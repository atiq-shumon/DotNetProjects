using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class ConsumerPurpose
    {
        public string PurposeID { set; get; }
        public string PurposeTitle { set; get; }
        public string Acc_code { set; get; }
        public string Remarks { set; get; }
        public string Priority { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
