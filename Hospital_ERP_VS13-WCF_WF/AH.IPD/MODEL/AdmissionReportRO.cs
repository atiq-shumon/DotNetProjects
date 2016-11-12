using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
    public class AdmissionReportRO
    {
        public string HCN { get; set; }
        public string RegistrationNo { get; set; }
        public string MRNo { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public decimal Amount { get; set; }
        public string DepartmentTitle { get; set; }
        public string UnitTitle { get; set; }
        public string WardNo { get; set; }
        public string RoomNo { get; set; }
        public string BedNo { get; set; }
        public string BedType { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string DischargeDate { get; set; }
        public string EntryBY { get; set; } 
    }
}
