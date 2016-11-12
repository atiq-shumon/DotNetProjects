using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;
using AH.DTMS.MODEL;
using AH.OPD.MODEL;
using AH.HR.MODEL;

namespace AH.DMS.MODEL
{
    public class EmergencyMaster
    {
        public string EmergencyPrescriptionID { set; get; }
        public string PackageID { set; get; }
        public DepartmentGroup DepartmentGroup { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public NursingTestOrder NursingTestOrder { set; get; }
        public string TicketType { set; get; }
        public string CopyPrinted { get; set; }
        public string CopyPrintedBY { get; set; }
        public string TicketValidity { set; get; }
        public string NextVisitDate { set; get; }
        public string IsAdmAdv { set; get; }
        public string PrevTicketNo { set; get; }
        public double TicketFee { set; get; }
        public double ConsultantFee { set; get; }
        public double RefdFee { set; get; }
        public double DeptFee { set; get; }
        public TestFee test { set; get; }
        public InPatient Patient { set; get; }
        public RefdOrg RefdOrg { set; get; }
        public OPDPayment DiagnosticPayment { set; get; }
        public Doctor Doctor { set; get; }
        //public Admission Admission { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
