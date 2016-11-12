using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.DTMS.MODEL
{
    public class TestGroup
    {
        public string GroupId { set; get; }
        public string GroupTitle { set; get; }
        public string GroupTitleBeng { set; get; }
        public string Remarks { set; get; }
        public string Result { set; get; }
        public Department Department { set; get; }
        public EntryParameter EParameter { set; get; }

    }
}
