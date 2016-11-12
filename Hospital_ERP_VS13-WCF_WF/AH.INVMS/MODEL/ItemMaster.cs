using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class ItemMaster
    {
        public CompanySetup Company { set; get; }
        public GroupDetails GroupDetails { set; get; }
        public Units Units { set; get; }
        public PacketType PacketType { set; get; }
        public ModelSetup ModelSetup { set; get; }
        public BrandSetup BrandSetup { set; get; }
        public Majorgroup Majorgroup { set; get; }
        public Supplier Supplier { set; get; }        
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string Remarks { set; get; }
        public DateTime Day { set; get; }
        public string PODate { set; get; }
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
        public Warehouse Warehouse { set; get; }
        public StoreTypeSCM StoreType { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
