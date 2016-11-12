using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class ProductLedgerRO
    {
        public string Transac { set; get; }
        public string Product { set; get; }
        public string ProductName { set; get; }
        public float Qty { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public string Supplier { set; get; }
        public string SupplierName { set; get; }
        public string Pharmacy { set; get; }
        public string PharmacyName { set; get; }
        public DateTime DT { set; get; }
    }
}
