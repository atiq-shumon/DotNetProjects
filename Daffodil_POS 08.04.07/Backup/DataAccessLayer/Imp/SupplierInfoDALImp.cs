using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for SupplierInfoDALImp
    /// </summary>
    public class SupplierInfoDALImp : CommonDALImp, ISupplierInfoDAL
   {
        // Error Handling developed by Samad
        // 05/12/06

        private void getPKCode(SupplierInfoDTO obj)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            string strPKCode = null;
            int PKSL = 0;

            string sqlSelect = "Select isnull(Max(SupplierCode),0)+1 From SupplierInfo";

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

            strPKCode = PKSL.ToString("000000");
            obj.SupplierCode = strPKCode;
            //return strPKCode;
        }

        public override void Save(object obj)
        {
            SupplierInfoDTO oSupplierInfoDTO = (SupplierInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oSupplierInfoDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                //string strset = getPKCode(oProductCategoryInfoDTO);
                String sql = "Insert Into SupplierInfo(SupplierCode,SupplierName,ContractPerson,ShortName,Address,Phone,Fax,Email,WebAddress,EntryBy,EntryDate) values(@SupplierCode,@SupplierName,@ContractPerson,@ShortName,@Address,@Phone,@Fax,@Email,@WebAddress,@EntryBy,@EntryDate)";


                try
                {

                    getPKCode(oSupplierInfoDTO);

                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@SupplierCode", SqlDbType.VarChar, 6));
                    objCmd.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.VarChar, 100));
                    objCmd.Parameters.Add(new SqlParameter("@ContractPerson", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@ShortName", SqlDbType.VarChar, 25));
                    objCmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 150));
                    objCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 30));
                    objCmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 30));
                    objCmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 30));
                    objCmd.Parameters.Add(new SqlParameter("@WebAddress", SqlDbType.VarChar, 20));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@SupplierCode"].Value = Convert.ToString(oSupplierInfoDTO.SupplierCode);
                    objCmd.Parameters["@SupplierName"].Value = Convert.ToString(oSupplierInfoDTO.SupplierName);
                    objCmd.Parameters["@ContractPerson"].Value = Convert.ToString(oSupplierInfoDTO.ContractPerson);
                    objCmd.Parameters["@ShortName"].Value = Convert.ToString(oSupplierInfoDTO.ShortName);
                    objCmd.Parameters["@Address"].Value = Convert.ToString(oSupplierInfoDTO.Address);
                    objCmd.Parameters["@Phone"].Value = Convert.ToString(oSupplierInfoDTO.Phone);
                    objCmd.Parameters["@Fax"].Value = Convert.ToString(oSupplierInfoDTO.Fax);
                    objCmd.Parameters["@Email"].Value = Convert.ToString(oSupplierInfoDTO.Email);
                    objCmd.Parameters["@WebAddress"].Value = Convert.ToString(oSupplierInfoDTO.WebAddress);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oSupplierInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oSupplierInfoDTO.EntryDate);

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

                String sql = "Update  SupplierInfo set SupplierName=@SupplierName,ContractPerson=@ContractPerson,ShortName=@ShortName,Address=@Address,Phone=@Phone,Fax=@Fax,Email=@Email,WebAddress=@WebAddress,EntryBy=@EntryBy,EntryDate=@EntryDate where Sp_PK=@Sp_PK";

                //objCmd = new SqlCommand(sql, getCurrentConnection(), getCurrentTransaction()); ;

                try
                {
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@Sp_PK", SqlDbType.UniqueIdentifier, 16));
                    //objCmd.Parameters.Add(new SqlParameter("@SupplierCode", SqlDbType.VarChar, 6));
                    objCmd.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.VarChar, 100));
                    objCmd.Parameters.Add(new SqlParameter("@ContractPerson", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@ShortName", SqlDbType.VarChar, 25));
                    objCmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 150));
                    objCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 30));
                    objCmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 30));
                    objCmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 30));
                    objCmd.Parameters.Add(new SqlParameter("@WebAddress", SqlDbType.VarChar, 20));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@Sp_PK"].Value = (Guid)oSupplierInfoDTO.PrimaryKey;
                    //objCmd.Parameters["@SupplierCode"].Value = Convert.ToString(oSupplierInfoDTO.SupplierCode);
                    objCmd.Parameters["@SupplierName"].Value = Convert.ToString(oSupplierInfoDTO.SupplierName);
                    objCmd.Parameters["@ContractPerson"].Value = Convert.ToString(oSupplierInfoDTO.ContractPerson);
                    objCmd.Parameters["@ShortName"].Value = Convert.ToString(oSupplierInfoDTO.ShortName);
                    objCmd.Parameters["@Address"].Value = Convert.ToString(oSupplierInfoDTO.Address);
                    objCmd.Parameters["@Phone"].Value = Convert.ToString(oSupplierInfoDTO.Phone);
                    objCmd.Parameters["@Fax"].Value = Convert.ToString(oSupplierInfoDTO.Fax);
                    objCmd.Parameters["@Email"].Value = Convert.ToString(oSupplierInfoDTO.Email);
                    objCmd.Parameters["@WebAddress"].Value = Convert.ToString(oSupplierInfoDTO.WebAddress);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oSupplierInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oSupplierInfoDTO.EntryDate);

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


        public override void Delete(object obj)
        {
            SupplierInfoDTO oSupplierInfoDTO = (SupplierInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  SupplierInfo where Sp_PK=@Sp_PK";

            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;

            try
            {
                objCmdDelete.Parameters.Add("@Sp_PK", SqlDbType.UniqueIdentifier, 16);

                objCmdDelete.Parameters["@Sp_PK"].Value = (Guid)oSupplierInfoDTO.PrimaryKey;

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
        
        public SupplierInfoDTO findByPKDTO(Guid pk)
        {
            SupplierInfoDTO oSupplierInfoDTO = new SupplierInfoDTO();
            //oSupplierInfoDTO.PrimaryKey = pk;

            string sqlSelect = "Select Sp_PK,SupplierCode,SupplierName,ContractPerson,ShortName,Address,Phone,Fax,Email,WebAddress,EntryBy,EntryDate From SupplierInfo where Sp_PK=@Sp_PK";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;


            try
            {
                objCmd.Parameters.Add("@Sp_PK", SqlDbType.UniqueIdentifier, 16);

                objCmd.Parameters["@Sp_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    oSupplierInfoDTO = populate(thisReader);
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
            return oSupplierInfoDTO;
        }


        public List<SupplierInfoDTO> getSupplierInfoData()
        {
            string sqlSelect = "Select Sp_PK,SupplierCode,SupplierName,ContractPerson,ShortName,Address,Phone,Fax,Email,WebAddress,EntryBy,EntryDate From SupplierInfo order by SupplierCode DESC";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            List<SupplierInfoDTO> oArrayList = new List<SupplierInfoDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    SupplierInfoDTO oSupplierInfoDTO = populate(thisReader);
                    oArrayList.Add(oSupplierInfoDTO);
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

        public SupplierInfoDTO GetSupplierInfoBYCode(string strCode)
        {
            SupplierInfoDTO oSupplierInfoDTO = new SupplierInfoDTO();
            //oSupplierInfoDTO.PrimaryKey = pk;

            string sqlSelect = "Select Sp_PK,SupplierCode,SupplierName,ContractPerson,ShortName,Address,Phone,Fax,Email,WebAddress,EntryBy,EntryDate From SupplierInfo where SupplierCode=@SupplierCode";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;


            try
            {
                objCmd.Parameters.Add(new SqlParameter("@SupplierCode", SqlDbType.VarChar, 6));

                objCmd.Parameters["@SupplierCode"].Value = strCode;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    oSupplierInfoDTO = populate(thisReader);
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
            return oSupplierInfoDTO;
        }

        public SupplierInfoDTO populate(SqlDataReader reader)
        {
            try
            {
                SupplierInfoDTO dto = new SupplierInfoDTO();

                dto.PrimaryKey = (Guid)reader["Sp_PK"];
                dto.SupplierCode = (string)reader["SupplierCode"];
                dto.SupplierName = (string)reader["SupplierName"];
                dto.ContractPerson = (string)reader["ContractPerson"];
                dto.ShortName = (string)reader["ShortName"];
                dto.Address = (string)reader["Address"];
                dto.Phone = (string)reader["Phone"];
                dto.Fax = (string)reader["Fax"];
                dto.Email = (string)reader["Email"];
                dto.WebAddress = (string)reader["WebAddress"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SupplierInfoDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}