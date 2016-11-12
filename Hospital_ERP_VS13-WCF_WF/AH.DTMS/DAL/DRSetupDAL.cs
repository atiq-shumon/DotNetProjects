using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DTMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.DUtility;
using AH.Shared.MODEL;

namespace AH.DTMS.DAL
{
    public class DRSetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.DRSMIS);
        private string packageName;

        #region GetSpecimen        
        public List<Specimen> GetSpec()
        {
            string packageName = "PKG_DRS_SETUP.GET_SPC_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetSpecSetup(packageName, parameterList);
        }
        private List<Specimen> GetSpecSetup(string packageName, OracleParameter[] parameterList)
        {
            List<Specimen> specsetup = new List<Specimen>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Specimen specobj = new Specimen();
                specobj.SpecimenID = (string)rdr[0];
                specobj.SpecimenTitle = (string)rdr[1];
                specobj.SpecimenTitleBeng = (string)rdr[2];
                specobj.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                specsetup.Add(specobj);
            }
            rdr.Close();
            return specsetup;

        }
        #endregion

        #region VerifySpecimen
        public int VerifySpecSetup(string spcid)
        {
            packageName = "PKG_DRS_SETUP.VERIFY_SPCID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("SpecimenID",OracleDbType.Varchar2,6,spcid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveSpecimen
        public short SaveSpecsetup(Specimen spec)
        {
            packageName = "PKG_DRS_SETUP.INSERT_SPC_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("SpecimenTitle",OracleDbType.Varchar2,200,spec.SpecimenTitle,ParameterDirection.Input),
            new OracleParameter("SpecimenTitleBeng",OracleDbType.Varchar2,200,spec.SpecimenTitleBeng,ParameterDirection.Input),
            new OracleParameter("Remarks",OracleDbType.Varchar2,300,spec.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,spec.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,spec.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,spec.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,spec.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateSpecimen
        public short UpdateSpecimen(Specimen uspc)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_SPC_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("SpecimenID",OracleDbType.Varchar2,6,uspc.SpecimenID,ParameterDirection.Input),
                new OracleParameter("SpecimenName",OracleDbType.Varchar2,200,uspc.SpecimenTitle,ParameterDirection.Input),
                new OracleParameter("SpecimenNameBeng",OracleDbType.Varchar2,200,uspc.SpecimenTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,uspc.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,uspc.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,uspc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,uspc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,uspc.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetReportGroup
        public List<ReportGroup> GetRptgrp()
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetReportGrp(packageName, parameterList);
        }
        public List<ReportGroup> GetRptgrpSetup(string dept)
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,10,dept,ParameterDirection.Input)
            };
            return GetReportGrp(packageName, parameterList);
        }
        public List<ReportGroup> GetRptgrpBySec(string sec)
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_GRP_BY_SECTION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,10,sec,ParameterDirection.Input)
            };
            return GetReportGrp(packageName, parameterList);
        }

        public List<ReportGroup> GetRptgrpDet(string dept,string sec)
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_GRP_BY_SECTION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,10,dept,ParameterDirection.Input),
                new OracleParameter("sec",OracleDbType.Varchar2,10,sec,ParameterDirection.Input)
            };
            return GetReportGrp(packageName, parameterList);
        }
        private List<ReportGroup> GetReportGrp(string packageName, OracleParameter[] parameterList)
        {
            List<ReportGroup> rptgrp = new List<ReportGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ReportGroup rptobj = new ReportGroup();
                rptobj.ReportGroupID = (string)rdr["grp_id"].ToString();
                rptobj.ReportGroupTitle = (string)rdr["grp_title"];
                rptobj.ReportGroupTitleBeng = (string)rdr["grp_title_beng"];
                rptobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["remarks"] : "";

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr["dept_id"];
                rptobj.Department = dpt;

                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = (string)rdr["sec_id"];
                rptobj.ReportSection = oRptSec;

                rptgrp.Add(rptobj);
            }
            rdr.Close();
            return rptgrp;

        }
        #endregion

        #region VerifyReportGroup
        public int VerifyReportGroup(string groupid)
        {
            packageName = "PKG_DRS_SETUP.VERIFY_RPTGRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,4,groupid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveReportGroup
        public short SaveReportGr(ReportGroup repgr)
        {
            packageName = "PKG_DRS_SETUP.INSERT_RPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("DeptID",OracleDbType.Varchar2,5,repgr.Department.DepartmentID,ParameterDirection.Input),
            new OracleParameter("p_sec_id",OracleDbType.Varchar2,5,repgr.ReportSection.ReportSectionID,ParameterDirection.Input),
            new OracleParameter("ReportGroupTitle",OracleDbType.Varchar2,70,repgr.ReportGroupTitle,ParameterDirection.Input),
            new OracleParameter("ReportGroupTitleBeng",OracleDbType.Varchar2,70,repgr.ReportGroupTitleBeng,ParameterDirection.Input),
            new OracleParameter("Remarks",OracleDbType.Varchar2,300,repgr.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,repgr.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,repgr.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,repgr.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,repgr.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateReportGroup
        public short UpdateReportGr(ReportGroup urepgr)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_RPT_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,4,urepgr.ReportGroupID,ParameterDirection.Input),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,5,urepgr.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,5,urepgr.ReportSection.ReportSectionID,ParameterDirection.Input),
                new OracleParameter("GroupName",OracleDbType.Varchar2,70,urepgr.ReportGroupTitle,ParameterDirection.Input),
                new OracleParameter("GroupNameBeng",OracleDbType.Varchar2,70,urepgr.ReportGroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,urepgr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,urepgr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,urepgr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,urepgr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,urepgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region SaveReportSection
        public short SaveReportSection(ReportSection repgr)
        {
            packageName = "PKG_DRS_SETUP.INSERT_RPT_SECTION";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),            
            new OracleParameter("p_sec_title",OracleDbType.Varchar2,70,repgr.ReportSectionTitle,ParameterDirection.Input),
            new OracleParameter("p_sec_title_beng",OracleDbType.Varchar2,70,repgr.ReportSectionTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,repgr.Department.DepartmentID,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,repgr.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,repgr.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,repgr.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,repgr.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,repgr.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateReportSection
        public short UpdateReportSection(ReportSection repgr)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_RPT_SECTION";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_sec_id",OracleDbType.Varchar2,4,repgr.ReportSectionID,ParameterDirection.Input),
            new OracleParameter("p_sec_title",OracleDbType.Varchar2,70,repgr.ReportSectionTitle,ParameterDirection.Input),
            new OracleParameter("p_sec_title_beng",OracleDbType.Varchar2,70,repgr.ReportSectionTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,repgr.Department.DepartmentID,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,repgr.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,repgr.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,repgr.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,repgr.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,repgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetReportSection
        public List<ReportSection> GetReportSection()
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_SECTION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetReportSectionDetails(packageName, parameterList);
        }
        public List<ReportSection> GetReportSectionSetup(string dept)
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_SECTION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,10,dept,ParameterDirection.Input)
            };
            return GetReportSectionDetails(packageName, parameterList);
        }
        private List<ReportSection> GetReportSectionDetails(string packageName, OracleParameter[] parameterList)
        {
            List<ReportSection> rptgrp = new List<ReportSection>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ReportSection rptobj = new ReportSection();
                rptobj.ReportSectionID = (string)rdr["SEC_ID"].ToString();
                rptobj.ReportSectionTitle = (string)rdr["SEC_TITLE"];
                rptobj.ReportSectionTitleBeng = (string)rdr["SEC_TITLE_BENG"];
                rptobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr["DEPT_ID"];
                rptobj.Department = dpt;

                rptgrp.Add(rptobj);
            }
            rdr.Close();
            return rptgrp;

        }
        #endregion

        #region GetResultHeadGroup
        public List<ResultHeadGroup> GetResHdGrp()
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetResultHdGrp(packageName, parameterList);
        }
        public List<ResultHeadGroup> GetResultHeaddGrp(string Dept,string Sec)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,Dept,ParameterDirection.Input),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,10,Sec,ParameterDirection.Input)
            };
            return GetResultHdGrp(packageName, parameterList);
        }
        private List<ResultHeadGroup> GetResultHdGrp(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHeadGroup> rshdgrp = new List<ResultHeadGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHeadGroup rshdobj = new ResultHeadGroup();
                rshdobj.ResultHeadGroupID = (string)rdr["hd_grp_id"].ToString();
                rshdobj.ResultHeadGroupTitle = (string)rdr["hd_grp_title"].ToString(); ;
                rshdobj.ResultHeadGroupTitleBeng = (string)rdr["hd_grp_title_beng"].ToString(); ;
                rshdobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["remarks"] : "";
                rshdobj.IsVisible = rdr["is_visible"].ToString();
                Department oDept = new Department();
                oDept.DepartmentID = (string)rdr["dept_id"].ToString(); ;
                rshdobj.Department = oDept;
                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = (string)rdr["sec_id"].ToString();
                rshdobj.ReportSection = oRptSec;
                rshdgrp.Add(rshdobj);
            }
            rdr.Close();
            return rshdgrp;
        }
        #endregion

        #region VerifyResultHeadGroup
        public int VerifyResHdGrp(string hdgrpid)
        {
            packageName = "PKG_DRS_SETUP.VERIFY_RESHDGRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("HeadGroupID",OracleDbType.Varchar2,4,hdgrpid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveResultHeadGroup
        public short SaveReshdGr(ResultHeadGroup reshdgr)
        {
            packageName = "PKG_DRS_SETUP.INSERT_RES_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,reshdgr.Department.DepartmentID,ParameterDirection.Input),
            new OracleParameter("p_sec_id",OracleDbType.Varchar2,5,reshdgr.ReportSection.ReportSectionID,ParameterDirection.Input),
            new OracleParameter("ResultHeadGroupTitle",OracleDbType.Varchar2,70,reshdgr.ResultHeadGroupTitle,ParameterDirection.Input),
            new OracleParameter("ResultHeadGroupTitleBeng",OracleDbType.Varchar2,70,reshdgr.ResultHeadGroupTitleBeng,ParameterDirection.Input),
            new OracleParameter("Remarks",OracleDbType.Varchar2,300,reshdgr.Remarks,ParameterDirection.Input),
            new OracleParameter("Is_visible",OracleDbType.Varchar2,1,reshdgr.IsVisible,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,reshdgr.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,reshdgr.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,reshdgr.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,reshdgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateResultHeadGroup
        public short UpdateReshdGr(ResultHeadGroup ureshdgr)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_RES_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,ureshdgr.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,5,ureshdgr.ReportSection.ReportSectionID,ParameterDirection.Input),
                new OracleParameter("HeadGroupID",OracleDbType.Varchar2,4,ureshdgr.ResultHeadGroupID,ParameterDirection.Input),
                new OracleParameter("HeadGroupName",OracleDbType.Varchar2,70,ureshdgr.ResultHeadGroupTitle,ParameterDirection.Input),
                new OracleParameter("HeadGroupNameBeng",OracleDbType.Varchar2,70,ureshdgr.ResultHeadGroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,ureshdgr.Remarks,ParameterDirection.Input),
                new OracleParameter("Is_visible",OracleDbType.Varchar2,1,ureshdgr.IsVisible,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ureshdgr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ureshdgr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ureshdgr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ureshdgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetResultHeadUnit
        public List<ResultHeadUnit> GetResUnit()
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_UNIT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetRsHdUnit(packageName, parameterList);
        }
        private List<ResultHeadUnit> GetRsHdUnit(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHeadUnit> rsunit = new List<ResultHeadUnit>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHeadUnit rsunitobj = new ResultHeadUnit();
                rsunitobj.UnitID = (string)rdr[0].ToString();
                rsunitobj.UnitTitle = (string)rdr[1];
                rsunitobj.UnitTitleBeng = (string)rdr[2];
                rsunitobj.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                rsunit.Add(rsunitobj);
            }
            rdr.Close();
            return rsunit;
        }
        #endregion

        #region VerifyResultHeadUnit
        public int VerifyResUnit(string runit)
        {
            packageName = "PKG_DRS_SETUP.VERIFY_RESUNIT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("UnitID",OracleDbType.Varchar2,3,runit,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveResultHeadUnit
        public short SaveRshdUnit(ResultHeadUnit rsunit)
        {
            packageName = "PKG_DRS_SETUP.INSERT_RES_UNIT";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("UnitTitle",OracleDbType.Varchar2,70,rsunit.UnitTitle,ParameterDirection.Input),
            new OracleParameter("UnitTitleBeng",OracleDbType.Varchar2,70,rsunit.UnitTitleBeng,ParameterDirection.Input),
            new OracleParameter("Remarks",OracleDbType.Varchar2,300,rsunit.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,rsunit.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,rsunit.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,rsunit.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,rsunit.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateResultHeadUnit
        public short UpdateResUnit(ResultHeadUnit ursunit)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_RES_UNIT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Unit ID",OracleDbType.Varchar2,4,ursunit.UnitID,ParameterDirection.Input),
                new OracleParameter("Unit Name",OracleDbType.Varchar2,70,ursunit.UnitTitle,ParameterDirection.Input),
                new OracleParameter("UnitNameBeng",OracleDbType.Varchar2,70,ursunit.UnitTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,ursunit.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ursunit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ursunit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ursunit.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ursunit.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetResultHead
        public List<ResultHead> GetResultHds(string reportGroup)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("group",OracleDbType.Varchar2,5,reportGroup,ParameterDirection.Input)
               
            };
            return GetResHead(packageName, parameterList);
        }

        
        public List<ResultHead> GetResultHd()
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
               
            };
            return GetResHeadSetup(packageName, parameterList);
        }
        public List<ResultHeadRO> GetResultHdFReport(string Section,string Group)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_FOR_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,10,Section,ParameterDirection.Input),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,10,Group,ParameterDirection.Input)
               
            };
            return GetResHeadDetailsReport(packageName, parameterList);
        }
        public List<ResultHead> GetResultHd(string reportGroup)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("group",OracleDbType.Varchar2,reportGroup,ParameterDirection.Input)
               
            };
            return GetResHead(packageName, parameterList);
        }
        public List<ResultHead> GetResultHdBySecGrp(string sec,string grp)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_BY_SEC_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,sec,ParameterDirection.Input),
                new OracleParameter("p_grp_id",OracleDbType.Varchar2,grp,ParameterDirection.Input)
               
            };
            return GetResHeadSetup(packageName, parameterList);
        }
        public List<ResultHeadRO> GetResultHeadReport(string sec, string grp)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_WITHOUT_REFF";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,sec,ParameterDirection.Input),
                new OracleParameter("p_grp_id",OracleDbType.Varchar2,grp,ParameterDirection.Input)
               
            };
            return GetResultHeadReportDetails(packageName, parameterList);
        }
        private List<ResultHeadRO> GetResultHeadReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHeadRO> reshd = new List<ResultHeadRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHeadRO reshdobj = new ResultHeadRO();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();

                reshdobj.ReportGroupID = (string)rdr["GRP_ID"].ToString();
                reshdobj.ReportGroupTitle = (string)rdr["GroupName"].ToString();
               
                reshdobj.UnitID = (string)rdr["HD_UNIT_ID"].ToString();
                reshdobj.UnitTitle = (string)rdr["UnitName"].ToString();

                reshdobj.ReportSectionID = (string)rdr["SEC_ID"].ToString();
                reshdobj.ReportSectionTitle = (string)rdr["SectionName"].ToString();              

                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        private List<ResultHeadRO> GetResHeadDetailsReport(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHeadRO> reshd = new List<ResultHeadRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHeadRO reshdobj = new ResultHeadRO();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();

                reshdobj.ReportGroupID = (string)rdr["GRP_ID"].ToString();
                reshdobj.ReportGroupTitle = (string)rdr["GroupName"].ToString();

                //reshdobj.ResultHeadGroupID = (string)rdr["HD_GRP_ID"].ToString();
                //reshdobj.ResultHeadGroupTitle = (string)rdr["HeadGroupName"].ToString();

                reshdobj.UnitID = (string)rdr["HD_UNIT_ID"].ToString();
                reshdobj.UnitTitle = (string)rdr["UnitName"].ToString();

                reshdobj.ReportSectionID = (string)rdr["SEC_ID"].ToString();
                reshdobj.ReportSectionTitle = (string)rdr["SectionName"].ToString();

                reshdobj.MachineID = (string)rdr["MACHINE_ID"].ToString();
                reshdobj.MachineTitle = (string)rdr["MacName"].ToString();

                reshdobj.LowerRange = (string)rdr["l_range"].ToString();
                reshdobj.UpperRange = (string)rdr["u_range"].ToString();
                reshdobj.LowerRangeMale = (string)rdr["l_range_m"].ToString();
                reshdobj.UpperRangeMale = (string)rdr["u_range_m"].ToString();
                reshdobj.LowerRangeFeMale = (string)rdr["l_range_f"].ToString();
                reshdobj.UpperRangeFeMale = (string)rdr["u_range_f"].ToString();
                reshdobj.LowerRangeChild = (string)rdr["l_range_c"].ToString();
                reshdobj.UpperRangeChild = (string)rdr["u_range_c"].ToString();
                reshdobj.RangeText = (string)rdr["reff_val_text"].ToString();

                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        private List<ResultHead> GetResHead(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();
                reshdobj.ResultHeadTitleBeng = (string)rdr["RES_HD_TITLE_BENG"].ToString();
                reshdobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"].ToString() : "";
                reshdobj.Serial = (decimal)rdr["SERIAL"];
                reshdobj.GenderSentitive =(string)rdr["IS_GENDER_SENSITIVE"].ToString();
                reshdobj.QualitiveFlag =(string)rdr["IS_QUALITATIVE"].ToString();
                reshdobj.QualitiveGroup = (string)rdr["QUALITATIVE_GRP_ID"].ToString();
                reshdobj.IsLisSyn =(string)rdr["IS_LIS_SYNC"].ToString();         
                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = (string)rdr["GRP_ID"].ToString();
                reshdobj.ReportGroup = rpt;

                //ResultHeadGroup hdrst = new ResultHeadGroup();
                //hdrst.ResultHeadGroupID = (string)rdr["HD_GRP_ID"].ToString();
                //reshdobj.ResultGroup = hdrst;

                ResultHeadUnit runit = new ResultHeadUnit();
                runit.UnitID = (string)rdr["HD_UNIT_ID"].ToString();
                reshdobj.ResultHeadUnit = runit;

                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = (string)rdr["SEC_ID"].ToString();
                reshdobj.ReportSection = oRptSec;

                Machine oMac = new Machine();
                oMac.MachineID = (string)rdr["MAC_ID"].ToString();
                oMac.MachineTitle = (string)rdr["MacName"].ToString();
                reshdobj.Machine = oMac;
                reshdobj.LowerRange = (string)rdr["l_range"].ToString();
                reshdobj.UpperRange = (string)rdr["u_range"].ToString();
                reshdobj.LowerRangeMale = (string)rdr["l_range_m"].ToString();
                reshdobj.UpperRangeMale = (string)rdr["u_range_m"].ToString();
                reshdobj.LowerRangeFeMale = (string)rdr["l_range_f"].ToString();
                reshdobj.UpperRangeFeMale = (string)rdr["u_range_f"].ToString();
                reshdobj.LowerRangeChild = (string)rdr["l_range_c"].ToString();
                reshdobj.UpperRangeChild = (string)rdr["u_range_c"].ToString();
                reshdobj.RangeText= (string)rdr["reff_val_text"].ToString();

                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        private List<ResultHead> GetResHeadSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();
                reshdobj.ResultHeadTitleBeng = (string)rdr["RES_HD_TITLE_BENG"].ToString();
                reshdobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"].ToString() : "";
                reshdobj.Serial = (decimal)rdr["SERIAL"];
                reshdobj.GenderSentitive = (string)rdr["IS_GENDER_SENSITIVE"].ToString();
                reshdobj.QualitiveFlag = (string)rdr["IS_QUALITATIVE"].ToString();
                reshdobj.QualitiveGroup = (string)rdr["QUALITATIVE_GRP_ID"].ToString();
                reshdobj.IsLisSyn = (string)rdr["IS_LIS_SYNC"].ToString();
                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = (string)rdr["GRP_ID"].ToString();
                reshdobj.ReportGroup = rpt;

                //ResultHeadGroup hdrst = new ResultHeadGroup();
                //hdrst.ResultHeadGroupID = (string)rdr["HD_GRP_ID"].ToString();
                //hdrst.ResultHeadGroupTitle = (string)rdr["HeadGroupName"].ToString();
                //reshdobj.ResultGroup = hdrst;

                ResultHeadUnit runit = new ResultHeadUnit();
                runit.UnitID = (string)rdr["HD_UNIT_ID"].ToString();
                reshdobj.ResultHeadUnit = runit;

                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = (string)rdr["SEC_ID"].ToString();
                reshdobj.ReportSection = oRptSec;

                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        #endregion

        #region GetResultHeadReff
        public List<ResultHead> GetResultHdReff()
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_REFF";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
               
            };
            return GetResHeadReff(packageName, parameterList);
        }      
        private List<ResultHead> GetResHeadReff(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();               
                reshdobj.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"].ToString() : "";
                reshdobj.Serial = (decimal)rdr["SERIAL"];
                Machine oMac = new Machine();
                oMac.MachineID = rdr["MACHINE_ID"] != DBNull.Value ? (string)rdr["MACHINE_ID"].ToString() : "";
                oMac.MachineTitle = rdr["MACHINE_TITLE"] != DBNull.Value ? (string)rdr["MACHINE_TITLE"].ToString() : "";
                reshdobj.Machine = oMac;
                reshdobj.LowerRange = rdr["L_RANGE"] != DBNull.Value ? (string)rdr["L_RANGE"].ToString() : "";
                reshdobj.UpperRange = rdr["U_RANGE"] != DBNull.Value ? (string)rdr["U_RANGE"].ToString() : "";
                reshdobj.LowerRangeMale = rdr["L_RANGE_M"] != DBNull.Value ? (string)rdr["L_RANGE_M"].ToString() : "";
                reshdobj.UpperRangeMale = rdr["U_RANGE_M"] != DBNull.Value ? (string)rdr["U_RANGE_M"].ToString() : "";
                reshdobj.LowerRangeFeMale = rdr["L_RANGE_F"] != DBNull.Value ? (string)rdr["L_RANGE_F"].ToString() : "";
                reshdobj.UpperRangeFeMale = rdr["U_RANGE_F"] != DBNull.Value ? (string)rdr["U_RANGE_F"].ToString() : "";
                reshdobj.LowerRangeChild = rdr["L_RANGE_C"] != DBNull.Value ? (string)rdr["L_RANGE_C"].ToString() : "";
                reshdobj.UpperRangeChild = rdr["U_RANGE_C"] != DBNull.Value ? (string)rdr["U_RANGE_C"].ToString() : "";
                reshdobj.RangeText = rdr["REFF_VAL_TEXT"] != DBNull.Value ? (string)rdr["REFF_VAL_TEXT"].ToString() : "";
                reshdobj.DefaultValue = rdr["DEFAULT_VALUE"] != DBNull.Value ? (string)rdr["DEFAULT_VALUE"].ToString() : "";
                reshdobj.InterpretationText = rdr["INTERPERTATION_TEXT"] != DBNull.Value ? (string)rdr["INTERPERTATION_TEXT"].ToString() : "";
                reshdobj.InterpretationFlag = rdr["IS_INTERPRETATION"] != DBNull.Value ? (string)rdr["IS_INTERPRETATION"].ToString() : "";
                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = (string)rdr["GRP_ID"].ToString();
                reshdobj.ReportGroup = rpt;
              
                reshd.Add(reshdobj);
            }

            rdr.Close();
            return reshd;
        }
        #endregion

        #region VerifyResultHead
        public int VerifyResHd(string headId)
        {
            packageName = "PKG_DRS_SETUP.VERIFY_RESHD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("HeadId",OracleDbType.Varchar2,5,headId,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveResultHead
        public short SaveReshd(ResultHead reshd)
        {
            packageName = "PKG_DRS_SETUP.INSERT_RES_HD";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_sec_id",OracleDbType.Varchar2,5,reshd.ReportSection.ReportSectionID,ParameterDirection.Input),
            new OracleParameter("GroupID",OracleDbType.Varchar2,4,reshd.ReportGroup.ReportGroupID,ParameterDirection.Input),
            new OracleParameter("UnitID",OracleDbType.Varchar2,3,reshd.ResultHeadUnit.UnitID,ParameterDirection.Input),
            new OracleParameter("ResultHeadTitle",OracleDbType.Varchar2,300,reshd.ResultHeadTitle,ParameterDirection.Input),
            new OracleParameter("ResultHeadTitleBeng",OracleDbType.Varchar2,300,reshd.ResultHeadTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_is_lys_syn",OracleDbType.Varchar2,300,reshd.IsLisSyn,ParameterDirection.Input),
            new OracleParameter("GenderSensitive",OracleDbType.Varchar2,1,reshd.GenderSentitive,ParameterDirection.Input),
            new OracleParameter("QualitiveFlag",OracleDbType.Varchar2,1,reshd.QualitiveFlag,ParameterDirection.Input),
            new OracleParameter("QualitiveGroup",OracleDbType.Varchar2,5,reshd.QualitiveGroup,ParameterDirection.Input),
            new OracleParameter("p_test_subs",OracleDbType.Varchar2,32767,reshd.MachineString,ParameterDirection.Input),
            new OracleParameter("Remarks",OracleDbType.Varchar2,300,reshd.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,reshd.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,reshd.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,reshd.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,reshd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            return 0;
        }
        #endregion

        #region UpdateResultHead
        public short UpdateReshd(ResultHead ureshd)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_RES_HD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ResultHeadID",OracleDbType.Varchar2,5,ureshd.ResultHeadID,ParameterDirection.Input),
                new OracleParameter("p_sec_id",OracleDbType.Varchar2,5,ureshd.ReportSection.ReportSectionID,ParameterDirection.Input),
                new OracleParameter("GroupID",OracleDbType.Varchar2,4,ureshd.ReportGroup.ReportGroupID,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,3,ureshd.ResultHeadUnit.UnitID,ParameterDirection.Input),
                new OracleParameter("ResultHeadTitle",OracleDbType.Varchar2,300,ureshd.ResultHeadTitle,ParameterDirection.Input),
                new OracleParameter("ResultHeadTitleBeng",OracleDbType.Varchar2,300,ureshd.ResultHeadTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_is_lys_syn",OracleDbType.Varchar2,300,ureshd.IsLisSyn,ParameterDirection.Input),
                new OracleParameter("GenderSensitive",OracleDbType.Varchar2,1,ureshd.GenderSentitive,ParameterDirection.Input),
                new OracleParameter("QualitiveFlag",OracleDbType.Varchar2,1,ureshd.QualitiveFlag,ParameterDirection.Input),
                new OracleParameter("QualitiveGroup",OracleDbType.Varchar2,5,ureshd.QualitiveGroup,ParameterDirection.Input),
                new OracleParameter("p_test_subs",OracleDbType.Varchar2,32767,ureshd.MachineString,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,ureshd.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ureshd.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ureshd.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ureshd.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ureshd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VerifySpecimenHolder
        public int VerifySpecHolder(string spchold)
        {
            packageName = "PKG_DRS_SETUP.VERIFY_SPCHOLDID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("HolderID",OracleDbType.Varchar2,4,spchold,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveSpecimenHolder
        public short SaveSpecHolder(SpecimenHolder spchld)
        {
            packageName = "PKG_DRS_SETUP.INSERT_SPC_HOLDER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("HolderName",OracleDbType.Varchar2,70,spchld.HolderTitle,ParameterDirection.Input),
                new OracleParameter("HolderNameBeng",OracleDbType.Varchar2,70,spchld.HolderTitleBeng,ParameterDirection.Input),
                new OracleParameter("ColorCode",OracleDbType.Varchar2,70,spchld.ColorCode.ColorID,ParameterDirection.Input),
                new OracleParameter("p_priority",OracleDbType.Varchar2,70,spchld.Priority,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,spchld.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,spchld.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,spchld.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,spchld.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,spchld.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateSpecimenHolder
        public short UpdateSpcHolder(SpecimenHolder usphl)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_SPC_HOLDER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("HolderID",OracleDbType.Varchar2,3,usphl.HolderID,ParameterDirection.Input),
                new OracleParameter("HolderName",OracleDbType.Varchar2,70,usphl.HolderTitle,ParameterDirection.Input),
                new OracleParameter("HolderNameBeng",OracleDbType.Varchar2,70,usphl.HolderTitleBeng,ParameterDirection.Input),
                new OracleParameter("ColorCode",OracleDbType.Varchar2,70,usphl.ColorCode.ColorID,ParameterDirection.Input),
                new OracleParameter("p_priority",OracleDbType.Varchar2,70,usphl.Priority,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,usphl.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,usphl.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,usphl.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,usphl.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,usphl.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetSpecimenHolder
        public List<SpecimenHolder> GetSpecHolder()
        {
            string packagename = "PKG_DRS_SETUP.GET_SPC_HOLDER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetSpecHld(packagename, parameterList);
        }
        public List<SpecimenHolder> GetSpecimenHolder(string ColorCode)
        {
            string packagename = "PKG_DRS_SETUP.GET_SPECIMEN_HOLDER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_color_code",OracleDbType.Varchar2,10,ColorCode,ParameterDirection.Input)
            };
            return GetSpecHld(packagename, parameterList);
        }
        private List<SpecimenHolder> GetSpecHld(string packagename, OracleParameter[] parameterList)
        {
            List<SpecimenHolder> spchd = new List<SpecimenHolder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                SpecimenHolder spechl = new SpecimenHolder();
                spechl.HolderID = (string)rdr["holder_id"];
                spechl.HolderTitle = (string)rdr["holder_title"];
                spechl.HolderTitleBeng = (string)rdr["holder_title_beng"];
                ColorCode oCol = new ColorCode();
                oCol.ColorID = rdr["color_code"].ToString();
                oCol.ColorTitle = rdr["color_title"].ToString();
                spechl.ColorCode = oCol;
                spechl.Remarks = rdr["remarks"] != DBNull.Value ? (string)rdr["remarks"] : "";
                spechl.Priority = rdr["PRIORITY"].ToString();
                spchd.Add(spechl);
            }
            rdr.Close();
            return spchd;
        }
        #endregion

        #region SaveMachineSetup
        public short SaveMachineSetup(Machine mac)
        {
            packageName = "PKG_DRS_SETUP.INSERT_MACHINE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_machine_id",OracleDbType.Varchar2,3,mac.MachineID,ParameterDirection.Input),
                new OracleParameter("p_machine_Name",OracleDbType.Varchar2,500,mac.MachineTitle,ParameterDirection.Input),
                new OracleParameter("p_machine_Name_beng",OracleDbType.Varchar2,500,mac.MachineTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,mac.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mac.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mac.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,mac.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,mac.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
    #endregion

        #region UpdateMachineSetup
        public short UpdateMachineSetup(Machine mac)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_MACHINE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_machine_id",OracleDbType.Varchar2,3,mac.MachineID,ParameterDirection.Input),
                new OracleParameter("p_machine_Name",OracleDbType.Varchar2,500,mac.MachineTitle,ParameterDirection.Input),
                new OracleParameter("p_machine_Name_beng",OracleDbType.Varchar2,500,mac.MachineTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,mac.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mac.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mac.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,mac.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,mac.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetMachineSetup
        public List<Machine> GetMachineSetup()
        {
            string packagename = "PKG_DRS_SETUP.GET_MACHINE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetMachineSetupDetails(packagename, parameterList);
        }
        private List<Machine> GetMachineSetupDetails(string packagename, OracleParameter[] parameterList)
        {
            List<Machine> macs = new List<Machine>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                Machine mac = new Machine();
                mac.MachineID = (string)rdr["MACHINE_ID"];
                mac.MachineTitle = (string)rdr["MACHINE_TITLE"];
                mac.MachineTitleBeng = (string)rdr["MACHINE_TITLE_BENG"];
                mac.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                macs.Add(mac);
            }
            rdr.Close();
            return macs;
        }
        #endregion

        #region SaveQualitativeGrpSetup
        public short SaveQualitativeGrpSetup(Qualitative oQual)
        {
            packageName = "PKG_DRS_SETUP.INSERT_QUALITATIVE_GRP_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,3,oQual.GroupID,ParameterDirection.Input),
                new OracleParameter("p_group_title",OracleDbType.Varchar2,500,oQual.GroupTitle,ParameterDirection.Input),
                new OracleParameter("p_group_title_beng",OracleDbType.Varchar2,500,oQual.GroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oQual.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oQual.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oQual.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oQual.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oQual.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateQualitativeGrpSetup
        public short UpdateQualitativeGrpSetup(Qualitative oQual)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_QUALITATIVE_GRP_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,3,oQual.GroupID,ParameterDirection.Input),
                new OracleParameter("p_group_title",OracleDbType.Varchar2,500,oQual.GroupTitle,ParameterDirection.Input),
                new OracleParameter("p_group_title_beng",OracleDbType.Varchar2,500,oQual.GroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oQual.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oQual.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oQual.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oQual.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oQual.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetQualitativeGrpSetup
        public List<Qualitative> GetQualitativeGrpSetup()
        {
            string packagename = "PKG_DRS_SETUP.GET_QUALITATIVE_GRP_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetQualitativeGrpSetupDetails(packagename, parameterList);
        }
        private List<Qualitative> GetQualitativeGrpSetupDetails(string packagename, OracleParameter[] parameterList)
        {
            List<Qualitative> macs = new List<Qualitative>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                Qualitative mac = new Qualitative();
                mac.GroupID = (string)rdr["GRP_ID"];
                mac.GroupTitle = (string)rdr["GRP_TITLE"];
                mac.GroupTitleBeng = (string)rdr["GRP_TITLE_BENG"];
                mac.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                macs.Add(mac);
            }
            rdr.Close();
            return macs;
        }
        #endregion

        #region SaveQualitativeGrpDetailsSetup
        public short SaveQualitativeGrpDetailsSetup(QualitativeDetail oQual)
        {
            packageName = "PKG_DRS_SETUP.INSERT_QT_GRP_DETAILS_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,3,oQual.Qualitative.GroupID,ParameterDirection.Input),
                new OracleParameter("p_det_id",OracleDbType.Varchar2,3,oQual.DetID,ParameterDirection.Input),
                new OracleParameter("p_det_title",OracleDbType.Varchar2,500,oQual.DetTitle,ParameterDirection.Input),
                new OracleParameter("p_det_title_beng",OracleDbType.Varchar2,500,oQual.DetTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oQual.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oQual.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oQual.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oQual.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oQual.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateQualitativeGrpDetailsSetup
        public short UpdateQualitativeGrpDetailsSetup(QualitativeDetail oQual)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_QT_GRP_DETAILS_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_group_id",OracleDbType.Varchar2,3,oQual.Qualitative.GroupID,ParameterDirection.Input),
                new OracleParameter("p_det_id",OracleDbType.Varchar2,3,oQual.DetID,ParameterDirection.Input),
                new OracleParameter("p_det_title",OracleDbType.Varchar2,500,oQual.DetTitle,ParameterDirection.Input),
                new OracleParameter("p_det_title_beng",OracleDbType.Varchar2,500,oQual.DetTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oQual.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oQual.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oQual.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oQual.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oQual.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetQualitativeGrpDetailsSetup
        public List<QualitativeDetail> GetQualitativeGrpDetails()
        {
            string packagename = "PKG_DRS_SETUP.GET_QT_GRP_DETAILS_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetQualitativeGrpDetailsSetup(packagename, parameterList);
        }
        public List<QualitativeDetail> GetQtGrpDetails(string Group)
        {
            string packagename = "PKG_DRS_SETUP.GET_QT_GRP_DETAILS_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_grp_id",OracleDbType.Varchar2,Group,ParameterDirection.Input)
            };
            return GetQualitativeGrpDetailsSetup(packagename, parameterList);
        }
        private List<QualitativeDetail> GetQualitativeGrpDetailsSetup(string packagename, OracleParameter[] parameterList)
        {
            List<QualitativeDetail> macs = new List<QualitativeDetail>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                QualitativeDetail mac = new QualitativeDetail();
                Qualitative oQu = new Qualitative();
                oQu.GroupID = (string)rdr["GRP_ID"].ToString();
                mac.Qualitative = oQu;
                mac.DetID = (string)rdr["DET_ID"];
                mac.DetTitle = (string)rdr["DET_TITLE"];
                mac.DetTitleBeng = rdr["DET_TITLE_BENG"] != DBNull.Value ? (string)rdr["DET_TITLE_BENG"] : "";
                mac.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                macs.Add(mac);
            }
            rdr.Close();
            return macs;
        }
        #endregion

        #region SaveColorCodeSetup
        public short SaveColorCodeSetup(ColorCode oColor)
        {
            packageName = "PKG_DRS_SETUP.INSERT_COLOR_CODE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_color_id",OracleDbType.Varchar2,3,oColor.ColorID,ParameterDirection.Input),
                new OracleParameter("p_color_title",OracleDbType.Varchar2,500,oColor.ColorTitle,ParameterDirection.Input),
                new OracleParameter("p_color_title_beng",OracleDbType.Varchar2,500,oColor.ColorTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oColor.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oColor.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oColor.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oColor.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oColor.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateColorCodeSetup
        public short UpdateColorCodeSetup(ColorCode oColor)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_COLOR_CODE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_color_id",OracleDbType.Varchar2,3,oColor.ColorID,ParameterDirection.Input),
                new OracleParameter("p_color_title",OracleDbType.Varchar2,500,oColor.ColorTitle,ParameterDirection.Input),
                new OracleParameter("p_color_title_beng",OracleDbType.Varchar2,500,oColor.ColorTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oColor.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oColor.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oColor.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oColor.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oColor.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetColorCodeSetup
        public List<ColorCode> GetColorCodeSetup()
        {
            string packagename = "PKG_DRS_SETUP.GET_COLOR_CODE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetColorCodeSetupDetails(packagename, parameterList);
        }
        private List<ColorCode> GetColorCodeSetupDetails(string packagename, OracleParameter[] parameterList)
        {
            List<ColorCode> oCols = new List<ColorCode>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                ColorCode oCol = new ColorCode();
                oCol.ColorID = (string)rdr["COLOR_ID"];
                oCol.ColorTitle = (string)rdr["COLOR_TITLE"];
                oCol.ColorTitleBeng = (string)rdr["COLOR_TITLE_BENG"];
                oCol.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                oCols.Add(oCol);
            }
            rdr.Close();
            return oCols;
        }
        #endregion

        #region SaveResultHeadMapping
        public short SaveResultHeadMapping(ResultHead reshd)
        {
            packageName = "PKG_DRS_SETUP.INSERT_RES_HD_MAP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_test_det_id",OracleDbType.Varchar2,6,reshd.TestSub.TestSubID,ParameterDirection.Input),
            new OracleParameter("p_grp_id",OracleDbType.Varchar2,4,reshd.ReportGroup.ReportGroupID,ParameterDirection.Input),         
            new OracleParameter("p_hd_string",OracleDbType.Varchar2,20000,reshd.MachineString,ParameterDirection.Input),
            new OracleParameter("p_serial",OracleDbType.Varchar2,20,reshd.Serial,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,reshd.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,reshd.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,reshd.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,reshd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            return 0;
        }
        #endregion       

        #region UpdateResultHeadMapping
        public short UpdateResultHeadMapping(ResultHead reshd)
        {
            packageName = "PKG_DRS_SETUP.UPDATE_RES_HD_MAP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_test_det_id",OracleDbType.Varchar2,6,reshd.TestSub.TestSubID,ParameterDirection.Input),
            new OracleParameter("p_grp_id",OracleDbType.Varchar2,4,reshd.ReportGroup.ReportGroupID,ParameterDirection.Input),        
            new OracleParameter("p_hd_string",OracleDbType.Varchar2,20000,reshd.MachineString,ParameterDirection.Input),
            new OracleParameter("p_serial",OracleDbType.Varchar2,20,reshd.Serial,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,reshd.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,reshd.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,reshd.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,reshd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            return 0;
        }
        #endregion

        #region GetResultHead
        public List<ResultHead> GetResultHdMap(string TestDetails)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_MAP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_test_det_id",OracleDbType.Varchar2,6,TestDetails,ParameterDirection.Input)
               
            };
            return GetResHeadMapSetup(packageName, parameterList);
        }
        public List<ResultHeadRO> GetReportResultHd(string TestDetails)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_MAP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_test_det_id",OracleDbType.Varchar2,6,TestDetails,ParameterDirection.Input)
               
            };
            return GetResHeadMapForReport(packageName, parameterList);
        }
        private List<ResultHead> GetResHeadMapSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();
                ResultHeadGroup oRes = new ResultHeadGroup();
                oRes.ResultHeadGroupID = (string)rdr["HD_GRP_ID"].ToString();
                oRes.ResultHeadGroupTitle = (string)rdr["HD_GRP_TITLE"].ToString();
                reshdobj.ResultGroup = oRes;
                reshdobj.Serial =Convert.ToInt32(rdr["serial"].ToString());
                reshdobj.HdGrpSerial = Convert.ToInt32(rdr["hd_grp_serial"].ToString());
                TestSub oTest = new TestSub();
                oTest.TestSubID = (string)rdr["TEST_DET_ID_RPT"].ToString();
                oTest.TestSubTitle = (string)rdr["TEST_DET_TITLE"].ToString();
                reshdobj.TestSub = oTest;
                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        private List<ResultHeadRO> GetResHeadMapForReport(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHeadRO> reshd = new List<ResultHeadRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHeadRO reshdobj = new ResultHeadRO();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();
                reshdobj.ResultHeadGroupID = (string)rdr["HD_GRP_ID"].ToString();
                reshdobj.ResultHeadGroupTitle = (string)rdr["HD_GRP_TITLE"].ToString();
                reshdobj.TestDetails = (string)rdr["TEST_DET_TITLE"].ToString(); 
                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }

        private bool isDBNull(int p)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetResultForHead
        public List<ResultHead> GetResultHdForMap(string TestDetails,string ReportGroup)
        {
            string packageName = "PKG_DRS_SETUP.GET_RES_HD_FOR_MAP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_test_det_id",OracleDbType.Varchar2,6,TestDetails,ParameterDirection.Input),
                new OracleParameter("p_rpt_grp",OracleDbType.Varchar2,5,ReportGroup,ParameterDirection.Input)
               
            };
            return GetResHeadForMapSetup(packageName, parameterList);
        }
        private List<ResultHead> GetResHeadForMapSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();
                reshdobj.Serial =Convert.ToInt32(rdr["Serial"].ToString());
                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        #endregion

        #region GetRprGrpByTest
        public List<ResultHead> GetRprGrpByTest(string TestDetails)
        {
            string packageName = "PKG_DRS_SETUP.GET_RPT_GRP_BY_TEST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_test_det_id",OracleDbType.Varchar2,6,TestDetails,ParameterDirection.Input)
               
            };
            return GetRprGrpByTestSetup(packageName, parameterList);
        }
        private List<ResultHead> GetRprGrpByTestSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                ReportGroup orpt = new ReportGroup();
                orpt.ReportGroupID = (string)rdr["REPORT_GRP_ID"].ToString();
                orpt.ReportGroupTitle = (string)rdr["grp_title"].ToString();
                TestCategory cat = new TestCategory();
                cat.TestCategoryID = rdr["TEST_CAT_ID"].ToString();
                cat.TestCategoryTitle = rdr["cat_title"].ToString();
                orpt.TestCategory = cat;
                GroupPanel grp = new GroupPanel();
                grp.PanelID = rdr["PNL_ID"].ToString();
                grp.PanelTitle = rdr["pnl_title"].ToString();
                orpt.GroupPanel = grp;
                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = rdr["sec_id"].ToString();
                oRptSec.ReportSectionTitle = rdr["sec_title"].ToString();
                orpt.ReportSection = oRptSec;
                reshdobj.ReportGroup = orpt;
                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        #endregion

        #region GetHdByGrp
        public List<ResultHead> GetHdByGrp(string ReportGrp)
        {
            string packageName = "PKG_DRS_SETUP.GET_HD_BY_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_rpt_grp_id",OracleDbType.Varchar2,10,ReportGrp,ParameterDirection.Input)
               
            };
            return GetHdByGrpSetup(packageName, parameterList);
        }
        private List<ResultHead> GetHdByGrpSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();
                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();
                reshdobj.Serial = Convert.ToInt32(rdr["SERIAL"].ToString());
                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }
        #endregion

    }
}
