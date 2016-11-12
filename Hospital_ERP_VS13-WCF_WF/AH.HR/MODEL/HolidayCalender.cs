using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.HR.MODEL
{
    public class HolidayCalender
    {
        public string Year { set; get; }
        public string HolidayDate { set; get; }
        public string IsDependsOnMoon { set; get; }
        public HolidayType HolidayType { set; get; }
        public HolidayName HolidayName { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
