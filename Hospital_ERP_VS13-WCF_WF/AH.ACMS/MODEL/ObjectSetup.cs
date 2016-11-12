using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class ObjectSetup
    {
        public Module Module { set; get; }
        public string ObjSerial { get; set; }
        public string ObjID { get; set; }
        public string ObjName { get; set; }
        public string ObjType { get; set; }
        public string AuthenticationLevel { get; set; }
        public EntryParameter EntryParameter { get; set; }
    }
    
}
