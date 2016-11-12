using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACCMS.MODEL;
using AH.INVMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class MaterialReceive
    {
        public ItemsOrder ItemsOrder { set; get; }
        public Warehouse Warehouse { set; get; }
        public Pharmacy Pharmacy { set; get; }
        public PurchaseOrder PurchaseOrder { set; get; }
        public CostCategoryTreeview CostCategoryTreeview { set; get; }
        public Supplier Supplier { set; get; }
        public string PRID { set; get; }
        public string MRRID { set; get; }
        public int OpeningFlag { set; get; }
        public string TransactionType { set; get; }
        public DateTime MRRDate { set; get; }
        public DateTime ExpireDate { set; get; }
        public string BatchNo { set; get; }
        public string MRRType { set; get; }
        public float MRRQuantity { set; get; }
        public float CompareQty { set; get; }
        public string ChallanNo { set; get; }
        public string VoucherNo { set; get; }
        public DateTime ChallanDate { set; get; }
        public string Remarks { set; get; }
        public string MRRDetails { set; get; }      
        public EntryParameter EntryParameter { set; get; }
    }
}
