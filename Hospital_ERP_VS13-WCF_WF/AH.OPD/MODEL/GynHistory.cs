using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class GynHistory
    {
        public string Gyn { get; set; }
        public string GynText { get; set; }
        public string Obs { get; set; }
        public string ObsText { get; set; }
       
        public EntryParameter EntryParameter { set; get; }
    }
}
