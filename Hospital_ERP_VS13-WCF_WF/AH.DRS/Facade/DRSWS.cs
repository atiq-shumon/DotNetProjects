using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.Shared.MODEL;
using AH.DRS.MODEL;
using AH.DTMS.MODEL;
using AH.PatReg.MODEL;
using AH.DRS.BLL;
using AH.HR.BLL;
using AH.PatReg.BLL;
using AH.PRMS.BLL;
using AH.DMS.BLL;
using AH.DTMS.BLL;
using AH.ORGMS.BLL;
using AH.DUtility;
using AH.IPDShared.MODEL;
using AH.DMS.MODEL;
using AH.HR.MODEL;


namespace AH.DRS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DRSWS" in both code and config file together.
    public class DRSWS : IDRSWS
    {

        public List<ResultHead> GetResultHeads(string groupID)
        {
           return new DRSetupBLL().GetResultHeads(groupID);
        }
        public string SaveSpecimenCollection(SpecimenCollection spcColl)
        {
            return new SpecimenCollectionBLL().SaveSpecimenCollection(spcColl);
        }
       
        public List<Specimen> GetSpec()
        {
            return new DRSetupBLL().GetSpec();
        }
        public Dictionary<string, string> GetSpec(string type)
        {
            return new DRSetupBLL().GetSpec(type);
        }       
        public Dictionary<string, string> GetDepartments(string type)
        {
            return new AdministrationSetupBLL().GetDepartments(type);
        }
        //public Dictionary<string, string> GetDepartmentsGroupWise(string type,string group)
        //{
        //    return new AdministrationSetupBLL().GetDepartmentsetup(type,group);
        //}
        public Dictionary<string, string> GetDepartmentsetupDic (string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }

        public Patient GetPatient(string pId)
        {
            return new PatientRegistrationBLL().GetPatient(pId);
        }
        public InPatient GetCurrentPatient(string mrno)
        {
            return new DiagnosticMRBLL().GetCurrentPatient(mrno);
        }
        public List<TestFee> GetReportTest(string mrno)
        {
            return new DiagnosticMRBLL().GetReportTest(mrno);
        }
        public Dictionary<string, string> GetRooms(string types)
        {
            return new PropertySetupBLL().GetRooms(types);
        }
        public string VerifyDiagnosticResult(DiagnosticReport dr)
        {
            return new DRSBLL().VerifyDiagnosticResult(dr);
        }
        public string SaveDiagnosticResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveDiagnosticResult(dr);
        }
        public SpecimenCollection GetSpecimenCollection(string spcId)
        {
            return new SpecimenCollectionBLL().GetSpecimenCollection(spcId);
        }
        public List<InvestigationReportRO> GetInvestigationReport(string transactionNo)
        {
            return new DRSReportBLL().GetInvestigationReport(transactionNo);
        }
        //==========Reffd DMS================//
        public Dictionary<string, string> GetRptgrpSetup(string type, string dept)
        {
            return new DRSetupBLL().GetRptgrpSetup(type, dept);
        }
        public Dictionary<string, string> GetRptSecSetup(string dept)
        {
            return new DRSetupBLL().GetRptSecSetup(dept)  ;
        }
         public Dictionary<string, string> GetRptgrpDic(string sec)
        {
            return new DRSetupBLL().GetRptgrpDic(sec)  ;
        }     
        public string verifyMrno(string mrno)
        {
            return new DiagnosticMRBLL().verifyMrno(mrno);
        }
        // Report
        public List<SpecimenRO> GetSpecimens(string SpecimenNo)
        {
            return new DRSReportBLL().GetSpecimens(SpecimenNo);
        }

        public List<InvestigationReportRO> GetMicroBioReport(string MRNo)
        {
            return new DRSReportBLL().GetMicroBioReport(MRNo);
        }
        public List<InvestigationReportRO> GetBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
        {
            return new DRSReportBLL().GetBulkReportPrint(rptSection, rptGroup, FromDate, ToDate);
        }
        public List<InvestigationReportRO> GetMicroBioResultA(string MRNo)
        {
            return new DRSReportBLL().GetMicroBioResultA(MRNo);
        }
        public List<InvestigationReportRO> GetMicroBioResultB(string MRNo)
        {
            return new DRSReportBLL().GetMicroBioResultB(MRNo);
        }
        public List<InvestigationReportRO> GetMicroBioResultC(string MRNo)
        {
            return new DRSReportBLL().GetMicroBioResultC(MRNo);
        }
        public string verifySpecimenNumbers(string spcno, string deptid, string reportid)
        {
            return new SpecimenCollectionBLL().verifySpecimenNumbers(spcno, deptid, reportid);

        }
        public string verifySpecimenNo(string spcno)
        {
            return new SpecimenCollectionBLL().verifySpecimenNo(spcno);
        }
        public List<TestFee> GetSpcCollectedTest(string specNo)
        {
            return new SpecimenCollectionBLL().GetSpcCollectedTest(specNo);
        }
        //Reff DiagnosticMRBLL//
        public List<TestFee> GetDmrTestForSpc(string mrno)
        {
            return new SpecimenCollectionBLL().GetDmrTestForSpc(mrno);
        }
        //
        public List<SpecimenCollection> GetReportListToVerify(string rptSection, string rptGroup)
        {
            return new DRSBLL().GetReportListToVerify(rptSection, rptGroup);
        }
        public List<SpecimenCollection> GetReportListToFinalised(string rptSection, string rptGroup)
        {
            return new DRSBLL().GetReportListToFinalised(rptSection, rptGroup);
        }
        public List<TestSub> GetSpcTestReportGroup(string spcNo,string reportGroup)
        {
            return new SpecimenCollectionBLL().GetSpcTestReportGroup( spcNo,reportGroup);
        }

        //===================25-10-2014========================================//
        public List<DiagnosticReport> GetResultToVerify(string mrID, string rptgr)
        {
            return new DRSBLL().GetResultToVerify(mrID, rptgr);
        }
        public List<DiagnosticReport> GetResultToFinalised(string mrID, string rptgr)
        {
            return new DRSBLL().GetResultToFinalised(mrID, rptgr);
        }


        public string UpdateDiagnosticResult(DiagnosticReport dr)
        {
            return new DRSBLL().UpdateDiagnosticResult(dr);
        }
        public DiagnosticReport GetSpecimenCollectionByResultID(string resultId, string test_detail_id)
        {
            return new SpecimenCollectionBLL().GetSpecimenCollectionByResultID(resultId, test_detail_id);
        }

        public List<NursingTree> GetNursStationWiseMoneyReceipt(string nsID)
        {
            return new DRSBLL().GetNursStationWiseMoneyReceipt(nsID);
        }
        public List<NursingTree> GetNurseStatonWiseMRNoForSampleReciv(string p_tkt_type)
        {
            return new DRSBLL().GetNurseStatonWiseMRNoForSampleReciv(p_tkt_type);
        }
        public short UpdateSpecimenReceivedBy(SpecimenCollection spcColl)
        {
            return new SpecimenCollectionBLL().UpdateSpecimenReceivedBy(spcColl);
        }
        public List<ResultHead> GetResHead(string mrID, string reportGroupID,string machineID)
        {
            return new DRSBLL().GetResHead(mrID, reportGroupID, machineID);
        }
        public List<SpecimenCollection> GetDiagnosticMoneyReceiptList()
        {
            return new SpecimenCollectionBLL().GetDiagnosticMoneyReceiptList();
        }
        public List<SpecimenCollection> GetSpecimenList(string deptID, string rpt_group_id)
        {
            return new SpecimenCollectionBLL().GetSpecimenList(deptID, rpt_group_id);
        }
        public List<SpecimenCollection> OPDPendingMoneyRecipt()
        {
            return new DRSBLL().OPDPendingMoneyRecipt();
        }
        public List<NursingTree> GetNursStationWiseMRNoForResult(string rptGroupId, string deptId, string p_tkt_type)
        {
            return new DRSBLL().GetNursStationWiseMRNoForResult(rptGroupId, deptId, p_tkt_type);
        }
        public List<SpecimenCollection> OPDPendingSpecimenListForResult(string rptGroupId, string deptId)
        {
            return new DRSBLL().OPDPendingSpecimenListForResult(rptGroupId, deptId);
        }
        //public string FinalisedDiagnosticResult(DiagnosticReport dr)
        //{
        //    return new DRSBLL().FinalisedDiagnosticResult(dr);
        //}
        public string SaveFinalDiagnosticResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveFinalDiagnosticResult(dr);
        }
        public List<TestSub> GetTestByMRID(string mrID, string reportGroup)
        {
            return new SpecimenCollectionBLL().GetTestByMRID(mrID, reportGroup);
        }
        public List<DiagnosticReport> GetLatestResultToVerify(string mrID, string rptgr)
        {
            return new DRSBLL().GetLatestResultToVerify(mrID, rptgr);
        }
        public string SaveVerifiedDiagnosticResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveVerifiedDiagnosticResult(dr);
        }
        public List<DiagnosticReport> GetUpdatedVerifiedResult(string mrID, string rptgr)
        {
            return new DRSBLL().GetUpdatedVerifiedResult(mrID, rptgr);
        }
        public List<DiagnosticReport> GetFinalisedResult(string mrID, string rptgr)
        {
            return new DRSBLL().GetFinalisedResult(mrID, rptgr);
        }  
        public List<NursingTree> GetNurseStationMrForVerified(string rptGroupId, string rptSection, string p_ns_id)
        {
            return new DRSBLL().GetNurseStationMrForVerified(rptGroupId, rptSection, p_ns_id);
        }
        public List<SpecimenCollection> GetOPDDMRToVerify(string rptSection, string rptGroup)
        {
            return new DRSBLL().GetOPDDMRToVerify(rptGroup, rptSection);
        }
        public List<SpecimenCollection> GetOPDDMRToFinalised(string rptSection, string rptGroup)
        {
            return new DRSBLL().GetOPDDMRToFinalised(rptGroup, rptSection);
        }
     
        public List<NursingTree> GetNurseStnWiseMrForFinalised(string rptGroupId, string rptSection, string p_ns_id)
        {
            return new DRSBLL().GetNurseStnWiseMrForFinalised(rptGroupId, rptSection, p_ns_id);
        }
        public string SaveStainResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveStainResult(dr);
        }
        public string SaveMicroBiologyResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveMicroBiologyResult(dr);
        }
        public DiagnosticReport GetNoGrowthResultToVerify(string mrID, string rptgr,string testDetailsID)
        {
            return new DRSBLL().GetNoGrowthResultToVerify(mrID, rptgr, testDetailsID);
        }
        public string SaveMicroBiologyVerifiedResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveMicroBiologyVerifiedResult(dr);
        }
        public List<DiagnosticMR> GetMicroBioRprtLstToVerify(string rptSection, string rptGroup)
        {
            return new DRSBLL().GetMicroBioRprtLstToVerify(rptSection, rptGroup);
        }
        public List<DiagnosticMR> GetMicroBioRprtLstToFinalised(string rptSection, string rptGroup)
        {
            return new DRSBLL().GetMicroBioRprtLstToFinalised(rptSection, rptGroup);
        }
        public DiagnosticReport GetNoGrowthResultToFinal(string mrID, string rptgr, string testDetails)
        {
            return new DRSBLL().GetNoGrowthResultToFinal(mrID, rptgr, testDetails);
        }
        public string SaveMicroBiologyFinaldResult(DiagnosticReport dr)
        {
            return new DRSBLL().SaveMicroBiologyFinaldResult(dr);
        }
        public List<SpecimenCollection> BulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
        {
            return new DRSBLL().BulkReportPrint(rptSection, rptGroup, FromDate, ToDate);
        }
        public string UpdatePrintFlag(DiagnosticReport dr)
        {
            return new DRSBLL().UpdatePrintFlag(dr);
        }
        public List<DiagnosticReport> GetMicroBioResultToVerify(string mrID, string rptgr,string testDetailsID)
        {
            return new DRSBLL().GetMicroBioResultToVerify(mrID, rptgr, testDetailsID);
        }
        public List<DiagnosticReport> GetMicroBioResultToFinalised(string mrID, string rptgr,string specimanID,string testDetails)
        {
            return new DRSBLL().GetMicroBioResultToFinalised(mrID, rptgr,specimanID,testDetails);
        }
        public List<SpecimenCollection> MBioOPDPendingSpcmenLstForRslt(string rptGroupId, string deptId)
        {
            return new DRSBLL().MBioOPDPendingSpcmenLstForRslt(rptGroupId, deptId);
        }
        public List<NursingTree> MBioIPDNursStationWiseSpecimenNoForResult(string rptGroupId, string deptId,string p_tkt_type)
        {
            return new DRSBLL().MBioIPDNursStationWiseSpecimenNoForResult(rptGroupId, deptId, p_tkt_type);
        }
        public List<NursingTree> MBioNSTNMrForVerified(string rptGroupId, string rptSection, string p_tkt_type)
        {
            return new DRSBLL().MBioNSTNMrForVerified(rptGroupId, rptSection, p_tkt_type);
        }
        public List<NursingTree> MBioNSTNMrForFinalised(string rptGroupId, string rptSection,string p_tkt_type)
        {
            return new DRSBLL().MBioNSTNMrForFinalised(rptGroupId, rptSection, p_tkt_type);
        }
        public string SaveUserReportAccess(UserReportAccess uerAccess)
        {
            return new DRSSetupBLL().SaveUserReportAccess(uerAccess);
        }
        //********************************HRMIS*********************************//
        public EmployeeMaster GetEmpoyee(string empID)
        {
            return new EmployeeSetUpBLL().GetEmpMaster(empID);
        }
        //**********************************************************************//
        public List<UserReportAccess> GetUserAccess(string deptID, string rptSecID)
        {
            return new DRSSetupBLL().GetUserAccess(deptID, rptSecID);
        }
        public List<DiagnosticMR> GetMrListToPrint()
        {
            return new DRSBLL().GetMrListToPrint();
        }
        public List<SpecimenCollection> GetAllReport(string moneyReciptID)
        {
            return new DRSBLL().GetAllReport(moneyReciptID);
        }
        public List<NursingTree> GetIPDMRList()
        {
            return new DRSBLL().GetIPDMRList();
        }
        public List<SpecimenCollection> GetAllReportsByMRID(string moneyReciptID)
        {
            return new DRSBLL().GetAllReportsByMRID(moneyReciptID);
        }
        public Dictionary<string, string> GetMacSetup(string type)
        {
            return new DRSetupBLL().GetMacSetup(type);
        }
        public List<ResultHead> GetResHeads(string mrID, string reportGroupID, string testDetailsID)
        {
            return new DRSBLL().GetResHeads(mrID, reportGroupID, testDetailsID);
        }
        public List<SpecimenCollection> STN_OPD_SPECIMEN_LIST_RSLT(string rptGroupId, string deptId)
        {
            return new DRSBLL().STN_OPD_SPECIMEN_LIST_RSLT(rptGroupId, deptId);
        }
        public string STN_SAVE_T_DR_DET_DRAFT(DiagnosticReport dr)
        {
            return new DRSBLL().STN_SAVE_T_DR_DET_DRAFT(dr);
        }
        public List<NursingTree> GET_IPD_SPEC_NO_FOR_RESL_STAN(string rptGroupId, string deptId,string p_tkt_type)
        {
            return new DRSBLL().GET_IPD_SPEC_NO_FOR_RESL_STAN(rptGroupId, deptId, p_tkt_type);
        }
        public List<TestFee> GetEntryReportDetails(string mrno, string reportGroupID)
        {
            return new DRSBLL().GetEntryReportDetails(mrno, reportGroupID);
        }
        public List<DiagnosticReport> GetStainDraftResult(string mrID, string rptgr, string testDetailsID)
        {
            return new DRSBLL().GetStainDraftResult(mrID, rptgr, testDetailsID);
        }
        public List<DiagnosticReport> GetStainResultToFinalised(string mrID, string rptgr, string testDetailsID)
        {
            return new DRSBLL().GetStainResultToFinalised(mrID, rptgr, testDetailsID);
        }
        public List<TestSub> GetReportTestDetails(string mrID, string reportGroup)
        {
            return new SpecimenCollectionBLL().GetReportTestDetails(mrID, reportGroup);
        }
        public List<InvestigationReportRO> GetWorkSheet(string mrID, string reportSecID)
       {
           return new DRSReportBLL().GetWorkSheet(mrID, reportSecID);
       }
       public List<InvestigationReportRO> GetMicroBioResultA1(string MRNo, string reportGrpID, string TestDetailsId)
       {
           return new DRSReportBLL().GetMicroBioResultA1(MRNo, reportGrpID, TestDetailsId);
       }
       public List<InvestigationReportRO> GetMicroBioResultB1(string MRNo, string reportGrpID, string TestDetailsId)
       {
           return new DRSReportBLL().GetMicroBioResultB1(MRNo, reportGrpID, TestDetailsId);
       }
       public List<InvestigationReportRO> GetMicroBioResultC1(string MRNo, string reportGrpID, string TestDetailsId)
       {
           return new DRSReportBLL().GetMicroBioResultC1(MRNo, reportGrpID, TestDetailsId);
       }
       public List<InvestigationReportRO> MBioBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
       {
           return new DRSReportBLL().MBioBulkReportPrint(rptSection, rptGroup, FromDate, ToDate);
       }
       public List<InvestigationReportRO> GetMicroBioResultA2(string rptSection, string rptGroup, string FromDate, string ToDate)
       {
           return new DRSReportBLL().GetMicroBioResultA2(rptSection, rptGroup, FromDate, ToDate);
       }
       public List<InvestigationReportRO> GetMicroBioResultB2(string rptSection, string rptGroup, string FromDate, string ToDate)
       {
           return new DRSReportBLL().GetMicroBioResultB2(rptSection, rptGroup, FromDate, ToDate);
       }
       public List<InvestigationReportRO> GetMicroBioResultC2(string rptSection, string rptGroup, string FromDate, string ToDate)
       {
           return new DRSReportBLL().GetMicroBioResultC2(rptSection, rptGroup, FromDate, ToDate);
       }
       public List<TestSub> GetTestNameForVerify(string mrID, string reportGroup)
       {
           return new SpecimenCollectionBLL().GetTestNameForVerify(mrID, reportGroup);
       }
       public List<TestSub> GetTestNameForFinalize(string mrID, string reportGroup)
       {
           return new SpecimenCollectionBLL().GetTestNameForFinalize(mrID, reportGroup);
       }
       public List<TestFee> GetSpcCollforCancellation(string mrNo)
       {
           return new SpecimenCollectionBLL().GetSpcCollforCancellation(mrNo);
       }
       public string SaveDiagnosResultFromMachin(string deptID, string rptSecID, string rptGrpID,string comID,string locID,string macID)
       {    
           return new DRSBLL().SaveDiagnosResultFromMachin(deptID, rptSecID, rptGrpID,comID,locID,macID);
       }
       public string PathologyReportVerify(string reportID)
       {
           return new DRSReportBLL().PathologyReportVerify(reportID);
       }
       public string MBIOReportVerify(string reportID)
       {
           return new DRSReportBLL().MBIOReportVerify(reportID);
       }
   
       public List<InvestigationReportRO> GetInvestigationReportPreview(string MRNo, string reportSection, string reportGroup)
       {
           return new DRSReportBLL().GetInvestigationReportPreview(MRNo, reportSection, reportGroup);
       }
       public List<InvestigationReportRO> GetMicroBioResultAA(string MRNo)
       {
           return new DRSReportBLL().GetMicroBioResultAA(MRNo);
       }
       public List<InvestigationReportRO> GetMicroBioResultBB(string MRNo)
       {
           return new DRSReportBLL().GetMicroBioResultBB(MRNo);
       }
       public List<DiagnosticReport> PatientListForLabelPrint(string mrID)
       {
           return new SpecimenCollectionBLL().PatientListForLabelPrint(mrID);
       }
       public List<InvestigationReportRO> PatientListForLabelPrintReport(string mrID, string reportGroupID)
       {
           return new DRSReportBLL().PatientListForLabelPrintReport(mrID, reportGroupID);
       }
       public short CancelSpecimanCollection(SpecimenCollection spcColl)
       {
           return new SpecimenCollectionBLL().CancelSpecimanCollection(spcColl);
       }
       public string SaveSpecimenCancellation(SpecimenCollection spcColl)
       {
           return new SpecimenCollectionBLL().SaveSpecimenCancellation(spcColl);
       }
       public int GetMicroBioResCnt(string MRNo)
       {
           return new DRSReportBLL().GetMicroBioResCnt(MRNo);
       }
       public List<InvestigationReportRO> GetMicroBioResultABulk(string rptSection, string rptGroup, string FromDate, string ToDate)
       {
           return new DRSReportBLL().GetMicroBioResultABulk(rptSection, rptGroup, FromDate, ToDate);
       }
       public List<InvestigationReportRO> GetMicroBioResultBBulk(string rptSection, string rptGroup, string FromDate, string ToDate)
       {
           return new DRSReportBLL().GetMicroBioResultBBulk(rptSection, rptGroup, FromDate, ToDate);
       }
       public List<InvestigationReportRO> GetWorkSheetForUI(string reportSectionID, string mrID)
       {
           return new DRSReportBLL().GetWorkSheetForUI(reportSectionID, mrID);
       }
       public string SaveFinalDiagnosticResultPreview(DiagnosticReport dr)
       {
           return new DRSBLL().SaveFinalDiagnosticResultPreview(dr);
       }
       public string SaveMicroBiologyFinaldResultPrev(DiagnosticReport dr)
       {
           return new DRSBLL().SaveMicroBiologyFinaldResultPrev(dr);
       }
       public List<InvestigationReportRO> GetMicroBioReportPreview(string resultID)
       {
           return new DRSReportBLL().GetMicroBioReportPreview(resultID);
       }
       public List<InvestigationReportRO> GetMicroBioResultAPreview(string resultID)
       {
           return new DRSReportBLL().GetMicroBioResultAPreview(resultID);
       }
       public List<InvestigationReportRO> GetMicroBioResultBPreview(string resultID)
       {
           return new DRSReportBLL().GetMicroBioResultBPreview(resultID);
       }
       public List<InvestigationReportRO> MoneyReceiptLifeCycle(string mrID)
       {
           return new DRSBLL().MoneyReceiptLifeCycle(mrID);
       }
       public List<SpecimenRO> GetSpecimensReprint(string mrID)
       {
           return new DRSReportBLL().GetSpecimensReprint(mrID);
       }
       public List<NursingTree> GetMRForEmergencySampleColl(string nsID)
       {
           return new DRSBLL().GetMRForEmergencySampleColl(nsID);
       }
    }
}
