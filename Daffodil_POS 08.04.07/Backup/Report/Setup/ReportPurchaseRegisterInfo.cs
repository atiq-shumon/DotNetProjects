using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace DSL.POS.Report.Setup
{
 public class ReportPurchaseRegisterInfo
    {

     public DataSet GetPurchaseRegisterInfo(DateTime DemandStartdate, DateTime DemandEnddate, Guid productCategory, Guid productSubCategory, Guid productBrand, Guid supplier)
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
             cmd.CommandText = "ReptPurchaseRegisterInfo";
             cmd.Parameters.Add(new SqlParameter("@DemandStartdate", SqlDbType.DateTime));
             cmd.Parameters.Add(new SqlParameter("@DemandEnddate", SqlDbType.DateTime));
             cmd.Parameters.Add(new SqlParameter("@PC_Pk", SqlDbType.UniqueIdentifier, 16));
             cmd.Parameters.Add(new SqlParameter("@PSC_PK", SqlDbType.UniqueIdentifier, 16));
             cmd.Parameters.Add(new SqlParameter("@PB_PK", SqlDbType.UniqueIdentifier, 16));
             cmd.Parameters.Add(new SqlParameter("@Sp_PK", SqlDbType.UniqueIdentifier, 16));


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
             if (supplier.ToString() == "00000000-0000-0000-0000-000000000000")
             {
                 cmd.Parameters["@Sp_PK"].Value = strConvartGuid;
             }
             else
             {
                 cmd.Parameters["@Sp_PK"].Value = supplier;
             }

             da.SelectCommand = cmd;

             sc.Open();

             DataSet ds = new DataSet();
             da.Fill(ds, "PurchaseRegisterInfo");

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
     //Methord For Branch Information
     public DataSet getAllSupplierInfo(int ReportMode)
     {
         SqlConnection sc = new SqlConnection();
         sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
         SqlDataAdapter da = new SqlDataAdapter();
         SqlCommand cmd = new SqlCommand();

         try
         {
             cmd.Connection = sc;
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.CommandText = "RptAllSupplierInfo";
             cmd.Parameters.Add(new SqlParameter("@ReportMode", SqlDbType.SmallInt, 2));

             if (ReportMode == 0)
             {
                 cmd.Parameters["@ReportMode"].Value = null;
             }
             else
             {
                 cmd.Parameters["@ReportMode"].Value = ReportMode;
             }

             da.SelectCommand = cmd;

             sc.Open();

             DataSet ds = new DataSet();
             da.Fill(ds, "SupplierInfo");
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
