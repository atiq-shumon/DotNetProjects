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
    class SalesReturnInfoDALImp : CommonDALImp , ISalesReturnInfoDAL 
    {

        
        #region Method

        /// <summary>
        /// Auto generate  Sales Return No
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns></returns>
        private string Get_SalesReturnNo(SalesReturnMainDTO Obj)
        {
            string returnNo = null;
            int brcodeno = 0;

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

            try
            {

                SqlCommand objcmd = new SqlCommand();

                objcmd.CommandText = "Select Isnull(Max(cast(ReturnNo as int)),0 )+1 from SalesReturnMain";
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

                SalesReturnMainDTO oSalesReturnMainDTO = (SalesReturnMainDTO)obj;
                //SalesSubInfoDTO oSalesSubInfoDTO1 = new SalesSubInfoDTO();

                oSalesReturnMainDTO.ReturnNo = Get_SalesReturnNo(oSalesReturnMainDTO);


                strBuilderSales.Append("Declare @ID int; Declare @ERR int;INSERT INTO SalesReturnMain (SALRM_PK, ReturnNo, SalesReturnDate, Cust_PK, ReturnMode, TotalReturnAmount, ReturnAmount, InvoiceNo, InvoiceDate, Remarks, EntryBy, EntryDate, Bo_PK) VALUES ('");
                strBuilderSales.Append(oSalesReturnMainDTO.PrimaryKey);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesReturnMainDTO.ReturnNo);
                strBuilderSales.Append("',");
                strBuilderSales.Append("GETDATE()");
                strBuilderSales.Append(",'");
                strBuilderSales.Append(oSalesReturnMainDTO.Cust_PK);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesReturnMainDTO.ReturnMode);
                strBuilderSales.Append("',");
                strBuilderSales.Append(oSalesReturnMainDTO.TotalReturnAmount);
                strBuilderSales.Append(",");
                strBuilderSales.Append(oSalesReturnMainDTO.ReturnAmount);
                strBuilderSales.Append(",'");
                strBuilderSales.Append(oSalesReturnMainDTO.InvoiceNo);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesReturnMainDTO.InvoiceDate);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesReturnMainDTO.Remarks);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesReturnMainDTO.EntryBy);
                strBuilderSales.Append("',");
                //strBuilderSales.Append(oSalesMainInfoDTO.EntryDate);
                strBuilderSales.Append("GETDATE()");
                strBuilderSales.Append(",'");
                strBuilderSales.Append(oSalesReturnMainDTO.Bo_PK);
                strBuilderSales.Append("');");

                foreach (SalesReturnSubDTO  oSalesReturnSubDTO1 in oSalesReturnMainDTO.SalesReturnSubDTO)
                {
                    strBuilderSales.Append("INSERT INTO SalesReturnSub (SALRM_PK, P_PK, SalesRate, SalesQuantity, VatAmount, TaxAmount, Discount, TotalAmount, EntryBy, EntryDate) VALUES ('");
                    strBuilderSales.Append(oSalesReturnSubDTO1.SALRM_PK);
                    strBuilderSales.Append("','");
                    strBuilderSales.Append(oSalesReturnSubDTO1.P_PK);
                    strBuilderSales.Append("',");
                    strBuilderSales.Append(oSalesReturnSubDTO1.SalesRate);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesReturnSubDTO1.SalesQuantity);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesReturnSubDTO1.VatAmount);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesReturnSubDTO1.TaxAmount);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesReturnSubDTO1.Discount);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesReturnSubDTO1.TotalAmount);
                    strBuilderSales.Append(",'");
                    //strBuilderSales.Append(oSalesSubInfoDTO1.EntryDate);
                    strBuilderSales.Append(oSalesReturnSubDTO1.EntryBy);
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
        public void Update(SalesReturnMainDTO  oSalesReturnMainDTO)
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
        public SalesReturnMainDTO GetSalesInfoBYInvoiceNo(string strCode)
        {
            //string sqlSelectMain = "Select Sal_Pk,DeliveryNo,DeliveryDate,Cust_PK,TotalAmount,PaidAmount,DueAmount,TotalDiscount,PaymentAmount,PaymentMode,Bo_PK,Remarks,EntryBy,EntryDate From SalesMain where DeliveryNo=@DeliveryNo";
            string sqlSelectMain = "SELECT  SalesMain.Sal_Pk, SalesMain.DeliveryNo, SalesMain.DeliveryDate, SalesMain.Cust_PK, SalesMain.TotalAmount, SalesMain.PaidAmount, SalesMain.DueAmount, SalesMain.TotalDiscount, SalesMain.PaymentAmount, SalesMain.PaymentMode, SalesMain.Bo_PK, SalesMain.Remarks,   SalesMain.EntryBy, SalesMain.EntryDate, MemberInfo.CustId, MemberInfo.CustName,  MemberInfo.CustAddr, MemberInfo.CreditLimit FROM  SalesMain INNER JOIN  MemberInfo ON SalesMain.Cust_PK = MemberInfo.Cust_PK WHERE SalesMain.DeliveryNo = @DeliveryNo";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());


            SalesReturnMainDTO oSalesReturnMainDTO = new SalesReturnMainDTO();
            SalesMainInfoDTO oSalesMainInfoDTO = new SalesMainInfoDTO();
            List<SalesSubInfoDTO> loSalesSubInfoDTO = new List<SalesSubInfoDTO>();

            SqlCommand objCmd = sqlConn.CreateCommand();

            objCmd.CommandText = sqlSelectMain;
            objCmd.Connection = sqlConn;

            try
            {
                objCmd.Parameters.Add(new SqlParameter("@DeliveryNo", SqlDbType.VarChar, 20));
                objCmd.Parameters["@DeliveryNo"].Value = strCode;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                if (thisReader.Read())
                {
                    oSalesReturnMainDTO = populate(thisReader);
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
            return oSalesReturnMainDTO;
            //return oSalesMainInfoDTO;
        }

        /// <summary>
        /// set Sales Main information in Domain Class
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public SalesReturnMainDTO  populate(SqlDataReader reader)
        {
            try
            {
                SalesReturnMainDTO dto = new SalesReturnMainDTO();
                SalesMainInfoDTO oSalesMainInfoDTO = new SalesMainInfoDTO();
                MemberInfoDTO oMemberInfoDTO = new MemberInfoDTO();

                oSalesMainInfoDTO.PrimaryKey = (Guid)reader["Sal_Pk"];
                oSalesMainInfoDTO.DeliveryNo = (string)reader["DeliveryNo"];
                oSalesMainInfoDTO.DeliveryDate = (DateTime)reader["DeliveryDate"];
                oSalesMainInfoDTO.Cust_PK = (Guid)reader["Cust_PK"];
                oSalesMainInfoDTO.TotalAmount = (decimal)reader["TotalAmount"];
                oSalesMainInfoDTO.PaidAmount = (decimal)reader["PaidAmount"];
                oSalesMainInfoDTO.DueAmount = (decimal)reader["DueAmount"];
                oSalesMainInfoDTO.TotalDiscount = (decimal)reader["TotalDiscount"];
                oSalesMainInfoDTO.PaymentAmount = (decimal)reader["PaymentAmount"];
                oSalesMainInfoDTO.PaymentMode = (string)reader["PaymentMode"];
                oSalesMainInfoDTO.Bo_PK = (Guid)reader["Bo_PK"];
                oSalesMainInfoDTO.Remarks = (string)reader["Remarks"];
                oSalesMainInfoDTO.EntryBy = (string)reader["EntryBy"];
                oSalesMainInfoDTO.EntryDate = (DateTime)reader["EntryDate"];
                dto.SalesMainInfoDTO = oSalesMainInfoDTO;
                oMemberInfoDTO.PrimaryKey = (Guid)reader["Cust_PK"];
                oMemberInfoDTO.CustId = (string)reader["CustId"];
                oMemberInfoDTO.CustName = (string)reader["CustName"];
                oMemberInfoDTO.CustAddr = (string)reader["CustAddr"];
                oMemberInfoDTO.CreditLimit = (Decimal)reader["CreditLimit"];

                dto.MemberInfoDTO = oMemberInfoDTO;

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

        public SalesReturnSubDTO  populatesub(SqlDataReader reader)
        {
            try
            {
                SalesReturnSubDTO dto = new SalesReturnSubDTO();

                dto.PrimaryKey = (Guid)reader["SALRS_PK"];
                dto.SALRM_PK = (Guid)reader["SALRM_PK"];
                dto.P_PK = (Guid)reader["P_PK"];
                dto.SalesRate = (decimal)reader["SalesRate"];
                dto.SalesQuantity = (decimal)reader["SalesQuantity"];
                dto.VatAmount = (decimal)reader["VatAmount"];
                dto.TaxAmount = (decimal)reader["TaxAmount"];
                dto.Discount = (decimal)reader["Discount"];
                dto.TotalAmount = (decimal)reader["TotalAmount"];
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
