using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;

namespace AH.ADMS.MODEL
{
    public class BedCharges
    {
        public RevenueHeadGroup RevenueHeadGroup { set; get; }
        public RevenueHead RevenueHead { set; get; }
        public Decimal Amount { set; get; }
        public Building Building { set; get; }
        public Department Department { set; get; }
        public BedType BedType { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
