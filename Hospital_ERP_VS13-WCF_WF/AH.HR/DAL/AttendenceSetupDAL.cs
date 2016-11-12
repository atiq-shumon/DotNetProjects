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
    public class AttendenceSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;


        #region GetDepartmentWiseManualAttendence

        public List<Attendence> ShowAttendence(string Mode,string DeptGrp,string Dept,string Unit,string Month,string Year)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_ATTENDENCE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input), 
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input), 
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input), 
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input), 
                new OracleParameter("p_sal_cycle",OracleDbType.Varchar2,30,Month,ParameterDirection.Input), 
                new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input)
           };

            return ShowAttendenceDetails(packageName, parameterList);
        }

        private List<Attendence> ShowAttendenceDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Attendence> oAttdences = new List<Attendence>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Attendence oAttdence = new Attendence();
                oAttdence.EmpId = (String)rdr["EMP_ID"].ToString();
                oAttdence.Name = (String)rdr["NAME"].ToString();
                oAttdence.FormatDept = rdr["FormatDept"] != DBNull.Value ? (string)rdr["FormatDept"] : "";
                oAttdence.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oAttdence.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oAttdence.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oAttdence.Month = (String)rdr["MONTH"].ToString();
                oAttdence.SalCycleId = (string)rdr["SAL_CYCLE_ID"].ToString();
                oAttdence.PresentDays =Convert.ToInt32(rdr["PRESENT_DAYS"].ToString());
                oAttdence.AbsentDays = Convert.ToInt32(rdr["ABSENT_DAYS"].ToString());
                oAttdence.LeaveDays = Convert.ToInt32(rdr["LEAVE_DAYS"].ToString());
                oAttdence.LeaveWithPayDays = Convert.ToInt32(rdr["LEAVE_WITH_PAY"].ToString());
                oAttdence.LeaveWithoutPayDays = Convert.ToInt32(rdr["LEAVE_WITHOUT_PAY"].ToString());
                oAttdence.WorkingDays = Convert.ToInt32(rdr["WORKING_DAYS"].ToString());
                oAttdences.Add(oAttdence);
            }
            rdr.Close();
            return oAttdences;
        }
        #endregion

        #region SaveAttendenceForUpdate

        public string SaveUpdatedAttendence(Attendence oAttendence)
        {
            packagename = "PKG_ATTENDANCE_SETUP.SAVE_ATTENDENCE_FOR_UPDATE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oAttendence.EmpId,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,30,oAttendence.Year,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,10,oAttendence.SalCycleId,ParameterDirection.Input),            
                new OracleParameter("absent_string",OracleDbType.Varchar2,4000,oAttendence.AbsentString,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oAttendence.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oAttendence.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oAttendence.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oAttendence.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oAttendence.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
        #endregion

        #region SaveShiftSetup
        public short SaveShiftSetup(Shift oShift)
        {
            packagename = "PKG_ATTENDANCE_SETUP.INSERT_SHIFT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_shift_id",OracleDbType.Varchar2,2,oShift.ShiftID,ParameterDirection.Input),
                new OracleParameter("p_shift_title",OracleDbType.Varchar2,100,oShift.ShiftTitle,ParameterDirection.Input),
                new OracleParameter("p_shift_title_beng",OracleDbType.Varchar2,100,oShift.ShiftTitleBeng,ParameterDirection.Input),                
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oShift.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oShift.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oShift.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oShift.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oShift.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateShiftSetup
        public short UpdateShiftSetup(Shift oShift)
        {
            packagename = "PKG_ATTENDANCE_SETUP.UPDATE_SHIFT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_shift_id",OracleDbType.Varchar2,2,oShift.ShiftID,ParameterDirection.Input),
                new OracleParameter("p_shift_title",OracleDbType.Varchar2,100,oShift.ShiftTitle,ParameterDirection.Input),
                new OracleParameter("p_shift_title_beng",OracleDbType.Varchar2,100,oShift.ShiftTitleBeng,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oShift.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oShift.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oShift.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oShift.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oShift.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetShiftSetup
        public List<Shift> GetShiftSetup()
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_SHIFT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),               
           };

            return GetShiftSetupDetails(packageName, parameterList);
        }
        private List<Shift> GetShiftSetupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Shift> oShifts = new List<Shift>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Shift oShift = new Shift();

                oShift.ShiftID = rdr["SHIFT_ID"].ToString();
                oShift.ShiftTitle = (String)rdr["SHIFT_TITLE"].ToString();
                oShift.ShiftTitleBeng = (String)rdr["SHIFT_TITLE_BENGALI"].ToString();              
                oShifts.Add(oShift);
            }
            rdr.Close();
            return oShifts;
        }
        #endregion
                
        #region GetEmpInfoForAttndence 
        public List<EmployeeMaster> GetEmpInfoForAttndence(string DeptGroup,string Department,string Unit)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_EMP_FOR_ATTNDENCE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
            };
            return GetEmpInfoDetails(packageName, parameterList);
        }
        public List<EmployeeMaster> GetEmpInfoForRptPrsn(string DeptType, string DeptGroup)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_EMP_FOR_RPT_PRSN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_type",OracleDbType.Varchar2,30,DeptType,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input)
            };
            return GetEmpInfoDetails(packageName, parameterList);

        }
        public List<EmployeeMaster> GetEmpInfoForRoster(string Mode,string DeptGroup, string Department, string Unit)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_EMP_FOR_ROSTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)             
            };
            return GetEmpInfoDetails(packageName, parameterList);

        }      
        private List<EmployeeMaster> GetEmpInfoDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oEmpAttnInfos = new List<EmployeeMaster>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmployeeMaster.Name = (string)rdr["NAME"].ToString();

                Department oDept = new Department();
                DepartmentGroup ogrp = new DepartmentGroup();

                ogrp.DepartmentGroupID = rdr["DEPT_GRP"].ToString();
                ogrp.DepartmentGroupTitle = rdr["DEPT_GRP_NAME"].ToString();
                oDept.DepartmentGroup = ogrp;

                oDept.DepartmentID = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oDept.DepartmentTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oEmployeeMaster.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oDeptUnit.UnitTitle = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"] : "";
                oEmployeeMaster.DepartmentUnit = oDeptUnit;

                Designation oDesig = new Designation();
                oDesig.DesignationId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oDesig.DesignationTitle = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"] : "";
                oEmployeeMaster.Designation = oDesig;

                oEmpAttnInfos.Add(oEmployeeMaster);
            }
            rdr.Close();
            return oEmpAttnInfos;

        }
        #endregion

        #region SaveRosterDuty
        public short SaveRosterDuty(EmployeeMaster oEmployeeMaster)
        {
            packagename = "PKG_ATTENDANCE_SETUP.INSERT_ROSTER_DUTY";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,8,oEmployeeMaster.Shift.Mode,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,8,oEmployeeMaster.SalaryCycle.Month,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oEmployeeMaster.SalaryCycle.Year,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oEmployeeMaster.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oEmployeeMaster.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oEmployeeMaster.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,oEmployeeMaster.Shift.StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,30,oEmployeeMaster.Shift.EndDate,ParameterDirection.Input),
                new OracleParameter("p_roster_string",OracleDbType.Clob,200000,oEmployeeMaster.RosterString,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmployeeMaster.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmployeeMaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmployeeMaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmployeeMaster.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetRosterDuty
        public List<EmployeeMaster> GetRosterDuty(string Mode,string Year,string Month,string DeptGroup,string Department, string Unit)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_ROSTER_DUTY";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,Month,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
            };
            return GetRosterDutyDetails(packageName, parameterList);

        }
        public List<EmployeeMaster> GetOneDayRoster(string Mode,string Year, string Month, string DeptGroup, string Department, string Unit,string StartDate,string EndDate)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_ONE_DAY_ROSTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,Month,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input)
            };
            return GetRosterDutyDetails(packageName, parameterList);

        }
        public List<EmployeeMaster> GetRosterDutyDate(string Mode,string Year, string Month, string DeptGroup, string Department, string Unit,string EmpID)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_ROSTER_DUTY_DATE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,30,Month,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input)
            };
            return GetRosterDutyDetails(packageName, parameterList);

        }
        private List<EmployeeMaster> GetRosterDutyDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oEmpAttnInfos = new List<EmployeeMaster>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmployeeMaster.Name = (string)rdr["NAME"].ToString();

                Department oDept = new Department();
                DepartmentGroup ogrp = new DepartmentGroup();

                ogrp.DepartmentGroupID = rdr["DEPT_GRP"].ToString();
                ogrp.DepartmentGroupTitle = rdr["DEPT_GRP_NAME"].ToString();
                oDept.DepartmentGroup = ogrp;
                oDept.DepartmentID = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oDept.DepartmentTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oEmployeeMaster.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oDeptUnit.UnitTitle = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"] : "";
                oEmployeeMaster.DepartmentUnit = oDeptUnit;

                Designation oDesig = new Designation();
                oDesig.DesignationId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oDesig.DesignationTitle = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"] : "";
                oEmployeeMaster.Designation = oDesig;
                Shift oShift = new Shift();
                oShift.ShiftID = (String)rdr["SHIFT_ID"].ToString();
                oShift.ShiftTitle = (string)rdr["shift_title"].ToString();
                oShift.DutyDate = (string)rdr["DUTY_DATE"].ToString();
                oEmployeeMaster.Shift = oShift;

                oEmpAttnInfos.Add(oEmployeeMaster);
            }
            rdr.Close();
            return oEmpAttnInfos;

        }
        #endregion

        #region SaveShiftTimingSetup
        public short SaveShiftTimingSetup(Shift oShift)
        {
            packagename = "PKG_ATTENDANCE_SETUP.INSERT_SHIFT_TIMING_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_shift_string",OracleDbType.Varchar2,200000,oShift.ShiftString,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oShift.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oShift.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oShift.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oShift.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oShift.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oShift.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oShift.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateShiftTimingSetup
        public short UpdateShiftTimingSetup(Shift oShift)
        {
            packagename = "PKG_ATTENDANCE_SETUP.UPDATE_SHIFT_TIMING_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_shift_id",OracleDbType.Varchar2,2,oShift.ShiftID,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oShift.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oShift.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oShift.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_start_time",OracleDbType.Varchar2,15,oShift.StartTime,ParameterDirection.Input),
                new OracleParameter("p_end_time",OracleDbType.Varchar2,15,oShift.EndTime,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oShift.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oShift.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oShift.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oShift.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetShiftTimingSetup
        public List<Shift> GetShiftTimingSetup()
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_SHIFT_TIMING_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)              
           };
            return GetShiftTimingSetupDetails(packageName, parameterList);
        }
        public List<Shift> GetShiftTiming(string DeptGroup,string Department,string Unit)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_SHIFT_TIMING_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
           };
            return GetShiftTimingSetupDetails(packageName, parameterList);
        }
        private List<Shift> GetShiftTimingSetupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Shift> oShifts = new List<Shift>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Shift oShift = new Shift();

                oShift.ShiftID = rdr["SHIFT_ID"].ToString();
                oShift.ShiftTitle = (String)rdr["SHIFT_TITLE"].ToString();
                Department oDept = new Department();                
                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["DEPT_GRP"].ToString();
                oDeptGrp.DepartmentGroupTitle = rdr["GROUP_TITLE"].ToString();
                DepartmentType oDeptType = new DepartmentType();
                oDeptType.TypeID = rdr["TYPE_ID"].ToString();
                oDeptGrp.DepartmentType = oDeptType;
                oShift.DepartmentGroup = oDeptGrp;

                oDept.DepartmentID = rdr["DEPT_ID"].ToString();
                oDept.DepartmentTitle = rdr["dept_title"].ToString();
                oShift.Department = oDept;
                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"].ToString();
                oDeptUnit.UnitTitle = rdr["UNIT_TITLE"].ToString();
                oShift.DepartmentUnit = oDeptUnit;
                oShift.StartTime = (String)rdr["START_TIME"].ToString();
                oShift.EndTime = (String)rdr["END_TIME"].ToString();
                oShift.ShiftTiming = (String)rdr["ShiftingTime"].ToString();

                oShifts.Add(oShift);
            }
            rdr.Close();
            return oShifts;
        }
        #endregion

        #region GetDailyAttndence
        public List<Attendence> GetDailyAttndence(string Mode,string DeptGroup,string Dept,string Unit,string StartDate,string EndDate)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_DAILY_ATTENDENCE_REPORT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
            };
            return GetDailyAttndenceDetails(packageName, parameterList);
        }
        public List<Attendence> GetDailyAbsent(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_DAILY_ABSENT_REPORT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
            };
            return GetDailyAttndenceDetails(packageName, parameterList);
        }
        public List<Attendence> GetDailyLate(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_DAILY_LATE_REPORT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
            };
            return GetDailyAttndenceDetails(packageName, parameterList);
        }
        private List<Attendence> GetDailyAttndenceDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Attendence> oEmpAttnInfos = new List<Attendence>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                Attendence oAttendence = new Attendence();
                oAttendence.EmpId = (string)rdr["emp_id"].ToString();
                oAttendence.Name = (string)rdr["NAME"].ToString();
                oAttendence.DeptGrp = rdr["DEPT_GRP"] != DBNull.Value ? (string)rdr["DEPT_GRP"] : "";
                oAttendence.DeptGrpTitle = rdr["DEPT_GRP_NAME"] != DBNull.Value ? (string)rdr["DEPT_GRP_NAME"] : "";
                oAttendence.DeptId = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oAttendence.DeptTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oAttendence.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oAttendence.UnitTitle = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"] : "";
                oAttendence.DesigId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oAttendence.DesigTitle = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"] : "";
                oAttendence.FormatDept = rdr["FormatDept"] != DBNull.Value ? (string)rdr["FormatDept"] : "";
                oAttendence.AttendenceDate =Convert.ToDateTime(rdr["ATDN_DATE"].ToString()).ToString("dd/MM/yyyy");
                oAttendence.Day = rdr["Days"].ToString();
                if (rdr["InTime"].ToString() != "")
                {
                    oAttendence.InTime = Convert.ToDateTime(rdr["InTime"].ToString()).ToString("hh:mm tt");
                }
                else
                {
                    oAttendence.InTime = rdr["InTime"].ToString();
                }
                if (rdr["OutTime"].ToString() != "")
                {
                    oAttendence.OutTime = Convert.ToDateTime(rdr["OutTime"].ToString()).ToString("hh:mm tt");
                }
                else
                {
                    oAttendence.OutTime = rdr["OutTime"].ToString();
                }
                oAttendence.Status = rdr["Status"].ToString();
                oAttendence.IsLate = rdr["IS_LATE"].ToString();

                oEmpAttnInfos.Add(oAttendence);
            }
            rdr.Close();
            return oEmpAttnInfos;

        }
        #endregion

        #region GetDailyLeave
        public List<LeaveRO> GetDailyLeave(string Mode,string DeptGrp, string Dept, string Unit, string StartDate,string EndDate)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_DAILY_LEAVE_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input) , 
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,50,EndDate,ParameterDirection.Input)
           };

            return GetDailyLeaveDetails(packageName, parameterList);
        }
        private List<LeaveRO> GetDailyLeaveDetails(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveRO> oLvs = new List<LeaveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveRO oLv = new LeaveRO();
                oLv.EmpId = (String)rdr["EMP_ID"].ToString();
                oLv.EmpName = (String)rdr["NAME"].ToString();
                oLv.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oLv.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oLv.DeptGrpID = (String)rdr["DEPT_GRP"].ToString();
                oLv.DeptGrpTitle = (String)rdr["DEPT_GRP_NAME"].ToString();               
                oLv.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oLv.FormatDept = (String)rdr["FormatDept"].ToString();
                oLv.StartDate = Convert.ToDateTime(rdr["LEAVE_S_DATE"].ToString());
                oLv.EndDate = Convert.ToDateTime(rdr["LEAVE_E_DATE"].ToString());
                oLv.LeaveDays = double.Parse(rdr["LEAVE_DAYS"].ToString());              
                oLvs.Add(oLv);
            }
            rdr.Close();
            return oLvs;
        }
        #endregion

        #region GetMonthlyAttndence
        public List<Attendence> GetMonthlyAttndence(string EmpID, string StartDate, string EndDate)
        {
            string packageName = "PKG_ATTENDANCE_SETUP.GET_MONTHLY_ATTENDENCE_REPORT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input)
            };
            return GetMonthlyAttndenceDetails(packageName, parameterList);
        }
        private List<Attendence> GetMonthlyAttndenceDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Attendence> oEmpAttnInfos = new List<Attendence>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {

                Attendence oAttendence = new Attendence();
                oAttendence.EmpId = (string)rdr["emp_id"].ToString();
                oAttendence.Name = (string)rdr["NAME"].ToString();
                oAttendence.DeptGrp = rdr["DEPT_GRP"] != DBNull.Value ? (string)rdr["DEPT_GRP"] : "";
                oAttendence.DeptGrpTitle = rdr["DEPT_GRP_NAME"] != DBNull.Value ? (string)rdr["DEPT_GRP_NAME"] : "";
                oAttendence.DeptId = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oAttendence.DeptTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oAttendence.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oAttendence.UnitTitle = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"] : "";
                oAttendence.DesigId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oAttendence.DesigTitle = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"] : "";
                oAttendence.FormatDept = rdr["FormatDept"] != DBNull.Value ? (string)rdr["FormatDept"] : "";
                oAttendence.AttendenceDate = Convert.ToDateTime(rdr["ATDN_DATE"].ToString()).ToString("dd/MM/yyyy");
                oAttendence.Day = rdr["Days"].ToString();
                if (rdr["InTime"].ToString() != "")
                {
                    oAttendence.InTime = Convert.ToDateTime(rdr["InTime"].ToString()).ToString("hh:mm tt");
                }
                else
                {
                    oAttendence.InTime = rdr["InTime"].ToString();
                }
                if (rdr["OutTime"].ToString() != "")
                {
                    oAttendence.OutTime = Convert.ToDateTime(rdr["OutTime"].ToString()).ToString("hh:mm tt");
                }
                else
                {
                    oAttendence.OutTime = rdr["OutTime"].ToString();
                }              
                oAttendence.Status = rdr["Status"].ToString();
                oAttendence.IsLate = rdr["IS_LATE"].ToString();

                oEmpAttnInfos.Add(oAttendence);
            }
            rdr.Close();
            return oEmpAttnInfos;

        }
        #endregion

        #region AttendanceProcess
        public string AttendanceProcess(Attendence oAttendence)
        {
            packagename = "PKG_ATTENDANCE_SETUP.ATTENDANCE_PROCESS";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("p_e_rows",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
             new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
             new OracleParameter("p_atn_date",OracleDbType.Varchar2,30, oAttendence.AttendenceDate,ParameterDirection.Input),             
             new OracleParameter("p_update_by",OracleDbType.Varchar2,20, oAttendence.EntryParameter.UpdateBy ,ParameterDirection.Input),
             new OracleParameter("p_comp_id",OracleDbType.Varchar2,2, oAttendence.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("p_loc_id",OracleDbType.Varchar2,2, oAttendence.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("p_mac_id",OracleDbType.Varchar2,20, oAttendence.EntryParameter.MachineID,ParameterDirection.Input)
          };

            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
        #endregion

        #region UpdateAttendanceProcess
        public short UpdateAttendanceProcess(Attendence oAttendence)
        {
            packagename = "PKG_ATTENDANCE_SETUP.UPDATE_ATTENDANCE_PROCESS";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("p_e_rows",OracleDbType.Int32,100,null,ParameterDirection.Output),
             new OracleParameter("p_atn_date",OracleDbType.Varchar2,30, oAttendence.AttendenceDate,ParameterDirection.Input),             
             new OracleParameter("p_update_by",OracleDbType.Varchar2,20, oAttendence.EntryParameter.UpdateBy ,ParameterDirection.Input),
             new OracleParameter("p_comp_id",OracleDbType.Varchar2,2, oAttendence.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("p_loc_id",OracleDbType.Varchar2,2, oAttendence.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("p_mac_id",OracleDbType.Varchar2,20, oAttendence.EntryParameter.MachineID,ParameterDirection.Input)
          };

            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

    }
}
