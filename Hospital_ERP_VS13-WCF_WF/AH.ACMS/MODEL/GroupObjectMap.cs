using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class GroupObjectMap
    {
        public Module Module { set; get; }
        public UserGroup UserGroup { set; get; }
        public Object Object { set; get; }
        public string AuthenticationLevel { get; set; }
        public string AuthLevID { get; set; }
        public EntryParameter EntryParameter { get; set; }
        public ObjectSetup ObjectSetup { set; get; }
    }
}
