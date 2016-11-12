using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.IPDShared.MODEL;
using AH.DRS.MODEL;
using AH.Shared.MODEL;
using AH.DTMS.MODEL;
//using AH.PatReg.MODEL;
using AH.DUtility;
using AH.DMS.MODEL;
using AH.HR.MODEL;

namespace AH.DRS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDRSWS" in both code and config file together.
    [ServiceContract]
    public interface IDRSWS
    {

        [OperationContract]
        List<ResultHead> GetResultHeads(string groupID);

        [OperationContract]
        List<ResultHead> GetResHead(string mrID, string reportGroupID,string machineID);
        [OperationContract]
        string SaveSpecimenCollection(SpecimenCollection spcColl);
        
        
        //[OperationContract]
        //List<Specimen> GetSpec();
        [OperationContract(Name = "GetSpecDict")]
        Dictionary<string, string> GetSpec(string type);
    
        [OperationContract]
        Dictionary<string, string> GetDepartments(string type);
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);
       // Dictionary<string, string> GetDepartmentsGroupWise(string type,string group);
        //[OperationContract]
        //List<ReportGroup> GetRptgrpSetup(string dept);
        [OperationContract]
        Patient GetPatient(string pId);
        [OperationContract]
        InPatient GetCurrentPatient(string mrno);
        [OperationContract]
        List<TestFee> GetReportTest(string mrno);
        [OperationContract(Name = "GetRoomsDict")]
        Dictionary<string, string> GetRooms(string types);
        [OperationContract]
        string VerifyDiagnosticResult(DiagnosticReport dr);
         [OperationContract]
        string SaveDiagnosticResult(DiagnosticReport dr);
        [OperationContract]
        SpecimenCollection GetSpecimenCollection(string spcId);
        [OperationContract]
        List<InvestigationReportRO> GetInvestigationReport(string transactionNo);
        //=======================Reffd DMS========================//
        [OperationContract(Name = "GetRptgrpDictByDept")]
        Dictionary<string, string> GetRptgrpSetup(string type, string dept);
        [OperationContract]
        Dictionary<string, string> GetRptSecSetup(string dept);
        [OperationContract]
        Dictionary<string, string> GetRptgrpDic(string sec);
      
        [OperationContract]
        string verifyMrno(string mrno);

        //Report
        [OperationContract]
        List<SpecimenRO> GetSpecimens(string SpecimenNo);
        [OperationContract]
        string verifySpecimenNumbers(string spcno, string deptid, string reportid);
        [OperationContract]
        List<TestFee> GetSpcCollectedTest(string specNo);
        [OperationContract]
        List<TestFee> GetDmrTestForSpc(string mrno);
        [OperationContract]
        List<SpecimenCollection> GetReportListToVerify(string rptSection, string rptGroup);

         [OperationContract]
        List<SpecimenCollection> GetReportListToFinalised(string rptSection, string rptGroup);
        [OperationContract]
        List<TestSub> GetSpcTestReportGroup( string spcNostring ,string reportGroup);

        //===================25-10-2014========================================//

        [OperationContract]
        List<DiagnosticReport> GetResultToVerify(string mrID, string rptgr);
        [OperationContract]
        List<DiagnosticReport> GetResultToFinalised(string mrID, string rptgr);

        [OperationContract]
        string UpdateDiagnosticResult(DiagnosticReport dr);

        [OperationContract]
        string verifySpecimenNo(string spcno);

        [OperationContract]
        DiagnosticReport GetSpecimenCollectionByResultID(string resultId, string test_detail_id);
        [OperationContract]
        List<NursingTree> GetNursStationWiseMoneyReceipt(string nsID);

        [OperationContract]
        List<NursingTree> GetNurseStatonWiseMRNoForSampleReciv(string p_tkt_type);
        [OperationContract]
        short UpdateSpecimenReceivedBy(SpecimenCollection spcColl);
        [OperationContract]
        List<SpecimenCollection> GetDiagnosticMoneyReceiptList();

        [OperationContract]
        List<SpecimenCollection> GetSpecimenList(string deptID, string rpt_group_id);

        [OperationContract]
        List<SpecimenCollection> OPDPendingMoneyRecipt();

        [OperationContract]
        List<NursingTree> GetNursStationWiseMRNoForResult(string rptGroupId, string deptId, string p_tkt_type);

        [OperationContract]
        List<SpecimenCollection> OPDPendingSpecimenListForResult(string rptGroupId, string deptId);

        //[OperationContract]
        //string FinalisedDiagnosticResult(DiagnosticReport dr);

        [OperationContract]
        string SaveFinalDiagnosticResult(DiagnosticReport dr);

        [OperationContract]
        List<TestSub> GetTestByMRID(string mrID, string reportGroup);

        [OperationContract]
        List<DiagnosticReport> GetLatestResultToVerify(string mrID, string rptgr);

        [OperationContract]
        string SaveVerifiedDiagnosticResult(DiagnosticReport dr);

        [OperationContract]
        List<DiagnosticReport> GetUpdatedVerifiedResult(string mrID, string rptgr);

        [OperationContract]
        List<DiagnosticReport> GetFinalisedResult(string mrID, string rptgr);

        [OperationContract]
        List<NursingTree> GetNurseStationMrForVerified(string rptGroupId, string rptSection, string p_ns_id);

       [OperationContract]
        List<SpecimenCollection> GetOPDDMRToVerify(string rptSection, string rptGroup);

       [OperationContract]
       List<SpecimenCollection> GetOPDDMRToFinalised(string rptSection, string rptGroup);

       [OperationContract]
       List<NursingTree> GetNurseStnWiseMrForFinalised(string rptGroupId, string rptSection, string p_ns_id);

       [OperationContract]
       string SaveStainResult(DiagnosticReport dr);

       [OperationContract]
       string SaveMicroBiologyResult(DiagnosticReport dr);

       [OperationContract]
       DiagnosticReport GetNoGrowthResultToVerify(string mrID, string rptgr,string testDetailsID);

       [OperationContract]
       string SaveMicroBiologyVerifiedResult(DiagnosticReport dr);

       [OperationContract]
       List<DiagnosticMR> GetMicroBioRprtLstToVerify(string rptSection, string rptGroup);

       [OperationContract]
       List<DiagnosticMR> GetMicroBioRprtLstToFinalised(string rptSection, string rptGroup);

       [OperationContract]
       DiagnosticReport GetNoGrowthResultToFinal(string mrID, string rptgr,string testDetails);

       [OperationContract]
       string SaveMicroBiologyFinaldResult(DiagnosticReport dr);

       [OperationContract]
       List<InvestigationReportRO> GetMicroBioReport(string MRNo);

       [OperationContract]
       List<SpecimenCollection> BulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate);

       [OperationContract]
       string UpdatePrintFlag(DiagnosticReport dr);

       [OperationContract]
       List<InvestigationReportRO> GetBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate);

       [OperationContract]
       List<DiagnosticReport> GetMicroBioResultToVerify(string mrID, string rptgr,string testDetailsID);

       [OperationContract]
       List<DiagnosticReport> GetMicroBioResultToFinalised(string mrID, string rptgr,string specimanID,string testDetails);

       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultA(string MRNo);

       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultB(string MRNo);

       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultC(string MRNo);

       [OperationContract]
       List<SpecimenCollection> MBioOPDPendingSpcmenLstForRslt(string rptGroupId, string deptId);

       [OperationContract]
       List<NursingTree> MBioIPDNursStationWiseSpecimenNoForResult(string rptGroupId, string deptId,string p_tkt_type);
       [OperationContract]
       List<NursingTree> MBioNSTNMrForVerified(string rptGroupId, string rptSection, string p_tkt_type);

       [OperationContract]
       List<NursingTree> MBioNSTNMrForFinalised(string rptGroupId, string rptSection,string p_tkt_type);

        //*************************HRMIS******************************//
       [OperationContract]
       EmployeeMaster GetEmpoyee(string empID);

       [OperationContract]
       string SaveUserReportAccess(UserReportAccess uerAccess);

       [OperationContract]
       List<UserReportAccess> GetUserAccess(string deptID, string rptSecID);

       [OperationContract]
       List<DiagnosticMR> GetMrListToPrint();

       [OperationContract]
       List<SpecimenCollection> GetAllReport(string moneyReciptID);

       [OperationContract]
       List<NursingTree> GetIPDMRList();

       [OperationContract]
       List<SpecimenCollection> GetAllReportsByMRID(string moneyReciptID);

       [OperationContract]
       Dictionary<string, string> GetMacSetup(string type);
       [OperationContract]
       List<ResultHead> GetResHeads(string mrID, string reportGroupID, string testDetailsID);
       [OperationContract]
       List<SpecimenCollection> STN_OPD_SPECIMEN_LIST_RSLT(string rptGroupId, string deptId);

       [OperationContract]
       string STN_SAVE_T_DR_DET_DRAFT(DiagnosticReport dr);
       [OperationContract]
       List<NursingTree> GET_IPD_SPEC_NO_FOR_RESL_STAN(string rptGroupId, string deptId,string p_tkt_type);

       [OperationContract]
       List<TestFee> GetEntryReportDetails(string mrno, string reportGroupID);

       [OperationContract]
       List<DiagnosticReport> GetStainDraftResult(string mrID, string rptgr, string testDetailsID);

       [OperationContract]
       List<DiagnosticReport> GetStainResultToFinalised(string mrID, string rptgr, string testDetailsID);

       [OperationContract]
       List<TestSub> GetReportTestDetails(string mrID, string reportGroup);

       [OperationContract]
       List<InvestigationReportRO> GetWorkSheet(string mrID, string reportSecID);
  
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultA1(string MRNo, string reportGrpID, string TestDetailsId);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultB1(string MRNo, string reportGrpID, string TestDetailsId);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultC1(string MRNo, string reportGrpID, string TestDetailsId);
       [OperationContract]
       List<InvestigationReportRO> MBioBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultA2(string rptSection, string rptGroup, string FromDate, string ToDate);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultB2(string rptSection, string rptGroup, string FromDate, string ToDate);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultC2(string rptSection, string rptGroup, string FromDate, string ToDate);

       [OperationContract]
       List<TestSub> GetTestNameForVerify(string mrID, string reportGroup);

       [OperationContract]
       List<TestSub> GetTestNameForFinalize(string mrID, string reportGroup);

       [OperationContract]
       List<TestFee> GetSpcCollforCancellation(string mrNo);

       [OperationContract]
       string SaveDiagnosResultFromMachin(string deptID, string rptSecID, string rptGrpID,string comID,string locID,string macID);

       [OperationContract]
       string PathologyReportVerify(string reportID);
       [OperationContract]
       string MBIOReportVerify(string reportID);

       [OperationContract]
       List<InvestigationReportRO> GetInvestigationReportPreview(string MRNo, string reportSection, string reportGroup);

       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultAA(string MRNo);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultBB(string MRNo);

       [OperationContract]
       List<DiagnosticReport> PatientListForLabelPrint(string mrID);

       [OperationContract]
       List<InvestigationReportRO> PatientListForLabelPrintReport(string mrID, string reportGroupID);

       [OperationContract]
       short CancelSpecimanCollection(SpecimenCollection spcColl);

       [OperationContract]
       string SaveSpecimenCancellation(SpecimenCollection spcColl);

       [OperationContract]
       int GetMicroBioResCnt(string MRNo);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultABulk(string rptSection, string rptGroup, string FromDate, string ToDate);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultBBulk(string rptSection, string rptGroup, string FromDate, string ToDate);
       [OperationContract]
       List<InvestigationReportRO> GetWorkSheetForUI(string reportSectionID, string mrID);

       [OperationContract]
       string SaveFinalDiagnosticResultPreview(DiagnosticReport dr);

       [OperationContract]
       string SaveMicroBiologyFinaldResultPrev(DiagnosticReport dr);

       [OperationContract]
       List<InvestigationReportRO> GetMicroBioReportPreview(string resultID);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultAPreview(string resultID);
       [OperationContract]
       List<InvestigationReportRO> GetMicroBioResultBPreview(string resultID);

       [OperationContract]
       List<InvestigationReportRO> MoneyReceiptLifeCycle(string mrID);

       [OperationContract]
       List<SpecimenRO> GetSpecimensReprint(string mrID);

       [OperationContract]
       List<NursingTree> GetMRForEmergencySampleColl(string nsID);
    } 
}
