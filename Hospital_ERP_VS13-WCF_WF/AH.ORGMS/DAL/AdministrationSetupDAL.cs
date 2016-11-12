using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.ORGMS.MODEL;


namespace AH.ORGMS.DAL
{
    public class AdministrationSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region GetDepartment
        public List<Department> GetDepartments()
        {
            string packageName = "PKG_HRM.GET_DEPT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDept(packageName, parameterList);

        }
        public List<Department> GetDepartmentsetup(string deptgr)
        {
            string packageName = "PKG_HRM.GET_DEPT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DeptGroup",OracleDbType.Varchar2,4,deptgr,ParameterDirection.Input)
            };
            return GetDept(packageName, parameterList);

        }

        public List<DeptUnitAss> GetDeptSetup(string deptgr)
        {
            string packageName = "PKG_HRM.GET_DEPT_BY_GROUP_WISE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DeptGroup",OracleDbType.Varchar2,4,deptgr,ParameterDirection.Input)
            };
            return GetDeptDetails(packageName, parameterList);

        }
       
        private List<Department> GetDept(string packageName, OracleParameter[] parameterList)
        {
            List<Department> depts = new List<Department>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                Department deptobj = new Department();
                deptobj.DepartmentID = (string)rdr["DEPT_ID"].ToString();
                deptobj.DepartmentTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                deptobj.DepartmentTitleBeng = rdr["DEPT_TITLE_BENG"] != DBNull.Value ? (string)rdr["DEPT_TITLE_BENG"] : "";
                deptobj.Serial=Convert.ToInt32(rdr["SERIAL"]);              

                deptobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                depts.Add(deptobj);

            }
            rdr.Close();
            return depts;

        }
        private List<DeptUnitAss> GetDeptDetails(string packageName, OracleParameter[] parameterList)
        {
            List<DeptUnitAss> depts = new List<DeptUnitAss>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                DeptUnitAss oDeptUnit = new DeptUnitAss();
                Department oDept = new Department();
                oDept.DepartmentID = (string)rdr["DEPT_ID"].ToString();
                oDept.DepartmentTitle = rdr["DEPT_TITLE"] != DBNull.Value ? (string)rdr["DEPT_TITLE"] : "";
                oDeptUnit.Department = oDept;
                DepartmentGroup oDeptGroup = new DepartmentGroup();
                oDeptGroup.DepartmentGroupID = rdr["GROUP_ID"].ToString();
                oDeptUnit.DepartmentGroup = oDeptGroup;
               
                depts.Add(oDeptUnit);

            }
            rdr.Close();
            return depts;

        }       
        #endregion

        #region SaveDepartment
        public short SaveDept(Department tDept)
        {
            packagename = "PKG_HRM.INSERT_DEPT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_title",OracleDbType.Varchar2,70,tDept.DepartmentTitle,ParameterDirection.Input),
                new OracleParameter("p_dept_title_beng",OracleDbType.Varchar2,70,tDept.DepartmentTitleBeng,ParameterDirection.Input),               
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,tDept.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,tDept.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,tDept.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,tDept.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,tDept.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDepartment
        public short UpdateDept(Department tDept)
        {
            packagename = "PKG_HRM.UPDATE_DEPT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,70,tDept.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_dept_title",OracleDbType.Varchar2,70,tDept.DepartmentTitle,ParameterDirection.Input),
                new OracleParameter("p_dept_title_beng",OracleDbType.Varchar2,70,tDept.DepartmentTitleBeng,ParameterDirection.Input),                 
                new OracleParameter("p_serial",OracleDbType.Int32,10,tDept.Serial,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,tDept.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,tDept.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,tDept.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,tDept.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,tDept.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region VerifyDepartment
        public int VerifyDeptSetup(string vdept)
        {
            packagename = "PKG_HRM.VERIFY_DEPTID";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,vdept,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

        #region GetDepartmentGroup
        public List<DepartmentGroup> GetDeptGroup()
        {
            string packageName = "PKG_HRM.GET_DEPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetDepartmentGroup(packageName, parameterList);
        }
        public List<DepartmentGroup> GetDeptGroupsByType(string dptType)
        {
            string packageName = "PKG_HRM.GET_DEPT_GRP_BY_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,dptType,ParameterDirection.Input)
           };

            return GetDepartmentGroup(packageName, parameterList);
        }
        private List<DepartmentGroup> GetDepartmentGroup(string packageName, OracleParameter[] parameterList)
        {
            List<DepartmentGroup> deptGrps = new List<DepartmentGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DepartmentGroup deptObj = new DepartmentGroup();
                deptObj.DepartmentGroupID = (String)rdr["GROUP_ID"].ToString();
                deptObj.DepartmentGroupTitle = (String)rdr["GROUP_TITLE"].ToString();
                deptObj.DepartmentGroupTitleBeng = (string)rdr["GROUP_TITLE_BENG"].ToString();
                deptObj.DepartmentTypeID = rdr["TYPE_ID"].ToString();
                deptObj.Remarks = rdr["REMARKS"] != DBNull.Value ? (String)rdr["REMARKS"] : "";
                deptObj.Serial = Convert.ToInt16(rdr["SERIAL"]);
                deptGrps.Add(deptObj);
            }
            rdr.Close();
            return deptGrps;
        }
        #endregion

        #region VerifyDepartmentGroup
        public int VerifyDeptGr(string groupid)
        {
            packagename = "PKG_HRM.VERIFY_DEPTGR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("GroupId",OracleDbType.Varchar2,2,groupid,ParameterDirection.Input)
             };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

        #region SaveDepartmentGroup
        public short SaveDeptGroup(DepartmentGroup tDeptGr)
        {
            packagename = "PKG_HRM.INSERT_DEPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                //new OracleParameter("DepartmentGroupId",OracleDbType.Varchar2,70,tDeptGr.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("DepartmentGroupTitle",OracleDbType.Varchar2,70,tDeptGr.DepartmentGroupTitle,ParameterDirection.Input),
                new OracleParameter("DepartmentGroupTitleBeng",OracleDbType.Varchar2,70,tDeptGr.DepartmentGroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,2,tDeptGr.DepartmentTypeID,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tDeptGr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tDeptGr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tDeptGr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tDeptGr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tDeptGr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region UpdateDepartmentGroup
        public short UpdateDeptGroup(DepartmentGroup tDptGr)
        {
            packagename = "PKG_HRM.UPDATE_DEPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DeptGroupID",OracleDbType.Varchar2,2,tDptGr.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("DeptGroupName",OracleDbType.Varchar2,70,tDptGr.DepartmentGroupTitle,ParameterDirection.Input),
                new OracleParameter("DeptGroupNameBeng",OracleDbType.Varchar2,70,tDptGr.DepartmentGroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,2,tDptGr.DepartmentTypeID,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tDptGr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tDptGr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tDptGr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tDptGr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tDptGr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetDesignation
        public List<Designation> GetDesignation()
        {
            string packagename = "PKG_HRM.GET_DSIG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("reff",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDesig(packagename, parameterList);

        }
        public List<Designation> GetDesignationGrpWise(string dsigr)
        {
            string packagename = "PKG_HRM.GET_DSIG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("reff",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DesignationGroup",OracleDbType.Varchar2,2,dsigr,ParameterDirection.Input)
            };
            return GetDesig(packagename, parameterList);

        }

        public List<Designation> GetDesignationParentWise(string dsigParent)
        {
            string packagename = "PKG_HRM.GET_DSIG_SETUP_BY_PARENT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("reff",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dsig_parent",OracleDbType.Varchar2,4,dsigParent,ParameterDirection.Input)
            };
            return GetDesig(packagename, parameterList);
        }
        public List<Designation> GetDesignationTypeWise(string DsigType)
        {
            string packagename = "PKG_HRM.GET_DSIG_SETUP_BY_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("reff",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dsig_type",OracleDbType.Varchar2,4,DsigType,ParameterDirection.Input)
            };
            return GetDesig(packagename, parameterList);
        }

        private List<Designation> GetDesig(string packagename, OracleParameter[] parameterList)
        {
            List<Designation> dsig = new List<Designation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                Designation dsigobj = new Designation();
                dsigobj.DesignationId = (string)rdr["DSIG_ID"].ToString();
                dsigobj.DesignationTitle = (string)rdr["DSIG_TITLE"].ToString();
                dsigobj.DesignationTitleBeng = (string)rdr["dsig_title_beng"].ToString();

                DesignationType oDesigType = new DesignationType();
                oDesigType.TypeID = (string)rdr["desig_type_id"].ToString();
                dsigobj.DesignationType = oDesigType;

                DesignationGroup dgrp = new DesignationGroup();
                dgrp.GroupId = (string)rdr["dsig_group"].ToString();
                dsigobj.DesignationGroup = dgrp;

                dsigobj.DesignationLevel = rdr["DSIG_LEVEL"] != DBNull.Value ? (String)rdr["DSIG_LEVEL"].ToString() : "";
                dsigobj.DesignationParentId = rdr["Parent"] != DBNull.Value ? rdr["Parent"].ToString() : "";
                dsigobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"].ToString() : "";
                dsig.Add(dsigobj);

            }
            rdr.Close();
            return dsig;

        }
        #endregion
 
        #region VerifyDesignation
        public int VerifyDsig(string dsigid)
        {
            packagename = "PKG_HRM.VERIFY_DSIG";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DesigId",OracleDbType.Varchar2,4,dsigid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

        #region SaveDesignation
        public short SaveDesignation(Designation dsig)
        {
            packagename = "PKG_HRM.INSERT_DSIG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DesignationTitle",OracleDbType.Varchar2,70,dsig.DesignationTitle,ParameterDirection.Input),
                new OracleParameter("DesignationTitleBeng",OracleDbType.Varchar2,70,dsig.DesignationTitleBeng,ParameterDirection.Input),
                new OracleParameter("DesignationGroup",OracleDbType.Varchar2,70,dsig.DesignationGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("p_dsig_parent",OracleDbType.Varchar2,4,dsig.DesignationParentId,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,dsig.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dsig.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,20,dsig.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,20,dsig.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dsig.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDesignation
        public short UpdateDsig(Designation udsig)
        {
            packagename = "PKG_HRM.UPDATE_DSIG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DesignationID",OracleDbType.Varchar2,4,udsig.DesignationId,ParameterDirection.Input),
                new OracleParameter("DesignationName",OracleDbType.Varchar2,70,udsig.DesignationTitle,ParameterDirection.Input),
                new OracleParameter("DesignationNameBeng",OracleDbType.Varchar2,70,udsig.DesignationTitleBeng,ParameterDirection.Input),
                new OracleParameter("DesignationGroup",OracleDbType.Varchar2,70,udsig.DesignationGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("Designationlevel",OracleDbType.Varchar2,6,udsig.DesignationLevel,ParameterDirection.Input),
                new OracleParameter("p_dsig_parent",OracleDbType.Varchar2,4,udsig.DesignationParentId,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,udsig.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,udsig.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,udsig.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,udsig.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,udsig.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetDesignationGroup
        public List<DesignationGroup> GetDesignGrp()
        {
            string packagename = "PKG_HRM.GET_DSIG_GR";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDsignGrp(packagename, parameterList);
        }
        public List<DesignationGroup> GetDesignGrpType(string Type)
        {
            string packagename = "PKG_HRM.GET_DSIG_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,4,Type,ParameterDirection.Input)
            };
            return GetDsignGrp(packagename, parameterList);
        }
        private List<DesignationGroup> GetDsignGrp(string packagename, OracleParameter[] parameterList)
        {
            List<DesignationGroup> dsigngr = new List<DesignationGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                DesignationGroup dsigngrobj = new DesignationGroup();
                dsigngrobj.GroupId = (string)rdr["group_id"].ToString();
                dsigngrobj.GroupTitle = (string)rdr["group_title"];
                dsigngrobj.GroupTitleBeng = rdr["group_title_beng"] != DBNull.Value ? (string)rdr["group_title_beng"] : "";
                dsigngrobj.Remarks = rdr["remarks"] != DBNull.Value ? (string)rdr["remarks"] : "";
                DesignationType oDesigType = new DesignationType();
                oDesigType.TypeID = (string)rdr["group_type"].ToString();
                dsigngrobj.DesignationType = oDesigType;
                dsigngr.Add(dsigngrobj);
            }
            rdr.Close();
            return dsigngr;
        }
        #endregion

        #region VerifyDesignationGroup
        public int VerifyDesigGr(string groupid)
        {
            packagename = "PKG_HRM.VERIFY_DSIG_GR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("GroupId",OracleDbType.Varchar2,2,groupid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

        #region SaveDesignationGroup
        public short SaveDesignationGr(DesignationGroup dsigGr)
        {
            packagename = "PKG_HRM.INSERT_DSIG_GR";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,70,dsigGr.DesignationType.TypeID,ParameterDirection.Input),
                new OracleParameter("GroupTitle",OracleDbType.Varchar2,70,dsigGr.GroupTitle,ParameterDirection.Input),
                new OracleParameter("GroupTitleBeng",OracleDbType.Varchar2,70,dsigGr.GroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,dsigGr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dsigGr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dsigGr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dsigGr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dsigGr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDesignationGroup
        public short UpdateDsigGr(DesignationGroup dsigGr)
        {
            packagename = "PKG_HRM.UPDATE_DSIG_GR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,2,dsigGr.GroupId,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2,70,dsigGr.DesignationType.TypeID,ParameterDirection.Input),
                new OracleParameter("GroupName",OracleDbType.Varchar2,70,dsigGr.GroupTitle,ParameterDirection.Input),
                new OracleParameter("GroupNameBeng",OracleDbType.Varchar2,70,dsigGr.GroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,dsigGr.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,dsigGr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dsigGr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dsigGr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dsigGr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion
        
        #region GetDepartmentUnit
        public List<DepartmentUnit> GetUnit(string Dept)
        {
            string packagename = "PKG_HRM.GET_UNIT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,4,Dept,ParameterDirection.Input)
            };
            return GetUnitSetup(packagename, parameterList);
        }
        private List<DepartmentUnit> GetUnitSetup(string packagename, OracleParameter[] parameterList)
        {
            List<DepartmentUnit> dunit = new List<DepartmentUnit>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                DepartmentUnit unitobj = new DepartmentUnit();
                unitobj.UnitId = (string)rdr["UNIT_ID"].ToString();
                unitobj.UnitTitle = (string)rdr["unit_title"].ToString();              
                dunit.Add(unitobj);
            }
            rdr.Close();
            return dunit;
        }
        #endregion

        #region GetUnit
        public List<DepartmentUnit> GetUnits()
        {
            string packagename = "PKG_HRM.GET_UNIT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetUnitDetails(packagename, parameterList);
        }
        private List<DepartmentUnit> GetUnitDetails(string packagename, OracleParameter[] parameterList)
        {
            List<DepartmentUnit> dunit = new List<DepartmentUnit>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                DepartmentUnit unitobj = new DepartmentUnit();
                unitobj.UnitId = (string)rdr["UNIT_ID"].ToString();
                unitobj.UnitTitle = (string)rdr["unit_title"].ToString();
                unitobj.UnitTitleBeng = (string)rdr["unit_title_beng"].ToString();
                unitobj.Serial = Convert.ToInt32(rdr["serial"].ToString());
                unitobj.Remarks = (string)rdr["remarks"].ToString();
                dunit.Add(unitobj);
            }
            rdr.Close();
            return dunit;
        }
        #endregion

        #region VerifyDepartmentUnit
        public int VerifyUnit(string unitid)
        {
            packagename = "PKG_HRM.VERIFY_UNIT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("UnitID",OracleDbType.Varchar2,2,unitid,ParameterDirection.Input) 
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

        #region SaveDepartmentUnit
        public short SaveUnit(DepartmentUnit tunit)
        {
            packagename = "PKG_HRM.INSERT_UNIT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("UnitTitle",OracleDbType.Varchar2,50,tunit.UnitTitle,ParameterDirection.Input),
                new OracleParameter("UnitTitleBeng",OracleDbType.Varchar2,50,tunit.UnitTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tunit.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tunit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tunit.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tunit.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tunit.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDepartmentUnit
        public short UpdateUnit(DepartmentUnit dunit)
        {
            packagename = "PKG_HRM.UPDATE_UNIT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("UnitID",OracleDbType.Varchar2,2,dunit.UnitId,ParameterDirection.Input),
                new OracleParameter("UnitTitle",OracleDbType.Varchar2,50,dunit.UnitTitle,ParameterDirection.Input),
                new OracleParameter("UnitTitleBeng",OracleDbType.Varchar2,50,dunit.UnitTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,dunit.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dunit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dunit.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dunit.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dunit.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VerifyDoctorID
        public int VerifyDocId(string docid)
        {
            packagename = "PKG_HRM.VERIFY_DOCID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DoctorID",OracleDbType.Varchar2,5,docid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

        #region SaveDeptUnitAssign
        public short SaveDeptUnitAss(DeptUnitAss dasign)
        {
            packagename = "PKG_HRM.INSERT_DEPTUNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,5,dasign.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,dasign.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_string",OracleDbType.Varchar2,20000,dasign.UnitAssignString,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,dasign.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,dasign.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,dasign.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,dasign.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region EditDeptUnitAssign
        public short EditDeptUnitAss(DeptUnitAss dasign)
        {
            packagename = "PKG_HRM.UPDATE_DEPTUNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,5,dasign.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("UnitID1",OracleDbType.Varchar2,2,dasign.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("UnitID2",OracleDbType.Varchar2,2,dasign.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dasign.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dasign.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dasign.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dasign.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetDeptUnitAssign
        public List<DeptUnitAss> GetDeptUnitAssign()
        {
            string packagename = "PKG_HRM.GET_DEPTUNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDunitAssign(packagename, parameterList);
        }
        public List<DeptUnitAss> GetDeptUnitAssigned(string DeptGrp,string deptid)
        {
            string packagename = "PKG_HRM.GET_DEPTUNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DepartmentGroup",OracleDbType.Varchar2,5,DeptGrp,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,deptid,ParameterDirection.Input)
            };
            return GetDunitDet(packagename, parameterList);
        }
        public List<DeptUnitAss> GetUnitList(string deptid)
        {
            string packagename = "PKG_HRM.GET_DEPT_UNIT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,5,deptid,ParameterDirection.Input)
            };
            return GetDunitDet(packagename, parameterList);
        }
        public List<DeptUnitAss> GetGroupDeptUnit(string DeptGroup)
        {
            string packagename = "PKG_HRM.GET_DEPT_UNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,5,DeptGroup,ParameterDirection.Input)
            };
            return GetDunitAssign(packagename, parameterList);
        }
        public List<DeptUnitAss> GetAssignedUnit(string DeptGroup,string Department)
        {
            string packagename = "PKG_HRM.GET_DEPT_UNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,5,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,Department,ParameterDirection.Input)
            };
            return GetDunitAssign(packagename, parameterList);
        }
        private List<DeptUnitAss> GetDunitAssign(string packagename, OracleParameter[] parameterList)
        {
            List<DeptUnitAss> hdas = new List<DeptUnitAss>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                DeptUnitAss hds = new DeptUnitAss();
                Department dept = new Department();
                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["group_id"].ToString();
                oDeptGrp.DepartmentGroupTitle = rdr["group_title"].ToString();
                hds.DepartmentGroup = oDeptGrp;
                dept.DepartmentID = (string)rdr["dept_id"].ToString();
                dept.DepartmentTitle = (string)rdr["dept_title"].ToString();
                hds.Department = dept;
                DepartmentUnit dunit = new DepartmentUnit();
                dunit.UnitId = (string)rdr["unit_id"];
                dunit.UnitTitle = (string)rdr["unit_title"];
                hds.DepartmentUnit = dunit;

                hdas.Add(hds);
            }
            rdr.Close();
            return hdas;
        }
        private List<DeptUnitAss> GetDunitDet(string packagename, OracleParameter[] parameterList)
        {
            List<DeptUnitAss> hdas = new List<DeptUnitAss>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                DeptUnitAss hds = new DeptUnitAss();               
                DepartmentUnit dunit = new DepartmentUnit();
                dunit.UnitId = (string)rdr["unit_id"];
                dunit.UnitTitle = (string)rdr["unit_title"];
                hds.DepartmentUnit = dunit;

                hdas.Add(hds);
            }
            rdr.Close();
            return hdas;
        }
        #endregion

        #region VerifyDeptUnitAssign
        public string verifyDeptUnitAssign(string dept, string unit)
        {
            string packageName = "PKG_HRM.VERIFY_DEPTUNIT_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Found",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,5,dept,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,3,unit,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;
        }
        #endregion

        #region GetGroupUnderCategory

        public List<DepartmentGroup> GetGroupUnderCategory(string oGrp)
        {
            string packageName = "PKG_HRM.GET_GROUP_UNDER_CATEGORY";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_category_id",OracleDbType.Varchar2,30,oGrp,ParameterDirection.Input),              
           };

            return GetGrpUnderCat(packageName, parameterList);
        }
        private List<DepartmentGroup> GetGrpUnderCat(string packageName, OracleParameter[] parameterList)
        {
            List<DepartmentGroup> oGrps = new List<DepartmentGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    DepartmentGroup oGrp = new DepartmentGroup();
                    oGrp.DepartmentGroupTitle = !rdr.IsDBNull(0) ? (string)rdr["GROUP_TITLE"] : "";
                    oGrp.DepartmentGroupID = !rdr.IsDBNull(0) ? (string)rdr["GROUP_ID"] : "";

                    oGrps.Add(oGrp);

                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region GetDeptUnderGroup

        public List<Department> GetDeptUnderGroup(string oGrp)
        {
            string packageName = "PKG_HRM.GET_DEPT_UNDER_GROUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,30,oGrp,ParameterDirection.Input),              
           };

            return GetDeptUnderGrp(packageName, parameterList);
        }
        private List<Department> GetDeptUnderGrp(string packageName, OracleParameter[] parameterList)
        {
            List<Department> oGrps = new List<Department>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    Department oDept = new Department();
                    oDept.DepartmentTitle= !rdr.IsDBNull(0) ? (string)rdr["DEPT_TITLE"] : "";
                    oDept.DepartmentID = !rdr.IsDBNull(0) ? (string)rdr["DEPT_ID"] : "";

                    oGrps.Add(oDept);

                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region GetDesigUnderGroup

        public List<Designation> GetDesigUnderGroup(string oGrp)
        {
            string packageName = "PKG_HRM.GET_DESIG_UNDER_GROUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,30,oGrp,ParameterDirection.Input),              
           };

            return GetDesigUnderGrp(packageName, parameterList);
        }
        private List<Designation> GetDesigUnderGrp(string packageName, OracleParameter[] parameterList)
        {
            List<Designation> oGrps = new List<Designation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    Designation oDesig = new Designation();
                    oDesig.DesignationTitle = !rdr.IsDBNull(0) ? (string)rdr["DSIG_TITLE"] : "";
                    oDesig.DesignationId = !rdr.IsDBNull(0) ? (string)rdr["DSIG_ID"] : "";

                    oGrps.Add(oDesig);

                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion      

        #region GetDistrict
        public List<DistrictThana> GetDistrict()
        {
            string packageName = "PKG_HRM.GET_DISTRICT";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),           
           };

            return GetDistrictSetup(packageName, parameterList);
        }
        private List<DistrictThana> GetDistrictSetup(string packageName, OracleParameter[] parameterList)
        {
            List<DistrictThana> oGrps = new List<DistrictThana>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    DistrictThana oDesig = new DistrictThana();
                    oDesig.DistName = (string)rdr["dist_name"].ToString();
                    oGrps.Add(oDesig);

                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion      

        #region SaveThana
        public short SaveThana(DistrictThana oDistrictThana)
        {
            packagename = "PKG_HRM.INSERT_THANA";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_district",OracleDbType.Varchar2,250,oDistrictThana.DistName,ParameterDirection.Input),
                new OracleParameter("p_thana",OracleDbType.Varchar2,250,oDistrictThana.ThanaName,ParameterDirection.Input)              
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateThana
        public short UpdateThana(DistrictThana oDistrictThana)
        {
            packagename = "PKG_HRM.UPDATE_THANA";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_district",OracleDbType.Varchar2,250,oDistrictThana.DistName,ParameterDirection.Input),
                new OracleParameter("p_thana",OracleDbType.Varchar2,250,oDistrictThana.ThanaName,ParameterDirection.Input) ,
                new OracleParameter("p_thana_old",OracleDbType.Varchar2,250,oDistrictThana.OldThanaName,ParameterDirection.Input)  
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetThana
        public List<DistrictThana> GetThana(string District)
        {
            string packageName = "PKG_HRM.GET_THANA";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_dist",OracleDbType.Varchar2,250,District,ParameterDirection.Input)  
               
           };

            return GetThanaSetup(packageName, parameterList);
        }
        private List<DistrictThana> GetThanaSetup(string packageName, OracleParameter[] parameterList)
        {
            List<DistrictThana> oGrps = new List<DistrictThana>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    DistrictThana oDesig = new DistrictThana();
                    oDesig.DistName = (string)rdr["DIST_NAME"].ToString();
                    oDesig.ThanaName = (string)rdr["THANA_NAME"].ToString();
                    oGrps.Add(oDesig);
                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion    

        #region GetDistrictAndThana
        public List<DistrictThana> GetDistrictAndThana()
        {
            string packageName = "PKG_HRM.GET_DISTRICT_AND_THANA";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
               
           };

            return GetDistrictAndThanaSetup(packageName, parameterList);
        }
        private List<DistrictThana> GetDistrictAndThanaSetup(string packageName, OracleParameter[] parameterList)
        {
            List<DistrictThana> oGrps = new List<DistrictThana>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    DistrictThana oDesig = new DistrictThana();
                    oDesig.DistName = (string)rdr["dist_name"].ToString();
                    oDesig.ThanaName = (string)rdr["thana_name"].ToString();                    
                    oGrps.Add(oDesig);

                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion    

        #region SavePostOffice
        public short SavePostOffice(DistrictThana oDistrictThana)
        {
            packagename = "PKG_HRM.INSERT_POST_OFFICE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_district",OracleDbType.Varchar2,250,oDistrictThana.DistName,ParameterDirection.Input),
                new OracleParameter("p_thana",OracleDbType.Varchar2,250,oDistrictThana.ThanaName,ParameterDirection.Input),
                new OracleParameter("p_post_code",OracleDbType.Varchar2,250,oDistrictThana.PostCode,ParameterDirection.Input) ,
                new OracleParameter("p_post_office",OracleDbType.Varchar2,250,oDistrictThana.PostOfficeName,ParameterDirection.Input) 
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdatePostOffice
        public short UpdatePostOffice(DistrictThana oDistrictThana)
        {
            packagename = "PKG_HRM.UPDATE_POST_OFFICE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_district",OracleDbType.Varchar2,250,oDistrictThana.DistName,ParameterDirection.Input),
                new OracleParameter("p_thana",OracleDbType.Varchar2,250,oDistrictThana.ThanaName,ParameterDirection.Input),
                new OracleParameter("p_post_code",OracleDbType.Varchar2,250,oDistrictThana.PostCode,ParameterDirection.Input) ,
                new OracleParameter("p_post_office",OracleDbType.Varchar2,250,oDistrictThana.PostOfficeName,ParameterDirection.Input),
                new OracleParameter("p_post_code_old",OracleDbType.Varchar2,250,oDistrictThana.OldPostCode,ParameterDirection.Input) ,
                new OracleParameter("p_post_office_old",OracleDbType.Varchar2,250,oDistrictThana.OldPostOfficeName,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetPostOffice
        public List<DistrictThana> GetPostOffice(string District, string Thana)
        {
            string packageName = "PKG_HRM.GET_POST_OFFICE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),   
                new OracleParameter("p_dept_group",OracleDbType.Varchar2,100,District,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,100,Thana,ParameterDirection.Input)
           };

            return GetPostOfficeDetails(packageName, parameterList);
        }
        private List<DistrictThana> GetPostOfficeDetails(string packageName, OracleParameter[] parameterList)
        {
            List<DistrictThana> oGrps = new List<DistrictThana>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    DistrictThana oDesig = new DistrictThana();
                    oDesig.DistName = rdr["DIST_NAME"].ToString();
                    oDesig.ThanaName = rdr["THANA_NAME"].ToString();
                    oDesig.PostOfficeName = (string)rdr["POST_OFFICE_NAME"].ToString();
                    oDesig.PostCode = (string)rdr["POST_CODE"].ToString();
                    oGrps.Add(oDesig);

                }
                rdr.Close();
                return oGrps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion    

        #region SaveBankSetup
        public short SaveBankSetup(BankInfo oBank)
        {
            packagename = "PKG_BANK_SETUP.INSERT_BANK_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_bank_id",OracleDbType.Varchar2,3,oBank.BankID,ParameterDirection.Input),
                new OracleParameter("p_bank_title",OracleDbType.Varchar2,70,oBank.BankTitle,ParameterDirection.Input),
                new OracleParameter("p_bank_title_beng",OracleDbType.Varchar2,70,oBank.BankTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,2,oBank.Serial,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oBank.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oBank.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oBank.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oBank.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oBank.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oBank.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateBankSetup
        public short UpdateBankSetup(BankInfo oBank)
        {
            packagename = "PKG_BANK_SETUP.UPDATE_BANK_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_bank_id",OracleDbType.Varchar2,3,oBank.BankID,ParameterDirection.Input),
                new OracleParameter("p_bank_title",OracleDbType.Varchar2,70,oBank.BankTitle,ParameterDirection.Input),
                new OracleParameter("p_bank_title_beng",OracleDbType.Varchar2,70,oBank.BankTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_serial",OracleDbType.Varchar2,2,oBank.Serial,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oBank.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oBank.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oBank.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oBank.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oBank.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oBank.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetBankSetup
        public List<BankInfo> GetBankSetup()
        {
            string packagename = "PKG_BANK_SETUP.GET_BANK_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetBankSetupDetails(packagename, parameterList);
        }
        private List<BankInfo> GetBankSetupDetails(string packagename, OracleParameter[] parameterList)
        {
            List<BankInfo>oBanks = new List<BankInfo>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                BankInfo oBank = new BankInfo();
                oBank.BankID = (string)rdr["BANK_ID"].ToString();
                oBank.BankTitle = (string)rdr["BANK_TITLE"];
                oBank.BankTitleBeng = !rdr.IsDBNull(2) ? (string)rdr["BANK_TITLE_BENG"] : "";
                oBank.Serial = (string)rdr["SERIAL"].ToString();
                oBank.Remarks = !rdr.IsDBNull(4) ? (string)rdr["REMARKS"] : "";
                oBanks.Add(oBank);
            }
            rdr.Close();
            return oBanks;
        }
        #endregion

        #region SaveOrganogram
        public short SaveOrganogram(Organogram oOrganogram)
        {
            packagename = "PKG_HRM.INSERT_ORGANOGRAM_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_type",OracleDbType.Varchar2,5,oOrganogram.Department.DepartmentType.TypeID,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,oOrganogram.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oOrganogram.Department.DepartmentID,ParameterDirection.Input), 
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,oOrganogram.DepartmentUnit.UnitId,ParameterDirection.Input), 
                new OracleParameter("p_dept_string",OracleDbType.Varchar2,20000,oOrganogram.DeptDesigString,ParameterDirection.Input),               
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oOrganogram.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oOrganogram.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oOrganogram.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oOrganogram.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oOrganogram.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetOrganogramSetup
        public List<Organogram> GetOrganogramSetup(string DepartmentGroup,string Department,string Unit)
        {
            string packagename = "PKG_HRM.GET_ORGANOGRAM_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,5,DepartmentGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,Department,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,5,Unit,ParameterDirection.Input)
            };
            return GetOrganogramDetails(packagename, parameterList);
        }
        private List<Organogram> GetOrganogramDetails(string packagename, OracleParameter[] parameterList)
        {
            List<Organogram> oOrganograms = new List<Organogram>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                Organogram oOrganogram = new Organogram();
                Department oDept = new Department();
                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["DEPT_GRP_ID"].ToString();
                oDept.DepartmentGroup = oDeptGrp;              
                oDept.DepartmentID = rdr["DEPT_ID"].ToString();
                oOrganogram.Department = oDept;
                DepartmentUnit oUnit = new DepartmentUnit();
                oUnit.UnitId = rdr["UNIT_ID"].ToString();
                oOrganogram.DepartmentUnit = oUnit;
                Designation oDesig = new Designation();
                oDesig.DesignationId = rdr["DESIG_ID"].ToString();
                oDesig.DesignationTitle = rdr["DSIG_TITLE"].ToString();
                oDesig.DesignationLevel = rdr["DEPT_DSIG_LEVEL"].ToString();
                oOrganogram.Designation = oDesig;
                oOrganogram.NoOfPost = Convert.ToInt16(rdr["NO_OF_POST"].ToString());

                oOrganograms.Add(oOrganogram);
            }
            rdr.Close();
            return oOrganograms;
        }
        #endregion

        #region SaveFoodSubsidySetup
        public short SaveFoodSubsidySetup(FoodSubsidy oFoodSubsidy)
        {
            packagename = "PKG_HRM.INSERT_FOOD_SUBSIDY_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Varchar2,70,oFoodSubsidy.Serial,ParameterDirection.Input),
                new OracleParameter("p_level",OracleDbType.Varchar2,70,oFoodSubsidy.JobLevel,ParameterDirection.Input),               
                new OracleParameter("p_percent",OracleDbType.Varchar2,300,oFoodSubsidy.Percent,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oFoodSubsidy.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oFoodSubsidy.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oFoodSubsidy.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oFoodSubsidy.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oFoodSubsidy.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateFoodSubsidySetup
        public string UpdateFoodSubsidySetup(FoodSubsidy oFoodSubsidy)
        {
            packagename = "PKG_HRM.UPDATE_FOOD_SUBSIDY_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_err_msg",OracleDbType.Varchar2,200,null,ParameterDirection.Output),
                new OracleParameter("p_serial",OracleDbType.Varchar2,70,oFoodSubsidy.Serial,ParameterDirection.Input),
                new OracleParameter("p_level",OracleDbType.Varchar2,70,oFoodSubsidy.JobLevel,ParameterDirection.Input),               
                new OracleParameter("p_percent",OracleDbType.Varchar2,300,oFoodSubsidy.Percent,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oFoodSubsidy.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oFoodSubsidy.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oFoodSubsidy.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oFoodSubsidy.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oFoodSubsidy.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
        #endregion

        #region GetFoodSubsidySetup
        public List<FoodSubsidy> GetFoodSubsidySetup()
        {
            string packagename = "PKG_HRM.GET_FOOD_SUBSIDY_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetFoodSubsidySetupDetails(packagename, parameterList);
        }
        private List<FoodSubsidy> GetFoodSubsidySetupDetails(string packagename, OracleParameter[] parameterList)
        {
            List<FoodSubsidy> oFoodSubsidys = new List<FoodSubsidy>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                FoodSubsidy oFoodSubsidy = new FoodSubsidy();
                oFoodSubsidy.JobLevel = (string)rdr["JOB_LEVEL"].ToString();
                oFoodSubsidy.Percent = (string)rdr["PERCENT"].ToString();
                oFoodSubsidy.Serial = (string)rdr["SERIAL"].ToString();
                oFoodSubsidys.Add(oFoodSubsidy);
            }
            rdr.Close();
            return oFoodSubsidys;
        }
        #endregion

        #region GetFoodSubsidy
        public FoodSubsidy GetFoodSubsidy(string EmpID)
        {
            string packagename = "PKG_HRM.GET_FOOD_SUBSIDY";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_emp_subsidy",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input)
            };
            return GetSubsidySetup(packagename, parameterList);
        }
        private FoodSubsidy GetSubsidySetup(string packagename, OracleParameter[] parameterList)
        {
            FoodSubsidy oFoodSubsidy = new FoodSubsidy();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);          
            oFoodSubsidy.Percent = (string)(OracleString)parameterList[0].Value.ToString();          
            return oFoodSubsidy;
        }
        #endregion
        
  }
}
