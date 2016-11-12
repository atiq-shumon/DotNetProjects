using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class TermsAndConditions
    {
       
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string IsAutoSelected { set; get; }
        public string IsBold { set; get; }
        public string Remarks { set; get; }
        public string Priority { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
