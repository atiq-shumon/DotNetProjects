using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.HR.MODEL
{
    public class PayrollBase
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public SalaryHead SalaryHead { set; get; }
        public double amount { set; get; }
        public string SalaryHeadString { set; get; }
        public string HeadType { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
