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
    public class EmployeeSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;


        #region GetEmployeeAcademicInformation
        public List<EmpEducation> GetEducation()
        {
            string packagename = "PKG_HRM.GET_EMP_EDUCATION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)              
            };
            return GetEmpEdu(packagename, parameterList);

        }
        public List<EmpEducation> GetEmpEducation(string emp)
        {
            string packagename = "PKG_HRM.GET_EMP_EDUCATION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,emp,ParameterDirection.Input), 
            };
            return GetEmpEdu(packagename, parameterList);

        }

        private List<EmpEducation> GetEmpEdu(string packagename, OracleParameter[] parameterList)
        {
            List<EmpEducation> empedus = new List<EmpEducation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                EmpEducation oEmpEdu = new EmpEducation();
                oEmpEdu.serial = (string)rdr["SERIAL_NO"].ToString();
                oEmpEdu.NameOfDegree = (string)rdr["DEG_NAME"].ToString();
                oEmpEdu.PassingYear = (string)rdr["PASS_YEAR"].ToString();
                oEmpEdu.Institute = (string)rdr["INSTITUTE"].ToString();
                oEmpEdu.Class = (string)rdr["CLASS"].ToString();

                oEmpEdu.Remarks = !rdr.IsDBNull(7) ? (string)rdr["REMARKS"].ToString() : "";
                Staff staff = new Staff();
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmpEdu.EmployeeMaster = oEmpMas;
                staff.Country = (string)rdr["COUNTRY"].ToString();
                oEmpEdu.Staff = staff;


                empedus.Add(oEmpEdu);


            }
            rdr.Close();
            return empedus;

        }
#endregion

        #region SaveEmployeeAcademicInformation
        public short SaveEmpEdu(EmpEducation EmpEdu)
        {
            packagename = "PKG_HRM .INSERT_EMP_EDUCATION";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_serial",OracleDbType.Varchar2,70,EmpEdu.serial,ParameterDirection.Input),
                new OracleParameter("p_staff_id",OracleDbType.Varchar2,70,EmpEdu.EmployeeMaster.EmpId ,ParameterDirection.Input),
                new OracleParameter("p_deg_name",OracleDbType.Varchar2,100,EmpEdu.NameOfDegree,ParameterDirection.Input),
                new OracleParameter("p_pass_year",OracleDbType.Varchar2,70,EmpEdu.PassingYear,ParameterDirection.Input),
                new OracleParameter("p_institute",OracleDbType.Varchar2,150,EmpEdu.Institute,ParameterDirection.Input),
                new OracleParameter("p_class",OracleDbType.Varchar2,300,EmpEdu.Class,ParameterDirection.Input),
                new OracleParameter("p_country",OracleDbType.Varchar2,20,EmpEdu.Staff.Country,ParameterDirection.Input),
                new OracleParameter("p_remarks ",OracleDbType.Varchar2,300,EmpEdu.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,EmpEdu.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,EmpEdu.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,EmpEdu.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,EmpEdu.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,EmpEdu.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateEmployeeAcademicInformation
        public short UpdateEmpEdu(EmpEducation EmpEdu)
        {
            packagename = "PKG_HRM.UPDATE_EMP_EDUCATION";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_serial",OracleDbType.Varchar2,70,EmpEdu.serial,ParameterDirection.Input),
                new OracleParameter("p_staff_id",OracleDbType.Varchar2,70,EmpEdu.EmployeeMaster.EmpId ,ParameterDirection.Input),
                new OracleParameter("p_deg_name",OracleDbType.Varchar2,70,EmpEdu.NameOfDegree,ParameterDirection.Input),
                new OracleParameter("p_pass_year",OracleDbType.Varchar2,70,EmpEdu.PassingYear,ParameterDirection.Input),
                new OracleParameter("p_institute",OracleDbType.Varchar2,20,EmpEdu.Institute,ParameterDirection.Input),
                new OracleParameter("p_class",OracleDbType.Varchar2,300,EmpEdu.Class,ParameterDirection.Input),
                new OracleParameter("p_country",OracleDbType.Varchar2,20,EmpEdu.Staff.Country,ParameterDirection.Input),
                new OracleParameter("p_remarks ",OracleDbType.Varchar2,300,EmpEdu.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,EmpEdu.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,EmpEdu.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,EmpEdu.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,EmpEdu.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,EmpEdu.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetEmployeeMaster
        public EmployeeMaster GetEmployeeMaster(string ID)
        {
            string packagename = "PKG_EMP_SETUP.GET_EMPLOYEE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_id",OracleDbType.Varchar2,30,ID,ParameterDirection.Input),         
            };
            return GetEmployeeMaster(packagename, parameterList);
        }


        private EmployeeMaster GetEmployeeMaster(string packagename, OracleParameter[] parameterList)
        {
            EmployeeMaster oEmpMast = new EmployeeMaster();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                oEmpMast.FirstName =rdr["FIRST_NAME"]!= DBNull.Value ? (string)rdr["FIRST_NAME"].ToString() : "";
                oEmpMast.MiddleName = rdr["MIDDLE_NAME"] != DBNull.Value ? (string)rdr["MIDDLE_NAME"].ToString() : "";
                oEmpMast.LastName = rdr["LAST_NAME"] != DBNull.Value ? (string)rdr["LAST_NAME"].ToString() : "";
                oEmpMast.NickName = rdr["NICK_NAME"] != DBNull.Value ? (string)rdr["NICK_NAME"].ToString() : "";
                oEmpMast.EmpNameBeng = (string)rdr["EMP_NAME_BENG"].ToString();
                oEmpMast.FathersName = (string)rdr["FAT_NAME"].ToString();
                oEmpMast.FathersNameBeng = (string)rdr["FAT_NAME_BENG"].ToString();
                oEmpMast.MothersName = (string)rdr["MOT_NAME"].ToString();
                oEmpMast.MothersNameBeng = (string)rdr["MOT_NAME_BENG"].ToString();
                oEmpMast.SpouseName = rdr["SPOUSE_NAME"] != DBNull.Value ? (string)rdr["SPOUSE_NAME"].ToString() : "";
                oEmpMast.SpouseNameBeng = rdr["SPOUSE_NAME_BENG"] != DBNull.Value ? (string)rdr["SPOUSE_NAME_BENG"].ToString() : "";
                oEmpMast.Religion = rdr["RELIGION"] != DBNull.Value ? (string)rdr["RELIGION"].ToString() : "";
                oEmpMast.Sex = rdr["SEX"] != DBNull.Value ? (string)rdr["SEX"].ToString() : "";
                oEmpMast.BloodGroup = rdr["BLOOD_GRP"] != DBNull.Value ? (string)rdr["BLOOD_GRP"].ToString() : "";
                oEmpMast.MaritalStatus = rdr["MARITIAL_STATUS"] != DBNull.Value ? (string)rdr["MARITIAL_STATUS"].ToString() : "";
                oEmpMast.Nationality = rdr["NATIONALITY"] != DBNull.Value ? (string)rdr["NATIONALITY"].ToString() : "";
                oEmpMast.PhotoPath = (string)rdr["PHOTO_PATH"].ToString();
                oEmpMast.SignaturePath = (string)rdr["SIGNATURE_PATH"].ToString();
                oEmpMast.CompanyId = rdr["COMPANY_ID"] != DBNull.Value ? (string)rdr["COMPANY_ID"].ToString() : "";
                oEmpMast.JobType = rdr["JOB_TYPE_ID"] != DBNull.Value ? (string)rdr["JOB_TYPE_ID"].ToString() : "";
                oEmpMast.EmpClass = rdr["EMP_CLASS"] != DBNull.Value ? (string)rdr["EMP_CLASS"].ToString() : "";               
                oEmpMast.DOB = Convert.ToDateTime((DateTime)rdr["DOB"]);
                if (rdr["DOJ"] == DBNull.Value)
                {
                    oEmpMast.DOJ = null;
                }
                else
                {
                    oEmpMast.DOJ = Convert.ToDateTime((DateTime)rdr["DOJ"]);
                }
                if (rdr["DOC"] == DBNull.Value)
                {
                    oEmpMast.DOC = null;
                }
                else
                {
                    oEmpMast.DOC = Convert.ToDateTime((DateTime)rdr["DOC"]);
                }
                if (rdr["DOR"] == DBNull.Value)
                {
                    oEmpMast.DOR = null;
                }
                else
                {
                    oEmpMast.DOR = Convert.ToDateTime((DateTime)rdr["DOR"]);
                }
                oEmpMast.CurrentJobStatus = rdr["CUR_JOB_STATUS"] != DBNull.Value ? (string)rdr["CUR_JOB_STATUS"].ToString() : "";
                oEmpMast.ConfirmFlag = rdr["CONFIRM_FLAG"] != DBNull.Value ? (string)rdr["CONFIRM_FLAG"].ToString() : "";
                oEmpMast.PfMember = rdr["PF_MEMBER"] != DBNull.Value ? (string)rdr["PF_MEMBER"].ToString() : "";
                oEmpMast.GratuityMember = rdr["GRATUATITY_MEMBER"] != DBNull.Value ? (string)rdr["GRATUATITY_MEMBER"] : "";
                oEmpMast.BankAccNo = rdr["BNK_AC_NO"] != DBNull.Value ? (string)rdr["BNK_AC_NO"].ToString() : "";
                oEmpMast.PfAccNo = rdr["PF_AC_NO"] != DBNull.Value ? (string)rdr["PF_AC_NO"].ToString() : "";
                oEmpMast.TIN = rdr["TIN"] != DBNull.Value ? (string)rdr["TIN"].ToString() : "";
                oEmpMast.Passport = rdr["PASSPORT_NO"] != DBNull.Value ? (string)rdr["PASSPORT_NO"].ToString() : "";
                oEmpMast.InsuranceNo = rdr["INSURANCE_NO"] != DBNull.Value ? (string)rdr["INSURANCE_NO"].ToString() : "";
                oEmpMast.AttnCardNumber = rdr["ATTN_CARD_NO"] != DBNull.Value ? (string)rdr["ATTN_CARD_NO"].ToString() : "";
                oEmpMast.IntercomNumber = rdr["INTERCOM_NO"] != DBNull.Value ? (string)rdr["INTERCOM_NO"].ToString() : "";
                oEmpMast.Email = rdr["EMAIL_ID"] != DBNull.Value ? (string)rdr["EMAIL_ID"].ToString() : "";
                oEmpMast.PersonalEmail = rdr["PERSONAL_EMAIL"] != DBNull.Value ? (string)rdr["PERSONAL_EMAIL"].ToString() : "";
                oEmpMast.HomePhone = rdr["HOME_PHONE"] != DBNull.Value ? (string)rdr["HOME_PHONE"].ToString() : "";
                oEmpMast.CellPhone = rdr["CELL_PHONE"] != DBNull.Value ? (string)rdr["CELL_PHONE"].ToString() : "";
                oEmpMast.NID = rdr["NATIONAL_ID"] != DBNull.Value ? (string)rdr["NATIONAL_ID"].ToString() : "";
                oEmpMast.Present_H_R_B = rdr["HO_VI_AR_RD"] != DBNull.Value ? (string)rdr["HO_VI_AR_RD"].ToString() : "";
                oEmpMast.Present_H_R_B_Beng = rdr["HO_VI_AR_RD_BENG"] != DBNull.Value ? (string)rdr["HO_VI_AR_RD_BENG"].ToString() : "";
                oEmpMast.Present_Post = rdr["POST_CODE"] != DBNull.Value ? (string)rdr["POST_CODE"].ToString() : "";
                oEmpMast.PresentThana = rdr["THANA_CODE"] != DBNull.Value ? (string)rdr["THANA_CODE"].ToString() : "";
                oEmpMast.PresentDistrict = rdr["DISTRICT_CODE"] != DBNull.Value ? (string)rdr["DISTRICT_CODE"].ToString() : "";
                oEmpMast.Country = rdr["COUNTRY"] != DBNull.Value ? (string)rdr["COUNTRY"].ToString() : "";
                oEmpMast.Permanent_H_R_B = rdr["PER_HO_VI_AR_RD"] != DBNull.Value ? (string)rdr["PER_HO_VI_AR_RD"].ToString() : "";
                oEmpMast.Permanent_Post = rdr["PER_POST_CODE"] != DBNull.Value ? (string)rdr["PER_POST_CODE"].ToString() : "";
                oEmpMast.PermanentThana = rdr["PER_THANA_CODE"] != DBNull.Value ? (string)rdr["PER_THANA_CODE"].ToString() : "";
                oEmpMast.PermanentDistrict = rdr["PER_DISTRICT_CODE"] != DBNull.Value ? (string)rdr["PER_DISTRICT_CODE"].ToString() : "";
                oEmpMast.SalFlag = rdr["SAL_FLAG"] != DBNull.Value ? (string)rdr["SAL_FLAG"].ToString() : "";
                oEmpMast.EmployeeType = rdr["EMP_INT_OR_EXT"] != DBNull.Value ? (string)rdr["EMP_INT_OR_EXT"].ToString() : "";
                oEmpMast.RecruitmentType = rdr["RECRUIT_TYPE"] != DBNull.Value ? (string)rdr["RECRUIT_TYPE"].ToString() : "";
                oEmpMast.BankID = rdr["BANK_ID"] != DBNull.Value ? (string)rdr["BANK_ID"].ToString() : "";
                if (rdr["SAL_FLAG_CHNG_DT"] == DBNull.Value)
                {
                    oEmpMast.SalFlagChangeDt = null;
                }
                else
                {
                    oEmpMast.SalFlagChangeDt = Convert.ToDateTime((DateTime)rdr["SAL_FLAG_CHNG_DT"]);
                }
                oEmpMast.ConsolidateScaleFlag = rdr["CONSOLIDATE_SCAL_FLAG"] != DBNull.Value ? (string)rdr["CONSOLIDATE_SCAL_FLAG"].ToString() : "";
                oEmpMast.ConsolidatedAmount = Convert.ToInt64(rdr["CONSOLIDATED_AMT"].ToString());
                oEmpMast.SalScaleID = rdr["Scale"] != DBNull.Value ? (string)rdr["Scale"].ToString() : "";
                oEmpMast.SalGradeID =rdr["Grade"] != DBNull.Value ?  (string)rdr["Grade"].ToString():"";
                oEmpMast.Reff1 = rdr["EMP_REFF1"] != DBNull.Value ? (string)rdr["EMP_REFF1"].ToString() : "";
                oEmpMast.Reff2 = rdr["EMP_REFF2"] != DBNull.Value ? (string)rdr["EMP_REFF2"].ToString() : "";
                oEmpMast.FringeBenefitGrp = (string)rdr["FRINGE_BENEFIT_GRP_ID"].ToString();  
                oEmpMast.PhotoPath=(string)rdr["PHOTO_PATH"].ToString();
                oEmpMast.SignaturePath = (string)rdr["SIGNATURE_PATH"].ToString();

                Department oDept = new Department();
                oDept.DepartmentID = (string)rdr["Department"].ToString();
                oEmpMast.Department = oDept;              

                DepartmentGroup oDeptg = new DepartmentGroup();
                oDeptg.DepartmentGroupID = (string)rdr["DepartmentGroup"].ToString();
                oDept.DepartmentGroup = oDeptg;
                oEmpMast.Department = oDept;

                DepartmentUnit oDUnit = new DepartmentUnit();
                oDUnit.UnitId = (string)rdr["Unit"].ToString();
                oEmpMast.DepartmentUnit = oDUnit;

                Designation oDsig = new Designation();
                oDsig.DesignationId = (string)rdr["Designation"].ToString();
                oEmpMast.Designation = oDsig;

                DesignationGroup oDsgr = new DesignationGroup();
                oDsgr.GroupId = (string)rdr["DesignationGroup"].ToString();
                oDsig.DesignationGroup = oDsgr;
                oEmpMast.Designation = oDsig;


            }
            rdr.Close();
            return oEmpMast;

        }
        #endregion

        #region UpdateEmployeeMaster

        public string UpdateEmployeeMaster(EmployeeMaster mas)
        {
            string packagename = "PKG_EMP_SETUP.UPDATE_EMPLOYEE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,mas,ParameterDirection.Output ),
                new OracleParameter("p_emp_id1",OracleDbType.Varchar2,30,mas.EmpId,ParameterDirection.Input ),
                new OracleParameter("p_first_name",OracleDbType.Varchar2,300,mas.FirstName,ParameterDirection.Input),
                new OracleParameter("p_middle_name",OracleDbType.Varchar2,300,mas.MiddleName,ParameterDirection.Input),
                new OracleParameter("p_last_name",OracleDbType.Varchar2,300,mas.LastName,ParameterDirection.Input),
                new OracleParameter("p_emp_name_beng",OracleDbType.Varchar2,400,mas.EmpNameBeng,ParameterDirection.Input),
                new OracleParameter("p_nick_name",OracleDbType.Varchar2,300,mas.NickName,ParameterDirection.Input),
                new OracleParameter("p_fat_name",OracleDbType.Varchar2,300,mas.FathersName,ParameterDirection.Input),
                new OracleParameter("p_fat_name_beng",OracleDbType.Varchar2,300,mas.FathersNameBeng,ParameterDirection.Input),
                new OracleParameter("p_mot_name",OracleDbType.Varchar2,300,mas.MothersName,ParameterDirection.Input),
                new OracleParameter("p_mot_name_beng",OracleDbType.Varchar2,300,mas.MothersNameBeng,ParameterDirection.Input),
                new OracleParameter("p_spouse_name",OracleDbType.Varchar2,300,mas.SpouseName,ParameterDirection.Input),
                new OracleParameter("p_spouse_name_beng",OracleDbType.Varchar2,300,mas.SpouseNameBeng,ParameterDirection.Input),
                new OracleParameter("p_religion",OracleDbType.Varchar2,1,mas.Religion,ParameterDirection.Input),
                new OracleParameter("p_sex",OracleDbType.Varchar2,1,mas.Sex,ParameterDirection.Input),
                new OracleParameter("p_blood_grp",OracleDbType.Varchar2,3,mas.BloodGroup,ParameterDirection.Input),
                new OracleParameter("p_maritial_status",OracleDbType.Varchar2,1,mas.MaritalStatus,ParameterDirection.Input),
                new OracleParameter("p_nationality",OracleDbType.Varchar2,300,mas.Nationality,ParameterDirection.Input),
                new OracleParameter("p_photo_path",OracleDbType.Varchar2,300,mas.PhotoPath,ParameterDirection.Input),
                new OracleParameter("p_signature_path",OracleDbType.Varchar2,300,mas.SignaturePath,ParameterDirection.Input),              
                new OracleParameter("p_dob",OracleDbType.Date,mas.DOB,ParameterDirection.Input),
                new OracleParameter("p_doj",OracleDbType.Date,mas.DOJ,ParameterDirection.Input),
                new OracleParameter("p_doc",OracleDbType.Date,mas.DOC,ParameterDirection.Input),
                new OracleParameter("p_dor",OracleDbType.Date,mas.DOR,ParameterDirection.Input),
                new OracleParameter("p_confirm_flag",OracleDbType.Varchar2,1,mas.ConfirmFlag,ParameterDirection.Input),
                new OracleParameter("p_pf_member",OracleDbType.Varchar2,1,mas.PfMember,ParameterDirection.Input),
                new OracleParameter("p_gratuatity_member",OracleDbType.Char,1,mas.GratuityMember,ParameterDirection.Input),
                new OracleParameter("p_bnk_ac_no",OracleDbType.Varchar2,30,mas.BankAccNo,ParameterDirection.Input),
                new OracleParameter("p_pf_ac_no",OracleDbType.Varchar2,50,mas.PfAccNo,ParameterDirection.Input),
                new OracleParameter("p_tin",OracleDbType.Varchar2,100,mas.TIN,ParameterDirection.Input),
                new OracleParameter("p_passport_no",OracleDbType.Varchar2,100,mas.Passport,ParameterDirection.Input),
                new OracleParameter("p_insurance_no",OracleDbType.Varchar2,50,mas.InsuranceNo,ParameterDirection.Input),
                new OracleParameter("p_attn_card_no",OracleDbType.Varchar2,50,mas.AttnCardNumber,ParameterDirection.Input),
                new OracleParameter("p_intercom_number",OracleDbType.Varchar2,50,mas.IntercomNumber,ParameterDirection.Input),
                new OracleParameter("p_email_id",OracleDbType.Varchar2,70,mas.Email,ParameterDirection.Input),
                new OracleParameter("p_personal_email",OracleDbType.Varchar2,100,mas.PersonalEmail,ParameterDirection.Input),
                new OracleParameter("p_home_phone",OracleDbType.Varchar2,70,mas.HomePhone,ParameterDirection.Input),
                new OracleParameter("p_cell_phone",OracleDbType.Varchar2,70,mas.CellPhone,ParameterDirection.Input),
                new OracleParameter("p_national_id",OracleDbType.Varchar2,40,mas.NID,ParameterDirection.Input),
                new OracleParameter("p_ho_vi_ar_rd",OracleDbType.Varchar2,200,mas.Present_H_R_B,ParameterDirection.Input),
                new OracleParameter("p_ho_vi_ar_rd_beng",OracleDbType.Varchar2,200,mas.Present_H_R_B_Beng,ParameterDirection.Input),
                new OracleParameter("p_post_code",OracleDbType.Varchar2,10,mas.Present_Post,ParameterDirection.Input),
                new OracleParameter("p_thana_code",OracleDbType.Varchar2,100,mas.PresentThana,ParameterDirection.Input),
                new OracleParameter("p_district_code",OracleDbType.Varchar2,100,mas.PresentDistrict,ParameterDirection.Input),
                new OracleParameter("p_country",OracleDbType.Varchar2,100,mas.Country,ParameterDirection.Input),
                new OracleParameter("p_per_ho_vi_ar_rd",OracleDbType.Varchar2,200,mas.Permanent_H_R_B,ParameterDirection.Input),
                new OracleParameter("p_per_post_code",OracleDbType.Varchar2,10,mas.Permanent_Post,ParameterDirection.Input),
                new OracleParameter("p_per_thana_code",OracleDbType.Varchar2,100,mas.PermanentThana,ParameterDirection.Input),
                new OracleParameter("p_per_district_code",OracleDbType.Varchar2,100,mas.PermanentDistrict,ParameterDirection.Input),
                new OracleParameter("p_sal_flag",OracleDbType.Varchar2,1,mas.SalFlag,ParameterDirection.Input),
                new OracleParameter("p_sal_flag_chng_dt",OracleDbType.Date,mas.SalFlagChangeDt,ParameterDirection.Input),
                new OracleParameter("p_consolidate_scal_flag",OracleDbType.Varchar2,1,mas.ConsolidateScaleFlag,ParameterDirection.Input),              
                new OracleParameter("p_emp_reff1",OracleDbType.Varchar2,2500,mas.Reff1,ParameterDirection.Input),
                new OracleParameter("p_emp_reff2",OracleDbType.Varchar2,2500,mas.Reff2,ParameterDirection.Input),
                new OracleParameter("p_fringe_benefit_grp",OracleDbType.Varchar2,8,mas.FringeBenefitGrp,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mas.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,mas.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mas.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,4,mas.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mas.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("p_emp_type",OracleDbType.Varchar2,2,mas.EmployeeType,ParameterDirection.Input),
                new OracleParameter("p_bank_id",OracleDbType.Varchar2,3,mas.BankID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            prm = parameterList[1];
            if ((OracleString)prm.Value != "0")
                return prm.Value.ToString();
            else return "0";
        }

        #endregion

        #region GetScaleUnderGrade

        public List<ScaleMSetup> GetScaleUnderGrade(string oSalHdG)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SCALE_UNDER_GRADE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,30,oSalHdG,ParameterDirection.Input),              
           };

            return GetScaleUnderGrd(packageName, parameterList);
        }
        private List<ScaleMSetup> GetScaleUnderGrd(string packageName, OracleParameter[] parameterList)
        {
            List<ScaleMSetup> oSclDSets = new List<ScaleMSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    ScaleMSetup oScaleMSetup = new ScaleMSetup();
                    oScaleMSetup.ScaleTitle = !rdr.IsDBNull(0) ? (string)rdr["SCALE_TITLE"] : "";
                    oScaleMSetup.ScaleMID = !rdr.IsDBNull(0) ? (string)rdr["SCALE_M_ID"] : "";
                    oSclDSets.Add(oScaleMSetup);
                }
                rdr.Close();
                return oSclDSets;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region GetEmployeeID

        public  List<EmployeeMaster>  GetEmployeeID()
        {
            string packagename = "PKG_EMP_SETUP.GET_EMP_ID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)        
            };
           return GetEmployeeID(packagename, parameterList);           
        }
        private List<EmployeeMaster> GetEmployeeID(string packagename, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oEmpMasts = new List<EmployeeMaster>();
            EmployeeMaster oEmp = new EmployeeMaster();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            if (rdr.Read())
            {
                oEmp.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmp.EmpNameBeng = (string)rdr["NAME"].ToString();
                oEmpMasts.Add(oEmp);
            }
            rdr.Close();
            return oEmpMasts;

        }
        #endregion

        #region GetEmpMaster
        public EmployeeMaster GetEmpMaster(string ID)
        {
            string packagename = "PKG_EMP_INFO.GET_EMPLOYEE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_id",OracleDbType.Varchar2,30,ID,ParameterDirection.Input),         
            };
            return GetEmpMaster(packagename, parameterList);
        }
        private EmployeeMaster GetEmpMaster(string packagename, OracleParameter[] parameterList)
        {
            EmployeeMaster oEmpMast = new EmployeeMaster();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                oEmpMast.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmpMast.Email = (string)rdr["EMAIL_ID"].ToString();
                oEmpMast.FirstName = (string)rdr["EmployeeName"].ToString();
                oEmpMast.ConsolidateScaleFlag = (string)rdr["CONSOLIDATE_SCAL_FLAG"].ToString();
                Department oDept = new Department();
                oDept.DepartmentID = (string)rdr["dept_id"].ToString();
                oDept.DepartmentTitle = (string)rdr["dept_title"].ToString();
                oEmpMast.Department = oDept;

                DepartmentUnit oDUnit = new DepartmentUnit();
                oDUnit.UnitId = (string)rdr["Unit"].ToString();
                oEmpMast.DepartmentUnit = oDUnit;

                Designation oDsig = new Designation();
                oDsig.DesignationId = (string)rdr["Designation"].ToString();
                oEmpMast.Designation = oDsig;
                oEmpMast.PhotoPath = (string)rdr["PHOTO_PATH"].ToString();

                EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
                oEmpJobInfo.ReportingPerson = rdr["REPORTING_PERSON_ID"].ToString();
                oEmpJobInfo.ReportingPersonName = rdr["REPORTING_PERSON_NAME"].ToString();
                oEmpJobInfo.DeptHead = rdr["DEPT_HEAD_ID"].ToString();
                oEmpJobInfo.DeptHeadName = rdr["DEPT_HEAD_NAME"].ToString();
                oEmpJobInfo.Class = rdr["CLASS_ID"].ToString();
                oEmpJobInfo.FoodSubsidy = rdr["PERCENT"].ToString();
                oEmpMast.EmployeeJobInformation = oEmpJobInfo;

            }
            rdr.Close();
            return oEmpMast;

        }
     #endregion

        #region SaveEmployeeMasterWIthJobInfo

        public short SaveEmpMasterJobInfo(EmployeeJobInformation mas)
        {
            string packagename = "PKG_EMP_SETUP.INSERT_EMP_MASTER_JOB_INFO";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,mas.EmployeeMaster.EmpId,ParameterDirection.Output),
                new OracleParameter("p_first_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.FirstName,ParameterDirection.Input),
                new OracleParameter("p_middle_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.MiddleName,ParameterDirection.Input),
                new OracleParameter("p_last_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.LastName,ParameterDirection.Input),
                new OracleParameter("p_emp_name_beng",OracleDbType.Varchar2,400,mas.EmployeeMaster.EmpNameBeng,ParameterDirection.Input),
                new OracleParameter("p_nick_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.NickName,ParameterDirection.Input),
                new OracleParameter("p_fat_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.FathersName,ParameterDirection.Input),
                new OracleParameter("p_fat_name_beng",OracleDbType.Varchar2,300,mas.EmployeeMaster.FathersNameBeng,ParameterDirection.Input),
                new OracleParameter("p_mot_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.MothersName,ParameterDirection.Input),
                new OracleParameter("p_mot_name_beng",OracleDbType.Varchar2,300,mas.EmployeeMaster.MothersNameBeng,ParameterDirection.Input),
                new OracleParameter("p_spouse_name",OracleDbType.Varchar2,300,mas.EmployeeMaster.SpouseName,ParameterDirection.Input),
                new OracleParameter("p_spouse_name_beng",OracleDbType.Varchar2,300,mas.EmployeeMaster.SpouseNameBeng,ParameterDirection.Input),
                new OracleParameter("p_religion",OracleDbType.Varchar2,1,mas.EmployeeMaster.Religion,ParameterDirection.Input),
                new OracleParameter("p_sex",OracleDbType.Varchar2,1,mas.EmployeeMaster.Sex,ParameterDirection.Input),
                new OracleParameter("p_blood_grp",OracleDbType.Varchar2,3,mas.EmployeeMaster.BloodGroup,ParameterDirection.Input),
                new OracleParameter("p_maritial_status",OracleDbType.Varchar2,1,mas.EmployeeMaster.MaritalStatus,ParameterDirection.Input),
                new OracleParameter("p_nationality",OracleDbType.Varchar2,300,mas.EmployeeMaster.Nationality,ParameterDirection.Input),
                new OracleParameter("p_photo_path",OracleDbType.Varchar2,300,mas.EmployeeMaster.PhotoPath,ParameterDirection.Input),
                new OracleParameter("p_signature_path",OracleDbType.Varchar2,300,mas.EmployeeMaster.SignaturePath,ParameterDirection.Input), 
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,mas.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,mas.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,mas.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_desig_id",OracleDbType.Varchar2,6,mas.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("p_job_type_id",OracleDbType.Varchar2,2,mas.JobType,ParameterDirection.Input),
                new OracleParameter("p_emp_type",OracleDbType.Varchar2,2,mas.EmployeeMaster.EmployeeType,ParameterDirection.Input),
                new OracleParameter("p_recruitment_type",OracleDbType.Varchar2,2,mas.RecruitmentType,ParameterDirection.Input),
                new OracleParameter("p_emp_class",OracleDbType.Varchar2,1,mas.Class,ParameterDirection.Input),
                new OracleParameter("p_dept_head_id",OracleDbType.Varchar2,30,mas.DeptHead,ParameterDirection.Input),
                new OracleParameter("p_reporting_person_id",OracleDbType.Varchar2,30,mas.ReportingPerson,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Date,mas.StartDate,ParameterDirection.Input),
                new OracleParameter("p_end_date",OracleDbType.Date,mas.EndDate,ParameterDirection.Input),
                new OracleParameter("p_retire_date",OracleDbType.Date,mas.RetireDate,ParameterDirection.Input),
                new OracleParameter("p_transfer_date",OracleDbType.Date,mas.TransferDate,ParameterDirection.Input),
                new OracleParameter("p_service_book_reff_no",OracleDbType.Varchar2,200,mas.ServiceBookReffNo,ParameterDirection.Input),
                new OracleParameter("p_job_desc",OracleDbType.Varchar2,500,mas.JobDesc,ParameterDirection.Input),
                new OracleParameter("p_job_update_cause_type",OracleDbType.Varchar2,2,mas.JobUpdateCauseType,ParameterDirection.Input),
                new OracleParameter("p_responsibilities",OracleDbType.Varchar2,100,mas.Responsibilities,ParameterDirection.Input),
                new OracleParameter("p_office_ord_no",OracleDbType.Varchar2,400,mas.OfficeOrderNo,ParameterDirection.Input),
                new OracleParameter("p_dob",OracleDbType.Date,mas.EmployeeMaster.DOB,ParameterDirection.Input),
                new OracleParameter("p_doj",OracleDbType.Date,mas.EmployeeMaster.DOJ,ParameterDirection.Input),
                new OracleParameter("p_doc",OracleDbType.Date,mas.EmployeeMaster.DOC,ParameterDirection.Input),
                new OracleParameter("p_dor",OracleDbType.Date,mas.EmployeeMaster.DOR,ParameterDirection.Input),
                new OracleParameter("p_confirm_flag",OracleDbType.Varchar2,1,mas.EmployeeMaster.ConfirmFlag,ParameterDirection.Input),
                new OracleParameter("p_pf_member",OracleDbType.Varchar2,1,mas.EmployeeMaster.PfMember,ParameterDirection.Input),
                new OracleParameter("p_gratuatity_member",OracleDbType.Char,1,mas.EmployeeMaster.GratuityMember,ParameterDirection.Input),
                new OracleParameter("p_bnk_ac_no",OracleDbType.Varchar2,30,mas.EmployeeMaster.BankAccNo,ParameterDirection.Input),
                new OracleParameter("p_pf_ac_no",OracleDbType.Varchar2,50,mas.EmployeeMaster.PfAccNo,ParameterDirection.Input),
                new OracleParameter("p_tin",OracleDbType.Varchar2,100,mas.EmployeeMaster.TIN,ParameterDirection.Input),
                new OracleParameter("p_passport_no",OracleDbType.Varchar2,100,mas.EmployeeMaster.Passport,ParameterDirection.Input),
                new OracleParameter("p_insurance_no",OracleDbType.Varchar2,50,mas.EmployeeMaster.InsuranceNo,ParameterDirection.Input),
                new OracleParameter("p_attn_card_no",OracleDbType.Varchar2,50,mas.EmployeeMaster.AttnCardNumber,ParameterDirection.Input),
                new OracleParameter("p_intercom_number",OracleDbType.Varchar2,50,mas.EmployeeMaster.IntercomNumber,ParameterDirection.Input),
                new OracleParameter("p_email_id",OracleDbType.Varchar2,70,mas.EmployeeMaster.Email,ParameterDirection.Input),
                new OracleParameter("p_personal_email",OracleDbType.Varchar2,100,mas.EmployeeMaster.PersonalEmail,ParameterDirection.Input),
                new OracleParameter("p_home_phone",OracleDbType.Varchar2,70,mas.EmployeeMaster.HomePhone,ParameterDirection.Input),
                new OracleParameter("p_cell_phone",OracleDbType.Varchar2,70,mas.EmployeeMaster.CellPhone,ParameterDirection.Input),
                new OracleParameter("p_national_id",OracleDbType.Varchar2,40,mas.EmployeeMaster.NID,ParameterDirection.Input),
                new OracleParameter("p_ho_vi_ar_rd",OracleDbType.Varchar2,500,mas.EmployeeMaster.Present_H_R_B,ParameterDirection.Input),
                new OracleParameter("p_ho_vi_ar_rd_beng",OracleDbType.Varchar2,500,mas.EmployeeMaster.Present_H_R_B_Beng,ParameterDirection.Input),
                new OracleParameter("p_post_code",OracleDbType.Varchar2,100,mas.EmployeeMaster.Present_Post,ParameterDirection.Input),
                new OracleParameter("p_thana_code",OracleDbType.Varchar2,100,mas.EmployeeMaster.PresentThana,ParameterDirection.Input),
                new OracleParameter("p_district_code",OracleDbType.Varchar2,100,mas.EmployeeMaster.PresentDistrict,ParameterDirection.Input),
                new OracleParameter("p_country",OracleDbType.Varchar2,100,mas.EmployeeMaster.Country,ParameterDirection.Input),
                new OracleParameter("p_per_ho_vi_ar_rd",OracleDbType.Varchar2,500,mas.EmployeeMaster.Permanent_H_R_B,ParameterDirection.Input),
                new OracleParameter("p_per_post_code",OracleDbType.Varchar2,100,mas.EmployeeMaster.Permanent_Post,ParameterDirection.Input),
                new OracleParameter("p_per_thana_code",OracleDbType.Varchar2,100,mas.EmployeeMaster.PermanentThana,ParameterDirection.Input),
                new OracleParameter("p_per_district_code",OracleDbType.Varchar2,100,mas.EmployeeMaster.PermanentDistrict,ParameterDirection.Input),
                new OracleParameter("p_sal_flag",OracleDbType.Varchar2,1,mas.EmployeeMaster.SalFlag,ParameterDirection.Input),
                new OracleParameter("p_sal_flag_chng_dt",OracleDbType.Date,mas.EmployeeMaster.SalFlagChangeDt,ParameterDirection.Input),
                new OracleParameter("p_consolidate_scal_flag",OracleDbType.Varchar2,1,mas.ConsolidateScaleFlag,ParameterDirection.Input),
                new OracleParameter("p_consolidated_amt",OracleDbType.Varchar2,100,mas.ConsolidatedAmount,ParameterDirection.Input),
                new OracleParameter("p_sal_scale_id",OracleDbType.Varchar2,30,mas.SalScaleID,ParameterDirection.Input),
                new OracleParameter("p_sal_grade_id",OracleDbType.Varchar2,30,mas.SalGradeID,ParameterDirection.Input),
                new OracleParameter("p_serial_no",OracleDbType.Varchar2,30,mas.SerialNo,ParameterDirection.Input),
                new OracleParameter("p_emp_reff1",OracleDbType.Varchar2,2500,mas.EmployeeMaster.Reff1,ParameterDirection.Input),
                new OracleParameter("p_emp_reff2",OracleDbType.Varchar2,2500,mas.EmployeeMaster.Reff2,ParameterDirection.Input),
                new OracleParameter("p_fringe_benefit_grp",OracleDbType.Varchar2,8,mas.EmployeeMaster.FringeBenefitGrp,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mas.EmployeeMaster.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_encrypted_password",OracleDbType.Varchar2,15,mas.EmployeeMaster.EntryParameter.UpdateBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mas.EmployeeMaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,4,mas.EmployeeMaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mas.EmployeeMaster.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("p_test_subs",OracleDbType.Varchar2,20000,mas.BenefitString,ParameterDirection.Input),
                new OracleParameter("p_bank_id",OracleDbType.Varchar2,3,mas.EmployeeMaster.BankID,ParameterDirection.Input)
                
            };

            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetEmpID
        public List<EmployeeMaster> GetEmpID(string dept)
        {
            string packageName = "PKG_EMP_SETUP.GET_EMP_ID";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp",OracleDbType.Varchar2,30,dept,ParameterDirection.Input)
           };

            return GetEmpDept(packageName, parameterList);
        }

        private List<EmployeeMaster> GetEmpDept(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oSals = new List<EmployeeMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMaster oSal = new EmployeeMaster();
                oSal.EmpId = (String)rdr["EMP_ID"].ToString();
                oSal.EmpNameBeng = (String)rdr["NAME"].ToString();
                oSals.Add(oSal);
            }
            rdr.Close();
            return oSals;
        }
#endregion

        #region SaveDeptHeadInfo
        public short SaveDeptHeadInfo(EmployeeJobInformation mas)
        {
            string packagename = "PKG_EMP_SETUP.INSERT_DEPT_HEAD_INFO";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),                               
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,mas.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,mas.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,mas.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_head_string",OracleDbType.Varchar2,1000,mas.HeadString,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mas.EmployeeMaster.EntryParameter.EntryBy,ParameterDirection.Input),               
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mas.EmployeeMaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,4,mas.EmployeeMaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mas.EmployeeMaster.EntryParameter.MachineID,ParameterDirection.Input),               
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetDeptHead
        public List<EmployeeJobInformation> GetDeptHead(string DeptGroup,string Dept,string Unit)
        {
            string packageName = "PKG_EMP_SETUP.GET_DEPT_HEAD_INFO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
            };
            return GetDeptHeadDetails(packageName, parameterList);

        }
        public List<EmployeeJobInformation> GetDepartmentHead(string DeptGroup)
        {
            string packageName = "PKG_EMP_SETUP.GET_DEPT_HEAD";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGroup,ParameterDirection.Input)
              
            };
            return GetDeptHeadDetails(packageName, parameterList);

        }

        private List<EmployeeJobInformation> GetDeptHeadDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeJobInformation> oEmpJobInfos = new List<EmployeeJobInformation>();

            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();

                EmployeeMaster oEmployeeMaster = new EmployeeMaster();
                oEmployeeMaster.EmpId = (string)rdr["EMP_ID"].ToString();
                oEmployeeMaster.Name = (string)rdr["name"].ToString();
                oEmpJobInfo.EmployeeMaster = oEmployeeMaster;

                oEmpJobInfo.DOJAsHead = Convert.ToDateTime(rdr["DOJ_AS_HEAD"]).ToString("dd/MM/yyyy");

                oEmpJobInfos.Add(oEmpJobInfo);
            }
            rdr.Close();
            return oEmpJobInfos;
        }
        #endregion
   
    }
}
