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
    public class EmployeeInformationSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packageName = string.Empty;

        #region SaveEmployeeJobInformation

        public short SaveEmployeeJobInformation(EmployeeJobInformation oEmpJobInfo)
        {
            packageName = "PKG_EMP_SETUP.INSERT_EMP_JOB_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpJobInfo.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oEmpJobInfo.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oEmpJobInfo.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oEmpJobInfo.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_design_id",OracleDbType.Varchar2,5,oEmpJobInfo.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("p_class_id",OracleDbType.Varchar2,5,oEmpJobInfo.Class,ParameterDirection.Input),
                new OracleParameter("p_job_type_id",OracleDbType.Varchar2,5,oEmpJobInfo.JobType,ParameterDirection.Input),
                new OracleParameter("p_recruitment_type",OracleDbType.Varchar2,2,oEmpJobInfo.RecruitmentType,ParameterDirection.Input),
                new OracleParameter("p_job_head_id",OracleDbType.Varchar2,30,oEmpJobInfo.DeptHead,ParameterDirection.Input),
                new OracleParameter("p_reporting_person_id",OracleDbType.Varchar2,30,oEmpJobInfo.ReportingPerson,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,oEmpJobInfo.StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Date,oEmpJobInfo.EndDate,ParameterDirection.Input),
                new OracleParameter("p_retire_date",OracleDbType.Date,30,oEmpJobInfo.RetireDate,ParameterDirection.Input),
                new OracleParameter("p_transfer_date",OracleDbType.Date,30,oEmpJobInfo.TransferDate,ParameterDirection.Input),
                new OracleParameter("p_service_book_reff_no",OracleDbType.Varchar2,200,oEmpJobInfo.ServiceBookReffNo,ParameterDirection.Input),
                new OracleParameter("p_job_desc",OracleDbType.Varchar2,500,oEmpJobInfo.JobDesc,ParameterDirection.Input),
                new OracleParameter("p_job_update_cause_type",OracleDbType.Varchar2,2,oEmpJobInfo.JobUpdateCauseType,ParameterDirection.Input),
                new OracleParameter("p_responsibilities",OracleDbType.Varchar2,100,oEmpJobInfo.Responsibilities,ParameterDirection.Input),
                new OracleParameter("p_office_order_no",OracleDbType.Varchar2,400,oEmpJobInfo.OfficeOrderNo,ParameterDirection.Input),
                new OracleParameter("p_consolidate_scal_flag",OracleDbType.Varchar2,1,oEmpJobInfo.ConsolidateScaleFlag,ParameterDirection.Input),
                new OracleParameter("p_consolidate_amt",OracleDbType.Double,100,oEmpJobInfo.ConsolidatedAmount,ParameterDirection.Input),
                new OracleParameter("p_sal_grade_id",OracleDbType.Varchar2,30,oEmpJobInfo.SalGradeID,ParameterDirection.Input),
                new OracleParameter("p_sal_scale_id",OracleDbType.Varchar2,30,oEmpJobInfo.SalScaleID,ParameterDirection.Input),
                new OracleParameter("p_serial_no",OracleDbType.Varchar2,30,oEmpJobInfo.SerialNo,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpJobInfo.Entryparameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpJobInfo.Entryparameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmpJobInfo.Entryparameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmpJobInfo.Entryparameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpJobInfo.Entryparameter.MachineID,ParameterDirection.Input),
                new OracleParameter("p_test_subs",OracleDbType.Varchar2,20000,oEmpJobInfo.BenefitString,ParameterDirection.Input)
                   
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region EmpIDGenerateEmployeeMasterDictionary

        public List<EmployeeMaster> GetEmployeeDictionary()
        {
            string packageName = "PKG_EMP_INFO.GET_EMP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetEmployeeMaster(packageName, parameterList);
        }

        private List<EmployeeMaster> GetEmployeeMaster(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oEmployeeMasters = new List<EmployeeMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmployeeMaster.EmpNameBeng = (string)rdr["EMP_NAME_BENG"].ToString();

                oEmployeeMasters.Add(oEmployeeMaster);
            }
            rdr.Close();
            return oEmployeeMasters;

        }
    #endregion

        #region GetEMP
        public List<EmployeeMaster> GetEmp()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_EMP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetEmpInfo(packageName, parameterList);
        }

        private List<EmployeeMaster> GetEmpInfo(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oSals = new List<EmployeeMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMaster oSal = new EmployeeMaster();
                oSal.EmpId = (String)rdr["EMP_ID"].ToString();
                oSal.EmpNameBeng = (String)rdr["EMP_NAME_BENG"].ToString();
                oSals.Add(oSal);
            }
            rdr.Close();
            return oSals;
        }
        #endregion

        #region GetEmployeeJobInformation
        public List<EmployeeJobInformation> GetEmployeeJobInfo()
        {
            string packageName = "PKG_EMP_SETUP.GET_EMP_JOB_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetEmpJobInformation(packageName, parameterList);

        }

        public List<EmployeeJobInformation> GetEmployeeJobInformation(string oEmpJobInfo)
        {
            string packageName = "PKG_EMP_SETUP.GET_EMP_JOB_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpJobInfo,ParameterDirection.Input)
            };
            return GetEmpJobInformation(packageName, parameterList);

        }
        public EmployeeJobInformation GetEmployeeCurrentJobInformation(string oEmpJobInfo)
        {
            string packageName = "PKG_EMP_SETUP.GET_EMP_CURRENT_JOB_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpJobInfo,ParameterDirection.Input)
            };
            return GetEmpCurrentJobInformation(packageName, parameterList);

        }

        private List<EmployeeJobInformation> GetEmpJobInformation(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeJobInformation> oEmpJobInfos = new List<EmployeeJobInformation>();

            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmpJobInfo.EmployeeMaster = oEmployeeMaster;

                DeptUnitAss oDeptUnitAss = new DeptUnitAss();
    
                Department oDept = new Department();
                DepartmentGroup ogrp = new DepartmentGroup();
                DepartmentType oType = new DepartmentType();
                oType.TypeID = rdr["DEPT_TYPE"] != DBNull.Value ? (string)rdr["DEPT_TYPE"] : "";
                oDept.DepartmentType = oType;

                ogrp.DepartmentGroupID = rdr["DEPT_GRP"] != DBNull.Value ? (string)rdr["DEPT_GRP"] : "";
                oDept.DepartmentGroup = ogrp;
               
                oDept.DepartmentID = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oDept.DepartmentTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oEmpJobInfo.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oDeptUnit.UnitTitle = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"] : "";
                oEmpJobInfo.DepartmentUnit = oDeptUnit;

                Designation oDesig = new Designation();
                oDesig.DesignationId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oDesig.DesignationTitle = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"] : "";
                oEmpJobInfo.Designation = oDesig;

                oEmpJobInfo.Class = rdr["CLASS_ID"] != DBNull.Value ? (string)rdr["CLASS_ID"] : "";
                oEmpJobInfo.JobType = rdr["JOB_TYPE_ID"] != DBNull.Value ? (string)rdr["JOB_TYPE_ID"] : "";
                oEmpJobInfo.RecruitmentType = rdr["RECRUIT_TYPE"] != DBNull.Value ? (string)rdr["RECRUIT_TYPE"] : "";
                oEmpJobInfo.DeptHead = rdr["DEPT_HEAD_ID"] != DBNull.Value ? (string)rdr["DEPT_HEAD_ID"] : "";
                oEmpJobInfo.DeptHeadName = rdr["DEPT_HEAD_NAME"] != DBNull.Value ? (string)rdr["DEPT_HEAD_NAME"] : "";
                oEmpJobInfo.ReportingPerson = rdr["REPORTING_PERSON_ID"] != DBNull.Value ? (string)rdr["REPORTING_PERSON_ID"] : "";
                oEmpJobInfo.ReportingPersonName = rdr["REPORTING_PERSON_NAME"] != DBNull.Value ? (string)rdr["REPORTING_PERSON_NAME"] : "";
                if (rdr["START_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.StartDate = null;
                }
                else
                {
                    oEmpJobInfo.StartDate = Convert.ToDateTime((DateTime)rdr["START_DATE"]);
                }
                if (rdr["END_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.EndDate = null;
                }
                else
                {
                    oEmpJobInfo.EndDate = Convert.ToDateTime((DateTime)rdr["END_DATE"]);
                }
                if (rdr["RETIRE_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.RetireDate = null;
                }
                else
                {
                    oEmpJobInfo.RetireDate = Convert.ToDateTime((DateTime)rdr["RETIRE_DATE"]);
                }
                if (rdr["TRANSFER_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.TransferDate = null;
                }
                else
                {
                    oEmpJobInfo.TransferDate = Convert.ToDateTime((DateTime)rdr["TRANSFER_DATE"]);
                }
                oEmpJobInfo.ServiceBookReffNo = rdr["SERVICE_BOOK_REFF_NO"] != DBNull.Value ? (string)rdr["SERVICE_BOOK_REFF_NO"] : "";
                oEmpJobInfo.JobDesc = rdr["JOB_DESC"] != DBNull.Value ? (string)rdr["JOB_DESC"].ToString() : "";
                oEmpJobInfo.JobUpdateCauseType = rdr["JOB_UPDATE_CAUSE_TYPE"] != DBNull.Value ? (string)rdr["JOB_UPDATE_CAUSE_TYPE"] : "";
                oEmpJobInfo.Responsibilities = rdr["RESPONSIBILITIES"] != DBNull.Value ? (string)rdr["RESPONSIBILITIES"] : "";

                oEmpJobInfo.OfficeOrderNo = rdr["OFFICE_ORD_NO"] != DBNull.Value ? (string)rdr["OFFICE_ORD_NO"] : "";

                oEmpJobInfo.ConsolidateScaleFlag = rdr["CONSOLIDATE_SCAL_FLAG"] != DBNull.Value ? (string)rdr["CONSOLIDATE_SCAL_FLAG"].ToString() : "";
                oEmpJobInfo.ConsolidatedAmount = Convert.ToInt64(rdr["CONSOLIDATED_AMT"]);
                oEmpJobInfo.SalGradeID = rdr["Grade"] != DBNull.Value ? rdr["Grade"].ToString() : "";
                oEmpJobInfo.SalScaleID = rdr["Scale"] != DBNull.Value ? rdr["Scale"].ToString() : "";
                oEmpJobInfo.SerialNo = rdr["SERIAL_NO"] != DBNull.Value ? rdr["SERIAL_NO"].ToString() : "";

                oEmpJobInfos.Add(oEmpJobInfo);
            }
            rdr.Close();
            return oEmpJobInfos;

        }

         private EmployeeJobInformation GetEmpCurrentJobInformation(string packageName, OracleParameter[] parameterList)
        {
            EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {                
                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmpJobInfo.EmployeeMaster = oEmployeeMaster;
               
                Department oDept = new Department();
                DepartmentGroup ogrp = new DepartmentGroup();
                DepartmentType oType = new DepartmentType();
                oType.TypeID = rdr["DEPT_TYPE"] != DBNull.Value ? (string)rdr["DEPT_TYPE"] : "";
                oDept.DepartmentType = oType;

                ogrp.DepartmentGroupID = rdr["DEPT_GRP"] != DBNull.Value ? (string)rdr["DEPT_GRP"] : "";
                oDept.DepartmentGroup = ogrp;
               
                oDept.DepartmentID = rdr["DEPT_ID"] != DBNull.Value ? (string)rdr["DEPT_ID"] : "";
                oDept.DepartmentTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oEmpJobInfo.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"] != DBNull.Value ? (string)rdr["UNIT_ID"] : "";
                oDeptUnit.UnitTitle = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"] : "";
                oEmpJobInfo.DepartmentUnit = oDeptUnit;

                Designation oDesig = new Designation();
                oDesig.DesignationId = rdr["DESIG_ID"] != DBNull.Value ? (string)rdr["DESIG_ID"] : "";
                oDesig.DesignationTitle = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"] : "";
                oEmpJobInfo.Designation = oDesig;

                oEmpJobInfo.Class = rdr["CLASS_ID"] != DBNull.Value ? (string)rdr["CLASS_ID"] : "";
                oEmpJobInfo.JobType = rdr["JOB_TYPE_ID"] != DBNull.Value ? (string)rdr["JOB_TYPE_ID"] : "";
                oEmpJobInfo.RecruitmentType = rdr["RECRUIT_TYPE"] != DBNull.Value ? (string)rdr["RECRUIT_TYPE"] : "";
                oEmpJobInfo.DeptHead = rdr["DEPT_HEAD_ID"] != DBNull.Value ? (string)rdr["DEPT_HEAD_ID"] : "";
                oEmpJobInfo.DeptHeadName = rdr["DEPT_HEAD_NAME"] != DBNull.Value ? (string)rdr["DEPT_HEAD_NAME"] : "";
                oEmpJobInfo.ReportingPerson = rdr["REPORTING_PERSON_ID"] != DBNull.Value ? (string)rdr["REPORTING_PERSON_ID"] : "";
                oEmpJobInfo.ReportingPersonName = rdr["REPORTING_PERSON_NAME"] != DBNull.Value ? (string)rdr["REPORTING_PERSON_NAME"] : "";
                if (rdr["START_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.StartDate = null;
                }
                else
                {
                    oEmpJobInfo.StartDate = Convert.ToDateTime((DateTime)rdr["START_DATE"]);
                }
                if (rdr["END_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.EndDate = null;
                }
                else
                {
                    oEmpJobInfo.EndDate = Convert.ToDateTime((DateTime)rdr["END_DATE"]);
                }
                if (rdr["RETIRE_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.RetireDate = null;
                }
                else
                {
                    oEmpJobInfo.RetireDate = Convert.ToDateTime((DateTime)rdr["RETIRE_DATE"]);
                }
                if (rdr["TRANSFER_DATE"] == DBNull.Value)
                {
                    oEmpJobInfo.TransferDate = null;
                }
                else
                {
                    oEmpJobInfo.TransferDate = Convert.ToDateTime((DateTime)rdr["TRANSFER_DATE"]);
                }
                oEmpJobInfo.ServiceBookReffNo = rdr["SERVICE_BOOK_REFF_NO"] != DBNull.Value ? (string)rdr["SERVICE_BOOK_REFF_NO"] : "";
                oEmpJobInfo.JobDesc = rdr["JOB_DESC"] != DBNull.Value ? (string)rdr["JOB_DESC"].ToString() : "";
                oEmpJobInfo.JobUpdateCauseType = rdr["JOB_UPDATE_CAUSE_TYPE"] != DBNull.Value ? (string)rdr["JOB_UPDATE_CAUSE_TYPE"] : "";
                oEmpJobInfo.Responsibilities = rdr["RESPONSIBILITIES"] != DBNull.Value ? (string)rdr["RESPONSIBILITIES"] : "";

                oEmpJobInfo.OfficeOrderNo = rdr["OFFICE_ORD_NO"] != DBNull.Value ? (string)rdr["OFFICE_ORD_NO"] : "";

                oEmpJobInfo.ConsolidateScaleFlag = rdr["CONSOLIDATE_SCAL_FLAG"] != DBNull.Value ? (string)rdr["CONSOLIDATE_SCAL_FLAG"].ToString() : "";
                oEmpJobInfo.ConsolidatedAmount = Convert.ToInt64(rdr["CONSOLIDATED_AMT"]);
                oEmpJobInfo.SalGradeID = rdr["Grade"] != DBNull.Value ? rdr["Grade"].ToString() : "";
                oEmpJobInfo.SalScaleID = rdr["Scale"] != DBNull.Value ? rdr["Scale"].ToString() : "";
                oEmpJobInfo.SerialNo = rdr["SERIAL_NO"] != DBNull.Value ? rdr["SERIAL_NO"].ToString() : "";
            }
            rdr.Close();
            return oEmpJobInfo;

        }
        #endregion

        #region UpdateEmployeeJobInformation
        public short UpdateEmployeeJobInformation(EmployeeJobInformation oEmpUpdateJob)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_JOB_INFO";
            OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpUpdateJob.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oEmpUpdateJob.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oEmpUpdateJob.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oEmpUpdateJob.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_design_id",OracleDbType.Varchar2,5,oEmpUpdateJob.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("p_class_id",OracleDbType.Varchar2,5,oEmpUpdateJob.Class,ParameterDirection.Input),
                new OracleParameter("p_job_type_id",OracleDbType.Varchar2,5,oEmpUpdateJob.JobType,ParameterDirection.Input),
                new OracleParameter("p_recruitment_type",OracleDbType.Varchar2,5,oEmpUpdateJob.RecruitmentType,ParameterDirection.Input),
                new OracleParameter("p_job_head_id",OracleDbType.Varchar2,30,oEmpUpdateJob.DeptHead,ParameterDirection.Input),
                new OracleParameter("p_reporting_person_id",OracleDbType.Varchar2,30,oEmpUpdateJob.ReportingPerson,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,oEmpUpdateJob.StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Date,oEmpUpdateJob.EndDate,ParameterDirection.Input),
                new OracleParameter("p_retire_date",OracleDbType.Date,30,oEmpUpdateJob.RetireDate,ParameterDirection.Input),
                new OracleParameter("p_transfer_date",OracleDbType.Date,30,oEmpUpdateJob.TransferDate,ParameterDirection.Input),
                new OracleParameter("p_service_book_reff_no",OracleDbType.Varchar2,200,oEmpUpdateJob.ServiceBookReffNo,ParameterDirection.Input),
                new OracleParameter("p_job_desc",OracleDbType.Varchar2,500,oEmpUpdateJob.JobDesc,ParameterDirection.Input),
                new OracleParameter("p_job_update_cause_type",OracleDbType.Varchar2,2,oEmpUpdateJob.JobUpdateCauseType,ParameterDirection.Input),
                new OracleParameter("p_responsibilities",OracleDbType.Varchar2,100,oEmpUpdateJob.Responsibilities,ParameterDirection.Input),
                new OracleParameter("p_office_order_no",OracleDbType.Varchar2,400,oEmpUpdateJob.OfficeOrderNo,ParameterDirection.Input),
                new OracleParameter("p_consolidate_scal_flag",OracleDbType.Varchar2,1,oEmpUpdateJob.ConsolidateScaleFlag,ParameterDirection.Input),
                new OracleParameter("p_consolidate_amt",OracleDbType.Double,100,oEmpUpdateJob.ConsolidatedAmount,ParameterDirection.Input),
                new OracleParameter("p_sal_grade_id",OracleDbType.Varchar2,30,oEmpUpdateJob.SalGradeID,ParameterDirection.Input),
                new OracleParameter("p_sal_scale_id",OracleDbType.Varchar2,30,oEmpUpdateJob.SalScaleID,ParameterDirection.Input),
                new OracleParameter("p_serial_no",OracleDbType.Varchar2,30,oEmpUpdateJob.SerialNo,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpUpdateJob.Entryparameter.UpdateBy,ParameterDirection.Input) ,
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmpUpdateJob.Entryparameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmpUpdateJob.Entryparameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpUpdateJob.Entryparameter.MachineID,ParameterDirection.Input),                      
                new OracleParameter("p_test_subs",OracleDbType.Varchar2,20000,oEmpUpdateJob.BenefitString,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion 

        #region GetEmployeeFringeBenefit
        public List<EmployeeJobInformation> GetEmployeeFringeBenefit()
        {
            string packageName = "PKG_EMP_SETUP.GET_EMP_FRINGE_BENEFIT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetEmpFringeBenefitInformation(packageName, parameterList);

        }
     
        private List<EmployeeJobInformation> GetEmpFringeBenefitInformation(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeJobInformation> oEmpJobInfos = new List<EmployeeJobInformation>();

            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmpJobInfo.EmployeeMaster = oEmployeeMaster;
                oEmpJobInfo.SerialNo = (string)rdr["JOB_SERIAL"].ToString();
                FringeBenefit oBenefit = new FringeBenefit();
                oBenefit.Serial = (string)rdr["BENEFIT_SERIAL"].ToString();
                oBenefit.BenID = (string)rdr["BENEFIT_ID"];
                oBenefit.BenTitle = (string)rdr["benefit_title"];
                oBenefit.Amount = (string)rdr["AMOUNT"].ToString();
                oBenefit.EffectiveDate =Convert.ToDateTime(rdr["EFFECTIVE_DATE"].ToString());
                oEmpJobInfo.FringeBenefit = oBenefit;

                oEmpJobInfos.Add(oEmpJobInfo);
            }
            rdr.Close();
            return oEmpJobInfos;
        }
        #endregion
        
        #region SaveEmployeePreviousExperience
        public string SaveEmployeePreviousExperiencen(EmployeePreviousExperience oEmpPrevExp)
        {
            packageName = "PKG_EMP_INFO.INSERT_EMP_PREV_EXP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Varchar2,30,oEmpPrevExp.serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpPrevExp.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_org_name",OracleDbType.Varchar2,500,oEmpPrevExp.OrganizationName,ParameterDirection.Input),
                new OracleParameter("p_design_id",OracleDbType.Varchar2,300,oEmpPrevExp.Designation,ParameterDirection.Input),          
                new OracleParameter("p_job_desc",OracleDbType.Varchar2,500,oEmpPrevExp.JobDesc,ParameterDirection.Input),
                new OracleParameter("p_doj",OracleDbType.Date,oEmpPrevExp.DoJ,ParameterDirection.Input),
                new OracleParameter("p_dor",OracleDbType.Date,oEmpPrevExp.DoR,ParameterDirection.Input),
                new OracleParameter("p_resign_cause",OracleDbType.Varchar2,oEmpPrevExp.ResignCause,ParameterDirection.Input),             
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpPrevExp.Entryparameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpPrevExp.Entryparameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmpPrevExp.Entryparameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmpPrevExp.Entryparameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpPrevExp.Entryparameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }
        #endregion

        #region GetEmployeePreviousExperience
        public List<EmployeePreviousExperience> GetEmployeePreviousExperience()
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_PREV_EXP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetEmpPrevExp(packageName, parameterList);

        }
        public List<EmployeePreviousExperience> GetEmpPreviousExperience(string emp)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_PREV_EXP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,emp,ParameterDirection.Input),
            };
            return GetEmpPrevExp(packageName, parameterList);

        }

        private List<EmployeePreviousExperience> GetEmpPrevExp(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeePreviousExperience> oEmpPrevExps = new List<EmployeePreviousExperience>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeePreviousExperience oEmpPrevExp = new EmployeePreviousExperience();

                EmployeeMaster oEmp = new EmployeeMaster();
                oEmp.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmp.Name = (string)rdr["EmployeeName"].ToString();
                oEmpPrevExp.EmployeeMaster = oEmp;

                oEmpPrevExp.serial = (string)rdr["serial_no"].ToString();
                oEmpPrevExp.OrganizationName = (string)rdr["ORG_NAME"].ToString();

                oEmpPrevExp.Designation = (string)rdr["DESIGNATION"].ToString();
              
                oEmpPrevExp.JobDesc = (string)rdr["JOB_DESC"].ToString();

                oEmpPrevExp.DoJ = (DateTime)rdr["DOJ"];
                oEmpPrevExp.DoR = (DateTime)rdr["DOR"];
                oEmpPrevExp.ResignCause = (string)rdr["RESIGN_CAUSE"].ToString();

                oEmpPrevExps.Add(oEmpPrevExp);
            }
            rdr.Close();
            return oEmpPrevExps;

        }
        #endregion

        #region UpdateEmployeePreviousExperience

        public short UpdateEmployeePreviousExperience(EmployeePreviousExperience oEmpUpdatePrevExp)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_PREV_EXP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Varchar2,30,oEmpUpdatePrevExp.serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpUpdatePrevExp.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_org_name",OracleDbType.Varchar2,500,oEmpUpdatePrevExp.OrganizationName,ParameterDirection.Input),
                new OracleParameter("p_design_id",OracleDbType.Varchar2,500,oEmpUpdatePrevExp.Designation,ParameterDirection.Input),          
                new OracleParameter("p_job_desc",OracleDbType.Varchar2,500,oEmpUpdatePrevExp.JobDesc,ParameterDirection.Input),
                new OracleParameter("p_doj",OracleDbType.Date,oEmpUpdatePrevExp.DoJ,ParameterDirection.Input),
                new OracleParameter("p_dor",OracleDbType.Date,oEmpUpdatePrevExp.DoR,ParameterDirection.Input),
                new OracleParameter("p_resign_cause",OracleDbType.Varchar2,oEmpUpdatePrevExp.ResignCause,ParameterDirection.Input),     
                new OracleParameter("p_active",OracleDbType.Char,100,oEmpUpdatePrevExp.Entryparameter.Active,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpUpdatePrevExp.Entryparameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpUpdatePrevExp.Entryparameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmpUpdatePrevExp.Entryparameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmpUpdatePrevExp.Entryparameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpUpdatePrevExp.Entryparameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }

        #endregion       

        #region SaveEmployeeTraining
        public short SaveEmployeeTraining(EmployeeTraining oEmpTraning)
        {
            packageName = "PKG_EMP_INFO.INSERT_EMP_TRAINING";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Varchar2,30,oEmpTraning.Serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpTraning.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_training_title",OracleDbType.NVarchar2,500,oEmpTraning.TrainingTitle,ParameterDirection.Input),
                new OracleParameter("p_training_type",OracleDbType.NVarchar2,2,oEmpTraning.TrainingType,ParameterDirection.Input),
                new OracleParameter("p_org_name",OracleDbType.NVarchar2,300,oEmpTraning.OrganizationName,ParameterDirection.Input),
                new OracleParameter("p_provided_by",OracleDbType.NVarchar2,30,oEmpTraning.ProvidedBy,ParameterDirection.Input),          
                new OracleParameter("p_subject",OracleDbType.NVarchar2,400,oEmpTraning.Subject,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,oEmpTraning.StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Date,oEmpTraning.EndDate,ParameterDirection.Input),
                new OracleParameter("p_grade",OracleDbType.Varchar2,30,oEmpTraning.Grade,ParameterDirection.Input), 
                new OracleParameter("p_remarks",OracleDbType.Varchar2,500,oEmpTraning.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpTraning.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpTraning.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmpTraning.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmpTraning.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpTraning.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetEmployeeTraning
        public List<EmployeeTraining> GetEmployeeTraining()
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_TRAINING";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetEmpTran(packageName, parameterList);

        }

        public List<EmployeeTraining> GetEmpTraining(string emp)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_TRAINING";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,emp,ParameterDirection.Input),
            };
            return GetEmpTran(packageName, parameterList);

        }

        private List<EmployeeTraining> GetEmpTran(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeTraining> oEmpTrans = new List<EmployeeTraining>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeeTraining oEmpTran = new EmployeeTraining();          
                EmployeeMaster oEmp = new EmployeeMaster();
                oEmp.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmp.Name = (string)rdr["EmployeeName"].ToString();               
                oEmpTran.EmployeeMaster = oEmp;
                oEmpTran.Serial = (string)rdr["TRAINING_SERIAL"].ToString();
                oEmpTran.TrainingTitle = (string)rdr["TRAINING_TITLE"].ToString();
                oEmpTran.TrainingType = (string)rdr["TRAINING_TYPE"].ToString();
                oEmpTran.OrganizationName = (string)rdr["ORG_NAME"].ToString();
                oEmpTran.ProvidedBy = (string)rdr["PROVIDED_BY"].ToString();
                oEmpTran.Subject = (string)rdr["SUBJECT"].ToString();
                oEmpTran.StartDate = (DateTime)rdr["START_DATE"];
                if (rdr["END_DATE"] == DBNull.Value)
                {
                    oEmpTran.EndDate = null;
                }
                else
                {
                    oEmpTran.EndDate = Convert.ToDateTime((DateTime)rdr["END_DATE"]);
                }
                oEmpTran.Grade = (string)rdr["GRADE"].ToString();
                oEmpTran.Remarks = (string)rdr["REMARKS"].ToString();
                oEmpTrans.Add(oEmpTran);
            }
            rdr.Close();
            return oEmpTrans;

        }
        #endregion

        #region UpdateEmployeeTraining
        public short UpdateEmployeeTraining(EmployeeTraining oEmpUpdateTran)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_TRAINING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Varchar2,30,oEmpUpdateTran.Serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpUpdateTran.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_training_title",OracleDbType.NVarchar2,500,oEmpUpdateTran.TrainingTitle,ParameterDirection.Input),
                new OracleParameter("p_training_type",OracleDbType.NVarchar2,2,oEmpUpdateTran.TrainingType,ParameterDirection.Input),
                new OracleParameter("p_org_name",OracleDbType.NVarchar2,500,oEmpUpdateTran.OrganizationName,ParameterDirection.Input),
                new OracleParameter("p_provided_by",OracleDbType.Varchar2,30,oEmpUpdateTran.ProvidedBy,ParameterDirection.Input),          
                new OracleParameter("p_subject",OracleDbType.NVarchar2,400,oEmpUpdateTran.Subject,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,oEmpUpdateTran.StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Date,oEmpUpdateTran.EndDate,ParameterDirection.Input),
                new OracleParameter("p_grade",OracleDbType.Varchar2,30,oEmpUpdateTran.Grade,ParameterDirection.Input), 
                new OracleParameter("p_remarks",OracleDbType.Varchar2,500,oEmpUpdateTran.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpUpdateTran.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpUpdateTran.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpUpdateTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,4,oEmpUpdateTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpUpdateTran.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region SaveBenefitType

        public short SaveBenefitType(FringeBenefit oBenType)
        {
            packageName = "PKG_EMP_INFO.INSERT_BENEFIT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oBenType.BenID,ParameterDirection.Input),
                new OracleParameter("p_type_title",OracleDbType.Varchar2,50,oBenType.BenTitle,ParameterDirection.Input),
                new OracleParameter("p_type_title_beng",OracleDbType.Varchar2,50,oBenType.BenTitleBeng,ParameterDirection.Input),    
                new OracleParameter("p_y_d_m_basis",OracleDbType.Varchar2,50,oBenType.YMDBasis,ParameterDirection.Input),   
                new OracleParameter("p_is_amount",OracleDbType.Varchar2,50,oBenType.isAmount,ParameterDirection.Input),   
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oBenType.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oBenType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oBenType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oBenType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oBenType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oBenType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
 #endregion

        #region GetBenefitType
        public List<FringeBenefit> GetBenefitType()
        {
            string packageName = "PKG_EMP_INFO.GET_BENEFIT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetBenefitTypes(packageName, parameterList);
        }
        public List<FringeBenefit> CheckBenefitType(string Benefit)
        {
            string packageName = "PKG_EMP_INFO.CHECK_BENEFIT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_benefit_id",OracleDbType.Varchar2,30,Benefit,ParameterDirection.Input)
           };

            return GetBenefitTypes(packageName, parameterList);
        }
        private List<FringeBenefit> GetBenefitTypes(string packageName, OracleParameter[] parameterList)
        {
            List<FringeBenefit> oBenTypes = new List<FringeBenefit>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FringeBenefit oBenType = new FringeBenefit();
                oBenType.BenID= (String)rdr["BEN_ID"].ToString();
                oBenType.BenTitle = (String)rdr["BEN_TITLE"];
                oBenType.BenTitleBeng = (string)rdr["BEN_TITLE_BENG"];
                oBenType.YMDBasis = rdr["Y_M_D_BASIS"] != DBNull.Value ? (String)rdr["Y_M_D_BASIS"] : "";
                oBenType.isAmount = rdr["IS_AMOUNT"] != DBNull.Value ? (String)rdr["IS_AMOUNT"] : "";
                oBenType.Serial = rdr["SERIAL"].ToString();
                oBenType.Remarks = rdr["REMARKS"] != DBNull.Value ? (String)rdr["REMARKS"] : "";
                oBenTypes.Add(oBenType);
            }
            rdr.Close();
            return oBenTypes;
        }
 #endregion

        #region UpdateBenefitType
        public short UpdateBenefitType(FringeBenefit oBenType)
        {
            packageName = "PKG_EMP_INFO.UPDATE_BENEFIT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,oBenType.BenID,ParameterDirection.Input),
                new OracleParameter("p_type_title",OracleDbType.Varchar2,50,oBenType.BenTitle,ParameterDirection.Input),
                new OracleParameter("p_type_title_beng",OracleDbType.Varchar2,50,oBenType.BenTitleBeng,ParameterDirection.Input),    
                new OracleParameter("p_y_d_m_basis",OracleDbType.Varchar2,50,oBenType.YMDBasis,ParameterDirection.Input),   
                new OracleParameter("p_is_amount",OracleDbType.Varchar2,50,oBenType.isAmount,ParameterDirection.Input),   
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oBenType.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oBenType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oBenType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oBenType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oBenType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oBenType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region SaveEmployeeDependent

        public short SaveEmployeeDependent(EmployeeDependent oEmpDep)
        {
            packageName = "PKG_EMP_INFO.INSERT_EMP_DEPENDENT";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpDep.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_depend_id",OracleDbType.Varchar2,30,oEmpDep.DependID,ParameterDirection.Input),
                new OracleParameter("p_dependent_name",OracleDbType.Varchar2,500,oEmpDep.DependName,ParameterDirection.Input),
                new OracleParameter("p_dependent_name_beng",OracleDbType.Varchar2,500,oEmpDep.DependNameBeng,ParameterDirection.Input),
                new OracleParameter("p_rel_id",OracleDbType.Varchar2,3,oEmpDep.RelationID,ParameterDirection.Input),
                new OracleParameter("p_depend_status",OracleDbType.Varchar2,2,oEmpDep.DependentStatus,ParameterDirection.Input),
                new OracleParameter("p_photo_path",OracleDbType.Varchar2,200,oEmpDep.PhotoPath,ParameterDirection.Input),
                new OracleParameter("p_dob",OracleDbType.Date,oEmpDep.DOB,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
#endregion

        #region UpdateEmployeeDependent

        public short UpdateEmployeeDependent(EmployeeDependent oEmpDep)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_DEPENDENT";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpDep.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_depend_id",OracleDbType.Varchar2,30,oEmpDep.DependID,ParameterDirection.Input),
                new OracleParameter("p_dependent_name",OracleDbType.Varchar2,500,oEmpDep.DependName,ParameterDirection.Input),
                new OracleParameter("p_dependent_name_beng",OracleDbType.Varchar2,500,oEmpDep.DependNameBeng,ParameterDirection.Input),
                new OracleParameter("p_rel_id",OracleDbType.Varchar2,3,oEmpDep.RelationID,ParameterDirection.Input),
                new OracleParameter("p_depend_status",OracleDbType.Varchar2,2,oEmpDep.DependentStatus,ParameterDirection.Input),
                new OracleParameter("p_photo_path",OracleDbType.Varchar2,200,oEmpDep.PhotoPath,ParameterDirection.Input),
                new OracleParameter("p_dob",OracleDbType.Date,oEmpDep.DOB,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
#endregion

        #region GetEmployeeDependent
        public List<EmployeeDependent> GetEmployeeDependent()
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_DEPENDENT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),

           };

            return GetEmpDependents(packageName, parameterList);
        }
        public List<EmployeeDependent> GetEmpDependent(string emp)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_DEPENDENT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,emp,ParameterDirection.Input),
           };

            return GetEmployeeDependents(packageName, parameterList);
        }
        private List<EmployeeDependent> GetEmployeeDependents(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeDependent> oEmpDeps = new List<EmployeeDependent>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeDependent oEmpDep = new EmployeeDependent();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmpDep.EmployeeMaster = oEmployeeMaster;

                oEmpDep.DependID =!rdr.IsDBNull(1) ? (String)rdr["DEPEND_ID"].ToString() : "";
                oEmpDep.DependSerial =!rdr.IsDBNull(2) ? rdr["DEPEND_SERIAL"].ToString() : "";
                oEmpDep.DependName =!rdr.IsDBNull(3) ? (String)rdr["DEPENDENT_NAME"].ToString() : "";
                oEmpDep.DependNameBeng =!rdr.IsDBNull(4) ? (string)rdr["DEPENDENT_NAME_BENG"].ToString() : "";
                oEmpDep.RelationID = !rdr.IsDBNull(5) ? (String)rdr["REL_ID"].ToString() : "";
                oEmpDep.DependentStatus = !rdr.IsDBNull(6) ? (String)rdr["DEPEND_STATUS"].ToString() : "";
                oEmpDep.PhotoPath = !rdr.IsDBNull(7) ? (String)rdr["PHOTO_PATH"].ToString() : "";
                oEmpDep.DOB =(DateTime)rdr["DOB"];
                oEmpDeps.Add(oEmpDep);
            }
            rdr.Close();
            return oEmpDeps;
        }

        private List<EmployeeDependent> GetEmpDependents(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeDependent> oEmpDeps = new List<EmployeeDependent>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                EmployeeDependent oEmpDep = new EmployeeDependent();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmpDep.EmployeeMaster = oEmployeeMaster;

                oEmpDep.DependID = !rdr.IsDBNull(1) ? (String)rdr["DEPEND_ID"].ToString() : "";
                oEmpDep.DependSerial = !rdr.IsDBNull(2) ? rdr["DEPEND_SERIAL"].ToString() : "";
                oEmpDep.DependName = !rdr.IsDBNull(3) ? (String)rdr["DEPENDENT_NAME"].ToString() : "";
                oEmpDep.DependNameBeng = !rdr.IsDBNull(4) ? (string)rdr["DEPENDENT_NAME_BENG"].ToString() : "";
                oEmpDep.RelationID = !rdr.IsDBNull(5) ? (String)rdr["REL_ID"].ToString() : "";
                oEmpDep.DependentStatus = !rdr.IsDBNull(6) ? (String)rdr["DEPEND_STATUS"].ToString() : "";
                oEmpDep.PhotoPath = !rdr.IsDBNull(7) ? (String)rdr["PHOTO_PATH"].ToString() : "";
                oEmpDep.DOB = (DateTime)rdr["DOB"];
                oEmpDeps.Add(oEmpDep);
            }
            rdr.Close();
            return oEmpDeps;
        }
#endregion        

        #region SaveEmployeeMedicalInformation

        public short SaveEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep)
        {
            packageName = "PKG_EMP_INFO.INSERT_EMP_MED_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpDep.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_eye_sight",OracleDbType.Varchar2,100,oEmpDep.EyeSight,ParameterDirection.Input),
                new OracleParameter("p_hieght",OracleDbType.Varchar2,500,oEmpDep.Height,ParameterDirection.Input),
                new OracleParameter("p_weight",OracleDbType.Varchar2,500,oEmpDep.weight,ParameterDirection.Input),
                new OracleParameter("p_disabilities",OracleDbType.Varchar2,300,oEmpDep.Disabilities,ParameterDirection.Input),
                new OracleParameter("p_diabitcs",OracleDbType.Varchar2,2,oEmpDep.IsDiabetics,ParameterDirection.Input),
                new OracleParameter("p_blood_group",OracleDbType.Varchar2,200,oEmpDep.BloodGrp,ParameterDirection.Input),
                new OracleParameter("p_bp",OracleDbType.Varchar2,300,oEmpDep.BP,ParameterDirection.Input),
                new OracleParameter("p_xray_report",OracleDbType.Varchar2,300,oEmpDep.XrayReport,ParameterDirection.Input),
                new OracleParameter("p_ecg_report",OracleDbType.Varchar2,300,oEmpDep.EcgReport,ParameterDirection.Input),
                new OracleParameter("p_mark",OracleDbType.Varchar2,200,oEmpDep.Mark,ParameterDirection.Input),
                new OracleParameter("p_report_date",OracleDbType.Varchar2,200,oEmpDep.ReportDate,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateEmployeeMedicalInformation

        public short UpdateEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_MED_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpDep.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,30,oEmpDep.MedicalReportSerial,ParameterDirection.Input),
                new OracleParameter("p_eye_sight",OracleDbType.Varchar2,30,oEmpDep.EyeSight,ParameterDirection.Input),
                new OracleParameter("p_hieght",OracleDbType.Varchar2,500,oEmpDep.Height,ParameterDirection.Input),
                new OracleParameter("p_weight",OracleDbType.Varchar2,500,oEmpDep.weight,ParameterDirection.Input),
                new OracleParameter("p_disabilities",OracleDbType.Varchar2,300,oEmpDep.Disabilities,ParameterDirection.Input),
                new OracleParameter("p_diabitcs",OracleDbType.Varchar2,2,oEmpDep.IsDiabetics,ParameterDirection.Input),
                new OracleParameter("p_blood_group",OracleDbType.Varchar2,200,oEmpDep.BloodGrp,ParameterDirection.Input),
                new OracleParameter("p_bp",OracleDbType.Varchar2,300,oEmpDep.BP,ParameterDirection.Input),
                new OracleParameter("p_xray_report",OracleDbType.Varchar2,300,oEmpDep.XrayReport,ParameterDirection.Input),
                new OracleParameter("p_ecg_report",OracleDbType.Varchar2,300,oEmpDep.EcgReport,ParameterDirection.Input),
                new OracleParameter("p_mark",OracleDbType.Varchar2,200,oEmpDep.Mark,ParameterDirection.Input),
                new OracleParameter("p_report_date",OracleDbType.Varchar2,200,oEmpDep.ReportDate,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpDep.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpDep.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetEmployeeMedicalInformation
        public List<EmployeeMedicalInfo> GetEmployeeMedicalInformation(string emp)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_MED_INFO";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,emp,ParameterDirection.Input),
           };

            return GetEmployeeMedicalInformationDetails(packageName, parameterList);
        }
        private List<EmployeeMedicalInfo> GetEmployeeMedicalInformationDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMedicalInfo> oEmpDeps = new List<EmployeeMedicalInfo>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMedicalInfo oEmpDep = new EmployeeMedicalInfo();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmployeeMaster.Name = (string)rdr["NAME"];
                oEmpDep.EmployeeMaster = oEmployeeMaster;

                oEmpDep.MedicalReportSerial = rdr["MED_RPT_SERIAL"] != DBNull.Value ? (String)rdr["MED_RPT_SERIAL"].ToString() : "";
                oEmpDep.EyeSight = rdr["EYE_SIGHT"] != DBNull.Value ? rdr["EYE_SIGHT"].ToString() : "";
                oEmpDep.Height = rdr["HEIGHT"] != DBNull.Value ? (String)rdr["HEIGHT"].ToString() : "";
                oEmpDep.weight = rdr["WEIGHT"] != DBNull.Value ? (string)rdr["WEIGHT"].ToString() : "";
                oEmpDep.Disabilities = rdr["DISABILITIES"] != DBNull.Value ? (String)rdr["DISABILITIES"].ToString() : "";
                oEmpDep.IsDiabetics = rdr["IS_DIABETIC"] != DBNull.Value ? (String)rdr["IS_DIABETIC"].ToString() : "";
                oEmpDep.BloodGrp = rdr["BLOOD_GROUP"] != DBNull.Value ? (String)rdr["BLOOD_GROUP"].ToString() : "";
                oEmpDep.BP = rdr["BP"] != DBNull.Value ? (String)rdr["BP"].ToString() : "";
                oEmpDep.XrayReport = rdr["X_RAY_REPORT"] != DBNull.Value ? (String)rdr["X_RAY_REPORT"].ToString() : "";
                oEmpDep.EcgReport = rdr["E_C_G_REPORT"] != DBNull.Value ? (String)rdr["E_C_G_REPORT"].ToString() : "";
                oEmpDep.Mark = rdr["MARK"] != DBNull.Value ? (String)rdr["MARK"].ToString() : "";
                oEmpDep.ReportDate = rdr["REPORT_DATE"].ToString();
                oEmpDeps.Add(oEmpDep);
            }
            rdr.Close();
            return oEmpDeps;
        }

        #endregion

        #region SavePunishmentType

        public short SavePunishmentType(PunishmentType oPunType)
        {
            packageName = "PKG_EMP_INFO.INSERT_PUNISHMENT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_pun_id",OracleDbType.Varchar2,4,oPunType.PunID,ParameterDirection.Input),
                new OracleParameter("p_pun_title",OracleDbType.Varchar2,100,oPunType.PunTitle,ParameterDirection.Input),
                new OracleParameter("p_pun_title_beng",OracleDbType.Varchar2,100,oPunType.PunTitleBeng,ParameterDirection.Input),    
                new OracleParameter("p_is_amount",OracleDbType.Varchar2,1,oPunType.isAmount,ParameterDirection.Input),   
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,oPunType.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oPunType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdatePunishmentType
        public short UpdatePunishmentType(PunishmentType oPunType)
        {
            packageName = "PKG_EMP_INFO.UPDATE_PUNISHMENT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_pun_id",OracleDbType.Varchar2,4,oPunType.PunID,ParameterDirection.Input),
                new OracleParameter("p_pun_title",OracleDbType.Varchar2,100,oPunType.PunTitle,ParameterDirection.Input),
                new OracleParameter("p_pun_title_beng",OracleDbType.Varchar2,100,oPunType.PunTitleBeng,ParameterDirection.Input),    
                new OracleParameter("p_is_amount",OracleDbType.Varchar2,1,oPunType.isAmount,ParameterDirection.Input),   
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,oPunType.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oPunType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetPunishmentType
        public List<PunishmentType> GetPunishmentType()
        {
            string packageName = "PKG_EMP_INFO.GET_PUNISHMENT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetPunishmentTypes(packageName, parameterList);
        }
        public List<PunishmentType> CheckPunishmentType(string Punishment)
        {
            string packageName = "PKG_EMP_INFO.CHECK_PUNISHMENT_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_pun_id",OracleDbType.Varchar2,30,Punishment,ParameterDirection.Input)
           };

            return GetPunishmentTypes(packageName, parameterList);
        }
        private List<PunishmentType> GetPunishmentTypes(string packageName, OracleParameter[] parameterList)
        {
            List<PunishmentType> oBenTypes = new List<PunishmentType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PunishmentType oBenType = new PunishmentType();
                oBenType.PunID = (String)rdr["PUN_ID"].ToString();
                oBenType.PunTitle = (String)rdr["PUN_TITLE"];
                oBenType.PunTitleBeng = (string)rdr["PUN_TITLE_BENG"];
                oBenType.isAmount = rdr["IS_AMOUNT"] != DBNull.Value ? (String)rdr["IS_AMOUNT"] : "";
                oBenType.Serial = rdr["SERIAL"].ToString();
                oBenType.Remarks = rdr["REMARKS"] != DBNull.Value ? (String)rdr["REMARKS"] : "";
                oBenTypes.Add(oBenType);
            }
            rdr.Close();
            return oBenTypes;
        }
        #endregion

        #region SaveEmpPunishmentSetup

        public short SaveEmpPunishmentSetup(PunishmentType oPunType)
        {
            packageName = "PKG_EMP_INFO.INSERT_EMP_PUNISHMENT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_pun_serial",OracleDbType.Varchar2,4,oPunType.Serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oPunType.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_pun_id",OracleDbType.Varchar2,4,oPunType.PunID,ParameterDirection.Input),
                new OracleParameter("p_amount",OracleDbType.Varchar2,100,oPunType.Amount,ParameterDirection.Input),
                new OracleParameter("p_effective_date",OracleDbType.Date,oPunType.EffectiveDate,ParameterDirection.Input),    
                new OracleParameter("p_duration",OracleDbType.Varchar2,100,oPunType.Duration,ParameterDirection.Input),   
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oPunType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateEmpPunishmentSetup
        public short UpdateEmpPunishmentSetup(PunishmentType oPunType)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_PUNISHMENT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_pun_serial",OracleDbType.Varchar2,4,oPunType.Serial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oPunType.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_pun_id",OracleDbType.Varchar2,4,oPunType.PunID,ParameterDirection.Input),
                new OracleParameter("p_amount",OracleDbType.Varchar2,100,oPunType.Amount,ParameterDirection.Input),
                new OracleParameter("p_effective_date",OracleDbType.Date,oPunType.EffectiveDate,ParameterDirection.Input),    
                new OracleParameter("p_duration",OracleDbType.Varchar2,100,oPunType.Duration,ParameterDirection.Input),   
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oPunType.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oPunType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oPunType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetPunishmentType
        public List<PunishmentType> GetEmpPunishmentType(string EmpId)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_PUNISHMENT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpId,ParameterDirection.Input)
           };

            return GetEmpPunishmentTypes(packageName, parameterList);
        }     
        private List<PunishmentType> GetEmpPunishmentTypes(string packageName, OracleParameter[] parameterList)
        {
            List<PunishmentType> oBenTypes = new List<PunishmentType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PunishmentType oBenType = new PunishmentType();
                oBenType.Serial = (String)rdr["PUNISHMENT_SERIAL"].ToString();
                EmployeeMaster oEmp = new EmployeeMaster();
                oEmp.EmpId = (String)rdr["EMP_ID"].ToString();
                oBenType.EmployeeMaster = oEmp;
                oBenType.PunID = (String)rdr["PUNISHMENT_ID"].ToString();
                oBenType.PunTitle = (String)rdr["PUN_TITLE"].ToString();
                oBenType.Amount = rdr["AMOUNT"] != DBNull.Value ? Convert.ToDecimal(rdr["AMOUNT"]).ToString() : "";
                oBenType.EffectiveDate =Convert.ToDateTime(rdr["EFFECTIVE_DATE"]);
                oBenType.Duration =rdr["DURATION"] != DBNull.Value ?  Convert.ToDecimal(rdr["DURATION"]).ToString():""; //rdr["DURATION"] != DBNull.Value ? (String)rdr["DURATION"] : "";               
                oBenTypes.Add(oBenType);
            }
            rdr.Close();
            return oBenTypes;
        }
        #endregion

        #region SaveNomineeInformation
        public short SaveNomineeInformation(Nominee oNominee)
        {
            packageName = "PKG_EMP_INFO.INSERT_NOMINEE_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oNominee.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_nominee_id",OracleDbType.Varchar2,30,oNominee.NomineeId,ParameterDirection.Input),
                new OracleParameter("p_nominee_name",OracleDbType.Varchar2,300,oNominee.NomineeName,ParameterDirection.Input),
                new OracleParameter("p_nominee_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeNameBeng,ParameterDirection.Input),
                new OracleParameter("p_fat_name",OracleDbType.Varchar2,300,oNominee.NomineeFatName,ParameterDirection.Input),
                new OracleParameter("p_fat_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeFatNameBeng,ParameterDirection.Input),
                new OracleParameter("p_mot_name",OracleDbType.Varchar2,300,oNominee.NomineeMotName,ParameterDirection.Input),
                new OracleParameter("p_mot_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeMotNameBeng,ParameterDirection.Input),
                new OracleParameter("p_spouse_name",OracleDbType.Varchar2,300,oNominee.NomineeSpouseName,ParameterDirection.Input),
                new OracleParameter("p_spouse_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeSpouseNameBeng,ParameterDirection.Input),
                new OracleParameter("p_religion",OracleDbType.Varchar2,1,oNominee.Religion,ParameterDirection.Input),
                new OracleParameter("p_sex",OracleDbType.Varchar2,1,oNominee.Sex,ParameterDirection.Input),
                new OracleParameter("p_blood_grp",OracleDbType.Varchar2,1,oNominee.BloodGroup,ParameterDirection.Input),
                new OracleParameter("p_dob",OracleDbType.Varchar2,300,oNominee.DOB,ParameterDirection.Input),
                new OracleParameter("p_maritial_status",OracleDbType.Varchar2,1,oNominee.MaritialStatus,ParameterDirection.Input),
                new OracleParameter("p_nationality",OracleDbType.Varchar2,300,oNominee.Nationality,ParameterDirection.Input),
                new OracleParameter("p_photo_path",OracleDbType.Varchar2,300,oNominee.PhotoPath,ParameterDirection.Input),
                new OracleParameter("p_signature_path",OracleDbType.Varchar2,300,oNominee.SignaturePath,ParameterDirection.Input),
                new OracleParameter("p_personal_email",OracleDbType.Varchar2,100,oNominee.PersonalEmail,ParameterDirection.Input),
                new OracleParameter("p_home_phone",OracleDbType.Varchar2,70,oNominee.HomePhone,ParameterDirection.Input),
                new OracleParameter("p_cell_phone",OracleDbType.Varchar2,70,oNominee.CellPhone,ParameterDirection.Input),
                new OracleParameter("p_national_id",OracleDbType.Varchar2,40,oNominee.NationalID,ParameterDirection.Input),
                new OracleParameter("p_occupation",OracleDbType.Varchar2,2,oNominee.Occupation,ParameterDirection.Input),
                new OracleParameter("p_nominee_serial",OracleDbType.Varchar2,2,oNominee.NomineeSerial,ParameterDirection.Input),
                new OracleParameter("p_relation_with_staff",OracleDbType.Varchar2,2,oNominee.RelationWithStaff,ParameterDirection.Input),
                new OracleParameter("p_present_address",OracleDbType.Varchar2,500,oNominee.PresentAddress,ParameterDirection.Input),
                new OracleParameter("p_parmanent_address",OracleDbType.Varchar2,500,oNominee.ParmanentAddress,ParameterDirection.Input),
                new OracleParameter("p_work_address",OracleDbType.Varchar2,500,oNominee.WorkAddress,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oNominee.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oNominee.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oNominee.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oNominee.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oNominee.EntryParameter.MachineID,ParameterDirection.Input),
                   
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateNomineeInformation
        public short UpdateNomineeInformation(Nominee oNominee)
        {
            packageName = "PKG_EMP_INFO.UPDATE_NOMINEE_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oNominee.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_nominee_id",OracleDbType.Varchar2,30,oNominee.NomineeId,ParameterDirection.Input),
                new OracleParameter("p_nominee_name",OracleDbType.Varchar2,300,oNominee.NomineeName,ParameterDirection.Input),
                new OracleParameter("p_nominee_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeNameBeng,ParameterDirection.Input),
                new OracleParameter("p_fat_name",OracleDbType.Varchar2,300,oNominee.NomineeFatName,ParameterDirection.Input),
                new OracleParameter("p_fat_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeFatNameBeng,ParameterDirection.Input),
                new OracleParameter("p_mot_name",OracleDbType.Varchar2,300,oNominee.NomineeMotName,ParameterDirection.Input),
                new OracleParameter("p_mot_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeMotNameBeng,ParameterDirection.Input),
                new OracleParameter("p_spouse_name",OracleDbType.Varchar2,300,oNominee.NomineeSpouseName,ParameterDirection.Input),
                new OracleParameter("p_spouse_name_beng",OracleDbType.Varchar2,300,oNominee.NomineeSpouseNameBeng,ParameterDirection.Input),
                new OracleParameter("p_religion",OracleDbType.Varchar2,1,oNominee.Religion,ParameterDirection.Input),
                new OracleParameter("p_sex",OracleDbType.Varchar2,1,oNominee.Sex,ParameterDirection.Input),
                new OracleParameter("p_blood_grp",OracleDbType.Varchar2,1,oNominee.BloodGroup,ParameterDirection.Input),
                new OracleParameter("p_dob",OracleDbType.Varchar2,300,oNominee.DOB,ParameterDirection.Input),
                new OracleParameter("p_maritial_status",OracleDbType.Varchar2,1,oNominee.MaritialStatus,ParameterDirection.Input),
                new OracleParameter("p_nationality",OracleDbType.Varchar2,300,oNominee.Nationality,ParameterDirection.Input),
                new OracleParameter("p_photo_path",OracleDbType.Varchar2,300,oNominee.PhotoPath,ParameterDirection.Input),
                new OracleParameter("p_signature_path",OracleDbType.Varchar2,300,oNominee.SignaturePath,ParameterDirection.Input),
                new OracleParameter("p_personal_email",OracleDbType.Varchar2,100,oNominee.PersonalEmail,ParameterDirection.Input),
                new OracleParameter("p_home_phone",OracleDbType.Varchar2,70,oNominee.HomePhone,ParameterDirection.Input),
                new OracleParameter("p_cell_phone",OracleDbType.Varchar2,70,oNominee.CellPhone,ParameterDirection.Input),
                new OracleParameter("p_national_id",OracleDbType.Varchar2,40,oNominee.NationalID,ParameterDirection.Input),
                new OracleParameter("p_occupation",OracleDbType.Varchar2,2,oNominee.Occupation,ParameterDirection.Input),
                new OracleParameter("p_nominee_serial",OracleDbType.Varchar2,2,oNominee.NomineeSerial,ParameterDirection.Input),
                new OracleParameter("p_relation_with_staff",OracleDbType.Varchar2,2,oNominee.RelationWithStaff,ParameterDirection.Input),
                new OracleParameter("p_present_address",OracleDbType.Varchar2,500,oNominee.PresentAddress,ParameterDirection.Input),
                new OracleParameter("p_parmanent_address",OracleDbType.Varchar2,500,oNominee.ParmanentAddress,ParameterDirection.Input),
                new OracleParameter("p_work_address",OracleDbType.Varchar2,500,oNominee.WorkAddress,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oNominee.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oNominee.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oNominee.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oNominee.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oNominee.EntryParameter.MachineID,ParameterDirection.Input),
                   
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetNomineeInformation   
        public List<Nominee> GetNomineeInfo()
        {
            string packageName = "PKG_EMP_INFO.GET_NOMINEE_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetNomineeInformationDetails(packageName, parameterList);

        }
        public List<Nominee> GetNomineeInformation(string EmpID)
        {
            string packageName = "PKG_EMP_INFO.GET_NOMINEE_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input)
            };
            return GetNomineeInformationDetails(packageName, parameterList);

        }
        private List<Nominee> GetNomineeInformationDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Nominee> oNominees = new List<Nominee>();

            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                Nominee oNominee = new Nominee();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oNominee.EmployeeMaster = oEmployeeMaster;

                oNominee.NomineeId = (string)rdr["NOMINEE_ID"].ToString();
                oNominee.NomineeName = (string)rdr["NOMINEE_NAME"].ToString();
                oNominee.NomineeNameBeng = (string)rdr["NOMINEE_NAME_BENG"].ToString();
                oNominee.NomineeFatName = (string)rdr["FAT_NAME"].ToString();
                oNominee.NomineeFatNameBeng = (string)rdr["FAT_NAME_BENG"].ToString();
                oNominee.NomineeMotName = (string)rdr["MOT_NAME"].ToString();
                oNominee.NomineeMotNameBeng = (string)rdr["MOT_NAME_BENG"].ToString();
                oNominee.NomineeSpouseName = (string)rdr["SPOUSE_NAME"].ToString();
                oNominee.NomineeSpouseNameBeng = (string)rdr["SPOUSE_NAME_BENG"].ToString();
                oNominee.Religion = (string)rdr["RELIGION"].ToString();
                oNominee.Sex = (string)rdr["Sex"].ToString();
                oNominee.BloodGroup = (string)rdr["BLOOD_GRP"].ToString();
                oNominee.DOB = Convert.ToDateTime(rdr["DOB"]).ToString("dd/MM/yyyy");
                oNominee.MaritialStatus = (string)rdr["maritial_status"].ToString();
                oNominee.Nationality = (string)rdr["NATIONALITY"].ToString();
                oNominee.PhotoPath = (string)rdr["PHOTO_PATH"].ToString();
                oNominee.SignaturePath = (string)rdr["SIGNATURE_PATH"].ToString();
                oNominee.PersonalEmail = (string)rdr["PERSONAL_EMAIL"].ToString();
                oNominee.HomePhone = (string)rdr["HOME_PHONE"].ToString();
                oNominee.CellPhone = (string)rdr["CELL_PHONE"].ToString();
                oNominee.NationalID = (string)rdr["NATIONAL_ID"].ToString();
                oNominee.Occupation = (string)rdr["OCCUPATION"].ToString();
                oNominee.NomineeSerial = (string)rdr["NOMINEE_SERIAL"].ToString();
                oNominee.RelationWithStaff = (string)rdr["RELATION_WITH_STAFF"].ToString();
                oNominee.PresentAddress = (string)rdr["PRESENT_ADDRESS"].ToString();
                oNominee.ParmanentAddress = (string)rdr["PREMANENT_ADDRESS"].ToString();
                oNominee.WorkAddress = (string)rdr["WORK_ADDRESS"].ToString();

                oNominees.Add(oNominee);
            }
            rdr.Close();
            return oNominees;

        }
        #endregion

        #region GetEmpGender
        public List<EmployeeMaster> GetEmpGender(string EmpID)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_GENDER";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input)
           };

            return GetEmpGenderDetails(packageName, parameterList);
        }

        private List<EmployeeMaster> GetEmpGenderDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oEmpMasters = new List<EmployeeMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas.Sex = (String)rdr["SEX"].ToString();
                oEmpMas.JobType = rdr["JOB_TYPE_ID"].ToString();
                oEmpMas.Age =Convert.ToDouble(rdr["age"].ToString());
                oEmpMasters.Add(oEmpMas);
            }
            rdr.Close();
            return oEmpMasters;
        }
        #endregion

        #region SaveEmployeeDropList
        public short SaveEmployeeDropList(EmployeeDropList oEmployeeDropList)
        {
            packageName = "PKG_EMP_INFO.INSERT_EMP_DROP_LIST";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmployeeDropList.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_drop_type_id",OracleDbType.Varchar2,30,oEmployeeDropList.DropTypeID,ParameterDirection.Input),
                new OracleParameter("p_drop_date",OracleDbType.Varchar2,100,oEmployeeDropList.DropDate,ParameterDirection.Input),
                new OracleParameter("p_drop_effective_date",OracleDbType.Varchar2,100,oEmployeeDropList.DropEffectiveDate,ParameterDirection.Input),
                new OracleParameter("p_verified_by",OracleDbType.Varchar2,30,oEmployeeDropList.VerifiedBy,ParameterDirection.Input),
                new OracleParameter("p_finalize_by",OracleDbType.Varchar2,30,oEmployeeDropList.FinalizeBy,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oEmployeeDropList.Remarks,ParameterDirection.Input),                
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.MachineID,ParameterDirection.Input),
                   
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateEmployeeDropList
        public short UpdateEmployeeDropList(EmployeeDropList oEmployeeDropList)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_DROP_LIST";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_list_serial",OracleDbType.Varchar2,30,oEmployeeDropList.ListSerial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmployeeDropList.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_drop_type_id",OracleDbType.Varchar2,30,oEmployeeDropList.DropTypeID,ParameterDirection.Input),
                new OracleParameter("p_drop_date",OracleDbType.Varchar2,100,oEmployeeDropList.DropDate,ParameterDirection.Input),
                new OracleParameter("p_drop_effective_date",OracleDbType.Varchar2,100,oEmployeeDropList.DropEffectiveDate,ParameterDirection.Input), 
                new OracleParameter("p_verified_by",OracleDbType.Varchar2,30,oEmployeeDropList.VerifiedBy,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oEmployeeDropList.Remarks,ParameterDirection.Input),                
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmployeeDropList.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateFinalizeDropList
        public short UpdateFinalizeDropList(EmployeeDropList oEmployeeDropList)
        {
            packageName = "PKG_EMP_INFO.UPDATE_EMP_DROP_LIST_FINALIZE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_list_serial",OracleDbType.Varchar2,30,oEmployeeDropList.ListSerial,ParameterDirection.Input),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmployeeDropList.EmployeeMaster.EmpId,ParameterDirection.Input),
                new OracleParameter("p_finalized_by",OracleDbType.Varchar2,30,oEmployeeDropList.FinalizeBy,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetEmpDropList
        public List<EmployeeDropList> GetEmpDropList()
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_DROP_LIST";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetEmpDropListDetails(packageName, parameterList);
        }
        public List<EmployeeDropList> GetDropListByType(string DropType)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_DROP_LIST";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_drop_type",OracleDbType.Varchar2,30,DropType,ParameterDirection.Input),
            };
            return GetEmpDropListDetails(packageName, parameterList);
        }
        public List<EmployeeDropList> GetEmpDropListForFinalize()
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_DROP_LIST_FOR_FINALIZE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                
            };
            return GetEmpDropListDetails(packageName, parameterList);
        }
        public List<EmployeeDropList> GetEmpDropListForFinalizeByType(string DropType)
        {
            string packageName = "PKG_EMP_INFO.GET_EMP_DROP_LIST_FOR_FINALIZE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_drop_type",OracleDbType.Varchar2,30,DropType,ParameterDirection.Input),
            };
            return GetEmpDropListDetails(packageName, parameterList);
        }
        public List<EmployeeDropList> GetCompletedFinalizedList(string DropType)
        {
            string packageName = "PKG_EMP_INFO.GET_COMPLETED_FINALIZE_LIST";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_drop_type",OracleDbType.Varchar2,30,DropType,ParameterDirection.Input),
            };
            return GetEmpDropListDetails(packageName, parameterList);
        }
        private List<EmployeeDropList> GetEmpDropListDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeDropList> ooEmployeeDropLists = new List<EmployeeDropList>();

            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeeDropList oEmployeeDropList = new EmployeeDropList();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"];
                oEmployeeMaster.Name = (string)rdr["Name"];
                oEmployeeDropList.EmployeeMaster = oEmployeeMaster;

                oEmployeeDropList.ListSerial = (string)rdr["LIST_SERIAL"].ToString();
                oEmployeeDropList.DropTypeID = (string)rdr["DROP_TYPE_ID"].ToString();
                oEmployeeDropList.DropDate = Convert.ToDateTime(rdr["DROP_DATE"].ToString()).ToString("dd/MM/yyyy");
                oEmployeeDropList.DropEffectiveDate = Convert.ToDateTime(rdr["DROP_EFFECT_DATE"].ToString()).ToString("dd/MM/yyyy");
                oEmployeeDropList.Remarks = (string)rdr["REMARKS"].ToString();
                oEmployeeDropList.VerifiedBy = (string)rdr["VERIFIED_BY"].ToString();
                oEmployeeDropList.VerifiedByName = (string)rdr["VerifiedName"].ToString();

                ooEmployeeDropLists.Add(oEmployeeDropList);
            }
            rdr.Close();
            return ooEmployeeDropLists;

        }
        #endregion

        #region SaveEmployeeDegreeSetup
        public short SaveEmployeeDegreeSetup(EmployeeDegree oEmpDegree)
        {
            packageName = "PKG_EMP_DEGREE_SETUP.INSERT_EMP_DEGREE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpDegree.EmployeeID,ParameterDirection.Input),
                new OracleParameter("p_degree_line_1",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine1,ParameterDirection.Input),
                new OracleParameter("p_degree_line_2",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine2,ParameterDirection.Input),    
                new OracleParameter("p_degree_line_3",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine3,ParameterDirection.Input),   
                new OracleParameter("p_degree_line_4",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine4,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpDegree.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpDegree.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpDegree.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpDegree.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateEmployeeDegreeSetup
        public short UpdateEmployeeDegreeSetup(EmployeeDegree oEmpDegree)
        {
            packageName = "PKG_EMP_DEGREE_SETUP.UPDATE_EMP_DEGREE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oEmpDegree.EmployeeID,ParameterDirection.Input),
                new OracleParameter("p_degree_line_1",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine1,ParameterDirection.Input),
                new OracleParameter("p_degree_line_2",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine2,ParameterDirection.Input),    
                new OracleParameter("p_degree_line_3",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine3,ParameterDirection.Input),   
                new OracleParameter("p_degree_line_4",OracleDbType.Varchar2,200,oEmpDegree.DegreeLine4,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmpDegree.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmpDegree.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmpDegree.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmpDegree.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetEmployeeDegreeSetup
        public List<EmployeeDegree> GetAllEmployeeDegree()
        {
            string packageName = "PKG_EMP_DEGREE_SETUP.GET_ALL_EMP_DEGREE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetEmployeeDegreeSetupDetails(packageName, parameterList);
        }
        public List<EmployeeDegree> GetEmployeeDegreeSetup(string EmpID)
        {
            string packageName = "PKG_EMP_DEGREE_SETUP.GET_EMP_DEGREE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input)
           };

            return GetEmployeeDegreeSetupDetails(packageName, parameterList);
        }
        private List<EmployeeDegree> GetEmployeeDegreeSetupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeDegree> oEmpDegrees = new List<EmployeeDegree>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeDegree oEmpDegree = new EmployeeDegree();
                oEmpDegree.EmployeeID = (String)rdr["EMP_ID"].ToString();
                oEmpDegree.EmployeeName = (String)rdr["NAME"].ToString();
                oEmpDegree.DegreeLine1 = rdr["DEGREE_LINE1"] != DBNull.Value ? rdr["DEGREE_LINE1"].ToString() : "";
                oEmpDegree.DegreeLine2 = rdr["DEGREE_LINE2"] != DBNull.Value ? rdr["DEGREE_LINE2"].ToString() : "";
                oEmpDegree.DegreeLine3 = rdr["DEGREE_LINE3"] != DBNull.Value ? rdr["DEGREE_LINE3"].ToString() : "";
                oEmpDegree.DegreeLine4 = rdr["DEGREE_LINE4"] != DBNull.Value ? rdr["DEGREE_LINE4"].ToString() : "";
                oEmpDegrees.Add(oEmpDegree);
            }
            rdr.Close();
            return oEmpDegrees;
        }
        #endregion

    }
}
