using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;

namespace AH.PHRMS.MODEL
{
    public class ItemsOrder
    {
        public DrugMaster DrugMaster { set; get; }
        public string Brand { set; get; }
        public string Model { set; get; }
        public string PurchaseBy { set; get; }
        public float RemQty { set; get; }
        public float URate { set; get; }
        public float VAT { set; get; }
        public float Discount { set; get; }
        public float RackRate { set; get; }
        public float SlRate { set; get; }
        public float PRQty { set; get; }
        public float POQty { set; get; }
        public float PendQty { set; get; }
        public float UsdQty { set; get; }
        public float RetQty { set; get; }
    }
}
