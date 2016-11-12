using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class Payroll : Staff
    {
        public string EmpId {set; get; }
        public string month { set; get; }
        public string year { set; get; }
        public string SalaryLock { set; get; }
    }
}
