using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.ACCMS.MODEL;
//using AH.IPD.MODEL;



namespace AH.PatReg.MODEL
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
        public string ReferenceType { set; get; }
        public string ReferenceNo { set; get; }
        //public Department Department { set; get; }
        //public DepartmentUnit DepartmentUnit { set; get; }
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
        public string DischargeType { set; get; }
        public string CancellationReason { set; get; }
        public string IsOperationAdvised { set; get; }
        public string OperationID { set; get; }
        public string OperationTitle { set; get; }
        public int HourDifference { set; get; }
        public DateTime ExpectedOperationDate { set; get; }    
    } 
}
