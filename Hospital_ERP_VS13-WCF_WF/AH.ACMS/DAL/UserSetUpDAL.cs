using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.ACMS.DAL
{
    public class UserSetUpDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
        string packageName = string.Empty;
        #region UserGroup
        #region GetsGrid
        public List<UserGroup> GetsUserGroups()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER_Group";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, "GRID",ParameterDirection.Input)
            };
            return GetsUserGroupDetails(packageName, parameterList);
        }
        private List<UserGroup> GetsUserGroupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<UserGroup> rDRSs = new List<UserGroup>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsUG(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        #region DataReaderMappingwithNUll
        private UserGroup MapObjectUG(NullHandler oReader)
        {
            UserGroup oDRS = new UserGroup();
            EntryParameter oEntryParameter = new EntryParameter();

            oDRS.GroupID = oReader.GetString("grp_id");
            oDRS.GroupTitle = oReader.GetString("grp_title");
            oDRS.GroupTitleBang = oReader.GetString("grp_title_beng");
            oDRS.Remarks = oReader.GetString("remarks");
            oDRS.Date = oReader.GetString("dt");

            oEntryParameter.Active = oReader.GetString("active");
            oEntryParameter.EntryBy = oReader.GetString("entry_by");
            oEntryParameter.EntryDate = Convert.ToDateTime(oReader.GetDateTime("entry_date").ToString("dd MMM yyyy"));
            oEntryParameter.EntryBy = oReader.GetString("update_by");
            oEntryParameter.EntryDate = Convert.ToDateTime(oReader.GetDateTime("update_date").ToString("dd MMM yyyy"));
            oEntryParameter.CompanyID = oReader.GetString("comp_id");
            oEntryParameter.LocationID = oReader.GetString("loc_id");
            oEntryParameter.MachineID = oReader.GetString("mac_id");
            oDRS.EntryParameter = oEntryParameter;
            return oDRS;
        }
        private UserGroup CreateObjectUG(NullHandler oReader)
        {
            UserGroup oDRS = new UserGroup();
            oDRS = MapObjectUG(oReader);
            return oDRS;
        }
        private List<UserGroup> CreateObjectsUG(IDataReader oReader)
        {
            List<UserGroup> rDRSs = new List<UserGroup>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                UserGroup oItem = CreateObjectUG(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion
        #region GetsUserGroupCbo
        public List<UserGroup> GetsUserGroupCbo()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER_Group";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, "COMBO",ParameterDirection.Input)
            };
            return GetsUserGroupDetailsCbo(packageName, parameterList);
        }
        private List<UserGroup> GetsUserGroupDetailsCbo(string packageName, OracleParameter[] parameterList)
        {
            List<UserGroup> rDRSs = new List<UserGroup>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsUGCbo(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        #region DataReaderMappingwithNUll
        private UserGroup MapObjectUGCbo(NullHandler oReader)
        {
            UserGroup oDRS = new UserGroup();
            oDRS.GroupID = oReader.GetString("grp_id");
            oDRS.GroupTitle = oReader.GetString("grp_title");
            return oDRS;
        }
        private UserGroup CreateObjectUGCbo(NullHandler oReader)
        {
            UserGroup oDRS = new UserGroup();
            oDRS = MapObjectUGCbo(oReader);
            return oDRS;
        }
        private List<UserGroup> CreateObjectsUGCbo(IDataReader oReader)
        {
            List<UserGroup> rDRSs = new List<UserGroup>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                UserGroup oItem = CreateObjectUGCbo(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion

        #region Save
        public UserGroup SaveUserGroup(UserGroup oUserGroupBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_USER_GRP";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, oUserGroupBO.GroupID,ParameterDirection.Input),
             new OracleParameter ("p_grp_title",OracleDbType.Varchar2,300,oUserGroupBO.GroupTitle,ParameterDirection.Input),
             new OracleParameter ("p_grp_title_beng",OracleDbType.Varchar2,300, oUserGroupBO.GroupTitleBang,ParameterDirection.Input),
             new OracleParameter ("p_remarks",OracleDbType.Varchar2,300,oUserGroupBO.Remarks,ParameterDirection.Input),
             new OracleParameter ("p_entry_by",OracleDbType.Varchar2,30,oUserGroupBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("p_comp_id",OracleDbType.Varchar2,20,oUserGroupBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("p_loc_id",OracleDbType.Varchar2,20,oUserGroupBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("p_mac_id",OracleDbType.Varchar2,20,oUserGroupBO.EntryParameter.MachineID,ParameterDirection.Input)
            };

            return SaveUserGroupDetails(packageName, parameterList);
        }
        public UserGroup SaveUserGroupDetails(string packageName, OracleParameter[] parameterList)
        {
            IDataReader reader = null;
            UserGroup oUserGroupBO = new UserGroup();

            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);
                EntryParameter oEntryParameter = new EntryParameter();
                oEntryParameter.ErrorMessage = "";
                oUserGroupBO.EntryParameter = oEntryParameter;
                if (reader.Read())
                {

                    oUserGroupBO = CreateObjectUG(oReader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                EntryParameter oEntryParameter = new EntryParameter();
                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                oUserGroupBO.EntryParameter = oEntryParameter;
            }
            return oUserGroupBO;
        }
        #endregion
        #region Edit
        public UserGroup EditUserGroup(UserGroup oUserGroupBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.EDIT_USER_GRP";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, oUserGroupBO.GroupID,ParameterDirection.Input),
             new OracleParameter ("p_group_title",OracleDbType.Varchar2,300, oUserGroupBO.GroupTitle,ParameterDirection.Input),
             new OracleParameter ("p_group_title_bangla",OracleDbType.Varchar2,300, oUserGroupBO.GroupTitleBang,ParameterDirection.Input),
             new OracleParameter ("p_group_remarks",OracleDbType.Varchar2,300, oUserGroupBO.Remarks,ParameterDirection.Input)
            };

            return SaveUserGroupDetails(packageName, parameterList);
        }
        #endregion
        #region Delete
        public UserGroup DeleteUserGroup(string groupid)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.DELETE_USER_GRP";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, groupid,ParameterDirection.Input)
            };

            return SaveUserGroupDetails(packageName, parameterList);
        }
        #endregion
        #endregion
        #region User
        #region GetsUser
        public List<User> GetsUser()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, "GRID",ParameterDirection.Input),             
            };
            return GetsUserDetails(packageName, parameterList);
        }
        private List<User> GetsUserDetails(string packageName, OracleParameter[] parameterList)
        {
            List<User> rDRSs = new List<User>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsUser(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        #endregion
        #region GetUsersCbo
        public List<User> GetUsersCbo()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_grp_id",OracleDbType.Varchar2,30, "COMBO",ParameterDirection.Input)
            };
            return GetUsersDetailsCbo(packageName, parameterList);
        }
        private List<User> GetUsersDetailsCbo(string packageName, OracleParameter[] parameterList)
        {
            List<User> rDRSs = new List<User>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsUCbo(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        #region DataReaderMappingwithNUll
        private User MapObjectUCbo(NullHandler oReader)
        {
            User oDRS = new User();
            oDRS.EmpID = oReader.GetString("EMP_ID");
            oDRS.NickName = oReader.GetString("Nick_Name");
            return oDRS;
        }
        private User CreateObjectUCbo(NullHandler oReader)
        {
            User oDRS = new User();
            oDRS = MapObjectUCbo(oReader);
            return oDRS;
        }
        private List<User> CreateObjectsUCbo(IDataReader oReader)
        {
            List<User> rDRSs = new List<User>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                User oItem = CreateObjectUCbo(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion
        #region SaveUser
        //
        public User EditUser(User oUserBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Update_USER";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, oUserBO.EmpID,ParameterDirection.Input),
             new OracleParameter ("P_NICK_NAME",OracleDbType.Varchar2,300, oUserBO.NickName,ParameterDirection.Input),
             new OracleParameter ("P_USER_PWD",OracleDbType.Varchar2,30,oUserBO.UserPassw,ParameterDirection.Input),
             new OracleParameter ("P_PIN_CODE",OracleDbType.Varchar2,30, oUserBO.PinCode,ParameterDirection.Input),
             new OracleParameter ("P_E_MAIL",OracleDbType.Varchar2,30,oUserBO.Email,ParameterDirection.Input),
             new OracleParameter ("P_USER_GRP",OracleDbType.Varchar2,30,oUserBO.UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("P_Q_ID",OracleDbType.Varchar2,30,oUserBO.SecurityQuestion.QID,ParameterDirection.Input),
             new OracleParameter ("P_ANS",OracleDbType.Varchar2,300,oUserBO.SecurityQuestion.Answer,ParameterDirection.Input),
             new OracleParameter ("P_REMARKS",OracleDbType.Varchar2,300,oUserBO.Remarks,ParameterDirection.Input),
             new OracleParameter ("P_ValidUpto",OracleDbType.Varchar2,30,oUserBO.ValidUpto,ParameterDirection.Input),
             new OracleParameter ("P_ENTRY_BY",OracleDbType.Varchar2,30,oUserBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_UPDATE_BY",OracleDbType.Varchar2,30,oUserBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_VERSION",OracleDbType.Varchar2,20,"1",ParameterDirection.Input),
             new OracleParameter ("P_COMP_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("P_LOC_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("P_MAC_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.MachineID,ParameterDirection.Input),
             new OracleParameter ("P_Active",OracleDbType.Char,1,oUserBO.EntryParameter.Active,ParameterDirection.Input)
            };

            return SaveUserDetails(packageName, parameterList);
        }
        public User SaveUser(User oUserBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_USER";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, oUserBO.EmpID,ParameterDirection.Input),
             new OracleParameter ("P_NICK_NAME",OracleDbType.Varchar2,300, oUserBO.NickName,ParameterDirection.Input),
             new OracleParameter ("P_USER_PWD",OracleDbType.Varchar2,30,oUserBO.UserPassw,ParameterDirection.Input),
             new OracleParameter ("P_PIN_CODE",OracleDbType.Varchar2,30, oUserBO.PinCode,ParameterDirection.Input),
             new OracleParameter ("P_E_MAIL",OracleDbType.Varchar2,30,oUserBO.Email,ParameterDirection.Input),
             new OracleParameter ("P_USER_GRP",OracleDbType.Varchar2,30,oUserBO.UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("P_Q_ID",OracleDbType.Varchar2,30,oUserBO.SecurityQuestion.QID,ParameterDirection.Input),
             new OracleParameter ("P_ANS",OracleDbType.Varchar2,300,oUserBO.SecurityQuestion.Answer,ParameterDirection.Input),
             new OracleParameter ("P_REMARKS",OracleDbType.Varchar2,300,oUserBO.Remarks,ParameterDirection.Input),
             new OracleParameter ("P_ValidUpto",OracleDbType.Varchar2,30,oUserBO.ValidUpto,ParameterDirection.Input),
             new OracleParameter ("P_ENTRY_BY",OracleDbType.Varchar2,30,oUserBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_UPDATE_BY",OracleDbType.Varchar2,30,oUserBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_VERSION",OracleDbType.Varchar2,20,"1",ParameterDirection.Input),
             new OracleParameter ("P_COMP_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("P_LOC_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("P_MAC_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.MachineID,ParameterDirection.Input),
             new OracleParameter ("p_moudle_id",OracleDbType.Varchar2,20,oUserBO.Module.ModuleID,ParameterDirection.Input)
            // new OracleParameter ("p_moudle_id",OracleDbType.Varchar2,20,oUserBO.EntryParameter.Active,ParameterDirection.Input)

            };

            //short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];

            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;

            //else
            //    return 0;
            return SaveUserDetails(packageName, parameterList);
        }
        public User SaveUserDetails(string packageName, OracleParameter[] parameterList)
        {
            IDataReader reader = null;
            User oUserBO = new User();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oUserBO.EntryParameter = oEntryParameter;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);
                if (reader.Read())
                {

                    oUserBO = CreateObjectUser(oReader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                oUserBO.EntryParameter = oEntryParameter;
            }
            return oUserBO;
        }
        #endregion
        #region DeleteUser
        public User DeleteUser(string UserID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Delete_USER";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, UserID,ParameterDirection.Input)
            };

            return SaveUserDetails(packageName, parameterList);
        }
        #endregion
        #region DataReaderMappingwithNUll
        private User MapObjectUser(NullHandler oReader)
        {
            User oDRS = new User();
            SecurityQuestion oSecurityQuestion = new SecurityQuestion();
            oDRS.EmpID = oReader.GetString("EMP_ID");
            oDRS.NickName = oReader.GetString("NickName");
            oDRS.UserPassw = oReader.GetString("USER_PWD");
            oDRS.PinCode = oReader.GetString("PIN_CODE");
            oDRS.Email = oReader.GetString("E_MAIL");
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.EntryDate = Convert.ToDateTime(oReader.GetDateTime("UPDATE_DATE").ToString("dd MMM yyyy"));
            oEntryParameter.Active = oReader.GetString("Active");
            oDRS.ValidUpto = oReader.GetDateTime("VALIDUPTO").ToString("dd MMM yyyy");
            oDRS.Remarks = oReader.GetString("REMARKS");
            oSecurityQuestion.QID = oReader.GetString("Q_ID");
            oSecurityQuestion.QTitle = oReader.GetString("Q_Title");
            oSecurityQuestion.Answer = oReader.GetString("ANS");  
            oDRS.EntryParameter = oEntryParameter;
            oDRS.SecurityQuestion = oSecurityQuestion;
            return oDRS;
        }
        private User CreateObjectUser(NullHandler oReader)
        {
            User oDRS = new User();
            oDRS = MapObjectUser(oReader);
            return oDRS;
        }
        private List<User> CreateObjectsUser(IDataReader oReader)
        {
            List<User> rDRSs = new List<User>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                User oItem = CreateObjectUser(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion
        #region GetUserNotAssignedyet
        public List<User> GetsUserNotAssigned(string ModuleID, string GroupID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER_Not_Assigned";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_moduleid",OracleDbType.Varchar2,30, ModuleID,ParameterDirection.Input),
             new OracleParameter ("p_grpid",OracleDbType.Varchar2,30, GroupID,ParameterDirection.Input)
            };
            return GetsUserNotAssignedDetails(packageName, parameterList);
        }
        private List<User> GetsUserNotAssignedDetails(string packageName, OracleParameter[] parameterList)
        {
            List<User> rDRSs = new List<User>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsUserNotAssigned(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }

        #region DataReaderMappingwithNUll
        private User MapObjectUserNotAssigned(NullHandler oReader)
        {
            User oDRS = new User();
            oDRS.EmpID = oReader.GetString("EMP_ID");
            oDRS.NickName = oReader.GetString("NickName");

            Department dept=new Department ();
            dept.DepartmentTitle=oReader.GetString("Dept_title");
            oDRS.Department =dept; 

            DepartmentUnit deptUnit=new DepartmentUnit ();
            deptUnit.UnitTitle= oReader.GetString("Unit_title");
            oDRS.DepartmentUnit = deptUnit;
            return oDRS;
        }
        private User CreateObjectUserNotAssigned(NullHandler oReader)
        {
            User oDRS = new User();
            oDRS = MapObjectUserNotAssigned(oReader);
            return oDRS;
        }
        private List<User> CreateObjectsUserNotAssigned(IDataReader oReader)
        {
            List<User> rDRSs = new List<User>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                User oItem = CreateObjectUserNotAssigned(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion

        #endregion
        #region GetUserAssigned
        public List<UserGroupAssign> GetsUserAssigned(string ModuleID, string GroupID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER_Assigned";
            OracleParameter[] parameterList = new OracleParameter[]
            {
              new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
              new OracleParameter ("P_Module",OracleDbType.Varchar2,30, ModuleID,ParameterDirection.Input),
              new OracleParameter ("P_Group",OracleDbType.Varchar2,30, GroupID,ParameterDirection.Input)
            };
            return GetsUserAssignedDetails(packageName, parameterList);
        }

        private List<UserGroupAssign> GetsUserAssignedDetails(string packageName, OracleParameter[] parameterList)
        {
            List<UserGroupAssign> rDRSs = new List<UserGroupAssign>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsUserAssigned(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }

        #region DataReaderMappingwithNUll
        private UserGroupAssign MapObjectUserAssigned(NullHandler oReader)
        {
            UserGroupAssign oDRS = new UserGroupAssign();
            EntryParameter oEntryParameter = new EntryParameter();
            User oUser = new User();
            Module oModule = new Module();
            UserGroup oUserGroup = new UserGroup();

            oEntryParameter.EntryBy = oReader.GetString("EMP_ID");
            oUser.NickName = oReader.GetString("NickName");
            oModule.ModuleName = oReader.GetString("ModuleName");
            oUserGroup.GroupTitle = oReader.GetString("GroupName");
            oUserGroup.GroupID = oReader.GetString("GroupID");
            oModule.ModuleID = oReader.GetString("ModuleID");

            oDRS.EntryParameter = oEntryParameter;
            oDRS.Module = oModule;
            oDRS.UserGroup = oUserGroup;
            oDRS.User = oUser;
            return oDRS;
        }
        private UserGroupAssign CreateObjectUserAssigned(NullHandler oReader)
        {
            UserGroupAssign oDRS = new UserGroupAssign();
            oDRS = MapObjectUserAssigned(oReader);
            return oDRS;
        }
        private List<UserGroupAssign> CreateObjectsUserAssigned(IDataReader oReader)
        {
            List<UserGroupAssign> rDRSs = new List<UserGroupAssign>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                UserGroupAssign oItem = CreateObjectUserAssigned(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion


        //===============================================13-Oct-2014==========================//

        public User GetUser(string empID)
        {
            string packageName = "AGH_ACMS.PKG_USER_MODULE.GET_USER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_employee_id",OracleDbType.Varchar2,30,empID,ParameterDirection.Input)                             
            };
            return GetUser(packageName, parameterList);

        }

        private User GetUser(string packageName, OracleParameter[] parameterList)
        {
           
            User oUser = new User();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedureIDataReader(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                oUser.NickName = (string)rdr["EmployeeName"];
                oUser.Email =!rdr.IsDBNull(2)? (string)rdr["Email"]:"";
                oUser.UserPassw = (string)rdr["Pass"];
                oUser.EmpID = (string)rdr["EmpId"];
                oUser.PhotoPath = (string)rdr["photo_Path"];

                Department dept = new Department();
                dept.DepartmentTitle = (string)rdr["Department"];
                dept.DepartmentID = (string)rdr["Department_id"];

                DepartmentGroup deptGroup = new DepartmentGroup();

                deptGroup.DepartmentGroupID = (string)rdr["DEPT_GRP"];
                deptGroup.DepartmentGroupTitle = (string)rdr["deptGroupTitle"];
                dept.DepartmentGroup = deptGroup;

                oUser.Department = dept;

                Designation dsg = new Designation();
                dsg.DesignationTitle = (string)rdr["Designation"];
                dsg.DesignationId = (string)rdr["Designation_ID"];
                oUser.Designation = dsg;

                DepartmentUnit dptUnit = new DepartmentUnit();
                dptUnit.UnitId = (string)rdr["Unit_ID"];
                dptUnit.UnitTitle = (string)rdr["Unit"];
                oUser.DepartmentUnit = dptUnit;
            }
            rdr.Close();
            return oUser;

        }



        //======================14-Oct-2014===================================//


      public short UpdateUserPassword(User oUserBO)
        {
            packageName = "AGH_ACMS.PKG_USER_MODULE.RESET_USER_PASSWORD";

            OracleParameter[] parameterList = new OracleParameter[] {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, oUserBO.EmpID,ParameterDirection.Input),      
             new OracleParameter ("P_USER_PWD",OracleDbType.Varchar2,30,oUserBO.UserPassw,ParameterDirection.Input) ,         
             new OracleParameter ("P_ENTRY_BY",OracleDbType.Varchar2,30,oUserBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_COMP_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("P_LOC_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("P_MAC_ID",OracleDbType.Varchar2,20,oUserBO.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else 
                return 0;
        }
   

        //====================================================//

      public List<User> GetsAssignedUser(string ModuleID, string GroupID)
      {
          string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_USER_Assigned";
          OracleParameter[] parameterList = new OracleParameter[]
            {
              new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
              new OracleParameter ("P_Module",OracleDbType.Varchar2,30, ModuleID,ParameterDirection.Input),
              new OracleParameter ("P_Group",OracleDbType.Varchar2,30, GroupID,ParameterDirection.Input)
            };
          return GetsUserAssignedMapping(packageName, parameterList);
      }
      private List<User> GetsUserAssignedMapping(string packageName, OracleParameter[] parameterList)
      {
          List<User> oUsers = new List<User>();
          OracleDataReader rdr;
          rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
          while (rdr.Read())
          {
              User oDRS = new User();
              oDRS.EmpID = (string)rdr["EMP_ID"];
              oDRS.NickName = (string)rdr["NickName"];

              Department dept = new Department();
              dept.DepartmentTitle = (string)rdr["Dept_title"];
              oDRS.Department = dept;

              DepartmentUnit deptUnit = new DepartmentUnit();
              deptUnit.UnitTitle = (string)rdr["Unit_title"];
              oDRS.DepartmentUnit = deptUnit;
              oUsers.Add(oDRS);
          }
          rdr.Close();
          return oUsers;
      }
    }
}
