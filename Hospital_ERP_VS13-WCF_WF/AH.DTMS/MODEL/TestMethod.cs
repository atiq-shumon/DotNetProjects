using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
namespace AH.DTMS.MODEL
{
    public class TestMethod
    {
        public string MethodID { set; get; }
        public string MethodTitle { set; get; }
        public string MethodTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
