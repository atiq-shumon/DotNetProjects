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
    public class LeaveReportDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region GetLeaveReport
        public List<LeaveRO> GetDeptWiseLeaveDetails(string Mode,string year,string DeptGrp,string Dept,string Unit)
        {
            string packageName = "Pkg_HRM_Reports.GET_DEPT_LEAVE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,5,Mode,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,5,year,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input),
                new OracleParameter("p_dept",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input) 
                
           };

            return GetLeaveD(packageName, parameterList);
        }
        public List<LeaveRO> GetEmployeeLeaveSummary(string Year, string Employee)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_EMPLOYEE_LEAVE_SUMMARY";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Int32,30,Year,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,Employee,ParameterDirection.Input)        
           };

            return GetLeaveD(packageName, parameterList);
        }
        private List<LeaveRO> GetLeaveD(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveRO> oLvs = new List<LeaveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveRO oLv = new LeaveRO();
                oLv.EmpId = (String)rdr["EMP_ID"].ToString();
                oLv.EmpName = (String)rdr["NAME"].ToString();
                oLv.DeptGrpID = (String)rdr["DEPT_GRP"].ToString();
                oLv.DeptGrpTitle = (String)rdr["DEPT_GRP_NAME"].ToString();
                oLv.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oLv.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oLv.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oLv.FormatDept = (String)rdr["FormatDept"].ToString(); 
                oLv.Casual = double.Parse(rdr["Casual"].ToString());
                oLv.Medical = double.Parse(rdr["Medical"].ToString());
                oLv.Earn = double.Parse(rdr["Earn"].ToString());
                oLv.Maternity = double.Parse(rdr["Maternity"].ToString());
                oLv.Paternity = double.Parse(rdr["Paternity"].ToString());
                oLv.Cas_enj = double.Parse(rdr["Cas_Enj"].ToString());
                oLv.Med_enj = double.Parse(rdr["Med_enj"].ToString());
                oLv.Ear_enj = double.Parse(rdr["Ear_Enj"].ToString());
                oLv.Mat_enj = double.Parse(rdr["Mat_enj"].ToString());
                oLv.Pat_enj = double.Parse(rdr["Pat_enj"].ToString());               
                oLvs.Add(oLv);
            }
            rdr.Close();
            return oLvs;
        }
 #endregion

        #region GetLeaveDetailsReport

        public List<LeaveRO> GetLeaveRegisterDetailsRO(string Emp, string year)
        {
            string packageName = "Pkg_HRM_Reports.GET_LEAVE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),              
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,Emp,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,5,year,ParameterDirection.Input)
           };

            return GetLeaveDetails(packageName, parameterList);

        }
        public List<LeaveRO> GetLeaveTemplateRO(string emp = "",string serial = "")
        {
            string packageName = "Pkg_HRM_Reports.GET_LEAVE_TEMPLATE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Int32,30,serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,emp,ParameterDirection.Input)              
           };
            return GetLeaveDetails(packageName, parameterList);
        }

        public List<LeaveRO> GetEmployeeLeaveDetails(string Year,string Employee)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_EMPLOYEE_LEAVE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Int32,30,Year,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,Employee,ParameterDirection.Input)              
           };
            return GetLeaveDetails(packageName, parameterList);
        }
        public List<LeaveRO> GetAllLeaveRequisition(string Mode,string Year, string DeptGroup,string Dept,string Unit)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_EMPLOYEE_LEAVE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input) ,
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input) ,
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)   
           };
            return GetLeaveDetails(packageName, parameterList);
        }

        private List<LeaveRO> GetLeaveDetails(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveRO> oLvs = new List<LeaveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
         
                LeaveRO oLv = new LeaveRO();
                oLv.EmpId = (String)rdr["EMP_ID"].ToString();
                oLv.EmpName = (String)rdr["NAME"].ToString();
                oLv.DeptGrpTitle = (String)rdr["DEPT_GRP_NAME"].ToString();
                oLv.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oLv.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oLv.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oLv.FormatDept = (String)rdr["FormatDept"].ToString();
                oLv.LeaveDays = double.Parse(rdr["LEAVE_DAYS"].ToString());
                oLv.WithPayDays = double.Parse(rdr["WITH_PAY_DAYS"].ToString());
                oLv.WithoutPayDays = double.Parse(rdr["WITHOUT_PAY_DAYS"].ToString());
                oLv.StartDate = Convert.ToDateTime((DateTime)rdr["LEAVE_S_DATE"]);
                oLv.EndDate = Convert.ToDateTime((DateTime)rdr["LEAVE_E_DATE"]);
                oLv.Serial = double.Parse(rdr["LEAVE_SERIAL"].ToString()); ;
                oLv.LeaveTypeId = (String)rdr["TYPE_TITLE"].ToString();
                oLv.Address = (String)rdr["ADDRESS_WHILE_ON_LEAVE"].ToString();
                oLv.LeaveCause = (String)rdr["LEAVE_CAUSE"].ToString();
                oLv.ResponsibilityHolderName = (String)rdr["RESPONSIBILITYHOLDERNAME"].ToString();
                
                oLvs.Add(oLv);
            }
            rdr.Close();
            return oLvs;
        }
        #endregion

        #region GetEmployeeLeaveDays
        public List<LeaveRO> GetEmployeeLeaveDays(string Year)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_EMPLOYEE_LEAVE_DAYS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Int32,30,Year,ParameterDirection.Input)    
           };

            return GetEmployeeLeaveDaysDet(packageName, parameterList);
        }
        private List<LeaveRO> GetEmployeeLeaveDaysDet(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveRO> oLvs = new List<LeaveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveRO oLv = new LeaveRO();
                oLv.Casual = double.Parse(rdr["Casual"].ToString());
                oLv.Medical = double.Parse(rdr["Medical"].ToString());
                oLv.Earn = double.Parse(rdr["Earn"].ToString());
                oLv.Maternity = double.Parse(rdr["Maternity"].ToString());
                oLv.Paternity = double.Parse(rdr["Paternity"].ToString());
                oLv.Cas_enj = double.Parse(rdr["Cas_Enj"].ToString());
                oLv.Med_enj = double.Parse(rdr["Med_enj"].ToString());
                oLv.Ear_enj = double.Parse(rdr["Ear_Enj"].ToString());
                oLv.Mat_enj = double.Parse(rdr["Mat_enj"].ToString());
                oLv.Pat_enj = double.Parse(rdr["Pat_enj"].ToString());    
                oLvs.Add(oLv);
            }
            rdr.Close();
            return oLvs;
        }
 #endregion

    }
}
