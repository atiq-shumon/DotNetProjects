using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.DUtility;

namespace AH.HR.DAL
{
    public class EmployeeSpecializationSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region SaveDoctor
        public short SaveDocSetup(Doctor tdoc)
        {
            packagename = "PKG_HRM.INSERT_HRM_DOC";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DoctorID",OracleDbType.Varchar2,30,tdoc.ID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,4,tdoc.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,3,tdoc.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorName",OracleDbType.Varchar2,70,tdoc.Name,ParameterDirection.Input),
                new OracleParameter("DoctorNameBeng",OracleDbType.Varchar2,70,tdoc.NameBeng,ParameterDirection.Input),
                new OracleParameter("Degree1",OracleDbType.Varchar2,200,tdoc.Degree1,ParameterDirection.Input),
                new OracleParameter("Degree2",OracleDbType.Varchar2,200,tdoc.Degree2,ParameterDirection.Input),
                new OracleParameter("Degree3",OracleDbType.Varchar2,200,tdoc.Degree3,ParameterDirection.Input),
                new OracleParameter("Degree4",OracleDbType.Varchar2,200,tdoc.Degree4,ParameterDirection.Input),
                new OracleParameter("Designation",OracleDbType.Varchar2,10,tdoc.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("RoomNo",OracleDbType.Varchar2,5,tdoc.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("DoctorType",OracleDbType.Char,1,tdoc.Doctype,ParameterDirection.Input),
                new OracleParameter("AvailableDays",OracleDbType.Varchar2,100,tdoc.AvailableDays,ParameterDirection.Input),
                new OracleParameter("AvailableDaysBeng",OracleDbType.Varchar2,100,tdoc.AvailableDaysBeng,ParameterDirection.Input),
                new OracleParameter("Signature",OracleDbType.Varchar2,50,tdoc.Signature,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tdoc.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tdoc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tdoc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tdoc.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region updateDoctor
        public short UpdateDocSetup(Doctor udoc)
        {
            packagename = "PKG_HRM.UPDATE_HRM_DOC";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,4,udoc.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,3,udoc.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorID",OracleDbType.Varchar2,5,udoc.ID,ParameterDirection.Input),
                new OracleParameter("DoctorName",OracleDbType.Varchar2,70,udoc.Name,ParameterDirection.Input),
                new OracleParameter("DoctorNameBeng",OracleDbType.Varchar2,70,udoc.NameBeng,ParameterDirection.Input),
                new OracleParameter("Degree1",OracleDbType.Varchar2,200,udoc.Degree1,ParameterDirection.Input),
                new OracleParameter("Degree2",OracleDbType.Varchar2,200,udoc.Degree2,ParameterDirection.Input),
                new OracleParameter("Degree3",OracleDbType.Varchar2,200,udoc.Degree3,ParameterDirection.Input),
                new OracleParameter("Degree4",OracleDbType.Varchar2,200,udoc.Degree4,ParameterDirection.Input),
                new OracleParameter("Designation",OracleDbType.Varchar2,10,udoc.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("RoomNo",OracleDbType.Varchar2,5,udoc.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("DoctorType",OracleDbType.Char,1,udoc.Doctype,ParameterDirection.Input),
                new OracleParameter("AvailableDays",OracleDbType.Varchar2,100,udoc.AvailableDays,ParameterDirection.Input),
                new OracleParameter("AvailableDaysBeng",OracleDbType.Varchar2,100,udoc.AvailableDaysBeng,ParameterDirection.Input),
                new OracleParameter("Signature",OracleDbType.Varchar2,50,udoc.Signature,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,udoc.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,udoc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,udoc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,udoc.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region GetDoctor
        public List<Doctor> GetDoctors()
        {
            string packagename = "PKG_HRM.GET_HRM_DOC";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDocSetup(packagename, parameterList);
        }
        public List<Doctor> GetDoctorByDept(string deptid)
        {
            string packagename = "PKG_HRM.GET_HRM_DOC";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),

            };
            return GetDocSetup(packagename, parameterList);
        }
        public List<Doctor> GetDoctorSetup(string deptid, string unitid)
        {
            string packagename = "PKG_HRM.GET_HRM_DOC";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,3,unitid,ParameterDirection.Input)
            };
            return GetDocSetup(packagename, parameterList);
        }
        private List<Doctor> GetDocSetup(string packagename, OracleParameter[] parameterList)
        {
            List<Doctor> tdocs = new List<Doctor>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                Doctor docs = new Doctor();
                docs.ID = (string)rdr[4].ToString();
                docs.Name = (string)rdr[5];
                docs.NameBeng = (string)rdr[6];
                docs.Doctype = (string)rdr[15];
                docs.Degree1 = (string)rdr[9];
                docs.Degree2 = !rdr.IsDBNull(10) ? (string)rdr[10] : "";
                docs.Degree3 = !rdr.IsDBNull(11) ? (string)rdr[11] : "";
                docs.Degree4 = !rdr.IsDBNull(12) ? (string)rdr[12] : "";
                // docs.AvailableDays = !rdr.IsDBNull(16) ? (string)rdr[16] : "";
                // docs.AvailableDaysBeng = !rdr.IsDBNull(17) ? (string)rdr[17] : "";
                //docs.Signature = (string)rdr[18];

                Department dpt = new Department();
                dpt.DepartmentTitle = !rdr.IsDBNull(1) ? (string)rdr["DEPT_ID"] : "";
                docs.Department = dpt;

                DepartmentUnit dunit = new DepartmentUnit();
                dunit.UnitTitle = (string)rdr[3];
                docs.DepartmentUnit = dunit;

                Designation dsig = new Designation();
                dsig.DesignationTitle = (string)rdr[8];
                docs.Designation = dsig;

                Room trm = new Room();
                trm.RoomNo = short.Parse(rdr[13].ToString());
                docs.Room = trm;
                docs.NameBeng = (string)rdr[4];
                // docs.AvailableDays = (string)rdr[7];
                tdocs.Add(docs);
            }
            rdr.Close();
            return tdocs;

        }
        #endregion

        #region SaveNurse

        public short SaveNurse(Nurse nrs)
        {
            string packagename = "PKG_HRM.INSERT_NURSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,4,nrs.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,3,nrs.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("NurseID",OracleDbType.Varchar2,30,nrs.ID,ParameterDirection.Input),
                new OracleParameter("NurseName",OracleDbType.Varchar2,70,nrs.Name,ParameterDirection.Input),
                new OracleParameter("NurseNameBeng",OracleDbType.Varchar2,70,nrs.NameBeng,ParameterDirection.Input),
                new OracleParameter("Degree1",OracleDbType.Varchar2,200,nrs.Degree1,ParameterDirection.Input),
                new OracleParameter("Designation",OracleDbType.Varchar2,10,nrs.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("RoomNo",OracleDbType.Varchar2,5,nrs.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("NurseType",OracleDbType.Char,1,nrs.NurseType,ParameterDirection.Input),
                new OracleParameter("Signature",OracleDbType.Varchar2,50,nrs.Signature,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nrs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Company",OracleDbType.Varchar2,2,nrs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Location",OracleDbType.Varchar2,4,nrs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,nrs.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetNurse

        public List<Nurse> GetNurse()
        {
            string packagename = "PKG_HRM.GET_NURSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetNurseList(packagename, parameterList);
        }
        private List<Nurse> GetNurseList(string packagename, OracleParameter[] parameterList)
        {
            List<Nurse> nurs = new List<Nurse>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                Nurse nrs = new Nurse();
                nrs.ID = (string)rdr[2];
                nrs.Name = (string)rdr[3];
                nrs.NameBeng = (string)rdr[4];
                nrs.Degree1 = (string)rdr[5];
                nrs.NurseType = (string)rdr[9];
                nrs.Signature = (string)rdr[10];

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr[0];
                //dpt.DepartmentTitle = (string)rdr[11];
                dpt.DepartmentTitle = !rdr.IsDBNull(11) ? (string)rdr[11] : "";
                nrs.Department = dpt;

                DepartmentUnit dunit = new DepartmentUnit();
                dunit.UnitId = (string)rdr[1];
                dunit.UnitTitle = (string)rdr[12];
                nrs.DepartmentUnit = dunit;

                Designation dsig = new Designation();
                dsig.DesignationId = (string)rdr[6];
                // dsig.DesignationTitle = (string)rdr[13];
                dsig.DesignationTitle = !rdr.IsDBNull(13) ? (string)rdr[13] : "";
                nrs.Designation = dsig;

                Room rm = new Room();
                rm.RoomID = (string)rdr[7];
                nrs.Room = rm;

                nurs.Add(nrs);
            }
            rdr.Close();
            return nurs;
        }

        #endregion

        #region EditNurse

        public short ModifyNurse(Nurse nrs)
        {
            string packagename = "PKG_HRM.UPDATE_NURSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,4,nrs.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,3,nrs.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("NurseName",OracleDbType.Varchar2,70,nrs.Name,ParameterDirection.Input),
                new OracleParameter("NurseNameBeng",OracleDbType.Varchar2,70,nrs.NameBeng,ParameterDirection.Input),
                new OracleParameter("Degree1",OracleDbType.Varchar2,200,nrs.Degree1,ParameterDirection.Input),
                new OracleParameter("Designation",OracleDbType.Varchar2,10,nrs.Designation.DesignationId,ParameterDirection.Input),
                new OracleParameter("RoomNo",OracleDbType.Varchar2,5,nrs.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("NurseType",OracleDbType.Char,1,nrs.NurseType,ParameterDirection.Input),
                new OracleParameter("Signature",OracleDbType.Varchar2,50,nrs.Signature,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nrs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Company",OracleDbType.Varchar2,2,nrs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Location",OracleDbType.Varchar2,4,nrs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,nrs.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }


        #endregion

        #region GetEmployeeMasterDeptWise

        public List<EmployeeMasterRO> GetEmployee(string Dept, string Unit)
        {
            string packageName = "Pkg_HRM_Reports.Get_dept_wise_employees";
            OracleParameter[] parameterList = new OracleParameter[] { 
                        new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                        new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                        new OracleParameter("p_unit",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
                   };

            return GetEmpMas(packageName, parameterList);
        }

        public List<EmployeeMasterRO> GetEmployees(string Desig, string Dept, string Unit)
        {
            string packageName = "Pkg_HRM_Reports.Get_dept_wise_employees";
            OracleParameter[] parameterList = new OracleParameter[] { 
                        new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                        new OracleParameter("p_desig_group",OracleDbType.Varchar2,30,Desig,ParameterDirection.Input),
                        new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                        new OracleParameter("p_unit",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input)
                   };

            return GetEmpMas(packageName, parameterList);
        }

        private List<EmployeeMasterRO> GetEmpMas(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMasterRO> oLvdays = new List<EmployeeMasterRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMasterRO oEmp = new EmployeeMasterRO();
                oEmp.EmpId = rdr["EMP_ID"] != DBNull.Value ? (string)rdr["EMP_ID"].ToString() : "";
                oEmp.EmpName = rdr["Name"] != DBNull.Value ? (string)rdr["Name"].ToString() : "";
                oEmp.EmpNameBeng = rdr["EMP_NAME_BENG"] != DBNull.Value ? (string)rdr["EMP_NAME_BENG"].ToString() : "";
                oEmp.FatName = rdr["fat_name"] != DBNull.Value ? (string)(rdr["fat_name"]).ToString() : "";
                oEmp.FatNameBeng = rdr["FAT_NAME_BENG"] != DBNull.Value ? (string)rdr["FAT_NAME_BENG"].ToString() : "";
                oEmp.MotName = rdr["mot_name"] != DBNull.Value ? (string)rdr["mot_name"].ToString() : "";
                oEmp.MotNameBeng = rdr["MOT_NAME_BENG"] != DBNull.Value ? (string)rdr["MOT_NAME_BENG"].ToString() : "";
                oEmp.SpouseName = rdr["SPOUSE_NAME"] != DBNull.Value ? (string)rdr["SPOUSE_NAME"].ToString() : "";
                oEmp.SpouseNameBeng = rdr["SPOUSE_NAME_BENG"] != DBNull.Value ? (string)rdr["SPOUSE_NAME_BENG"].ToString() : "";
                oEmp.Religion = (string)rdr["religion"].ToString();
                oEmp.Sex = (string)rdr["sex"].ToString();
                oEmp.BloodGroup = (string)rdr["blood_grp"].ToString();
                oEmp.MaritialStatus = (string)rdr["maritial_status"].ToString();
                oEmp.Nationality = (string)rdr["nationality"].ToString();
                oEmp.DeptId = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"].ToString() : "";
                oEmp.DeptGrp = rdr["Dept_grp_name"] != DBNull.Value ? (string)rdr["Dept_grp_name"].ToString() : "";
                oEmp.DesigId = rdr["DSIG_TITLE"] != DBNull.Value ? (string)rdr["DSIG_TITLE"].ToString() : "";
                oEmp.DesigGrp = rdr["Desig_grp_name"] != DBNull.Value ? (string)rdr["Desig_grp_name"].ToString() : "";
                oEmp.UnitId = rdr["UNIT_TITLE"] != DBNull.Value ? (string)rdr["UNIT_TITLE"].ToString() : "";
                oEmp.Email = rdr["email_id"] != DBNull.Value ? (string)rdr["email_id"].ToString() : "";
                oEmp.CellPhone = rdr["cell_phone"] != DBNull.Value ? (string)rdr["cell_phone"].ToString() : "";
                oEmp.ScaleId = rdr["scale_title"] != DBNull.Value ? (string)rdr["scale_title"].ToString() : "";
                oEmp.GradeId = rdr["grade_title"] != DBNull.Value ? (string)rdr["grade_title"].ToString() : "";
                oEmp.Country = rdr["country"] != DBNull.Value ? (string)rdr["country"].ToString() : "";
                oEmp.Photo = rdr["PHOTO_PATH"] != DBNull.Value ? (string)rdr["PHOTO_PATH"].ToString() : "";
                oEmp.Signature = rdr["SIGNATURE_PATH"] != DBNull.Value ? (string)rdr["SIGNATURE_PATH"].ToString() : "";
                oEmp.CompanyId = rdr["COMPANY_ID"] != DBNull.Value ? (string)rdr["COMPANY_ID"].ToString() : "";
                oEmp.JobType = rdr["JOB_TYPE_ID"] != DBNull.Value ? (string)rdr["JOB_TYPE_ID"].ToString() : "";
                oEmp.EmpClass = rdr["EMP_CLASS"] != DBNull.Value ? (string)rdr["EMP_CLASS"].ToString() : "";
                oEmp.DOB = Convert.ToDateTime(rdr["DOB"].ToString());
                oEmp.DOJ =Convert.ToDateTime(rdr["DOJ"].ToString());
                oEmp.DOC = rdr["DOC"].ToString();
                oEmp.DOR = rdr["DOR"].ToString();
                //if (rdr["DOC"] == DBNull.Value)
                //{
                //    oEmp.DOC = null;
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
                oEmp.CurJobSts = rdr["CUR_JOB_STATUS"] != DBNull.Value ? (string)rdr["CUR_JOB_STATUS"].ToString() : "";
                oEmp.ConfirmFlag = rdr["CONFIRM_FLAG"] != DBNull.Value ? (string)rdr["CONFIRM_FLAG"].ToString() : "";
                oEmp.PfMember = rdr["PF_MEMBER"] != DBNull.Value ? (string)rdr["PF_MEMBER"].ToString() : "";
                oEmp.GratuityMember = rdr["GRATUATITY_MEMBER"] != DBNull.Value ? (string)rdr["GRATUATITY_MEMBER"].ToString() : "";
                oEmp.BnkAccNo = rdr["BNK_AC_NO"] != DBNull.Value ? (string)rdr["BNK_AC_NO"].ToString() : "";
                oEmp.PfAccNo = rdr["PF_AC_NO"] != DBNull.Value ? (string)rdr["PF_AC_NO"].ToString() : "";
                oEmp.Tin = rdr["TIN"] != DBNull.Value ? (string)rdr["TIN"].ToString() : "";
                oEmp.PassPort = rdr["PASSPORT_NO"] != DBNull.Value ? (string)rdr["PASSPORT_NO"].ToString() : "";
                oEmp.InsuranceNo = rdr["INSURANCE_NO"] != DBNull.Value ? (string)rdr["INSURANCE_NO"].ToString() : "";
                oEmp.NationalId = rdr["NATIONAL_ID"] != DBNull.Value ? (string)rdr["NATIONAL_ID"].ToString() : "";
                oEmp.HoViRd = rdr["HO_VI_AR_RD"] != DBNull.Value ? (string)rdr["HO_VI_AR_RD"].ToString() : "";
                oEmp.HoViRdBeng = rdr["HO_VI_AR_RD_BENG"] != DBNull.Value ? (string)rdr["HO_VI_AR_RD_BENG"].ToString() : "";
                oEmp.PostCode = rdr["POST_CODE"] != DBNull.Value ? (string)rdr["POST_CODE"].ToString() : "";
                oEmp.ThanaCode = rdr["THANA_CODE"] != DBNull.Value ? (string)rdr["THANA_CODE"].ToString() : "";
                oEmp.DistCode = rdr["DISTRICT_CODE"] != DBNull.Value ? (string)rdr["DISTRICT_CODE"].ToString() : "";
                oEmp.Country = rdr["COUNTRY"] != DBNull.Value ? (string)rdr["COUNTRY"].ToString() : "";
                oEmp.PerHoViRd = rdr["PER_HO_VI_AR_RD"] != DBNull.Value ? (string)rdr["PER_HO_VI_AR_RD"].ToString() : "";
                oEmp.PerPostCOde = rdr["PER_POST_CODE"] != DBNull.Value ? (string)rdr["PER_POST_CODE"].ToString() : "";
                oEmp.PerThanaCode = rdr["PER_THANA_CODE"] != DBNull.Value ? (string)rdr["PER_THANA_CODE"].ToString() : "";
                oEmp.PerDistCode = rdr["PER_DISTRICT_CODE"] != DBNull.Value ? (string)rdr["PER_DISTRICT_CODE"].ToString() : "";
                oEmp.SalFlag = rdr["SAL_FLAG"] != DBNull.Value ? (string)rdr["SAL_FLAG"].ToString() : "";
                oEmp.SalFlagChangeDate = rdr["SAL_FLAG_CHNG_DT"] != DBNull.Value ? (string)rdr["SAL_FLAG_CHNG_DT"].ToString() : "";
                oEmp.ConsolidateFlag = rdr["CONSOLIDATE_SCAL_FLAG"] != DBNull.Value ? (string)rdr["CONSOLIDATE_SCAL_FLAG"].ToString() : "";
                oEmp.ConsolidateAmt = double.Parse(rdr["CONSOLIDATED_AMT"].ToString());
                oEmp.EmpRef1 = rdr["EMP_REFF1"] != DBNull.Value ? (string)rdr["EMP_REFF1"].ToString() : "";
                oEmp.EmpRef2 = rdr["EMP_REFF2"] != DBNull.Value ? (string)rdr["EMP_REFF2"].ToString() : "";
                oLvdays.Add(oEmp);
            }
            rdr.Close();
            return oLvdays;
        }
        #endregion
    }
}
