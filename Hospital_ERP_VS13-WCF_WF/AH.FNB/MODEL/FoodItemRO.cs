using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.FNB.MODEL
{
    public class FoodItemRO
    {
        public string FoodID { set; get; }
        public string FoodName { set; get; }
        public string CatName { set; get; }
        public string CatID { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public double NetPrice { set; get; }
        public EntryParameter EntryParameter { set; get; }


    }
}
