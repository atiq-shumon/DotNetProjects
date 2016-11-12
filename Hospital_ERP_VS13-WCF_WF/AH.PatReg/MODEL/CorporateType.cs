using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PatReg.MODEL
{
    public class CorporateType
    {
        public string CorpID { set; get; }
        public string CorpTypeID { set; get; }
        public string CorpTitle { set; get; }
        public string CorpTitleBeng { set; get; }
        public string CorpAddress { set; get; }  
        public string CorpWeb { set; get; }
        public string CorpEmail { set; get; }
        public string CorpPhone { set; get; }  
        public string CorpMobile { set; get; }  
        public EntryParameter EntryParameter { set; get; }
    }
}
