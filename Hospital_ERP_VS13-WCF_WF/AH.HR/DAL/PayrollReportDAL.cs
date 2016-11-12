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
    
    public class PayrollReportDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

       #region GetPayrollReport
        public List<PayrollRO> GetPayrollDetailsRO(string Payroll="",string DeptGrp="",string dept="",string Unit="",string Month="")
        {
            string packageName = "Pkg_HRM_Reports.GET_PAYROLL_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Payroll,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input),
                new OracleParameter("p_dept",OracleDbType.Varchar2,30,dept,ParameterDirection.Input),
                new OracleParameter("p_unit",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,Month,ParameterDirection.Input)      
           };

            return GetPayrollD(packageName, parameterList);
        }
        public List<PayrollRO> GetSalaryStatementForBank(string month)
        {
            string packageName = "Pkg_HRM_Reports.GET_SALARY_STATEMENT_FOR_BANK";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,month,ParameterDirection.Input) 
           };

            return GetSalaryStatementDetails(packageName, parameterList);
        }
        public List<PayrollRO> GetPaySlip(string Month,string EmpId)
        {
            string packageName = "Pkg_HRM_Reports.GET_PAY_SLIP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,Month,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpId,ParameterDirection.Input)      
           };
            return GetPayrollD(packageName, parameterList);
        }
        public List<PayrollRO> GetEmployeeUnderSalary()
        {
            string packageName = "Pkg_HRM_Reports.Get_employee_under_salary";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetEmployeeUnderSalaryDetails(packageName, parameterList);
        }
        private List<PayrollRO> GetPayrollD(string packageName, OracleParameter[] parameterList)
        {
            List<PayrollRO> oPays = new List<PayrollRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PayrollRO oPay = new PayrollRO();
                oPay.EmpId = (String)rdr["EMP_ID"].ToString();
                oPay.EmpName = (String)rdr["NAME"].ToString();
                oPay.DeptGrpTitle = (String)rdr["DEPT_GRP_NAME"].ToString();
                oPay.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oPay.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oPay.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oPay.FormatDept = (String)rdr["FormatDept"].ToString();
                oPay.ScaleId = (String)rdr["scale_title"].ToString();
                oPay.GradeId = (String)rdr["grade_title"].ToString();
                oPay.WorkingDay= (string)rdr["WORKING_DAYS"].ToString();
                oPay.PresentDay = (string)rdr["PRESENT_DAYS"].ToString();
                oPay.TotalNoOfDay = (string)rdr["TOTAL_NO_DAYS"].ToString();
                oPay.TotalFriday = (string)rdr["TOTAL_FRIDAY"].ToString();
                oPay.TotalHoliday = (string)rdr["TOTAL_HOLIDAY"].ToString();
                oPay.LeaveDay = (string)rdr["LEAVE_DAYS"].ToString();
                oPay.LeaveWithPayDay = (string)rdr["LEAVE_WITH_PAY"].ToString();
                oPay.LeaveWithoutPayDay = (string)rdr["LEAVE_WITHOUT_PAY"].ToString();
                oPay.AbsentDay = (string)rdr["ABSENT_DAYS"].ToString();
                oPay.ProcessDate = Convert.ToDateTime((DateTime)rdr["PROCESS_DATE"]);                
                oPay.SalCycleId = (string)rdr["SAL_CYCLE_ID"].ToString();
                oPay.SalTypeId = (string)rdr["SAL_TYPE_ID"].ToString();
                oPay.GradeCOnsFlag = (string)rdr["GRADE_CONS_FLAG"].ToString();
                oPay.BankID = (string)rdr["BANK_ID"].ToString();
                oPay.BankTitle = (string)rdr["BANK_TITLE"].ToString();
                oPay.BankAcc = (string)rdr["BANK_ACCOUNT"].ToString();
                oPay.LockFlag = (string)rdr["LOCK_FLAG"].ToString();
                oPay.Basic = double.Parse(rdr["BASIC"].ToString());
                oPay.HouseRent = double.Parse(rdr["HOUSERENT"].ToString());
                oPay.Transport = double.Parse(rdr["TRANSPORT"].ToString());
                oPay.MobileBill = double.Parse(rdr["MOBILEBILL"].ToString());
                oPay.MedicalAllowance = double.Parse(rdr["MEDICALALLOWANCE"].ToString());
                oPay.Consolated = double.Parse(rdr["Consolated"].ToString());
                oPay.Overtime = double.Parse(rdr["OVERTIME"].ToString());
                oPay.Arear = double.Parse(rdr["Arear"].ToString());
                oPay.Others = double.Parse(rdr["Others"].ToString());
                oPay.IncomeTax = double.Parse(rdr["IncomeTax"].ToString());
                oPay.MobileBillDeduce = double.Parse(rdr["MobileBILLDeduce"].ToString());
                oPay.Lunch = double.Parse(rdr["Lunch"].ToString());
                oPay.ProvidentFund = double.Parse(rdr["ProvidentFund"].ToString());
                oPay.Advance = double.Parse(rdr["Advance"].ToString());
                oPay.Absent = double.Parse(rdr["Absent"].ToString());
                oPay.Cash = double.Parse(rdr["cash"].ToString());
                oPay.LeaveWithoutPay = double.Parse(rdr["LEAVEWITHOUTPAY"].ToString());
                oPay.Loan = double.Parse((rdr["Loan"]).ToString());
                oPay.OthersDed = double.Parse((rdr["OthersDed"]).ToString());
                oPay.Addition = double.Parse(rdr["addition"].ToString());
                oPay.Deduction = double.Parse(rdr["deduction"].ToString());
                oPay.GrossPay =double.Parse(rdr["gross_pay"].ToString());
                oPays.Add(oPay);
            }
            rdr.Close();
            return oPays;
        }
        private List<PayrollRO> GetEmployeeUnderSalaryDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PayrollRO> oPays = new List<PayrollRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PayrollRO oPay = new PayrollRO();
                oPay.EmpId = (String)rdr["EMP_ID"].ToString();
                oPay.EmpName = (String)rdr["NAME"].ToString();
                oPay.DeptGrpTitle = (String)rdr["DEPT_GRP_NAME"].ToString();
                oPay.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oPay.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oPay.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oPay.FormatDept = (String)rdr["FormatDept"].ToString();
                oPay.Addition = double.Parse(rdr["Addition"].ToString());
                oPay.Deduction = double.Parse(rdr["Deduction"].ToString());
                oPay.GrossPay = double.Parse(rdr["gross_pay"].ToString());
                oPays.Add(oPay);
            }
            rdr.Close();
            return oPays;
        }

        private List<PayrollRO> GetSalaryStatementDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PayrollRO> oPays = new List<PayrollRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PayrollRO oPay = new PayrollRO();
                oPay.EmpId = (String)rdr["EMP_ID"].ToString();
                oPay.EmpName = (String)rdr["NAME"].ToString();
                oPay.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oPay.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oPay.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oPay.FormatDept = (String)rdr["FormatDept"].ToString();
                oPay.SalCycleId = (string)rdr["SAL_CYCLE_ID"].ToString();
                oPay.BankAcc = (string)rdr["BNK_AC_NO"].ToString();
                oPay.GrossPay = double.Parse(rdr["gross_pay"].ToString());
                oPays.Add(oPay);
            }
            rdr.Close();
            return oPays;
        }
#endregion

        #region GetAccountsPart
        public List<PayrollRO> GetAccountsPart(string month)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_PAYROLL_FOR_ACCOUNTS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,month,ParameterDirection.Input) 
           };

            return GetAccountsPartDetails(packageName, parameterList);
        }

        private List<PayrollRO> GetAccountsPartDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PayrollRO> oPays = new List<PayrollRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PayrollRO oPay = new PayrollRO();
                oPay.Cash = Convert.ToDouble(rdr["v_gross"].ToString());
                oPay.Others = Convert.ToDouble(rdr["v_cash"].ToString());
                oPay.BankAmount = Convert.ToDouble(rdr["v_bank"].ToString());                                          
                oPays.Add(oPay);
            }
            rdr.Close();
            return oPays;
        }

        #endregion

    }
}
