using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class PurchaseOrder
    {
        public string ID { set; get; }
        public string TransactionType { set; get; }
        public string Type { set; get; }
        public string Remarks { set; get; }
        public string Details { set; get; }
        public DateTime Deliverydate { set; get; }
        public string Deliverynote { set; get; }
        public PurchaseRequisition PurchaseRequisition { set; get; }
        public DateTime PODate { set; get; }
        public Warehouse Warehouse { set; get; }
        public Supplier Supplier { set; get; }
        public EntryParameter EntryParameter { set; get; }
        public string POString { set; get; }
        public string TermsDetails { set; get; }
        public ItemsOrder ItemsOrder{set;get;}
    }
}
