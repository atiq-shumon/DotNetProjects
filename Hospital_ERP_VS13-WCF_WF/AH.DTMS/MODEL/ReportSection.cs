using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class ReportSection
    {
        public string ReportSectionID { set; get; }
        public string ReportSectionTitle { set; get; }
        public string ReportSectionTitleBeng { set; get; }
        public string Remarks { set; get; }
        public Department Department { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
