using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
   public class IPDDeathRO
    {
        public string HCN { get; set; }
        public string RegistrationNo { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }
        public string Consultant { get; set; }
        public string BedTitle { get; set; }
        public string DepartmentTitle { get; set; }
        public string UnitTitle { get; set; }
        public string DeathNotes { get; set; }
        public string DeathReason { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DeathDateTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Remarks { get; set; }
    }
}
