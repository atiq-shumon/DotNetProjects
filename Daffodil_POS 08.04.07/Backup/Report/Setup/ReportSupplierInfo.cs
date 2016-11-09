using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DSL.POS.Report.Setup
{
    public class ReportSupplierInfo
    {
        public DataSet GetSupplierInfo(Guid SupplierID)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();



            try
            {
                cmd.Connection = sc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RptSupplierInfo";
                cmd.Parameters.Add(new SqlParameter("@Sp_PK", SqlDbType.UniqueIdentifier, 16));


                if (SupplierID.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    cmd.Parameters["@Sp_PK"].Value = null;
                }
                else
                {
                    cmd.Parameters["@Sp_PK"].Value = SupplierID;
                }


                da.SelectCommand = cmd;

                sc.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "Supplier");

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
