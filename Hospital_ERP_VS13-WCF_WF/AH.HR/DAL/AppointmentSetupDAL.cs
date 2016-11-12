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
    public class AppointmentSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region SaveAppointmentSetup
        public short SaveAppointmentSetup(Appointment oAppointment)
        {
            packagename = "PKG_APPOINTMENT_SETUP.INSERT_APPOINTMENT_LT_ISSUE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_reff_no",OracleDbType.Varchar2,45,oAppointment.RefferenceNumber,ParameterDirection.Input),
                new OracleParameter("p_appointment_templt_type",OracleDbType.Varchar2,2,oAppointment.AppointTemplType,ParameterDirection.Input),
                new OracleParameter("p_issue_date",OracleDbType.Varchar2,100,oAppointment.IssueDate,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2,100,oAppointment.Name,ParameterDirection.Input),
                new OracleParameter("p_address",OracleDbType.Varchar2,300,oAppointment.Address,ParameterDirection.Input),
                new OracleParameter("p_name_beng",OracleDbType.Varchar2,100,oAppointment.NameBeng,ParameterDirection.Input),
                new OracleParameter("p_address_beng",OracleDbType.Varchar2,300,oAppointment.AddressBeng,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_desig_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("p_job_type_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.JobType,ParameterDirection.Input),
                new OracleParameter("p_recruit_type",OracleDbType.Varchar2,1,oAppointment.EmployeeJobInformation.RecruitmentType,ParameterDirection.Input),
                new OracleParameter("p_contract_period",OracleDbType.Varchar2,3,oAppointment.ContractPeriod,ParameterDirection.Input),
                new OracleParameter("p_contract_upto",OracleDbType.Varchar2,100,oAppointment.ContractUpto,ParameterDirection.Input),
                new OracleParameter("p_doj_within",OracleDbType.Varchar2,100,oAppointment.DOJWithin,ParameterDirection.Input),
                new OracleParameter("p_effect_from",OracleDbType.Varchar2,100,oAppointment.EffectFrom,ParameterDirection.Input),
                new OracleParameter("p_consolidate_amt",OracleDbType.Varchar2,100,oAppointment.ConssolidateAmount,ParameterDirection.Input),
                new OracleParameter("p_probation_period",OracleDbType.Varchar2,3,oAppointment.ProbationPeriod,ParameterDirection.Input),
                new OracleParameter("p_compliance_with",OracleDbType.Varchar2,200,oAppointment.ComplianceWith,ParameterDirection.Input),
                new OracleParameter("p_cc_list",OracleDbType.Varchar2,500,oAppointment.CCList,ParameterDirection.Input),
                new OracleParameter("p_hr_manager_id",OracleDbType.Varchar2,5,oAppointment.HRManagerID,ParameterDirection.Input),
                new OracleParameter("p_prepared_by",OracleDbType.Varchar2,5,oAppointment.PreparedBy,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oAppointment.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oAppointment.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oAppointment.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oAppointment.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateAppointmentSetup
        public short UpdateAppointmentSetup(Appointment oAppointment)
        {
            packagename = "PKG_APPOINTMENT_SETUP.UPDATE_APPOINTMENT_LT_ISSUE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_reff_no",OracleDbType.Varchar2,45,oAppointment.RefferenceNumber,ParameterDirection.Input),
                new OracleParameter("p_appointment_templt_type",OracleDbType.Varchar2,2,oAppointment.AppointTemplType,ParameterDirection.Input),
                new OracleParameter("p_issue_date",OracleDbType.Varchar2,100,oAppointment.IssueDate,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2,100,oAppointment.Name,ParameterDirection.Input),
                new OracleParameter("p_address",OracleDbType.Varchar2,300,oAppointment.Address,ParameterDirection.Input),
                new OracleParameter("p_name_beng",OracleDbType.Varchar2,100,oAppointment.NameBeng,ParameterDirection.Input),
                new OracleParameter("p_address_beng",OracleDbType.Varchar2,300,oAppointment.AddressBeng,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_desig_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("p_job_type_id",OracleDbType.Varchar2,5,oAppointment.EmployeeJobInformation.JobType,ParameterDirection.Input),
                new OracleParameter("p_recruit_type",OracleDbType.Varchar2,1,oAppointment.EmployeeJobInformation.RecruitmentType,ParameterDirection.Input),
                new OracleParameter("p_contract_period",OracleDbType.Varchar2,3,oAppointment.ContractPeriod,ParameterDirection.Input),
                new OracleParameter("p_contract_upto",OracleDbType.Varchar2,100,oAppointment.ContractUpto,ParameterDirection.Input),
                new OracleParameter("p_doj_within",OracleDbType.Varchar2,100,oAppointment.DOJWithin,ParameterDirection.Input),
                new OracleParameter("p_effect_from",OracleDbType.Varchar2,100,oAppointment.EffectFrom,ParameterDirection.Input),
                new OracleParameter("p_consolidate_amt",OracleDbType.Varchar2,100,oAppointment.ConssolidateAmount,ParameterDirection.Input),
                new OracleParameter("p_probation_period",OracleDbType.Varchar2,3,oAppointment.ProbationPeriod,ParameterDirection.Input),
                new OracleParameter("p_compliance_with",OracleDbType.Varchar2,200,oAppointment.ComplianceWith,ParameterDirection.Input),
                new OracleParameter("p_cc_list",OracleDbType.Varchar2,500,oAppointment.CCList,ParameterDirection.Input),
                new OracleParameter("p_hr_manager_id",OracleDbType.Varchar2,5,oAppointment.HRManagerID,ParameterDirection.Input),
                new OracleParameter("p_prepared_by",OracleDbType.Varchar2,5,oAppointment.PreparedBy,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oAppointment.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oAppointment.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oAppointment.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oAppointment.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetAppointmentSetup
        public List<Appointment> GetAppointmentSetup(string ReffNumber)
        {
            string packageName = "PKG_APPOINTMENT_SETUP.GET_APPOINTMENT_LT_ISSUE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_reff_number",OracleDbType.Varchar2,45,ReffNumber,ParameterDirection.Input),               
            };
            return GetAppointmentSetupDetails(packageName, parameterList);

        }
        private List<Appointment> GetAppointmentSetupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Appointment> oAppointments = new List<Appointment>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                Appointment oAppointment = new Appointment();
                EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
                oAppointment.RefferenceNumber = rdr["REFF_NO"].ToString();
                oAppointment.AppointTemplType = (string)rdr["APPOINT_TEMPL_TYPE"].ToString();
                oAppointment.IssueDate =Convert.ToDateTime(rdr["ISSUE_DATE"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.ContractPeriod = (string)rdr["CONTRACT_PERIOD"].ToString();
                oAppointment.ContractUpto = Convert.ToDateTime(rdr["CONTRACT_UPTO"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.DOJWithin = Convert.ToDateTime(rdr["DOJ_WITHIN"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.EffectFrom = Convert.ToDateTime(rdr["EFFECT_FROM"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.ConssolidateAmount = (string)rdr["CONSOLIDATE_AMT"].ToString();
                oAppointment.ProbationPeriod = (string)rdr["PROBATION_PERIOD"].ToString();
                oAppointment.Name = (String)rdr["NAME"].ToString();
                oAppointment.Address = rdr["ADDRESS"].ToString();
                oAppointment.NameBeng = rdr["NAME_BENG"] != DBNull.Value ? (string)rdr["NAME_BENG"].ToString() : "";
                oAppointment.AddressBeng = rdr["ADDRESS_BENG"] != DBNull.Value ? (string)rdr["ADDRESS_BENG"].ToString() : "";
                oAppointment.HRManagerID = rdr["HR_MANAGER_ID"].ToString();
                oAppointment.HRManagerName = rdr["HR_MANAGER_Name"].ToString();
                oAppointment.PreparedBy = rdr["PREPARED_BY"].ToString();
                oAppointment.PreparedByName = rdr["PREPARED_BY_name"].ToString();
                oAppointment.ComplianceWith = rdr["COMPLIANCE_WITH"].ToString();
                oAppointment.CCList = rdr["CC_LIST"].ToString();
               
                DepartmentGroup ogrp = new DepartmentGroup();
                ogrp.DepartmentGroupID = (string)rdr["DEPT_GRP"].ToString();
                DepartmentType oDeptType = new DepartmentType();
                oDeptType.TypeID = rdr["DEPT_TYPE"].ToString();
                ogrp.DepartmentType = oDeptType;
                oEmpJobInfo.DepartmentGroup = ogrp;

                Department oDept = new Department();               
                oDept.DepartmentID = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oEmpJobInfo.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oEmpJobInfo.DepartmentUnit = oDeptUnit;

                Designation oDesig = new Designation();
                oDesig.DesignationId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oDesig.DesignationTitle = rdr["dsig_title"] != DBNull.Value ? (string)rdr["dsig_title"] : "";
                oEmpJobInfo.Designation = oDesig;

                oEmpJobInfo.JobType = (string)rdr["JOB_TYPE_ID"].ToString();
                oEmpJobInfo.RecruitmentType = (string)rdr["RECRUIT_TYPE"].ToString();

                oAppointment.EmployeeJobInformation = oEmpJobInfo;

                oAppointments.Add(oAppointment);
            }
            rdr.Close();
            return oAppointments;

        }
        #endregion

        #region GetAppointmentLetter
        public List<AppointmentRO> GetAppointmentLetter(string ReffNumber)
        {
            string packageName = "PKG_APPOINTMENT_SETUP.GET_APPOINTMENT_LT_ISSUE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_reff_number",OracleDbType.Varchar2,45,ReffNumber,ParameterDirection.Input),               
            };
            return GetAppointmentLetterDetails(packageName, parameterList);

        }
        private List<AppointmentRO> GetAppointmentLetterDetails(string packageName, OracleParameter[] parameterList)
        {
            List<AppointmentRO> oAppointments = new List<AppointmentRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AppointmentRO oAppointment = new AppointmentRO();
                oAppointment.RefferenceNumber = rdr["REFF_NO"].ToString();
                oAppointment.AppointTemplType = (string)rdr["APPOINT_TEMPL_TYPE"].ToString();
                oAppointment.IssueDate = Convert.ToDateTime(rdr["ISSUE_DATE"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.ContractPeriod = (string)rdr["CONTRACT_PERIOD"].ToString();
                oAppointment.ContractUpto = Convert.ToDateTime(rdr["CONTRACT_UPTO"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.DOJWithin = Convert.ToDateTime(rdr["DOJ_WITHIN"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.EffectFrom = Convert.ToDateTime(rdr["EFFECT_FROM"].ToString()).ToString("dd/MM/yyyy");
                oAppointment.ConssolidateAmount = (string)rdr["CONSOLIDATE_AMT"].ToString();
                oAppointment.ProbationPeriod = (string)rdr["PROBATION_PERIOD"].ToString();
                oAppointment.Name = (String)rdr["NAME"].ToString();
                oAppointment.Address = rdr["ADDRESS"].ToString();
                oAppointment.NameBeng = rdr["NAME_BENG"] != DBNull.Value ? (string)rdr["NAME_BENG"].ToString() : "";
                oAppointment.AddressBeng = rdr["ADDRESS_BENG"] != DBNull.Value ? (string)rdr["ADDRESS_BENG"].ToString() : "";
                oAppointment.HRManagerID = rdr["HR_MANAGER_ID"].ToString();
                oAppointment.HRManagerName = rdr["HR_MANAGER_Name"].ToString();
                oAppointment.PreparedBy = rdr["PREPARED_BY"].ToString();
                oAppointment.PreparedByName = rdr["PREPARED_BY_name"].ToString();
                oAppointment.ComplianceWith = rdr["COMPLIANCE_WITH"].ToString();
                oAppointment.CCList = rdr["CC_LIST"].ToString();
                oAppointment.DeptGrpID = (string)rdr["DEPT_GRP"].ToString();
                oAppointment.DeptTypeID = rdr["DEPT_TYPE"].ToString();
                oAppointment.DeptID = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oAppointment.UnitID = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oAppointment.DesigID = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oAppointment.DesigTitle = rdr["dsig_title"] != DBNull.Value ? (string)rdr["dsig_title"] : "";
                oAppointment.JobType = (string)rdr["JOB_TYPE_ID"].ToString();
                oAppointment.RecruitmentType = (string)rdr["RECRUIT_TYPE"].ToString();

                oAppointments.Add(oAppointment);
            }
            rdr.Close();
            return oAppointments;

        }
        #endregion
    }
}
