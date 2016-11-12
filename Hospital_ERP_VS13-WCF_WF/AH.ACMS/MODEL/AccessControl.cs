using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class AccessControl
    {
        public User User { get; set; }
        public Module Module { set; get; }
        public UserGroup UserGroup { set; get; }
        public Object Object { set; get; }
        public ObjectSetup ObjectSetup { set; get; }
        public int AuthenticationLevel { get; set;}
        public string AuthLevel { get; set; }
        public string ErrorMessage { get; set; }
        public string Remarks { get; set; }
        public EntryParameter EntryParameter { get; set; }
    }
}
