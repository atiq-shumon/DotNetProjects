using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;

namespace AH.NWMS.MODEL
{
    public class NurseRequisition
    {
        public InPatient Patient { set; get; }
        public string tests { set; get; }
        public double testsNetFee { set; get; }
        public string drugs { set; get; }
        public string StoreID { set; get; }
        public string IssueDetails { set; get; }
        public string AccessoriesBill { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
