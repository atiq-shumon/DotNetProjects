using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class HolidayCalenderRO
    {
        public string Year { set; get; }
        public string TypeID { set; get; }
        public string TypeTitle { set; get; }
        public string NameID { set; get; }
        public string NameTitle { set; get; }
        public string HolidayDate { set; get; }
        public string Day { set; get; }
        public string IsDependendsOnMoon { set; get; }
    }
}
