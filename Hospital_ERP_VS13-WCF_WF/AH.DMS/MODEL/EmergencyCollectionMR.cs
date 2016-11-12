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
    public class EmergencyCollectionMR
    {
        public EmrCollHead EmrCollHead { set; get; }
        public string EmergencyMR { set; get; }
        public string AdmissionID { set; get; }
        public double NetPaid { set; get; }
        public NursingTestOrder NursingTestOrder { set; get; }
        public TestFee test { set; get; }
        public string Remarks { set; get; }
        public string DRNo { set; get; }
        public Ticket Ticket { set; get; }
        public InPatient Patient { set; get; }
        public string PackageID { set; get; }
        public string TestString1 { set; get; }
        public RefdOrg RefdOrg { set; get; }
        public OPDPayment DiagnosticPayment { set; get; }
        public Doctor Doctor { set; get; }
        public EntryParameter EntryParameter { set; get; }
        public string IsAdmAdv { set; get; }
    }
}
