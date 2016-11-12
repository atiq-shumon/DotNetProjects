using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using Oracle.DataAccess.Client;
namespace AH.DMS.DAL
{
    public class MoneyReceiptReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.DMSMIS);
        string packageName = string.Empty;
        public List<MoneyReceiptRO> GetMoneyReceiptReport(string moneyReceiptNo)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_Diagonostic_Bill";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,moneyReceiptNo,ParameterDirection.Input)
              };

            return GetMoneyReceiptReportDetails(packageName, parameterList);
        }
      
        public List<MoneyReceiptRO> GetMoneyReceiptReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> rDMSs = new List<MoneyReceiptRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDMSs = CreateObjects(reader);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return rDMSs;
        }
        #region DataReaderMappingwithNUll
        private MoneyReceiptRO MapObject(NullHandler oReader)
        {
            MoneyReceiptRO oDMR = new MoneyReceiptRO();
            oDMR.MoneyReceipNo = oReader.GetString("MoneyReceipNo");
            oDMR.TransactionNo = oReader.GetString("TransactionNo");
            oDMR.TicketNo = oReader.GetString("TicketNo");
            oDMR.TicketType = oReader.GetString("TicketType");
            oDMR.HCN = oReader.GetString("HCN");
            oDMR.DepertmentName = oReader.GetString("DepertmentName");
            oDMR.ReffOrgID = oReader.GetString("REFF_ORG_ID");
            oDMR.ReffOrgName = oReader.GetString("ORG_TITLE");
            oDMR.DoctorID = oReader.GetString("DOC_ID");
            oDMR.DoctorName = oReader.GetString("DoctorName");
            oDMR.DoctorTitle = oReader.GetString("DOC_TITLE");
            oDMR.DepertmentName = oReader.GetString("DepertmentName");
            oDMR.Vat = oReader.GetDouble("Vat");
            oDMR.Discount = Convert.ToDouble(oReader.GetDouble("Discount"));
            oDMR.IndividualDiscount = Convert.ToDouble(oReader.GetDouble("IndividualDisc"));
            oDMR.Advance = Convert.ToDouble(oReader.GetDouble("Advance"));
            oDMR.Due = Convert.ToDouble(oReader.GetDouble("Due"));
            oDMR.NetPaid = Convert.ToDouble(oReader.GetDouble("NetPaid"));
            oDMR.PaymentType = oReader.GetString("PaymentType");
            oDMR.Remarks = oReader.GetString("Remarks");
            oDMR.LAB_ROOM_NO = oReader.GetString("LAB_ROOM_NO");
            oDMR.Fee = Convert.ToDouble(oReader.GetDouble("Fee"));
            oDMR.DepositAmount = Convert.ToDouble(oReader.GetDouble("DepositAmount"));
            oDMR.TestName = oReader.GetString("TestName");
            oDMR.Age = oReader.GetString("Age");
            oDMR.PatientName = oReader.GetString("PatientName");
            oDMR.Sex = oReader.GetString("Sex");
            oDMR.Address = oReader.GetString("Address");
            oDMR.MobileNo = oReader.GetString("MobileNo");
            oDMR.HomePhone = oReader.GetString("HomePhone");
            oDMR.EntryBy = oReader.GetString("ENTRY_BY_NAME");
            oDMR.TDetID = oReader.GetString("TDetID");
            oDMR.BedID = oReader.GetString("BED_ID");
            oDMR.BedTitle = oReader.GetString("bedtitle");
            oDMR.EntryDate = oReader.GetDateTime("ENTRY_DATE").ToString("dd/MM/yyyy");
            oDMR.CashAmt = oReader.GetDouble("CASH_AMT");
            oDMR.DrAmount = oReader.GetDouble("DEBIT_CARD_AMT");
            oDMR.CrAmount = oReader.GetDouble("CREDIT_CARD_AMT");
            oDMR.PackageID = oReader.GetString("DIAG_PKG_ID");
            oDMR.PackageTitle = oReader.GetString("PACKAGE_TITLE");
            oDMR.PackageAmount = Convert.ToDouble(oReader.GetDouble("PACKAGE_AMOUNT"));
            oDMR.TestCancelStatus = oReader.GetString("TestCancelStatus");
            return oDMR;
        }
        private MoneyReceiptRO CreateObject(NullHandler oReader)
        {
            MoneyReceiptRO oDMR = new MoneyReceiptRO();
            oDMR = MapObject(oReader);
            return oDMR;
        }
        private List<MoneyReceiptRO> CreateObjects(IDataReader oReader)
        {
            List<MoneyReceiptRO> rDMSs = new List<MoneyReceiptRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                MoneyReceiptRO oItem = CreateObject(oHandler);
                rDMSs.Add(oItem);
            }
            return rDMSs;
        }
        #endregion

        #region GetRefundMoneyReceiptReport
        public List<MoneyReceiptRO> GetRefundMoneyReceiptReport(string moneyReceiptNo)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_Refund_Bill";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,moneyReceiptNo,ParameterDirection.Input)
              };

            return GetRefundReceiptReportDetails(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetRefundReceiptReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.MoneyReceipNo = (string)rdr["MoneyReceipNo"].ToString();
                oDMR.TransactionNo = (string)rdr["TransactionNo"].ToString();               
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.Advance = Convert.ToDouble(rdr["Advance"]);
                oDMR.NetPaid = Convert.ToDouble(rdr["NetPaid"]);
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.Age = (string)rdr["Age"].ToString();
                oDMR.Sex = (string)rdr["Sex"].ToString();
                oDMR.Address = (string)rdr["Address"].ToString();               
                oDMR.EntryBy = (string)rdr["ENTRY_BY_NAME"].ToString() ;
                oDMR.TestName = (string)rdr["TestName"].ToString();
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetDuePayment
        public List<MoneyReceiptRO> GetDuePayment(string MrNo)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_due_payment";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mr_no",OracleDbType.Varchar2,20,MrNo,ParameterDirection.Input)
           };

            return GetDuePaymentDetails(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetDuePaymentDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.MoneyReceipNo = (string)rdr["MR_NO"].ToString();
                oDMR.TransactionNo = (string)rdr["TransactionNo"].ToString();
                oDMR.TicketNo = (string)rdr["TicketNo"].ToString();
                oDMR.TicketType = (string)rdr["TicketType"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.NetAmt = Convert.ToDouble(rdr["Prev_paid"].ToString());
                oDMR.NetPaid = Convert.ToDouble(rdr["NetPaid"].ToString());
                oDMR.Due = Convert.ToDouble(rdr["Due"].ToString());
                oDMR.PaymentType = rdr["PaymentType"].ToString();
                oDMR.newTransNo = (string)rdr["NewTransactionNo"].ToString();
                oDMR.PaidAmt = Convert.ToDouble(rdr["PAID_AMT"].ToString());
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.DepertmentName = (string)rdr["DepertmentName"].ToString();
                oDMR.Age = (string)rdr["Age"].ToString();
                oDMR.Sex = (string)rdr["Sex"].ToString();
                oDMR.Address = (string)rdr["Address"].ToString();
                oDMR.MobileNo = (string)rdr["MobileNo"].ToString();
                oDMR.HomePhone = (string)rdr["HomePhone"].ToString();
                oDMR.Fee = Convert.ToDouble(rdr["FEE"].ToString());
                oDMR.EntryBy = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetDuePayment
        public List<MoneyReceiptRO> GetPatientDueList(string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.get_patient_due_list";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };

            return GetPatientDueLists(packageName, parameterList);
        }
        public List<MoneyReceiptRO> GetTotalCollection(string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.get_total_collection";
             OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };
            return GetPatientDueLists(packageName, parameterList);
        }
        public List<MoneyReceiptRO> GetUserWiseCollection(string EmpId,string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.get_user_wise_collection";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,100,EmpId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };

            return GetPatientDueLists(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetPatientDueLists(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.MoneyReceipNo = (string)rdr["MR_NO"].ToString();
                oDMR.TransactionNo = (string)rdr["TransactionNo"].ToString();
                oDMR.TicketNo = (string)rdr["TicketNo"].ToString();
                oDMR.TicketType = (string)rdr["TicketType"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.NetAmt = Convert.ToDouble(rdr["Net_amt"].ToString());
                oDMR.NetPaid = Convert.ToDouble(rdr["NetPaid"].ToString());
                oDMR.Due = Convert.ToDouble(rdr["Due"].ToString());
                oDMR.PaymentType = rdr["PaymentType"].ToString();
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.Age = (string)rdr["Age"].ToString();
                oDMR.Sex = (string)rdr["Sex"].ToString();
                oDMR.Address = (string)rdr["Address"].ToString();
                oDMR.MobileNo = (string)rdr["MobileNo"].ToString();
                oDMR.HomePhone = (string)rdr["HomePhone"].ToString();
                oDMR.DueStatus = (string)rdr["DUE_STATUS"].ToString();
                oDMR.EntryBy = (string)rdr["ENTRY_BY"].ToString();
                oDMR.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetIntegretedVoucher
        public List<AccountsPayment> GetIntegretedVoucher(string UserID,string StartDate,string EndDate)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.get_integreted_voucher";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_user_id",OracleDbType.Varchar2,20,UserID,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,20,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,20,EndDate,ParameterDirection.Input)
           };

            return GetIntegretedVoucherDetails(packageName, parameterList);
        }
        private List<AccountsPayment> GetIntegretedVoucherDetails(string packageName, OracleParameter[] parameterList)
        {
            List<AccountsPayment> oDMRs = new List<AccountsPayment>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AccountsPayment oDMR = new AccountsPayment();
                oDMR.UserID = (string)rdr["USER_ID"].ToString();
                oDMR.UserName = (string)rdr["UserName"].ToString();
                oDMR.VoucherNo = (string)rdr["VOU_NUM"].ToString();
                oDMR.PaymentAmount = Convert.ToDouble(rdr["NET_AMOUNT"].ToString());
                oDMR.EntryBy = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMR.EntryDate =Convert.ToDateTime(rdr["ENTRY_DATE"].ToString()).ToString("dd/MM/yyyy");
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetAllRefundMR
        public List<MoneyReceiptRO> GetAllRefundMR(string EmpId, string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.get_all_refund_report";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,100,EmpId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };

            return GetAllRefundMRDetails(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetAllRefundMRDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.RefundMoneyReceipNo = (string)rdr["MR_NO"].ToString();
                oDMR.MoneyReceipNo = (string)rdr["PAID_MR_NO"].ToString();
                oDMR.TransactionNo = (string)rdr["TRANSAC_NO"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.NetPaid = Convert.ToDouble(rdr["REFD_AMT"].ToString());
                oDMR.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetAllCancelMR
        public List<MoneyReceiptRO> GetAllCancelMR(string EmpId, string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.get_all_test_cancel_report";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,100,EmpId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };

            return GetAllCancelMRDetails(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetAllCancelMRDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.MoneyReceipNo = (string)rdr["MR_NO"].ToString();
                oDMR.TransactionNo = (string)rdr["TRANSAC_NO"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.NetPaid = Convert.ToDouble(rdr["fee"].ToString());
                oDMR.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetDoctorWiseCollection
        public List<MoneyReceiptRO> GetDoctorWiseCollection(string TicketType, string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.get_doctor_wise_collection";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_ticket_type",OracleDbType.Varchar2,100,TicketType,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };

            return GetDoctorWiseCollectionDet(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetDoctorWiseCollectionDet(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.TDetID = (string)rdr["TestDetID"].ToString();
                oDMR.TestName = (string)rdr["TestName"].ToString();
                oDMR.TestMainID = (string)rdr["TEST_MAIN_ID"].ToString();
                oDMR.TestMainName = (string)rdr["TEST_MAIN_TITLE"].ToString();
                oDMR.Fee = Convert.ToDouble(rdr["Fee"].ToString());
                oDMR.DeptFee = Convert.ToDouble(rdr["Dept_amt"].ToString());
                oDMR.Discount = Convert.ToDouble(rdr["Disc"].ToString());
                oDMR.TicketType = (string)rdr["TicketType"].ToString();
                oDMR.PaymentType = (string)rdr["PaymentType"].ToString();
                oDMR.NetPaid = Convert.ToDouble(rdr["NetPaid"].ToString());
                oDMR.Advance = Convert.ToDouble(rdr["Advance"].ToString());
                oDMR.Due = Convert.ToDouble(rdr["Due"].ToString());
                oDMR.ReffOrgID = (string)rdr["REFF_ORG_ID"].ToString();
                oDMR.ReffOrgName = (string)rdr["ORG_TITLE"].ToString();
                oDMR.DoctorID = (string)rdr["DOC_ID"].ToString();
                oDMR.DoctorName = (string)rdr["DOC_TITLE"].ToString();
                oDMR.EntryBy = (string)rdr["ENTRY_BY"].ToString();
                oDMR.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetAllTestByHCN
        public List<MoneyReceiptRO> GetAllTestByHCN(string HCN, string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.GET_TEST_BY_HCN";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_hcn",OracleDbType.Varchar2,100,HCN,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };
            return GetAllTestByHCNDetails(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetAllTestByHCNDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.MoneyReceipNo = (string)rdr["MoneyReceipNo"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.TestMainName = (string)rdr["TestMainName"].ToString();
                oDMR.TDetID = (string)rdr["test_det_id"].ToString();
                oDMR.TestName = (string)rdr["TestName"].ToString();
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.Age = (string)rdr["Age"].ToString();
                oDMR.EntryDate =Convert.ToDateTime(rdr["ENTRY_DATE"].ToString()).ToString("dd/MM/yyyy");
                oDMR.Fee = Convert.ToDouble(rdr["Fee"].ToString());
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetTestMainWiseTestDetails
        public List<MoneyReceiptRO> GetTestMainWiseTestDetails(string StartDate, string EndDate)
        {
            string packageName = "DiagnosticManagementReport.GET_TEST_MAIN_WISE_COLL_DET";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,100,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,100,EndDate,ParameterDirection.Input)
           };
            return GetTestMainWiseDetails(packageName, parameterList);
        }
        private List<MoneyReceiptRO> GetTestMainWiseDetails(string packageName, OracleParameter[] parameterList)
        {
            List<MoneyReceiptRO> oDMRs = new List<MoneyReceiptRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MoneyReceiptRO oDMR = new MoneyReceiptRO();
                oDMR.TestGroupName = (string)rdr["groupname"].ToString();
                oDMR.TestMainName = (string)rdr["testmainname"].ToString();
                oDMR.TestName = (string)rdr["testname"].ToString();
                oDMR.NoOfTest = Convert.ToDouble(rdr["Qty"].ToString());              
                oDMR.Fee = Convert.ToDouble(rdr["Fee"].ToString());
                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion


        #region GetEmergencyMoneyReceiptReport
        public List<EmergencyCollectionRO> GetEmergencyMoneyReceiptReport(string moneyReceiptNo)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_Emergency_Bill";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,moneyReceiptNo,ParameterDirection.Input)
              };

            return GetEmergencyReceiptReportDetails(packageName, parameterList);
        }
        private List<EmergencyCollectionRO> GetEmergencyReceiptReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmergencyCollectionRO> oDMRs = new List<EmergencyCollectionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmergencyCollectionRO oDMR = new EmergencyCollectionRO();
                oDMR.MoneyReceipNo = (string)rdr["MoneyReceipNo"].ToString();
                oDMR.TransactionNo = (string)rdr["TransactionNo"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();            
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.Age = (string)rdr["Age"].ToString();
                oDMR.Sex = (string)rdr["Sex"].ToString();
                oDMR.Address = (string)rdr["Address"].ToString();
                oDMR.EntryBy = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMR.HeadID = (string)rdr["HEAD_ID"].ToString();
                oDMR.HeadName = (string)rdr["HEAD_TITLE"].ToString();
                oDMR.Qty =Convert.ToDouble(rdr["QTY"].ToString());
                oDMR.Fee = Convert.ToDouble(rdr["FEE"].ToString());
                oDMR.Advance = Convert.ToDouble(rdr["Advance"]);
                oDMR.NetPaid = Convert.ToDouble(rdr["NetPaid"]);
                oDMR.CashAmt = Convert.ToDouble(rdr["CASH_AMT"]);
                oDMR.DrAmount = Convert.ToDouble(rdr["DEBIT_CARD_AMT"]);
                oDMR.CrAmount = Convert.ToDouble(rdr["CREDIT_CARD_AMT"]);
                oDMR.ReffOrgName = rdr["ORG_TITLE"].ToString();
                oDMR.DoctorName = rdr["DOC_TITLE"].ToString();
                oDMR.EntryDate = rdr["ENTRY_DATE"].ToString();

                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetEmergencyPrescription
        public List<EmergencyMasterRO> GetEmergencyPrescription(string moneyReceiptNo)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_Emergency_Prescription";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,moneyReceiptNo,ParameterDirection.Input)
              };

            return GetEmergencyPrescriptionDetails(packageName, parameterList);
        }
        private List<EmergencyMasterRO> GetEmergencyPrescriptionDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmergencyMasterRO> oDMRs = new List<EmergencyMasterRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmergencyMasterRO oDMR = new EmergencyMasterRO();
                oDMR.EmergencyPrescriptionID = (string)rdr["E_PRES_NO"].ToString();
                oDMR.TransactionNo = (string)rdr["TRANSAC_NO"].ToString();
                oDMR.HCN = (string)rdr["HCN"].ToString();
                oDMR.PatientName = (string)rdr["PatientName"].ToString();
                oDMR.Age = (string)rdr["Age"].ToString();
                oDMR.Gender = (string)rdr["Sex"].ToString();
                oDMR.Address = (string)rdr["Address"].ToString();
                oDMR.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
                oDMR.TicketFee = Convert.ToDouble(rdr["TKT_FEE"]);
                oDMR.ConsultantFee = Convert.ToDouble(rdr["CONSULT_FEE"]);               
                oDMR.ReffOrgName = rdr["ORG_TITLE"].ToString();
                oDMR.DoctorName = rdr["DOC_TITLE"].ToString();
                oDMR.FormatDept = rdr["FormatDept"].ToString();

                oDMRs.Add(oDMR);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

       
    }
}
