using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.DTMS.MODEL
{
    public class TestMain
    {
        public string TestMainID { set; get; }
        public string TestMainTitle { set; get; }
        public string TestMainTitleBeng { set; get; }
        public TestGroup TestGroup { set; get; }
        public Department TestDepartment { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
