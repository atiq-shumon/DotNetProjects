using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.INVMS.DAL;

namespace AH.INVMS.BLL
{
    public class DayCloseBLL
    {
        public short StartDayClose(DayEnd odayclose)
        {
            return new DayCloseDAL().StartDayClose(odayclose);
        }
        public int VerifyDate(string strid, DateTime day)
        {
            return new DayCloseDAL().VerifyDate(strid,day);
        }
    }
}
