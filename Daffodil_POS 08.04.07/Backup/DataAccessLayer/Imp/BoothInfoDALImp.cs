using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DTO.DTO;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for BoothInfoDALImp
    /// </summary>
    /// 
    // Error Handling developed by Samad
    // 05/12/06

    public class BoothInfoDALImp : CommonDALImp, IBoothInfoDAL
    {
        private void getPKCode(BoothInfoDTO obj)
        {

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            int   PKSL = 0;

            string sqlSelect = "Select isnull(Max(BoothNo),000)+1 From BoothInfo";

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;

            try
            {
                sqlConn.Open();
                PKSL = (int)objCmd.ExecuteScalar();
            }
            catch(Exception Exp)
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

            obj.BoothNo = PKSL;
        }

        public override void Save(object obj)
        {
            BoothInfoDTO oBoothInfoDTO = (BoothInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oBoothInfoDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                //string strset = getPKCode(oProductCategoryInfoDTO);
                String sql = "Insert Into BoothInfo(BR_PK,BoothNo,BoothCashLimit,BoothStatus,EntryBy,EntryDate) values(@BR_PK,@BoothNo,@BoothCashLimit,@BoothStatus,@EntryBy,@EntryDate)";


                try
                {

                    getPKCode(oBoothInfoDTO);

                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@BR_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@BoothNo", SqlDbType.Int, 2));
                    objCmd.Parameters.Add(new SqlParameter("@BoothCashLimit", SqlDbType.Decimal, 9));
                    objCmd.Parameters.Add(new SqlParameter("@BoothStatus", SqlDbType.Bit, 1));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));
                    
                    objCmd.Parameters["@BR_PK"].Value = (Guid)oBoothInfoDTO.BR_PK;
                    objCmd.Parameters["@BoothNo"].Value = Convert.ToInt16(oBoothInfoDTO.BoothNo);
                    objCmd.Parameters["@BoothCashLimit"].Value = Convert.ToDecimal(oBoothInfoDTO.BoothCashLimit);
                    objCmd.Parameters["@BoothStatus"].Value = Convert.ToBoolean(oBoothInfoDTO.BoothStatus);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oBoothInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oBoothInfoDTO.EntryDate);

                    sqlConn.Open();
                    objCmd.ExecuteNonQuery();

                }
                catch (Exception Exp)
                {
                    throw Exp;
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

                String sql = "Update  BoothInfo set BR_PK=@BR_PK,BoothCashLimit=@BoothCashLimit,BoothStatus=@BoothStatus,MachineID=@MachineID,EntryBy=@EntryBy,EntryDate=@EntryDate where Bo_PK=@Bo_PK";

                //objCmd = new SqlCommand(sql, getCurrentConnection(), getCurrentTransaction()); ;

                try
                {
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@Bo_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@BR_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@BoothCashLimit", SqlDbType.Decimal));
                    objCmd.Parameters.Add(new SqlParameter("@BoothStatus", SqlDbType.Bit));
                    objCmd.Parameters.Add(new SqlParameter("@MachineID", SqlDbType.NVarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@Bo_PK"].Value = (Guid)oBoothInfoDTO.PrimaryKey;
                    objCmd.Parameters["@BR_PK"].Value = (Guid)oBoothInfoDTO.BR_PK;
                    objCmd.Parameters["@BoothCashLimit"].Value = Convert.ToDecimal(oBoothInfoDTO.BoothCashLimit);
                    objCmd.Parameters["@BoothStatus"].Value = Convert.ToBoolean(oBoothInfoDTO.BoothStatus);
                    //Not Identity MachineId
                    objCmd.Parameters["@MachineID"].Value = Convert.ToString(oBoothInfoDTO.BoothNo);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oBoothInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oBoothInfoDTO.EntryDate);

                    sqlConn.Open();
                    objCmd.ExecuteNonQuery();
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
            }
        }

        public override void Delete(object obj)
        {
            BoothInfoDTO oBoothInfoDTO = (BoothInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  BoothInfo where Bo_PK=@Bo_PK";

            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;

            try
            {


                objCmdDelete.Parameters.Add("@Bo_PK", SqlDbType.UniqueIdentifier, 16);

                objCmdDelete.Parameters["@Bo_PK"].Value = (Guid)oBoothInfoDTO.PrimaryKey;

                sqlConn.Open();
                objCmdDelete.ExecuteNonQuery();

            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objCmdDelete.Dispose();
                objCmdDelete.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }

        }
        
        public BoothInfoDTO findByPKDTO(Guid pk)
        {
            BoothInfoDTO oBoothInfoDTO = new BoothInfoDTO();


            string sqlSelect = "Select Bo_PK,BR_PK,BoothNo,BoothCashLimit,BoothStatus,MachineID,EntryBy,EntryDate From BoothInfo where Bo_PK=@Bo_PK";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;



            try
            {
                objCmd.Parameters.Add("@Bo_PK", SqlDbType.UniqueIdentifier, 16);

                objCmd.Parameters["@Bo_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                if (thisReader.Read())
                {
                    oBoothInfoDTO = populate(thisReader);
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
            return oBoothInfoDTO;
        }

        /// <summary>
        /// Find Booth Information corresponding Booth Code
        /// </summary>
        /// <param name="BoothCode"></param>
        /// <returns></returns>
        public BoothInfoDTO findBoothInfoByCodeDTO(short BoothCode)
        {
            BoothInfoDTO oBoothInfoDTO = new BoothInfoDTO();


            string sqlSelect = "Select Bo_PK,BR_PK,BoothNo,BoothCashLimit,BoothStatus,MachineID,EntryBy,EntryDate From BoothInfo where BoothNo=@BoothNo";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;



            try
            {
                objCmd.Parameters.Add("@BoothNo", SqlDbType.SmallInt, 2);

                objCmd.Parameters["@BoothNo"].Value = BoothCode;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                if (thisReader.Read())
                {
                    oBoothInfoDTO = populate(thisReader);
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
            return oBoothInfoDTO;
        }

        public List<BoothInfoDTO> getBoothInfoData()
        {
            string sqlSelect = "Select Bo_PK,BR_PK,BoothNo,BoothCashLimit,BoothStatus,MachineID,EntryBy,EntryDate From BoothInfo order by BoothNo DESC";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            List<BoothInfoDTO> oArrayList = new List<BoothInfoDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    BoothInfoDTO oBoothInfoDTO = populate(thisReader);
                    oArrayList.Add(oBoothInfoDTO);
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

            return oArrayList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        public BoothInfoDTO findByPK_AllDTO(Guid pk)
        {
            BoothInfoDTO oBoothInfoDTO = new BoothInfoDTO();


            string sqlSelect = "SELECT BranchTypeInfo.BT_Name as 'BType_Name', BranchInfo.BranchCode, "+
                "BranchInfo.BranchName, BranchInfo.ContactPerson, BranchInfo.BranchAddress, " +
                " BranchInfo.Telephone1, BranchInfo.Telephone2, BranchInfo.Fax, BranchInfo.EMail," +
                " BranchInfo.CashInSafeLimit, BoothInfo.BoothNo,  BoothInfo.BoothCashLimit, " +
                " BoothInfo.BoothStatus, BoothInfo.MachineID, BoothInfo.Bo_PK FROM BranchTypeInfo " +
                " INNER JOIN  BranchInfo ON BranchTypeInfo.BT_PK = BranchInfo.BT_PK INNER JOIN " +
                "BoothInfo ON BranchInfo.BR_PK = BoothInfo.BR_PK WHERE    BoothInfo.Bo_PK = @Bo_PK ";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;



            try
            {
                objCmd.Parameters.Add("@Bo_PK", SqlDbType.UniqueIdentifier, 16);

                objCmd.Parameters["@Bo_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                if (thisReader.Read())
                {
                    oBoothInfoDTO = populate_all(thisReader);
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
            return oBoothInfoDTO;
        }
        public BoothInfoDTO populate_all(SqlDataReader reader)
        {
            try
            {
                BoothInfoDTO dto = new BoothInfoDTO();
                BranchInfoDTO oBranchInfoDTO=new BranchInfoDTO();
                BranchTypeInfoDTO oBranchTypeInfoDTO=new BranchTypeInfoDTO();

                oBranchTypeInfoDTO.BT_Name = (string)reader["BType_Name"];
                oBranchInfoDTO.BranchCode = (string)reader["BranchCode"];
                oBranchInfoDTO.BranchName = (string)reader["BranchName"];
                oBranchInfoDTO.ContactPerson = (string)reader["ContactPerson"];
                oBranchInfoDTO.BranchAddress = (string)reader["BranchAddress"];
                oBranchInfoDTO.Telephone1 = (string)reader["Telephone1"];
                oBranchInfoDTO.Telephone2 = (string)reader["Telephone2"];
                oBranchInfoDTO.Fax = (string)reader["Fax"];
                oBranchInfoDTO.EMail = (string)reader["EMail"];
                oBranchInfoDTO.CashInSafeLimit = (decimal)reader["CashInSafeLimit"];
                dto.BoothNo = (Int16)reader["BoothNo"];
                dto.BoothCashLimit = (decimal)reader["BoothCashLimit"];
                dto.BoothStatus = (bool)reader["BoothStatus"];
                dto.MachineID = (string)reader["MachineID"];

                dto.BranchCode  = oBranchInfoDTO;
                dto.BranchCode.BranchTypeInfoDTO = oBranchTypeInfoDTO;


                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }
        public BoothInfoDTO populate(SqlDataReader reader)
        {
            try
            {
                BoothInfoDTO dto = new BoothInfoDTO();
                dto.PrimaryKey = (Guid)reader["Bo_PK"];
                dto.BR_PK = (Guid)reader["BR_PK"];
                dto.BoothNo = (Int16)reader["BoothNo"];
                dto.BoothCashLimit = (decimal)reader["BoothCashLimit"];
                dto.BoothStatus = (bool)reader["BoothStatus"];
                if (reader.IsDBNull(5) == true)
                {
                    dto.MachineID = null;
                }
                else
                {
                    dto.MachineID = (string)reader["MachineID"];
                }
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        public BoothInfoDALImp()
        {

            //
            // TODO: Add constructor logic here
            //
        }
    }
}