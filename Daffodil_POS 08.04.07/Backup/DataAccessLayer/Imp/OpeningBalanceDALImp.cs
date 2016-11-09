using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Imp;
using DSL.POS.DataAccessLayer.Interface;

namespace DSL.POS.DataAccessLayer.Imp
{
    class OpeningBalanceDALImp:CommonDALImp,IOpeningBalanceDAL 
    {
        public override void Save(object obj)
        {
            OpeningBalanceDTO oOpeningBalanceDTO = (OpeningBalanceDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            SqlCommand objCmd = sqlConn.CreateCommand();

            if (oOpeningBalanceDTO.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                //string strset = getPKCode(oProductCategoryInfoDTO);
                String sql = "INSERT INTO ProductOpeningBalance  (P_PK, OpeningDate, OpeningQty, OpeningRate, OpeningDiscount, EntryBy, EntryDate) VALUES   (@P_PK, @OpeningDate, @OpeningQty,@OpeningRate, @OpeningDiscount, @EntryBy, @EntryDate)";


                try
                {

                    //getPKCode(oOpeningBalanceDTO);

                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningDate", SqlDbType.DateTime));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningQty", SqlDbType.Decimal, 9));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningRate", SqlDbType.Decimal,9));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningDiscount", SqlDbType.Decimal, 9)); 
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@P_PK"].Value = (Guid)oOpeningBalanceDTO.P_PK;
                    objCmd.Parameters["@OpeningDate"].Value = Convert.ToDateTime(oOpeningBalanceDTO.OpeningDate);
                    objCmd.Parameters["@OpeningQty"].Value = Convert.ToDecimal(oOpeningBalanceDTO.OpeningQty);
                    objCmd.Parameters["@OpeningRate"].Value = Convert.ToDecimal(oOpeningBalanceDTO.OpeningRate);
                    objCmd.Parameters["@OpeningDiscount"].Value = Convert.ToDecimal(oOpeningBalanceDTO.OpeningDiscount);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oOpeningBalanceDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oOpeningBalanceDTO.EntryDate);

                    sqlConn.Open();
                    objCmd.ExecuteNonQuery();

                }
                catch (Exception Exp)
                {
                    throw Exp;
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

                String sql = "UPDATE    ProductOpeningBalance SET  P_PK =@P_PK, OpeningDate =@OpeningDate, OpeningQty =@OpeningQty, OpeningRate =@OpeningRate, OpeningDiscount =@OpeningDiscount,EntryBy=@EntryBy,EntryDate=@EntryDate where POB_PK =@POB_PK";

                //objCmd = new SqlCommand(sql, getCurrentConnection(), getCurrentTransaction()); ;

                try
                {
                    objCmd.CommandText = sql;

                    objCmd.Parameters.Add(new SqlParameter("@POB_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier, 16));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningDate", SqlDbType.DateTime));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningQty", SqlDbType.Decimal,9));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningRate", SqlDbType.Decimal, 9));
                    objCmd.Parameters.Add(new SqlParameter("@OpeningDiscount", SqlDbType.Decimal, 9));
                    objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                    objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime));

                    objCmd.Parameters["@POB_PK"].Value = (Guid)oOpeningBalanceDTO.PrimaryKey;
                    objCmd.Parameters["@P_PK"].Value = (Guid)oOpeningBalanceDTO.P_PK;
                    objCmd.Parameters["@OpeningDate"].Value = Convert.ToDateTime(oOpeningBalanceDTO.OpeningDate);
                    objCmd.Parameters["@OpeningQty"].Value = Convert.ToDecimal(oOpeningBalanceDTO.OpeningQty);
                    objCmd.Parameters["@OpeningRate"].Value = Convert.ToDecimal(oOpeningBalanceDTO.OpeningRate);
                    objCmd.Parameters["@OpeningDiscount"].Value = Convert.ToDecimal(oOpeningBalanceDTO.OpeningDiscount);
                    objCmd.Parameters["@EntryBy"].Value = Convert.ToString(oOpeningBalanceDTO.EntryBy);
                    objCmd.Parameters["@EntryDate"].Value = Convert.ToDateTime(oOpeningBalanceDTO.EntryDate);

                    sqlConn.Open();
                    objCmd.ExecuteNonQuery();
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
            }
        }

        public override void Delete(object obj)
        {
            OpeningBalanceDTO oOpeningBalanceDTO = (OpeningBalanceDTO)obj;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            String sql = "Delete  ProductOpeningBalance where POB_PK=@POB_PK";

            SqlCommand objCmdDelete = sqlConn.CreateCommand();
            objCmdDelete.CommandText = sql;

            try
            {


                objCmdDelete.Parameters.Add("@POB_PK", SqlDbType.UniqueIdentifier, 16);

                objCmdDelete.Parameters["@POB_PK"].Value = (Guid)oOpeningBalanceDTO.PrimaryKey;

                sqlConn.Open();
                objCmdDelete.ExecuteNonQuery();

            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objCmdDelete.Dispose();
                objCmdDelete.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }

        }
        public List<OpeningBalanceDTO> getOpeningBalanceInfo()
        {
            string sqlSelect = "SELECT     ProductOpeningBalance.POB_PK, ProductOpeningBalance.P_PK, ProductInfo.P_Name, ProductOpeningBalance.OpeningDate,   ProductOpeningBalance.OpeningQty, ProductOpeningBalance.OpeningRate, ProductOpeningBalance.OpeningDiscount,  ProductOpeningBalance.EntryBy, ProductOpeningBalance.EntryDate FROM         ProductOpeningBalance INNER JOIN  ProductInfo ON ProductOpeningBalance.P_PK = ProductInfo.P_PK ORDER BY ProductOpeningBalance.P_PK, ProductInfo.P_Name";

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            List<OpeningBalanceDTO> oArrayList = new List<OpeningBalanceDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();
            objCmd.CommandText = sqlSelect;
            objCmd.Connection = sqlConn;

            try
            {
                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    OpeningBalanceDTO oOpeningBalanceDTO = populate(thisReader);
                    oArrayList.Add(oOpeningBalanceDTO);
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
        /// Get Data
        /// </summary>
        /// <returns></returns>
        public DataSet getDataSetOpeningBalanceInfo()
        {
            string sqlSelect = "SELECT     ProductOpeningBalance.POB_PK, ProductOpeningBalance.P_PK, ProductInfo.P_Name, ProductOpeningBalance.OpeningDate,   ProductOpeningBalance.OpeningQty, ProductOpeningBalance.OpeningRate, ProductOpeningBalance.OpeningDiscount,  ProductOpeningBalance.EntryBy, ProductOpeningBalance.EntryDate FROM         ProductOpeningBalance INNER JOIN  ProductInfo ON ProductOpeningBalance.P_PK = ProductInfo.P_PK ORDER BY ProductOpeningBalance.P_PK, ProductInfo.P_Name";
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = sc;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlSelect;
                da.SelectCommand = cmd;
                sc.Open();
                               
                da.Fill(ds,"OpeningBalance");
                
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
        public OpeningBalanceDTO populate(SqlDataReader reader)
        {
            try
            {
                OpeningBalanceDTO dto = new OpeningBalanceDTO();
                dto.PrimaryKey = (Guid)reader["POB_PK"];
                dto.P_PK = (Guid)reader["P_PK"];
                dto.OpeningDate = (DateTime)reader["OpeningDate"];
                dto.OpeningQty = (decimal)reader["OpeningQty"];
                dto.OpeningRate = (decimal)reader["OpeningRate"];
                dto.OpeningDiscount = (decimal)reader["OpeningDiscount"];
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
