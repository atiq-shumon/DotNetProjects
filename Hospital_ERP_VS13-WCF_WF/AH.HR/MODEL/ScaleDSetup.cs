using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class ScaleDSetup : Staff
    {
        public SalaryHead SalaryHead { set; get; }
        public SalaryGradeSetup SalaryGradeSetup { set; get; }
        public ScaleMSetup ScaleMSetup { set; get; }
        public string amount { set; get; }

        public string SalaryHeadString { set; get; }
    }
}
