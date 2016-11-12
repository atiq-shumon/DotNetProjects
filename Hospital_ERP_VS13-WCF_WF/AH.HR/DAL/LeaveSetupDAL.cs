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
    public class LeaveSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region SaveLeaveType

        public short SaveLeaveType(LeaveType oLvType)
        {
            packagename = "PKG_LEAVE_SETUP.INSERT_LEAVE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oLvType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_type_title",OracleDbType.Varchar2,50,oLvType.TypeTitle,ParameterDirection.Input),
                new OracleParameter("p_type_title_beng",OracleDbType.Varchar2,50,oLvType.TypeTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_type_flag",OracleDbType.Varchar2,1,oLvType.TypeFlag,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,300,oLvType.Serial,ParameterDirection.Input),               
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oLvType.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oLvType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oLvType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oLvType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oLvType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oLvType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetLeaveType
        public List<LeaveType> GetLeaveType()
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetLeaveTypes(packageName, parameterList);
        }

        public List<LeaveType> GetLeaveTypeSetup(string oLvTpSet)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,3,oLvTpSet,ParameterDirection.Input)
           };

            return GetLeaveTypes(packageName, parameterList);
        }
        private List<LeaveType> GetLeaveTypes(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveType> oLvTypes = new List<LeaveType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveType oLvType = new LeaveType();
                oLvType.TypeID = (String)rdr["TYPE_ID"].ToString();
                oLvType.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                oLvType.TypeTitleBeng = (string)rdr["TYPE_TITLE_BENG"].ToString();
                oLvType.TypeFlag = (string)rdr["TYPE_FLAG"].ToString();
                oLvType.Serial = rdr["SERIAL"].ToString();
                oLvType.Remarks = !rdr.IsDBNull(5) ? (String)rdr["REMARKS"].ToString() : "";
                oLvTypes.Add(oLvType);
            }
            rdr.Close();
            return oLvTypes;
        }
        #endregion

        #region UpdateLeaveType

        public short UpdateLeaveType(LeaveType oLvType)
        {
            packagename = "PKG_LEAVE_SETUP.UPDATE_LEAVE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oLvType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_type_title",OracleDbType.Varchar2,50,oLvType.TypeTitle,ParameterDirection.Input),
                new OracleParameter("p_type_title_beng",OracleDbType.Varchar2,50,oLvType.TypeTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_type_flag",OracleDbType.Varchar2,1,oLvType.TypeFlag,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,300,oLvType.Serial,ParameterDirection.Input),               
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oLvType.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oLvType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oLvType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oLvType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oLvType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oLvType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetLeave
        public List<LeaveType> GetLeave()
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetLeaveInfo(packageName, parameterList);
        }

        private List<LeaveType> GetLeaveInfo(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveType> olvs = new List<LeaveType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveType olv = new LeaveType();
                olv.TypeID = (String)rdr["TYPE_ID"].ToString();
                olv.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                olvs.Add(olv);
            }
            rdr.Close();
            return olvs;
        }
        #endregion

        #region GetLeaveDays
        public List<LeaveDaysSetup> GetLeaveDay(string oLvTpSet)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_DAYS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oLvTpSet,ParameterDirection.Input)
           };

            return GetLeaveDaysSetup(packageName, parameterList);
        }
        public List<LeaveDaysSetup> GetLeaveDays(string oYear, string oLvTpSet)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_DAYS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oYear,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oLvTpSet,ParameterDirection.Input)
                
           };

            return GetLeaveDaysSetup(packageName, parameterList);
        }

        private List<LeaveDaysSetup> GetLeaveDaysSetup(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveDaysSetup> oLvdays = new List<LeaveDaysSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveDaysSetup oLvDay = new LeaveDaysSetup();
                oLvDay.year = (String)rdr["YEAR"].ToString();
                LeaveType oLvTp = new LeaveType();
                oLvTp.TypeID = (String)rdr["TYPE_TITLE"].ToString();
                oLvDay.LeaveType = oLvTp;
                oLvDay.days = Convert.ToInt32(rdr["DAYS"]).ToString();
                oLvDay.ReqDays = (String)rdr["REQ_DAYS"].ToString();
                oLvDay.ReqWithin = (String)rdr["REQ_WITHIN"].ToString();
                oLvDay.Reamrks = rdr["REMARKS"] != DBNull.Value ? (String)rdr["REMARKS"].ToString() : "";
                oLvdays.Add(oLvDay);
            }
            rdr.Close();
            return oLvdays;
        }
        #endregion

        #region SaveLeaveDays

        public short SaveLeaveDays(LeaveDaysSetup oLvDaysSet)
        {
            packagename = "PKG_LEAVE_SETUP.INSERT_LEAVE_DAYS ";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oLvDaysSet.year,ParameterDirection.Input),
                new OracleParameter("p_leave_type_id",OracleDbType.Varchar2,4,oLvDaysSet.LeaveType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_days",OracleDbType.Varchar2,6,oLvDaysSet.days,ParameterDirection.Input),  
                new OracleParameter("p_req_days",OracleDbType.Varchar2,6,oLvDaysSet.ReqDays,ParameterDirection.Input), 
                new OracleParameter("p_req_within",OracleDbType.Varchar2,6,oLvDaysSet.ReqWithin,ParameterDirection.Input), 
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oLvDaysSet.Reamrks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oLvDaysSet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oLvDaysSet.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oLvDaysSet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oLvDaysSet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oLvDaysSet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateLeaveDays

        public short UpdateLeaveDays(LeaveDaysSetup oLvDaysSet)
        {
            packagename = "PKG_LEAVE_SETUP.UPDATE_LEAVE_DAYS";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oLvDaysSet.year,ParameterDirection.Input),
                new OracleParameter("p_leave_type_id",OracleDbType.Varchar2,4,oLvDaysSet.LeaveType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_days",OracleDbType.Varchar2,6,oLvDaysSet.days,ParameterDirection.Input),
                new OracleParameter("p_req_days",OracleDbType.Varchar2,6,oLvDaysSet.ReqDays,ParameterDirection.Input), 
                new OracleParameter("p_req_within",OracleDbType.Varchar2,6,oLvDaysSet.ReqWithin,ParameterDirection.Input),             
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oLvDaysSet.Reamrks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oLvDaysSet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oLvDaysSet.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oLvDaysSet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oLvDaysSet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oLvDaysSet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetLeaveRegister
        public List<EmpLeaveRegister> GetLeaveRegister(string oLvType)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_REGISTER";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,10,oLvType,ParameterDirection.Input)
           };

            return GetLeaveRegisterSetup(packageName, parameterList);
        }

        private List<EmpLeaveRegister> GetLeaveRegisterSetup(string packageName, OracleParameter[] parameterList)
        {
            List<EmpLeaveRegister> oLvRegiss = new List<EmpLeaveRegister>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmpLeaveRegister oLvRegis = new EmpLeaveRegister();

                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas.EmpId = (String)rdr["EMP_ID"].ToString();
                oEmpMas.Name = (String)rdr["NAME"].ToString();
                oLvRegis.EmployeeMaster = oEmpMas;

                oLvRegis.year = (String)rdr["YEAR"].ToString();

                LeaveType oLvTp = new LeaveType();
                oLvTp.TypeID = (String)rdr["TYPE_TITLE"].ToString();
                oLvRegis.LeaveType = oLvTp;

                if (rdr["LEAVE_S_DATE"] == DBNull.Value)
                {
                    oLvRegis.StartDate = null;
                }
                else
                {
                    oLvRegis.StartDate = Convert.ToDateTime((DateTime)rdr["LEAVE_S_DATE"]);
                }
                if (rdr["LEAVE_E_DATE"] == DBNull.Value)
                {
                    oLvRegis.EndDate = null;
                }
                else
                {
                    oLvRegis.EndDate = Convert.ToDateTime((DateTime)rdr["LEAVE_E_DATE"]);
                }               
                oLvRegis.LeaveCauseFlag = (String)rdr["LEAVE_CAUSE"].ToString();
                oLvRegis.AddrtessWhileOnLeave = (String)rdr["ADDRESS_WHILE_ON_LEAVE"].ToString();
                oLvRegis.ResponsibilityHolderID = (String)rdr["RESPONSIBILITY_HOLDER_ID"].ToString();
                oLvRegis.ResponsibilityHolderName = (String)rdr["RESPONSIBILITYHOLDERNAME"].ToString();
                oLvRegis.ApprovedByID = (String)rdr["APPROVED_BY"].ToString();
                oLvRegis.ApprovedByHR = (String)rdr["APPROVED_BY_HR"].ToString();
                oLvRegis.ApprovedByName = (String)rdr["ApprovedByHead"].ToString();
                oLvRegis.LeaveDocPath = "C";
                oLvRegis.Serial = (String)rdr["LEAVE_SERIAL"].ToString();
                oLvRegiss.Add(oLvRegis);
            }
            rdr.Close();
            return oLvRegiss;
        }
        #endregion

        #region GetLeaveRegister
        public EmpLeaveRegister GetLeaveReg(string oEmp,string oLvType,string Serial)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_REGISTER";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,10,oEmp,ParameterDirection.Input),
                new OracleParameter("p_leave_type_id",OracleDbType.Varchar2,10,oLvType,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,100,Serial,ParameterDirection.Input)
           };

            return GetLeaveRegisters(packageName, parameterList);
        }

        private EmpLeaveRegister GetLeaveRegisters(string packageName, OracleParameter[] parameterList)
        {
            EmpLeaveRegister oLvRegis = new EmpLeaveRegister();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas.EmpId = (String)rdr["EMP_ID"].ToString();
                oEmpMas.Name = (String)rdr["NAME"].ToString();
                oLvRegis.EmployeeMaster = oEmpMas;

                oLvRegis.year = (String)rdr["YEAR"].ToString();

                LeaveType oLvTp = new LeaveType();
                oLvTp.TypeID = (String)rdr["TYPE_ID"].ToString();
                oLvTp.TypeTitle = (String)rdr["TYPE_TITLE"].ToString();
                oLvRegis.LeaveType = oLvTp;

                if (rdr["LEAVE_S_DATE"] == DBNull.Value)
                {
                    oLvRegis.StartDate = null;
                }
                else
                {
                    oLvRegis.StartDate = Convert.ToDateTime((DateTime)rdr["LEAVE_S_DATE"]);
                }
                if (rdr["LEAVE_E_DATE"] == DBNull.Value)
                {
                    oLvRegis.EndDate = null;
                }
                else
                {
                    oLvRegis.EndDate = Convert.ToDateTime((DateTime)rdr["LEAVE_E_DATE"]);
                }
                oLvRegis.LeaveCauseFlag = (String)rdr["LEAVE_CAUSE"].ToString();
                oLvRegis.LeaveDays = Convert.ToDouble(rdr["LEAVE_DAYS"].ToString());
                oLvRegis.WithPayDays = Convert.ToDouble(rdr["WITH_PAY_DAYS"].ToString());
                oLvRegis.WithoutPayDays = Convert.ToDouble(rdr["WITHOUT_PAY_DAYS"].ToString());
                oLvRegis.AddrtessWhileOnLeave = (String)rdr["ADDRESS_WHILE_ON_LEAVE"].ToString();
                oLvRegis.ResponsibilityHolderID = (String)rdr["RESPONSIBILITY_HOLDER_ID"].ToString();
                oLvRegis.ResponsibilityHolderName = (String)rdr["RESPONSIBILITYHOLDERNAME"].ToString();
                oLvRegis.ApprovedByID = (String)rdr["APPROVED_BY"].ToString();
                oLvRegis.ApprovedByHR = (String)rdr["APPROVED_BY_HR"].ToString();
                oLvRegis.ApprovedByName = (String)rdr["ApprovedByHead"].ToString();
                oLvRegis.CancelCauseID = (string)rdr["Cancel_cause_id"].ToString();
                oLvRegis.CancelCauseIDHr = (string)rdr["Cancel_cause_id_hr"].ToString();
                oLvRegis.Remarks = (string)rdr["Remarks"].ToString();
                oLvRegis.RemarksHR = (string)rdr["Remarks_hr"].ToString();
                oLvRegis.DeptAppFlag = (string)rdr["DEPT_APPR_FLAG"].ToString();
                oLvRegis.HrAppFlag = (string)rdr["HR_APPR_FLAG"].ToString();
                oLvRegis.LeaveDocPath = "C";
                oLvRegis.Serial = (string)rdr["LEAVE_SERIAL"].ToString();
                oLvRegis.ReportingPersonID = (string)rdr["REPTPSON_ID"].ToString();
                oLvRegis.ReportingPersonName = (string)rdr["REPTPSONPERSONNAME"].ToString();
                oLvRegis.ReptPrsnAppFlag = (string)rdr["REPTPSON_APPR_FLAG"].ToString();
                oLvRegis.CancelCauseRptPrsn = (string)rdr["CANCEL_CAUSE_ID_RPTPSON"].ToString();
            }
            rdr.Close();
            return oLvRegis;
        }
        #endregion
      
        #region SaveEmpLeaveRegister

        public string SaveEmpLeaveRegister(EmpLeaveRegister oEmpLeaveRegis)
        {
            packagename = "PKG_LEAVE_SETUP.INSERT_LEAVE_REGISTER ";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpLeaveRegis.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oEmpLeaveRegis.year,ParameterDirection.Input),
                new OracleParameter("p_sal_cycle_id",OracleDbType.Varchar2,50,oEmpLeaveRegis.SalCycleId,ParameterDirection.Input),
                new OracleParameter("p_leave_type_id",OracleDbType.Varchar2,4,oEmpLeaveRegis.LeaveType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,oEmpLeaveRegis.StartDate,ParameterDirection.Input), 
                new OracleParameter("p_end_date",OracleDbType.Date,oEmpLeaveRegis.EndDate,ParameterDirection.Input), 
                new OracleParameter("p_leave_cause",OracleDbType.Varchar2,5,oEmpLeaveRegis.LeaveCauseFlag,ParameterDirection.Input),
                new OracleParameter("p_address_while_on_leave",OracleDbType.Varchar2,500,oEmpLeaveRegis.AddrtessWhileOnLeave,ParameterDirection.Input),
                new OracleParameter("p_responsibility_holder_id",OracleDbType.Varchar2,30,oEmpLeaveRegis.ResponsibilityHolderID,ParameterDirection.Input),
                new OracleParameter("p_rept_prsn",OracleDbType.Varchar2,30,oEmpLeaveRegis.ReportingPersonID,ParameterDirection.Input),
                new OracleParameter("p_approved_by",OracleDbType.Varchar2,30,oEmpLeaveRegis.ApprovedByID,ParameterDirection.Input),
                new OracleParameter("p_approved_by_hr",OracleDbType.Varchar2,30,oEmpLeaveRegis.ApprovedByHR,ParameterDirection.Input),
                new OracleParameter("p_rpt_prsn_appr_flag",OracleDbType.Varchar2,30,oEmpLeaveRegis.ReptPrsnAppFlag,ParameterDirection.Input),
                new OracleParameter("p_dept_appr_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.DeptAppFlag,ParameterDirection.Input),
                new OracleParameter("p_hr_appr_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.HrAppFlag,ParameterDirection.Input),
                new OracleParameter("p_notification_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.NotificationFlag,ParameterDirection.Input),
                new OracleParameter("p_cancel_cause_rpt_prsn",OracleDbType.Varchar2,3,oEmpLeaveRegis.CancelCauseRptPrsn,ParameterDirection.Input),
                new OracleParameter("p_cancel_cause_id",OracleDbType.Varchar2,3,oEmpLeaveRegis.CancelCauseID,ParameterDirection.Input),
                new OracleParameter("p_cancel_cause_id_hr",OracleDbType.Varchar2,3,oEmpLeaveRegis.CancelCauseIDHr,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,250,oEmpLeaveRegis.Remarks,ParameterDirection.Input),
                new OracleParameter("p_remarks_hr",OracleDbType.Varchar2,250,oEmpLeaveRegis.RemarksHR,ParameterDirection.Input),
                new OracleParameter("p_leave_doc_path",OracleDbType.Varchar2,500,oEmpLeaveRegis.LeaveDocPath,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpLeaveRegis.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpLeaveRegis.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpLeaveRegis.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpLeaveRegis.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpLeaveRegis.EntryParameter.MachineID,ParameterDirection.Input)
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

        #region UpdateLeaveRegister

        public short UpdateLeaveRegister(EmpLeaveRegister oEmpLeaveRegis)
        {
            packagename = "PKG_LEAVE_SETUP.UPDATE_LEAVE_REGISTER";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,oEmpLeaveRegis.Mode,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpLeaveRegis.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_year",OracleDbType.Varchar2,4,oEmpLeaveRegis.year,ParameterDirection.Input),
                new OracleParameter("p_leave_type_id",OracleDbType.Varchar2,4,oEmpLeaveRegis.LeaveType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,oEmpLeaveRegis.StartDate,ParameterDirection.Input), 
                new OracleParameter("p_end_date",OracleDbType.Date,oEmpLeaveRegis.EndDate,ParameterDirection.Input), 
                new OracleParameter("p_with_pays",OracleDbType.Varchar2,5,oEmpLeaveRegis.WithPayDays,ParameterDirection.Input),
                new OracleParameter("p_without_pays",OracleDbType.Varchar2,5,oEmpLeaveRegis.WithoutPayDays,ParameterDirection.Input),
                new OracleParameter("p_leave_cause",OracleDbType.Varchar2,5,oEmpLeaveRegis.LeaveCauseFlag,ParameterDirection.Input),
                new OracleParameter("p_address_while_on_leave",OracleDbType.Varchar2,500,oEmpLeaveRegis.AddrtessWhileOnLeave,ParameterDirection.Input),
                new OracleParameter("p_responsibility_holder_id",OracleDbType.Varchar2,30,oEmpLeaveRegis.ResponsibilityHolderID,ParameterDirection.Input),
                new OracleParameter("p_approved_by_rpt_prsn",OracleDbType.Varchar2,30,oEmpLeaveRegis.ReportingPersonID,ParameterDirection.Input),
                new OracleParameter("p_approved_by",OracleDbType.Varchar2,30,oEmpLeaveRegis.ApprovedByID,ParameterDirection.Input),
                new OracleParameter("p_approved_by_hr",OracleDbType.Varchar2,30,oEmpLeaveRegis.ApprovedByHR,ParameterDirection.Input),
                new OracleParameter("p_rpt_prsn_appr_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.ReptPrsnAppFlag,ParameterDirection.Input),
                new OracleParameter("p_dept_appr_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.DeptAppFlag,ParameterDirection.Input),
                new OracleParameter("p_hr_appr_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.HrAppFlag,ParameterDirection.Input),
                new OracleParameter("p_notification_flag",OracleDbType.Varchar2,1,oEmpLeaveRegis.NotificationFlag,ParameterDirection.Input),
                new OracleParameter("p_cancel_cause_rpt_prsn",OracleDbType.Varchar2,3,oEmpLeaveRegis.CancelCauseRptPrsn,ParameterDirection.Input),
                new OracleParameter("p_cancel_cause_id",OracleDbType.Varchar2,3,oEmpLeaveRegis.CancelCauseID,ParameterDirection.Input),
                new OracleParameter("p_cancel_cause_id_hr",OracleDbType.Varchar2,3,oEmpLeaveRegis.CancelCauseIDHr,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,250,oEmpLeaveRegis.Remarks,ParameterDirection.Input),
                new OracleParameter("p_remarks_hr",OracleDbType.Varchar2,250,oEmpLeaveRegis.RemarksHR,ParameterDirection.Input),
                new OracleParameter("p_leave_doc_path",OracleDbType.Varchar2,500,oEmpLeaveRegis.LeaveDocPath,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpLeaveRegis.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpLeaveRegis.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpLeaveRegis.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpLeaveRegis.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpLeaveRegis.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,250,oEmpLeaveRegis.Serial,ParameterDirection.Input),
                new OracleParameter("p_to",OracleDbType.Varchar2,250,oEmpLeaveRegis.MailTO,ParameterDirection.Input),
                new OracleParameter("p_from",OracleDbType.Varchar2,250,oEmpLeaveRegis.MailFrom,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetRemainingDays
        public List<EmpLeaveRegister> GetRMD(string oEmpID, string oLvType)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_RMD";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpID,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oLvType,ParameterDirection.Input)
           };

            return GetLeaveDays(packageName, parameterList);
        }

        private List<EmpLeaveRegister> GetLeaveDays(string packageName, OracleParameter[] parameterList)
        {
            List<EmpLeaveRegister> oLvRegiss = new List<EmpLeaveRegister>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmpLeaveRegister oLvRegis = new EmpLeaveRegister();
                oLvRegis.RMD = Convert.ToInt32(rdr["RMD"]);

                oLvRegiss.Add(oLvRegis);
            }
            rdr.Close();
            return oLvRegiss;
        }
        #endregion

        #region GetLeaveRequestList

        public List<LeaveRO> GetLeaveRequestListRptPrsn(string EmpID)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_REQUEST_LIST_RPTPRSN";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,10,EmpID,ParameterDirection.Input)
           };

            return GetLeaveRequestListSetup(packageName, parameterList);
        }
        public List<LeaveRO> GetLeaveRequestList(string EmpID)
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_REQUEST_LIST_HD";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,10,EmpID,ParameterDirection.Input)
           };
            return GetLeaveRequestListSetup(packageName, parameterList);
        }
        public List<LeaveRO> GetLeaveRequestListHR()
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_REQUEST_LIST_HR";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
           };

            return GetLeaveRequestListSetup(packageName, parameterList);
        }

        private List<LeaveRO> GetLeaveRequestListSetup(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveRO> oLvRegiss = new List<LeaveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveRO oLvRegis = new LeaveRO();

                oLvRegis.EmpId = (String)rdr["EMP_ID"].ToString();
                oLvRegis.EmpName = (String)rdr["NAME"].ToString();
                oLvRegis.DeptGrpID = (String)rdr["DEPT_GRP"].ToString();
                oLvRegis.DeptGrpTitle = (String)rdr["DEPT_GRP_NAME"].ToString();
                oLvRegis.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oLvRegis.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oLvRegis.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oLvRegis.FormatDept = rdr["FormatDept"].ToString();
                oLvRegis.year = (String)rdr["YEAR"].ToString();           
                oLvRegis.LeaveTypeId = (String)rdr["TYPE_ID"].ToString();
                oLvRegis.LeaveTypeTitle = (String)rdr["TYPE_TITLE"].ToString();

                oLvRegis.StartDate = Convert.ToDateTime((DateTime)rdr["LEAVE_S_DATE"]);
                oLvRegis.EndDate = Convert.ToDateTime((DateTime)rdr["LEAVE_E_DATE"]);
                oLvRegis.LeaveDays = Convert.ToDouble(rdr["LEAVE_DAYS"].ToString());
                oLvRegis.WithPayDays = Convert.ToDouble(rdr["WITH_PAY_DAYS"].ToString());
                oLvRegis.WithoutPayDays = Convert.ToDouble(rdr["WITHOUT_PAY_DAYS"].ToString());
                oLvRegis.LeaveCause = (String)rdr["LEAVE_CAUSE"].ToString();
                oLvRegis.Address = (String)rdr["ADDRESS_WHILE_ON_LEAVE"].ToString();
                oLvRegis.ResponsibilityHolder = (String)rdr["RESPONSIBILITY_HOLDER_ID"].ToString();
                oLvRegis.ResponsibilityHolderName = (String)rdr["RESPONSIBILITYHOLDERNAME"].ToString();
                oLvRegis.ApprovedByRptPrsn = (string)rdr["REPTPSON_ID"].ToString();
                oLvRegis.ApprovedByHead = (string)rdr["ApprovedByHead"].ToString();
                oLvRegis.ApprovedByHR = (string)rdr["ApprovedByHR"].ToString();
                oLvRegis.RptPrsnFlag = (string)rdr["REPTPSON_APPR_FLAG"].ToString();
                oLvRegis.DeptFlag = (string)rdr["DEPT_APPR_FLAG"].ToString();
                oLvRegis.HrFlag = (string)rdr["HR_APPR_FLAG"].ToString();
                oLvRegis.CancelCauseRptPrsn = (string)rdr["CANCEL_CAUSE_ID_RPTPSON"].ToString();
                oLvRegis.CancelCauseHead = (string)rdr["CANCEL_CAUSE_ID"].ToString();
                oLvRegis.CancelCauseHR = (string)rdr["CANCEL_CAUSE_ID_HR"].ToString();
                oLvRegis.RemarksHead = (string)rdr["REMARKS"].ToString();
                oLvRegis.RemarksHR = (string)rdr["REMARKS_HR"].ToString();
                oLvRegis.Serial =Convert.ToDouble(rdr["LEAVE_SERIAL"].ToString());
               
                oLvRegiss.Add(oLvRegis);
            }
            rdr.Close();
            return oLvRegiss;
        }
 #endregion

        #region SaveLeaveCancelCause

        public short SaveLeaveCancelCause(LeaveCancelCause oLvCanCaus)
        {
            packagename = "PKG_LEAVE_SETUP.INSERT_LEAVE_CANCEL_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_cause_id",OracleDbType.Varchar2,4,oLvCanCaus.CauseId,ParameterDirection.Input),
                new OracleParameter("p_title",OracleDbType.Varchar2,50,oLvCanCaus.CauseTitle,ParameterDirection.Input),
                new OracleParameter("p_title_beng",OracleDbType.Varchar2,50,oLvCanCaus.CauseTitleBeng,ParameterDirection.Input),            
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oLvCanCaus.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oLvCanCaus.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oLvCanCaus.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oLvCanCaus.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oLvCanCaus.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oLvCanCaus.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetLeaveCancelCause

        public List<LeaveCancelCause> GetLeaveCancelCause()
        {
            string packageName = "PKG_LEAVE_SETUP.GET_LEAVE_CANCEL_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetLeaveCancelCauses(packageName, parameterList);
        }

        private List<LeaveCancelCause> GetLeaveCancelCauses(string packageName, OracleParameter[] parameterList)
        {
            List<LeaveCancelCause> oLvCanCaus = new List<LeaveCancelCause>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                LeaveCancelCause oLvCanCau = new LeaveCancelCause();
                oLvCanCau.CauseId = (String)rdr["CAUSE_ID"].ToString();
                oLvCanCau.CauseTitle = (String)rdr["TITLE"].ToString();
                oLvCanCau.CauseTitleBeng = (string)rdr["TITLE_BENG"].ToString();
                oLvCanCau.Serial = rdr["SERIAL"].ToString();
                oLvCanCau.Remarks = !rdr.IsDBNull(4) ? (String)rdr["REMARKS"].ToString() : "";
                oLvCanCaus.Add(oLvCanCau);
            }
            rdr.Close();
            return oLvCanCaus;
        }
#endregion

        #region UpdateLeaveCancelCause

        public short UpdateLeaveCancelCause(LeaveCancelCause oLvCanCaus)
        {
            packagename = "PKG_LEAVE_SETUP.UPDATE_LEAVE_CANCEL_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_cause_id",OracleDbType.Varchar2,4,oLvCanCaus.CauseId,ParameterDirection.Input),
                new OracleParameter("p_title",OracleDbType.Varchar2,50,oLvCanCaus.CauseTitle,ParameterDirection.Input),
                new OracleParameter("p_title_beng",OracleDbType.Varchar2,50,oLvCanCaus.CauseTitleBeng,ParameterDirection.Input),             
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oLvCanCaus.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oLvCanCaus.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oLvCanCaus.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oLvCanCaus.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oLvCanCaus.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oLvCanCaus.EntryParameter.MachineID,ParameterDirection.Input)
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
