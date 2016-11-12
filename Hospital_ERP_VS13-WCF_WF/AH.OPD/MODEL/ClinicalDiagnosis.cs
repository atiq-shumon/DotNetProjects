using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPD.MODEL
{
    public class ClinicalDiagnosis
    {
        public string DiagID { set; get; }
        public string DiagTitle { set; get; }
        public string DiagTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
