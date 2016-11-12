using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;

namespace AH.HR.DAL
{
    public class HolidaySetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region SaveHolidayType
        public short SaveHolidayType(HolidayType oHolidayType)
        {
            packagename = "PKG_HOLIDAY_SETUP.INSERT_HOLIDAY_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oHolidayType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_type_title",OracleDbType.Varchar2,100,oHolidayType.TypeTitle,ParameterDirection.Input),
                new OracleParameter("p_type_title_beng",OracleDbType.Varchar2,100,oHolidayType.TypeTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_weekly",OracleDbType.Varchar2,1,oHolidayType.Weekly,ParameterDirection.Input),
                new OracleParameter("p_monthly",OracleDbType.Varchar2,1,oHolidayType.Monthly,ParameterDirection.Input),               
                new OracleParameter("p_yearly",OracleDbType.Varchar2,1,oHolidayType.Yearly,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oHolidayType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oHolidayType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oHolidayType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oHolidayType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oHolidayType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateLHolidayType

        public short UpdateLHolidayType(HolidayType oHolidayType)
        {
            packagename = "PKG_HOLIDAY_SETUP.UPDATE_HOLIDAY_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oHolidayType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_type_title",OracleDbType.Varchar2,100,oHolidayType.TypeTitle,ParameterDirection.Input),
                new OracleParameter("p_type_title_beng",OracleDbType.Varchar2,100,oHolidayType.TypeTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_weekly",OracleDbType.Varchar2,1,oHolidayType.Weekly,ParameterDirection.Input),
                new OracleParameter("p_monthly",OracleDbType.Varchar2,1,oHolidayType.Monthly,ParameterDirection.Input),               
                new OracleParameter("p_yearly",OracleDbType.Varchar2,1,oHolidayType.Yearly,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oHolidayType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oHolidayType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oHolidayType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oHolidayType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oHolidayType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetHolidayType
        public List<HolidayType> GetHolidayType()
        {
            string packageName = "PKG_HOLIDAY_SETUP.GET_HOLIDAY_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetHolidayTypeDetails(packageName, parameterList);
        }
        private List<HolidayType> GetHolidayTypeDetails(string packageName, OracleParameter[] parameterList)
        {
            List<HolidayType> oHolidayTypes = new List<HolidayType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                HolidayType oHolidayType = new HolidayType();
                oHolidayType.TypeID = (String)rdr["TYPE_ID"].ToString();
                oHolidayType.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                oHolidayType.TypeTitleBeng = (String)rdr["TYPE_TITLE_BENGALI"].ToString();
                oHolidayType.Weekly = (String)rdr["WEEKLY"].ToString();
                oHolidayType.Monthly = (String)rdr["MONTHLY"].ToString();
                oHolidayType.Yearly = (String)rdr["YEARLY"].ToString();
                oHolidayTypes.Add(oHolidayType);
            }
            rdr.Close();
            return oHolidayTypes;
        }
        #endregion

        #region SaveHolidayName
        public short SaveHolidayName(HolidayName oHolidayName)
        {
            packagename = "PKG_HOLIDAY_SETUP.INSERT_HOLIDAY_NAME";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oHolidayName.HolidayType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_name_id",OracleDbType.Varchar2,4,oHolidayName.NameID,ParameterDirection.Input),
                new OracleParameter("p_name_title",OracleDbType.Varchar2,100,oHolidayName.NameTitle,ParameterDirection.Input),
                new OracleParameter("p_name_title_beng",OracleDbType.Varchar2,100,oHolidayName.NameTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oHolidayName.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oHolidayName.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oHolidayName.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oHolidayName.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oHolidayName.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateLHolidayName

        public short UpdateLHolidayName(HolidayName oHolidayName)
        {
            packagename = "PKG_HOLIDAY_SETUP.UPDATE_HOLIDAY_NAME";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oHolidayName.HolidayType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_name_id",OracleDbType.Varchar2,4,oHolidayName.NameID,ParameterDirection.Input),
                new OracleParameter("p_name_title",OracleDbType.Varchar2,100,oHolidayName.NameTitle,ParameterDirection.Input),
                new OracleParameter("p_name_title_beng",OracleDbType.Varchar2,100,oHolidayName.NameTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oHolidayName.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oHolidayName.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oHolidayName.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oHolidayName.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oHolidayName.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetHolidayName
        public List<HolidayName> GetHoliday()
        {
            string packageName = "PKG_HOLIDAY_SETUP.GET_HOLIDAY_NAME";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetHolidayNameDetails(packageName, parameterList);
        }
        public List<HolidayName> GetHolidayName(string Type)
        {
            string packageName = "PKG_HOLIDAY_SETUP.GET_HOLIDAY_NAME";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,Type,ParameterDirection.Input)
           };

            return GetHolidayNameDetails(packageName, parameterList);
        }
        private List<HolidayName> GetHolidayNameDetails(string packageName, OracleParameter[] parameterList)
        {
            List<HolidayName> oHolidayNames = new List<HolidayName>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                HolidayName oHolidayName = new HolidayName();

                HolidayType oHolidayType = new HolidayType();
                oHolidayType.TypeID = (String)rdr["TYPE_ID"].ToString();
                oHolidayName.HolidayType = oHolidayType;

                oHolidayName.NameID = (String)rdr["NAME_ID"].ToString();
                oHolidayName.NameTitle = (String)rdr["NAME_TITLE"].ToString();
                oHolidayName.NameTitleBeng = (String)rdr["NAME_TITLE_BENGALI"].ToString();
                oHolidayNames.Add(oHolidayName);
            }
            rdr.Close();
            return oHolidayNames;
        }
        #endregion

        #region SaveHolidayCalender
        public short SaveHolidayCalender(HolidayCalender oHolidayCalender)
        {
            packagename = "PKG_HOLIDAY_SETUP.INSERT_HOLIDAY_CALENDER";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oHolidayCalender.Year,ParameterDirection.Input),
                new OracleParameter("p_holiday_date",OracleDbType.Varchar2,100,oHolidayCalender.HolidayDate,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,100,oHolidayCalender.HolidayType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_name_id",OracleDbType.Varchar2,100,oHolidayCalender.HolidayName.NameID,ParameterDirection.Input),
                new OracleParameter("p_is_depends_on_moon",OracleDbType.Varchar2,100,oHolidayCalender.IsDependsOnMoon,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oHolidayCalender.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oHolidayCalender.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oHolidayCalender.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oHolidayCalender.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oHolidayCalender.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateHolidayCalender
        public short UpdateHolidayCalender(HolidayCalender oHolidayCalender)
        {
            packagename = "PKG_HOLIDAY_SETUP.UPDATE_HOLIDAY_CALENDER";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oHolidayCalender.Year,ParameterDirection.Input),
                new OracleParameter("p_holiday_date",OracleDbType.Varchar2,100,oHolidayCalender.HolidayDate,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,100,oHolidayCalender.HolidayType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_name_id",OracleDbType.Varchar2,100,oHolidayCalender.HolidayName.NameID,ParameterDirection.Input),
                new OracleParameter("p_is_depends_on_moon",OracleDbType.Varchar2,100,oHolidayCalender.IsDependsOnMoon,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oHolidayCalender.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oHolidayCalender.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oHolidayCalender.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oHolidayCalender.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oHolidayCalender.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetHolidayCalender      
        public List<HolidayCalender> GetHolidayCalender(string Year, string Type)
        {
            string packageName = "PKG_HOLIDAY_SETUP.GET_HOLIDAY_CALENDER";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,Year,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,Type,ParameterDirection.Input)
           };

            return GetHolidayCalenderDetails(packageName, parameterList);
        }
        private List<HolidayCalender> GetHolidayCalenderDetails(string packageName, OracleParameter[] parameterList)
        {
            List<HolidayCalender> oHolidayCalenders = new List<HolidayCalender>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                HolidayCalender oHolidayCalender = new HolidayCalender();

                oHolidayCalender.Year = rdr["YEAR"].ToString();
                HolidayType oHolidayType = new HolidayType();
                oHolidayType.TypeID = (String)rdr["H_TYPE_ID"].ToString();
                oHolidayType.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                oHolidayCalender.HolidayType = oHolidayType;

                HolidayName oHolidayName = new HolidayName();
                oHolidayName.NameID = (String)rdr["H_DAY_TITLE_ID"].ToString();
                oHolidayName.NameTitle = (String)rdr["NAME_TITLE"].ToString();
                oHolidayCalender.HolidayName = oHolidayName;

                oHolidayCalender.HolidayDate =((DateTime)(rdr["H_DATE"])).ToString("dd/MM/yyyy");
                oHolidayCalender.IsDependsOnMoon = (String)rdr["IS_DEPENDS_ON_MOON"].ToString();

                oHolidayCalenders.Add(oHolidayCalender);
            }
            rdr.Close();
            return oHolidayCalenders;
        }
        #endregion

        #region GetHolidayCalenderForReport
        public List<HolidayCalenderRO> GetHolidayCalenderForReport(string Year)
        {
            string packageName = "PKG_HOLIDAY_SETUP.GET_HOLIDAY_CALENDER";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,Year,ParameterDirection.Input)
           };

            return GetHolidayCalenderForReportDet(packageName, parameterList);
        }
        private List<HolidayCalenderRO> GetHolidayCalenderForReportDet(string packageName, OracleParameter[] parameterList)
        {
            List<HolidayCalenderRO> oHolidayCalenders = new List<HolidayCalenderRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                HolidayCalenderRO oHolidayCalender = new HolidayCalenderRO();

                oHolidayCalender.Year = rdr["YEAR"].ToString();
                oHolidayCalender.HolidayDate = ((DateTime)(rdr["H_DATE"])).ToString("dd/MM/yyyy");
                oHolidayCalender.TypeID = (String)rdr["H_TYPE_ID"].ToString();
                oHolidayCalender.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                oHolidayCalender.NameID = (String)rdr["H_DAY_TITLE_ID"].ToString();
                oHolidayCalender.NameTitle = (String)rdr["NAME_TITLE"].ToString();
                oHolidayCalender.Day = (String)rdr["Day"].ToString();
                oHolidayCalender.IsDependendsOnMoon = (String)rdr["IS_DEPENDS_ON_MOON"].ToString();

                oHolidayCalenders.Add(oHolidayCalender);
            }
            rdr.Close();
            return oHolidayCalenders;
        }
        #endregion
    }
}
