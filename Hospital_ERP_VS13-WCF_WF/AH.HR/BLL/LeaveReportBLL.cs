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
    public class LeaveReportBLL
    {
        public List<LeaveRO> GetDeptWiseLeaveDetails(string Mode, string year, string DeptGrp, string Dept, string Unit)
        {
            return new LeaveReportDAL().GetDeptWiseLeaveDetails(Mode, year, DeptGrp, Dept, Unit);
        }
        public List<LeaveRO> GetLeaveRegisterDetailsRO(string Emp , string year)
        {
            return new LeaveReportDAL().GetLeaveRegisterDetailsRO(Emp, year);
        }
        public List<LeaveRO> GetLeaveTemplateRO(string emp = "", string serial = "")
        {
            return new LeaveReportDAL().GetLeaveTemplateRO(emp, serial);
        }
        public List<LeaveRO> GetEmployeeLeaveDetails(string Year,string Employee)
        {
            return new LeaveReportDAL().GetEmployeeLeaveDetails(Year, Employee);
        }
        public List<LeaveRO> GetEmployeeLeaveSummary(string Year, string Employee)
        {
            return new LeaveReportDAL().GetEmployeeLeaveSummary(Year, Employee);
        }
        public List<LeaveRO> GetEmployeeLeaveDays(string Year)
        {
            return new LeaveReportDAL().GetEmployeeLeaveDays(Year);
        }
        public List<LeaveRO> GetAllLeaveRequisition(string Mode,string Year, string DeptGroup,string Dept,string Unit)
        {
            return new LeaveReportDAL().GetAllLeaveRequisition(Mode, Year, DeptGroup, Dept, Unit);
        }
    }
}
