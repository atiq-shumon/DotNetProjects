using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DataAccessLayer.Common.Imp;
using System.Configuration;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for PurchaseInfoDALImp
    /// </summary>
    class PurchaseInfoDALImp:CommonDALImp,IPurchaseInfoDAL 
    {

        #region Method

        /// <summary>
        /// This method used for save and update
        /// </summary>
        /// <param name="obj"> Purchase Info DTO</param>
        /// 
        public override void Save(object obj)
        {
            StringBuilder strBuilderPurchase = new StringBuilder();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            PurchaseMainDTO oPurchaseMainDTO = (PurchaseMainDTO)obj;

            strBuilderPurchase.Append("Declare @ID int; Declare @ERR int;Insert Into PurchaseMain(PU_PK,GRN_No,GRNDate,ReferenceNo,Sp_PK,TotalAmount,Discount,EntryBy,EntryDate) values ('");
            strBuilderPurchase.Append(oPurchaseMainDTO.PrimaryKey);
            strBuilderPurchase.Append("','");
            strBuilderPurchase.Append(oPurchaseMainDTO.GRN_No);
            strBuilderPurchase.Append("','");
            strBuilderPurchase.Append(oPurchaseMainDTO.GRNDate);                
            strBuilderPurchase.Append("','");
            strBuilderPurchase.Append(oPurchaseMainDTO.ReferenceNo);
            strBuilderPurchase.Append("','");
            strBuilderPurchase.Append(oPurchaseMainDTO.Sp_PK);
            strBuilderPurchase.Append("',");
            strBuilderPurchase.Append(oPurchaseMainDTO.TotalAmount);
            strBuilderPurchase.Append(",");
            strBuilderPurchase.Append(oPurchaseMainDTO.Discount);
            strBuilderPurchase.Append(",'");
            strBuilderPurchase.Append(oPurchaseMainDTO.EntryBy);
            strBuilderPurchase.Append("',");
            strBuilderPurchase.Append("GETDATE()");                
            strBuilderPurchase.Append(");");

            foreach (PurchaseSubDTO oPurchaseSubDTO in oPurchaseMainDTO.PurchaseSubDTO)
            {
                strBuilderPurchase.Append("Insert Into PurchaseSub(PU_PK,P_PK,ReceivedQuantity,ItemRate,Discount,Notes,EntryBy,EntryDate) values ('");
                strBuilderPurchase.Append(oPurchaseSubDTO.PU_PK);
                strBuilderPurchase.Append("','");
                strBuilderPurchase.Append(oPurchaseSubDTO.P_PK);
                strBuilderPurchase.Append("',");
                strBuilderPurchase.Append(oPurchaseSubDTO.ReceivedQuantity);
                strBuilderPurchase.Append(",");
                strBuilderPurchase.Append(oPurchaseSubDTO.ItemRate);
                strBuilderPurchase.Append(",");
                strBuilderPurchase.Append(oPurchaseSubDTO.Discount);
                strBuilderPurchase.Append(",'");
                strBuilderPurchase.Append(oPurchaseSubDTO.Notes);
                strBuilderPurchase.Append("','");
                strBuilderPurchase.Append(oPurchaseSubDTO.EntryBy);
                strBuilderPurchase.Append("',");
                strBuilderPurchase.Append("GETDATE()");                
                strBuilderPurchase.Append(");SELECT @ERR=@ERR+@@ERROR;");
            }


            sqlConn.Open();
            objCmd.Connection = sqlConn;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strBuilderPurchase.Append("SELECT @ID, ISNULL(@ERR,0)").ToString();

            using (SqlDataReader rdr = objCmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                // Read the returned @ERR
                rdr.Read();
                // If the error count is not zero throw an exception
                if (rdr.GetInt32(1) != 0)
                    throw new ApplicationException("DATA INTEGRITY ERROR ON ORDER INSERT - ROLLBACK ISSUED");
            }
        }
        ///// <summary>
        ///// Delete 
        ///// </summary>
        ///// <param name="obj"></param>
        //public override void Delete(object obj)
        //{
        //    SalesMainInfoDTO oSalesMainInfoDTO = (SalesMainInfoDTO)obj;

        //    SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());

        //    String sql = "Delete  PurchaseMain where Sal_Pk=@Sal_Pk";

        //    SqlCommand objCmdDelete = sqlConn.CreateCommand();
        //    objCmdDelete.CommandText = sql;

        //    try
        //    {
        //        objCmdDelete.Parameters.Add("@Sal_Pk", SqlDbType.UniqueIdentifier, 16);
        //        objCmdDelete.Parameters["@Sal_Pk"].Value = (Guid)oSalesMainInfoDTO.PrimaryKey;

        //        sqlConn.Open();
        //        objCmdDelete.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objCmdDelete.Dispose();
        //        objCmdDelete.Cancel();
        //        sqlConn.Dispose();
        //        sqlConn.Close();
        //    }

        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="reader"></param>
        ///// <returns></returns>
        //public SalesMainInfoDTO populate(SqlDataReader reader)
        //{
        //    try
        //    {
        //        SalesMainInfoDTO dto = new SalesMainInfoDTO();

        //        dto.PrimaryKey = (Guid)reader["Sal_Pk"];
        //        dto.DeliveryNo = (string)reader["DeliveryNo"];
        //        dto.DeliveryDate = (DateTime)reader["DeliveryDate"];
        //        dto.Cust_PK = (Guid)reader["Cust_PK"];
        //        dto.TotalAmount = (decimal)reader["TotalAmount"];
        //        dto.PaidAmount = (decimal)reader["PaidAmount"];
        //        dto.DueAmount = (decimal)reader["DueAmount"];
        //        dto.PaymentMode = (string)reader["PaymentMode"];
        //        dto.Bo_PK = (Guid)reader["Bo_PK"];
        //        dto.Remarks = (string)reader["Remarks"];
        //        dto.EntryBy = (string)reader["EntryBy"];
        //        dto.EntryDate = (DateTime)reader["EntryDate"];

        //        return dto;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}



        #endregion

    }
}
