using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRS.MODEL;
using AH.DRS.DAL;
using AH.DTMS.MODEL;
using AH.DUtility;
using AH.DMS.MODEL;

namespace AH.DRS.BLL
{
    public class DRSBLL
    {
        public string VerifyDiagnosticResult(DiagnosticReport dr)
        {
            return new DRDAL().VerifyDiagnosticResult(dr);
        }
        //public string FinalisedDiagnosticResult(DiagnosticReport dr)
        //{
        //    return new DRDAL().FinalisedDiagnosticResult(dr);
        //}

        public string SaveDiagnosticResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveDiagnosticResult(dr);
        }
        public List<SpecimenCollection> GetReportListToVerify(string rptSection, string rptGroup)
        {
            return new DRDAL().GetReportListToVerify(rptSection, rptGroup);
        }
        public List<SpecimenCollection> GetReportListToFinalised(string rptSection, string rptGroup)
        {
            return new DRDAL().GetReportListToFinalised(rptSection, rptGroup);
        }

        ////21-10-2014////////////

        //public List<InvestigationReportRO> GetInvestigationReport(string result_id)
        //{
        //    return new InvestigationReportDAL().GetInvestigationReport(result_id);
        //}
        public List<DiagnosticReport> GetResultToVerify(string mrID, string rptgr)
        {
            return new DRDAL().GetResultToVerify(mrID, rptgr);
        }
        public List<DiagnosticReport> GetResultToFinalised(string mrID, string rptgr)
        {
            return new DRDAL().GetResultToFinalised(mrID, rptgr);
        }
        public string UpdateDiagnosticResult(DiagnosticReport dr)
        {
            return new DRDAL().UpdateDiagnosticResult(dr);
        }
        public List<NursingTree> GetNursStationWiseMoneyReceipt(string nsID)
        {
            return new DRDAL().GetNursStationWiseMoneyReceipt(nsID);
        }
        public List<NursingTree> GetNurseStatonWiseMRNoForSampleReciv(string p_tkt_type)
        {
            return new DRDAL().GetNurseStatonWiseMRNoForSampleReciv(p_tkt_type);
        }
        public List<ResultHead> GetResHead(string mrID, string reportGroupID,string machineID)
        {
            return new DRDAL().GetResHead(mrID, reportGroupID, machineID);
        }
        public List<ResultHead> GetResHeads(string mrID, string reportGroupID,string testDetailsID)
        {
            return new DRDAL().GetResHeads(mrID, reportGroupID, testDetailsID);
        }
        public List<SpecimenCollection> OPDPendingMoneyRecipt()
        {
            return new DRDAL().OPDPendingMoneyRecipt();
        }
        public List<NursingTree> GetNursStationWiseMRNoForResult(string rptGroupId, string deptId, string p_tkt_type)
        {
            return new DRDAL().GetNursStationWiseMRNoForResult(rptGroupId, deptId, p_tkt_type);
        }
        public List<SpecimenCollection> OPDPendingSpecimenListForResult(string rptGroupId, string deptId)
        {
            return new DRDAL().OPDPendingSpecimenListForResult(rptGroupId, deptId);
        }
        public string SaveFinalDiagnosticResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveFinalDiagnosticResult(dr);       
        }
        public List<DiagnosticReport> GetLatestResultToVerify(string mrID, string rptgr)
        {
            return new DRDAL().GetLatestResultToVerify(mrID, rptgr);
        }
        public string SaveVerifiedDiagnosticResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveVerifiedDiagnosticResult(dr);
        }
        public List<DiagnosticReport> GetUpdatedVerifiedResult(string mrID, string rptgr)
        {
            return new DRDAL().GetUpdatedVerifiedResult(mrID, rptgr);
        }
        public List<DiagnosticReport> GetFinalisedResult(string mrID, string rptgr)
        {
            return new DRDAL().GetFinalisedResult(mrID, rptgr);
        }
        public List<NursingTree> GetNurseStationMrForVerified(string rptGroupId, string rptSection, string p_ns_id)
        {
            return new DRDAL().GetNurseStationMrForVerified(rptGroupId, rptSection, p_ns_id);
        }
        public List<SpecimenCollection> GetOPDDMRToVerify(string rptSection, string rptGroup)
        {
            return new DRDAL().GetOPDDMRToVerify(rptGroup, rptSection);
        }
        public List<SpecimenCollection> GetOPDDMRToFinalised(string rptSection, string rptGroup)
        {
            return new DRDAL().GetOPDDMRToFinalised(rptGroup, rptSection);
        }
        public List<NursingTree> GetNurseStnWiseMrForFinalised(string rptGroupId, string rptSection, string p_ns_id)
        {
            return new DRDAL().GetNurseStnWiseMrForFinalised(rptGroupId, rptSection, p_ns_id);
        }
        public string SaveStainResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveStainResult(dr);
        }
        public string SaveMicroBiologyResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveMicroBiologyResult(dr);
        }
        public DiagnosticReport GetNoGrowthResultToVerify(string mrID, string rptgr,string testDetailsID)
        {
            return new DRDAL().GetNoGrowthResultToVerify(mrID, rptgr, testDetailsID);
        }
        public string SaveMicroBiologyVerifiedResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveMicroBiologyVerifiedResult(dr);
        }
        public List<DiagnosticMR> GetMicroBioRprtLstToVerify(string rptSection, string rptGroup)
        {
            return new DRDAL().GetMicroBioRprtLstToVerify(rptSection, rptGroup);
        }
        public List<DiagnosticMR> GetMicroBioRprtLstToFinalised(string rptSection, string rptGroup)
        {
            return new DRDAL().GetMicroBioRprtLstToFinalised(rptSection, rptGroup);
        }
        public DiagnosticReport GetNoGrowthResultToFinal(string mrID, string rptgr,string testDetails)
        {
            return new DRDAL().GetNoGrowthResultToFinal(mrID, rptgr, testDetails);
        }
        public string SaveMicroBiologyFinaldResult(DiagnosticReport dr)
        {
            return new DRDAL().SaveMicroBiologyFinaldResult(dr);
        }
        public List<SpecimenCollection> BulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
        {
            return new DRDAL().BulkReportPrint(rptSection, rptGroup, FromDate, ToDate);
        }
        public string UpdatePrintFlag(DiagnosticReport dr)
        {
            return new DRDAL().UpdatePrintFlag(dr);
        }
        public List<DiagnosticReport> GetMicroBioResultToVerify(string mrID, string rptgr, string testDetailsId)
        {
            return new DRDAL().GetMicroBioResultToVerify(mrID, rptgr, testDetailsId);
        }
        public List<DiagnosticReport> GetMicroBioResultToFinalised(string mrID, string rptgr,string specimanID,string testDetails)
        {
            return new DRDAL().GetMicroBioResultToFinalised(mrID, rptgr, specimanID, testDetails);
        }
        public List<SpecimenCollection> MBioOPDPendingSpcmenLstForRslt(string rptGroupId, string deptId)
        {
            return new DRDAL().MBioOPDPendingSpcmenLstForRslt(rptGroupId, deptId);
        }
        public List<NursingTree> MBioIPDNursStationWiseSpecimenNoForResult(string rptGroupId, string deptId,string p_tkt_type)
        {
            return new DRDAL().MBioIPDNursStationWiseSpecimenNoForResult(rptGroupId, deptId, p_tkt_type);
        }
        public List<NursingTree> MBioNSTNMrForVerified(string rptGroupId, string rptSection, string p_tkt_type)
        {
            return new DRDAL().MBioNSTNMrForVerified(rptGroupId, rptSection, p_tkt_type);
        }
        public List<NursingTree> MBioNSTNMrForFinalised(string rptGroupId, string rptSection,string p_tkt_type)
        {
            return new DRDAL().MBioNSTNMrForFinalised(rptGroupId, rptSection, p_tkt_type);
        }
        public List<DiagnosticMR> GetMrListToPrint()
        {
            return new DRDAL().GetMrListToPrint();
        }

        public List<SpecimenCollection> GetAllReport(string moneyReciptID)
        {
            return new DRDAL().GetAllReport(moneyReciptID);
        }
        public List<NursingTree> GetIPDMRList()
        {
            return new DRDAL().GetIPDMRList();
        }
        public List<SpecimenCollection> GetAllReportsByMRID(string moneyReciptID)
        {
            return new DRDAL().GetAllReportsByMRID(moneyReciptID);
        }
        public List<SpecimenCollection> STN_OPD_SPECIMEN_LIST_RSLT(string rptGroupId, string deptId)
        {
            return new DRDAL().STN_OPD_SPECIMEN_LIST_RSLT(rptGroupId, deptId);
        }
        public string STN_SAVE_T_DR_DET_DRAFT(DiagnosticReport dr)
        {
            return new DRDAL().STN_SAVE_T_DR_DET_DRAFT(dr);
        }
        public List<NursingTree> GET_IPD_SPEC_NO_FOR_RESL_STAN(string rptGroupId, string deptId,string p_tkt_type)
        {
            return new DRDAL().GET_IPD_SPEC_NO_FOR_RESL_STAN(rptGroupId, deptId, p_tkt_type);
        }
        public List<TestFee> GetEntryReportDetails(string mrno, string reportGroupID)
        {
            return new SpecimenCollectionDAL().GetEntryReportDetails(mrno, reportGroupID);
        }
        public List<DiagnosticReport> GetStainDraftResult(string mrID, string rptgr, string testDetailsID)
        {
            return new DRDAL().GetStainDraftResult(mrID, rptgr, testDetailsID);
        }
        public List<DiagnosticReport> GetStainResultToFinalised(string mrID, string rptgr, string testDetailsID)
        {
            return new DRDAL().GetStainResultToFinalised(mrID, rptgr, testDetailsID);
        }
        public string SaveDiagnosResultFromMachin(string deptID, string rptSecID, string rptGrpID, string comID, string locID, string macID)
        {
            return new DRDAL().SaveDiagnosResultFromMachin(deptID, rptSecID, rptGrpID, comID, locID, macID);
        }
        public string SaveFinalDiagnosticResultPreview(DiagnosticReport dr)          
        {
            return new DRDAL().SaveFinalDiagnosticResultPreview(dr);
        }
        public string SaveMicroBiologyFinaldResultPrev(DiagnosticReport dr)
        {
            return new DRDAL().SaveMicroBiologyFinaldResultPrev(dr);
        }
        public List<InvestigationReportRO> MoneyReceiptLifeCycle(string mrID)
        {
            return new DRDAL().MoneyReceiptLifeCycle(mrID);
        }
        public List<NursingTree> GetMRForEmergencySampleColl(string nsID)
        {
            return new DRDAL().GetMRForEmergencySampleColl(nsID);
        }
    }
}
