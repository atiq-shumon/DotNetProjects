using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class TransferRequisition
    {
        public string ID { set; get; }
        public DateTime RequisitionDate { set; get; }
        public string Remarks { set; get; }
        public string TrDetails { set; get; }
        public float TrQty { set; get; }
        public float TrrQty { set; get; }
        public float StockQty { set; get; }
        public ItemMaster ItemMaster { set; get; }
        public DepartmentGroup DepartmentGroup { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Warehouse  Warehouse { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
