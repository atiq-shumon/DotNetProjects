using AH.HR.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class OPDDoctorCall
    {
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Doctor Doctor { set; get; }
        public string NurseID { get; set;}
        public string NStationID { get; set;}
        public string RoomNo { get; set; }
        public Prescription Prescription { set; get;}
        public string Status { get; set; }
        public string EntryDate { get; set; }
        public string DoctorStatus { get; set; }
      
    }
}
