using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
    public class IPDBirthCertificateRO
    {
        public string ChildID { get; set; }
        public string Name { get; set; }
        public string MotherHCN { get; set; }
        public string ChildHCN { get; set; }
        public string MotherRegistrationNo { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }      
        public string Address { get; set; }
        public string CellPhone { get; set; }
        public string DoctorName { get; set; }
        public string BirthType { get; set; }
        public string DepartmentTitle { get; set; }
        public string UnitTitle { get; set; }
        public string BirthMarks { get; set; }
        public string BirthHeight { get; set; }
        public string BirthWeight { get; set; }
        public string DischargeWeight { get; set; }
        public string GovtRegistrationID { get; set; }
        public string HealthStatus { get; set; }
        public string AuthorizeBy { get; set; } 
        public DateTime BirthDateTime { get; set; } 
        public string Remarks { get; set; }
    }
}
