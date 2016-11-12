using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.FNB.MODEL
{
    public class MealSetup
    {
        public string MealID { set; get; }
        public string MealName { set; get; }
        public string Remarks { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
