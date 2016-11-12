using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.FNB.MODEL
{
   public class DailyCollectionRO
    {

       public DateTime  MealDate { set; get; }
       public string MealID { set; get; }
       public string CardNo { set; get; }
       public string MealName { set; get; }
       public string WeekDayNo { set; get; }
       public string WeekDayName { set; get; }
       public double BillAmount  { set; get; }
       public double BillSubsidy { set; get; }
       public double NetAmount { set; get; }
       public string userID { set; get; }

       public string strMealDate { set; get; }







    }
}
