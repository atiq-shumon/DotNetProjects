using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;
using AH.ACCMS.MODEL;
using AH.HR.MODEL;

namespace AH.INVMS.MODEL
{
    public class ItemIssue
    {
        public string ID { set; get; }
        public string IssueType { set; get; }
        public string BatchID { set; get; }
        public string ConsumptionID { set; get; }
        public string StockOverFlow { set; get; }
        public CostCategoryTreeview CostCategoryTreeview { set; get; }
        public string ReceivedBy { set; get; }
        public string TransactionType { set; get; }
        public string IssueDetails { set; get; }
        public string AssetTrackerSerialNo { set; get; }
        public string Remarks { set; get; }
        public string HCN { set; get; }
        public string Staff { set; get; }
        public string IRID { set; get; }
        public string Doctor { set; get; }
        public string PrescriptionNo { set; get; }
        public string RegID { set; get; }
        public float IssueQty { set; get; }
        public float ReturnQty { set; get; }
        public float CompareQty { set; get; }
        public ItemOrder ItemOrder { set; get; }
        public EmployeeMaster EmployeeMaster { set; get; }
        public DemandRequisition DemandRequisition { set; get; }
        public Warehouse Warehouse { set; get; }
        public DateTime IssueDate { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Bed Bed { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public StoreTypeSCM StoreTypeSCM { set; get; }
        public EntryParameter EntryParameter { set; get; }
       
    }
}
