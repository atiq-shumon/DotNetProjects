using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.FNB.MODEL
{
   public class SetmenuItem
    {

        public string MrrNo { set; get; }
        public string MrrDate { set; get; }
        public string SupplierId { set; get; }
        public string SupplierName { set; get; }
        public string AgainstRefNo { set; get; }
        public string Notes { set; get; }
        public string Status { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public string Unitcode { set; get; }
        public string UnitName { set; get; }
        public double Quantity { set; get; }
        public double Rate { set; get; }
        public double NetAmount { set; get; }
        public string Groupcode { set; get; }
        public string GroupName { set; get; }
        public EntryParameter EntryParameter { set; get; }



    }
}
