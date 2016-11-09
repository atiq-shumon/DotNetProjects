using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace DSL.POS.Report.Setup
{
   public  class ReportMemberInfo
    {
       public DataSet GetMemberInfo(Guid MemberID)
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
               cmd.CommandText = "RptMemberInfo";
               cmd.Parameters.Add(new SqlParameter("@Cust_PK", SqlDbType.UniqueIdentifier, 16));


               if (MemberID.ToString() == "00000000-0000-0000-0000-000000000000")
               {
                   cmd.Parameters["@Cust_PK"].Value = strConvartGuid;
               }
               else
               {
                   cmd.Parameters["@Cust_PK"].Value = MemberID;
               }


               da.SelectCommand = cmd;

               sc.Open();

               DataSet ds = new DataSet();
               da.Fill(ds,"Member");

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
