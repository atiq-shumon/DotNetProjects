using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for BranchTypeInfoDALImp
    /// </summary>
    /// 
    // Error Handling developed by Samad
    // 05/12/06


    public class BranchTypeInfoDALImp : CommonDALImp, IBranchTypeInfoDAL
    {
        private void getPKCode(BranchTypeInfoDTO obj)
        {

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            string strPKCode = null;
            int PKSL = 0;

            string sqlSelect = "Select isnull(Max(BT_Code),0)+1 From BranchTypeInfo";

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

            strPKCode = PKSL.ToString("0");
            obj.BT_Code = strPKCode;
            //return strPKCode;
        }

        public override void Save(object obj)
        {
            BranchTypeInfoDTO oBranchTypeInfoDTO = (BranchTypeInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oBranchTypeInfoDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                //string strset = getPKCode(oProductCategoryInfoDTO);
                String sql = "Insert Into BranchTypeInfo(BT_Code,BT_Name,EntryBy,EntryDate) values(@BT_Code,@BT_Name,@EntryBy,@EntryDate)";


                try
                {

                    getPKCode(oBranchTypeInfoDTO);

                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@BT_Code", SqlDbType.VarChar, 1));
                    objCmd.Parameters.Add(new SqlParameter("@BT_Name", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@BT_Code"].Value = Convert.ToString(oBranchTypeInfoDTO.BT_Code);
                    objCmd.Parameters["@BT_Name"].Value = Convert.ToString(oBranchTypeInfoDTO.BT_Name);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oBranchTypeInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oBranchTypeInfoDTO.EntryDate);

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

                String sql = "Update  BranchTypeInfo set BT_Name=@BT_Name,EntryBy=@EntryBy,EntryDate=@EntryDate where BT_PK=@BT_PK";

                
                try
                {
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@BT_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@BT_Name", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@BT_PK"].Value = (Guid)oBranchTypeInfoDTO.PrimaryKey;
                    objCmd.Parameters["@BT_Name"].Value = Convert.ToString(oBranchTypeInfoDTO.BT_Name);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oBranchTypeInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oBranchTypeInfoDTO.EntryDate);

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
            BranchTypeInfoDTO oSupplierInfoDTO = (BranchTypeInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  BranchTypeInfo where BT_PK=@BT_PK";

            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;

            try
            {


                objCmdDelete.Parameters.Add("@BT_PK", SqlDbType.UniqueIdentifier, 16);

                objCmdDelete.Parameters["@BT_PK"].Value = (Guid)oSupplierInfoDTO.PrimaryKey;

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

        public BranchTypeInfoDTO findByPKDTO(Guid pk)
        {
            BranchTypeInfoDTO oBranchTypeInfoDTO = new BranchTypeInfoDTO();
            //oBranchTypeInfoDTO.PrimaryKey = pk;

            string sqlSelect = "Select BT_PK,BT_Code,BT_Name,EntryBy,EntryDate From BranchTypeInfo where BT_PK=@BT_PK";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;


            try
            {
                objCmd.Parameters.Add("@BT_PK", SqlDbType.UniqueIdentifier, 16);

                objCmd.Parameters["@BT_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    oBranchTypeInfoDTO = populate(thisReader);
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
            return oBranchTypeInfoDTO;
        }

        public List<BranchTypeInfoDTO> getBranchTypeInfoData()
        {
            string sqlSelect = "Select BT_PK,BT_Code,BT_Name,EntryBy,EntryDate From BranchTypeInfo order by BT_Code";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            List<BranchTypeInfoDTO> oArrayList = new List<BranchTypeInfoDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    BranchTypeInfoDTO oBranchTypeInfoDTO = populate(thisReader);
                    oArrayList.Add(oBranchTypeInfoDTO);
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

        public BranchTypeInfoDTO populate(SqlDataReader reader)
        {
            try
            {
                BranchTypeInfoDTO dto = new BranchTypeInfoDTO();

                dto.PrimaryKey = (Guid)reader["BT_PK"];
                dto.BT_Code = (string)reader["BT_Code"];
                dto.BT_Name = (string)reader["BT_Name"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        public BranchTypeInfoDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }
}