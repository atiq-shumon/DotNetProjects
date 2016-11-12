using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.INVMS.MODEL
{
    public class StoreUser
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public StoreLocation StoreLocation { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
