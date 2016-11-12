using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.DRUGS.MODEL
{
    public class DrugDose
    {
        public DrugMaster DrugMaster { set; get; }
        public ConsumptionForm ConsumptionForm { set; get; }
        
        public string AgeGroup { set; get; }
        public string AgeGroupName { set; get; }
        public string DoseStr { set; get; }
        public string RouteID { set; get; }
        public string RouteName { set; get; }
        public char BeforeAfterMeal { set; get; }
        public string B_A_MealName { set; get; }
        public int MealTimeDuration { set; get; }
        public string M_T_DurationName { set; get; }
        public char MealID { set; get; }
        public string MealName { set; get; }
        public int MinUseDuration { set; get; }
        public char DurationIndicator { set; get; }
        public string Dur_Ind_Name { set; get; }
        public EntryParameter EntryParameter { set; get; }


        //public int DoseTimesID { get; set; }
        //public string DoseTimesInd { get; set; }
        //public string DoseRouteID { get; set; }

        //public int Duration { get; set; }
        //public string DurationInd { get; set; }
        public int Refills { get; set; }

        public string Coll_Status { get; set; }
        public string HourGap { get; set; }
        public string MealTimeGap { get; set; }

        public string MealTimeGapID { get; set; }

        //public string RouteID { get; set; }
        public string DoseConsQty { get; set; }
        public string DoseDrug { get; set; }

        public string DurationPeriod { get; set; }
        public string DurationContinue { get; set; }


        public string DrugDoseDetails { set; get; }


    }
}
