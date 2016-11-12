using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class PurchaseOrder
    {
        public string ID { set; get; }
        public string TransactionType { set; get; }
        public string POType { set; get; }
        public DateTime PODate { set; get; }
        public DateTime DeliveryDate { set; get; }
        public string DeliveryNote { set; get; }
        public string CompleteFlag { set; get; }
        public string Remarks { set; get; }
        public string PurchaseBy { set; get; }
        public string POString { set; get; }
        public string TermsDetails { set; get; }
        public float PendingReqQty { set; get; }
        public float PrevPO { set; get; }
        public ItemOrder ItemOrder { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public Warehouse Warehouse { set; get; }
        public StoreTypeSCM StoreType { set; get; }
        public PurchaseRequisition PurchaseRequisition { set; get; }
        public Supplier Supplier { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
