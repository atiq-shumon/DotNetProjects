using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ATMS.MODEL
{
    public class StoreType
    {
        public string strTypeID { set; get; }
        public string TypeTitle { set; get; }
        public string Remarks { set; get; }
        public char Active { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
