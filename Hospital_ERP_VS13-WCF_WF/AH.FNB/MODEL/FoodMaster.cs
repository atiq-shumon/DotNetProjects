using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class FoodMaster
    {
        public string FoodID { set; get; }
        public string FoodName { set; get; }
        public string CatID { set; get; }
        public string GrpID { set; get; }
        public string FoodImage { set; get; }
        public string UnitId { set; get; }
        public string IsNormal { set; get; }
        public string IsDiabetic { set; get; }
        public string IsHighprotein { set; get; }
        public string IsLowProtein { set; get; }
        public string IsRenal { set; get; }
        public string IsHighFat { set; get; }
        public string IsLowFat { set; get; }
        public double Price { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
