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
    public class EmployeeMasterReportDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

         #region GetEmployeeMaster

        public List<EmployeeMasterRO> RptGetEmpMaster(string EmpMaster, string oLvTpSet,string Param="")
        {
            string packageName = "Pkg_HRM_Reports.GET_EMPLOYEE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,EmpMaster,ParameterDirection.Input),
                new OracleParameter("p_id1",OracleDbType.Varchar2,30,oLvTpSet,ParameterDirection.Input),
                new OracleParameter("p_id2",OracleDbType.Varchar2,30,Param,ParameterDirection.Input)
           };

            return RptGetEmpMas(packageName, parameterList);
        }

        public List<EmployeeMasterRO> RptGetAllEmployee()
        {
           string packageName = "Pkg_HRM_Reports.GET_ALL_EMPLOYEE";
           OracleParameter[] parameterList = new OracleParameter[] { 
             new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return RptGetEmpMas(packageName, parameterList);
        }

        public List<EmployeeMasterRO> GetEmployeeInfo(string mode, string param)
        {
            string packageName = "Pkg_HRM_Reports.GET_EMPLOYEE_INFO";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,mode,ParameterDirection.Input),
                new OracleParameter("p_id",OracleDbType.Varchar2,300,param,ParameterDirection.Input)
           };

            return RptGetEmpMas(packageName, parameterList);
        }

        public List<EmployeeMasterRO> RptGetAllEmployeeMas(string DeptType,string DeptGrp,string Dept,string Unit)
        {
            string packageName = "Pkg_HRM_Reports.GET_ALL_EMPLOYEE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_type",OracleDbType.Varchar2,30,DeptType,ParameterDirection.Input),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input),
                new OracleParameter("p_dept",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
           };

            return RptGetEmpMas(packageName, parameterList);
        }

        private List<EmployeeMasterRO> RptGetEmpMas(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMasterRO> oLvdays = new List<EmployeeMasterRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMasterRO oEmp = new EmployeeMasterRO();
                oEmp.EmpId = (String)rdr["EMP_ID"].ToString();
                oEmp.EmpName = (String)rdr["Name"].ToString();
                oEmp.EmpNameBeng = (string)rdr["EMP_NAME_BENG"].ToString();
                oEmp.FatName = (String)(rdr["fat_name"]).ToString();
                oEmp.FatNameBeng = (string)rdr["FAT_NAME_BENG"].ToString();
                oEmp.MotName = (String)rdr["mot_name"].ToString();
                oEmp.MotNameBeng = (string)rdr["MOT_NAME_BENG"].ToString();
                oEmp.SpouseName = (string)rdr["SPOUSE_NAME"].ToString();
                oEmp.SpouseNameBeng = (string)rdr["SPOUSE_NAME_BENG"].ToString();
                oEmp.Religion = (String)rdr["religion"].ToString();
                oEmp.Sex = (String)rdr["sex"].ToString();
                oEmp.BloodGroup = (String)rdr["blood_grp"].ToString();
                oEmp.MaritialStatus = (String)rdr["maritial_status"].ToString();
                oEmp.Nationality = (String)rdr["nationality"].ToString();
                oEmp.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oEmp.DeptGrp = (String)rdr["Dept_grp_name"].ToString();
                oEmp.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oEmp.DesigGrp = (String)rdr["Desig_grp_name"].ToString();
                oEmp.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oEmp.Email = (String)rdr["email_id"].ToString();
                oEmp.CellPhone = (String)rdr["cell_phone"].ToString();
                oEmp.ScaleId = (String)rdr["scale_title"].ToString();
                oEmp.GradeId = (String)rdr["grade_title"].ToString();
                oEmp.Country = (String)rdr["country"].ToString();
                oEmp.Photo = (string)rdr["PHOTO_PATH"].ToString();
                oEmp.Signature = (string)rdr["SIGNATURE_PATH"].ToString();
                oEmp.CompanyId = (string)rdr["COMPANY_ID"];
                oEmp.JobType = (string)rdr["JOB_TYPE_ID"].ToString();
                oEmp.EmpClass = (string)rdr["EMP_CLASS"].ToString();
                oEmp.DOB =Convert.ToDateTime(rdr["DOB"].ToString());
                oEmp.DOJ =Convert.ToDateTime(rdr["DOJ"].ToString());
                oEmp.DOC = rdr["DOC"].ToString();
                oEmp.DOR = rdr["DOR"].ToString();
                //if (rdr["DOC"] == DBNull.Value)
                //{
                //    oEmp.DOC = 0;
                //}
                //else
                //{
                //    oEmp.DOC = Convert.ToDateTime((DateTime)rdr["DOC"]);
                //}
                //if (rdr["DOR"] == DBNull.Value)
                //{
                //    oEmp.DOR = null;
                //}
                //else
                //{
                //    oEmp.DOR = Convert.ToDateTime((DateTime)rdr["DOR"]);
                //}            
                oEmp.CurJobSts = (string)rdr["CUR_JOB_STATUS"].ToString();
                oEmp.ConfirmFlag = (string)rdr["CONFIRM_FLAG"].ToString();
                oEmp.PfMember = (string)rdr["PF_MEMBER"].ToString();
                oEmp.GratuityMember = (string)rdr["GRATUATITY_MEMBER"].ToString();
                oEmp.BnkAccNo = (string)rdr["BNK_AC_NO"].ToString();
                oEmp.PfAccNo = (string)rdr["PF_AC_NO"].ToString();
                oEmp.Tin = (string)rdr["TIN"].ToString();
                oEmp.PassPort = (string)rdr["PASSPORT_NO"].ToString();
                oEmp.InsuranceNo = (string)rdr["INSURANCE_NO"].ToString();
                oEmp.NationalId = (string)rdr["NATIONAL_ID"].ToString();
                oEmp.HoViRd = (string)rdr["HO_VI_AR_RD"].ToString();
                oEmp.HoViRdBeng = (string)rdr["HO_VI_AR_RD_BENG"].ToString();
                oEmp.PostCode = (string)rdr["POST_CODE"].ToString();
                oEmp.ThanaCode = (string)rdr["THANA_CODE"].ToString();
                oEmp.DistCode = (string)rdr["DISTRICT_CODE"].ToString();
                oEmp.Country = (string)rdr["COUNTRY"].ToString();
                oEmp.PerHoViRd = (string)rdr["PER_HO_VI_AR_RD"].ToString();
                oEmp.PerPostCOde = (string)rdr["PER_POST_CODE"].ToString();
                oEmp.PerThanaCode = (string)rdr["PER_THANA_CODE"].ToString();
                oEmp.PerDistCode = (string)rdr["PER_DISTRICT_CODE"].ToString();
                oEmp.SalFlag = (string)rdr["SAL_FLAG"].ToString();            
                oEmp.SalFlagChangeDate = (string)rdr["SAL_FLAG_CHNG_DT"].ToString();
                oEmp.ConsolidateFlag = (string)rdr["CONSOLIDATE_SCAL_FLAG"].ToString();
                oEmp.ConsolidateAmt = double.Parse(rdr["CONSOLIDATED_AMT"].ToString());
                oEmp.EmpRef1 = (string)rdr["EMP_REFF1"].ToString();
                oEmp.EmpRef2 = (string)rdr["EMP_REFF2"].ToString();
                oLvdays.Add(oEmp);
            }
            rdr.Close();
            return oLvdays;
        }
        #endregion

        #region GetEmployeeInformationForReport
        public List<EmployeeMasterRO> GetEmpJoiningReport(string Mode, string DeptGroup, string Dept,string Unit,string StartDate,string EndDate)
        {
            string packageName = "Pkg_HRM_Reports.GET_EMPLOYEE_JOINING_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
           };

            return GetEmpReportDetails(packageName, parameterList);
        }

        public List<EmployeeMasterRO> GetEmpResigReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            string packageName = "Pkg_HRM_Reports.GET_EMPLOYEE_RESIG_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
           };

            return GetEmpReportDetails(packageName, parameterList);
        }
        public List<EmployeeMasterRO> GetEmpConfDateReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            string packageName = "Pkg_HRM_Reports.GET_EMPLOYEE_CONF_DATE_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
           };

            return GetEmpReportDetails(packageName, parameterList);
        }
        public List<EmployeeMasterRO> GetEmpOthersReport(string Mode, string DeptGroup, string Dept, string Unit,string DropType,string StartDate, string EndDate)
        {
            string packageName = "Pkg_HRM_Reports.GET_EMPLOYEE_OTHERS_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                new OracleParameter("p_drop_type",OracleDbType.Varchar2,30,DropType,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,30,StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,30,EndDate,ParameterDirection.Input),
           };

            return GetEmpReportDetails(packageName, parameterList);
        }
        private List<EmployeeMasterRO> GetEmpReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMasterRO> oEmployeeMasterROs = new List<EmployeeMasterRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMasterRO oEmp = new EmployeeMasterRO();
                oEmp.EmpId = (String)rdr["EMP_ID"].ToString();
                oEmp.EmpName = (String)rdr["Name"].ToString();               
                oEmp.Sex = (String)rdr["sex"].ToString();
                oEmp.DesigId = (String)rdr["DSIG_TITLE"].ToString();                           
                oEmp.DOB = Convert.ToDateTime(rdr["DOB"].ToString());
                oEmp.DOJ = Convert.ToDateTime(rdr["DOJ"].ToString());
                if (rdr["DOC"] != DBNull.Value)
                {
                    oEmp.DOC = Convert.ToDateTime(rdr["DOC"].ToString()).ToString("dd/MM/yyyy");
                }
                if (rdr["DOR"] != DBNull.Value)
                {
                    oEmp.DOR = Convert.ToDateTime(rdr["DOR"].ToString()).ToString("dd/MM/yyyy");
                }
                oEmp.FormatDept = (string)rdr["FormatDept"].ToString();
                oEmp.LastQualification = (string)rdr["LastQualification"].ToString();
                oEmp.PastEmployer = (string)rdr["PastEmployer"].ToString();
                oEmp.Training = (string)rdr["Training"].ToString();
                oEmp.Salary = (string)rdr["Salary"].ToString();
                oEmployeeMasterROs.Add(oEmp);
            }
            rdr.Close();
            return oEmployeeMasterROs;
        }
        #endregion
    }
}
