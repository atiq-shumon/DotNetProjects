using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class FringeBenefit
    {
        public string BenID { set; get; }
        public string BenTitle{set;get;}
        public string BenTitleBeng { set; get; }
        public string YMDBasis { set; get; }
        public string isAmount { set; get; }
        public string Serial { set; get; }
        public string Remarks { set; get; }
        public string Amount { set; get; }
        public DateTime EffectiveDate { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
