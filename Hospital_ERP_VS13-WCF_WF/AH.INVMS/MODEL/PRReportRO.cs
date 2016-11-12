using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class PRReportRO
    {
        public string PRID { set; get; }
        public DateTime PRDATE { set; get; }
        public string STOREID { set; get; }
        public string STORENAME { set; get; }
        public string ItemID { set; get; }
        public string ItemName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string TypeID { set; get; }
        public string TypeName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public string STORETYPEID { set; get; }
        public string STORETYPENAME { set; get; }
        public string MAJORGROUPID { set; get; }
        public string MAJORGROUPNAME { set; get; }
        public string Remarks { set; get; }
        public float Qty { set; get; }
        public float LPQTY { set; get; }
        public float LPRATE { set; get; }
        public string LPDATE { set; get; }
        public float CURRENTSTOCK { set; get; }
        public string EntryBy { set; get; }
        public string EntryByName { set; get; }
    }
}
