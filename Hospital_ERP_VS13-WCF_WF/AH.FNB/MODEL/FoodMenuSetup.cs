using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
    public class FoodMenuSetup
    {
        public string MenuID { set; get; }
        public string MenuName { set; get; }
        public string Remarks { set; get; }
        public double Rate { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
