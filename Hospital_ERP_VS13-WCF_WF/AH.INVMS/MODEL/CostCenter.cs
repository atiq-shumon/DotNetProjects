using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class CostCenter
    {
        public string CostCenterID { set; get; }
        public string CostCenterTitle { set; get; }
        public string Remarks { set; get; }
        public IssueType IssueType { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
