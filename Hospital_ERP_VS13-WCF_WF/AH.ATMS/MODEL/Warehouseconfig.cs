using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL; 

namespace AH.ATMS.MODEL
{
    public class WarehouseConfig
    {
        public string Typeid { set; get; }
        public string TypeName { set; get; }
        public string Whid { set; get; }
        public string WhName { set; get; }
        public string WhNameBeng { set; get; }
        public string Remarks { set; get; }
        public char Active { set; get; }
        public string BuildID { set; get; }
        public string FloorNo { set; get; }
        public string BlockNo { set; get; }
        public string DepID { set; get; }
        public string UnitID { set; get; }
        public string NurseStationID { set; get; }
        public string CostCategoryID { set; get; }
        public string CostCenterID { set; get; }
        public string Contactperson { set; get; }
        public string phoneNo { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
