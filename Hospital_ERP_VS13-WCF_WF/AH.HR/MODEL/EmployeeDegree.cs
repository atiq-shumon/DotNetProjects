using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeeDegree
    {
        public string EmployeeID { set; get; }
        public string EmployeeName { set; get; }
        public string DegreeLine1 { set; get; }
        public string DegreeLine2 { set; get; }
        public string DegreeLine3 { set; get; }
        public string DegreeLine4 { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
