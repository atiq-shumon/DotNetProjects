using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;

namespace DSL.POS.DataAccessLayer.Imp
{
    public class MemberInfoDALImp: CommonDALImp, IMemberInfoDAL 
    {
        // Error Handling developed by Samad
        // 07/12/06

        private void getPKCode(MemberInfoDTO obj)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            string strPKCode = null;
            int PKSL = 0;

            string sqlSelect = "Select isnull(Max(CustId),0)+1 From MemberInfo";

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;

            try
            {
                sqlConn.Open();
                PKSL = (int)objCmd.ExecuteScalar();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objCmd.Dispose();
                objCmd.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }

            strPKCode = PKSL.ToString("000000");
            obj.CustId = strPKCode;
            //return strPKCode;
        }

        public override void Save(object obj)
        {
            MemberInfoDTO oMemberInfoDTO = (MemberInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oMemberInfoDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                String sql = "Insert Into MemberInfo(CustId,ManualId,CustName,CustAtten,ContactPerson,CustAddr," +
                    " CustPhone,CustFax,CustEmail,WebSite,BirthDay,Mobile,CreditLimit,EntryBy,EntryDate)" +
                    " values(@CustId,@ManualId,@CustName,@CustAtten,@ContactPerson,@CustAddr,@CustPhone," +
                    " @CustFax,@CustEmail,@WebSite,@BirthDay,@Mobile,@CreditLimit,@EntryBy,@EntryDate)";

                try
                {

                    getPKCode(oMemberInfoDTO);
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@CustId", SqlDbType.VarChar, 6));
                    objCmd.Parameters.Add(new SqlParameter("@ManualId", SqlDbType.VarChar, 20));
                    objCmd.Parameters.Add(new SqlParameter("@CustName", SqlDbType.VarChar, 100));
                    objCmd.Parameters.Add(new SqlParameter("@CustAtten", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@ContactPerson", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CustAddr", SqlDbType.VarChar, 150));
                    objCmd.Parameters.Add(new SqlParameter("@CustPhone", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CustFax", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CustEmail", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@WebSite", SqlDbType.VarChar, 70));
                    objCmd.Parameters.Add(new SqlParameter("@BirthDay", SqlDbType.DateTime));
                    objCmd.Parameters.Add(new SqlParameter("@Mobile", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CreditLimit", SqlDbType.Decimal, 9));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 10));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@CustId"].Value = Convert.ToString(oMemberInfoDTO.CustId);
                    objCmd.Parameters["@ManualId"].Value = Convert.ToString(oMemberInfoDTO.ManualId);
                    objCmd.Parameters["@CustName"].Value = Convert.ToString(oMemberInfoDTO.CustName);
                    objCmd.Parameters["@CustAtten"].Value = Convert.ToString(oMemberInfoDTO.CustAtten);
                    objCmd.Parameters["@ContactPerson"].Value = Convert.ToString(oMemberInfoDTO.ContactPerson);
                    objCmd.Parameters["@CustAddr"].Value = Convert.ToString(oMemberInfoDTO.CustAddr);
                    objCmd.Parameters["@CustPhone"].Value = Convert.ToString(oMemberInfoDTO.CustPhone);
                    objCmd.Parameters["@CustFax"].Value = Convert.ToString(oMemberInfoDTO.CustFax);
                    objCmd.Parameters["@CustEmail"].Value = Convert.ToString(oMemberInfoDTO.CustEmail);
                    objCmd.Parameters["@WebSite"].Value = Convert.ToString(oMemberInfoDTO.WebSite);

                    if (oMemberInfoDTO.BirthDay ==null)
                        objCmd.Parameters["@BirthDay"].Value = "<NULL>";
                    else
                        objCmd.Parameters["@BirthDay"].Value = Convert.ToString(oMemberInfoDTO.BirthDay);

                    objCmd.Parameters["@Mobile"].Value = Convert.ToString(oMemberInfoDTO.Mobile);
                    objCmd.Parameters["@CreditLimit"].Value = Convert.ToString(oMemberInfoDTO.CreditLimit);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oMemberInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oMemberInfoDTO.EntryDate);

                    sqlConn.Open();
                    objCmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objCmd.Dispose();
                    objCmd.Cancel();
                    sqlConn.Close();
                    sqlConn.Dispose();
                }
            }
            else
            {
                String sql = "Update  MemberInfo set " +
                        " CustId=@CustId,ManualId=@ManualId,CustName=@CustName,CustAtten=@CustAtten,ContactPerson=@ContactPerson," +
                        " CustAddr=@CustAddr,CustPhone=@CustPhone,CustFax=@CustFax,CustEmail=@CustEmail,WebSite=@WebSite," +
                        " BirthDay=@BirthDay,Mobile=@Mobile,CreditLimit=@CreditLimit,EntryBy=@EntryBy,EntryDate=@EntryDate" +
                        " where Cust_PK=@Cust_PK";

                try
                {
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@Cust_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@CustId", SqlDbType.VarChar, 6));
                    objCmd.Parameters.Add(new SqlParameter("@ManualId", SqlDbType.VarChar, 20));
                    objCmd.Parameters.Add(new SqlParameter("@CustName", SqlDbType.VarChar, 100));
                    objCmd.Parameters.Add(new SqlParameter("@CustAtten", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@ContactPerson", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CustAddr", SqlDbType.VarChar, 150));
                    objCmd.Parameters.Add(new SqlParameter("@CustPhone", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CustFax", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CustEmail", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@WebSite", SqlDbType.VarChar, 70));
                    objCmd.Parameters.Add(new SqlParameter("@BirthDay", SqlDbType.DateTime));
                    objCmd.Parameters.Add(new SqlParameter("@Mobile", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@CreditLimit", SqlDbType.Decimal, 9));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 10));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@Cust_PK"].Value = (Guid)oMemberInfoDTO.PrimaryKey;
                    objCmd.Parameters["@CustId"].Value = Convert.ToString(oMemberInfoDTO.CustId);
                    objCmd.Parameters["@ManualId"].Value = Convert.ToString(oMemberInfoDTO.ManualId);
                    objCmd.Parameters["@CustName"].Value = Convert.ToString(oMemberInfoDTO.CustName);
                    objCmd.Parameters["@CustAtten"].Value = Convert.ToString(oMemberInfoDTO.CustAtten);
                    objCmd.Parameters["@ContactPerson"].Value = Convert.ToString(oMemberInfoDTO.ContactPerson);
                    objCmd.Parameters["@CustAddr"].Value = Convert.ToString(oMemberInfoDTO.CustAddr);
                    objCmd.Parameters["@CustPhone"].Value = Convert.ToString(oMemberInfoDTO.CustPhone);
                    objCmd.Parameters["@CustFax"].Value = Convert.ToString(oMemberInfoDTO.CustFax);
                    objCmd.Parameters["@CustEmail"].Value = Convert.ToString(oMemberInfoDTO.CustEmail);
                    objCmd.Parameters["@WebSite"].Value = Convert.ToString(oMemberInfoDTO.WebSite);
                    objCmd.Parameters["@BirthDay"].Value = Convert.ToString(oMemberInfoDTO.BirthDay);
                    objCmd.Parameters["@Mobile"].Value = Convert.ToString(oMemberInfoDTO.Mobile);
                    objCmd.Parameters["@CreditLimit"].Value = Convert.ToString(oMemberInfoDTO.CreditLimit);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oMemberInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oMemberInfoDTO.EntryDate);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oMemberInfoDTO.EntryDate);

                    sqlConn.Open();
                    objCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objCmd.Dispose();
                    objCmd.Cancel();
                    sqlConn.Dispose();
                    sqlConn.Close();
                }
            }
        }
        /// <summary>
        /// Delete row
        /// </summary>
        /// <param name="obj"></param>
        public override void Delete(object obj)
        {
            MemberInfoDTO oMemberInfoDTO = (MemberInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  MemberInfo where Cust_PK=@Cust_PK";

            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;

            try
            {
                objCmdDelete.Parameters.Add("@Cust_PK", SqlDbType.UniqueIdentifier, 16);

                objCmdDelete.Parameters["@Cust_PK"].Value = (Guid)oMemberInfoDTO.PrimaryKey;

                sqlConn.Open();
                objCmdDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCmdDelete.Dispose();
                objCmdDelete.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }

        }
        
        /// <summary>
        /// This Method used for get Primary Key corresponding Member Code
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns> Primary Key</returns>
        /// 
        public Guid GetPKBYCode(string strCode)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            Guid guidCust_ID=new Guid();

            string sqlSelect = "Select Cust_PK From MemberInfo where CustId=@CustId";

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;

            objCmd.Parameters.Add("@CustId", SqlDbType.VarChar, 6);

            objCmd.Parameters["@CustId"].Value = strCode ;

            try
            {
                sqlConn.Open();
                SqlDataReader sqlDReader = objCmd.ExecuteReader();
                //while (sqlDReader.Read())
                //{
                //    guidCust_ID = (Guid)sqlDReader["Cust_PK"];
                //    //return guidCust_ID;
                //}
                if (sqlDReader.Read())
                    guidCust_ID = (Guid)sqlDReader["Cust_PK"];
                //else
                 //   guidCust_ID = (Guid)("00000000-0000-0000-0000-000000000000");
                
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objCmd.Dispose();
                sqlConn.Dispose();
                sqlConn.Close();
            }

            return guidCust_ID;      
        }

        /// <summary>
        /// This method used for get all data corresponding primary key.
        /// </summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        /// 

        public MemberInfoDTO findByPKDTO(Guid pk)
        {
            MemberInfoDTO oMemberInfoDTO = new MemberInfoDTO();
            
            string sqlSelect = "Select Cust_PK,CustId,ManualId,CustName,CustAtten,ContactPerson,CustAddr," +
                                " CustPhone,CustFax,CustEmail,WebSite,BirthDay,Mobile,CreditLimit,EntryBy,EntryDate From MemberInfo where Cust_PK=@Cust_PK";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;


            try
            {
                objCmd.Parameters.Add("@Cust_PK", SqlDbType.UniqueIdentifier, 16);

                objCmd.Parameters["@Cust_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    oMemberInfoDTO = populate(thisReader);
                }

                thisReader.Close();
                thisReader.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                objCmd.Dispose();
                objCmd.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }
            return oMemberInfoDTO;
        }


        public List<MemberInfoDTO> getMemberInfoData()
        {
            string sqlSelect = "Select Cust_PK,CustId,ManualId,CustName,CustAtten,ContactPerson,CustAddr," +
                                " CustPhone,CustFax,CustEmail,WebSite,BirthDay,Mobile,CreditLimit,EntryBy,EntryDate From MemberInfo order by CustId Asc";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            List<MemberInfoDTO> oArrayList = new List<MemberInfoDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    MemberInfoDTO oMemberInfoDTO = populate(thisReader);
                    oArrayList.Add(oMemberInfoDTO);
                }

                thisReader.Close();
                thisReader.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

                objCmd.Dispose();
                objCmd.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }

            return oArrayList;
        }

        public MemberInfoDTO  populate(SqlDataReader reader)
        {
            try
            {
                MemberInfoDTO  dto = new MemberInfoDTO ();

                dto.PrimaryKey = (Guid)reader["Cust_PK"];
                dto.CustId  = (string)reader["CustId"];
                dto.ManualId = (string)reader["ManualId"];
                dto.CustName = (string)reader["CustName"];
                dto.CustAtten = (string)reader["CustAtten"];
                dto.ContactPerson = (string)reader["ContactPerson"];
                dto.CustAddr = (string)reader["CustAddr"];
                dto.CustPhone = (string)reader["CustPhone"];
                dto.CustFax = (string)reader["CustFax"];
                dto.CustEmail = (string)reader["CustEmail"];
                dto.WebSite = (string)reader["WebSite"];
                dto.BirthDay = (DateTime)reader["BirthDay"];
                dto.Mobile = (string)reader["Mobile"];
                dto.CreditLimit = (Decimal)reader["CreditLimit"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MemberInfoDALImp()
        {
            // Todo
        }


    }
}
