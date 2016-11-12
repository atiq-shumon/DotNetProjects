using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class IssueReportRO
    {
        public string IssueId { set; get; }
        public string StoreID { set; get; }
        public string StoreName { set; get; }
        public string WarehouseID { set; get; }
        public string WarehouseName { set; get; }
        public string ItemGroup { set; get; }
        public string ItemType { set; get; }
        public string ItemUnit { set; get; }
        public string ItemName { set; get; }
        public string ItemCompany { set; get; }
        public string ModelName { set; get; }
        public string BrandName { set; get; }
        public float ReqQty { set; get; }
        public float Quantity { set; get; }
        public string IRID { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public string Hcn { set; get; }
        public string PatientName { set; get; }
        public string EntryBy { set; get; }
        public DateTime EntryDate { set; get; }
    }
}
