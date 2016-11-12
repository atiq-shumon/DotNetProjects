using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class PayrollRO : Staff
    {
        public string EmpId { set; get; }
        public string Month { set; get; }
        public string EmpName { set; get; }
        public string DeptId { set; get; }
        public string DeptType { set; get; }
        public string DeptGrp { set; get; }
        public string DeptGrpTitle { set; get; }
        public string DeptTitle { set; get; }
        public string UnitId { set; get; }
        public string UnitTitle { set; get; }
        public string DesigId { set; get; }
        public string DesigTitle { set; get; }
        public string SalCycleId { set; get; }
        public string SalTypeId { set; get; }
        public string ScaleId { set; get; }
        public string GradeId { set; get; }
        public string ScaleTitle { set; get; }
        public string GradeTitle { set; get; }
        public string GradeCOnsFlag { set; get; }
        public DateTime ProcessDate { set; get; }
        public double GrossPay { set; get; }
        public string BankAcc { set; get; }
        public string BankID { set; get; }
        public string BankTitle { set; get; }
        public string LockFlag { set; get; }
        public string SalHeadId { set; get; }
        public string HeadTitle { set; get; }
        public double Basic { set; get; }
        public double HouseRent { set; get; }
        public double Transport { set; get; }
        public double MobileBill { set; get; }
        public double MedicalAllowance { set; get; }
        public double Consolated { set; get; }
        public double Overtime { set; get; }
        public double Arear { set; get; }
        public double Others { set; get; }
        public double IncomeTax { set; get; }
        public double MobileBillDeduce { set; get; }
        public double Lunch { set; get; }
        public double ProvidentFund { set; get; }
        public double Advance { set; get; }
        public double Absent { set; get; }
        public double Cash { set; get; }
        public double LeaveWithoutPay { set; get; }
        public double Loan { set; get; }
        public double OthersDed { set; get; }
        public double BankAmount { set; get; }
        public double Amount { set; get; }
        public double Addition { set; get; }
        public double Deduction { set; get; }
        public string HeadType { set; get; }
        public string PresentDay { set; get; }
        public string LeaveDay { set; get; }
        public string LeaveWithPayDay { set; get; }
        public string LeaveWithoutPayDay { set; get; }
        public string AbsentDay { set; get; }
        public string WorkingDay { set; get; }
        public string TotalNoOfDay { set; get; }
        public string TotalFriday { set; get; }
        public string TotalHoliday { set; get; }
        public string FormatDept { set; get; }
    }
}
