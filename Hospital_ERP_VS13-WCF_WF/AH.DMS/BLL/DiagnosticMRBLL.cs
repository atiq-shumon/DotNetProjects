using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.IPDShared.MODEL;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.DMS.DAL;
using AH.DTMS.MODEL;
using AH.HR.BLL;
using AH.ORGMS.BLL;
using AH.IPDShared.BLL;
using AH.Shared.MODEL;

//using AH.IPD.BLL;

namespace AH.DMS.BLL
{
    public class DiagnosticMRBLL
    {
        public Dictionary<string, string> GetDepartments(string type)
        {
            return new AdministrationSetupBLL().GetDepartments(type);
        }
        public Dictionary<string, string> GetDeptGroup(string type)
        {
            return new AdministrationSetupBLL().GetDeptGroup(type);
        }
        public Dictionary<string, string> GetDepartmentGroupWise(string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentGroupWise(deptgr);
        }
        public string SaveDiagnosticMR(DiagnosticMR mr)
        {
            return new DiagnosticMRDAL().SaveDiagnosticMR(mr);
        }
        public List<DiagnosticMR> GetDiagHistory(string regno)
        {
            return new DiagnosticMRDAL().GetDiagHistory(regno);
        }

        public List<TestFee> GetReportTest(string mrno)
        {
            return new DiagnosticMRDAL().GetReportTest(mrno);
        }
        public InPatient GetCurrentPatient(string mrno)
        {
            return new DiagnosticMRDAL().GetCurrentPatient(mrno);
        }

        public string VerifyInPatient(string regNo)
        {         
           return new IPDSharedBLL().VerifyInPatient(regNo);           
        }
        public InPatient GetAdmittedPatient(string RegistrationNo)
        {
            return new IPDSharedBLL().GetAdmittedPatient(RegistrationNo);  
        }
         public InPatient GetPatientDetails(string presID)
         {
             return new IPDSharedBLL().GetPatientDetails(presID);
         }

        //public string VarifyTicketNo(string tktno)
        //{
        //    return new OPDDAL().VarifyTicketNo(tktno);
        //}
        //public InPatient GetPatreg(string RegistrationNo)
        //{
        //    return new IPDDAL().GetPatreg(RegistrationNo);
        //}
        //public InPatient GetCurrentPatient(string mrno)
        //{
        //    return new DiagnosticSetupDAL().GetCurrentPatient(mrno);
        //}
        //public List<TestFee> GetReportTest(string mrno)
        //{
        //    return new DiagnosticSetupDAL().GetReportTest(mrno);
        //}
         public List<TestFee> GetDmrTestForCancel(string mrno)
         {
             return new DiagnosticMRDAL().GetDmrTestForCancel(mrno);
         }
         public List<TestFee> GetTotalTestFee(string mrno)
         {
             return new DiagnosticMRDAL().GetTotalTestFee(mrno);
         }
         public List<DiagnosticMR> GetReffDoctor(string mrno)
         {
             return new DiagnosticMRDAL().GetReffDoctor(mrno);
         }
         public List<TestFee> GetDmrTestForRefund(string mrno)
         {
             return new DiagnosticMRDAL().GetDmrTestForRefund(mrno);
         }
        public short SaveDiagnosticMRDraft(DiagnosticMR mr)
        {
            return new DiagnosticMRDAL().SaveDiagnosticMRDraft(mr);
        }
        public List<DiagnosticMR> GetDraftList(string entryby)
        {
            return new DiagnosticMRDAL().GetDraftList(entryby);
        }
        public string verifyMrno(string mrno)
        {
            return new DiagnosticMRDAL().verifyMrno(mrno);
        }
        public List<TestFee> GetDmrTest(string mrno)
        {
            return new DiagnosticMRDAL().GetDmrTest(mrno);
        }
         public List<TestFee> GetDmrTest(string mrno,string Dept,string reportGrp)
        {
            return new DiagnosticMRDAL().GetDmrTest(mrno, Dept, reportGrp);
        }
        public DiagnosticMR GetDmrCollMaster(string mrno)
        {
            return new DiagnosticMRDAL().GetDmrCollMaster(mrno);
        }
        public string SaveDuePayment(DuePayment oDuePay)
        {
            return new DiagnosticMRDAL().SaveDuePayment(oDuePay);
        }
        public LoadPatient GetCurrentPatientByPhone(string PhoneNo)
        {
            return new DiagnosticMRDAL().GetCurrentPatientByPhone(PhoneNo);
        }
        public List<TestFee> GetDmrTestsForIPD(string RegNo)
        {
            return new DiagnosticMRDAL().GetDmrTestsForIPD(RegNo);
        }
        public List<NursingTestOrder> GetNursingStation()
        {
            return new DiagnosticMRDAL().GetNursingStation();
        }
        public List<NursingTestOrder> GetNursingStationRegNum(string ReqNo)
        {
            return new DiagnosticMRDAL().GetNursingStationRegNum(ReqNo);
        }
        public List<TestFee> GetIPDTests(string RegNo, string DrNo)
        {
            return new DiagnosticMRDAL().GetIPDTests(RegNo, DrNo);
        }
        public List<AccountsPayment> GetAccountsPayment(string CollectionDate, string UserID)
        {
            return new DiagnosticMRDAL().GetAccountsPayment(CollectionDate, UserID);
        }
        public string SaveAccountsPayment(AccountsPayment oAccounts)
        {
            return new DiagnosticMRDAL().SaveAccountsPayment(oAccounts);
        }
        public DiagnosticMR GetAdvance(string mrno)
        {
            return new DiagnosticMRDAL().GetAdvance(mrno);
        }
        public string SaveDiagnosticRefundMR(DiagnosticMR mr)
        {
            return new DiagnosticMRDAL().SaveDiagnosticRefundMR(mr);
        }
        public short SaveLabelTestAssociation(TestSub oTestSub)
        {
            return new DiagnosticMRDAL().SaveLabelTestAssociation(oTestSub);
        }
        public List<TestSub> GetTestLabel(string TestDetID)
        {
            return new DiagnosticMRDAL().GetTestLabel(TestDetID);
        }
        public List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate)
        {
            return new DiagnosticMRDAL().GetCollectionSummary(StartDate, EndDate);
        }
        public short UpdateReffDoctor(DiagnosticMR mr)
        {
            return new DiagnosticMRDAL().UpdateReffDoctor(mr);
        }
        public List<DiagnosticMR> GetDueByHCN(string HCN)
        {
            return new DiagnosticMRDAL().GetDueByHCN(HCN);
        }
        public List<MoneyReceiptRO> GetUserWiseCashCollection(string StartDate, string EndDate)
        {
            return new DiagnosticMRDAL().GetUserWiseCashCollection(StartDate, EndDate);
        }
        public List<MoneyReceiptRO> GetAllCollectionSummary(string StartDate, string EndDate)
        {
            return new DiagnosticMRDAL().GetAllCollectionSummary(StartDate, EndDate);
        }
        public List<EmergencyMasterRO> GetPatByEmerPres(string Prescription)
        {
            return new DiagnosticMRDAL().GetPatByEmerPres(Prescription);
        }
        public List<EmergencyMasterRO> GetEmerDiagBill(string Prescription)
        {
            return new DiagnosticMRDAL().GetEmerDiagBill(Prescription);
        }
    }
}
