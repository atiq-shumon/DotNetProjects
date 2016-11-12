using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ORGMS.MODEL
{
    public class BankInfo
    {
        public string BankID { set; get; }
        public string BankTitle { set; get; }
        public string BankTitleBeng { set; get; }
        public string Serial { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
