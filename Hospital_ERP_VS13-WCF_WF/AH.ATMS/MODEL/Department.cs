using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ATMS.MODEL
{
   public class Department
    {
        public string DepID { get; set; }
        public string DepName { get; set; }
        public string Remarks { get; set; }
        public string FormName { get; set; }
        public int intMode { get; set; }
        public EntryParameter EntryParameter { set; get; }
    }
}
