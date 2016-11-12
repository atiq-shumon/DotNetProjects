using AH.HR.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPDShared.MODEL
{
    public class IPDDoctor : Doctor
    {
        //public Department Department { get; set; }
        //public DepartmentUnit DepartmentUnit { get; set; }
        //public Doctor Doctor { get; set; }
        public string VisitNo { get; set; }
        public double IPDVisitingFee { get; set; }
        public double DoctorsVisitingFee { get; set; }
        public string Remarks { get; set; }

        // public EntryParameter EntryParameter { set; get; }
    }
}

