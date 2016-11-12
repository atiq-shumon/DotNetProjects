using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.PHRMS.MODEL;
using AH.DRUGS.MODEL;
using AH.IPDShared.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PHRMS.DAL
{
    public class DRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region SaveDemandRequisition
        public string SaveDemandRequisition(DemandRequisition odr)
        {
            string packageName = "PKG_DR.SAVE_DR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,odr.ID,ParameterDirection.Output),
                new OracleParameter("PharmacyLocation",OracleDbType.Varchar2,2,odr.Pharmacy.PharmacyID,ParameterDirection.Input),                
                new OracleParameter("Supplier",OracleDbType.Varchar2,15,odr.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("DepartmentGroup",OracleDbType.Varchar2,5,odr.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,4,odr.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,4,odr.DepartmentUnit.UnitId,ParameterDirection.Input),                
                new OracleParameter("RequisitionDate",OracleDbType.Date,odr.RequisitionDate,ParameterDirection.Input),                
                new OracleParameter("RequisitionType",OracleDbType.Varchar2,1,odr.RequisitionType,ParameterDirection.Input),
                new OracleParameter("RequisitionBy",OracleDbType.Varchar2,30,odr.RequisitionBy,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,odr.Remarks,ParameterDirection.Input),
                new OracleParameter("RequisitionDetails",OracleDbType.Varchar2,32000,odr.DrDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion


    }
}
