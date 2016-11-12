using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class SalesReportRO
    {
        public string Issue_id { set; get; }
        public string Str_id { set; get; }
        public string StoreTitle { set; get; }
        public string DRID { set; get; }
        public string DeptID { set; get; }
        public string DeptName { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string ItemGroup { set; get; }
        public string ItemType { set; get; }
        public string ItemUnit { set; get; }
        public string ItemName { set; get; }
        public string ItemCompany { set; get; }
        public string ItemBrand { set; get; }
        public string ItemModel { set; get; }
        public float ReqQty { set; get; }
        public float IssueQty { set; get; }
        public float Qty_Over_Pres { set; get; }
        public float Urate { set; get; }
        public float Vat { set; get; }
        public float Disc { set; get; }       
        public string EntryBy { set; get; }
        public string ENTRY_BY_NAME { set; get; }
        public DateTime EntryDate { set; get; }
    }
}
