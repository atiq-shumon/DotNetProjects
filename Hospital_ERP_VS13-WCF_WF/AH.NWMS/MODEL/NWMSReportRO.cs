using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.IPDShared.MODEL;

namespace AH.NWMS.MODEL
{
    public class NWMSReportRO 
    {
        public string HCN { get; set; }
        public string RegistrationNo { get; set; }
        public string Name { get; set; }
        public string ReferenceNo { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public string AgeFull { get; set; }
        public string StaffID { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string DepartmentID { get; set; }
        public string DepartmentTitle { get; set; }
        public string UnitId { get; set; }
        public string UnitTitle { get; set; }
        public string DeptUnitTitle { get; set; }
        public string DocID { get; set; }
        public string DocName { get; set; }
        public string DeptHeadID { get; set; }
        public string DeptHeadName { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string NurseStationID { get; set; }
        public string TreatingConsultant { get; set; }
        public string VisitingConsultant { get; set; }
        public string DisDiagnosis { get; set; }
        public string DiagnosisOnAdm { get; set; }
        public string CaseSummary { set; get; }
        public string HospitalCourse { set; get; }
        public string OperationNote { set; get; }
        public string Comorbidity { get; set; }
        public string ClinicalFindings { get; set; }
        public string DisDietAdvice { get; set; }
        public string DisAdvice { get; set; }
        public string DisMedicine { get; set; }
        public string DisDiag { get; set; }
        public string NxtVisitDept { get; set; }
        public string NxtVisitUnit { get; set; }
        public string NxtVisitDoc { get; set; }
        public string NextVisitDate { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Bp { get; set; }
        public string Temparature { get; set; }
        public string SPOTWO { get; set; }
        public string OFC { get; set; }
        public string DischargeStatus { get; set; }
        public string DischargeType { get; set; }
        public string IPDMedicineHistory { get; set; }

    }
}
