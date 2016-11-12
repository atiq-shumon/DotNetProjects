using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class PODetailsRO
    {
        public string POID { set; get; }
        public string PRID { set; get; }
        public string StoreID { set; get; }
        public string StoreName { set; get; }
        public string TransactionType { set; get; }
        public DateTime PODATE { set; get; }
        public DateTime DeliveryDate { set; get; }
        public string DeliveryNote { set; get; }
        public string POTYPE { set; get; }
        public string SupplierID { set; get; }
        public string SupplierName { set; get; }
        public string SupplierAddress { set; get; }
        public string SupplierPhone { set; get; }
        public string SupplierFax { set; get; }
        public string ItemID { set; get; }
        public string ItemName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string TypeID { set; get; }
        public string TypeName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public float RequisitionQty { set; get; }
        public float POQty { set; get; }
        public float RemainingQty { set; get; }
        public float ReturnQty { set; get; }
        public string CompleteFlag { set; get; }
        public string Remarks { set; get; }
        public string Entry_By_Name { set; get; }
    }
}
