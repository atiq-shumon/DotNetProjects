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
    public class AttendenceSetupBLL
    {
        public List<Attendence> ShowAttendence(string Mode, string DeptGrp, string Dept, string Unit, string Month, string Year)
        {
            return new AttendenceSetupDAL().ShowAttendence(Mode,DeptGrp, Dept, Unit, Month, Year);
        }
        public string SaveUpdatedAttendence(Attendence oAttendence)
        {
            return new AttendenceSetupDAL().SaveUpdatedAttendence(oAttendence);
        }
        public short SaveShiftSetup(Shift oShift)
        {
            return new AttendenceSetupDAL().SaveShiftSetup(oShift);
        }
        public short UpdateShiftSetup(Shift oShift)
        {
            return new AttendenceSetupDAL().UpdateShiftSetup(oShift);
        }
        public List<Shift> GetShiftSetup()
        {
            return new AttendenceSetupDAL().GetShiftSetup();
        }
        public Dictionary<string, string> GetShiftDict(string type)
        {
            Dictionary<string, string> ShiftDict = new Dictionary<string, string>();
            ShiftDict.Add("", "--Select--");
            foreach (Shift oShift in new AttendenceSetupDAL().GetShiftSetup())
            {
                ShiftDict.Add(oShift.ShiftID, oShift.ShiftTitle);
            }
            return ShiftDict;
        }
        public List<EmployeeMaster> GetEmpInfoForAttndence(string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupDAL().GetEmpInfoForAttndence(DeptGroup,Department, Unit);
        }
        public List<EmployeeMaster> GetEmpInfoForRptPrsn(string DeptType, string DeptGroup)
        {
            return new AttendenceSetupDAL().GetEmpInfoForRptPrsn(DeptType, DeptGroup);
        }
        public Dictionary<string, string> GetReportingPersonDic(string DeptType, string DeptGroup)
        {
            Dictionary<string, string> ShiftDict = new Dictionary<string, string>();
            ShiftDict.Add("", "--Select--");
            foreach (EmployeeMaster oShift in new AttendenceSetupDAL().GetEmpInfoForRptPrsn(DeptType, DeptGroup))
            {
                ShiftDict.Add(oShift.EmpId, oShift.Name);
            }
            return ShiftDict;
        }
        public List<EmployeeMaster> GetEmpInfoForRoster(string Mode, string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupDAL().GetEmpInfoForRoster(Mode, DeptGroup, Department, Unit);
        }
        public short SaveRosterDuty(EmployeeMaster oEmployeeMaster)
        {
            return new AttendenceSetupDAL().SaveRosterDuty(oEmployeeMaster);
        }
        public List<EmployeeMaster> GetRosterDuty(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupDAL().GetRosterDuty(Mode,Year, Month, DeptGroup, Department, Unit);
        }
        public List<EmployeeMaster> GetOneDayRoster(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupDAL().GetOneDayRoster(Mode, Year, Month, DeptGroup, Department, Unit, StartDate, EndDate);
        }
        public List<EmployeeMaster> GetRosterDutyDate(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit, string EmpID)
        {
            return new AttendenceSetupDAL().GetRosterDutyDate(Mode,Year, Month, DeptGroup, Department, Unit, EmpID);
        }
        public short SaveShiftTimingSetup(Shift oShift)
        {
            return new AttendenceSetupDAL().SaveShiftTimingSetup(oShift);
        }
        public short UpdateShiftTimingSetup(Shift oShift)
        {
            return new AttendenceSetupDAL().UpdateShiftTimingSetup(oShift);
        }
        public List<Shift> GetShiftTimingSetup()
        {
            return new AttendenceSetupDAL().GetShiftTimingSetup();
        }
        public List<Shift> GetShiftTiming(string DeptGroup,string Department,string Unit)
        {
            return new AttendenceSetupDAL().GetShiftTiming(DeptGroup, Department, Unit);
        }
        public List<Attendence> GetDailyAttndence(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupDAL().GetDailyAttndence(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<Attendence> GetDailyAbsent(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupDAL().GetDailyAbsent(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<Attendence> GetDailyLate(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupDAL().GetDailyLate(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<LeaveRO> GetDailyLeave(string Mode,string DeptGrp, string Dept, string Unit, string StartDate,string EndDate)
        {
            return new AttendenceSetupDAL().GetDailyLeave(Mode, DeptGrp, Dept, Unit, StartDate, EndDate);
        }
        public List<Attendence> GetMonthlyAttndence(string EmpID, string StartDate, string EndDate)
        {
            return new AttendenceSetupDAL().GetMonthlyAttndence(EmpID, StartDate, EndDate);
        }
        public string AttendanceProcess(Attendence oAttendence)
        {
            return new AttendenceSetupDAL().AttendanceProcess(oAttendence);
        }
        public short UpdateAttendanceProcess(Attendence oAttendence)
        {
            return new AttendenceSetupDAL().UpdateAttendanceProcess(oAttendence);
        }
    }
}
