using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class DayEnd
    {
        public StoreLocation StoreLocation { set; get; }
        public DateTime Date { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
