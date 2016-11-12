using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;
using AH.DRUGS.MODEL;
using AH.DTMS.MODEL;

namespace AH.NWMS.MODEL
{
    public class NWMSReceiveRequisition
    {
        public string RequisitionID {set; get;}
        public string RequisitionQty { set; get; }
        public string IssueQty { set; get; }
        public string ReturnQty { set; get; }
        public string RemainingQty { set; get; }
        public string ReceivedQty { set; get; }
        public string IssueDetails { set; get; }
        public string ReceiveStatus { set; get; }
        public string pharmacyID { set; get; }
        public string IssueID { set; get; }
        public string DiagMR { set; get; }
        public string DiagSecID { set; get; }
        public string DiagResultID { set; get; }
        public InPatient Patient { set; get; }
        public DrugDose Drugs { set; get; }
        public TestSub Tests { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
