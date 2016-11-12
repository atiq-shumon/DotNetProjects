using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class OPDDoctorCallQ
    {
        public OPDDoctorCallQ()
        {
            PatientCount = "0";
        }
        public string Dept_ID { get; set; }
        public string DepertmentName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string Doc_ID { get; set; }
        public string DoctorName { get; set; }
        public string NurseID { get; set; }
        public string NStationID { get; set; }
        public string DoctorStatus { get; set; }
        public string RoomNo { get; set; }
        public string Room { get; set; }
        public string TicketNo { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Bp { get; set; }
        public string Temparature { get; set; }

        public string SPOTWO { get; set; }
        public string OFC { get; set; }
        public string Allergy { get; set; }
        public string AllergyText { get; set; }
        public string Asthma { get; set; }
        public string AsthmaText { get; set; }
        public string Diabetes { get; set; }
        public string DiabetesText { get; set; }
        public string Pressure { get; set; }
        public string PressureText { get; set; }
        public string HeartDisease { get; set; }
        public string HeartDiseaseText { get; set; }
        public string KidneyDisease { get; set; }
        public string KidneyDiseaseText { get; set; }
        public string Others { get; set; }
        public string OthersText { get; set; }
        public string PastMedicalHistory { get; set; }
        public string PastMedicalHistoryText { get; set; }
        public string PastSurgicalHistory { get; set; }
        public string PastSurgicalHistoryText { get; set; }
        public string FamilyHistory { get; set; }
        public string FamilyHistoryText { get; set; }
        public string DT { get; set; }
        public string PatientCount { get; set; }
        public EntryParameter EntryParameter { set; get; }

    }

}
