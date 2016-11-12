using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class Warehouse
    {
        public string TypeID { set; get; }
        public string ToTypeID { set; get; }
        public string TypeName { set; get; }
        public string ToTypeName { set; get; }
        public string TypeNameBangla { set; get; }
        public string Remarks { set; get; }
        public char Active { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
