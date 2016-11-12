using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AH.Shared.MODEL;

namespace AH.OPRMS.MODEL
{
    public class DoctorsCategory
    {
        public string empid { set; get; }
        public string assignId { set; get; }
        public string doctorscode { set; get; }
        public string doctorsName { set; get; }
        public string FixedKeyMaster { set; get; }
        public string CategoryName { set; get; } 
        public int assignmenttype { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
