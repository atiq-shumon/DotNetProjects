using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.PatReg.MODEL;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.DTMS.MODEL;

namespace AH.DMS.MODEL
{
    public class TestCancelCause
    {
        public string CauseId { set; get; }
        public string CauseTitle { set; get; }
        public string CauseTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
        
    }
}
