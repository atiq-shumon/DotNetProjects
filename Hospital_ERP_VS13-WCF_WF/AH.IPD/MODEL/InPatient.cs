using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.DUtility;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
using AH.ACCMS.MODEL;




namespace AH.IPD.MODEL
{
    public class InPatient : Patient
    {
        public string RegistrationNo { set; get; }
        public DateTime AdmissionDate { set; get; }
        public string AdmissionType { set; get; }
        public string PackageID { set; get; }
        public double Total { set; get; }
        public AdmissionReason AdmissionReason { set; get; }
        public Purpose Purpose { set; get; }
        public string Remarks { set; get; }
        public Age Age { set; get; }
        //public Department Department { set; get; }
        //public DepartmentUnit DepartmentUnit { set; get; }
        //public TestGroup TestGroup { set; get; }
        public RevenueHead RevenueHead { set; get; }
        public Room Room { set; get; }
        public Bed Bed { set; get; }
        public Ward Ward { set; get; }
        public Doctor Doctor { set; get; }
        public DateTime DischargeDate { set; get; }
        public DateTime ExpDischargeDate { set; get; }
        public decimal StayingDays { set; get; }
        public OPDPayment Payment { set; get; }
        public Nurse DutyNurse { set; get; }
    } 
}
