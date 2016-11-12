using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ATMS.MODEL
{
    public class TermsandCondition
    {
        public string storeID { set; get; }
        public string storeName { set; get; }
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public char isAutoSelected { set; get; }
        public char isBold { set; get; }
        public string Remarks { set; get; }
        public char Priority { set; get; }
        public char Active { set; get; }

        public EntryParameter EntryParameter { set; get; }

    }
}
