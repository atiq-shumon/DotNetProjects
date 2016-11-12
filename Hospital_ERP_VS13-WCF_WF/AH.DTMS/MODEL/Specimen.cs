using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class Specimen
    {
        public string SpecimenID { set; get; }
        public string SpecimenTitle { set; get; }
        public string SpecimenTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
