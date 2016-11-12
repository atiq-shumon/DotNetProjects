using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class TestCategory
    {
        public string TestCategoryID { set; get; }
        public string TestCategoryTitle { set; get; }
        public string TestCategoryTitleBeng { set; get; }
        public string TestCategoryRemarks { set; get; }
        public EntryParameter EParameter { set; get; }
    }
}
