using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRS.MODEL;
using AH.DRS.DAL;

namespace AH.DRS.BLL
{
   public class DRSReportBLL
        {
            public List<InvestigationReportRO> GetInvestigationReport(string transactionNo)
            {
                return new InvestigationReportDAL().GetInvestigationReport(transactionNo);
            }

            public List<SpecimenRO> GetSpecimens(string SpecimenNo)
            {
                return new InvestigationReportDAL().GetSpecimens(SpecimenNo);
            }
            public List<InvestigationReportRO> GetMicroBioReport(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioReport(MRNo);
            }
            public List<InvestigationReportRO> GetBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().GetBulkReportPrint(rptSection, rptGroup, FromDate, ToDate);
            }
            public List<InvestigationReportRO> GetMicroBioResultA(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioResultA(MRNo);
            }
            public List<InvestigationReportRO> GetMicroBioResultB(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioResultB(MRNo);
            }
            public List<InvestigationReportRO> GetMicroBioResultC(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioResultC(MRNo);
            }
            public List<InvestigationReportRO> GetWorkSheet(string mrID, string reportsecID)
            {
                return new InvestigationReportDAL().GetWorkSheet(mrID, reportsecID);
            }       
            public List<InvestigationReportRO> GetMicroBioResultA1(string MRNo, string reportGrpID, string TestDetailsId)
            {
                return new InvestigationReportDAL().GetMicroBioResultA1(MRNo, reportGrpID, TestDetailsId);
            }
            public List<InvestigationReportRO> GetMicroBioResultB1(string MRNo, string reportGrpID, string TestDetailsId)
            {
                return new InvestigationReportDAL().GetMicroBioResultB1(MRNo, reportGrpID, TestDetailsId);
            }
            public List<InvestigationReportRO> GetMicroBioResultC1(string MRNo, string reportGrpID, string TestDetailsId)
            {
                return new InvestigationReportDAL().GetMicroBioResultC1(MRNo, reportGrpID, TestDetailsId);
            }
            public List<InvestigationReportRO> MBioBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().MBioBulkReportPrint(rptSection, rptGroup, FromDate, ToDate);
            }
            public List<InvestigationReportRO> GetMicroBioResultA2(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().GetMicroBioResultA2(rptSection, rptGroup, FromDate, ToDate);
            }
            public List<InvestigationReportRO> GetMicroBioResultB2(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().GetMicroBioResultB2(rptSection, rptGroup, FromDate, ToDate);
            }
            public List<InvestigationReportRO> GetMicroBioResultC2(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().GetMicroBioResultC2(rptSection, rptGroup, FromDate, ToDate);
            }
            public string PathologyReportVerify(string reportID)
            {
                return new InvestigationReportDAL().PathologyReportVerify(reportID);
            }
            public string MBIOReportVerify(string reportID)
            {
                return new InvestigationReportDAL().MBIOReportVerify(reportID);
            }
            public List<InvestigationReportRO> GetInvestigationReportPreview(string MRNo, string reportSection, string reportGroup)
            {
                return new InvestigationReportDAL().GetInvestigationReportPreview(MRNo, reportSection, reportGroup);
            }
            public List<InvestigationReportRO> GetMicroBioResultAA(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioResultAA(MRNo);
            }
            public List<InvestigationReportRO> GetMicroBioResultBB(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioResultBB(MRNo);
            }
            public List<InvestigationReportRO> PatientListForLabelPrintReport(string mrID, string reportGroupID)
            {
                return new InvestigationReportDAL().PatientListForLabelPrintReport(mrID, reportGroupID);
            }
            public int GetMicroBioResCnt(string MRNo)
            {
                return new InvestigationReportDAL().GetMicroBioResCnt(MRNo);
            }
            public List<InvestigationReportRO> GetMicroBioResultABulk(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().GetMicroBioResultABulk(rptSection, rptGroup, FromDate, ToDate);
            }
            public List<InvestigationReportRO> GetMicroBioResultBBulk(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                return new InvestigationReportDAL().GetMicroBioResultBBulk(rptSection, rptGroup, FromDate, ToDate);
            }
            public List<InvestigationReportRO> GetWorkSheetForUI(string reportSectionID,string mrID)
            {
                return new InvestigationReportDAL().GetWorkSheetForUI(reportSectionID, mrID);
            }
            public List<InvestigationReportRO> GetMicroBioReportPreview(string resultID)
            {
                return new InvestigationReportDAL().GetMicroBioReportPreview(resultID);
            }
            public List<InvestigationReportRO> GetMicroBioResultAPreview(string resultID)
            {
                return new InvestigationReportDAL().GetMicroBioResultAPreview(resultID);
            }
            public List<InvestigationReportRO> GetMicroBioResultBPreview(string resultID)
            {
                return new InvestigationReportDAL().GetMicroBioResultBPreview(resultID);
            }
            public List<SpecimenRO> GetSpecimensReprint(string mrID)
            {
                return new InvestigationReportDAL().GetSpecimensReprint(mrID);
            }
        }
  }


