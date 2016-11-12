using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class IssueReturn
    {
        public string ID { set; get; }
        public ItemIssue ItemIssue { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public DateTime ReturnDate { set; get; }
        public string ReturnType { set; get; }
        public string ReturnFrom { set; get; }
        public string ReturnCause { set; get; }
        public string Remarks { set; get; }
        public string ReturnDetails { set; get; }
        public string AssetTrackerSerialNo { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
