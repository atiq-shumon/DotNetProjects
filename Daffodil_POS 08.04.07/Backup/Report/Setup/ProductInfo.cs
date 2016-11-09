using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;


namespace DSL.POS.Report.Setup
{
    public class ProductInfo
    {
    
        /// <summary>
        /// Get product information
        /// </summary>
        /// <param name="productCategory">Guid Product Brand</param>
        /// <param name="productSubCategory"> Guid ProductSubCategory</param>
        /// <param name="productBrand">Guid ProductCategory</param>
        /// <returns>DataSet</returns>
        public  DataSet GetProductInfo(Guid productCategory, Guid productSubCategory, Guid productBrand)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();



            try
            {
                cmd.Connection = sc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RptProductInfo";
                cmd.Parameters.Add(new SqlParameter("@PCPK", SqlDbType.UniqueIdentifier, 16));
                cmd.Parameters.Add(new SqlParameter("@PSCPK", SqlDbType.UniqueIdentifier, 16));
                cmd.Parameters.Add(new SqlParameter("@PBPK", SqlDbType.UniqueIdentifier, 16));

                if (productCategory.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    cmd.Parameters["@PCPK"].Value = null;
                }
                else
                {
                    cmd.Parameters["@PCPK"].Value = productCategory;
                }
                if (productSubCategory.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    cmd.Parameters["@PSCPK"].Value = null;
                }
                else
                {
                    cmd.Parameters["@PSCPK"].Value = productSubCategory;
                }
                if (productBrand.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    cmd.Parameters["@PBPK"].Value = null;
                }
                else
                {
                    cmd.Parameters["@PBPK"].Value = productBrand;
                }

                da.SelectCommand = cmd;

                sc.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "Product");
                //ds.WriteXml("E:\\Development\\General Software\\DSL.POS\\Web\\Report\\Setup\\XMLSchema.xsd");
                
                return ds;
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                sc.Close();
            }
        }
            
    }
}
