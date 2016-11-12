using AH.IPDShared.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
   public class IPDBirth
    {
        public InPatient InPatient { set; get; }
        public string ChildHCN { set; get; }
        public string BirthType { set; get; }
        public string Gender { set; get; }
        public string BloodGroup { set; get; }
        public string BirthHeight { set; get; }
        public string BirthWeight { set; get; } 
        public string DeptGroupID { set; get; }
        public string DepartmentGroupTitle { set; get; }
        public string DepartmentID { set; get; }
        public string DepartmentTitle { set; get; }
        public string UnitId { set; get; }
        public string UnitTitle { set; get; }
        public string DoctorId { set; get; }
        public string DoctorName { set; get; }
        public string NurseID { set; get; }
        public string NurseTitle { set; get; }
        public string DischargeWeight { set; get; }
        public DateTime BirthDateTime { set; get; }
        public string Complexion { set; get; }
        public string BirthMark { set; get; }
        public string HealthStatus { set; get; }
        public string GovtRegistrationNo { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
