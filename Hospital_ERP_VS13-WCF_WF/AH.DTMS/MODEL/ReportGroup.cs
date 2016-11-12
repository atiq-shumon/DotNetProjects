using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.DTMS.MODEL
{
    public class ReportGroup
    {
        public string ReportGroupID { set; get; }
        public string ReportGroupTitle { set; get; }
        public string ReportGroupTitleBeng { set; get; }
        public string Remarks { set; get; }
        public Department Department { set; get; }
        public GroupPanel GroupPanel { set; get; }
        public TestCategory TestCategory { set; get; }
        public ReportSection ReportSection { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
