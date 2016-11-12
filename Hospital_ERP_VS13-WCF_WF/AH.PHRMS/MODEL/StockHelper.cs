using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DRUGS.MODEL;

namespace AH.PHRMS.MODEL
{
    public class StockHelper
    {
        public Pharmacy Pharmacy { set; get; }
        public DrugMaster DrugMaster { set; get; }
        public float StockQty { set; get; }
    }
}
