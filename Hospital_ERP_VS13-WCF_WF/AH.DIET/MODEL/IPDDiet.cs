using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.FNB.MODEL;

namespace AH.DIET.MODEL
{
    public class IPDDiet
    {
        public string AdmissionID { set; get; }
        public string NurseStationID { set; get; }
        public string NurseStationTitle { set; get; }
        public string DietTypeID { set; get; }   
        public string DietTypeTitle { set; get; }
        public decimal Bill { set; get; }
        public DateTime DietDateTime { set; get; }
        public decimal Total { set; get; }
        public MealSetup MealSetup { set; get; } 
        public FoodItem FoodItem { set; get; }
        public EntryParameter EntryParameter { set; get; }
        
    }
}
