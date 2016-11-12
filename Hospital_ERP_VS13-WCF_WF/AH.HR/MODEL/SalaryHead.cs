using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class SalaryHead : Staff
    {     
        public SalaryHeadGroup SalaryHeadGroup { set; get; }
        public string HeadID { set; get; }
        public string HeadTitle { set; get; }
        public string HeadTitleBeng { set; get; }
        public string Remarks { set; get; }
        public string Srl { set; get; }
    }
}
