using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;

using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DTO.DTO;
using DSL.POS.Common.Utility;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for ProductCategoryBLImp
    /// </summary>
    /// 

    public class ProductCategoryDALImp : CommonDALImp, IProductCategoryDAL
    {
        // Error Handling Developed By Samad
        // 05/12/06

        ClsErrorHandle cls = new ClsErrorHandle();

        private void getPKCode(ProductCategoryInfoDTO obj)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            string strPKCode = null;
            int PKSL = 0;

            string sqlSelect = "Select isnull(Max(PC_Code),0)+1 From ProductCategoryInfo";

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

            strPKCode = PKSL.ToString("00");
            obj.PC_Code = strPKCode;
        }

        public override void Save(object obj)
        {
            ProductCategoryInfoDTO oProductCategoryInfoDTO = (ProductCategoryInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oProductCategoryInfoDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                String sql = "Insert Into ProductCategoryInfo(PC_Code,PC_Description,EntryBy,EntryDate) values(@PC_Code,@PC_Description,@EntryBy,@EntryDate)";


                try
                {
                    getPKCode(oProductCategoryInfoDTO);
                    
                    objCmd.CommandText = sql;
                    
                    objCmd.Parameters.Add(new SqlParameter("@PC_Code", SqlDbType.VarChar, 2));
                    objCmd.Parameters.Add(new SqlParameter("@PC_Description", SqlDbType.VarChar, 50));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@PC_Code"].Value = Convert.ToString(oProductCategoryInfoDTO.PC_Code);
                    objCmd.Parameters["@PC_Description"].Value = Convert.ToString(oProductCategoryInfoDTO.PC_Description);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oProductCategoryInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oProductCategoryInfoDTO.EntryDate);

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
                String sql = "Update  ProductCategoryInfo set PC_Description=@PC_Description,EntryBy=@EntryBy,EntryDate=@EntryDate where PC_PK=@PC_PK ";

                
                try
                {
                    objCmd.CommandText = sql;
                    objCmd.Parameters.Add("@PC_Description", SqlDbType.VarChar, 50);
                    objCmd.Parameters.Add("@EntryBy", SqlDbType.VarChar, 50);
                    objCmd.Parameters.Add("@EntryDate", SqlDbType.DateTime);
                    objCmd.Parameters.Add("@PC_PK", SqlDbType.UniqueIdentifier, 16);


                    objCmd.Parameters["@PC_Description"].Value = Convert.ToString(oProductCategoryInfoDTO.PC_Description);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oProductCategoryInfoDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oProductCategoryInfoDTO.EntryDate);
                    objCmd.Parameters["@PC_PK"].Value = (Guid)oProductCategoryInfoDTO.PrimaryKey;

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


        public ProductCategoryDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public override void Delete(object obj)
        {
            ProductCategoryInfoDTO oProductCategoryInfoDTO = (ProductCategoryInfoDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  ProductCategoryInfo where PC_PK=@PC_PK ";
            
            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;
            
            try
            {
                objCmdDelete.Parameters.Add("@PC_PK", SqlDbType.UniqueIdentifier, 16);
                objCmdDelete.Parameters["@PC_PK"].Value = (Guid)oProductCategoryInfoDTO.PrimaryKey;
                
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

        
        public List<ProductCategoryInfoDTO> GetProductCategoryInfo()
        {

            List<ProductCategoryInfoDTO> productCategoriList = new List<ProductCategoryInfoDTO>();

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();
            SqlDataReader DR;
            objcmd.Connection = objmycon;
            objcmd.CommandText = "SELECT PC_PK, PC_Code, PC_Description,EntryBy,EntryDate FROM ProductCategoryInfo ORDER BY PC_Code";

            try
            {
                objmycon.Open();
                DR = objcmd.ExecuteReader();

                while (DR.Read())
                {
                    ProductCategoryInfoDTO ProcInfo = new ProductCategoryInfoDTO();//(Guid)DR[0],(string)DR[1],(string)DR[1]);

                    ProcInfo.PrimaryKey = (Guid)DR[0];
                    ProcInfo.PC_Code = (string)DR[1];
                    ProcInfo.PC_Description = (string)DR[2];
                    productCategoriList.Add(ProcInfo);
                }
                DR.Close();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                
                objmycon.Close();
            }
            return productCategoriList;
        }

        public ProductCategoryInfoDTO FindByPK(Guid pk)
        {
            ProductCategoryInfoDTO pcDTO = new ProductCategoryInfoDTO();
            string sqlSelect = "SELECT PC_PK, PC_Code, PC_Description,EntryBy,EntryDate FROM ProductCategoryInfo WHERE PC_PK=@PC_PK";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
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
                    pcDTO = Populate(thisReader);
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
            return pcDTO;

        }

        public ProductCategoryInfoDTO Populate(SqlDataReader reader)
        {
            try
            {
                ProductCategoryInfoDTO dto = new ProductCategoryInfoDTO();
                dto.PrimaryKey = (Guid)reader["PC_PK"];
                dto.PC_Code = (string)reader["PC_Code"];
                dto.PC_Description = (string)reader["PC_Description"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

    }
}