using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class ItemListRO
    {
        public string ItemID { set; get; }
        public string ItemName { set; get; }
        public string ItemNameBengali { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string GroupNameBengali { set; get; }
        public string TypeID { set; get; }
        public string TypeName { set; get; }
        public string TypeNameBengali { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public int ReorderQty { set; get; }
        public int Priority { set; get; }
        public int SerialPriority { set; get; }
        public string ISEXPREQ { set; get; }
        public string Remarks { set; get; }
        public float Rate { set; get; }
        public float VAT { set; get; }
        public float Discount { set; get; }
        public float RackRate { set; get; }
        public float SlRate { set; get; }
        public float Stock { set; get; }

        public string StoreTypeID { set; get; }

        public string StoreTypeTitle { set; get; }
    }
}
