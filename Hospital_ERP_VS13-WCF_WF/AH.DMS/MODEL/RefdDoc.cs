using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DMS.MODEL
{
    public class RefdDoc
    {
        public RefdOrg RefdOrg { set; get; }
        public string DocID { set; get; }
        public string DocTitle { set; get; }
        public string DocTitleBeng { set; get; }
        public string DegreeLine { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Web { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
