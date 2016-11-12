using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class SecurityQuestion
    {
        public string QID { get; set; }
        public string QTitle { get; set; }
        public string QTitleBangla { get; set; }
        public string Answer { set; get; }
        public string Remarks { get; set; }
        public EntryParameter EntryParameter { get; set; }
        public string Date { get; set; }
    }
}
