using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class OPDPrescriptionReportNewRO
    {
        public string PatientName { get; set; }
        public string TicketNo { get; set; }
        public string HCN { get; set; }
        public string BloodGroup { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BP { get; set; }
        public string Temparature { get; set; }

        public string SPOTWO { get; set; }
        public string OFC { get; set; }
        public string TestGroup { get; set; }
        public string TestGroupString { get; set; }
        public string TestMain { get; set; }
        public string TestDetailsName { get; set; }
        public string Unit { get; set; }
        public string UnitName { get; set; }

        public string Dept { get; set; }
        public string DeptName { get; set; }
        public string DeptUnit { get; set; }
        public string DoctorName { get; set; }
        public string DegreeLn1 { get; set; }
        public string DegreeLn2 { get; set; }
        public string DegreeLn3 { get; set; }
        public string DegreeLn4 { get; set; }
        public string DoctorsDegree { get; set; }
        public string VisitDate { get; set; }
        public string Advice { get; set; }
        public string Diagnosis { get; set; }
        public string GenericName { get; set; }
        public string Medicine { get; set; }
        public string ComplaintsTitle { get; set; }
        public string OtherComplaintsTitle { get; set; }
        public string CFcategory { get; set; }
        public string ClinicalFindingsGroup { get; set; }
        public string ClinicalFindings { get; set; }
        public string ComorbidIllness { get; set; }
        public string PastMedHis { get; set; }
        public string PastSurgHis { get; set; }
        public string FamilyHis { get; set; }
        public string HistoryTogether { get; set; }
        public string PaediatricHisTogether { get; set; }
        public string GynObsHistory { get; set; }
        public string MedicineDose { get; set; }
        public string RefDept { get; set; }
        public string RefUnit { get; set; }
        public string RefDoc { get; set; }
        public string NextVisitDate { get; set; }
    }
}
