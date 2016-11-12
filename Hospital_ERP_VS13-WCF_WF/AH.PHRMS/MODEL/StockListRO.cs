using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PHRMS.MODEL
{
    public class StockListRO
    {
        public string DrugID { set; get; }
        public string DrugName { set; get; }
        public string DrugNameBangla { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string GroupNameBangla { set; get; }
        public string TypeID { set; get; }
        public string PackName { set; get; }
        public string PackNameBangla { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string UnitNameBangla { set; get; }
        public float Reorder_Qty { set; get; }
        public int Priority { set; get; }
        public int Serial_Priority { set; get; }
        public string Remarks { set; get; }
        public float Urate { set; get; }
        public float Vat { set; get; }
        public float Disc { set; get; }
        public float Rack_rate { set; get; }
        public float Sl_rate { set; get; }
        public string Phr_id { set; get; }
        public string PharmacyName { set; get; }
        public float Stock_Qty { set; get; }
    }
}
