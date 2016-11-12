using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class QualitativeDetail
    {
        public Qualitative Qualitative { set; get; }
        public string DetID { set; get; }
        public string DetTitle { set; get; }
        public string DetTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set;get;}
    }
}
