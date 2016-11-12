using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class StockReportGroupwiseRO
    {
        public string Itemid { set; get; }
        public string ItemName { set; get; }
        public string MinorGroupID { set; get; }
        public string MinorGroupName { set; get; }
        public string MajorGroupID { set; get; }
        public string MajorGroupName { set; get; }
        public float Stock { set; get; }
        public string BatchNo { set; get; }
        public DateTime ExpireDate { set; get; }
        public DateTime MrrDate { set; get; }
        public string SupplierID { set; get; }
        public string SupplierName { set; get; }
        public float PuchaseRate { set; get; }
        public float SalesRate { set; get; }
        public string GRNNO { set; get; }
        public float StockValue { set; get; }
    }
}
