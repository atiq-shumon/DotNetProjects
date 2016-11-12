using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;

namespace AH.INVMS.MODEL
{
    public class IssueRequisition
    {
        public string ID { set; get; }
        public string IRType { set; get; }
        public DateTime IRDate { set; get; }
        public string ConsumptionID { set; get; }
        public string ConsumptionHeadID { set; get; }
        public string TransactionType { set; get; }
        public string RequisitionBy { set; get; }
        public string IRDetails { set; get; }
        public string Remarks { set; get; }
        public string EmpID { set; get; }
        public string HCN { set; get; }
        public string Staff { set; get; }
        public string RegID { set; get; }
        public float RequisitionQty { set; get; }
        public ItemIssue ItemIssue { set; get; }
        public ItemOrder ItemOrder { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Bed Bed { set; get; }
        public Stock Stock { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
