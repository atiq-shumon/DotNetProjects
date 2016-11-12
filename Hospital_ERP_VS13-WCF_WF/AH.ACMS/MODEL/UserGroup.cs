using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class UserGroup
    {
        public string GroupID { get; set; }
        public string GroupTitle { get; set; }
        public string GroupTitleBang { get; set; }
        public string Remarks { get; set; }
        public EntryParameter EntryParameter { get; set; }
        public string Date { get; set; }
    }
}
