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

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for ProductBrandDALImp
    /// </summary>
    /// 
    // Error Handling developed by Samad
    // 05/12/06


    public class ProductBrandDALImp : CommonDALImp, IProductBrandDAL
    {
        private string Get_NewProductBrandCode(ProductBrandInfoDTO dto)
        {
            string pbCode = null;
            int pbCodeNo = 0;
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();

            objCmd.CommandText = "Select Isnull(Max(cast(PB_Code as int)),0 )+1 From ProductBrandInfo";
            try
            {
                objMyCon.Open();
                objCmd.Connection = objMyCon;
                pbCodeNo = (int)objCmd.ExecuteScalar();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objMyCon.Close();
            }
            
            pbCode = pbCodeNo.ToString("0000");
            return pbCode;
        }

        public override void Save(object Obj)
        {
            ProductBrandInfoDTO dto = (ProductBrandInfoDTO)Obj;

            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();

            if (dto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                dto.PB_Code = Get_NewProductBrandCode(dto);

                objCmd.CommandText = "Insert Into ProductBrandInfo(PB_Code,PB_Name,EntryBy,EntryDate) Values(@PB_Code,@PB_Name,@EntryBy,@EntryDate)";
                objCmd.Parameters.Add(new SqlParameter("@PB_Code", SqlDbType.VarChar, 4));
                objCmd.Parameters.Add(new SqlParameter("@PB_Name", SqlDbType.VarChar, 50));

                objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 6));
                objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime, 8));

                objCmd.Parameters["@PB_Code"].Value = (string)dto.PB_Code;
                objCmd.Parameters["@PB_Name"].Value = (string)dto.PB_Name;

                objCmd.Parameters["@Entryby"].Value = (string)dto.EntryBy;
                objCmd.Parameters["@EntryDate"].Value = (DateTime)dto.EntryDate;
            }
            else
            {
                objCmd.CommandText = "Update ProductBrandInfo Set PB_Name=@PB_Name Where PB_PK=@PB_PK";
                objCmd.Parameters.Add(new SqlParameter("@PB_PK", SqlDbType.UniqueIdentifier, 16));
                objCmd.Parameters.Add(new SqlParameter("@PB_Name", SqlDbType.VarChar, 50));
                objCmd.Parameters["@PB_PK"].Value = (Guid)dto.PrimaryKey;
                objCmd.Parameters["@PB_Name"].Value = (string)dto.PB_Name;
            }
            try
            {
                objCmd.Connection = objMyCon;
                objMyCon.Open();
                objCmd.ExecuteNonQuery();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objMyCon.Close();
            }
        }

        public override void Delete(object PrimaryKey)
        {
            ProductBrandInfoDTO dto = (ProductBrandInfoDTO)PrimaryKey;

            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();

            objCmd.CommandText = "Delete From ProductBrandInfo Where PB_PK=@PB_PK";
            objCmd.Parameters.Add(new SqlParameter("@PB_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters["@PB_PK"].Value = (Guid)dto.PrimaryKey;

            objCmd.Connection = objMyCon;
            try
            {
                objMyCon.Open();
                objCmd.ExecuteNonQuery();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objMyCon.Close();
            }
        }

        public List<ProductBrandInfoDTO> GetProductBrand()
        {

            List<ProductBrandInfoDTO> productBrandiList = new List<ProductBrandInfoDTO>();
            SqlDataReader DR;
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objMyCon;
            objCmd.CommandText = "SELECT PB_PK, PB_Code, PB_Name FROM ProductBrandInfo ORDER BY PB_Code DESC";

            try
            {
                objMyCon.Open();
                DR = objCmd.ExecuteReader();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            while (DR.Read())
            {
                ProductBrandInfoDTO pbDto = new ProductBrandInfoDTO();//(Guid)DR[0],(string)DR[1],(string)DR[1]);

                pbDto.PrimaryKey = (Guid)DR[0];
                pbDto.PB_Code = (string)DR[1];
                pbDto.PB_Name = (string)DR[2];
                productBrandiList.Add(pbDto);
            }

            DR.Close();
            objMyCon.Close();
            return productBrandiList;
        }

        public ArrayList GetData()
        {
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCom = new SqlCommand();
            ArrayList brandList = new ArrayList();
            SqlDataReader reader;
            objCom.Connection = objMyCon;
            objCom.CommandText = "SELECT PB_PK, PB_Code, PB_Name FROM ProductBrandInfo ORDER BY PB_Code DESC";

            try
            {
                objMyCon.Open();
                reader = objCom.ExecuteReader();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            while (reader.Read())
            {
                ProductBrandInfoDTO dto = Populate(reader);
                brandList.Add(dto);
            }

            reader.Close();
            reader.Dispose();

            return brandList;
        }

        public ProductBrandInfoDTO FindByPK(Guid pk)
        {
            ProductBrandInfoDTO pbDTO = new ProductBrandInfoDTO();
            string sqlSelect = "SELECT PB_PK, PB_Code, PB_Name FROM ProductBrandInfo WHERE PB_PK=@PB_PK";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            try
            {
                objCmd.CommandText = sqlSelect;
                objCmd.Connection = sqlConn;
                objCmd.Parameters.Add("@PB_PK", SqlDbType.UniqueIdentifier, 16);
                objCmd.Parameters["@PB_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    pbDTO = Populate(thisReader);
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
            return pbDTO;
        }

        public ProductBrandInfoDTO Populate(SqlDataReader reader)
        {
            try
            {
                ProductBrandInfoDTO dto = new ProductBrandInfoDTO();

                dto.PrimaryKey = (Guid)reader["PB_PK"];
                dto.PB_Code = (string)reader["PB_Code"];
                dto.PB_Name = (string)reader["PB_Name"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }


        public ProductBrandDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}