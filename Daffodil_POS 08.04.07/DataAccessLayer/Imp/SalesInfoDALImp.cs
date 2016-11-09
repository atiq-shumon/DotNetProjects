using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Web;
using System.Configuration;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DataAccessLayer.Common.Imp;


namespace DSL.POS.DataAccessLayer.Imp
{
    class SalesInfoDALImp : CommonDALImp, ISalesInfoDAL
    {

        #region Method

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

                SalesMainInfoDTO oSalesMainInfoDTO = (SalesMainInfoDTO)obj;
                //SalesSubInfoDTO oSalesSubInfoDTO1 = new SalesSubInfoDTO();

                strBuilderSales.Append("Declare @ID int; Declare @ERR int;Insert Into SalesMain(Sal_Pk,DeliveryNo,DeliveryDate,Cust_PK,TotalAmount,PaidAmount,DueAmount,TotalDiscount,PaymentAmount,PaymentMode,Bo_PK,Remarks,EntryBy,EntryDate) values ('");
                strBuilderSales.Append(oSalesMainInfoDTO.PrimaryKey);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesMainInfoDTO.DeliveryNo);
                strBuilderSales.Append("',");
                strBuilderSales.Append("GETDATE()");
                strBuilderSales.Append(",'");
                strBuilderSales.Append(oSalesMainInfoDTO.Cust_PK);
                strBuilderSales.Append("',");
                strBuilderSales.Append(oSalesMainInfoDTO.TotalAmount);
                strBuilderSales.Append(",");
                strBuilderSales.Append(oSalesMainInfoDTO.PaidAmount);
                strBuilderSales.Append(",");
                strBuilderSales.Append(oSalesMainInfoDTO.DueAmount);
                strBuilderSales.Append(",");
                strBuilderSales.Append(oSalesMainInfoDTO.TotalDiscount);                
                strBuilderSales.Append(",");
                strBuilderSales.Append(oSalesMainInfoDTO.PaymentAmount);
                strBuilderSales.Append(",'");
                strBuilderSales.Append(oSalesMainInfoDTO.PaymentMode);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesMainInfoDTO.Bo_PK);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesMainInfoDTO.Remarks);
                strBuilderSales.Append("','");
                strBuilderSales.Append(oSalesMainInfoDTO.EntryBy);
                strBuilderSales.Append("',");
                //strBuilderSales.Append(oSalesMainInfoDTO.EntryDate);
                strBuilderSales.Append("GETDATE()");
                strBuilderSales.Append(");");

                foreach (SalesSubInfoDTO oSalesSubInfoDTO1 in oSalesMainInfoDTO.SalesSubInfoDTO)
                {
                    strBuilderSales.Append("Insert Into SalesSub(Sal_Pk,P_PK,SalesRate,SalesQuantity,VatAmount,TaxAmount,Discount,TotalAmount,EntryDate,EntryBy) values ('");
                    strBuilderSales.Append(oSalesSubInfoDTO1.Sal_Pk);
                    strBuilderSales.Append("','");
                    strBuilderSales.Append(oSalesSubInfoDTO1.P_PK);
                    strBuilderSales.Append("',");
                    strBuilderSales.Append(oSalesSubInfoDTO1.SalesRate);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesSubInfoDTO1.SalesQuantity);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesSubInfoDTO1.VatAmount);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesSubInfoDTO1.TaxAmount);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesSubInfoDTO1.Discount);
                    strBuilderSales.Append(",");
                    strBuilderSales.Append(oSalesSubInfoDTO1.TotalAmount);
                    strBuilderSales.Append(",");
                    //strBuilderSales.Append(oSalesSubInfoDTO1.EntryDate);
                    strBuilderSales.Append("GETDATE()");
                    strBuilderSales.Append(",'");
                    strBuilderSales.Append(oSalesSubInfoDTO1.EntryBy);
                    strBuilderSales.Append("');SELECT @ERR=@ERR+@@ERROR;");
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
        public void Update(SalesMainInfoDTO oSalesMainInfoDTO)
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
        //public SalesMainInfoDTO GetSalesInfoBYInvoiceNo(string strCode)
        //{
        //    //string sqlSelectMain = "Select Sal_Pk,DeliveryNo,DeliveryDate,Cust_PK,TotalAmount,PaidAmount,DueAmount,TotalDiscount,PaymentAmount,PaymentMode,Bo_PK,Remarks,EntryBy,EntryDate From SalesMain where DeliveryNo=@DeliveryNo";
        //    string sqlSelectMain = "SELECT  SalesMain.Sal_Pk, SalesMain.DeliveryNo, SalesMain.DeliveryDate, SalesMain.Cust_PK, SalesMain.TotalAmount, SalesMain.PaidAmount, SalesMain.DueAmount, SalesMain.TotalDiscount, SalesMain.PaymentAmount, SalesMain.PaymentMode, SalesMain.Bo_PK, SalesMain.Remarks,   SalesMain.EntryBy, SalesMain.EntryDate, MemberInfo.CustId, MemberInfo.CustName,  MemberInfo.CustAddr, MemberInfo.CreditLimit FROM  SalesMain INNER JOIN  MemberInfo ON SalesMain.Cust_PK = MemberInfo.Cust_PK WHERE SalesMain.DeliveryNo = @DeliveryNo";
        //    SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());


        //    SalesMainInfoDTO oSalesMainInfoDTO = new SalesMainInfoDTO();
        //    List<SalesSubInfoDTO> loSalesSubInfoDTO = new List<SalesSubInfoDTO>();

        //    SqlCommand objCmd = sqlConn.CreateCommand();

        //    objCmd.CommandText = sqlSelectMain;
        //    objCmd.Connection = sqlConn;

        //    try
        //    {
        //        objCmd.Parameters.Add(new SqlParameter("@DeliveryNo", SqlDbType.VarChar, 20));
        //        objCmd.Parameters["@DeliveryNo"].Value = strCode;

        //        sqlConn.Open();
        //        SqlDataReader thisReader = objCmd.ExecuteReader();

        //        if (thisReader.Read())
        //        {
        //            oSalesMainInfoDTO = populate(thisReader);
        //        }

        //        sqlConn.Close();
        //        thisReader.Close();
        //        thisReader.Dispose();
        //        objCmd.Dispose();
        //        objCmd.Cancel();

        //        //  For Sales Sub dto
        //        try
        //        {
        //            string sqlSelectSalesSub = "Select SalSub_Pk,Sal_Pk,P_PK,SalesRate,SalesQuantity,VatAmount,TaxAmount,Discount,TotalAmount,EntryDate,EntryBy From SalesSub where Sal_Pk=@Sal_Pk";

        //            objCmd.CommandText = sqlSelectSalesSub;
        //            objCmd.Connection = sqlConn;


        //            objCmd.Parameters.Add("@Sal_Pk", SqlDbType.UniqueIdentifier, 16);
        //            objCmd.Parameters["@Sal_Pk"].Value = oSalesMainInfoDTO.PrimaryKey;

        //            sqlConn.Open();
        //            thisReader = objCmd.ExecuteReader();


        //            while (thisReader.Read())
        //            {
        //                SalesSubInfoDTO oSalesSubInfoDTO = populatesub(thisReader);
        //                loSalesSubInfoDTO.Add(oSalesSubInfoDTO);
        //            }
        //            oSalesMainInfoDTO.SalesSubInfoDTO = loSalesSubInfoDTO;

        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        objCmd.Dispose();
        //        objCmd.Cancel();
        //        sqlConn.Dispose();
        //        sqlConn.Close();
        //    }
        //    return oSalesMainInfoDTO;
        //}

        /// <summary>
        /// set Sales Main information in Domain Class
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public SalesMainInfoDTO populate(SqlDataReader reader)
        {
            try
            {
                SalesMainInfoDTO dto = new SalesMainInfoDTO();
                MemberInfoDTO oMemberInfoDTO = new MemberInfoDTO();

                dto.PrimaryKey = (Guid)reader["Sal_Pk"];
                dto.DeliveryNo = (string)reader["DeliveryNo"];
                dto.DeliveryDate = (DateTime)reader["DeliveryDate"];
                dto.Cust_PK = (Guid)reader["Cust_PK"];
                dto.TotalAmount = (decimal)reader["TotalAmount"];
                dto.PaidAmount = (decimal)reader["PaidAmount"];
                dto.DueAmount = (decimal)reader["DueAmount"];
                dto.TotalDiscount = (decimal)reader["TotalDiscount"];
                dto.PaymentAmount = (decimal)reader["PaymentAmount"];
                dto.PaymentMode = (string)reader["PaymentMode"];
                dto.Bo_PK = (Guid)reader["Bo_PK"];
                dto.Remarks = (string)reader["Remarks"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                oMemberInfoDTO.PrimaryKey= (Guid)reader["Cust_PK"];
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
 
        public SalesSubInfoDTO populatesub(SqlDataReader reader)
        {
            try
            {
                SalesSubInfoDTO dto = new SalesSubInfoDTO();

                dto.PrimaryKey = (Guid)reader["SalSub_Pk"];
                dto.Sal_Pk = (Guid)reader["Sal_Pk"];
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

        public SalesInfoDALImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
