using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DRUGS.MODEL;

namespace AH.PHRMS.MODEL
{
    public class ItemRates
    {
        public DrugMaster DrugMaster { set; get; }
        public Pharmacy Pharmacy { set; get; }
        public float Urate { set; get; }
        public float VAT { set; get; }
        public float Discount { set; get; }
        public float Rackrate { set; get; }
        public float Slrate { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
