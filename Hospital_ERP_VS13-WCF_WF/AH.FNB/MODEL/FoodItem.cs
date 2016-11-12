using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.FNB.MODEL
{
    public  class FoodItem
    {
        public string ItemID { set; get; }
        public string ItemName { set; get; }
        public string FoodCatID { set; get; }
        public string DietCatID { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }


    }
}
