using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PatReg.MODEL
{
    public class StaffType
    {
        public string TypeID { set; get; }
        public string TypeTitle { set; get; }
        public string TypeTitleBeng { set; get; }
        public string Remarks { set; get; }  
        public EntryParameter EntryParameter { set; get; }
    }
}
