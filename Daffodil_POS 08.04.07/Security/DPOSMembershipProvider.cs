using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Configuration.Provider;
//using System.Security.Principal;
//using System.Security.Permissions;
using System.Globalization;
//using System.Runtime.Serialization;
using System.Web;
using System.Web.Hosting;
using System.Web.Security;
using System.Web.Configuration;
using System.Web.DataAccess;
using System.Web.Management;
using System.Web.Util;
using System.ComponentModel;
using DSL.POS.Common.Utility;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;


//using Microsof.SharePoint.Dsp;


namespace DSL.Common.Security
{
    /// <summary>
    /// Summary description for DPOSMembershipProvider
    /// </summary>
    public class DPOSMembershipProvider : MembershipProvider
    {
                
        private const int SALT_SIZE_IN_BYTES = 16;

        ////////////////////////////////////////////////////////////
        // Public properties

        public override bool EnablePasswordRetrieval { get { return _EnablePasswordRetrieval; } }

        public override bool EnablePasswordReset { get { return _EnablePasswordReset; } }

        public override bool RequiresQuestionAndAnswer { get { return _RequiresQuestionAndAnswer; } }

        public override bool RequiresUniqueEmail { get { return _RequiresUniqueEmail; } }

        public override MembershipPasswordFormat PasswordFormat { get { return _PasswordFormat; } }

        public override int MaxInvalidPasswordAttempts { get { return _MaxInvalidPasswordAttempts; } }
        public override int PasswordAttemptWindow { get { return _PasswordAttemptWindow; } }

        public override int MinRequiredPasswordLength
        {
            get { return _MinRequiredPasswordLength; }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { return _MinRequiredNonalphanumericCharacters; }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { return _PasswordStrengthRegularExpression; }
        }

        public override string ApplicationName
        {
            get { return _AppName; }
            set
            {
                if (_AppName != value)
                {
                    _ApplicationId = 0;
                    _AppName = value;
                }
            }
        }

        private bool _EnablePasswordRetrieval;
        private bool _EnablePasswordReset;
        private bool _RequiresQuestionAndAnswer;
        private string _AppName;
        private bool _RequiresUniqueEmail;
        private string _DatabaseFileName;
        private string _ConnectionString;
        private string _HashAlgorithmType;
        private int _ApplicationId = 0;
        private int _MaxInvalidPasswordAttempts;
        private int _PasswordAttemptWindow;
        private int _MinRequiredPasswordLength;
        private int _MinRequiredNonalphanumericCharacters;
        private string _PasswordStrengthRegularExpression;
        private DateTime _ApplicationIDCacheDate;
        private MembershipPasswordFormat _PasswordFormat;

        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////

        public override void Initialize(string name, NameValueCollection config)
        {
            if (config == null)
                throw new ArgumentNullException("config");
            if (String.IsNullOrEmpty(name))
                name = "DPOSMembershipProvider";
            if (string.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "DPOS Membership Provider");
            }


            base.Initialize(name, config);

            _EnablePasswordRetrieval = SecurityUnitlity.GetBooleanValue(config, "enablePasswordRetrieval", false);
            _EnablePasswordReset = SecurityUnitlity.GetBooleanValue(config, "enablePasswordReset", true);
            _RequiresQuestionAndAnswer = SecurityUnitlity.GetBooleanValue(config, "requiresQuestionAndAnswer", true);
            _RequiresUniqueEmail = SecurityUnitlity.GetBooleanValue(config, "requiresUniqueEmail", true);
            _MaxInvalidPasswordAttempts = SecurityUnitlity.GetIntValue(config, "maxInvalidPasswordAttempts", 5, false, 0);
            _PasswordAttemptWindow = SecurityUnitlity.GetIntValue(config, "passwordAttemptWindow", 10, false, 0);
            _MinRequiredPasswordLength = SecurityUnitlity.GetIntValue(config, "minRequiredPasswordLength", 7, false, 128);
            _MinRequiredNonalphanumericCharacters = SecurityUnitlity.GetIntValue(config, "minRequiredNonalphanumericCharacters", 1, true, 128);

            _HashAlgorithmType = config["hashAlgorithmType"];
            if (String.IsNullOrEmpty(_HashAlgorithmType))
            {
                _HashAlgorithmType = "SHA1";
            }

            _PasswordStrengthRegularExpression = config["passwordStrengthRegularExpression"];
            if (_PasswordStrengthRegularExpression != null)
            {
                _PasswordStrengthRegularExpression = _PasswordStrengthRegularExpression.Trim();
                if (_PasswordStrengthRegularExpression.Length != 0)
                {
                    try
                    {
                        Regex regex = new Regex(_PasswordStrengthRegularExpression);
                    }
                    catch (ArgumentException e)
                    {
                        throw new ProviderException(e.Message, e);
                    }
                }
            }
            else
            {
                _PasswordStrengthRegularExpression = string.Empty;
            }

            _AppName = config["applicationName"];
            if (string.IsNullOrEmpty(_AppName))
                _AppName = SecurityUnitlity.GetDefaultAppName();

            if (_AppName.Length > 255)
            {
                throw new ProviderException("Provider application name is too long, max length is 255.");
            }

            string strTemp = config["passwordFormat"];
            if (strTemp == null)
                strTemp = "Hashed";

            switch (strTemp)
            {
                case "Clear":
                    _PasswordFormat = MembershipPasswordFormat.Clear;
                    break;
                case "Encrypted":
                    _PasswordFormat = MembershipPasswordFormat.Encrypted;
                    break;
                case "Hashed":
                    _PasswordFormat = MembershipPasswordFormat.Hashed;
                    break;
                default:
                    throw new ProviderException("Bad password format");
            }

            if (_PasswordFormat == MembershipPasswordFormat.Hashed && _EnablePasswordRetrieval)
                throw new ProviderException("Provider cannot retrieve hashed password");

            _ConnectionString = config["Constring"];
            _ConnectionString = ConfigurationManager.ConnectionStrings[0].ToString();// config["connectionString"];
            if (_ConnectionString == null || _ConnectionString.Length < 1)
                throw new ProviderException("Connection name not specified");


            //string temp = AccessConnectionHelper.GetFileNameFromConnectionName(_ConnectionString, true);
            //if (temp == null || temp.Length <  1)
            //    throw new ProviderException("Connection string not found: " + _ConnectionString);
            //_ConnectionString = temp;



            config.Remove("connectionStringName");
            config.Remove("enablePasswordRetrieval");
            config.Remove("enablePasswordReset");
            config.Remove("requiresQuestionAndAnswer");
            config.Remove("applicationName");
            config.Remove("requiresUniqueEmail");
            config.Remove("maxInvalidPasswordAttempts");
            config.Remove("passwordAttemptWindow");
            config.Remove("passwordFormat");
            config.Remove("name");
            config.Remove("description");
            config.Remove("minRequiredPasswordLength");
            config.Remove("minRequiredNonalphanumericCharacters");
            config.Remove("passwordStrengthRegularExpression");
            config.Remove("hashAlgorithmType");
            if (config.Count > 0)
            {
                string attribUnrecognized = config.GetKey(0);
                if (!String.IsNullOrEmpty(attribUnrecognized))
                    throw new ProviderException("Provider unrecognized attribute: " + attribUnrecognized);
            }
        }

        private string GenerateSalt()
        {
            byte[] buf = new byte[SALT_SIZE_IN_BYTES];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        private string EncodePassword(string pass, int passwordFormat, string salt)
        {
            if (passwordFormat == 0) // MembershipPasswordFormat.Clear
                return pass;

            byte[] bIn = Encoding.Unicode.GetBytes(pass);
            byte[] bSalt = Convert.FromBase64String(salt);
            byte[] bAll = new byte[bSalt.Length + bIn.Length];
            byte[] bRet = null;

            Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
            Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);
            if (passwordFormat == 1)
            { // MembershipPasswordFormat.Hashed
                HashAlgorithm s = HashAlgorithm.Create(_HashAlgorithmType);

                // If the hash algorithm is null (and came from config), throw a config exception
                if (s == null)
                {
                    throw new ProviderException("Could not create a hash algorithm");
                }
                bRet = s.ComputeHash(bAll);
            }
            else
            {
                bRet = EncryptPassword(bAll);
            }

            return Convert.ToBase64String(bRet);
        }

        private string UnEncodePassword(string pass, int passwordFormat)
        {
            switch (passwordFormat)
            {
                case 0: // MembershipPasswordFormat.Clear:
                    return pass;
                case 1: // MembershipPasswordFormat.Hashed:
                    throw new ProviderException("Provider can not decode hashed password");
                default:
                    byte[] bIn = Convert.FromBase64String(pass);
                    byte[] bRet = DecryptPassword(bIn);
                    if (bRet == null)
                        return null;
                    return Encoding.Unicode.GetString(bRet, SALT_SIZE_IN_BYTES, bRet.Length - SALT_SIZE_IN_BYTES);
            }
        }

        ////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////

        public override MembershipUser CreateUser(string username,
                                                   string password,
                                                   string email,
                                                   string passwordQuestion,
                                                   string passwordAnswer,
                                                   bool isApproved,
                                                   object userId,
                                                   out    MembershipCreateStatus status)
        {
            if (!SecurityUnitlity.ValidateParameter(ref password, true, true, false, 0))
            {
                status = MembershipCreateStatus.InvalidPassword;
                return null;
            }

            string salt = GenerateSalt();
            string pass = EncodePassword(password, (int)_PasswordFormat, salt);

            if (pass.Length > 128)
            {
                status = MembershipCreateStatus.InvalidPassword;
                return null;
            }

            if (!SecurityUnitlity.ValidateParameter(ref username, true, true, true, 255))
            {
                status = MembershipCreateStatus.InvalidUserName;
                return null;
            }

            SqlConnection objMycon = new SqlConnection();
            //bool fBeginTransCalled = false;



            try
            {
                objMycon.ConnectionString = _ConnectionString;

                SqlCommand objCmd = new SqlCommand();
                objCmd.Connection = objMycon;
                objCmd.CommandText = "Select UserName from UserInfo where UserName=@UserName";
                objCmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50));
                objCmd.Parameters["@UserName"].Value = username;
                objMycon.Open();
                SqlDataReader ds = objCmd.ExecuteReader();

                if (ds.Read())
                {
                    ds.Close();
                    objCmd.Dispose();
                    objMycon.Close();
                    status = MembershipCreateStatus.DuplicateUserName;
                    return null;
                }

                ds.Close();
                objCmd.CommandText = "INSERT INTO UserInfo(UserName, UserPassword, PasswordFormat, " +
                                "PasswordSalt, LastLoginDate, LastPasswordChangedDate, CreateDate,Createdby)" +
                                " VALUES (@UserName, @UserPassword, @PasswordFormat,@PasswordSalt, @LastLoginDate, " +
                                "@LastPasswordChangedDate, @CreateDate,@Createdby)";



                int pFormat = (int)_PasswordFormat;
                objCmd.Parameters.Add(new SqlParameter("@SUserName", SqlDbType.NVarChar, 50));
                objCmd.Parameters.Add(new SqlParameter("@UserPassword", SqlDbType.NVarChar, 128));
                objCmd.Parameters.Add(new SqlParameter("@PasswordFormat", SqlDbType.Int, 4));
                objCmd.Parameters.Add(new SqlParameter("@PasswordSalt", SqlDbType.NVarChar, 128));
                objCmd.Parameters.Add(new SqlParameter("@LastLoginDate", SqlDbType.DateTime ,8));
                objCmd.Parameters.Add(new SqlParameter("@LastPasswordChangedDate", SqlDbType.DateTime, 8));
                objCmd.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 8));
                objCmd.Parameters.Add(new SqlParameter("@Createdby", SqlDbType.UniqueIdentifier, 16));

                objCmd.Parameters["@SUserName"].Value = username;
                objCmd.Parameters["@UserPassword"].Value = pass;
                objCmd.Parameters["@PasswordFormat"].Value = pFormat;
                objCmd.Parameters["@PasswordSalt"].Value = salt;
                objCmd.Parameters["@LastLoginDate"].Value = DateTime.Now;
                objCmd.Parameters["@LastPasswordChangedDate"].Value = DateTime.Now;
                objCmd.Parameters["@CreateDate"].Value = DateTime.Now;
                objCmd.Parameters["@Createdby"].Value = Guid.NewGuid();

                if (objCmd.ExecuteNonQuery() != 1)
                {
                    objCmd.Dispose();
                    objMycon.Close();

                    status = MembershipCreateStatus.ProviderError;
                    return null;
                }

                status = MembershipCreateStatus.Success;
                return new MembershipUser(this.Name, username, null, String.Empty, String.Empty, String.Empty, true, false,
                                          DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now);

            }


            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                objMycon.Close();
            }
        }


        //public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        //{

        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        //public override string GetPassword(string username, string passwordAnswer)
        //{

        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //public override bool ChangePassword(string username, string oldPassword, string newPassword)
        //{
        //    SecurityUnitlity.CheckParameter(ref username, true, true, true, 255, "username");
        //    SecurityUnitlity.CheckParameter(ref oldPassword, true, true, false, 128, "oldPassword");
        //    SecurityUnitlity.CheckParameter(ref newPassword, true, true, false, 128, "newPassword");

        //    string salt = GenerateSalt();
        //    string pass = EncodePassword(newPassword, (int)_PasswordFormat, salt);
        //    if (pass.Length > 128)
        //        throw new ArgumentException("Membership password too long, max is 128");


        //    SqlConnection ObjMy = new SqlConnection();
        //    try
        //        {
        //            int status = 0;

        //            // Step 1: Make sure user exists


        //            ////////////////////////////////////////////////////////////
        //            // Step 2: Make sure oldPassword is correct
        //            //if (!CheckPassword(connection, userId, oldPassword, out status))
        //            //{
        //            //    return false;
        //            //}

        //            ////////////////////////////////////////////////////////////
        //            // Step 3: Save new password
        //            command = new SqlCommand(@"UPDATE aspnet_Membership " +
        //                                        @"SET [Password] = @Pass, PasswordFormat = @PasswordFormat, PasswordSalt = @PasswordSalt, LastPasswordChangedDate = @LastPasswordChangedDate " +
        //                                        @"WHERE UserId = @UserId",
        //                                       connection);

        //            int pFormat = (int)_PasswordFormat;
        //            command.Parameters.Add(new SqlParameter("@Pass", pass));
        //            command.Parameters.Add(new SqlParameter("@PasswordFormat", pFormat));
        //            command.Parameters.Add(new SqlParameter("@PasswordSalt", salt));
        //            command.Parameters.Add(CreateDateTimeOleDbParameter("@LastPasswordChangedDate", DateTime.Now));
        //            command.Parameters.Add(new SqlParameter("@UserId", userId));

        //            if (command.ExecuteNonQuery() != 1)
        //            {
        //                throw new ProviderException(GetExceptionText(100));
        //            }
        //            return true;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        public override string ResetPassword(string username, string passwordAnswer)
        {
            if (!EnablePasswordReset)
                throw new NotSupportedException("Not configured to support password resets");

            SecurityUnitlity.CheckParameter(ref username, true, true, true, 255, "username");
            SecurityUnitlity.CheckParameter(ref passwordAnswer, RequiresQuestionAndAnswer, RequiresQuestionAndAnswer, false, 128, "passwordAnswer");

            string salt = GenerateSalt();
            string newPassword = GeneratePassword();
            string pass = EncodePassword(newPassword, (int)_PasswordFormat, salt);

            //SqlConnection Objmycon = new SqlConnection();
            //Objmycon.ConnectionString = _ConnectionString;
            
            DSLConnectionHolder holder = DSLConnectionHelper.GetConnection(_DatabaseFileName, true);
            SqlConnection connection = holder.Connection;
            SqlDataReader reader = null;
            try
            {
                try
                {
                    int appId = GetAppplicationId(holder);
                    Guid userId = DSLConnectionHelper.GetUserID(connection, appId, username, false);
                    SqlCommand command;

                    ////////////////////////////////////////////////////////////
                    // Step 1: Make sure user exists
                    if (userId.ToString() == "00000000-0000-0000-0000-000000000000")
                    {
                        throw new ProviderException(GetExceptionText(1));
                    }

                    ////////////////////////////////////////////////////////////
                    // Step 2: Check passwordAnswer
                    if (RequiresQuestionAndAnswer)
                    {
                        command = new SqlCommand(@"SELECT PasswordAnswer " +
                                                    @"FROM aspnet_Membership " +
                                                    @"WHERE UserId = @UserId",
                                                    connection);
                        command.Parameters.Add(new SqlParameter("@UserId", userId));
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        { // No passwordAnswer!
                            throw new MembershipPasswordException(GetExceptionText(3));
                        }
                        string storedPasswordAnswer = GetNullableString(reader, 0);
                        if (storedPasswordAnswer == null || String.Compare(storedPasswordAnswer, passwordAnswer, true, CultureInfo.InvariantCulture) != 0)
                        {
                            throw new MembershipPasswordException(GetExceptionText(3));
                        }
                    }

                    ////////////////////////////////////////////////////////////
                    // Step 3: Save new password
                    command = new SqlCommand(@"UPDATE aspnet_Membership " +
                                                @"SET [Password] = @Pass, PasswordFormat = @PasswordFormat, PasswordSalt = @PasswordSalt, LastPasswordChangedDate = @LastPasswordChangedDate " +
                                                @"WHERE UserId = @UserId",
                                               connection);
                    int pFormat = (int)_PasswordFormat;
                    command.Parameters.Add(new SqlParameter("@Pass", pass));
                    command.Parameters.Add(new SqlParameter("@PasswordFormat", pFormat));
                    command.Parameters.Add(new SqlParameter("@PasswordSalt", salt));
                    command.Parameters.Add(CreateDateTimeOleDbParameter("@LastPasswordChangedDate", DateTime.Now));
                    command.Parameters.Add(new SqlParameter("@UserId", userId));

                    if (command.ExecuteNonQuery() != 1)
                    {
                        throw new ProviderException(GetExceptionText(100));
                    }
                    return newPassword;
                }
                catch (Exception e)
                {
                    throw DSLConnectionHelper.GetBetterException(e, holder);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                    holder.Close();
                }
            }
            catch
            {
                throw;
            }
        }

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        //public override void UpdateUser(MembershipUser user)
        //{
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException("user");
        //    }

        //    string temp = user.UserName;
        //    SecurityUnitlity.CheckParameter(ref temp, true, true, false, 255, "UserName");
        //    temp = user.Email;
        //    SecurityUnitlity.CheckParameter(ref temp, RequiresUniqueEmail, RequiresUniqueEmail, false, 128, "Email");
        //    user.Email = temp;

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    bool fBeginTransCalled = false;

        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            int userId = AccessConnectionHelper.GetUserID(connection, appId, user.UserName, false);
        //            SqlCommand command;
        //            object result;

        //            ////////////////////////////////////////////////////////////
        //            // Step 1: Make sure user exists
        //            if (userId == 0)
        //            {
        //                throw new ProviderException(GetExceptionText(1));
        //            }
        //            command = new SqlCommand(@"SELECT UserId FROM aspnet_Membership WHERE UserId = @UserId", connection);
        //            command.Parameters.Add(new SqlParameter("@UserId", userId));

        //            result = command.ExecuteScalar();
        //            if (result == null || !(result is int))
        //            {
        //                throw new ProviderException(GetExceptionText(1));
        //            }

        //            ////////////////////////////////////////////////////////////
        //            // Step 2: Make sure email is unique

        //            if (_RequiresUniqueEmail)
        //            {
        //                command = new SqlCommand(@"SELECT u.UserId " +
        //                                            @"FROM aspnet_Membership m, aspnet_Users u " +
        //                                            @"WHERE u.UserId <> @UserId AND m.Email = @Email AND u.UserId = m.UserId AND u.ApplicationId = @AppId",
        //                                            connection);
        //                command.Parameters.Add(new SqlParameter("@UserId", userId));
        //                command.Parameters.Add(new SqlParameter("@Email", user.Email));
        //                command.Parameters.Add(new SqlParameter("@AppId", appId));

        //                result = command.ExecuteScalar();
        //                if (result != null && (result is int))
        //                {
        //                    int userId2 = (int)result;
        //                    if (userId2 != userId)
        //                    {
        //                        throw new ProviderException("Dup user id: " + userId2.ToString(CultureInfo.InvariantCulture));
        //                    }
        //                }
        //            }

        //            ////////////////////////////////////////////////////////////
        //            // Step 3: Update table

        //            //
        //            // Start transaction
        //            //

        //            command = new SqlCommand("BEGIN TRANSACTION", connection);
        //            command.ExecuteNonQuery();
        //            fBeginTransCalled = true;

        //            command = new SqlCommand(@"UPDATE aspnet_Membership " +
        //                                        @"SET Email = @Email, Comment = @Comment, LastLoginDate = @LastLoginDate, IsApproved = @IsApproved " +
        //                                        @"WHERE UserId = @UserId",
        //                                        connection);
        //            int isapp = user.IsApproved ? 1 : 0;
        //            string comm = (user.Comment == null) ? String.Empty : user.Comment;

        //            command.Parameters.Add(CreateOleDbParam("@Email", OleDbType.BSTR, user.Email));
        //            command.Parameters.Add(new SqlParameter("@Comment", comm));
        //            command.Parameters.Add(CreateDateTimeOleDbParameter("@LastLoginDate", user.LastLoginDate));
        //            command.Parameters.Add(new SqlParameter("@IsApproved", isapp));
        //            command.Parameters.Add(new SqlParameter("@UserId", userId));

        //            if (command.ExecuteNonQuery() != 1)
        //            {
        //                throw new ProviderException(GetExceptionText(20));
        //            }

        //            command = new SqlCommand(@"UPDATE aspnet_Users SET LastActivityDate = @LastActivityDate WHERE UserId = @UserId", connection);
        //            command.Parameters.Add(CreateDateTimeOleDbParameter("@LastActivityDate", user.LastActivityDate));
        //            command.Parameters.Add(new SqlParameter("@UserId", userId));

        //            command.ExecuteNonQuery();

        //            //
        //            // End transaction
        //            //

        //            command = new SqlCommand("COMMIT TRANSACTION", connection);
        //            command.ExecuteNonQuery();
        //            fBeginTransCalled = false;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            if (fBeginTransCalled)
        //            {
        //                try
        //                {
        //                    SqlCommand cmd = new SqlCommand("ROLLBACK TRANSACTION",
        //                                                         connection);
        //                    cmd.ExecuteNonQuery();
        //                }
        //                catch { }
        //            }

        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        public override bool ValidateUser(string username, string password)
        {
            if (!SecurityUnitlity.ValidateParameter(ref username,
                                               true,
                                               true,
                                               false,
                                               255))
            {
                return false;
            }

            if (!SecurityUnitlity.ValidateParameter(ref password,
                                               true,
                                               true,
                                               false,
                                               128))
            {
                return false;
            }

            SqlConnection Objmycon = new SqlConnection();
            Guid userId = Guid.NewGuid();// "00000000-0000-0000-0000-000000000000";

            //1. Get User ID by Opening a Data Reader.
            try
            {
                
                Objmycon.ConnectionString = _ConnectionString;
                SqlCommand objCmd = new SqlCommand();
                objCmd.Connection = Objmycon;
                objCmd.CommandText = "Select UserID from UserInfo where UserName=@UserName";
                objCmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50));
                objCmd.Parameters["@UserName"].Value = username;
                Objmycon.Open();
                SqlDataReader Reader = objCmd.ExecuteReader();

                if (Reader.Read())
                {
                    userId = (Guid)Reader[0];
                }

                Reader.Close();


                //bool userIsApproved = false;
                if (CheckPassword(Objmycon, userId, password))//, out userIsApproved) && userIsApproved)
                //if (CheckPassword(Objmycon, userId, password, out userIsApproved) && userIsApproved)
                {
                    SqlCommand command;

                    //
                    // Start transaction
                    //

                    //command = new SqlCommand("BEGIN TRANSACTION", connection);
                    //command.ExecuteNonQuery();
                    //fBeginTransCalled = true;

                    command = new SqlCommand(@"UPDATE  UserInfo " +
                                                @"SET     LastLoginDate = @LastLoginDate " +
                                                @"WHERE   UserID = @UserID",
                                           Objmycon);

                    command.Parameters.Add(CreateDateTimeOleDbParameter("@LastLoginDate", DateTime.Now));
                    command.Parameters.Add(new SqlParameter("@UserID", userId));
                    command.ExecuteNonQuery();
                                

                    ////// Retrieving data in cookies 
                    ////if (Request.Cookies["DPOS"] != null)
                    ////{
                    ////    string strBoothID = "";

                    ////    if (Request.Cookies["DPOS"]["BoothNo"] != null)
                    ////    {
                    ////        strBoothID = Request.Cookies["DPOS"]["BoothNo"];

                    ////        Guid BoothID = Guid.NewGuid();
                    ////        BoothInfoDTO dto = new BoothInfoDTO();
                    ////        // populate dto

                    ////        Facade facade = Facade.GetInstance();

                    ////        // PK keep in local variable 
                    ////        BoothID = (Guid)TypeDescriptor.GetConverter(BoothID).ConvertFromString(strBoothID);

                    ////        //  Get the Booth Information Corresponding Booth No. and keep Booth Info Domain Object
                    ////        dto = facade.getBoothInfo_AllDTO(BoothID);

                    ////        //strBranchName = dto.BranchCode.BranchName;
                    ////        //strBrnachType = dto.BranchCode.BranchTypeInfoDTO.BT_Name;
                    ////        //strBranchAddress = dto.BranchCode.BranchAddress;
                    ////        //strPhone = dto.BranchCode.Telephone1 + "," + dto.BranchCode.Telephone2 + "," + dto.BranchCode.Telephone3;
                    ////        //strEmail = dto.BranchCode.EMail;
                    ////    }
                    ////}

                    //command = new SqlCommand(@"UPDATE  aspnet_Users " +
                    //                            @"SET     LastActivityDate = @LastActivityDate " +
                    //                            @"WHERE   UserId = @UserId", connection);
                    //command.Parameters.Add(CreateDateTimeOleDbParameter("@LastActivityDate", DateTime.Now));
                    //command.Parameters.Add(new SqlParameter("@UserId", userId));
                    //command.ExecuteNonQuery();

                    //
                    // End transaction
                    //

                    //command = new SqlCommand("COMMIT TRANSACTION", connection);
                    //command.ExecuteNonQuery();
                    //fBeginTransCalled = false;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;//AccessConnectionHelper.GetBetterException(e, holder);
            }

        }

        //public override bool UnlockUser(string userName)
        //{
        //    return false;
        //}

        //public override MembershipUser GetUser(object userId, bool userIsOnline)
        //{
        //    return null;
        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        //public override MembershipUser GetUser(string username, bool userIsOnline)
        //{
        //    SecurityUnitlity.CheckParameter(
        //                    ref username,
        //                    true,
        //                    false,
        //                    true,
        //                    255,
        //                    "username");

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    OleDbDataReader reader = null;

        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            SqlCommand command;

        //            command = new SqlCommand(@"SELECT Email, PasswordQuestion, Comment, CreateDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, u.UserId, IsApproved " +
        //                                        @"FROM aspnet_Users u, aspnet_Membership m " +
        //                                        @"WHERE u.ApplicationId = @AppId  AND u.UserName = @UserName AND u.UserId = m.UserId",
        //                                       connection);

        //            command.Parameters.Add(new SqlParameter("@AppId", appId));
        //            command.Parameters.Add(new SqlParameter("@UserName", username));

        //            reader = command.ExecuteReader();
        //            if (!reader.Read())
        //            {
        //                return null;
        //            }

        //            string email = GetNullableString(reader, 0);
        //            string passwordQuestion = GetNullableString(reader, 1);
        //            string comment = GetNullableString(reader, 2);
        //            DateTime dtCreate = reader.GetDateTime(3);
        //            DateTime dtLastLogin = reader.GetDateTime(4);
        //            DateTime dtLastActivity = userIsOnline ? AccessConnectionHelper.RoundToSeconds(DateTime.Now)
        //                                                   : reader.GetDateTime(5);
        //            DateTime dtLastPassChange = reader.GetDateTime(6);
        //            int userId = reader.GetInt32(7);
        //            bool isApproved = reader.GetBoolean(8);

        //            if (userIsOnline)
        //            {
        //                command = new SqlCommand(@"UPDATE aspnet_Users " +
        //                                            @"SET LastActivityDate = @LastActivityDate " +
        //                                            @"WHERE UserId = @UserId",
        //                                           connection);
        //                command.Parameters.Add(CreateDateTimeOleDbParameter("@LastActivityDate", dtLastActivity));
        //                command.Parameters.Add(new SqlParameter("@UserId", userId));

        //                command.ExecuteNonQuery();
        //            }

        //            ////////////////////////////////////////////////////////////
        //            // Step 4 : Return the result
        //            return new MembershipUser(this.Name,
        //                                       username,
        //                                       userId,
        //                                       email,
        //                                       passwordQuestion,
        //                                       comment,
        //                                       isApproved,
        //                                       false,
        //                                       dtCreate,
        //                                       dtLast,
        //
        //                                       dtLastActivity,
        //                                       dtLastPassChange,
        //                                       DateTime.MinValue);
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            if (reader != null)
        //                reader.Close();
        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        //public override string GetUserNameByEmail(string email)
        //{
        //    SecurityUnitlity.CheckParameter(
        //                    ref email,
        //                    false,
        //                    false,
        //                    false,
        //                    128,
        //                    "email");

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            SqlCommand command = null;
        //            OleDbDataReader reader = null;
        //            string username = null;

        //            if (email != null)
        //            {
        //                command = new SqlCommand(@"SELECT UserName " +
        //                                           @"FROM aspnet_users u, aspnet_Membership m " +
        //                                           @"WHERE m.Email = @Email AND u.UserId = m.UserId AND u.ApplicationId = @AppId",
        //                                           connection);
        //                command.Parameters.Add(CreateOleDbParam("@Email", OleDbType.BSTR, email));
        //                command.Parameters.Add(new SqlParameter("@AppId", appId));
        //            }
        //            else
        //            {
        //                command = new SqlCommand(@"SELECT UserName " +
        //                                           @"FROM aspnet_users u, aspnet_Membership m " +
        //                                           @"WHERE m.Email IS NULL AND u.UserId = m.UserId AND u.ApplicationId = @AppId",
        //                                           connection);
        //                command.Parameters.Add(new SqlParameter("@AppId", appId));
        //            }

        //            try
        //            {
        //                reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
        //                if (reader.Read())
        //                {
        //                    username = GetNullableString(reader, 0);
        //                    if (RequiresUniqueEmail && reader.Read())
        //                    {
        //                        throw new ProviderException("Cannot have more than one user with the same email");
        //                    }
        //                }
        //                return username;
        //            }
        //            catch
        //            {
        //                throw;
        //            }
        //            finally
        //            {
        //                if (reader != null)
        //                    reader.Close();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        //public override bool DeleteUser(string username, bool deleteAllRelatedData)
        //{
        //    SecurityUnitlity.CheckParameter(ref username, true, true, true, 255, "username");

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    bool fBeginTransCalled = false;

        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            int userId = AccessConnectionHelper.GetUserID(connection, appId, username, false);

        //            if (userId == 0)
        //                return false; // User not found
        //            SqlCommand command;

        //            //
        //            // Start transaction
        //            //

        //            command = new SqlCommand("BEGIN TRANSACTION", connection);
        //            command.ExecuteNonQuery();
        //            fBeginTransCalled = true;

        //            command = new SqlCommand(@"DELETE FROM aspnet_Membership WHERE UserId = @UserId", connection);
        //            command.Parameters.Add(new SqlParameter("@UserId", userId));

        //            bool returnValue = (command.ExecuteNonQuery() == 1);
        //            if (deleteAllRelatedData)
        //            {
        //                command = new SqlCommand(@"DELETE FROM aspnet_UsersInRoles WHERE UserId = @UserId", connection);
        //                command.Parameters.Add(new SqlParameter("@UserId", userId));
        //                command.ExecuteNonQuery();

        //                command = new SqlCommand(@"DELETE FROM aspnet_Profile WHERE UserId = @UserId", connection);
        //                command.Parameters.Add(new SqlParameter("@UserId", userId));
        //                command.ExecuteNonQuery();

        //                command = new SqlCommand(@"DELETE FROM aspnet_PagePersonalizationPerUser WHERE UserId = @UserId", connection);
        //                command.Parameters.Add(new SqlParameter("@UserId", userId));
        //                command.ExecuteNonQuery();

        //                command = new SqlCommand(@"DELETE FROM aspnet_Users WHERE UserId = @UserId", connection);
        //                command.Parameters.Add(new SqlParameter("@UserId", userId));
        //                returnValue = (command.ExecuteNonQuery() == 1);
        //            }

        //            //
        //            // End transaction
        //            //

        //            command = new SqlCommand("COMMIT TRANSACTION", connection);
        //            command.ExecuteNonQuery();
        //            fBeginTransCalled = false;

        //            return returnValue;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            if (fBeginTransCalled)
        //            {
        //                try
        //                {
        //                    SqlCommand cmd = new SqlCommand("ROLLBACK TRANSACTION",
        //                                                         connection);
        //                    cmd.ExecuteNonQuery();
        //                }
        //                catch { }
        //            }

        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////


        //public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        //{
        //    if (pageIndex < 0)
        //        throw new ArgumentException("PageIndex cannot be negative");
        //    if (pageSize < 1)
        //        throw new ArgumentException("PageSize must be positive");

        //    long lBound = (long)pageIndex * pageSize;
        //    long uBound = lBound + pageSize - 1;

        //    if (uBound > System.Int32.MaxValue)
        //    {
        //        throw new ArgumentException("PageIndex too big");
        //    }

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    OleDbDataReader reader = null;
        //    long recordCount = 0;
        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            SqlCommand command;
        //            MembershipUserCollection users = new MembershipUserCollection();

        //            command = new SqlCommand(@"SELECT UserName, Email, PasswordQuestion, Comment, CreateDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, IsApproved, u.UserId " +
        //                                       @"FROM  aspnet_Membership m, aspnet_Users u " +
        //                                       @"WHERE  u.ApplicationId = @AppId AND u.UserId = m.UserId " +
        //                                       @"ORDER BY UserName",
        //                          connection);
        //            command.Parameters.Add(new SqlParameter("@AppId", appId));

        //            reader = command.ExecuteReader(CommandBehavior.SequentialAccess);

        //            while (reader.Read())
        //            {
        //                recordCount++;
        //                if (recordCount - 1 < lBound || recordCount - 1 > uBound)
        //                    continue;
        //                string username, email, passwordQuestion, comment;
        //                DateTime dtCreate, dtLastLogin, dtLastActivity, dtLastPassChange;
        //                bool isApproved;
        //                int userId;
        //                username = GetNullableString(reader, 0);
        //                email = GetNullableString(reader, 1);
        //                passwordQuestion = GetNullableString(reader, 2);
        //                comment = GetNullableString(reader, 3);
        //                dtCreate = reader.GetDateTime(4);
        //                dtLastLogin = reader.GetDateTime(5);
        //                dtLastActivity = reader.GetDateTime(6);
        //                dtLastPassChange = reader.GetDateTime(7);
        //                isApproved = reader.GetBoolean(8);
        //                userId = reader.GetInt32(9);
        //                users.Add(new MembershipUser(this.Name,
        //                                              username,
        //                                              userId,
        //                                              email,
        //                                              passwordQuestion,
        //                                              comment,
        //                                              isApproved,
        //                                              false,
        //                                              dtCreate,
        //                                              dtLastLogin,
        //                                              dtLastActivity,
        //                                              dtLastPassChange,
        //                                              DateTime.MinValue));
        //            }
        //            totalRecords = (int)recordCount;
        //            return users;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            if (reader != null)
        //                reader.Close();
        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////

        //public override int GetNumberOfUsersOnline()
        //{
        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            TimeSpan ts = new TimeSpan(0, Membership.UserIsOnlineTimeWindow, 0);
        //            DateTime dt = DateTime.Now.Subtract(ts);
        //            object result;
        //            SqlCommand command;

        //            command = new SqlCommand(@"SELECT COUNT(*) FROM aspnet_Users u, aspnet_Membership m WHERE u.UserId = m.UserId AND ApplicationId=@AppId AND LastActivityDate > @LastActivityDate",
        //                                       connection);

        //            command.Parameters.Add(new SqlParameter("@AppId", appId));
        //            command.Parameters.Add(CreateDateTimeOleDbParameter("@LastActivityDate", dt));
        //            result = command.ExecuteScalar();

        //            if (result != null && (result is int))
        //                return (int)result;
        //            else
        //                return 0;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            holder.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////

        //public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        //{
        //    SecurityUnitlity.CheckParameter(ref usernameToMatch, true, true, false, 255, "usernameToMatch");

        //    if (pageIndex < 0)
        //        throw new ArgumentException("PageIndex cannot be negative");
        //    if (pageSize < 1)
        //        throw new ArgumentException("PageSize must be positive");

        //    long lBound = (long)pageIndex * pageSize;
        //    long uBound = lBound + pageSize - 1;

        //    if (uBound > System.Int32.MaxValue)
        //    {
        //        throw new ArgumentException("PageIndex too big");
        //    }

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    OleDbDataReader reader = null;
        //    long recordCount = 0;
        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            SqlCommand command;
        //            MembershipUserCollection users = new MembershipUserCollection();

        //            command = new SqlCommand(@"SELECT UserName, Email, PasswordQuestion, Comment, CreateDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, IsApproved, u.UserId " +
        //                                        @"FROM  aspnet_Membership m, aspnet_Users u " +
        //                                        @"WHERE  u.ApplicationId = @AppId AND u.UserId = m.UserId AND " +
        //                                        @"UserName like @UserName " +
        //                                        @"ORDER BY UserName", connection);
        //            command.Parameters.Add(new SqlParameter("@AppId", appId));
        //            command.Parameters.Add(new SqlParameter("@UserName", usernameToMatch));
        //            reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
        //            while (reader.Read())
        //            {
        //                recordCount++;
        //                if (recordCount - 1 < lBound || recordCount - 1 > uBound)
        //                    continue;

        //                string username, email, passwordQuestion, comment;
        //                DateTime dtCreate, dtLastLogin, dtLastActivity, dtLastPassChange;
        //                bool isApproved;
        //                int userId;

        //                username = GetNullableString(reader, 0);
        //                email = GetNullableString(reader, 1);
        //                passwordQuestion = GetNullableString(reader, 2);
        //                comment = GetNullableString(reader, 3);
        //                dtCreate = reader.GetDateTime(4);
        //                dtLastLogin = reader.GetDateTime(5);
        //                dtLastActivity = reader.GetDateTime(6);
        //                dtLastPassChange = reader.GetDateTime(7);
        //                isApproved = reader.GetBoolean(8);
        //                userId = reader.GetInt32(9);
        //                users.Add(new MembershipUser(this.Name,
        //                                              username,
        //                                              userId,
        //                                              email,
        //                                              passwordQuestion,
        //                                              comment,
        //                                              isApproved,
        //                                              false,
        //                                              dtCreate,
        //                                              dtLastLogin,
        //                                              dtLastActivity,
        //                                              dtLastPassChange,
        //                                              DateTime.MinValue));
        //            }
        //            return users;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            if (reader != null)
        //                reader.Close();

        //            holder.Close();
        //            totalRecords = (int)recordCount;
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////
        //public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        //{
        //    SecurityUnitlity.CheckParameter(ref emailToMatch, false, false, false, 128, "emailToMatch");

        //    if (pageIndex < 0)
        //        throw new ArgumentException("PageIndex cannot be negative");
        //    if (pageSize < 1)
        //        throw new ArgumentException("PageSize must be positive");

        //    long lBound = (long)pageIndex * pageSize;
        //    long uBound = lBound + pageSize - 1;

        //    if (uBound > System.Int32.MaxValue)
        //    {
        //        throw new ArgumentException("PageIndex too big");
        //    }

        //    AccessConnectionHolder holder = AccessConnectionHelper.GetConnection(_ConnectionString, true);
        //    SqlConnection connection = holder.Connection;
        //    OleDbDataReader reader = null;
        //    long recordCount = 0;
        //    try
        //    {
        //        try
        //        {
        //            int appId = GetAppplicationId(holder);
        //            SqlCommand command;
        //            MembershipUserCollection users = new MembershipUserCollection();

        //            if (emailToMatch != null)
        //            {
        //                command = new SqlCommand(@"SELECT UserName, Email, PasswordQuestion, Comment, CreateDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, IsApproved, u.UserId "
        //                                        + @"FROM  aspnet_Membership m, aspnet_Users u " +
        //                                        @"WHERE  u.ApplicationId = @AppId AND u.UserId = m.UserId AND Email like @Email " + @"ORDER BY UserName", connection);
        //                command.Parameters.Add(new SqlParameter("@AppId", appId));
        //                command.Parameters.Add(new SqlParameter("@Email", emailToMatch));
        //            }
        //            else
        //            {
        //                command = new SqlCommand(@"SELECT UserName, Email, PasswordQuestion, Comment, CreateDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, IsApproved, u.UserId "
        //                                        + @"FROM  aspnet_Membership m, aspnet_Users u " +
        //                                        @"WHERE  u.ApplicationId = @AppId AND u.UserId = m.UserId AND Email IS NULL " + @"ORDER BY UserName", connection);
        //                command.Parameters.Add(new SqlParameter("@AppId", appId));
        //            }
        //            reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
        //            while (reader.Read())
        //            {
        //                recordCount++;
        //                if (recordCount - 1 < lBound || recordCount - 1 > uBound)
        //                    continue;

        //                string username, email, passwordQuestion, comment;
        //                DateTime dtCreate, dtLastLogin, dtLastActivity, dtLastPassChange;
        //                bool isApproved;
        //                int userId;

        //                username = GetNullableString(reader, 0);
        //                email = GetNullableString(reader, 1);
        //                passwordQuestion = GetNullableString(reader, 2);
        //                comment = GetNullableString(reader, 3);
        //                dtCreate = reader.GetDateTime(4);
        //                dtLastLogin = reader.GetDateTime(5);
        //                dtLastActivity = reader.GetDateTime(6);
        //                dtLastPassChange = reader.GetDateTime(7);
        //                isApproved = reader.GetBoolean(8);
        //                userId = reader.GetInt32(9);
        //                users.Add(new MembershipUser(this.Name,
        //                                              username,
        //                                              userId,
        //                                              email,
        //                                              passwordQuestion,
        //                                              comment,
        //                                              isApproved,
        //                                              false,
        //                                              dtCreate,
        //                                              dtLastLogin,
        //                                              dtLastActivity,
        //                                              dtLastPassChange,
        //                                              DateTime.MinValue));
        //            }
        //            return users;
        //        }
        //        catch (Exception e)
        //        {
        //            throw AccessConnectionHelper.GetBetterException(e, holder);
        //        }
        //        finally
        //        {
        //            if (reader != null)
        //                reader.Close();

        //            holder.Close();
        //            totalRecords = (int)recordCount;
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////
        private bool CheckPassword(SqlConnection connection, Guid userId, string password)
        {
            string salt;
            int passwordFormat;
            string pass = GetPasswordWithFormat(connection, userId, out passwordFormat, out salt);
            string pass2 = EncodePassword(password, passwordFormat, salt);
            return (pass == pass2);
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        //private bool CheckPassword(SqlConnection connection, int userId, string password, out bool userIsApproved)
        //{
        //    string salt;
        //    int passwordFormat, status;
        //    string pass = GetPasswordWithFormat(connection, userId, null, false, out passwordFormat, out status, out salt, out userIsApproved);
        //    string pass2 = EncodePassword(password, passwordFormat, salt);
        //    return (pass == pass2);
        //}

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        private string GetPasswordWithFormat(
                            SqlConnection connection,
                            Guid userId,
                            out int passwordFormat,
                            out string passwordSalt)
        {
            SqlCommand command;
            SqlDataReader reader;
            //string storedPasswordAnswer;
            string pass;

            passwordFormat = 0;
            //status = 1; // status = user not found
            passwordSalt = String.Empty;
            //userIsApproved = false;
            if (userId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                return null;
            }

            command = new SqlCommand(@"SELECT PasswordFormat, UserPassword, PasswordSalt " +
                                        @"FROM UserInfo WHERE UserId = @UserId", connection);
            command.Parameters.Add(new SqlParameter("@UserId", userId));

            reader = command.ExecuteReader();

            if (!reader.Read())
            { // Zero rows read = user-not-found
                reader.Close();
                return null;
            }
            else
                //userId = (Guid)reader[""];
                passwordFormat = reader.GetInt32(0);
            pass = GetNullableString(reader, 1);
            passwordSalt = GetNullableString(reader, 2);

            reader.Close();
            return pass;
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        private int GetAppplicationId(DSLConnectionHolder holder)
        {
            if (_ApplicationId != 0 && holder.CreateDate < _ApplicationIDCacheDate) // Already cached?
                return _ApplicationId;
            string appName = _AppName;
            if (appName.Length > 255)
                appName = appName.Substring(0, 255);
            _ApplicationId = DSLConnectionHelper.GetApplicationID(holder.Connection, appName, true);
            _ApplicationIDCacheDate = DateTime.Now;
            if (_ApplicationId != 0)
                return _ApplicationId;
            throw new ProviderException(GetExceptionText(20));
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        private string GetNullableString(SqlDataReader reader, int col)
        {
            if (reader.IsDBNull(col) == false)
            {
                return reader.GetString(col);
            }

            return null;
        }
        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        private string GetExceptionText(int status)
        {
            string key;
            switch (status)
            {
                case 0:
                    return String.Empty;
                case 1:
                    key = "User not found";
                    break;
                case 2:
                    key = "Wrong password";
                    break;
                case 3:
                    key = "Wrong answer";
                    break;
                case 4:
                    key = "Invalid password";
                    break;
                case 5:
                    key = "Invalid question";
                    break;
                case 6:
                    key = "Invalid answer";
                    break;
                case 7:
                    key = "Invalid email";
                    break;
                default:
                    key = "Unknown provider error";
                    break;
            }
            return key;
        }

        /////////////////////////////////////////////////////////////////////////////
        private bool IsStatusDueToBadPassword(int status)
        {
            return (status >= 2 && status <= 6);
        }
        private const int PASSWORD_SIZE = 14;
        public virtual string GeneratePassword()
        {
            return Membership.GeneratePassword(
                      MinRequiredPasswordLength < PASSWORD_SIZE ? PASSWORD_SIZE : MinRequiredPasswordLength,
                      MinRequiredNonAlphanumericCharacters);
        }


        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override string GetPassword(string username, string answer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        //public override string ResetPassword(string username, string answer)
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        public override bool UnlockUser(string userName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        //public override bool ValidateUser(string username, string password)
        //{
        //    return true;
        //}

        private SqlParameter CreateDateTimeOleDbParameter(string parameterName, DateTime dt)
        {
            SqlParameter p = new SqlParameter(parameterName, SqlDbType.DateTime);
            p.Direction = ParameterDirection.Input;
            p.Value = SecurityUnitlity.RoundToSeconds(dt);
            return p;
        }
    }
    //    /////////////////////////////////////////////////////////////////////////////
    //    /////////////////////////////////////////////////////////////////////////////
    //    private SqlParameter CreateOleDbParam(string paramName, OleDbType oledbType, object objValue)
    //    {

    //        SqlParameter param = new SqlParameter(paramName, oledbType);

    //        if (objValue == null)
    //        {
    //            param.IsNullable = true;
    //            param.Value = DBNull.Value;
    //        }
    //        else
    //        {
    //            param.Value = objValue;
    //        }

    //        return param;
    //    }
    //}
}