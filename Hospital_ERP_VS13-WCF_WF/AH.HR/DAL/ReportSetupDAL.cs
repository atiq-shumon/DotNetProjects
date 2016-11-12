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
    public class ReportSetupDAL
    {
         public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
         string packagename = string.Empty;

     #region GetAllDepartment
         public List<RptDepartment> GetRptDepartment()
         {
             string packageName = "Pkg_HRM_Reports.Get_Departments";
             OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

             return GetRptDept(packageName, parameterList);
         }
         public List<RptDepartment> GetDepartmentTree()
         {
             string packageName = "PKG_TREE_VIEW.GET_DEPT_TREE_VIEW";
             OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)             
           };

             return GetRptDept(packageName, parameterList);
         }
         private List<RptDepartment> GetRptDept(string packageName, OracleParameter[] parameterList)
         {
             List<RptDepartment> oDepts = new List<RptDepartment>();
             OracleDataReader rdr;
             rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
             while (rdr.Read())
             {
                 RptDepartment oDept = new RptDepartment();
                 oDept.Dept_id = (String)rdr["DEPT_ID"].ToString();
                 oDept.Dept_title = (String)rdr["DEPT_TITLE"].ToString();
                 oDept.Dept_grp = (string)rdr["GROUP_ID"].ToString();
                 oDept.Grp_title = rdr["GROUP_TITLE"].ToString();                
                 oDept.TypeID = (string)rdr["DEPT_TYPE"].ToString();
                 oDept.DeptType = (string)rdr["DEPT_TYPE_TITLE"].ToString();
                 oDept.UnitID = (string)rdr["UNIT_ID"].ToString();
                 oDept.UnitTitle = (string)rdr["UNIT_TITLE"].ToString();
                 oDepts.Add(oDept);
             }
             rdr.Close();
             return oDepts;
         }
 #endregion

     #region GetLeaveDays
         public List<RptLeaveDays> RptGetLeave(string oLvTpSet)
         {
             string packageName = "Pkg_HRM_Reports.GET_LEAVE_DAYS";
             OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oLvTpSet,ParameterDirection.Input)
           };

             return GetLeaveDaysSetup(packageName, parameterList);
         }


         private List<RptLeaveDays> GetLeaveDaysSetup(string packageName, OracleParameter[] parameterList)
         {
             List<RptLeaveDays> oLvdays = new List<RptLeaveDays>();
             OracleDataReader rdr;
             rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
             while (rdr.Read())
             {               
                 RptLeaveDays oLvTp = new RptLeaveDays();
                 oLvTp.TypeId= (String)rdr["TYPE_ID"].ToString();
                 oLvTp.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                 oLvTp.Days = Convert.ToInt32(rdr["DAYS"]).ToString();
                 oLvTp.Remarks = !rdr.IsDBNull(5) ? (String)rdr["REMARKS"].ToString() : "";
                 oLvTp.year=(String)rdr["YEAR"].ToString();
                 oLvdays.Add(oLvTp);
             }
             rdr.Close();
             return oLvdays;
         }
 #endregion
    }
}
