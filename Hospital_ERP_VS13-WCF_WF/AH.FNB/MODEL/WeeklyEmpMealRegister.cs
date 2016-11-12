using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.FNB.MODEL
{
    public class WeeklyEmpMealRegister
    {
        public string MealDate { set; get; }
        public string WeekDayNo { set; get; }
        public string mealid { set; get; }
        public string mealName { set; get; }
        public string Setmenuid { set; get; }
        public string SetmenuItem { set; get; }
        public string empId { set; get; }

        public string MealRegID { set; get; }
        public double Bill { set; get; }
        public double subsidy { set; get; }

        public string Billrate { set; get; }
        public double NetAmount { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
