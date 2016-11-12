using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class StockListRO
    {
        public string ItemID { set; get; }
        public string ItemName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string TypeID { set; get; }
        public string TypeName { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float DISCOUNT { set; get; }
        public string STOREID { set; get; }
        public string StoreName { set; get; }
        public float STOCK { set; get; }
    }
}
