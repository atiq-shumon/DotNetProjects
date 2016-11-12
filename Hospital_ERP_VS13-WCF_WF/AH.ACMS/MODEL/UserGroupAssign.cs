using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class UserGroupAssign
    {
        public Module Module { set; get; }
        public User User { set; get; }
        public UserGroup UserGroup { set; get; }
        public EntryParameter EntryParameter { get; set; }
        public string Date { set; get; }
        public string EmpIDs { get; set; }
    }
}
