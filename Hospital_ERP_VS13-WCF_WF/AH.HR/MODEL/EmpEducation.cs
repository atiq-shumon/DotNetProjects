using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmpEducation 
    {
        public Staff Staff { set; get; }
        public string serial { set; get; }
        public EmployeeMaster EmployeeMaster { set; get; }
        public string NameOfDegree { set; get; }
        public string PassingYear { set; get; }
        public string Institute { set; get; }
        public string Class { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
