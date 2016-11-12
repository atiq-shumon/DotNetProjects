using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;

namespace AH.HR.MODEL
{
    public class Nurse : Staff
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public string NurseType { set; get; }
        public string Degree1 { set; get; }
        public string Signature { set; get; }
        public Room Room { set; get; }
        //public DepartmentUnit DepartmentUnit { set; get; }
    }
}
