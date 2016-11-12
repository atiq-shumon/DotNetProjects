using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class ItemListGrpStrWiseRO
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string Remarks { set; get; }
        public DateTime Day { set; get; }
        public int ReorderQty { set; get; }
        public int ReorderCycle { set; get; }
        public float StockQty { set; get; }
        public int Priority { set; get; }
        public int SerialPriority { set; get; }
        public string IsExpDate { set; get; }
        public string IsSerial { set; get; }
        public string IsBillable { set; get; }
        public string IsWarranty { set; get; }
        public float Urate { set; get; }
        public float VAT { set; get; }
        public float Discount { set; get; }
        public float Rackrate { set; get; }
        public float Slrate { set; get; }
        public string strTypeID { set; get; }
        public string TypeTitle { set; get; }
        public string MajorgrpID { set; get; }
        public string MajorgrpName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string GroupNameBeng { set; get; }
        public string PacketTypeID { set; get; }
        public string PacketTypeName { set; get; }
        public string PacketTypeNameBeng { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }

    }
}
