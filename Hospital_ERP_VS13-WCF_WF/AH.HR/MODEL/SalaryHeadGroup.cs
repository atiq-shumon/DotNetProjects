using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class SalaryHeadGroup : Staff

    {
        public string HeadType { set; get; }
        public string HeadGroupID { set; get; }
        public string HeadGroupTitle { set; get; }
        public string HeadGroupTitleBeng { set; get; }
        public string SerialNumber { get; set; }
        public string Remarks { set; get; }

    }
}
