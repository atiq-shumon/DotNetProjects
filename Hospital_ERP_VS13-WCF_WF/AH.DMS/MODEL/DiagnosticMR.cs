using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.PatReg.MODEL;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.DTMS.MODEL;
using AH.IPDShared.MODEL;



namespace AH.DMS.MODEL
{
    public class DiagnosticMR
    {
        public string DraftNo { set; get; }
        public double RefundAmount { set; get; }
        public double Due { set; get; }
        public string DRNo { set; get; }
        public NursingTestOrder NursingTestOrder { set; get; }
        public DateTime Date { set; get; }
        public string MRNo { set; get; }
        public InPatient Patient { set; get; }
        public Ticket Prescription { set; get; }
        public TestFee test { set; get; }
        public OPDPayment DiagnosticPayment { set; get; }
        public Doctor Doctor { set; get; }
        public Age PatientAge { set; get; }
        public SpecimenHolder SampleCollector { set; get; }
        public LabRoom Room { set; get; }
        public List<TestFee> Tests { set; get; }
        public string TestString1 { set; get; }
        public string TestString2 { set; get; }
        public string PackageID { set; get; }
        public string Remarks { set; get; }
        public string TestCancelCause { set; get; }
        public string TestRefundCause { set; get; }
        public string TransNo { set; get; }
        public string Dept { set; get; }
        public string BedNo { set; get; }
        public string ApprovalID { set; get; }
        public string PurposeID { set; get; }
        public string DueStatus { set; get; }
        public RefdOrg RefdOrg { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
