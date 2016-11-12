using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class IncomeTax
    {
        public string FiscalYear { set; get; }
        public string Catagory { set; get; }
        public string HraExm { set; get; }
        public string MaExm { set; get; }
        public string ConExm { set; get; }
        public string InvstLimit { set; get; }
        public string InvstTaxRebat { set; get; }
        public string TaxFreeLimit { set; get; }
        public string MinTaxAmt { set; get; }
        public string Slot1 { set; get; }
        public string Slot1Limit { set; get; }
        public string Slot2 { set; get; }
        public string Slot2Limit { set; get; }
        public string Slot3 { set; get; }
        public string Slot3Limit { set; get; }
        public string Slot4 { set; get; }
        public string Slot4Limit { set; get; }
        public string Slot5 { set; get; }
        public string Slot5Limit { set; get; }
        public EntryParameter EntryParameter { set; get; }
        
    }
}
