#region Author
/* Name:
 * Created On:
 * Created by:
 * Purpose
 * Modified on:
 */
#endregion
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DTO.DTO;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for ProductInfoDALImp
    /// </summary>
    public class ProductInfoDALImp : CommonDALImp, IProductInfoDAL
    {
        private static ProductInfoDALImp pInfo = new ProductInfoDALImp();

        public static ProductInfoDALImp GetInstance()
        {
            return pInfo;
        }

        private string Get_NewProductInfoCode(ProductInfoDTO dto)
        {
            
            string pcCode = null;   //2
            string pscCode = null;  //3
            string pbCode = null;   //4
            // generate Product Code combination of Year+Month+Day+Hour+Minute+Second

            pscCode = Convert.ToString(DateTime.Today.Day.ToString("00")+1);
            pbCode = Convert.ToString(DateTime.Today.Year);
            
            string pCode = null;    //13
            int pCodeNo = 0;
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();

            objCmd.CommandText = "SELECT PC_Code FROM ProductCategoryInfo WHERE (PC_PK = @PC_PK)";
            objCmd.Parameters.Add(new SqlParameter("@PC_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters["@PC_PK"].Value = (Guid)dto.PC_PrimaryKey;
            objMyCon.Open();
            objCmd.Connection = objMyCon;
            pcCode = (string)objCmd.ExecuteScalar();
            objMyCon.Close();
            
            //objCmd.CommandText = "SELECT PSC_Code FROM ProductSubCategoryInfo WHERE (PSC_PK = @PSC_PK)";
            //objCmd.Parameters.Add(new SqlParameter("@PSC_PK", SqlDbType.UniqueIdentifier, 16));
            //objCmd.Parameters["@PSC_PK"].Value = (Guid)dto.PSC_PrimaryKey;
            //objMyCon.Open();
            //objCmd.Connection = objMyCon;
            //pscCode = (string)objCmd.ExecuteScalar();
            //objMyCon.Close();
            
            //objCmd.CommandText = "SELECT PB_Code FROM ProductBrandInfo WHERE (PB_PK = @PB_PK)";
            //objCmd.Parameters.Add(new SqlParameter("@PB_PK", SqlDbType.UniqueIdentifier, 16));
            //objCmd.Parameters["@PB_PK"].Value = (Guid)dto.PB_PrimaryKey;
            //objMyCon.Open();
            //objCmd.Connection = objMyCon;
            //pbCode = (string)objCmd.ExecuteScalar();
            //objMyCon.Close();
            
            objCmd.CommandText = "SELECT ISNULL(MAX(CAST(RIGHT(P_Code, 4) AS int)), 0) + 1 FROM ProductInfo " +
                                "WHERE (SUBSTRING(P_Code, 1, 2) = @pcCode) " +
                                "AND (SUBSTRING(P_Code, 3, 3) = @pscCode) " +
                                "AND (SUBSTRING(P_Code, 6, 4) = @pbCode)";
            objCmd.Parameters.Add(new SqlParameter("@pcCode", SqlDbType.VarChar, 2));
            objCmd.Parameters["@pcCode"].Value = (string)pcCode;
            objCmd.Parameters.Add(new SqlParameter("@pscCode", SqlDbType.VarChar, 3));
            objCmd.Parameters["@pscCode"].Value = (string)pscCode;
            objCmd.Parameters.Add(new SqlParameter("@pbCode", SqlDbType.VarChar, 4));
            objCmd.Parameters["@pbCode"].Value = (string)pbCode;
            objMyCon.Open();
            objCmd.Connection = objMyCon;
            pCodeNo = (int)objCmd.ExecuteScalar();
            objMyCon.Close();
            pCode = pcCode + pscCode + pbCode + pCodeNo.ToString("0000");

            return pCode;
        }

        public override void Save(object Obj)
        {
            ProductInfoDTO dto = (ProductInfoDTO)Obj;

            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();

            if (dto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                dto.P_Code = Get_NewProductInfoCode(dto);
                objCmd.CommandText = "Insert Into ProductInfo(PC_PK,PSC_PK,PB_PK,P_Code,P_Name,P_Style,P_SalesPrice,P_CostPrice,P_Tax,P_VAT,P_Discount,P_MinLevel,P_MaxLevel,P_ReorderLevel,P_Status,P_SalesPriceDate,P_CostPriceDate,P_Warranty,P_WarrantyMonth,PU_PK,EntryBy,EntryDate) Values(@PC_PK,@PSC_PK,@PB_PK,@P_Code,@P_Name,@P_Style,@P_SalesPrice,@P_CostPrice,@P_Tax,@P_VAT,@P_Discount,@P_MinLevel,@P_MaxLevel,@P_ReorderLevel,@P_Status,@P_SalesPriceDate,@P_CostPriceDate,@P_Warranty,@P_WarrantyMonth,@PU_PK,@EntryBy,@EntryDate)";
            }
            else
            {
                objCmd.CommandText = "Update ProductInfo Set PC_PK=@PC_PK,PSC_PK=@PSC_PK,PB_PK=@PB_PK,P_Code=@P_Code,P_Name=@P_Name,P_Style=@P_Style,P_SalesPrice=@P_SalesPrice,P_CostPrice=@P_CostPrice,P_Tax=@P_Tax,P_VAT=@P_VAT,P_Discount=@P_Discount,P_MinLevel=@P_MinLevel,P_MaxLevel=@P_MaxLevel,P_ReorderLevel=@P_ReorderLevel,P_Status=@P_Status,P_SalesPriceDate=@P_SalesPriceDate,P_CostPriceDate=@P_CostPriceDate,P_Warranty=@P_Warranty,P_WarrantyMonth=@P_WarrantyMonth,PU_PK=@PU_PK,EntryBy=@EntryBy,EntryDate=@EntryDate Where P_PK=@P_PK";
                objCmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier, 16));
                objCmd.Parameters["@P_PK"].Value = (Guid)dto.PrimaryKey;
            }

            objCmd.Parameters.Add(new SqlParameter("@PC_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters.Add(new SqlParameter("@PSC_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters.Add(new SqlParameter("@PB_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters.Add(new SqlParameter("@PU_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters.Add(new SqlParameter("@P_Code", SqlDbType.VarChar, 13));
            objCmd.Parameters.Add(new SqlParameter("@P_Name", SqlDbType.VarChar, 50));
            objCmd.Parameters.Add(new SqlParameter("@P_Style", SqlDbType.VarChar, 100));
            objCmd.Parameters.Add(new SqlParameter("@P_SalesPrice", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_CostPrice", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_Tax", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_VAT", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_Discount", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_MinLevel", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_MaxLevel", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_ReorderLevel", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_Status", SqlDbType.Bit, 1));
            objCmd.Parameters.Add(new SqlParameter("@P_SalesPriceDate", SqlDbType.DateTime, 8));
            objCmd.Parameters.Add(new SqlParameter("@P_CostPriceDate", SqlDbType.DateTime, 8));
            objCmd.Parameters.Add(new SqlParameter("@P_Warranty", SqlDbType.Bit, 1));
            objCmd.Parameters.Add(new SqlParameter("@P_WarrantyMonth", SqlDbType.Int, 4));
            objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 6));
            objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime, 8));

            objCmd.Parameters["@PC_PK"].Value = (Guid)dto.PC_PrimaryKey;
            objCmd.Parameters["@PSC_PK"].Value = (Guid)dto.PSC_PrimaryKey;
            objCmd.Parameters["@PB_PK"].Value = (Guid)dto.PB_PrimaryKey;
            objCmd.Parameters["@PU_PK"].Value = (Guid)dto.PU_PrimaryKey;
            objCmd.Parameters["@P_Code"].Value = (string)dto.P_Code;
            objCmd.Parameters["@P_Name"].Value = (string)dto.P_Name;
            objCmd.Parameters["@P_Style"].Value = (string)dto.P_Style;
            objCmd.Parameters["@P_SalesPrice"].Value = Convert.ToDecimal(dto.P_SalesPrice);
            objCmd.Parameters["@P_CostPrice"].Value = Convert.ToDecimal(dto.P_CostPrice);
            objCmd.Parameters["@P_Tax"].Value = Convert.ToDecimal(dto.P_Tax);
            objCmd.Parameters["@P_VAT"].Value = Convert.ToDecimal(dto.P_VAT);
            objCmd.Parameters["@P_Discount"].Value = Convert.ToDecimal(dto.P_Discount);
            objCmd.Parameters["@P_MinLevel"].Value = Convert.ToDecimal(dto.P_MinLevel);
            objCmd.Parameters["@P_MaxLevel"].Value = Convert.ToDecimal(dto.P_MaxLevel);
            objCmd.Parameters["@P_ReorderLevel"].Value = Convert.ToDecimal(dto.P_ReorderLevel);
            objCmd.Parameters["@P_Status"].Value = Convert.ToBoolean(dto.P_Status);
            objCmd.Parameters["@P_SalesPriceDate"].Value = (DateTime)dto.P_SalesPriceDate;
            objCmd.Parameters["@P_CostPriceDate"].Value = (DateTime)dto.P_CostPriceDate;
            objCmd.Parameters["@P_Warranty"].Value = Convert.ToBoolean(dto.P_Warranty);
            objCmd.Parameters["@P_WarrantyMonth"].Value = Convert.ToDecimal(dto.P_WarrantyMonth);
            objCmd.Parameters["@EntryBy"].Value = (string)dto.EntryBy;
            objCmd.Parameters["@EntryDate"].Value = (DateTime)dto.EntryDate;

            objCmd.Connection = objMyCon;
            objMyCon.Open();
            objCmd.ExecuteNonQuery();
            objMyCon.Close();
        }

        public override void Delete(object obj)
        {
            ProductInfoDTO pDto = (ProductInfoDTO)obj;
            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();
            objcmd.CommandText = "Delete From ProductInfo WHERE P_PK=@P_PK";
            objcmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier, 16));
            objcmd.Parameters["@P_PK"].Value = (Guid)pDto.PrimaryKey;
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
            }
        }

        public List<ProductInfoDTO> GetProductInfo()
        {

            List<ProductInfoDTO> productInfoList = new List<ProductInfoDTO>();
            SqlDataReader DR;
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objMyCon;
            objCmd.CommandText = "SELECT     ProductInfo.P_PK, ProductInfo.P_Code, ProductInfo.PC_PK, ProductInfo.PSC_PK, ProductInfo.PB_PK, ProductInfo.P_Name, ProductInfo.P_Style, "+
                                  "ProductInfo.P_SalesPrice, ProductInfo.P_CostPrice, ProductInfo.P_Tax, ProductInfo.P_VAT, ProductInfo.P_Discount, ProductInfo.P_MinLevel, "+
                                  "ProductInfo.P_MaxLevel, ProductInfo.P_ReorderLevel, ProductInfo.P_Status, ProductInfo.P_SalesPricedate, ProductInfo.P_CostPricedate, "+
                                  "ProductInfo.P_Warranty, ProductInfo.P_WarrantyMonth, ProductInfo.PU_PK, ProductInfo.EntryBy, ProductInfo.EntryDate, "+
                                  "ProductCategoryInfo.PC_Description "+
                                    "FROM  ProductInfo INNER JOIN "+
                                    "ProductCategoryInfo ON ProductInfo.PC_PK = ProductCategoryInfo.PC_PK "+
                                    "ORDER BY ProductInfo.P_Code DESC ";
            //objCmd.CommandText = "SELECT ProductInfo.P_PK, ProductInfo.P_Code, ProductInfo.PC_PK, ProductInfo.PSC_PK, ProductInfo.PB_PK, ProductInfo.P_Name, ProductInfo.P_Style, " +
            //          "ProductInfo.P_SalesPrice, ProductInfo.P_CostPrice, ProductInfo.P_Tax, ProductInfo.P_VAT, ProductInfo.P_Discount, ProductInfo.P_MinLevel, " +
            //          "ProductInfo.P_MaxLevel, ProductInfo.P_ReorderLevel, ProductInfo.P_status, ProductInfo.P_SalesPricedate, ProductInfo.P_CostPricedate, " +
            //          "ProductInfo.P_Warranty, ProductInfo.P_WarrantyMonth, ProductInfo.PU_PK, ProductInfo.EntryBy, ProductInfo.EntryDate, " +
            //          "ProductCategoryInfo.PC_Description, ProductSubCategoryInfo.PSC_Description, ProductBrandInfo.PB_Name, ProductUnitInfo.PU_Name " +
            //            "FROM ProductInfo INNER JOIN " +
            //          "ProductCategoryInfo ON ProductInfo.PC_PK = ProductCategoryInfo.PC_PK " +
            //          "ProductBrandInfo ON ProductInfo.PB_PK = ProductBrandInfo.PB_PK INNER JOIN " +
            //          "ProductUnitInfo ON ProductInfo.PU_PK = ProductUnitInfo.PU_PK INNER JOIN " +
            //          "ProductSubCategoryInfo ON ProductInfo.PSC_PK = ProductSubCategoryInfo.PSC_PK " +
            //          "ORDER BY ProductInfo.P_Code DESC";
                        
            try
            {
                objMyCon.Open();
                DR = objCmd.ExecuteReader();
                while (DR.Read())
                {
                    ProductInfoDTO pDto = new ProductInfoDTO();

                    pDto.PrimaryKey = (Guid)DR[0];
                    pDto.P_Code = (string)DR[1];
                    pDto.PC_PrimaryKey = (Guid)DR[2];
                    pDto.PSC_PrimaryKey = (Guid)DR[3];
                    pDto.PB_PrimaryKey = (Guid)DR[4];
                    pDto.P_Name = (string)DR[5];
                    pDto.P_Style = (string)DR[6];
                    pDto.P_SalesPrice = Convert.ToDecimal(DR[7]);
                    pDto.P_CostPrice = Convert.ToDecimal(DR[8]);
                    pDto.P_Tax = Convert.ToDecimal(DR[9]);
                    pDto.P_VAT = Convert.ToDecimal(DR[10]);
                    pDto.P_Discount = Convert.ToDecimal(DR[11]);
                    pDto.P_MinLevel = Convert.ToDecimal(DR[12]);
                    pDto.P_MaxLevel = Convert.ToDecimal(DR[13]);
                    pDto.P_ReorderLevel = Convert.ToDecimal(DR[14]);
                    pDto.P_Status = (Boolean)DR[15];
                    pDto.P_SalesPriceDate = (DateTime)DR[16];
                    pDto.P_CostPriceDate = (DateTime)DR[17];
                    pDto.P_Warranty = (Boolean)DR[18];
                    pDto.P_WarrantyMonth = (int)DR[19];
                    pDto.PU_PrimaryKey = (Guid)DR[20];
                    pDto.EntryBy = (string)DR[21];
                    pDto.EntryDate = (DateTime)DR[22];

                    productInfoList.Add(pDto);
                }

                DR.Close();
                objMyCon.Close();
                return productInfoList;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        public ProductInfoDTO FindByPK(Guid pk)
        {
            ProductInfoDTO pInfoDTO = new ProductInfoDTO();
            string sqlSelect = "SELECT     ProductInfo.P_PK, ProductInfo.P_Code, ProductInfo.PC_PK, ProductInfo.PSC_PK, ProductInfo.PB_PK, ProductInfo.P_Name, ProductInfo.P_Style, " +
                                  "ProductInfo.P_SalesPrice, ProductInfo.P_CostPrice, ProductInfo.P_Tax, ProductInfo.P_VAT, ProductInfo.P_Discount, ProductInfo.P_MinLevel, " +
                                  "ProductInfo.P_MaxLevel, ProductInfo.P_ReorderLevel, ProductInfo.P_Status, ProductInfo.P_SalesPricedate, ProductInfo.P_CostPricedate, " +
                                  "ProductInfo.P_Warranty, ProductInfo.P_WarrantyMonth, ProductInfo.PU_PK, ProductInfo.EntryBy, ProductInfo.EntryDate, " +
                                  "ProductCategoryInfo.PC_Description " +
                                    "FROM  ProductInfo INNER JOIN " +
                                    "ProductCategoryInfo ON ProductInfo.PC_PK = ProductCategoryInfo.PC_PK " +
                                    "WHERE P_PK=@P_PK ";
            //string sqlSelect = "SELECT ProductInfo.P_PK, ProductInfo.P_Code, ProductInfo.PC_PK, ProductInfo.PSC_PK, ProductInfo.PB_PK, ProductInfo.P_Name, ProductInfo.P_Style, " +
            //          "ProductInfo.P_SalesPrice, ProductInfo.P_CostPrice, ProductInfo.P_Tax, ProductInfo.P_VAT, ProductInfo.P_Discount, ProductInfo.P_MinLevel, " +
            //          "ProductInfo.P_MaxLevel, ProductInfo.P_ReorderLevel, ProductInfo.P_status, ProductInfo.P_SalesPricedate, ProductInfo.P_CostPricedate, " +
            //          "ProductInfo.P_Warranty, ProductInfo.P_WarrantyMonth, ProductInfo.PU_PK, ProductInfo.EntryBy, ProductInfo.EntryDate, " +
            //          "ProductCategoryInfo.PC_Description, ProductSubCategoryInfo.PSC_Description, ProductBrandInfo.PB_Name, ProductUnitInfo.PU_Name " +
            //            "FROM ProductInfo INNER JOIN " +
            //          "ProductCategoryInfo ON ProductInfo.PC_PK = ProductCategoryInfo.PC_PK INNER JOIN " +
            //          "ProductBrandInfo ON ProductInfo.PB_PK = ProductBrandInfo.PB_PK INNER JOIN " +
            //          "ProductUnitInfo ON ProductInfo.PU_PK = ProductUnitInfo.PU_PK INNER JOIN " +
            //          "ProductSubCategoryInfo ON ProductInfo.PSC_PK = ProductSubCategoryInfo.PSC_PK " +
            //            "WHERE P_PK=@P_PK";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            try
            {
                objCmd.CommandText = sqlSelect;
                objCmd.Connection = sqlConn;
                objCmd.Parameters.Add("@P_PK", SqlDbType.UniqueIdentifier, 16);
                objCmd.Parameters["@P_PK"].Value = pk;
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    pInfoDTO = Populate(thisReader);
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
            return pInfoDTO;
        }

        public ProductInfoDTO Populate(SqlDataReader reader)
        {
            try
            {
                ProductInfoDTO dto = new ProductInfoDTO();

                dto.PrimaryKey = (Guid)reader["P_PK"];
                dto.PC_PrimaryKey = (Guid)reader["PC_PK"];
                dto.PSC_PrimaryKey = (Guid)reader["PSC_PK"];
                dto.PB_PrimaryKey = (Guid)reader["PB_PK"];
                dto.P_Code = (string)reader["P_Code"];
                dto.P_Name = (string)reader["P_Name"];
                dto.P_Style = (string)reader["P_Style"];
                dto.P_SalesPrice = Convert.ToDecimal(reader["P_SalesPrice"]);
                dto.P_CostPrice = Convert.ToDecimal(reader["P_CostPrice"]);
                dto.P_Tax = Convert.ToDecimal(reader["P_Tax"]);
                dto.P_VAT = Convert.ToDecimal(reader["P_VAT"]);
                dto.P_Discount = Convert.ToDecimal(reader["P_Discount"]);
                dto.P_MinLevel = Convert.ToDecimal(reader["P_MinLevel"]);
                dto.P_MaxLevel = Convert.ToDecimal(reader["P_MaxLevel"]);
                dto.P_ReorderLevel = Convert.ToDecimal(reader["P_ReorderLevel"]);
                dto.P_Status = (Boolean)reader["P_Status"];
                dto.P_SalesPriceDate = (DateTime)reader["P_SalesPricedate"];
                dto.P_CostPriceDate = (DateTime)reader["P_CostPricedate"];
                dto.P_Warranty = (Boolean)reader["P_Warranty"];
                dto.P_WarrantyMonth = (int)reader["P_WarrantyMonth"];
                dto.PU_PrimaryKey = (Guid)reader["PU_PK"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        /// <summary>
        /// Get Primary Key corresponding Product Code
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns> Primary Key</returns>
        /// 
        public Guid GetPKBYCode(string strCode)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            Guid guidCust_ID = new Guid();

            string sqlSelect = "Select P_PK From ProductInfo where P_Code=@P_Code";

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;

            objCmd.Parameters.Add("@P_Code", SqlDbType.VarChar, 13);
            objCmd.Parameters["@P_Code"].Value = strCode;

            try
            {
                sqlConn.Open();
                SqlDataReader sqlDReader = objCmd.ExecuteReader();
                
                if (sqlDReader.Read())
                    guidCust_ID = (Guid)sqlDReader["P_PK"];
                //else
                //    guidCust_ID = (Guid)"00000000-0000-0000-0000-000000000000";
                
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

        public ProductInfoDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}