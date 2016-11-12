using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class MaterialReceiveRO
    {
        public string MRRID { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string PackageType { set; get; }
        public string UnitID { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string SupplierName { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public float Quantity { set; get; }
        public string TransactionType { set; get; }
        public DateTime Day { set; get; }
        public DateTime MRRDATE { set; get; }
        public DateTime ExpireDate { set; get; }
        public string BatchNo { set; get; }
    }
}
