using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeeDependent
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public string DependID { set; get; }
        public string DependSerial { set; get; }
        public string DependName { set; get; }
        public string DependNameBeng { set; get; }
        public string RelationID { set; get; }
        public string DependentStatus { set; get; }
        public string PhotoPath { set; get; }
        public DateTime DOB { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
