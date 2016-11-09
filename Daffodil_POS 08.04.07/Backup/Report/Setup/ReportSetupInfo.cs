using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;


namespace DSL.POS.Report.Setup
{
  public class ReportSetupInfo
    {
      //Methord For Branch Information
        public DataSet getBranchInfo(int ReportMode)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = sc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RptBranchInfo";
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
                da.Fill(ds, "BranchInfo");
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
        //Methord For Member Information
      public DataSet getMemberInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptAllMemberInfo";
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
              da.Fill(ds, "MemberInfo");
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
      //Methord For Supplier Information
      public DataSet getSupplierInfo(int ReportMode)
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
      //Methord For Product Information
      public DataSet getProductInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptAllProductInfo";
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
              da.Fill(ds, "AllProductInfo");
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
      //Methord For Product Category Information
      public DataSet getProductCategoryInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptProductCategoryInfo";
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
              da.Fill(ds, "ProductCategoryInfo");
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
      //Methord For Product Sub Category Information
      public DataSet getProductSubCategoryInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptProductSubCategoryInfo";
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
              da.Fill(ds, "ProductSubCategoryInfo");
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
      //Methord For Product Unit Information
      public DataSet getProductUnitInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptProductUnitInfo";
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
              da.Fill(ds, "ProductUnitInfo");
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

      //Methord For Booth Information
      public DataSet getBoothInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptBoothInfo";
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
              da.Fill(ds, "BoothInfo");
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

      public DataSet getProductSummaryInfo(int ReportMode)
      {
          SqlConnection sc = new SqlConnection();
          sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();
          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();

          try
          {
              cmd.Connection = sc;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "RptProductSummaryInfo";
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
              da.Fill(ds, "ProductSummaryInfo");
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
