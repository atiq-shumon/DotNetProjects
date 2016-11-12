using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class ScaleMSetup : Staff
    {
        public SalaryGradeSetup SalaryGradeSetup { set; get; }
        public string ScaleMID { set; get; }
        public string ScaleTitle { set; get; }
        public string ScaleTitleBeng { set; get; }
        public string Srl { set; get; }
    }
}
