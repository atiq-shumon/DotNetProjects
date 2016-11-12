using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DMS.MODEL
{
    public class RefundCause
    {
        public string CauseId { set; get; }
        public string CauseTitle { set; get; }
        public string CauseTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
