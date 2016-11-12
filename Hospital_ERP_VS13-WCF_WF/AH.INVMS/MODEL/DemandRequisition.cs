using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class DemandRequisition
    {
        public string ID { set; get; }
        public string TransactionType { set; get; }
        public string SerialNo { set; get; }
        public DateTime RequisitionDate { set; get; }
        public string RequisitionType { set; get; }
        public string RequisitionBy { set; get; }
        public string RequisitionByName { set; get; }
        public string VerifiedBy { set; get; }
        public string Remarks { set; get; }
        public string ReqDetails { set; get; }
        public float DemandQty { set; get; }
        public float RemainingQty { set; get; }
        public Warehouse Warehouse { set; get; }
        public ItemMaster ItemMaster { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public StoreTypeSCM StoreTypeSCM { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
