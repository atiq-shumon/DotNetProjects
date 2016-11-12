using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeePreviousExperience
    {
        public EmployeeMaster EmployeeMaster { get; set; }  // EmployeeMaster typer employee lagbe tai
        public string OrganizationName { get; set; }
        public string Designation { set; get; }
        public string JobDesc { get; set; }
        public DateTime  DoJ { get; set; }
        public DateTime DoR { get; set; }
        public string serial { set; get; }
        public string ResignCause { get; set; }
        public EntryParameter Entryparameter { get; set; }
    }
}
