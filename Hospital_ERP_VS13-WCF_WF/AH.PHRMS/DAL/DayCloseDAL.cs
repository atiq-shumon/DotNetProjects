using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.OracleManager;
using AH.DUtility;
using AH.PHRMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace AH.PHRMS.DAL
{
    public class DayCloseDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region StartDayEnd
        public short StartDayClose(DayEnd odayclose)
        {
            string packageName = "PKG_DAY_CLOSE.GET_DAY_CLOSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,odayclose.Pharmacy.PharmacyID,ParameterDirection.Input),
                new OracleParameter("Date",OracleDbType.Date,odayclose.Date,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odayclose.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odayclose.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odayclose.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odayclose.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        public int VerifyDate(string phrid, DateTime day)
        {
            string packageName = "PKG_DAY_CLOSE.VERIFY_DATE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,phrid,ParameterDirection.Input),
                new OracleParameter("Date",OracleDbType.Date,day,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            int dclose = (int)(OracleDecimal)prm.Value;
            return dclose;
        }

    }
}
