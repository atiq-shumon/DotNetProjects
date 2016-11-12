using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DMS.MODEL;
using AH.DMS.DAL;
using AH.Shared.MODEL;

namespace AH.DMS.BLL
{
    public class DMSReportBLL
    {
        public List<MoneyReceiptRO> GetMoneyReceiptReport(string MoneyReceiptNo)
        {
            return new MoneyReceiptReportDAL().GetMoneyReceiptReport(MoneyReceiptNo);
        }
        public List<MoneyReceiptRO> GetRefundMoneyReceiptReport(string moneyReceiptNo)
        {
            return new MoneyReceiptReportDAL().GetRefundMoneyReceiptReport(moneyReceiptNo);
        }
        public List<MoneyReceiptRO> GetDuePayment(string MrNo)
        {
            return new MoneyReceiptReportDAL().GetDuePayment(MrNo);
        }
        public List<MoneyReceiptRO> GetTotalCollection(string StartDate, string EndDate)
        {
            return new MoneyReceiptReportDAL().GetTotalCollection(StartDate, EndDate);
        }
        public List<MoneyReceiptRO> GetUserWiseCollection(string EmpId,string StartDate, string EndDate)
        {
            return new MoneyReceiptReportDAL().GetUserWiseCollection(EmpId,StartDate, EndDate);
        }
        public List<MoneyReceiptRO> GetPatientDueList(string StartDate, string EndDate)
        {
            return new MoneyReceiptReportDAL().GetPatientDueList(StartDate, EndDate);
        }
        public List<TestSetupRO> GetTestDetailsReport(string DeptID, string GroupID, string MainID)
        {
            return new TestSetupReportDAL().GetTestDetailsReport(DeptID, GroupID, MainID);
        }
        public List<TestSetupRO> GetDetailsTest(string DeptID)
        {
            return new TestSetupReportDAL().GetDetailsTest(DeptID);
        }
        public List<TestSetupRO> GetAllPanelTest()
        {
            return new TestSetupReportDAL().GetAllPanelTest();
        }
        public List<AccountsPayment> GetIntegretedVoucher(string UserID,string StartDate,string EndDate)
        {
            return new MoneyReceiptReportDAL().GetIntegretedVoucher(UserID,StartDate, EndDate);
        }
        public List<TestSetupRO> GetReportPanelTest()
        {
            return new TestSetupReportDAL().GetReportPanelTest();
        }
        public List<MoneyReceiptRO> GetAllRefundMR(string EmpId, string StartDate, string EndDate)
        {
            return new MoneyReceiptReportDAL().GetAllRefundMR(EmpId, StartDate, EndDate);
        }
         public List<MoneyReceiptRO> GetAllCancelMR(string EmpId, string StartDate, string EndDate)
        {
            return new MoneyReceiptReportDAL().GetAllCancelMR(EmpId, StartDate, EndDate);
        }
         public List<MoneyReceiptRO> GetDoctorWiseCollection(string TicketType, string StartDate, string EndDate)
         {
             return new MoneyReceiptReportDAL().GetDoctorWiseCollection(TicketType, StartDate, EndDate);
         }       
         public List<MoneyReceiptRO> GetAllTestByHCN(string HCN, string StartDate, string EndDate)
         {
             return new MoneyReceiptReportDAL().GetAllTestByHCN(HCN, StartDate, EndDate);
         }
         public List<MoneyReceiptRO> GetTestMainWiseTestDetails(string StartDate, string EndDate)
         {
             return new MoneyReceiptReportDAL().GetTestMainWiseTestDetails(StartDate, EndDate);
         }
         public List<EmergencyCollectionRO> GetEmergencyMoneyReceiptReport(string moneyReceiptNo)
         {
             return new MoneyReceiptReportDAL().GetEmergencyMoneyReceiptReport(moneyReceiptNo);
         }
        public List<EmergencyMasterRO> GetEmergencyPrescription(string moneyReceiptNo)
        {
            return new MoneyReceiptReportDAL().GetEmergencyPrescription(moneyReceiptNo);
        }
    }
}
