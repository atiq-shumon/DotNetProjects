using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACCMS.MODEL;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class PurchaseRequisition
    {
        public string ID { set; get; }
        public string TransactionType { set; get; }
        public DateTime RequisitionDate { set; get; }
        public DateTime DeliveryDate { set; get; }
        public string Priority { set; get; }
        public string RequisitionType { set; get; }
        public string RequisitionBy { set; get; }
        public string RequisitionByName { set; get; }
        public string Remarks { set; get; }
        public string PrDetails { set; get; }
        public string AlterPrDetails { set; get; }
        public float RequisitionQty { set; get; }
        public float RemainingQty { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public CostCategoryTreeview CostCategoryTreeview { set; get; }
        public ItemMaster ItemMaster { set; get; }
        public Department Department { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public Warehouse Warehouse { set; get; }
        public StoreTypeSCM StoreType { set; get; }
        public DemandRequisition DemandRequisition { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
