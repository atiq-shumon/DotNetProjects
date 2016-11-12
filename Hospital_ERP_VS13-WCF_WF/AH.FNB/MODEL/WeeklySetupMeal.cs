using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class WeeklySetupMeal
    {
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public string WeekDayNo { set; get; }
        public string MealID { set; get; }
        public string MealName { set; get; }
        public string SetMenuID { set; get; }
        public string WeeklySetMenuTypeID { set; get; }
        public string WeeklySetMenuTypeName { set; get; }

        public string OldWeekDayNo { set; get; }
        public string OldSetMenuID { set; get; }
        public string OldMealID { set; get; }
        public string OldSetMenuTypeID { set; get; }


        public EntryParameter EntryParameter { set; get; }
    }
}
