using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class FeeCategory
    {
        public string FeeCategoryID { set; get; }
        public string FeeCategoryTitle { set; get; }
        public string FeeCategoryTitleBeng { set; get; }
        public string FeeCategoryRemarks { set; get; }
        public EntryParameter EParameter { set; get; }
    }
}
