using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmpLeaveRegister
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public LeaveType LeaveType { set; get; }
        public string year { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public DateTime? LeaveDate { set; get; }
        public double LeaveDays { set; get; }
        public double WithPayDays { set; get; }
        public double WithoutPayDays { set; get; }
        public string LeaveCauseFlag { set; get; }
        public string AddrtessWhileOnLeave { set; get; }
        public string ResponsibilityHolderID { set; get; }
        public string ResponsibilityHolderName { set; get; }
        public string ReportingPersonID { set; get; }
        public string ReportingPersonName { set; get; }
        public string ApprovedByID { set; get; }
        public string ApprovedByHR { set; get; }
        public string ReptPrsnAppFlag { set; get; }
        public string DeptAppFlag { set; get; }
        public string HrAppFlag { set; get; }
        public string NotificationFlag { set; get; }
        public string CancelCauseRptPrsn { set; get; }
        public string CancelCauseID { set; get; }
        public string CancelCauseIDHr { set; get; }
        public string Remarks { set; get; }
        public string RemarksHR { set; get; }
        public string ApprovedByName { set; get; }
        public string LeaveDocPath { set; get; }
        public long RMD { set; get; }
        public string Mode { set; get; }
        public string SalCycleId { set; get; }
        public string Serial { set; get; }
        public string MailTO { set; get; }
        public string MailFrom { set; get; }
        public EntryParameter EntryParameter { set; get; }
         
    }
}
