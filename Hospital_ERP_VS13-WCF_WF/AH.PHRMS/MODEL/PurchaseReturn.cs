using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class PurchaseReturn
    {
        public string ID { set; get; }
        public Warehouse Warehouse { set; get; }
        public Pharmacy Pharmacy { set;get;}
        public PurchaseOrder PurchaseOrder { set; get; }
        public string BatchNo { set; get; }
        public DateTime ReturnDate { set; get; }
        public string ReturnType { set; get; }
        public string ReturnCause { set; get; }
        public string Remarks { set; get; }
        public string ReturnDetails { set; get; }

        public MaterialReceive MaterialReceive { set; get; }
        public Supplier Supplier { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
