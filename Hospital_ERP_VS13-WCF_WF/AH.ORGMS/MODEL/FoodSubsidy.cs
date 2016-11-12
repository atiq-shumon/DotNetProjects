using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ORGMS.MODEL
{
    public class FoodSubsidy
    {
        public string Serial { set; get; }
        public string JobLevel { set; get; }
        public string Percent { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
