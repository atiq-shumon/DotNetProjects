using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class Attendence
    {
        public string EmpId { set; get; }
        public string Name { set; get; }
        public string DeptGrp { set; get; }
        public string DeptGrpTitle { set; get; }  
        public string DeptId { set; get; }
        public string DeptTitle { set; get; }
        public string UnitId { set; get; }
        public string UnitTitle { set; get; }
        public string DesigId { set; get; }
        public string DesigTitle { set; get; }
        public string AttendenceDate { set; get; }
        public string Day { set; get; }
        public string InTime { set; get; }
        public string OutTime { set; get; }
        public string Status { set; get; }
        public string Month { set; get; }
        public string SalCycleId { set; get; }
        public string Year { set; get; }
        public int PresentDays { set; get; }
        public int AbsentDays { set; get; }
        public int LeaveDays { set; get; }
        public string CheckBox { set; get; }
        public int LeaveWithPayDays { set; get; }
        public int LeaveWithoutPayDays { set; get; }
        public string AbsentString { set; get; }
        public int WorkingDays { set; get; }
        public string FormatDept { set; get; }
        public string IsLate { set; get; }
        public EntryParameter EntryParameter { set; get; }
        
    }
}
