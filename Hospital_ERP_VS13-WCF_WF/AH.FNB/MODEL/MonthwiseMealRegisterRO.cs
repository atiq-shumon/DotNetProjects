using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class MonthwiseMealRegisterRO
    {
        public string empID { set; get; }
        public string empName { set; get; }
        public string deptittle { set; get; }
        public double qnty { set; get; }
        public double  Rate { set; get; }
        public double  subsidy { set; get; }
        public double disRate { set; get; }
        public double  NetAmount { set; get; }
        public string grpTitle { set; get; }
        public string desTitle { set; get; }
        public string unitTitle { set; get; }
        



    }
}
