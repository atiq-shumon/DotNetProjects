using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.HR.DAL;
using AH.Shared.MODEL;


namespace AH.HR.BLL
{
    public class HolidaySetupBLL
    {
        public short SaveHolidayType(HolidayType oHolidayType)
        {
            return new HolidaySetupDAL().SaveHolidayType(oHolidayType);
        }
        public short UpdateLHolidayType(HolidayType oHolidayType)
        {
            return new HolidaySetupDAL().UpdateLHolidayType(oHolidayType);
        }
        public List<HolidayType> GetHolidayType()
        {
            return new HolidaySetupDAL().GetHolidayType();
        }
        public Dictionary<string, string> GetHolidayTypeDict(string type)
        {
            Dictionary<string, string> oHolidayDic = new Dictionary<string, string>();
            oHolidayDic.Add("", "--Select--");
            foreach (HolidayType oHoliday in new HolidaySetupDAL().GetHolidayType())
            {
                oHolidayDic.Add(oHoliday.TypeID, oHoliday.TypeTitle);
            }

            return oHolidayDic;
        }
        public short SaveHolidayName(HolidayName oHolidayName)
        {
            return new HolidaySetupDAL().SaveHolidayName(oHolidayName);
        }
        public short UpdateLHolidayName(HolidayName oHolidayName)
        {
            return new HolidaySetupDAL().UpdateLHolidayName(oHolidayName);
        }
        public List<HolidayName> GetHoliday()
        {
            return new HolidaySetupDAL().GetHoliday();
        }
        public List<HolidayName> GetHolidayName(string Type)
        {
            return new HolidaySetupDAL().GetHolidayName(Type);
        }
        public Dictionary<string, string> GetHolidayNameDict(string type)
        {
            Dictionary<string, string> oHolidayDic = new Dictionary<string, string>();
            oHolidayDic.Add("", "--Select--");
            foreach (HolidayName oHoliday in new HolidaySetupDAL().GetHolidayName(type))
            {
                oHolidayDic.Add(oHoliday.NameID, oHoliday.NameTitle);
            }

            return oHolidayDic;
        }       
        public short SaveHolidayCalender(HolidayCalender oHolidayCalender)
        {
            return new HolidaySetupDAL().SaveHolidayCalender(oHolidayCalender);
        }
        public short UpdateHolidayCalender(HolidayCalender oHolidayCalender)
        {
            return new HolidaySetupDAL().UpdateHolidayCalender(oHolidayCalender);
        }
        public List<HolidayCalender> GetHolidayCalender(string Year, string Type)
        {
            return new HolidaySetupDAL().GetHolidayCalender(Year, Type);
        }
        public List<HolidayCalenderRO> GetHolidayCalenderForReport(string Year)
        {
            return new HolidaySetupDAL().GetHolidayCalenderForReport(Year);
        }
    }
}
