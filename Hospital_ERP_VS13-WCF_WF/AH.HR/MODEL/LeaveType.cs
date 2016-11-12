using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class LeaveType:Staff
    {
        public string TypeID { set; get; }
        public string TypeTitle { set; get; }
        public string TypeTitleBeng { set; get; }
        public string TypeFlag { set; get; }
        public string Serial { set; get; }
        public string Remarks { set; get; }
    }
}
