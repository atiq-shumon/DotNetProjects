using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class WeeklyDietSetup
    {
        public string DietMenuID { set; get; }
        public string DietSubID { set; get; }
        public string DietSubMenuName { set; get; }
        public string DietTypeID { set; get; }
        public string DietTypeMenuName { set; get; }
        public string DietName { set; get; }
        public string WeeklyDietMenu { set; get; }
        public string WeekDayNo { set; get; }
        public string WeekDayName { set; get; }
        public string DietTime { set; get; }
        public EntryParameter EntryParameter { set; get; }


    }
}
