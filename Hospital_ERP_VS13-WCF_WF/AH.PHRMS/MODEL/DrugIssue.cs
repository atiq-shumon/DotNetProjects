using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.INVMS.MODEL;
using AH.ACCMS.MODEL;
using AH.DRUGS.MODEL;



namespace AH.PHRMS.MODEL
{
    public class DrugIssue
    {
        public string ID { set; get; }
        public string BatchID { set; get; }
        public string ConsumptionID { set; get; }
        public string ConsumptionHeadID { set; get; }
        public string RegID { set; get; }
        public string DRID { set; get; }
        public NurseDemandRequisition NurseDemandRequisition { set; get; } 
        public CostCategoryTreeview CostCategoryTreeview { set; get; }
        public string TransactionType { set; get; }
        public string IssueType { set; get; }
        public string ReceivedBy { set; get; }
        public string Remarks { set; get; }
        public string HCN { set; get; }
        public string TicketNo { set; get; }
        public string IssueString { set; get; }
        public string Staff { set; get; }
        public string Doctor { set; get; }
        public DrugMaster DrugMaster { set; get; }
        public float IssueQty { set; get; }
        public float ReturnQty { set; get; }
        public float CompareQty { set; get; }
        public OPDPayment PharmacyPayment { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public EmployeeMaster EmployeeMaster { set; get; }
        public DateTime IssueDate { set; get; }
        public Warehouse Warehouse { set; get; }
        public Pharmacy Pharmacy { set; get; }
        public PurchaseOrder PurchaseOrder { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
