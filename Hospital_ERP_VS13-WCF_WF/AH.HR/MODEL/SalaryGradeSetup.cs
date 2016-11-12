using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class SalaryGradeSetup : Staff
    {
        public string GradeID { set; get; }
        public string GradeTitle { set; get; }
        public string GradeTitleBeng { set; get; }
        public string Srl { set; get; }
        public string Level { set; get; }
    }
}
