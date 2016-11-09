using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace DSL.POS.Report.Setup
{
    public class ReportSalesRegisterInfo
    {
        /// <summary>
        /// Get or set DateSet for Sales Register
        /// </summary>
        /// <param name="DemandStartdate">Demand Start Date</param>
        /// <param name="DemandEnddate">Demand End Date</param>
        /// <param name="branchPK">Branch Primary Key</param>
        /// <param name="productCategory">Product Category Primary Key</param>
        /// <param name="productSubCategory">Product SubCategory Primary Key</param>
        /// <param name="productBrand">Product Brand Primary Key</param>
        /// <param name="productPK">Product Primary Key</param>
        /// <returns>DataSet</returns>
        public DataSet GetSalesInfo(DateTime DemandStartdate, DateTime DemandEnddate, Guid branchPK, Guid productCategory, Guid productSubCategory, Guid productBrand, Guid productPK)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();

          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          Guid strConvartGuid = Guid.NewGuid();

          strConvartGuid = (Guid)TypeDescriptor.GetConverter(strConvartGuid).ConvertFromString("00000000-0000-0000-0000-000000000000");


          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "ReptSalesRegisterInfo";
              cmd.Parameters.Add(new SqlParameter("@DemandStartdate", SqlDbType.DateTime));
              cmd.Parameters.Add(new SqlParameter("@DemandEnddate", SqlDbType.DateTime));
              cmd.Parameters.Add(new SqlParameter("@BR_PK", SqlDbType.UniqueIdentifier, 16));
              cmd.Parameters.Add(new SqlParameter("@PC_Pk", SqlDbType.UniqueIdentifier, 16));
              cmd.Parameters.Add(new SqlParameter("@PSC_PK", SqlDbType.UniqueIdentifier, 16));
              cmd.Parameters.Add(new SqlParameter("@PB_PK", SqlDbType.UniqueIdentifier, 16));
              cmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier, 16));


              if (DemandStartdate.ToString() == "00/00/0000")
              {
                  cmd.Parameters["@DemandStartdate"].Value = null;
              }
              else
              {
                  cmd.Parameters["@DemandStartdate"].Value = DemandStartdate;
              }
              if (DemandEnddate.ToString() == "00/00/0000")
              {
                  cmd.Parameters["@DemandEnddate"].Value = null;
              }
              else
              {
                  cmd.Parameters["@DemandEnddate"].Value = DemandEnddate;
              }
              if (branchPK.ToString() == "00000000-0000-0000-0000-000000000000")
              {
                  cmd.Parameters["@BR_PK"].Value = strConvartGuid;
              }
              else
              {
                  cmd.Parameters["@BR_PK"].Value = branchPK;
              }
              if (productCategory.ToString() == "00000000-0000-0000-0000-000000000000")
              {
                  cmd.Parameters["@PC_Pk"].Value = strConvartGuid;
              }
              else
              {
                  cmd.Parameters["@PC_Pk"].Value = productCategory;
              }
              if (productSubCategory.ToString() == "00000000-0000-0000-0000-000000000000")
              {
                  cmd.Parameters["@PSC_PK"].Value = strConvartGuid;
              }
              else
              {
                  cmd.Parameters["@PSC_PK"].Value = productSubCategory;
              }
              if (productBrand.ToString() == "00000000-0000-0000-0000-000000000000")
              {
                  cmd.Parameters["@PB_PK"].Value = strConvartGuid;
              }
              else
              {
                  cmd.Parameters["@PB_PK"].Value = productBrand;
              }
              if (productPK.ToString() == "00000000-0000-0000-0000-000000000000")
              {
                  cmd.Parameters["@P_PK"].Value = strConvartGuid;
              }
              else
              {
                  cmd.Parameters["@P_PK"].Value = productPK;
              }

              da.SelectCommand = cmd;

              sc.Open();

              DataSet ds = new DataSet();
              da.Fill(ds, "SalesRegisterInfo");

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
