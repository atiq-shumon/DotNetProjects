using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.DTMS.MODEL
{
    public class Qualitative
    {
        public string GroupID { set; get; }
        public string GroupTitle { set; get; }
        public string GroupTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
