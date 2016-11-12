using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPRMS.MODEL
{
    public class OperationDetailsRO
    {
        public DateTime RegDate { set; get; }
        public string RegID { set; get; }
        public string PatinentName { set; get; }
        public string Sex { set; get; }
        public int OtStatus { set; get; }
        public string StartTime { set; get; }
        public string Endtime { set; get; }
        public EntryParameter EntryParameter { set; get; }
    
    }
}
