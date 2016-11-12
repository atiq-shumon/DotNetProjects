using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ATMS.MODEL
{
    public class WarehouseStoreRO
    {
        public string ItemCode { set; get; }
        public string ItemName { set; get; }
        public string UnitId { set; get; }
        public string UnitName { set; get; }
        public string WarehouseId { set; get; }
        public string WarehouseName { set; get; }
        public double  InwardQnty { set; get; }
        public double OutwardQnty { set; get; }
        public double ClosingQnty { set; get; }

    }
}
