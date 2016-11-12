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
    public class PayrollReportBLL
    {
        public List<PayrollRO> GetPayrollDetailsRO(string Payroll = "", string DeptGrp = "", string dept = "", string Unit = "", string Month = "")
        {
            return new PayrollReportDAL().GetPayrollDetailsRO(Payroll, DeptGrp, dept, Unit,Month);
        }
        public List<PayrollRO> GetSalaryStatementForBank(string month)
        {
            return new PayrollReportDAL().GetSalaryStatementForBank(month);
        }
        public List<PayrollRO> GetPaySlip(string Month,string EmpId)
        {
            return new PayrollReportDAL().GetPaySlip(Month, EmpId);
        }
        public List<PayrollRO> GetEmployeeUnderSalary()
        {
            return new PayrollReportDAL().GetEmployeeUnderSalary();
        }
        public List<PayrollRO> GetAccountsPart(string month)
        {
            return new PayrollReportDAL().GetAccountsPart(month);
        }
    }
}
