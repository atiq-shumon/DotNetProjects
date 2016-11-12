using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.ATMS.MODEL
{
    public class InvGroups
    {
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public EntryParameter EntryParameter { set; get; }
    }
}
