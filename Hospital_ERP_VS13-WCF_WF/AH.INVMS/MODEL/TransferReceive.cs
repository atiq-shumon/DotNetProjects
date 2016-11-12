using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.INVMS.MODEL;

namespace AH.INVMS.MODEL
{
    public class TransferReceive
    {
        public string ID { set; get; }
        public DateTime TrrDate { set; get; }
        public string TrrType { set; get; }
        public string Remarks { set; get; }
        public string TrrDetails { set; get; }
        public TransferRequisition TransferRequisition { set; get; }
        public AH.INVMS.MODEL.MaterialReceive MaterialReceive { set; get; }
        public ItemMaster ItemMaster { set; get; }
        public DepartmentGroup DepartmentGroup { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Warehouse Warehouse { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
