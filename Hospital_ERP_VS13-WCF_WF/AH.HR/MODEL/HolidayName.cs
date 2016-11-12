using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.HR.MODEL
{
    public class HolidayName
    {
        public HolidayType HolidayType { set; get; }
        public string NameID { set; get; }
        public string NameTitle { set; get; }
        public string NameTitleBeng { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
