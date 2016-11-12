using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;
using AH.ACCMS.MODEL;
using AH.Shared.MODEL;


namespace AH.PHRMS.MODEL
{
    public class DemandRequisition
    {
        public string ID { set; get; }
        public string TransactionType { set; get; }
        public DateTime RequisitionDate { set; get; }        
        public string RequisitionType { set; get; }
        public string RequisitionBy { set; get; }
        public string Remarks { set; get; }
        public string DrDetails { set; get; }
        public float RequisitionQty { set; get; }
        public float RemainingQty { set; get; }       
        public DrugMaster DrugMaster { set; get; }
        public DepartmentGroup DepartmentGroup { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Pharmacy Pharmacy { set; get; }
        public Supplier Supplier { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
