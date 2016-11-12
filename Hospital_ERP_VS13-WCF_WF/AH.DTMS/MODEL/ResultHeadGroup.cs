using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class ResultHeadGroup
    {
        public string ResultHeadGroupID { set; get; }
        public string ResultHeadGroupTitle { set; get; }
        public string ResultHeadGroupTitleBeng { set; get; }
        public string Remarks { set; get; }
        public string IsVisible { set; get; }
        public ReportSection ReportSection { set; get; }
        public Department Department { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
