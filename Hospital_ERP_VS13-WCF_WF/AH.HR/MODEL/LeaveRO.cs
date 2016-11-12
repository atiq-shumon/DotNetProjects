using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class LeaveRO
    {
        public string EmpId { set; get; }
        public string EmpName { set; get; }
        public string DeptGrpID { set; get; }
        public string DeptGrpTitle { set; get; }
        public string DeptId { set; get; }
        public string UnitId { set; get; }
        public string DesigId { set; get; }
        public string year { set; get; }
        public double Casual { set; get; }
        public double Medical { set; get; }
        public double Earn { set; get; }
        public double Maternity { set; get; }
        public double Paternity { set; get; }
        public double Cas_enj { set; get; }
        public double Med_enj { set; get; }
        public double Ear_enj { set; get; }
        public double Mat_enj { set; get; }
        public double Pat_enj { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public double LeaveDays { set; get; }
        public double WithPayDays { set; get; }
        public double WithoutPayDays { set; get; }
        public double Serial { set; get; }
        public string LeaveTypeId { set; get; }
        public string LeaveTypeTitle { set; get; }
        public string Address { set; get; }
        public string LeaveCause { set; get; }
        public string ResponsibilityHolder { set; get; }
        public string ResponsibilityHolderName { set; get; }
        public string ApprovedByRptPrsn { set; get; }
        public string ApprovedByHead { set; get; }
        public string ApprovedByHR { set; get; }
        public string RptPrsnFlag { set; get; }
        public string DeptFlag { set; get; }
        public string HrFlag { set; get; }
        public string CancelCauseRptPrsn { set; get; }
        public string CancelCauseHead { set; get; }
        public string CancelCauseHR { set; get; }
        public string RemarksHead { set; get; }
        public string RemarksHR { set; get; }
        public string FormatDept { set; get; }
     
    }
}
