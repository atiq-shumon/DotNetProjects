using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PHRMS.MODEL
{
    public class PharmacyUser
    {
        public string UserID { set; get; }
        public Warehouse Warehouse { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
