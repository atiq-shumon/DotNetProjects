using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.DTMS.MODEL;
using AH.IPDShared.MODEL;
using AH.Shared.MODEL;
using AH.PatReg.MODEL;
using AH.OPD.MODEL;
using AH.DMS.MODEL;
using AH.IPDShared.BLL;
using AH.DUtility;

namespace AH.DMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDMSWS" in both code and config file together.
    [ServiceContract]
    public interface IDMSWS
    {
        [OperationContract]
        Dictionary<string, string> GetPrescriptionTypes();
        [OperationContract]
        List<MoneyReceiptRO> GetRefundMoneyReceiptReport(string moneyReceiptNo);
        [OperationContract]
        Dictionary<string, string> GetDepartments(string type);
        [OperationContract]
        Dictionary<string, string> GetTestGroups(string type);
        [OperationContract]
        int VerifyTestFee(string detail);
        [OperationContract]
        List<TestFee> GetTestFee(string dept, string group, string main, string feeCategory);
        [OperationContract]
        List<TestSetupRO> GetDetailsTest(string DeptID);
        //[OperationContract]
        //List<TestFee> GetTestFee();
        [OperationContract]
        Dictionary<string, string> GetDeptGroup(string type);
        [OperationContract(Name = "GetTestFeeDeptGrpCate")]
        List<TestFee> GetTestFeeGrp(string group, string detail);
        [OperationContract]
        string VarifyTicketNo(string tktno, bool isPescribed);
        [OperationContract]
        Patient GetPatient(string pId, string mode);
        [OperationContract]
        List<Patient> GetPatientByPhone(string name, string cell);
        [OperationContract]
        Ticket GetTicket(string tktNo);
        [OperationContract]
        string SaveDiagnosticMR(DiagnosticMR mr);
        [OperationContract]
        int VerifyTestGroup(string groupId);
        [OperationContract]
        short SaveTestGroup(TestGroup tg);
        [OperationContract]
        short UpdateGroup(TestGroup upd);
        [OperationContract]
        int VerifyTestMain(string mainid);
        [OperationContract]
        short SaveTestMain(TestMain tm);
        [OperationContract]
        short UpdateTestMain(TestMain tmain);
        [OperationContract(Name = "GetMainDict")]
        Dictionary<string, string> GetTestMain(string type);
        [OperationContract(Name = "GetMainDeptGroupwiseList")]
        List<TestMain> GetTestMain(string department, string group);

        [OperationContract(Name = "GetMainDeptwise")]
        Dictionary<string, string> GetTestMain(string type, string department, string group);
        [OperationContract]
        short SaveTestPanel(GroupPanel tp);
        [OperationContract]
        short UpdateTestPanel(GroupPanel tspanel);
        [OperationContract]
        short SaveTestDetail(TestSub tsp);
        [OperationContract]
        short UpdateTestDetail(TestSub tdtail);
        [OperationContract]
        short SaveTestFee(TestFee tf);
        [OperationContract]
        short UpdateTestFee(TestFee tfee);
        [OperationContract]
        short UpdateDiagnosticTestFee(TestFee tfee);
        [OperationContract]
        int VerifyTestDetail(string detailid);
        [OperationContract]
        List<TestGroup> GetDiagnGrp();
        [OperationContract(Name = "GetDiagnGrpDict")]
        Dictionary<string, string> GetDiagnGrp(string type);
        [OperationContract(Name = "GetDiagnGrpDeptWise")]
        Dictionary<string, string> GetDiagnGrp(string type, string department);
        [OperationContract]
        List<TestGroup> GetDiagnGrpTest(string department);
        [OperationContract]
        List<TestMain> GetTestMain();
        [OperationContract]
        List<GroupPanel> GetPanelSetup();
        [OperationContract(Name = "GetPanelSetupDict")]
        Dictionary<string, string> GetPanelSetup(string type);
        [OperationContract]
        List<TestSub> GetTestDetail();
        [OperationContract]
        List<TestSub> GetTestDetails(string deptid, string group, string main);
        [OperationContract]
        Dictionary<string, string> GetTestDetailsDict(string deptid, string group, string main);
        [OperationContract]
        List<TestSub> GetUnassignTest(string deptid, string group, string main);
        [OperationContract(Name = "GetTestDetailDict")]
        Dictionary<string, string> GetTestDetails(string type, string deptid, string group, string main);
        [OperationContract]
        int VerifyTestCat(string catid);
        [OperationContract]
        short SaveCategory(TestCategory testCat);
        [OperationContract]
        short UpdateCategory(TestCategory tcat);
        [OperationContract]
        List<TestCategory> GetCategories();
        [OperationContract(Name = "GetCategoryDict")]
        Dictionary<string, string> GetCategories(string type);
       
        [OperationContract(Name = "GetSpecDict")]
        Dictionary<string, string> GetSpec(string type);
        [OperationContract]
        int VerifyFeeCategory(string feecat);
        [OperationContract]
        short SaveFeeCategory(FeeCategory fcat);
        [OperationContract]
        short UpdateFeeCategory(FeeCategory fecat);
        [OperationContract]
        List<FeeCategory> GetFeecats();
        [OperationContract(Name = "GetFeecatDict")]
        Dictionary<string, string> GetFeecats(string type);
        [OperationContract(Name = "GetRoomsDict")]
        Dictionary<string, string> GetRooms(string types);
        [OperationContract(Name = "GetRoomSetup")]
        Dictionary<string, short> GetRoomSet(string type);
        [OperationContract]
        string VerifyInPatient(string regNo);
       
        [OperationContract]
        List<short> GetNumbers(short min, short max);
        [OperationContract]
        List<TestFee> GetPrescriptionTests(string ticketno, string feecat,string status);
        [OperationContract]
        string VerifyPatientNo(string patNo);
        [OperationContract]
        short SaveDiagnosticMRDraft(DiagnosticMR mr);
        [OperationContract]
        List<DiagnosticMR> GetDraftList(string entryby);
        [OperationContract]
        List<MoneyReceiptRO> GetMoneyReceiptReport(string MoneyReceiptNo);
        [OperationContract]
        List<TestSetupRO> GetTestDetailsReport(string DeptID, string GroupID,string MainID);
        //reports
        [OperationContract]
        int VerifySpecSetup(string spcid);
        [OperationContract]
        short SaveSpecsetup(Specimen spec);
        [OperationContract]
        short UpdateSpecimen(Specimen uspc);
        [OperationContract]
        List<Specimen> GetSpec();


        [OperationContract]
        int VerifyReportGroup(string groupid);
        [OperationContract]
        short SaveReportGr(ReportGroup reptgrp);
        [OperationContract]
        short UpdateReportGr(ReportGroup urepgr);

        [OperationContract]
        List<ReportGroup> GetRptgrp();
        [OperationContract(Name = "GetRptgrpDict")]
        Dictionary<string, string> GetRptgrp(string type);

        [OperationContract(Name = "GetRptgrpDictByDept")]
        Dictionary<string, string> GetRptgrpSetup(string type, string dept);
        [OperationContract]
        List<ReportGroup> GetRptgrpSetup(string dept);
        [OperationContract]
        List<TestFee> GetDmrTest(string mrno);


        [OperationContract]
        int VerifyResHdGrp(string hdgrpid);
        [OperationContract]
        short SaveReshdGr(ResultHeadGroup rshdgr);
        [OperationContract]
        short UpdateReshdGr(ResultHeadGroup ureshdgr);

         [OperationContract]
         int VerifyResUnit(string runit);
         [OperationContract]
         short SaveRshdUnit(ResultHeadUnit rshdunit);
         [OperationContract]
         short UpdateResUnit(ResultHeadUnit ursunit);
         [OperationContract]
         int VerifyResHd(string headId);
         [OperationContract]
         short SaveReshd(ResultHead rshd);
         [OperationContract]
         short UpdateReshd(ResultHead ureshd);
         [OperationContract]
         List<ResultHead> GetResultHd();
        [OperationContract]
         List<ResultHead> GetResultHdBySecGrp(string sec, string grp);
        [OperationContract]
        List<ResultHeadRO> GetResultHeadReport(string sec, string grp);
        [OperationContract]
         List<ResultHeadGroup> GetResHdGrp();
         [OperationContract]
         List<ResultHeadGroup> GetResultHeaddGrp(string Dept, string Sec);
         [OperationContract(Name = "GetResHdGrpDict")]
         Dictionary<string, string> GetResHdGrp(string type);
         [OperationContract]
         List<ResultHeadUnit> GetResUnit();
         [OperationContract(Name = "GetResUnitDict")]
         Dictionary<string, string> GetResUnit(string type);
         [OperationContract]
         Dictionary<string, string> GetDepartmentGroupWise(string deptgr);
         [OperationContract]
         string verifyMrno(string mrno);
         [OperationContract]
         InPatient GetCurrentPatient(string mrno);
         [OperationContract]
         string SaveTestCancel(DiagnosticMR mr);
         [OperationContract]

         List<TestFee> GetDmrTestForCancel(string mrno);
         [OperationContract]
         List<TestFee> GetTotalTestFee(string mrno);
        [OperationContract]
         List<TestFee> GetDmrTestForRefund(string mrno);
        [OperationContract]
         short SaveTestCancelCause(TestCancelCause oCanCause);
         [OperationContract]
         List<TestCancelCause> GetCancelCause();
         [OperationContract]
         short UpdateCancelCause(TestCancelCause oCanCause);
         [OperationContract]
         Dictionary<string, string> GetCancelCauseDic(string type);
         [OperationContract]
         DiagnosticMR GetDmrCollMaster(string mrno);
         [OperationContract]
         string SaveDuePayment(DuePayment oDuePay);
         [OperationContract]
         List<MoneyReceiptRO> GetDuePayment(string MrNo);
         [OperationContract]
         List<MoneyReceiptRO> GetPatientDueList(string StartDate, string EndDate);
         [OperationContract]
         //List<TestSub> InsertPanelTests(TestSub oTestDetails);
         short InsertPanelTests(TestSub oTestDetails);
         //[OperationContract]
         //short UpdatePanelTests(TestSub oTestDetails);
         [OperationContract(Name = "GetTestName")]
         Dictionary<string, string> GetTestDetail(string type);
         [OperationContract]
         List<TestFee> GetPanelTests(string PanelId);
         [OperationContract]
         List<TestFee> GetPanelTest(string PanelId);
         [OperationContract]
         List<TestFee> GetTestDet(string group, string detail);
         [OperationContract]
         List<SpecimenHolder> GetSpecHolder();
         [OperationContract]
         List<SpecimenHolder> GetSpecimenHolder(string ColorCode);
         [OperationContract(Name = "GetSpecHolderDict")]
         Dictionary<string, string> GetSpecHolder(string type);
         [OperationContract]
         List<TestFee> GetTestUnedrPanel(string PanelId);
         [OperationContract]
         int VerifySpecHolder(string spchold);
        [OperationContract]
        short SaveSpecHolder(SpecimenHolder spchld);
        [OperationContract]
        short UpdateSpcHolder(SpecimenHolder usphl);
        [OperationContract]
        LoadPatient GetCurrentPatientByPhone(string PhoneNo);
        [OperationContract(Name = "GetDmrTestForSpcList")]
        List<TestFee> GetDmrTest(string mrno, string Dept, string reportGrp);
        [OperationContract]
        InPatient GetPatientDetails(string presID, string mode);
        [OperationContract]
        List<MoneyReceiptRO> GetTotalCollection(string StartDate, string EndDate);
        [OperationContract]
        List<TestSub> GetSpcTestDetail();
        [OperationContract]
        List<ResultHead> GetResultHdReff();
        [OperationContract]
        short SaveMachineSetup(Machine mac);
        [OperationContract]
        short UpdateMachineSetup(Machine mac);
        [OperationContract]
        List<Machine> GetMachineSetup();
        [OperationContract]
        Dictionary<string, string> GetMacSetup(string type);
        [OperationContract]
        short SaveQualitativeGrpSetup(Qualitative oQual);
        [OperationContract]
        short UpdateQualitativeGrpSetup(Qualitative oQual);
        [OperationContract]
        List<Qualitative> GetQualitativeGrpSetup();
        [OperationContract]
        Dictionary<string, string> GetQualitativeGrp(string type);
        [OperationContract]
        short SaveQualitativeGrpDetailsSetup(QualitativeDetail oQual);
        [OperationContract]
        short UpdateQualitativeGrpDetailsSetup(QualitativeDetail oQual);
        [OperationContract]
        List<QualitativeDetail> GetQualitativeGrpDetails();
        [OperationContract]
        List<QualitativeDetail> GetQtGrpDetails(string Group);
        [OperationContract]
        short SaveMethodSetup(TestMethod mac);
        [OperationContract]
        short UpdateMethodSetup(TestMethod mac);
        [OperationContract]
        List<TestMethod> GetMethodSetup();
        [OperationContract]
        Dictionary<string, string> GetMethod(string type);
        [OperationContract]
        short SaveColorCodeSetup(ColorCode oColor);
        [OperationContract]
        short UpdateColorCodeSetup(ColorCode oColor);
        [OperationContract]
        List<ColorCode> GetColorCodeSetup();
        [OperationContract]
        Dictionary<string, string> GetColorCode(string type);
        [OperationContract(Name = "GetAllTestFee")]
        List<TestFee> GetTestFeeGrp();
        [OperationContract]
        List<TestFee> GetAllMappingTest(string Mode, string FeeCatagory);
        [OperationContract]
        List<TestFee> GetTestFeeGrpid(string group, string detailid);
        [OperationContract]
        List<MoneyReceiptRO> GetUserWiseCollection(string EmpId, string StartDate, string EndDate);
        [OperationContract]
        InPatient GetAdmittedPatient(string RegistrationNo);
        [OperationContract]
        List<NursingTestOrder> GetNursingStation();
        [OperationContract]
        List<NursingTestOrder> GetNursingStationRegNum(string ReqNo);
        [OperationContract]
        List<TestFee> GetIPDTests(string RegNo, string DrNo);
        [OperationContract]
        short SaveReportSection(ReportSection repgr);
        [OperationContract]
        short UpdateReportSection(ReportSection repgr);
        [OperationContract]
        List<ReportSection> GetReportSection();
        [OperationContract]
        Dictionary<string, string> GetRptSecDic(string type);
        [OperationContract]
        List<ReportSection> GetReportSectionSetup(string dept);
        [OperationContract]
        Dictionary<string, string> GetRptSecSetup(string dept);
        [OperationContract]
        List<ReportGroup> GetRptgrpDet(string dept, string sec);
        [OperationContract]
        Dictionary<string, string> GetGrpByDeptSecDic(string dept, string sec);
        [OperationContract]
        List<ReportGroup> GetRptgrpBySec(string sec);
        [OperationContract]
        Dictionary<string, string> GetRptgrpDic(string sec);
        [OperationContract]
        List<ResultHeadRO> GetResultHdFReport(string Section, string Group);
        [OperationContract]
        short SaveResultHeadMapping(ResultHead reshd);
        [OperationContract]
        short UpdateResultHeadMapping(ResultHead reshd);
        [OperationContract]
        List<ResultHead> GetResultHdMap(string TestDetails);
        [OperationContract]
        List<ResultHead> GetResultHdForMap(string TestDetails, string ReportGroup);
        [OperationContract]
        List<ResultHead> GetRprGrpByTest(string TestDetails);
        [OperationContract]
        List<ResultHead> GetHdByGrp(string ReportGrp);
        [OperationContract]
        List<AccountsPayment> GetAccountsPayment(string CollectionDate, string UserID);
        [OperationContract]
        string SaveAccountsPayment(AccountsPayment oAccounts);
        [OperationContract]
        List<AccountsPayment> GetIntegretedVoucher(string UserID, string StartDate, string EndDate);
        [OperationContract]
        DiagnosticMR GetAdvance(string mrno);
        [OperationContract]
        string SaveDiagnosticRefundMR(DiagnosticMR mr);
        [OperationContract]
        short SaveRefundCause(RefundCause oRefundCause);
        [OperationContract]
        short UpdateRefundCause(RefundCause oRefundCause);
        [OperationContract]
        List<RefundCause> GetRefundCause();
        [OperationContract]
        Dictionary<string, string> GetRefundCauseDic(string type);
        [OperationContract]
        List<TestSetupRO> GetReportPanelTest();
        [OperationContract]
        List<MoneyReceiptRO> GetAllRefundMR(string EmpId, string StartDate, string EndDate);
        [OperationContract]
        List<MoneyReceiptRO> GetAllCancelMR(string EmpId, string StartDate, string EndDate);
        [OperationContract]
        short SaveLabelTestAssociation(TestSub oTestSub);
        [OperationContract]
        List<TestSub> GetTestLabel(string TestDetID);
        [OperationContract]
        List<TestSub> GetTestDets(string deptid, string group, string main);
        [OperationContract]
        Dictionary<string, string> GetTestDetsDict(string type, string deptid, string group, string main);
        [OperationContract(Name = "GetTestNameDetails")]
        List<TestSub> GetTestName(string deptid, string group, string main, string ReportSection, string ReportGroup);
        [OperationContract]
        short SaveReffdOrg(RefdOrg oReff);
        [OperationContract]
        short UpdateReffdOrg(RefdOrg oReff);
        [OperationContract]
        List<RefdOrg> GetReffdOrg();
        [OperationContract]
        Dictionary<string, string> GetReffdOrgDic(string type);
        [OperationContract]
        short SaveReffdDoc(RefdDoc oReff);
        [OperationContract]
        short UpdateReffdDoc(RefdDoc oReff);
        [OperationContract]
        List<RefdDoc> GetReffdDoc(string OrgID);
        [OperationContract]
        Dictionary<string, string> GetReffdDocDic(string OrgID);
        [OperationContract]
        List<MoneyReceiptRO> GetDoctorWiseCollection(string TicketType, string StartDate, string EndDate);
        [OperationContract]
        List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate);
        [OperationContract]
        List<TestSetupRO> GetAllPanelTest();
        [OperationContract]
        List<ResultHeadRO> GetReportResultHd(string TestDetails);
        [OperationContract]
        List<DiagnosticMR> GetReffDoctor(string mrno);
        [OperationContract]
        short UpdateReffDoctor(DiagnosticMR mr);
        [OperationContract]
        List<DiagnosticMR> GetDueByHCN(string HCN);       
        [OperationContract]
        List<MoneyReceiptRO> GetAllTestByHCN(string HCN, string StartDate, string EndDate);
        [OperationContract]
        short SaveDiagPackageMaster(DiagPackage oDiagPackage);
        [OperationContract]
        short UpdateDiagPackageMaster(DiagPackage oDiagPackage);
        [OperationContract]
        List<DiagPackage> GetDiagPackageMaster();
        [OperationContract]
        List<TestFee> GetDiagPackageList();
        [OperationContract]
        Dictionary<string, string> GetDiagPackageDict(string type);
        [OperationContract]
        List<DiagPackage> GetDiagPackageAmount(string Package);
        [OperationContract]
        List<TestFee> GetAllTestForPackage();
        [OperationContract]
        short SaveDiagnosticTestFeePkg(TestFee tfee);
        [OperationContract]
        List<TestFee> GetTestFeePkg(string Package);
        [OperationContract]
        List<TestFee> GetAllPackageTest(string PackageID);
        [OperationContract]
        List<TestFee> GetAllMappingTestLike(string FeeCatagory, string TestDetails);
        [OperationContract]
        List<MoneyReceiptRO> GetUserWiseCashCollection(string StartDate, string EndDate);
        [OperationContract]
        List<MoneyReceiptRO> GetAllCollectionSummary(string StartDate, string EndDate);
        [OperationContract]
        List<MoneyReceiptRO> GetTestMainWiseTestDetails(string StartDate, string EndDate);
        [OperationContract]
        List<TestSub> GetTestForDetailsSetup(string Mode, string deptid, string group, string main);
        [OperationContract]
        short SaveEmrCollHead(EmrCollHead oEmrCollHead);
        [OperationContract]
        short UpdateEmrCollHead(EmrCollHead oEmrCollHead);
        [OperationContract]
        List<EmrCollHead> GetEmrCollHead(string Mode, string DeptGroup, string Dept, string Unit);
        [OperationContract]
        Dictionary<string, string> GetDeptGroupDicByType(string type);
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);
        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid);
        [OperationContract]
        string SaveEmergencyCollection(EmergencyCollectionMR mr);
        [OperationContract]
        List<EmergencyCollectionRO> GetEmergencyMoneyReceiptReport(string moneyReceiptNo);
        [OperationContract]
        string SaveEmergencyMaster(EmergencyMaster mr);
        [OperationContract]
        List<EmergencyMasterRO> GetEmergencyPrescription(string moneyReceiptNo);
        [OperationContract]
        List<EmergencyMasterRO> GetPatByEmerPres(string Prescription);
        [OperationContract]
        List<EmergencyMasterRO> GetEmerDiagBill(string Prescription);
        [OperationContract]
        Dictionary<string, string> GetIPDDoctorsDict(string deptID, string UnitID);
        [OperationContract]
        List<EmergencyMaster> GetPatientByEmerPrescription(string Prescription);
        [OperationContract]
        List<EmergencyCollectionMR> GetEmerBillForPayment(string HCNNo);
        [OperationContract]
        string SaveEmergencyCollectionPayment(EmergencyCollectionMR mr);
        [OperationContract]
        List<EmergencyCollectionMR> GetEmerMRNo(string HCNNo);
        [OperationContract]
        List<EmergencyCollectionMR> GetEmerDetailsForIPD(string HCNNo);

    }
}
