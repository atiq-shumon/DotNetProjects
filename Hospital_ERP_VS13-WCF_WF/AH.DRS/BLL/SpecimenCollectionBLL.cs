using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRS.MODEL;
using AH.DTMS.MODEL;
using AH.Shared.MODEL;
using AH.DRS.DAL;

namespace AH.DRS.BLL
{
    public class SpecimenCollectionBLL
    {
        public string SaveSpecimenCollection(SpecimenCollection spcColl)
        {
            return new SpecimenCollectionDAL().SaveSpecimenCollection(spcColl);

        }
        public SpecimenCollection GetSpecimenCollection(string spcId)
        {
            return new SpecimenCollectionDAL().GetSpecimenCollection(spcId);
        }
        public string verifySpecimenNumbers(string spcno, string deptid, string reportid)
        {
            return new SpecimenCollectionDAL().verifySpecimenNumbers(spcno, deptid, reportid);
        }
        public string verifySpecimenNo(string spcno)
        {
            return new SpecimenCollectionDAL().verifySpecimenNo(spcno);
        }
        public List<TestFee> GetSpcCollectedTest(string specNo)
        {
            return new SpecimenCollectionDAL().GetSpcCollectedTest(specNo);
        }
        public List<TestSub> GetSpcTestReportGroup(string spcNo, string reportGroup)
        {
            return new SpecimenCollectionDAL().GetSpcTestReportGroup(spcNo, reportGroup);
        }
        public DiagnosticReport GetSpecimenCollectionByResultID(string resultId, string test_detail_id)
        {
            return new SpecimenCollectionDAL().GetSpecimenCollectionByResultID(resultId, test_detail_id);
        }
        public short UpdateSpecimenReceivedBy(SpecimenCollection spcColl)
        {
            return new SpecimenCollectionDAL().UpdateSpecimenReceivedBy(spcColl);
        }
        public List<SpecimenCollection> GetDiagnosticMoneyReceiptList()
        {
            return new SpecimenCollectionDAL().GetDiagnosticMoneyReceiptList();
        }
        public List<SpecimenCollection> GetSpecimenList(string deptID, string rpt_group_id)
        {
            return new SpecimenCollectionDAL().GetSpecimenList(deptID, rpt_group_id);
        }
        public List<TestFee> GetDmrTestForSpc(string mrno)
        {
            return new SpecimenCollectionDAL().GetDmrTestForSpc(mrno);
        }
        public List<TestSub> GetTestByMRID(string mrID, string reportGroup)
        {
            return new SpecimenCollectionDAL().GetTestByMRID(mrID, reportGroup);
        }
        public List<TestSub> GetReportTestDetails(string mrID, string reportGroup)
        {
            return new SpecimenCollectionDAL().GetReportTestDetails(mrID, reportGroup);
        }
        public List<TestSub> GetTestNameForVerify(string mrID, string reportGroup)
        {
            return new SpecimenCollectionDAL().GetTestNameForVerify(mrID, reportGroup);
        }
        public List<TestSub> GetTestNameForFinalize(string mrID, string reportGroup)
        {
            return new SpecimenCollectionDAL().GetTestNameForFinalize(mrID, reportGroup);
        }
        public List<TestFee> GetSpcCollforCancellation(string mrNo)
        {
            return new SpecimenCollectionDAL().GetSpcCollforCancellation(mrNo);
        }
     
        public List<DiagnosticReport> PatientListForLabelPrint(string mrID)
        {
            return new SpecimenCollectionDAL().PatientListForLabelPrint(mrID);
        }
        public short CancelSpecimanCollection(SpecimenCollection spcColl)
        {
            return new SpecimenCollectionDAL().CancelSpecimanCollection(spcColl);
        }
        public string SaveSpecimenCancellation(SpecimenCollection spcColl)
        {
            return new SpecimenCollectionDAL().SaveSpecimenCancellation(spcColl);
        }
    }
}
