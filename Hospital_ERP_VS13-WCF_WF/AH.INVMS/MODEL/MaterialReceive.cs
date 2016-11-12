using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACCMS.MODEL;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class MaterialReceive
    {
        public string ID { set; get; }
        public int MrrFlag { set; get; }
        public DateTime MrrDate { set; get; }
        public DateTime ExpDate { set; get; }
        public string BatchID { set; get; }
        public string TransactionType { set; get; }
        public string MrrType { set; get; }
        public string ChallanNo { set; get; }
        public string VoucherNo { set; get; }
        public CostCategoryTreeview CostCategoryTreeview { set; get; }
        public DateTime ChallanDate { set; get; }
        public string MrrDetails { set; get; }
        public string AssetTracker { set; get; }
        public string Remarks { set; get; }
        public float MrrQuantity { set; get; }
        public float ReturnQty { set; get; }
        public float CompareQty { set; get; }
        public ItemOrder ItemOrder { set; get; }
        public PurchaseRequisition PurchaseRequisition { set; get; }
        public PurchaseOrder PurchaseOrder { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public Warehouse Warehouse { set; get; }
        public Supplier Supplier { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
