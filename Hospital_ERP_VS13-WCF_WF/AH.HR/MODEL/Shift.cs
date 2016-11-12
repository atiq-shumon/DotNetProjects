using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class Shift
    {
        public string ShiftID { set; get; }
        public Department Department { set; get; }
        public DepartmentGroup DepartmentGroup { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public string ShiftTitle { set; get; }
        public string ShiftTitleBeng { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public string DutyDate { set; get; }
        public string ShiftTiming { set; get; }
        public string ShiftString { set; get; }
        public string Mode { set; get; }
        public EntryParameter EntryParameter { set; get; } 
    }
}
