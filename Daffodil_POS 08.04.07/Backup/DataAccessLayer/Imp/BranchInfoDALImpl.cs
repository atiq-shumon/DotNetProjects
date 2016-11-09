using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DTO.DTO;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for BranchInfoDALImpl
    /// </summary>
    /// 
    // Error Handling developed by Samad
    // 05/12/06

    public class BranchInfoDALImpl : CommonDALImp, IBranchInfoDAL
    {
        private string Get_BranchInfoCode(BranchInfoDTO Obj)
        {
            string brcode = null;
            int brcodeno = 0;

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            try
            {
                
                SqlCommand objcmd = new SqlCommand();

                objcmd.CommandText = "Select Isnull(Max(cast(BranchCode as int)),0 )+1 from BranchInfo";
                objmycon.Open();
                objcmd.Connection = objmycon;
                brcodeno = (int)objcmd.ExecuteScalar();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objmycon.Close();
            }
            
            brcode = brcodeno.ToString("000");
            return brcode;
        }

        public override void Save(object Obj)
        {
            BranchInfoDTO btInfo = (BranchInfoDTO)Obj;
            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            
            try
            {   
                SqlCommand objcmd = new SqlCommand();

                if (btInfo.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    btInfo.BranchCode = Get_BranchInfoCode(btInfo);

                    objcmd.CommandText = "Insert Into BranchInfo(BT_PK,BranchCode,BranchName,ContactPerson,ContactPersonPhone,BranchPrefix,BranchAddress,Telephone1,Telephone2,Telephone3,Fax,EMail,CashInSafeLimit,EntryBy,EntryDate) Values(@BT_PK,@BranchCode,@BranchName,@ContactPerson,@ContactPersonPhone,@BranchPrefix,@BranchAddress,@Telephone1,@Telephone2,@Telephone3,@Fax,@EMail,@CashInSafeLimit,@EntryBy,@EntryDate)";

                    objcmd.Parameters.Add(new SqlParameter("@BT_PK", SqlDbType.UniqueIdentifier, 16));
                    objcmd.Parameters.Add(new SqlParameter("@BranchCode", SqlDbType.VarChar, 3));
                    objcmd.Parameters.Add(new SqlParameter("@BranchName", SqlDbType.VarChar, 50));
                    objcmd.Parameters.Add(new SqlParameter("@ContactPerson", SqlDbType.VarChar, 50));
                    objcmd.Parameters.Add(new SqlParameter("@ContactPersonPhone", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@BranchPrefix", SqlDbType.VarChar, 3));
                    objcmd.Parameters.Add(new SqlParameter("@BranchAddress", SqlDbType.VarChar, 150));
                    objcmd.Parameters.Add(new SqlParameter("@Telephone1", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@Telephone2", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@Telephone3", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 25));
                    objcmd.Parameters.Add(new SqlParameter("@EMail", SqlDbType.VarChar, 25));
                    objcmd.Parameters.Add(new SqlParameter("@CashInSafeLimit", SqlDbType.VarChar, 9));
                    //objcmd.Parameters.Add(new SqlParameter("@", SqlDbType.VarChar, ));

                    objcmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objcmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime, 8));

                    objcmd.Parameters["@BT_PK"].Value = (Guid)btInfo.BT_PK;
                    objcmd.Parameters["@BranchCode"].Value = (string)btInfo.BranchCode;
                    objcmd.Parameters["@BranchName"].Value = (string)btInfo.BranchName;
                    objcmd.Parameters["@ContactPerson"].Value = (string)btInfo.ContactPerson;
                    objcmd.Parameters["@ContactPersonPhone"].Value = (string)btInfo.ContactPersonPhone;
                    objcmd.Parameters["@BranchPrefix"].Value = (string)btInfo.BranchPrefix;
                    objcmd.Parameters["@BranchAddress"].Value = (string)btInfo.BranchAddress;
                    objcmd.Parameters["@Telephone1"].Value = (string)btInfo.Telephone1;
                    objcmd.Parameters["@Telephone2"].Value = (string)btInfo.Telephone2;
                    objcmd.Parameters["@Telephone3"].Value = (string)btInfo.Telephone3;
                    objcmd.Parameters["@Fax"].Value = (string)btInfo.Fax;
                    objcmd.Parameters["@EMail"].Value = (string)btInfo.EMail;
                    objcmd.Parameters["@CashInSafeLimit"].Value = (Decimal)btInfo.CashInSafeLimit;

                    //objcmd.Parameters["@"].Value = (string)brInfo.

                    objcmd.Parameters["@EntryBy"].Value = (string)btInfo.EntryBy;
                    objcmd.Parameters["@EntryDate"].Value = (DateTime)btInfo.EntryDate;

                }
                else
                {
                    objcmd.CommandText = "Update BranchInfo set BT_PK=@BT_PK, BranchName=@BranchName,ContactPerson=@ContactPerson,ContactPersonPhone=@ContactPersonPhone,BranchPrefix=@BranchPrefix,BranchAddress=@BranchAddress,Telephone1=@Telephone1,Telephone2=@Telephone2,Telephone3=@Telephone3,Fax=@Fax,EMail=@EMail,CashInSafeLimit=@CashInSafeLimit where BR_PK=@BR_PK";
                    objcmd.Parameters.Add(new SqlParameter("@BR_PK", SqlDbType.UniqueIdentifier, 16));
                    objcmd.Parameters.Add(new SqlParameter("@BT_PK", SqlDbType.UniqueIdentifier, 16));
                    objcmd.Parameters.Add(new SqlParameter("@BranchName", SqlDbType.VarChar, 50));
                    objcmd.Parameters.Add(new SqlParameter("@ContactPerson", SqlDbType.VarChar, 50));
                    objcmd.Parameters.Add(new SqlParameter("@ContactPersonPhone", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@BranchPrefix", SqlDbType.VarChar, 3));
                    objcmd.Parameters.Add(new SqlParameter("@BranchAddress", SqlDbType.VarChar, 150));
                    objcmd.Parameters.Add(new SqlParameter("@Telephone1", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@Telephone2", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@Telephone3", SqlDbType.VarChar, 15));
                    objcmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 25));
                    objcmd.Parameters.Add(new SqlParameter("@EMail", SqlDbType.VarChar, 25));
                    objcmd.Parameters.Add(new SqlParameter("@CashInSafeLimit", SqlDbType.Decimal, 9));


                    objcmd.Parameters["@BR_PK"].Value = (Guid)btInfo.PrimaryKey;
                    objcmd.Parameters["@BT_PK"].Value = (Guid)btInfo.BT_PK;
                    objcmd.Parameters["@BranchName"].Value = (string)btInfo.BranchName;
                    objcmd.Parameters["@ContactPerson"].Value = (string)btInfo.ContactPerson;
                    objcmd.Parameters["@ContactPersonPhone"].Value = (string)btInfo.ContactPersonPhone;
                    objcmd.Parameters["@BranchPrefix"].Value = (string)btInfo.BranchPrefix;
                    objcmd.Parameters["@BranchAddress"].Value = (string)btInfo.BranchAddress;
                    objcmd.Parameters["@Telephone1"].Value = (string)btInfo.Telephone1;
                    objcmd.Parameters["@Telephone2"].Value = (string)btInfo.Telephone2;
                    objcmd.Parameters["@Telephone3"].Value = (string)btInfo.Telephone3;
                    objcmd.Parameters["@Fax"].Value = (string)btInfo.Fax;
                    objcmd.Parameters["@EMail"].Value = (string)btInfo.EMail;
                    objcmd.Parameters["@CashInSafeLimit"].Value = (Decimal)btInfo.CashInSafeLimit;

                }

                objcmd.Connection = objmycon;
                objmycon.Open();
                objcmd.ExecuteNonQuery();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objmycon.Close();
            }

        }

        public List<BranchInfoDTO> GetBranchInfo()
        {
            List<BranchInfoDTO> productUnitList = new List<BranchInfoDTO>();

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();

            try
            {

                
                objcmd.Connection = objmycon;
                objcmd.CommandText = "SELECT BR_PK,BT_PK,BranchCode,BranchName,ContactPerson,ContactPersonPhone,BranchPrefix,BranchAddress,Telephone1,Telephone2,Telephone3,Fax,EMail,CashInSafeLimit,EntryBy,EntryDate FROM BranchInfo ORDER BY BranchCode DESC";
                objmycon.Open();
                SqlDataReader thisReader = objcmd.ExecuteReader();

                while (thisReader.Read())
                {
                    BranchInfoDTO oProductUnitInfoDto = populate(thisReader);
                    productUnitList.Add(oProductUnitInfoDto);
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

                objcmd.Dispose();
                objcmd.Cancel();
                objmycon.Close();
            }
            return productUnitList;
        }

        public override void Delete(object obj)
        {
            BranchInfoDTO oProductUnitInfoDto = (BranchInfoDTO)obj;

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();

            objcmd.CommandText = "Delete From BranchInfo WHERE BR_PK=@BR_PK";
            
            objcmd.Parameters.Add(new SqlParameter("@BR_PK", SqlDbType.UniqueIdentifier, 16));
            objcmd.Parameters["@BR_PK"].Value = (Guid)oProductUnitInfoDto.PrimaryKey;

            objcmd.Connection = objmycon;
            
            try
            {
                objmycon.Open();
                objcmd.ExecuteNonQuery();                
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objmycon.Close();
                //objCmdDelete.Dispose();
                //objCmdDelete.Cancel();
            }
        }

        public BranchInfoDTO findByPK(Guid pk)
        {
            BranchInfoDTO oBranchInfoDTO = new BranchInfoDTO();

            string sqlSelect = "Select BR_PK,BT_PK,BranchCode,BranchName,ContactPerson,ContactPersonPhone,BranchPrefix,BranchAddress,Telephone1,Telephone2,Telephone3,Fax,EMail,CashInSafeLimit,EntryBy,EntryDate From BranchInfo where BR_PK=@BR_PK";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            try            
            {
                
                objCmd.CommandText = sqlSelect;
                objCmd.Connection = sqlConn;

                objCmd.Parameters.Add("@BR_PK", SqlDbType.UniqueIdentifier, 16);

                objCmd.Parameters["@BR_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    oBranchInfoDTO = populate(thisReader);
                }

                thisReader.Close();
                thisReader.Dispose();
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
            return oBranchInfoDTO;

        }
        public BranchInfoDTO populate(SqlDataReader reader)
        {
            try
            {
                BranchInfoDTO dto = new BranchInfoDTO();

                dto.PrimaryKey = (Guid)reader["BR_PK"];
                dto.BT_PK = (Guid)reader["BT_PK"];
                dto.BranchCode = (string)reader["BranchCode"];
                dto.BranchName = (string)reader["BranchName"];
                dto.ContactPerson = (string)reader["ContactPerson"];
                dto.ContactPersonPhone = (string)reader["ContactPersonPhone"];
                dto.BranchPrefix = (string)reader["BranchPrefix"];
                dto.BranchAddress = (string)reader["BranchAddress"];
                dto.Telephone1 = (string)reader["Telephone1"];
                dto.Telephone2 = (string)reader["Telephone2"];
                dto.Telephone3 = (string)reader["Telephone3"];
                dto.Fax = (string)reader["Fax"];
                dto.EMail = (string)reader["EMail"];
                dto.CashInSafeLimit = (Decimal)reader["CashInSafeLimit"];

                ////dto = (string)reader[""];

                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        public BranchInfoDALImpl()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}