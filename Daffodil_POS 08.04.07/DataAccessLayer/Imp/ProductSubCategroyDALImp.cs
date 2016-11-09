using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Collections;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DTO.DTO;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for ProductSubCategroyDALImp
    /// </summary>
    /// 

    public class ProductSubCategroyDALImp : CommonDALImp, IProductSubCategoryDAL
    {
        
        private void getPKCode(ProductSubCategoryInfoDTO obj)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            string strPKCode = null;
            int PKSL = 0;

            string sqlSelect = "Select isnull(Max(PSC_Code),0)+1 From ProductSubCategoryInfo";

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

            strPKCode = PKSL.ToString("000");
            obj.PSC_Code = strPKCode;
            //return strPKCode;
        }

        public override void Save(object obj)
        {
            ProductSubCategoryInfoDTO oProductSubCategoryInfoDTO = (ProductSubCategoryInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oProductSubCategoryInfoDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                //string strset = getPKCode(oProductCategoryInfoDTO);
                String sql = "Insert Into ProductSubCategoryInfo(PC_PK,PSC_Code,PSC_Description,EntryBy,EntryDate) values(@PC_PK,@PSC_Code,@PSC_Description,@EntryBy,@EntryDate)";

                try
                {

                    getPKCode(oProductSubCategoryInfoDTO);

                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@PC_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@PSC_Code", SqlDbType.VarChar, 3));
                    objCmd.Parameters.Add(new SqlParameter("@PSC_Description", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@PC_PK"].Value = (Guid)oProductSubCategoryInfoDTO.PC_PK;
                    objCmd.Parameters["@PSC_Code"].Value = Convert.ToString(oProductSubCategoryInfoDTO.PSC_Code);
                    objCmd.Parameters["@PSC_Description"].Value = Convert.ToString(oProductSubCategoryInfoDTO.PSC_Description);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oProductSubCategoryInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oProductSubCategoryInfoDTO.EntryDate);

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
                String sql = "Update  ProductSubCategoryInfo set PC_PK=@PC_PK,PSC_Description=@PSC_Description,EntryBy=@EntryBy,EntryDate=@EntryDate where PSC_PK=@PSC_PK ";

                try
                {
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@PSC_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@PC_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@PSC_Description", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@PSC_PK"].Value = (Guid)oProductSubCategoryInfoDTO.PrimaryKey;
                    objCmd.Parameters["@PC_PK"].Value = (Guid)oProductSubCategoryInfoDTO.PC_PK;
                    objCmd.Parameters["@PSC_Description"].Value = Convert.ToString(oProductSubCategoryInfoDTO.PSC_Description);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oProductSubCategoryInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oProductSubCategoryInfoDTO.EntryDate);

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
            ProductSubCategoryInfoDTO oProductSubCategoryInfoDTO = (ProductSubCategoryInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  ProductSubCategoryInfo where PSC_PK=@PSC_PK";

            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;

            try
            {


                objCmdDelete.Parameters.Add("@PSC_PK", SqlDbType.UniqueIdentifier, 16);
                
                objCmdDelete.Parameters["@PSC_PK"].Value = (Guid)oProductSubCategoryInfoDTO.PrimaryKey;
                
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
        /// Get Product Category all Information
        /// </summary>
        /// <returns></returns>
        public List<ProductSubCategoryInfoDTO> getProductSubCategoryData()
        {
            string sqlSelect = "Select PSC_PK,PC_PK,PSC_Code,PSC_Description,EntryBy,EntryDate From ProductSubCategoryInfo order by PSC_Code DESC";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            List<ProductSubCategoryInfoDTO> oArrayList = new List<ProductSubCategoryInfoDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    ProductSubCategoryInfoDTO oProductSubCategoryInfoDTO = Populate(thisReader);
                    oArrayList.Add(oProductSubCategoryInfoDTO);
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
        /// Get Product Category Information corresponding definite Product Primary Key.
        /// </summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        public List<ProductSubCategoryInfoDTO> getProductSubCategoryDataByPC(Guid pk)
        {
            string sqlSelect = "Select PSC_PK,PC_PK,PSC_Code,PSC_Description,EntryBy,EntryDate From ProductSubCategoryInfo Where PC_PK=@PC_PK";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            List<ProductSubCategoryInfoDTO> oArrayList = new List<ProductSubCategoryInfoDTO>();
            SqlCommand objCmd = sqlConn.CreateCommand();
            
            try
            {
                objCmd.CommandText = sqlSelect;
                objCmd.Connection = sqlConn;
                objCmd.Parameters.Add("@PC_PK", SqlDbType.UniqueIdentifier, 16);
                objCmd.Parameters["@PC_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    ProductSubCategoryInfoDTO oProductSubCategoryInfoDTO = Populate(thisReader);
                    oArrayList.Add(oProductSubCategoryInfoDTO);
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
        /// Get Product Category Information corresponding definite Product Primary Key.
        /// </summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        public ProductSubCategoryInfoDTO FindByPK(Guid pk)
        {
            ProductSubCategoryInfoDTO pscDTO = new ProductSubCategoryInfoDTO();
            string sqlSelect = "SELECT PSC_PK, PC_PK,PSC_Code, PSC_Description,EntryBy,EntryDate FROM ProductSubCategoryInfo WHERE PSC_PK=@PSC_PK";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            try
            {
                objCmd.CommandText = sqlSelect;
                objCmd.Connection = sqlConn;
                objCmd.Parameters.Add("@PSC_PK", SqlDbType.UniqueIdentifier, 16);
                objCmd.Parameters["@PSC_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    pscDTO = Populate(thisReader);
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
            return pscDTO;
        }

        /// <summary>
        /// Set All data in Domain() 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public ProductSubCategoryInfoDTO Populate(SqlDataReader reader)
        {
            try
            {
                ProductSubCategoryInfoDTO dto = new ProductSubCategoryInfoDTO();

                dto.PrimaryKey = (Guid)reader["PSC_PK"];
                dto.PC_PK = (Guid)reader["PC_PK"];
                dto.PSC_Code = (string)reader["PSC_Code"];
                dto.PSC_Description = (string)reader["PSC_Description"];
                dto.EntryBy  = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];
                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        public ProductSubCategroyDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}