using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ATMS.MODEL
{
    public class AssetsUser
    {
        public string DepID { set; get; }
        public string DepName { set; get; }
        public string Prefix { set; get; }
        public string UserId { set; get; }
        public string UserName { set; get; }
        public string formName { set; get; }
        public long  UserNo { set; get; }
        public string  LaetNo { set; get; }
        public int  intStatus { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
