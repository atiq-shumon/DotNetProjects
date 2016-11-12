using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PHRMS.DAL;
using AH.Shared.MODEL;
using AH.PHRMS.MODEL;

namespace AH.PHRMS.BLL
{
    public class DayCloseBLL
    {
        public short StartDayClose(DayEnd odayclose)
        {
            return new DayCloseDAL().StartDayClose(odayclose);
        }
        public int VerifyDate(string phrid, DateTime day)
        {
            return new DayCloseDAL().VerifyDate(phrid,day);
        }
    }
}
