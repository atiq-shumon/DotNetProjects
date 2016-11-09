using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DataAccessLayer.Common.Imp;

namespace DSL.POS.DataAccessLayer.Imp
{
    class PurchaseReturnInfoDALImp:CommonDALImp,IPurchaseReturnInfoDAL 
    {

        #region ALL_Method

        /// <summary>
        /// Auto generate  Sales Return No
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns></returns>
        private string Get_PurchaseReturnNo(PurchaseReturnMainDTO Obj)
        {
            string returnNo = null;
            int brcodeno = 0;

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            try
            {

                SqlCommand objcmd = new SqlCommand();

                objcmd.CommandText = "Select Isnull(Max(cast(PurchaseReturnNo as int)),0 )+1 from PurchaseReturnMain";
                objmycon.Open();
                objcmd.Connection = objmycon;
                brcodeno = (int)objcmd.ExecuteScalar();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objmycon.Close();
            }

            returnNo = brcodeno.ToString("0000000");
            return returnNo;
        }
        /// <summary>
        /// This method used for save and update
        /// </summary>
        /// <param name="obj">DTO Object </param>
        /// 
        //public override void Save(SalesMainInfoDTO oSalesMainInfoDTO)
        public override void Save(object obj)
        {
            try
            {
                StringBuilder strBuilderSales = new StringBuilder();

                SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
                SqlCommand objCmd = sqlConn.CreateCommand();

                PurchaseReturnMainDTO oPurchaseReturnMainDTO = (PurchaseReturnMainDTO)obj;
                //SalesSubInfoDTO oSalesSubInfoDTO1 = new SalesSubInfoDTO();

                oPurchaseReturnMainDTO.PurchaseReturnNo = Get_PurchaseReturnNo(oPurchaseReturnMainDTO);


                strBuilderSales.Append("Declare @ID int; Declare @ERR int;INSERT INTO PurchaseReturnMain (PRM_PK,PU_PK, Sp_PK, PurchaseReturnNo, ReferenceNo, GRN_No, GRNDate, TotalReturnAmount, PurchaseDeduction, PurchaseReturnAmount, Remarks, EntryBy, EntryDate) VALUES ('");
                strBuilderSales.Append(oPurchaseReturnMainDTO.PrimaryKey);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.PU_PK);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.Sp_PK);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.PurchaseReturnNo);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.ReferenceNo);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.GRN_No);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.GRNDate);
                strBuilderSales.Append("',");
                strBuilderSales.Append(oPurchaseReturnMainDTO.TotalReturnAmount);
                strBuilderSales.Append(",");
                strBuilderSales.Append(oPurchaseReturnMainDTO.PurchaseDeduction);
                strBuilderSales.Append(",");
                strBuilderSales.Append(oPurchaseReturnMainDTO.PurchaseReturnAmount);
                strBuilderSales.Append(",'");
                strBuilderSales.Append(oPurchaseReturnMainDTO.Remarks);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oPurchaseReturnMainDTO.EntryBy);
                strBuilderSales.Append("',");
                //strBuilderSales.Append(oSalesMainInfoDTO.EntryDate);
                strBuilderSales.Append("GETDATE()");
                strBuilderSales.Append(");");

                foreach (PurchaseReturnSubDTO oPurchaseReturnSubDTO1 in oPurchaseReturnMainDTO.PurchaseReturnSubDTO)
                {
                    strBuilderSales.Append("INSERT INTO PurchaseReturnSub  (PRM_PK,P_PK, ReceivedQuantity, ItemRate, Discount, Notes, EntryBy, EntryDate)VALUES ('");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.PRM_PK);
                    strBuilderSales.Append("','");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.P_PK);
                    strBuilderSales.Append("',");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.ReceivedQuantity);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.ItemRate);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.Discount);
                    strBuilderSales.Append(",'");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.Notes);
                    strBuilderSales.Append("','");
                    strBuilderSales.Append(oPurchaseReturnSubDTO1.EntryBy);
                    strBuilderSales.Append("',");
                    strBuilderSales.Append("GETDATE()");
                    strBuilderSales.Append(");SELECT @ERR=@ERR+@@ERROR;");
                }


                sqlConn.Open();
                objCmd.Connection = sqlConn;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = strBuilderSales.Append("SELECT @ID, ISNULL(@ERR,0)").ToString();

                using (SqlDataReader rdr = objCmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    // Read the returned @ERR
                    rdr.Read();
                    // If the error count is not zero throw an exception
                    if (rdr.GetInt32(1) != 0)
                        throw new ApplicationException("DATA INTEGRITY ERROR ON ORDER INSERT - ROLLBACK ISSUED");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method used for update
        /// </summary>
        /// <param name="obj">DTO Object </param>
        /// 
        //public void Update(SalesMainInfoDTO oSalesMainInfoDTO)
        public void Update(PurchaseReturnMainDTO oPurchaseReturnMainDTO)
        {
            //try
            //{
            //    StringBuilder strBuilderSales = new StringBuilder();

            //    SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            //    SqlCommand objCmd = sqlConn.CreateCommand();


            //    strBuilderSales.Append("Declare @ID int; Declare @ERR int;update SalesMain(Sal_Pk,DeliveryNo,DeliveryDate,Cust_PK,TotalAmount,PaidAmount,DueAmount,PaymentAmount,PaymentMode,Bo_PK,Remarks,EntryBy,EntryDate) values ('");
            //    strBuilderSales.Append(oSalesMainInfoDTO.PrimaryKey);
            //    strBuilderSales.Append("','");
            //    strBuilderSales.Append(oSalesMainInfoDTO.DeliveryNo);
            //    strBuilderSales.Append("',");
            //    strBuilderSales.Append("GETDATE()");
            //    strBuilderSales.Append(",'");
            //    strBuilderSales.Append(oSalesMainInfoDTO.Cust_PK);
            //    strBuilderSales.Append("',");
            //    strBuilderSales.Append(oSalesMainInfoDTO.TotalAmount);
            //    strBuilderSales.Append(",");
            //    strBuilderSales.Append(oSalesMainInfoDTO.PaidAmount);
            //    strBuilderSales.Append(",");
            //    strBuilderSales.Append(oSalesMainInfoDTO.DueAmount);
            //    strBuilderSales.Append(",");
            //    strBuilderSales.Append(oSalesMainInfoDTO.PaymentAmount);
            //    strBuilderSales.Append(",'");
            //    strBuilderSales.Append(oSalesMainInfoDTO.PaymentMode);
            //    strBuilderSales.Append("','");
            //    strBuilderSales.Append(oSalesMainInfoDTO.Bo_PK);
            //    strBuilderSales.Append("','");
            //    strBuilderSales.Append(oSalesMainInfoDTO.Remarks);
            //    strBuilderSales.Append("','");
            //    strBuilderSales.Append(oSalesMainInfoDTO.EntryBy);
            //    strBuilderSales.Append("',");
            //    strBuilderSales.Append(oSalesMainInfoDTO.EntryDate);
            //    strBuilderSales.Append("GETDATE()");
            //    strBuilderSales.Append(");");

            //    foreach (SalesSubInfoDTO oSalesSubInfoDTO1 in oSalesMainInfoDTO.SalesSubInfoDTO)
            //    {
            //        strBuilderSales.Append("Insert Into SalesSub(Sal_Pk,P_PK,SalesRate,SalesQuantity,VatAmount,TaxAmount,Discount,TotalAmount,EntryDate,EntryBy) values ('");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.Sal_Pk);
            //        strBuilderSales.Append("','");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.P_PK);
            //        strBuilderSales.Append("',");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.SalesRate);
            //        strBuilderSales.Append(",");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.SalesQuantity);
            //        strBuilderSales.Append(",");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.VatAmount);
            //        strBuilderSales.Append(",");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.TaxAmount);
            //        strBuilderSales.Append(",");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.Discount);
            //        strBuilderSales.Append(",");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.TotalAmount);
            //        strBuilderSales.Append(",");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.EntryDate);
            //        strBuilderSales.Append("GETDATE()");
            //        strBuilderSales.Append(",'");
            //        strBuilderSales.Append(oSalesSubInfoDTO1.EntryBy);
            //        strBuilderSales.Append("');SELECT @ERR=@ERR+@@ERROR;");
            //    }


            //    sqlConn.Open();
            //    objCmd.Connection = sqlConn;
            //    objCmd.CommandType = CommandType.Text;
            //    objCmd.CommandText = strBuilderSales.Append("SELECT @ID, ISNULL(@ERR,0)").ToString();

            //    using (SqlDataReader rdr = objCmd.ExecuteReader(CommandBehavior.CloseConnection))
            //    {
            //         Read the returned @ERR
            //        rdr.Read();
            //         If the error count is not zero throw an exception
            //        if (rdr.GetInt32(1) != 0)
            //            throw new ApplicationException("DATA INTEGRITY ERROR ON ORDER INSERT - ROLLBACK ISSUED");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        /// <summary>
        /// Get All Information in Sales Main And Sales Sub corresponding Invoice No.
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public PurchaseReturnMainDTO GetPurchaseInfoBYGRNNo(string strCode)
        {

            string sqlSelectMain = "SELECT PurchaseMain.PU_PK, PurchaseMain.GRN_No, PurchaseMain.GRNDate, PurchaseMain.ReferenceNo, PurchaseMain.Sp_PK,  PurchaseMain.TotalAmount, PurchaseMain.Discount, PurchaseMain.EntryBy, PurchaseMain.EntryDate, SupplierInfo.SupplierName,  SupplierInfo.Sp_PK, SupplierInfo.SupplierCode, SupplierInfo.Address FROM  SupplierInfo INNER JOIN  PurchaseMain ON SupplierInfo.Sp_PK = PurchaseMain.Sp_PK WHERE   PurchaseMain.GRN_No = @GRN_No";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());


            PurchaseReturnMainDTO oPurchaseReturnMainDTO = new PurchaseReturnMainDTO();
            PurchaseMainDTO  oPurchaseMainDTO = new PurchaseMainDTO();
            List<PurchaseReturnSubDTO> olPurchaseReturnSubDTO = new List<PurchaseReturnSubDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();

            objCmd.CommandText = sqlSelectMain;
            objCmd.Connection = sqlConn;

            try
            {
                objCmd.Parameters.Add(new SqlParameter("@GRN_No", SqlDbType.VarChar, 20));
                objCmd.Parameters["@GRN_No"].Value = strCode;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                if (thisReader.Read())
                {
                    oPurchaseReturnMainDTO = populate(thisReader);
                }

                sqlConn.Close();
                thisReader.Close();
                thisReader.Dispose();
                objCmd.Dispose();
                objCmd.Cancel();

                ////  For Sales Sub dto
                //try
                //{
                //    string sqlSelectSalesSub = "Select SalSub_Pk,Sal_Pk,P_PK,SalesRate,SalesQuantity,VatAmount,TaxAmount,Discount,TotalAmount,EntryDate,EntryBy From SalesSub where Sal_Pk=@Sal_Pk";

                //    objCmd.CommandText = sqlSelectSalesSub;
                //    objCmd.Connection = sqlConn;


                //    objCmd.Parameters.Add("@Sal_Pk", SqlDbType.UniqueIdentifier, 16);
                //    objCmd.Parameters["@Sal_Pk"].Value = oSalesMainInfoDTO.PrimaryKey;

                //    sqlConn.Open();
                //    thisReader = objCmd.ExecuteReader();


                //    while (thisReader.Read())
                //    {
                //        SalesSubInfoDTO oSalesSubInfoDTO = populatesub(thisReader);
                //        loSalesSubInfoDTO.Add(oSalesSubInfoDTO);
                //    }
                //    oSalesMainInfoDTO.SalesSubInfoDTO = loSalesSubInfoDTO;

                //}
                //catch (Exception ex)
                //{
                //    throw ex;
                //}
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
            return oPurchaseReturnMainDTO;
            //return oSalesMainInfoDTO;
        }

        /// <summary>
        /// set Sales Main information in Domain Class
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public PurchaseReturnMainDTO populate(SqlDataReader reader)
        {
            try
            {
                PurchaseReturnMainDTO dto = new PurchaseReturnMainDTO();
                PurchaseMainDTO oPurchaseMainDTO = new PurchaseMainDTO();
                SupplierInfoDTO oSupplierInfoDTO = new SupplierInfoDTO();

                oPurchaseMainDTO.PrimaryKey = (Guid)reader["PU_PK"];
                oPurchaseMainDTO.GRN_No = (string)reader["GRN_No"];
                oPurchaseMainDTO.GRNDate = (DateTime)reader["GRNDate"];
                oPurchaseMainDTO.ReferenceNo = (string)reader["ReferenceNo"];
                oPurchaseMainDTO.Sp_PK = (Guid)reader["Sp_PK"];
                oPurchaseMainDTO.TotalAmount = (decimal)reader["TotalAmount"];
                oPurchaseMainDTO.Discount = (decimal)reader["Discount"];
                oPurchaseMainDTO.EntryBy = (string)reader["EntryBy"];
                oPurchaseMainDTO.EntryDate = (DateTime)reader["EntryDate"];
                dto.PurchaseMainDTO = oPurchaseMainDTO;

                oSupplierInfoDTO.PrimaryKey = (Guid)reader["Sp_PK"];
                oSupplierInfoDTO.SupplierCode = (string)reader["SupplierCode"];
                oSupplierInfoDTO.SupplierName = (string)reader["SupplierName"];
                oSupplierInfoDTO.Address = (string)reader["Address"];
                
                dto.SupplierInfoDTO = oSupplierInfoDTO;

                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// set up in Sales Sub Information 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>

        public PurchaseReturnSubDTO populatesub(SqlDataReader reader)
        {
            try
            {
                PurchaseReturnSubDTO dto = new PurchaseReturnSubDTO();

                dto.PrimaryKey = (Guid)reader["PRS_PK"];
                dto.PRM_PK = (Guid)reader["SALRM_PK"];
                dto.P_PK = (Guid)reader["P_PK"];
                dto.ReceivedQuantity = (decimal)reader["ReceivedQuantity"];
                dto.ItemRate = (decimal)reader["ItemRate"];
                dto.Discount = (decimal)reader["Discount"];
                dto.Notes = (string)reader["Discount"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
