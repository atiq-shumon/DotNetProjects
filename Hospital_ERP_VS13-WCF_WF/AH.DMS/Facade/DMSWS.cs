using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.DTMS.MODEL;
using AH.PatReg.MODEL;
using AH.IPDShared.MODEL;
using AH.PatReg.BLL;
using AH.DUtility;
using AH.OPD.MODEL;
using AH.DMS.MODEL;
using AH.Shared.MODEL;
using AH.OPD.BLL;
using AH.DMS.BLL;
using AH.PRMS.BLL;
using AH.DTMS.BLL;
using AH.IPDShared.BLL;
using AH.HR.BLL;
using AH.ORGMS.BLL;


namespace AH.DMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DMSWS" in both code and config file together.
    public class DMSWS : IDMSWS
    {
        public Dictionary<string, string> GetPrescriptionTypes()
        {
            return new OPDBLL().GetPrescriptionTypes();
        }
        public Dictionary<string, string> GetDepartments(string type)
        {
            return new DiagnosticMRBLL().GetDepartments(type);
            
        }
        public Dictionary<string, string> GetDeptGroup(string type)
        {
            return new DiagnosticMRBLL().GetDeptGroup(type);
        }
        public List<MoneyReceiptRO> GetRefundMoneyReceiptReport(string moneyReceiptNo)
        {
            return new DMSReportBLL().GetRefundMoneyReceiptReport(moneyReceiptNo);
        }
        public Dictionary<string, string> GetDepartmentGroupWise(string deptgr)
        {
            return new DiagnosticMRBLL().GetDepartmentGroupWise(deptgr);
        }

        public Dictionary<string, string> GetTestGroups(string type)
        {
            return new DiagnosticSetupBLL().GetDiagnGrp(type);
        }
        public List<TestGroup> GetDiagnGrpTest(string department)
        {
            return new DiagnosticSetupBLL().GetDiagnGrpTest(department);
        }
        public Dictionary<string, string> GetDiagnGrp(string type, string department)
        {
            return new DiagnosticSetupBLL().GetDiagnGrp(type, department);
        }
        public List<TestFee> GetTestFee()
        {
            return new DiagnosticSetupBLL().GetTestFee();
        }
        public List<TestFee> GetTestFee(string dept, string group, string main, string feeCategory)
        {
            return new DiagnosticSetupBLL().GetTestFee(dept, group, main, feeCategory);
        }
        public int VerifyTestFee(string detail)
        {
            return new DiagnosticSetupBLL().VerifyTestFee(detail);
        }
        public string VarifyTicketNo(string tktno,bool isPescribed)
        {
            return new OPDBLL().VerifyTicketNo(tktno, isPescribed);
        }
        public Patient GetPatient(string pId, string mode)
        {
            return new PatientRegistrationBLL().GetPatient(pId);
        }
        public List<Patient> GetPatientByPhone(string name, string cell)
        {
            return new PatientRegistrationBLL().GetPatientDetails(name, cell);
        }

        public Ticket GetTicket(string tktNo)
        {
            return new OPDBLL().GetTicket(tktNo);
        }

        public InPatient GetPatientDetails(string presID, string mode)
        {
            return new DiagnosticMRBLL().GetPatientDetails(presID);
        }
        public string SaveDiagnosticMR(DiagnosticMR mr)
        {
            return new DiagnosticMRBLL().SaveDiagnosticMR(mr);
        }
        public int VerifyTestGroup(string groupId)
        {
            return new DiagnosticSetupBLL().VerifyTestGroup(groupId);
        }
        public short SaveTestGroup(TestGroup tg)
        {
            return new DiagnosticSetupBLL().SaveTestGroup(tg);
        }
        public short UpdateGroup(TestGroup upd)
        {
            return new DiagnosticSetupBLL().UpdateGroup(upd);
        }
        public int VerifyTestMain(string mainid)
        {
            return new DiagnosticSetupBLL().VerifyTestMain(mainid);
        }
        public short SaveTestMain(TestMain tm)
        {
            return new DiagnosticSetupBLL().SaveTestMain(tm);
        }
        public short UpdateTestMain(TestMain tmain)
        {
            return new DiagnosticSetupBLL().UpdateTestMain(tmain);
        }
        public short SaveTestPanel(GroupPanel tp)
        {
            return new DiagnosticSetupBLL().SaveTestPanel(tp);
        }
        public short UpdateTestPanel(GroupPanel tspanel)
        {
            return new DiagnosticSetupBLL().UpdateTestPanel(tspanel);
        }
        public short SaveTestDetail(TestSub tsp)
        {
            return new DiagnosticSetupBLL().SaveTestDetail(tsp);
        }
        public short UpdateTestDetail(TestSub tdtail)
        {
            return new DiagnosticSetupBLL().UpdateTestDetail(tdtail);
        }
        public short SaveTestFee(TestFee tf)
        {
            return new DiagnosticSetupBLL().SaveTestFee(tf);
        }
        public short UpdateTestFee(TestFee tfee)
        {
            return new DiagnosticSetupBLL().UpdateTestFee(tfee);
        }
        public short UpdateDiagnosticTestFee(TestFee tfee)
        {
            return new DiagnosticSetupBLL().UpdateDiagnosticTestFee(tfee);
        }
        public int VerifyTestDetail(string detailid)
        {
            return new DiagnosticSetupBLL().VerifyTestDetail(detailid);
        }
        public List<TestGroup> GetDiagnGrp()
        {
            return new DiagnosticSetupBLL().GetDiagnGrp();
        }
        public Dictionary<string, string> GetDiagnGrp(string type)
        {
            return new DiagnosticSetupBLL().GetDiagnGrp(type);
        }
        public List<TestMain> GetTestMain()
        {
            return new DiagnosticSetupBLL().GetTestMain();
        }
        public Dictionary<string, string> GetTestMain(string type)
        {
            return new DiagnosticSetupBLL().GetTestMain(type);
        }
        public List<TestMain> GetTestMain(string department, string group)
        {
            return new DiagnosticSetupBLL().GetTestMain(department, group);
        }
        public Dictionary<string, string> GetTestMain(string type, string department, string group)
        {
            return new DiagnosticSetupBLL().GetTestMain(type, department, group);
        }
        public Dictionary<string, string> GetTestDetsDict(string type, string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDetsDict(type, deptid, group, main);
        }
        public List<TestSub> GetTestForDetailsSetup(string Mode, string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestForDetailsSetup(Mode, deptid, group, main);
        }
        public List<GroupPanel> GetPanelSetup()
        {
            return new DiagnosticSetupBLL().GetPanelSetup();
        }
        public Dictionary<string, string> GetPanelSetup(string type)
        {
            return new DiagnosticSetupBLL().GetPanelSetup(type);
        }
        public List<TestSub> GetTestDetail()
        {
            return new DiagnosticSetupBLL().GetTestDetail();
        }
        public int VerifyTestCat(string catid)
        {
            return new DiagnosticSetupBLL().VerifyTestCat(catid);
        }
        public short SaveCategory(TestCategory testCat)
        {
            return new DiagnosticSetupBLL().SaveCategory(testCat);
        }
        public short UpdateCategory(TestCategory tcat)
        {
            return new DiagnosticSetupBLL().UpdateCategory(tcat);
        }
        public List<TestCategory> GetCategories()
        {
            return new DiagnosticSetupBLL().GetCategories();
        }
        public Dictionary<string, string> GetCategories(string type)
        {
            return new DiagnosticSetupBLL().GetCategories(type);
        }
        public Dictionary<string, string> GetTestDetail(string type)
        {
            return new DiagnosticSetupBLL().GetTestDetail(type);
        }
        public Dictionary<string, string> GetSpec(string type)
        {
            return new DRSetupBLL().GetSpec(type);
        }
        public List<TestSub> GetTestDetails(string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDetails(deptid, group, main);
        }
        public Dictionary<string, string> GetTestDetailsDict(string deptid,string group,string main)
        {
            return new DiagnosticSetupBLL().GetTestDetailsDict(deptid, group, main);
        }
        public List<TestSub> GetUnassignTest(string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetUnassignTest(deptid, group, main);
        }
        public List<TestSub> GetTestDets(string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDets(deptid, group, main);
        }
        public Dictionary<string, string> GetTestDetails(string type, string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDetails(type, deptid, group, main);
        }
        public int VerifyFeeCategory(string feecat)
        {
            return new DiagnosticSetupBLL().VerifyFeeCategory(feecat);
        }
        public short SaveFeeCategory(FeeCategory fcat)
        {
            return new DiagnosticSetupBLL().SaveFeeCategory(fcat);
        }
        public short UpdateFeeCategory(FeeCategory fecat)
        {
            return new DiagnosticSetupBLL().UpdateFeeCategory(fecat);
        }
        public List<FeeCategory> GetFeecats()
        {
            return new DiagnosticSetupBLL().GetFeeCats();
        }
        public Dictionary<string, string> GetFeecats(string type)
        {
            return new DiagnosticSetupBLL().GetFeecats(type);
        }
        public Dictionary<string, string> GetRooms(string type)
        {
            return new PropertySetupBLL().GetRooms(type);
        }
        public Dictionary<string, short> GetRoomSet(string type)
        {
            return new PropertySetupBLL().GetRoomSet(type);
        }
        public string VerifyInPatient(string regNo)
        {
            return new DiagnosticMRBLL().VerifyInPatient(regNo);
        }

        public InPatient GetAdmittedPatient(string RegistrationNo)
        {
            return new DiagnosticMRBLL().GetAdmittedPatient(RegistrationNo);
        }
        public List<TestFee> GetTestFeeGrp(string group, string detail)
        {
            return new DiagnosticSetupBLL().GetTestFeeGrp(group, detail);
        }
        public List<short> GetNumbers(short min, short max)
        {
            return Utility.GetNumbers(min, max);
        }
        public List<TestFee> GetPrescriptionTests(string ticketno, string feecat,string status)
        {
            return new OPDBLL().GetPrescriptionTests(ticketno, feecat,status);
        }
        public string VerifyPatientNo(string patNo)
        {
           return new PatientRegistrationBLL().VerifyPatientNo(patNo);
        }
        public short SaveDiagnosticMRDraft(DiagnosticMR mr)
        {
            return new DiagnosticMRBLL().SaveDiagnosticMRDraft(mr);
        }
        public List<DiagnosticMR> GetDraftList(string entryby)
        {
            return new DiagnosticMRBLL().GetDraftList(entryby);
        }
        public List<MoneyReceiptRO> GetMoneyReceiptReport(string MoneyReceiptNo)
        {
            return new DMSReportBLL().GetMoneyReceiptReport(MoneyReceiptNo);
        }
        public List<TestSetupRO> GetTestDetailsReport(string DeptID, string GroupID, string MainID)
        {
            return new DMSReportBLL().GetTestDetailsReport(DeptID, GroupID, MainID);
        }
        public List<TestSetupRO> GetDetailsTest(string DeptID)
        {
            return new DMSReportBLL().GetDetailsTest(DeptID);
        }
        public List<ResultHead> GetResultHdBySecGrp(string sec, string grp)
        {
            return new DRSetupBLL().GetResultHdBySecGrp(sec, grp);
        }
        public List<ResultHeadRO> GetResultHeadReport(string sec, string grp)
        {
            return new DRSetupBLL().GetResultHeadReport(sec, grp);
        }
        //Reports
        public List<ResultHead> GetResultHd()
        {
            return new DRSetupBLL().GetResultHd();
        }
        public int VerifyReportGroup(string groupid)
        {
            return new DRSetupBLL().VerifyReportGroup(groupid);
        }
        public short SaveReportGr(ReportGroup reptgrp)
        {
            return new DRSetupBLL().SaveReportGr(reptgrp);
        }
        public short UpdateReportGr(ReportGroup urepgr)
        {
            return new DRSetupBLL().UpdateReportGr(urepgr);
        }
        public int VerifyResHdGrp(string hdgrpid)
        {
            return new DRSetupBLL().VerifyResHdGrp(hdgrpid);
        }
        public short SaveReshdGr(ResultHeadGroup rshdgr)
        {
            return new DRSetupBLL().SaveReshdGr(rshdgr);
        }
        public short UpdateReshdGr(ResultHeadGroup ureshdgr)
        {
            return new DRSetupBLL().UpdateReshdGr(ureshdgr);
        }
        public int VerifyResUnit(string runit)
        {
            return new DRSetupBLL().VerifyResUnit(runit);
        }
        public short SaveRshdUnit(ResultHeadUnit rshdunit)
        {
            return new DRSetupBLL().SaveRshdUnit(rshdunit);
        }
        public short UpdateResUnit(ResultHeadUnit ursunit)
        {
            return new DRSetupBLL().UpdateResUnit(ursunit);
        }

        public int VerifyResHd(string headId)
        {
            return new DRSetupBLL().VerifyResHd(headId);
        }
        public short SaveReshd(ResultHead rshd)
        {
            return new DRSetupBLL().SaveReshd(rshd);
        }
        public short UpdateReshd(ResultHead ureshd)
        {
            return new DRSetupBLL().UpdateReshd(ureshd);
        }

        public List<ResultHeadGroup> GetResHdGrp()
        {
            return new DRSetupBLL().GetResHdGrp();
        }
        public List<ResultHeadGroup> GetResultHeaddGrp(string Dept, string Sec)
        {
            return new DRSetupBLL().GetResultHeaddGrp(Dept, Sec);
        }
        public Dictionary<string, string> GetGrpByDeptSecDic(string dept, string sec)
        {
            return new DRSetupBLL().GetGrpByDeptSecDic(dept, sec);
        }
        public Dictionary<string, string> GetResHdGrp(string type)
        {
            return new DRSetupBLL().GetResHdGrp(type);
        }
        public List<ResultHeadUnit> GetResUnit()
        {
            return new DRSetupBLL().GetResUnit();
        }
        public Dictionary<string, string> GetResUnit(string type)
        {
            return new DRSetupBLL().GetResUnit(type);
        }
        public int VerifySpecSetup(string spcid)
        {
            return new DRSetupBLL().VerifySpecSetup(spcid);
        }
       public short SaveSpecsetup(Specimen spec)
       {
           return new DRSetupBLL().SaveSpecsetup(spec);
       }
       public short UpdateSpecimen(Specimen uspc)
       {
           return new DRSetupBLL().UpdateSpecimen(uspc);
       }
       public List<Specimen> GetSpec()
        {
            return new DRSetupBLL().GetSpec();
        }

       public List<ReportGroup> GetRptgrp()
       {
           return new DRSetupBLL().GetRptgrp();
       }
       public Dictionary<string, string> GetRptgrp(string type)
       {
           return new DRSetupBLL().GetRptgrp(type);
       }
       public List<ReportGroup> GetRptgrpSetup(string dept)
       {
           return new DRSetupBLL().GetRptgrpSetup(dept);
       }
       public Dictionary<string, string> GetRptgrpSetup(string type, string dept)
       {
           return new DRSetupBLL().GetRptgrpSetup(type, dept);
       }
       public List<TestFee> GetDmrTest(string mrno)
       {
           return new DiagnosticMRBLL().GetDmrTest(mrno);
       }

       public string verifyMrno(string mrno)
       {
           return new DiagnosticMRBLL().verifyMrno(mrno);
       }

       public InPatient GetCurrentPatient(string mrno)
       {
           return new DiagnosticMRBLL().GetCurrentPatient(mrno);
       }

       public string SaveTestCancel(DiagnosticMR mr)
       {
           return new TestCancelBLL().SaveTestCancel(mr);
       }
       public List<TestFee> GetDmrTestForCancel(string mrno)
       {
           return new DiagnosticMRBLL().GetDmrTestForCancel(mrno);
       }
       public List<TestFee> GetTotalTestFee(string mrno)
       {
           return new DiagnosticMRBLL().GetTotalTestFee(mrno);
       }
       public List<TestFee> GetDmrTestForRefund(string mrno)
       {
           return new DiagnosticMRBLL().GetDmrTestForRefund(mrno);
       }
       public short SaveTestCancelCause(TestCancelCause oCanCause)
       {
           return new TestCancelBLL().SaveTestCancelCause(oCanCause);
       }

       public List<TestCancelCause> GetCancelCause()
       {
           return new TestCancelBLL().GetCancelCause();
       }
       public short UpdateCancelCause(TestCancelCause oCanCause)
       {
           return new TestCancelBLL().UpdateCancelCause(oCanCause);
       }
       public Dictionary<string, string> GetCancelCauseDic(string type)
       {
           return new TestCancelBLL().GetCancelCauseDic(type);
       }

       public DiagnosticMR GetDmrCollMaster(string mrno)
       {
           return new DiagnosticMRBLL().GetDmrCollMaster(mrno);
       }
       public string SaveDuePayment(DuePayment oDuePay)
       {
           return new DiagnosticMRBLL().SaveDuePayment(oDuePay);
       }
       public List<MoneyReceiptRO> GetDuePayment(string MrNo)
       {
           return new DMSReportBLL().GetDuePayment(MrNo);
       }
       public List<MoneyReceiptRO> GetPatientDueList(string StartDate, string EndDate)
       {
           return new DMSReportBLL().GetPatientDueList(StartDate, EndDate);
       }
       public List<MoneyReceiptRO> GetUserWiseCollection(string EmpId, string StartDate, string EndDate)
       {
           return new DMSReportBLL().GetUserWiseCollection(EmpId, StartDate, EndDate);
       }
       public short InsertPanelTests(TestSub oTestDetails)
       //public List<TestSub> InsertPanelTests(TestSub oTestDetails)
       {
           return new DiagnosticSetupBLL().InsertPanelTests(oTestDetails);
       }
       //public short UpdatePanelTests(TestSub oTestDetails)
       //{
       //    return new DiagnosticSetupBLL().UpdatePanelTests(oTestDetails);
       //}
       public List<TestFee> GetPanelTests(string PanelId)
       {
           return new DiagnosticSetupBLL().GetPanelTests(PanelId);
       }
       public List<TestFee> GetPanelTest(string PanelId)
       {
           return new DiagnosticSetupBLL().GetPanelTest(PanelId);
       }
       public List<TestFee> GetTestDet(string group, string detail)
       {
           return new DiagnosticSetupBLL().GetTestDet(group, detail);
       }
       public List<SpecimenHolder> GetSpecHolder()
       {
           return new DRSetupBLL().GetSpecHolder();
       }
       public List<SpecimenHolder> GetSpecimenHolder(string ColorCode)
       {
           return new DRSetupBLL().GetSpecimenHolder(ColorCode);
       }
        public Dictionary<string, string> GetSpecHolder(string type)
       {
           return new DRSetupBLL().GetSpecHolder(type);
       }
        public List<TestFee> GetTestUnedrPanel(string PanelId)
        {
            return new DiagnosticSetupBLL().GetTestUnedrPanel(PanelId);
        }
        public int VerifySpecHolder(string spchold)
        {
            return new DRSetupBLL().VerifySpecHolder(spchold);
        }
        public short SaveSpecHolder(SpecimenHolder spchld)
        {
            return new DRSetupBLL().SaveSpecHolder(spchld);
        }
        public short UpdateSpcHolder(SpecimenHolder usphl)
        {
            return new DRSetupBLL().UpdateSpcHolder(usphl);
        }
        public LoadPatient GetCurrentPatientByPhone(string PhoneNo)
        {
            return new DiagnosticMRBLL().GetCurrentPatientByPhone(PhoneNo);
        }
        public List<TestFee> GetDmrTest(string mrno, string Dept, string reportGrp)
        {
            return new DiagnosticMRBLL().GetDmrTest(mrno, Dept, reportGrp);
        }
        public List<MoneyReceiptRO> GetTotalCollection(string StartDate, string EndDate)
        {
            return new DMSReportBLL().GetTotalCollection(StartDate, EndDate);
        }
        public List<TestSub> GetSpcTestDetail()
        {
            return new DiagnosticSetupBLL().GetSpcTestDetail();
        }
        public List<ResultHead> GetResultHdReff()
        {
            return new DRSetupBLL().GetResultHdReff();
        }
        public short SaveMachineSetup(Machine mac)
        {
            return new DRSetupBLL().SaveMachineSetup(mac);
        }
        public short UpdateMachineSetup(Machine mac)
        {
            return new DRSetupBLL().UpdateMachineSetup(mac);
        }
        public List<Machine> GetMachineSetup()
        {
            return new DRSetupBLL().GetMachineSetup();
        }
        public Dictionary<string, string> GetMacSetup(string type)
        {
            return new DRSetupBLL().GetMacSetup(type);
        }
        public short SaveQualitativeGrpSetup(Qualitative oQual)
        {
            return new DRSetupBLL().SaveQualitativeGrpSetup(oQual);
        }
        public short UpdateQualitativeGrpSetup(Qualitative oQual)
        {
            return new DRSetupBLL().UpdateQualitativeGrpSetup(oQual);
        }
        public List<Qualitative> GetQualitativeGrpSetup()
        {
            return new DRSetupBLL().GetQualitativeGrpSetup();
        }
        public Dictionary<string, string> GetQualitativeGrp(string type)
        {
            return new DRSetupBLL().GetQualitativeGrp(type);
        }
        public short SaveQualitativeGrpDetailsSetup(QualitativeDetail oQual)
        {
            return new DRSetupBLL().SaveQualitativeGrpDetailsSetup(oQual);
        }
        public short UpdateQualitativeGrpDetailsSetup(QualitativeDetail oQual)
        {
            return new DRSetupBLL().UpdateQualitativeGrpDetailsSetup(oQual);
        }
        public List<QualitativeDetail> GetQualitativeGrpDetails()
        {
            return new DRSetupBLL().GetQualitativeGrpDetails();
        }
        public List<QualitativeDetail> GetQtGrpDetails(string Group)
        {
            return new DRSetupBLL().GetQtGrpDetails(Group);
        }
        public short SaveMethodSetup(TestMethod mac)
        {
            return new DiagnosticSetupBLL().SaveMethodSetup(mac);
        }
        public short UpdateMethodSetup(TestMethod mac)
        {
            return new DiagnosticSetupBLL().UpdateMethodSetup(mac);
        }
        public List<TestMethod> GetMethodSetup()
        {
            return new DiagnosticSetupBLL().GetMethodSetup();
        }
         public Dictionary<string, string> GetMethod(string type)
        {
            return new DiagnosticSetupBLL().GetMethod(type);
        }
         public short SaveColorCodeSetup(ColorCode oColor)
         {
             return new DRSetupBLL().SaveColorCodeSetup(oColor);
         }
         public short UpdateColorCodeSetup(ColorCode oColor)
         {
             return new DRSetupBLL().UpdateColorCodeSetup(oColor);
         }
         public List<ColorCode> GetColorCodeSetup()
         {
             return new DRSetupBLL().GetColorCodeSetup();
         }
         public Dictionary<string, string> GetColorCode(string type)
         {
             return new DRSetupBLL().GetColorCode(type);
         }
         public List<TestFee> GetTestFeeGrp()
         {
             return new DiagnosticSetupBLL().GetTestFeeGrp();
         }
         public List<TestFee> GetAllMappingTest(string Mode, string FeeCatagory)
         {
             return new DiagnosticSetupBLL().GetAllMappingTest(Mode,FeeCatagory);
         }
         public List<TestFee> GetTestFeeGrpid(string group, string detailid)
         {
             return new DiagnosticSetupBLL().GetTestFeeGrpid(group, detailid);
         }
         public List<NursingTestOrder> GetNursingStation()
         {
             return new DiagnosticMRBLL().GetNursingStation();
         }
         public List<NursingTestOrder> GetNursingStationRegNum(string ReqNo)
         {
             return new DiagnosticMRBLL().GetNursingStationRegNum(ReqNo);
         }
         public List<TestFee> GetIPDTests(string RegNo, string DrNo)
         {
             return new DiagnosticMRBLL().GetIPDTests(RegNo, DrNo);
         }
         public short SaveReportSection(ReportSection repgr)
         {
             return new DRSetupBLL().SaveReportSection(repgr);
         }

         public short UpdateReportSection(ReportSection repgr)
         {
             return new DRSetupBLL().UpdateReportSection(repgr);
         }
         public List<ReportSection> GetReportSection()
         {
             return new DRSetupBLL().GetReportSection();
         }
        public Dictionary<string, string> GetRptSecDic(string type)
         {
             return new DRSetupBLL().GetRptSecDic(type);
         }
         public List<ReportSection> GetReportSectionSetup(string dept)
         {
             return new DRSetupBLL().GetReportSectionSetup(dept);
         }
        public Dictionary<string, string> GetRptSecSetup(string dept)
         {
             return new DRSetupBLL().GetRptSecSetup(dept);
         }
        public List<ReportGroup> GetRptgrpDet(string dept, string sec)
        {
            return new DRSetupBLL().GetRptgrpDet(dept, sec);
        }
         public List<ReportGroup> GetRptgrpBySec(string sec)
         {
           return new DRSetupBLL().GetRptgrpBySec(sec);
         }
         public Dictionary<string, string> GetRptgrpDic(string sec)
         {
             return new DRSetupBLL().GetRptgrpDic(sec);
         }
         public List<ResultHeadRO> GetResultHdFReport(string Section, string Group)
         {
             return new DRSetupBLL().GetResultHdFReport(Section, Group);
         }
         public short SaveResultHeadMapping(ResultHead reshd)
         {
             return new DRSetupBLL().SaveResultHeadMapping(reshd);
         }
         public short UpdateResultHeadMapping(ResultHead reshd)
         {
             return new DRSetupBLL().UpdateResultHeadMapping(reshd);
         }
         public List<ResultHead> GetResultHdMap(string TestDetails)
         {
             return new DRSetupBLL().GetResultHdMap(TestDetails);
         }
         public List<ResultHead> GetResultHdForMap(string TestDetails, string ReportGroup)
         {
             return new DRSetupBLL().GetResultHdForMap(TestDetails, ReportGroup);
         }
         public List<ResultHead> GetRprGrpByTest(string TestDetails)
         {
             return new DRSetupBLL().GetRprGrpByTest(TestDetails);
         }
         public List<ResultHead> GetHdByGrp(string ReportGrp)
         {
             return new DRSetupBLL().GetHdByGrp(ReportGrp);
         }
         public List<AccountsPayment> GetAccountsPayment(string CollectionDate, string UserID)
         {
             return new DiagnosticMRBLL().GetAccountsPayment(CollectionDate, UserID);
         }
         public string SaveAccountsPayment(AccountsPayment oAccounts)
         {
             return new DiagnosticMRBLL().SaveAccountsPayment(oAccounts);
         }
         public List<AccountsPayment> GetIntegretedVoucher(string UserID, string StartDate, string EndDate)
         {
             return new DMSReportBLL().GetIntegretedVoucher(UserID, StartDate, EndDate);
         }
         public DiagnosticMR GetAdvance(string mrno)
         {
             return new DiagnosticMRBLL().GetAdvance(mrno);
         }
         public string SaveDiagnosticRefundMR(DiagnosticMR mr)
         {
             return new DiagnosticMRBLL().SaveDiagnosticRefundMR(mr);
         }
         public short SaveRefundCause(RefundCause oRefundCause)
         {
             return new TestCancelBLL().SaveRefundCause(oRefundCause);
         }
         public short UpdateRefundCause(RefundCause oRefundCause)
         {
             return new TestCancelBLL().UpdateRefundCause(oRefundCause);
         }
         public List<RefundCause> GetRefundCause()
         {
             return new TestCancelBLL().GetRefundCause();
         }
         public Dictionary<string, string> GetRefundCauseDic(string type)
         {
             return new TestCancelBLL().GetRefundCauseDic(type);
         }
         public List<TestSetupRO> GetReportPanelTest()
         {
             return new DMSReportBLL().GetReportPanelTest();
         }
         public List<DiagnosticMR> GetReffDoctor(string mrno)
         {
             return new DiagnosticMRBLL().GetReffDoctor(mrno);
         }
         public List<MoneyReceiptRO> GetAllRefundMR(string EmpId, string StartDate, string EndDate)
         {
             return new DMSReportBLL().GetAllRefundMR(EmpId, StartDate, EndDate);
         }
         public List<MoneyReceiptRO> GetAllCancelMR(string EmpId, string StartDate, string EndDate)
         {
             return new DMSReportBLL().GetAllCancelMR(EmpId, StartDate, EndDate);
         }        
         public short SaveLabelTestAssociation(TestSub oTestSub)
         {
             return new DiagnosticMRBLL().SaveLabelTestAssociation(oTestSub);
         }
         public List<TestSub> GetTestLabel(string TestDetID)
         {
             return new DiagnosticMRBLL().GetTestLabel(TestDetID);
         }
         public List<TestSub> GetTestName(string deptid, string group, string main, string ReportSection, string ReportGroup)
         {
             return new DiagnosticSetupBLL().GetTestName(deptid, group, main, ReportSection, ReportGroup);
         }
         public short SaveReffdOrg(RefdOrg oReff)
         {
             return new OtherRefferrenceSetupBLL().SaveReffdOrg(oReff);
         }
         public short UpdateReffdOrg(RefdOrg oReff)
         {
             return new OtherRefferrenceSetupBLL().UpdateReffdOrg(oReff);
         }
         public List<RefdOrg> GetReffdOrg()
         {
             return new OtherRefferrenceSetupBLL().GetReffdOrg();
         }
         public Dictionary<string, string> GetReffdOrgDic(string type)
         {
             return new OtherRefferrenceSetupBLL().GetReffdOrgDic(type);
         }
         public short SaveReffdDoc(RefdDoc oReff)
         {
             return new OtherRefferrenceSetupBLL().SaveReffdDoc(oReff);
         }
         public short UpdateReffdDoc(RefdDoc oReff)
         {
             return new OtherRefferrenceSetupBLL().UpdateReffdDoc(oReff);
         }
         public List<RefdDoc> GetReffdDoc(string OrgID)
         {
             return new OtherRefferrenceSetupBLL().GetReffdDoc(OrgID);
         }
         public Dictionary<string, string> GetReffdDocDic(string OrgID)
         {
             return new OtherRefferrenceSetupBLL().GetReffdDocDic(OrgID);
         }
         public List<MoneyReceiptRO> GetDoctorWiseCollection(string TicketType, string StartDate, string EndDate)
         {
             return new DMSReportBLL().GetDoctorWiseCollection(TicketType, StartDate, EndDate);
         }
         public List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate)
         {
             return new DiagnosticMRBLL().GetCollectionSummary(StartDate, EndDate);
         }
         public List<TestSetupRO> GetAllPanelTest()
         {
             return new DMSReportBLL().GetAllPanelTest();
         }
         public List<ResultHeadRO> GetReportResultHd(string TestDetails)
         {
             return new DRSetupBLL().GetReportResultHd(TestDetails);
         }
         public short UpdateReffDoctor(DiagnosticMR mr)
         {
             return new DiagnosticMRBLL().UpdateReffDoctor(mr);
         }
         public List<DiagnosticMR> GetDueByHCN(string HCN)
         {
             return new DiagnosticMRBLL().GetDueByHCN(HCN);
         }
         public List<MoneyReceiptRO> GetAllTestByHCN(string HCN, string StartDate, string EndDate)
         {
             return new DMSReportBLL().GetAllTestByHCN(HCN, StartDate, EndDate);
         }
         public short SaveDiagPackageMaster(DiagPackage oDiagPackage)
         {
             return new DiagnosticSetupBLL().SaveDiagPackageMaster(oDiagPackage);
         }
         public short UpdateDiagPackageMaster(DiagPackage oDiagPackage)
         {
             return new DiagnosticSetupBLL().UpdateDiagPackageMaster(oDiagPackage);
         }
         public List<DiagPackage> GetDiagPackageMaster()
         {
             return new DiagnosticSetupBLL().GetDiagPackageMaster();
         }
         public List<TestFee> GetDiagPackageList()
         {
             return new DiagnosticSetupBLL().GetDiagPackageList();
         }
         public Dictionary<string, string> GetDiagPackageDict(string type)
         {
             return new DiagnosticSetupBLL().GetDiagPackageDict(type);
         }
         public List<DiagPackage> GetDiagPackageAmount(string Package)
         {
             return new DiagnosticSetupBLL().GetDiagPackageAmount(Package);
         }
         public List<TestFee> GetAllTestForPackage()
         {
             return new DiagnosticSetupBLL().GetAllTestForPackage();
         }
         public short SaveDiagnosticTestFeePkg(TestFee tfee)
         {
             return new DiagnosticSetupBLL().SaveDiagnosticTestFeePkg(tfee);
         }
         public List<TestFee> GetTestFeePkg(string Package)
         {
             return new DiagnosticSetupBLL().GetTestFeePkg(Package);
         }
         public List<TestFee> GetAllPackageTest(string PackageID)
         {
             return new DiagnosticSetupBLL().GetAllPackageTest(PackageID);
         }
         public List<TestFee> GetAllMappingTestLike(string FeeCatagory, string TestDetails)
         {
             return new DiagnosticSetupBLL().GetAllMappingTestLike(FeeCatagory, TestDetails);
         }
         public List<MoneyReceiptRO> GetUserWiseCashCollection(string StartDate, string EndDate)
         {
             return new DiagnosticMRBLL().GetUserWiseCashCollection(StartDate, EndDate);
         }
         public List<MoneyReceiptRO> GetAllCollectionSummary(string StartDate, string EndDate)
         {
             return new DiagnosticMRBLL().GetAllCollectionSummary(StartDate, EndDate);
         }
         public List<MoneyReceiptRO> GetTestMainWiseTestDetails(string StartDate, string EndDate)
         {
             return new DMSReportBLL().GetTestMainWiseTestDetails(StartDate, EndDate);
         }
         public short SaveEmrCollHead(EmrCollHead oEmrCollHead)
         {
             return new EmergencySetupBLL().SaveEmrCollHead(oEmrCollHead);
         }
         public short UpdateEmrCollHead(EmrCollHead oEmrCollHead)
         {
             return new EmergencySetupBLL().UpdateEmrCollHead(oEmrCollHead);
         }
         public List<EmrCollHead> GetEmrCollHead(string Mode, string DeptGroup, string Dept, string Unit)
         {
             return new EmergencySetupBLL().GetEmrCollHead(Mode, DeptGroup, Dept, Unit);
         }
         public Dictionary<string, string> GetDeptGroupDicByType(string type)
         {
             return new AdministrationSetupBLL().GetDeptGroupDicByType(type);
         }
         public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
         {
             return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
         }
         public Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid)
         {
             return new AdministrationSetupBLL().GetDeptUnitDic(DeptGrp, deptid);
         }
         public string SaveEmergencyCollection(EmergencyCollectionMR mr)
         {
             return new EmergencyCollectionBLL().SaveEmergencyCollection(mr);
         }
         public List<EmergencyCollectionRO> GetEmergencyMoneyReceiptReport(string moneyReceiptNo)
         {
             return new DMSReportBLL().GetEmergencyMoneyReceiptReport(moneyReceiptNo);
         }
         public string SaveEmergencyMaster(EmergencyMaster mr)
         {
             return new EmergencyCollectionBLL().SaveEmergencyMaster(mr);
         }
         public List<EmergencyMasterRO> GetEmergencyPrescription(string moneyReceiptNo)
         {
             return new DMSReportBLL().GetEmergencyPrescription(moneyReceiptNo);
         }
         public List<EmergencyMasterRO> GetPatByEmerPres(string Prescription)
         {
             return new DiagnosticMRBLL().GetPatByEmerPres(Prescription);
         }
         public List<EmergencyMasterRO> GetEmerDiagBill(string Prescription)
         {
             return new DiagnosticMRBLL().GetEmerDiagBill(Prescription);
         }
         public Dictionary<string, string> GetIPDDoctorsDict(string deptID, string UnitID)
         {
             return new IPDSharedBLL().GetIPDDoctorsDict(deptID, UnitID);
         }
         public List<EmergencyMaster> GetPatientByEmerPrescription(string Prescription)
         {
             return new EmergencyCollectionBLL().GetPatientByEmerPrescription(Prescription);
         }
         public List<EmergencyCollectionMR> GetEmerBillForPayment(string HCNNo)
         {
             return new EmergencyCollectionBLL().GetEmerBillForPayment(HCNNo);
         }
         public string SaveEmergencyCollectionPayment(EmergencyCollectionMR mr)
         {
             return new EmergencyCollectionBLL().SaveEmergencyCollectionPayment(mr);
         }
         public List<EmergencyCollectionMR> GetEmerMRNo(string HCNNo)
         {
             return new EmergencyCollectionBLL().GetEmerMRNo(HCNNo);
         }
         public List<EmergencyCollectionMR> GetEmerDetailsForIPD(string HCNNo)
         {
             return new EmergencyCollectionBLL().GetEmerDetailsForIPD(HCNNo);
         }

    }
}
