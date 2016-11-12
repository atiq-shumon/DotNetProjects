using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class DayEnd
    {
        public Pharmacy Pharmacy { set; get; }
        public DateTime Date { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
