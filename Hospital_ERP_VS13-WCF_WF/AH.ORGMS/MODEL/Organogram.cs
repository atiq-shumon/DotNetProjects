using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ORGMS.MODEL
{
    public class Organogram
    {
        public Department Department { set; get; }
        public Designation Designation { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public short NoOfPost { set; get; }
        public string DeptDesigString { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
