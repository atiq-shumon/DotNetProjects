using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.APMS.MODEL
{
    public class DoctorWeekDays
    {
        public Department Department { get; set; }
        public DepartmentUnit DepartmentUnit { get; set; }
        public Doctor Doctor { get; set; }
        public string WeekDayNO { get; set; }
        public string WeekDayName { get; set; }
        public string StartDate { get; set; }
        public DateTime VisitDate { get; set; }
        public string LastDate {get;set;}
        public string DoctorTiming { get; set; }
        public int Interval { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ServiceId { get; set; }
       // public int Flag { get; set; }
        public EntryParameter EntryParameter { set; get; }
    }
}
