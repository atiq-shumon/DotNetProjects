using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class Inventory
    {
        public string MrrNo { set; get; }
        public string MrrDate { set; get; }
        public int intVtype { set; get; }
        public string strString { set; get; }
        public string CatID { set; get; }
        public string CatName { set; get; }
        public string FoodID { set; get; }
        public string FoodName { set; get; }
        public double dblopnqty  { set; get; }
        public double dblTranqty { set; get; }
        public double dblClosingQty { set; get; }
        public double dblTranRate { set; get; }
        public double dblOutwardQty { set; get; }
        public double dblInwardQty { set; get; }
        public double dbldamageQty { set; get; }
        public double dblNetQty { set; get; }
        public double dblNetAmount { set; get; }
        public double dblReceivedQnty { set; get; }
        public string PostStatus { set; get; }
        public string IssueRefNo { set; get; }

        public EntryParameter EntryParameter { set; get; }
    }
}
