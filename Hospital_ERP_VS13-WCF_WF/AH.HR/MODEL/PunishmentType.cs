using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.HR.MODEL
{
    public class PunishmentType
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public string PunID { set; get; }
        public string PunTitle { set; get; }
        public string PunTitleBeng { set; get; }
        public string isAmount { set; get; }
        public string Serial { set; get; }
        public string Remarks { set; get; }
        public string Amount { set; get; }
        public string Duration { set; get; }
        public DateTime EffectiveDate { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
