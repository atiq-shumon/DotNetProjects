using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class StockDetailsReportRO
    {
        public string Transac { set; get; }
        public string Product { set; get; }
        public string ProductName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public float OpenQty { set; get; }
        public float OpenRate { set; get; }
        public float PurchaseQty { set; get; }
        public float PurchaseRate { set; get; }
        public float SalesQty { set; get; }
        public float SalesRate { set; get; }
        public float ClosingQty { set; get; }
        public float ClosingRate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public string Supplier { set; get; }
        public string SupplierName { set; get; }
        public string StoreID { set; get; }
        public string StoreName { set; get; }
        public DateTime DT { set; get; }
    }
}
