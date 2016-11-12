using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PHRMS.MODEL
{
    public class MrrReportRO
    {
        public string MRRID { set; get; }
        public DateTime MRRDATE { set; get; }
        public string PharmacyID { set; get; }
        public string PharmacyName { set; get; }
        public string PRNO { set; get; }
        public DateTime PRDATE { set; get; }
        public string POID { set; get; }
        public DateTime PODATE { set; get; }
        public string ChallanNo { set; get; }
        public DateTime ChallanDate { set; get; }
        public string VoucherNo { set; get; }
        public string SupplierID { set; get; }
        public string SupplierName { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string TypeID { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public float Quantity { set; get; }
        public float RequisitionQty { set; get; }
        public float POQty { set; get; }
        public string TransactionType { set; get; }
        public DateTime Day { set; get; }
        public string EntryBy { set; get; }
        public string Entry_By_Name { set; get; }

    }
}
