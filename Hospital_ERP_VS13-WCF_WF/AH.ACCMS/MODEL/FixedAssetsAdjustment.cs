using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.ACCMS.MODEL
{
    public class FixedAssetsAdjustment
    {
        public string RefNo { set; get; }
        public string Ledgercode { set; get; }
        public string LedgerName { set; get; }
        public string Branchid { set; get; }
        public string adjustmentdate { set; get; }
        public double adjustmentAmount { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
