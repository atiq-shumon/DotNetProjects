using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AH.HR.MODEL;
using AH.Shared.MODEL;

namespace AH.ACCMS.MODEL
{
    public class DepartmentRevenueHead
    {
        public Department Department { set; get; }
        public RevenueHead RevenueHead { set; get; }
        public RevenueHeadGroup RevenueHeadGroup { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
