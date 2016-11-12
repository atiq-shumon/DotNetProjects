using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class FoodMenuItemSetup
    {
        public string FoodItemID { set; get; }
        public string FoodItemName { set; get; }
        public string FoodMenuID { set; get; }
        public string FoodMenuName { set; get; }
        public string FoodTypeID { set; get; }
        public string FoodTypeName { set; get; }
        public double  ItemRate { set; get; }
        public string Remarks { set; get; }
        
        public EntryParameter EntryParameter { set; get; }
    }
}
