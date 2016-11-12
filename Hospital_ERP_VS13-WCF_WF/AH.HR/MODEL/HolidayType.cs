using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class HolidayType
    {
        public string TypeID { set; get; }
        public string TypeTitle { set; get; }
        public string TypeTitleBeng { set; get; }
        public string Weekly { set; get; }
        public string Monthly { set; get; }
        public string Yearly { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
