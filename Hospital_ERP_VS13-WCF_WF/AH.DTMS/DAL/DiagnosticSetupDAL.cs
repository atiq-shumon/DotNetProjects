using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.PatReg.MODEL;
using AH.DTMS.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using AH.Shared.MODEL;

namespace AH.DTMS.DAL
{
    public class DiagnosticSetupDAL
    {
        public string connString = Utility.GetConnectionString(Utility.Module.DMSMIS);
        string packageName = string.Empty;

        #region GetTestGroup
        public List<TestGroup> GetDiagnGrp()
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDiagnosGrp(packagename, parameterList);
        }

        public List<TestGroup> GetDiagnGrp(string department)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,department,ParameterDirection.Input)
            };
            return GetDiagnosGrp(packagename, parameterList);
        }
        private List<TestGroup> GetDiagnosGrp(string packagename, OracleParameter[] parameterList)
        {
            List<TestGroup> diaggrp = new List<TestGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestGroup diagrobj = new TestGroup();
                diagrobj.GroupId = (string)rdr[0];
                diagrobj.GroupTitle = (string)rdr[1];
                diagrobj.GroupTitleBeng = (string)rdr[2];
                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr[3];
                dpt.DepartmentTitle = !rdr.IsDBNull(4) ? (string)rdr[4] : ""; 
                diagrobj.Department = dpt;
                diagrobj.Remarks = !rdr.IsDBNull(5) ? (string)rdr[5] : "";
                diaggrp.Add(diagrobj);
            }
            rdr.Close();
            return diaggrp;
        }
        #endregion

        #region SaveTestGroup
        public short SaveTestGroup(TestGroup grp)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_TEST_GRP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                  new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                  new OracleParameter("GroupTitle",OracleDbType.Varchar2,70,grp.GroupTitle,ParameterDirection.Input),
                  new OracleParameter("GroupTitleBeng",OracleDbType.Varchar2,70,grp.GroupTitleBeng,ParameterDirection.Input),
                  new OracleParameter("Dept",OracleDbType.Varchar2,5,grp.Department.DepartmentID,ParameterDirection.Input),
                  new OracleParameter("Remarks",OracleDbType.Varchar2,300,grp.Remarks,ParameterDirection.Input),
                  new OracleParameter("EntryBy",OracleDbType.Varchar2,20,grp.EParameter.EntryBy,ParameterDirection.Input),
                  new OracleParameter("CompanyID",OracleDbType.Varchar2,2,grp.EParameter.CompanyID,ParameterDirection.Input),
                  new OracleParameter("LocationID",OracleDbType.Varchar2,2,grp.EParameter.LocationID,ParameterDirection.Input),
                  new OracleParameter("MachineID",OracleDbType.Varchar2,20,grp.EParameter.MachineID,ParameterDirection.Input)
          };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateTestGroup
        public short UpdateGroup(TestGroup grp)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_TEST_GRP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                  new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                  new OracleParameter("GroupID",OracleDbType.Varchar2,2,grp.GroupId,ParameterDirection.Input),
                  new OracleParameter("GroupTitle",OracleDbType.Varchar2,70,grp.GroupTitle,ParameterDirection.Input),
                  new OracleParameter("GroupTitleBeng",OracleDbType.Varchar2,70,grp.GroupTitleBeng,ParameterDirection.Input),
                  new OracleParameter("Dept",OracleDbType.Varchar2,5,grp.Department.DepartmentID,ParameterDirection.Input),
                  new OracleParameter("Remarks",OracleDbType.Varchar2,300,grp.Remarks,ParameterDirection.Input),
                  new OracleParameter("EntryBy",OracleDbType.Varchar2,20,grp.EParameter.EntryBy,ParameterDirection.Input),
                  new OracleParameter("CompanyID",OracleDbType.Varchar2,2,grp.EParameter.CompanyID,ParameterDirection.Input),
                  new OracleParameter("LocationID",OracleDbType.Varchar2,2,grp.EParameter.LocationID,ParameterDirection.Input),
                  new OracleParameter("MachineID",OracleDbType.Varchar2,20,grp.EParameter.MachineID,ParameterDirection.Input)
          };


            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VerifyTestGroup
        public int VerifyTestGroup(string groupId)
        {
            packageName = "PKG_DIAG_SETUP.VERIFY_TEST_GRPID";
            OracleParameter[] parameterList = new OracleParameter[] { 
                  new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                  new OracleParameter("GroupID",OracleDbType.Varchar2,2,groupId,ParameterDirection.Input)
          };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region GetTestMain
        public List<TestMain> GetTestMain()
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_MAIN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetMainSetup(packagename, parameterList);

        }
        public List<TestMain> GetTestMain(string department, string group)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_MAIN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,department,ParameterDirection.Input),
                new OracleParameter("Group",OracleDbType.Varchar2,4,group,ParameterDirection.Input)
            };
            return GetMainSetup(packagename, parameterList);

        }
        private List<TestMain> GetMainSetup(string packagename, OracleParameter[] parameterList)
        {
            List<TestMain> tsmain = new List<TestMain>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestMain tmainobj = new TestMain();
                tmainobj.TestMainID = (string)rdr[0].ToString();
                tmainobj.TestMainTitle = (string)rdr[1];
                tmainobj.TestMainTitleBeng = (string)rdr[2];
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr[3];
                tg.GroupTitle =!rdr.IsDBNull(4) ? (string)rdr[4]:"";

                tmainobj.TestGroup = tg;
                Department dp = new Department();
                dp.DepartmentID = !rdr.IsDBNull(5) ? (string)rdr[5] : "";
                dp.DepartmentTitle =!rdr.IsDBNull(6) ?  (string)rdr[6]: "";
                tmainobj.TestDepartment = dp;
                tmainobj.Remarks = !rdr.IsDBNull(7) ? (string)rdr[7] : "";
                tsmain.Add(tmainobj);
            }
            rdr.Close();
            return tsmain;
        }
        #endregion

        #region VerifyTestMain
        public int VerifyTestMain(string mainid)
        {
            packageName = "PKG_DIAG_SETUP.VERIFY_MAINID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("MainID",OracleDbType.Varchar2,5,mainid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int rsno = (int)(OracleDecimal)prm.Value;
            return rsno;
        }
        #endregion

        #region SaveTestMain
        public short SaveTestMain(TestMain tsmain)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_TEST_MAIN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TestMainTitle",OracleDbType.Varchar2,150,tsmain.TestMainTitle,ParameterDirection.Input),
                new OracleParameter("TestMainTitleBeng",OracleDbType.Varchar2,150,tsmain.TestMainTitleBeng,ParameterDirection.Input),
                new OracleParameter("GroupID",OracleDbType.Varchar2,2,tsmain.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,tsmain.TestDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tsmain.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tsmain.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tsmain.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tsmain.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tsmain.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateTestMain
        public short UpdateTestMain(TestMain tmain)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_TEST_MAIN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Main ID",OracleDbType.Varchar2,5,tmain.TestMainID,ParameterDirection.Input),
                new OracleParameter("Test Main Name",OracleDbType.Varchar2,150,tmain.TestMainTitle,ParameterDirection.Input),
                new OracleParameter("Test Main NameBeng",OracleDbType.Varchar2,150,tmain.TestMainTitleBeng,ParameterDirection.Input),
                new OracleParameter("Group ID",OracleDbType.Varchar2,4,tmain.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("Department ID",OracleDbType.Varchar2,4,tmain.TestDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tmain.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tmain.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tmain.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tmain.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tmain.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetTestPanel
        public List<GroupPanel> GetPanelSetup()
        {
            string packagename = "PKG_DIAG_SETUP.GET_PNL_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetPnlSetup(packagename, parameterList);
        }
        private List<GroupPanel> GetPnlSetup(string packagename, OracleParameter[] parameterList)
        {
            List<GroupPanel> pnl = new List<GroupPanel>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                GroupPanel pnlobj = new GroupPanel();
                pnlobj.PanelID = (string)rdr[0].ToString();
                pnlobj.PanelTitle = (string)rdr[1];
                pnlobj.PanelTitleBeng = (string)rdr[2];
                pnlobj.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                pnl.Add(pnlobj);
            }
            rdr.Close();
            return pnl;
        }
        #endregion

        #region SaveTestPanel
        public short SaveTestPanel(GroupPanel tspanel)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_PNL_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PanelTitle",OracleDbType.Varchar2,70,tspanel.PanelTitle,ParameterDirection.Input),
                new OracleParameter("PanelTitleBeng",OracleDbType.Varchar2,70,tspanel.PanelTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tspanel.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,30,tspanel.EntryParam.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tspanel.EntryParam.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tspanel.EntryParam.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tspanel.EntryParam.MachineID,ParameterDirection.Input)
                
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateTestPanel
        public short UpdateTestPanel(GroupPanel tspanel)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_PNL_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PanelID",OracleDbType.Varchar2,2,tspanel.PanelID,ParameterDirection.Input),
                new OracleParameter("PanelTitle",OracleDbType.Varchar2,70,tspanel.PanelTitle,ParameterDirection.Input),
                new OracleParameter("PanelTitleBeng",OracleDbType.Varchar2,70,tspanel.PanelTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tspanel.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,30,tspanel.EntryParam.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tspanel.EntryParam.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tspanel.EntryParam.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tspanel.EntryParam.MachineID,ParameterDirection.Input)
                
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VerifyTestPanel
        public int VerifyTestPanel(string panelId)
        {
            packageName = "PKG_PNL_SETUP.P_Verify_Pnl_Setup";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PanelID",OracleDbType.Varchar2,3,panelId,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region GetTestDetail
        public List<TestSub> GetTestDetail()
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_DET";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDetailSetup(packagename, parameterList);
        }
        public List<TestSub> GetTestDetails(string deptid, string group, string main)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_DET";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
                new OracleParameter("group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("main",OracleDbType.Varchar2,4,main,ParameterDirection.Input)
            };
            return GetDetailSetup(packagename, parameterList);
        }
        public List<TestSub> GetTestDets(string deptid, string group, string main)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
                new OracleParameter("group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("main",OracleDbType.Varchar2,4,main,ParameterDirection.Input)
            };
            return GetDetailSetup(packagename, parameterList);
        }
        public List<TestSub> GetTestForDetailsSetup(string Mode,string deptid, string group, string main)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,4,Mode,ParameterDirection.Input),
                new OracleParameter("dept",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
                new OracleParameter("group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("main",OracleDbType.Varchar2,4,main,ParameterDirection.Input)
            };
            return GetDetailSetup(packagename, parameterList);
        }
        public List<TestSub> GetTestName(string deptid, string group, string main,string ReportSection,string ReportGroup)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
                new OracleParameter("group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("main",OracleDbType.Varchar2,4,main,ParameterDirection.Input),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,5,ReportSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,5,ReportGroup,ParameterDirection.Input)
            };
            return GetDetailSetup(packagename, parameterList);
        }

        private List<TestSub> GetDetailSetup(string packagename, OracleParameter[] parameterList)
        {
            List<TestSub> detsetup = new List<TestSub>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestSub detobj = new TestSub();
                detobj.TestSubID = (string)rdr["test_det_id"].ToString();
                detobj.TestSubTitle = (string)rdr["test_det_title"].ToString();
                detobj.TestSubTitleBeng = (string)rdr["test_det_title_beng"].ToString();
                detobj.TestMainID = (string)rdr["test_main_id"].ToString();
                Department dp = new Department();
                dp.DepartmentID = (string)rdr["dept_id"].ToString();
                detobj.TestDepartment = dp;
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["grp_id"].ToString();
                detobj.TestGroup = tg;
                detobj.DeliveryAfter = short.Parse(rdr["MIN_DAY_TO_MATURE"].ToString());
                detobj.DeliveryAfterHours = short.Parse(rdr["min_time_to_mature"].ToString());

                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = (string)rdr["report_sec_id"].ToString();
                oRptSec.ReportSectionTitle = (string)rdr["sec_title"].ToString();
                detobj.ReportSection = oRptSec;
                
                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = (string)rdr["report_grp_id"].ToString();
                detobj.ReportGroup = rpt;

                TestCategory tc = new TestCategory();
                tc.TestCategoryID = (string)rdr["test_cat_id"].ToString();
                detobj.TestCategory = tc;

                LabRoom lbrm = new LabRoom();
                lbrm.RoomID = (string)rdr["lab_room"].ToString();
                detobj.LabRoom = lbrm;
            
                detobj.PanelID = !rdr.IsDBNull(21) ? (string)rdr["pnl_id"].ToString() : "";
                detobj.PanelTitle = !rdr.IsDBNull(22) ? (string)rdr["PNL_TITLE"].ToString() : "";
                detobj.ShortCode = !rdr.IsDBNull(23) ? (string)rdr["SHORT_CODE"].ToString() : "";
                detobj.TestSubTitleAlias = (string)rdr["TEST_DET_TITLE_ALIAS"].ToString();

                Specimen spc = new Specimen();
                spc.SpecimenID = (string)rdr["specimen_id"].ToString();
                spc.SpecimenTitle = (string)rdr["spc_title"].ToString();
                detobj.Specimen = spc;              

                SpecimenCollectionRoom spcroom = new SpecimenCollectionRoom();
                spcroom.RoomID = (string)rdr["spc_coll_room"];
                spcroom.RoomTitle = rdr["room_title"] != DBNull.Value ? (string)rdr["room_title"] : "";
                detobj.SpecimenCollectionRoom = spcroom;

                SpecimenHolder SpecimenHolder = new SpecimenHolder();
                SpecimenHolder.HolderID = (string)rdr["CONTAINER_ID"].ToString();
                SpecimenHolder.HolderTitle = (string)rdr["CONTAINER_TITLE"].ToString();
                SpecimenHolder.HolderQuantity = (string)rdr["CONTAINER_QTY"].ToString();
                detobj.SpecimenHolder = SpecimenHolder;

                TestMethod oTest = new TestMethod();
                oTest.MethodID = rdr["TEST_METHOD_ID"].ToString();
                oTest.MethodTitle = rdr["METHOD_TITLE"].ToString();
                detobj.TestMethod = oTest;

                detobj.PosSerial = rdr["pos_serial"].ToString();

                EntryParameter oEp = new EntryParameter();
                oEp.Active = rdr["ACTIVE"].ToString();
                detobj.EParameter = oEp;

               detsetup.Add(detobj);
            };
            rdr.Close();
            return detsetup;

        }
        #endregion

        #region GetSpcTestDetail
        public List<TestSub> GetSpcTestDetail()
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_SPC_DET";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetSpcDetailSetup(packagename, parameterList);
        }      
        private List<TestSub> GetSpcDetailSetup(string packagename, OracleParameter[] parameterList)
        {
            List<TestSub> detsetup = new List<TestSub>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestSub detobj = new TestSub();
                detobj.TestSubID = (string)rdr["test_det_id"];
                detobj.TestMainID = (string)rdr["test_main_id"];
                Department dp = new Department();
                dp.DepartmentID = (string)rdr["dept_id"];
                detobj.TestDepartment = dp;
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["grp_id"];
                detobj.TestGroup = tg;
                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = (string)rdr["report_grp_id"];
                detobj.ReportGroup = rpt;

                Specimen spc = new Specimen();
                spc.SpecimenID = (string)rdr["specimen_id"];
                spc.SpecimenTitle = (string)rdr["spc_title"];
                detobj.Specimen = spc;

                TestCategory tc = new TestCategory();
                tc.TestCategoryID = (string)rdr["test_cat_id"];
                detobj.TestCategory = tc;

                SpecimenCollectionRoom spcroom = new SpecimenCollectionRoom();
                spcroom.RoomID = (string)rdr["spc_coll_room"];
                spcroom.RoomTitle =rdr["room_title"] != DBNull.Value ? (string)rdr["room_title"]:"";
                detobj.SpecimenCollectionRoom = spcroom;

                SpecimenHolder SpecimenHolder = new SpecimenHolder();
                SpecimenHolder.HolderID = (string)rdr["CONTAINER_ID"].ToString();
                SpecimenHolder.HolderTitle = (string)rdr["CONTAINER_TITLE"].ToString();
                SpecimenHolder.HolderQuantity = (string)rdr["CONTAINER_QTY"].ToString(); 
                detobj.SpecimenHolder = SpecimenHolder;
                             
                detsetup.Add(detobj);
            };
            rdr.Close();
            return detsetup;

        }
        #endregion

        #region UnAssignTest
        public List<TestSub> GetUnassignTest(string deptid, string group, string main)
        {
            string packageName = "PKG_DIAG_SETUP.get_unAssigned_test";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
                new OracleParameter("group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("main",OracleDbType.Varchar2,4,main,ParameterDirection.Input)
            };
            return GetUnassign(packageName, parameterList);
        }
        private List<TestSub> GetUnassign(string packageName, OracleParameter[] parameterList)
        {
            List<TestSub> tset = new List<TestSub>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestSub tsub = new TestSub();
                tsub.TestSubID = (string)rdr[0];
                tsub.TestSubTitle = (string)rdr[1];
                tsub.PanelID = (string)rdr[2];
                tset.Add(tsub);
            }
            rdr.Close();
            return tset;
        }
        #endregion

        #region VerifyTestDetail
        public int VerifyTestDetail(string detailid)
        {
            packageName = "PKG_DIAG_SETUP.VERIFY_TEST_DETID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DetailID",OracleDbType.Varchar2,10,detailid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveTestDetail
        public short SaveTestDetail(TestSub tsDetail)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_TEST_DET";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TestDetailTitle",OracleDbType.Varchar2,150,tsDetail.TestSubTitle,ParameterDirection.Input),
                new OracleParameter("TestDetailTitleBeng",OracleDbType.Varchar2,150,tsDetail.TestSubTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_test_det_title_alias",OracleDbType.Varchar2,150,tsDetail.TestSubTitleAlias,ParameterDirection.Input),
                new OracleParameter("TestMainID",OracleDbType.Varchar2,4,tsDetail.TestMainID,ParameterDirection.Input),
                new OracleParameter("GroupID",OracleDbType.Varchar2,2,tsDetail.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,tsDetail.TestDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_report_sec_id",OracleDbType.Varchar2,4,tsDetail.ReportSection.ReportSectionID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,4,tsDetail.ReportGroup.ReportGroupID,ParameterDirection.Input),
                new OracleParameter("panel",OracleDbType.Varchar2,3,tsDetail.PanelID,ParameterDirection.Input),
                new OracleParameter("CategoryID",OracleDbType.Varchar2,2,tsDetail.TestCategory.TestCategoryID,ParameterDirection.Input),
                new OracleParameter("p_test_method",OracleDbType.Varchar2,3,tsDetail.TestMethod.MethodID,ParameterDirection.Input),
                new OracleParameter("p_specimen_id",OracleDbType.Varchar2,4,tsDetail.Specimen.SpecimenID,ParameterDirection.Input),
                new OracleParameter("p_spc_coll_room",OracleDbType.Varchar2,5,tsDetail.SpecimenCollectionRoom.RoomID,ParameterDirection.Input),
                new OracleParameter("p_container_id",OracleDbType.Varchar2,4,tsDetail.SpecimenHolder.HolderID,ParameterDirection.Input),
                new OracleParameter("p_container_qty",OracleDbType.Varchar2,5,tsDetail.SpecimenHolder.HolderQuantity,ParameterDirection.Input),
                new OracleParameter("LabRoom",OracleDbType.Varchar2,5,tsDetail.LabRoom.RoomID,ParameterDirection.Input),
                new OracleParameter("p_min_day_to_mature",OracleDbType.Int32,tsDetail.DeliveryAfter,ParameterDirection.Input),
                new OracleParameter("p_min_time_to_mature",OracleDbType.Int32,tsDetail.DeliveryAfterHours,ParameterDirection.Input),
                new OracleParameter("p_short_code",OracleDbType.Varchar2,150,tsDetail.ShortCode,ParameterDirection.Input),
                new OracleParameter("p_pos_serial",OracleDbType.Varchar2,10,tsDetail.PosSerial,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tsDetail.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tsDetail.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tsDetail.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tsDetail.EParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateTestDetail
        public short UpdateTestDetail(TestSub tsDetail)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_TEST_DET";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Detail ID",OracleDbType.Varchar2,6,tsDetail.TestSubID,ParameterDirection.Input),
                new OracleParameter("TestDetailTitle",OracleDbType.Varchar2,150,tsDetail.TestSubTitle,ParameterDirection.Input),
                new OracleParameter("TestDetailTitleBeng",OracleDbType.Varchar2,150,tsDetail.TestSubTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_test_det_title_alias",OracleDbType.Varchar2,150,tsDetail.TestSubTitleAlias,ParameterDirection.Input),
                new OracleParameter("TestMainID",OracleDbType.Varchar2,4,tsDetail.TestMainID,ParameterDirection.Input),
                new OracleParameter("GroupID",OracleDbType.Varchar2,2,tsDetail.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,tsDetail.TestDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_report_sec_id",OracleDbType.Varchar2,4,tsDetail.ReportSection.ReportSectionID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,4,tsDetail.ReportGroup.ReportGroupID,ParameterDirection.Input),
                new OracleParameter("panel",OracleDbType.Varchar2,3,tsDetail.PanelID,ParameterDirection.Input),
                new OracleParameter("CategoryID",OracleDbType.Varchar2,2,tsDetail.TestCategory.TestCategoryID,ParameterDirection.Input),
                new OracleParameter("p_test_method",OracleDbType.Varchar2,3,tsDetail.TestMethod.MethodID,ParameterDirection.Input),
                new OracleParameter("p_specimen_id",OracleDbType.Varchar2,4,tsDetail.Specimen.SpecimenID,ParameterDirection.Input),
                new OracleParameter("p_spc_coll_room",OracleDbType.Varchar2,5,tsDetail.SpecimenCollectionRoom.RoomID,ParameterDirection.Input),
                new OracleParameter("p_container_id",OracleDbType.Varchar2,4,tsDetail.SpecimenHolder.HolderID,ParameterDirection.Input),
                new OracleParameter("p_container_qty",OracleDbType.Varchar2,5,tsDetail.SpecimenHolder.HolderQuantity,ParameterDirection.Input),
                new OracleParameter("LabRoom",OracleDbType.Varchar2,5,tsDetail.LabRoom.RoomID,ParameterDirection.Input),
                new OracleParameter("p_min_day_to_mature",OracleDbType.Int32,tsDetail.DeliveryAfter,ParameterDirection.Input),
                new OracleParameter("p_min_time_to_mature",OracleDbType.Int32,tsDetail.DeliveryAfterHours,ParameterDirection.Input),
                new OracleParameter("p_short_code",OracleDbType.Varchar2,150,tsDetail.ShortCode,ParameterDirection.Input),
                new OracleParameter("p_pos_serial",OracleDbType.Varchar2,10,tsDetail.PosSerial,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tsDetail.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tsDetail.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tsDetail.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tsDetail.EParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("p_Active",OracleDbType.Varchar2,1,tsDetail.EParameter.Active,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region InsertPanelTests
        public short InsertPanelTests(TestSub oTestDetails)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_PANEL_TESTS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_panel_id",OracleDbType.Varchar2,3,oTestDetails.PanelID,ParameterDirection.Input),
                new OracleParameter("test_string",OracleDbType.Varchar2,5000,oTestDetails.AllTest,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oTestDetails.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,20,oTestDetails.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,20,oTestDetails.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oTestDetails.EParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion
       
        #region GetPanelTests
        public List<TestFee> GetPanelTest(string PanelId)
        {
            string packagename = "PKG_DIAG_SETUP.GET_PANEL_TEST";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_panel_id",OracleDbType.Varchar2,5,PanelId,ParameterDirection.Input)
            };
            return GetPanelTestSetup(packagename, parameterList);
        }

        public List<TestFee> GetPanelTests(string PanelId)
        {
            string packagename = "PKG_DIAG_SETUP.GET_PANEL_TESTS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_panel_id",OracleDbType.Varchar2,5,PanelId,ParameterDirection.Input)
            };
            return GetPanelTestsSetup(packagename, parameterList);
        }

        public List<TestFee> GetTestUnedrPanel(string PanelId)
        {
            string packagename = "PKG_DIAG_SETUP.GET_TEST_UNDER_PANEL";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_panel_id",OracleDbType.Varchar2,5,PanelId,ParameterDirection.Input)
            };
            return GetPanelTestsSetup(packagename, parameterList);
        }

        private List<TestFee> GetPanelTestsSetup(string packagename, OracleParameter[] parameterList)
        {
            List<TestFee> oTestFees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestFee oFee = new TestFee();

                TestSub oTestSub = new TestSub();
                oTestSub.PanelID = (String)rdr["PNL_ID"].ToString();
                oTestSub.TestSubID = (string)rdr["TEST_DET_ID"].ToString();
                oTestSub.TestSubTitle = (string)rdr["TEST_DET_TITLE"].ToString();
                oTestSub.TestMainID = (string)rdr["TEST_MAIN_ID"].ToString();
                oTestSub.TestMainTitle = (string)rdr["TEST_MAIN_TITLE"].ToString();
                
                Department dp = new Department();
                dp.DepartmentID = (string)rdr["DEPT_ID"].ToString();
                dp.DepartmentTitle = (string)rdr["DEPT_TITLE"].ToString();
                oTestSub.TestDepartment = dp;
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["GRP_ID"].ToString();
                oTestSub.TestGroup = tg;
                LabRoom oRoom = new LabRoom();
                oRoom.RoomID = (string)rdr["LAB_ROOM"].ToString();
                oTestSub.LabRoom = oRoom;

                SpecimenCollectionRoom oSpcColl = new SpecimenCollectionRoom();
                oSpcColl.RoomID = (string)rdr["SPC_COLL_ROOM"].ToString();
                oSpcColl.RoomTitle = (string)rdr["SPC_COLL_ROOM_TITLE"].ToString();
                oTestSub.SpecimenCollectionRoom = oSpcColl;

                ReportGroup oRptGrp = new ReportGroup();
                oRptGrp.ReportGroupID = (string)rdr["REPORT_GRP_ID"].ToString();
                oTestSub.ReportGroup = oRptGrp;

                oFee.TestSub = oTestSub;

                FeeCategory oFeeCat = new FeeCategory();
                oFeeCat.FeeCategoryID = (string)rdr["FEE_CAT_ID"].ToString();
                oFee.FeeCategory = oFeeCat;

                oFee.Fee = Convert.ToDecimal(rdr["FEE"].ToString());
                oFee.DeptFee = Convert.ToDecimal(rdr["DEPT_AMT"].ToString());
                oFee.RefdFee = Convert.ToDecimal(rdr["REFF_DEPT_AMT"].ToString());
                oFee.DoctorFee = Convert.ToDecimal(rdr["REFF_DOC_AMT"].ToString());
                oFee.VAT = Convert.ToDecimal(rdr["VAT"].ToString());
                oFee.Discount = Convert.ToDecimal(rdr["DISC"].ToString());

                oTestFees.Add(oFee);
            };
            rdr.Close();
            return oTestFees;

        }

        private List<TestFee> GetPanelTestSetup(string packagename, OracleParameter[] parameterList)
        {
            List<TestFee> oTestFees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestSub oTestSub = new TestSub();
                TestFee oFee = new TestFee();
                oTestSub.TestSubID = (string)rdr["TEST_DET_ID"].ToString();
                oTestSub.TestSubTitle = (string)rdr["TEST_DET_TITLE"].ToString();
                oTestSub.TestMainID = (string)rdr["TEST_MAIN_ID"].ToString();
                oTestSub.TestMainTitle = (string)rdr["TEST_MAIN_TITLE"].ToString();
                Department dp = new Department();
                dp.DepartmentID = (string)rdr["DEPT_ID"].ToString();
                oTestSub.TestDepartment = dp;
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["GRP_ID"].ToString();
                oTestSub.TestGroup = tg;
                oFee.TestSub = oTestSub;
                oTestFees.Add(oFee);
            };
            rdr.Close();
            return oTestFees;

        }
        #endregion

        #region GetCategory
        public List<TestCategory> GetCategories()
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_CAT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetCatsetup(packageName, parameterList);
        }
        private List<TestCategory> GetCatsetup(string packageName, OracleParameter[] parameterList)
        {
            List<TestCategory> testcat = new List<TestCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestCategory tcat = new TestCategory();
                tcat.TestCategoryID = (string)rdr[0];
                tcat.TestCategoryTitle = (string)rdr[1];
                tcat.TestCategoryTitleBeng = (string)rdr[2];
                tcat.TestCategoryRemarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                testcat.Add(tcat);
            }
            rdr.Close();
            return testcat;
        }
        #endregion

        #region VerifyTestCategory
        public int VerifyTestCat(string catid)
        {
            packageName = "PKG_DIAG_SETUP.VERIFY_CATID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("CategoryID",OracleDbType.Varchar2,2,catid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveCategory
        public short SaveCategory(TestCategory testCat)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_TEST_CAT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("CategoryName",OracleDbType.Varchar2,70,testCat.TestCategoryTitle,ParameterDirection.Input),
                new OracleParameter("CategoryNameBeng",OracleDbType.Varchar2,70,testCat.TestCategoryTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,testCat.TestCategoryRemarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,testCat.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,testCat.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,testCat.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,testCat.EParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region UpdateCategory
        public short UpdateCategory(TestCategory tcat)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_TEST_CAT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Cat ID",OracleDbType.Varchar2,2,tcat.TestCategoryID,ParameterDirection.Input),
                new OracleParameter("Cat Title",OracleDbType.Varchar2,70,tcat.TestCategoryTitle,ParameterDirection.Input),
                new OracleParameter("Cat Title Beng",OracleDbType.Varchar2,70,tcat.TestCategoryTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tcat.TestCategoryRemarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tcat.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tcat.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tcat.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tcat.EParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region SaveTestFee
        public short SaveTestFee(TestFee tfee)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_TEST_FEE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TestDetailID",OracleDbType.Varchar2,6,tfee.TestSub.TestSubID,ParameterDirection.Input),
                new OracleParameter("TestMainID",OracleDbType.Varchar2,4,tfee.TestSub.TestMainID,ParameterDirection.Input),
                new OracleParameter("TestGroup",OracleDbType.Varchar2,2,tfee.TestSub.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,tfee.TestSub.TestDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("FeeCategory",OracleDbType.Varchar2,2,tfee.FeeCategory.FeeCategoryID,ParameterDirection.Input),
                new OracleParameter("Fee",OracleDbType.Decimal,tfee.Fee,ParameterDirection.Input),
                new OracleParameter("DepartmentAmount",OracleDbType.Decimal,tfee.DeptFee,ParameterDirection.Input),
                new OracleParameter("ReffDeptAmount",OracleDbType.Decimal,tfee.RefdFee,ParameterDirection.Input),
                new OracleParameter("ReffDocAmount",OracleDbType.Decimal,tfee.DoctorFee,ParameterDirection.Input),
                new OracleParameter("Vat",OracleDbType.Decimal,tfee.VAT,ParameterDirection.Input),
                new OracleParameter("Discount",OracleDbType.Decimal,tfee.Discount,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tfee.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tfee.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tfee.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tfee.EParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateTestFee
        public short UpdateTestFee(TestFee tfee)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_TEST_FEE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TestDetailID",OracleDbType.Varchar2,6,tfee.TestSub.TestSubID,ParameterDirection.Input),
                new OracleParameter("TestMainID",OracleDbType.Varchar2,4,tfee.TestSub.TestMainID,ParameterDirection.Input),
                new OracleParameter("TestGroup",OracleDbType.Varchar2,2,tfee.TestSub.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,tfee.TestSub.TestDepartment.DepartmentID,ParameterDirection.Input),
               // new OracleParameter("Panel",OracleDbType.Varchar2,2,tfee.TestSub.PanelID,ParameterDirection.Input),
                new OracleParameter("FeeCategory",OracleDbType.Varchar2,2,tfee.FeeCategory,ParameterDirection.Input),
                new OracleParameter("Fee",OracleDbType.Decimal,tfee.Fee,ParameterDirection.Input),
                new OracleParameter("DepartmentAmount",OracleDbType.Decimal,tfee.DeptFee,ParameterDirection.Input),
                new OracleParameter("ReffDeptAmount",OracleDbType.Decimal,tfee.RefdFee,ParameterDirection.Input),
                new OracleParameter("ReffDocAmount",OracleDbType.Decimal,tfee.DoctorFee,ParameterDirection.Input),
                new OracleParameter("Vat",OracleDbType.Decimal,tfee.VAT,ParameterDirection.Input),
                new OracleParameter("Discount",OracleDbType.Decimal,tfee.Discount,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tfee.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tfee.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tfee.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tfee.EParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDiagnosticTestFee
        public short UpdateDiagnosticTestFee(TestFee tfee)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_DIAGNOSTIC_TEST_FEE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_test_main_id",OracleDbType.Varchar2,4,tfee.TestSub.TestMainID,ParameterDirection.Input),
                new OracleParameter("p_grp_id",OracleDbType.Varchar2,2,tfee.TestSub.TestGroup.GroupId,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,tfee.TestSub.TestDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_fee_cat_id",OracleDbType.Varchar2,2,tfee.FeeCategory.FeeCategoryID,ParameterDirection.Input),
                new OracleParameter("p_test_string",OracleDbType.Varchar2,2000000,tfee.TestSub.AllTest,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,tfee.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,tfee.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,tfee.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,tfee.EParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VerifyTestFee
        public int VerifyTestFee(string detail)
        {
            packageName = "PKG_DIAG_SETUP.Verify_Test_Fee";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DetailID",OracleDbType.Varchar2,4,detail,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region GetTestFee
        public List<TestFee> GetTestFee()
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_FEE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetTestFees(packageName, parameterList);
        }
        public List<TestFee> GetTestFee(string dept, string group, string main, string feeCategory)
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_FEE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,4,dept,ParameterDirection.Input),
                new OracleParameter("group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("main",OracleDbType.Varchar2,4,main,ParameterDirection.Input),
                new OracleParameter("fcat",OracleDbType.Varchar2,2,feeCategory,ParameterDirection.Input)
            };
            return GetTestFees(packageName, parameterList);
        }
        private List<TestFee> GetTestFees(string packageName, OracleParameter[] parameterList)
        {
            List<TestFee> tfees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee tsfee = new TestFee();
                tsfee.Fee = (decimal)rdr["fee"];
                tsfee.DeptFee = (decimal)rdr["dept_amt"];
                tsfee.RefdFee = (decimal)rdr["reff_dept_amt"];
                tsfee.DoctorFee = (decimal)rdr["reff_doc_amt"];
                tsfee.VAT = decimal.Parse(rdr["vat"].ToString());
                tsfee.Discount = decimal.Parse(rdr["disc"].ToString());

                FeeCategory oFeeCat = new FeeCategory();
                oFeeCat.FeeCategoryID = (string)rdr["fee_cat_id"].ToString();
                tsfee.FeeCategory = oFeeCat;

                TestSub tsObj = new TestSub();
                tsObj.TestSubID = rdr["test_det_id"].ToString();
                tsObj.TestSubTitle = rdr["TESTDETAIL"] != DBNull.Value ? (string)rdr["TESTDETAIL"] : "";
                tsObj.TestMainTitle = (string)rdr["TESTMAIN"];
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["grp_id"];
                tsObj.TestGroup = tg;
                Department dp = new Department();
                dp.DepartmentID = (string)rdr["dept_id"];
                tsObj.TestDepartment = dp;
                tsObj.PanelID = (string)rdr["pnl_id"];
                tsfee.TestSub = tsObj;

                tfees.Add(tsfee);
            }
            rdr.Close();
            return tfees;

        }
        #endregion

        #region GetAllTestByDifferentWay

        public List<TestFee> GetTestFeeGrp(string group, string detail)
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_FEE_LISTS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("Detail",OracleDbType.Varchar2,150,detail,ParameterDirection.Input)
            };

            return GetTestFeeGrps(packageName, parameterList);
        }
        public List<TestFee> GetTestFeeGrpid(string group, string detailid)
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_FEE_LIST_ID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("Detailid",OracleDbType.Varchar2,150,detailid,ParameterDirection.Input)
            };

            return GetTestFeeGrps(packageName, parameterList);
        }
        public List<TestFee> GetTestFeeGrp()
        {
            string packageName = "PKG_DIAG_SETUP.GET_ALL_TEST_FEE_LISTS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)              
            };
            return GetTestFeeGrps(packageName, parameterList);
        }
        public List<TestFee> GetAllMappingTest(string Mode,string FeeCatagory)
        {
            string packageName = "PKG_DIAG_SETUP.GET_ALL_TEST_FEE_MAPS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,5,Mode,ParameterDirection.Input),
                new OracleParameter("p_fee_cat",OracleDbType.Varchar2,3,FeeCatagory,ParameterDirection.Input)
            };
            return GetTestFeeGrps(packageName, parameterList);
        }
        public List<TestFee> GetAllMappingTestLike(string FeeCatagory,string TestDetails)
        {
            string packageName = "PKG_DIAG_SETUP.GET_ALL_TEST_FEE_MAPS_LIKE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),               
                new OracleParameter("p_fee_cat",OracleDbType.Varchar2,3,FeeCatagory,ParameterDirection.Input),
                new OracleParameter("p_test_det",OracleDbType.Varchar2,5,TestDetails,ParameterDirection.Input),
            };
            return GetTestFeeGrps(packageName, parameterList);
        }
        public List<TestFee> GetAllPackageTest(string PackageID)
        {
            string packageName = "PKG_DIAG_SETUP.GET_ALL_TEST_FEE_PACKAGE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter("p_package_id",OracleDbType.Varchar2,5,PackageID,ParameterDirection.Input),
            };
            return GetTestFeeGrps(packageName, parameterList);
        }
        private List<TestFee> GetTestFeeGrps(string packageName, OracleParameter[] parameterList)
        {

            List<TestFee> testFees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee tsfee = new TestFee();
                tsfee.Fee = (decimal)rdr["FEE"];
                tsfee.DeptFee = (decimal)rdr["dept_amt"];
                tsfee.RefdFee = (decimal)rdr["reff_dept_amt"];
                tsfee.DoctorFee = (decimal)rdr["reff_doc_amt"];
                tsfee.VAT = decimal.Parse(rdr["vat"].ToString());
                tsfee.Discount = decimal.Parse(rdr["disc"].ToString());

                FeeCategory oFeeCat = new FeeCategory();
                oFeeCat.FeeCategoryID = (string)rdr["fee_cat_id"].ToString();
                oFeeCat.FeeCategoryTitle = (string)rdr["fee_cat_title"].ToString();
                tsfee.FeeCategory = oFeeCat;

                TestSub tsObj = new TestSub();
                tsObj.TestSubID = (string)rdr["test_det_id"];
                tsObj.TestSubTitle = (string)rdr["TESTDETAIL"];
                tsObj.TestMainID = (string)rdr["test_main_id"];
                tsObj.TestMainTitle = (string)rdr["TESTMAIN"];

                Department dp = new Department();
                dp.DepartmentID = rdr["DeptCode"] != DBNull.Value ? (string)rdr["DeptCode"] : "";
                dp.DepartmentTitle = rdr["DeptName"] != DBNull.Value ?  (string)rdr["DeptName"] : "";
                tsObj.TestDepartment = dp;
                tsObj.PanelID = rdr["pnl_id"] != DBNull.Value ? (string)rdr["pnl_id"] : "";
                tsObj.PanelTitle = rdr["pnl_title"] != DBNull.Value ?  (string)rdr["pnl_title"]:"";
                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["grp_id"];
                tg.GroupTitle= (string)rdr["group_title"];
                tsObj.TestGroup = tg;
                
                ReportGroup rg = new ReportGroup();
                rg.ReportGroupID = (string)rdr["REPORT_GRP_ID"];
                tsObj.ReportGroup = rg;

                LabTechnologist lt = new LabTechnologist();
                lt.ID = "0";
                tsObj.Technologist = lt;
                SpecimenCollectionRoom rm = new SpecimenCollectionRoom();
                rm.RoomID = (string)rdr["SPC_COLL_ROOM"];
                rm.RoomTitle = rdr["spcroomtitle"] != DBNull.Value ? (string)rdr["spcroomtitle"] : "";
                tsObj.SpecimenCollectionRoom = rm;

                LabRoom oRoom = new LabRoom();
                oRoom.RoomID = (string)rdr["Lab_Room"];
                oRoom.RoomTitle = rdr["roomtitle"] != DBNull.Value ? (string)rdr["roomtitle"] : "";
                tsObj.LabRoom = oRoom;

                EntryParameter oEntry = new EntryParameter();
                oEntry.Active = rdr["Active"].ToString();
                tsfee.EParameter = oEntry;

                tsfee.TestSub = tsObj;
                testFees.Add(tsfee);
            }
            rdr.Close();
            return testFees;

        }
        #endregion

        #region GetAllTestForPackage
        public List<TestFee> GetAllTestForPackage()
        {
            string packageName = "PKG_DIAG_SETUP.GET_ALL_TEST_FOR_PACKAGE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)              
            };
            return GetAllTestForPackageDetails(packageName, parameterList);
        }
        private List<TestFee> GetAllTestForPackageDetails(string packageName, OracleParameter[] parameterList)
        {

            List<TestFee> testFees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee tsfee = new TestFee();              
                TestSub tsObj = new TestSub();
                tsObj.TestSubID = (string)rdr["test_det_id"];
                tsObj.TestSubTitle = (string)rdr["TESTDETAIL"];                            
                tsObj.PanelID = rdr["pnl_id"] != DBNull.Value ? (string)rdr["pnl_id"] : "";
                tsObj.PanelTitle = rdr["pnl_title"] != DBNull.Value ? (string)rdr["pnl_title"] : "";               
                tsfee.TestSub = tsObj;
                testFees.Add(tsfee);
            }
            rdr.Close();
            return testFees;

        }
        #endregion

        #region GetAllTest

        public List<TestFee> GetTestDet(string group, string detail)
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_FEE_LISTS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Group",OracleDbType.Varchar2,2,group,ParameterDirection.Input),
                new OracleParameter("Detail",OracleDbType.Varchar2,150,detail,ParameterDirection.Input)
            };

            return GetTestDetSetup(packageName, parameterList);
        }

        private List<TestFee> GetTestDetSetup(string packageName, OracleParameter[] parameterList)
        {

            List<TestFee> testFees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee tsfee = new TestFee();
            
                TestSub tsObj = new TestSub();
                tsObj.TestSubID = (string)rdr["test_det_id"];
                tsObj.TestSubTitle = rdr["TESTDETAIL"] != DBNull.Value ? (string)rdr["TESTDETAIL"] : "";
                tsObj.TestMainID = rdr["test_main_id"] != DBNull.Value ? (string)rdr["test_main_id"] : "";
                tsObj.TestMainTitle = rdr["TESTMAIN"] != DBNull.Value ? (string)rdr["TESTMAIN"]:"";

                Department dp = new Department();
                dp.DepartmentID = rdr["DeptCode"] != DBNull.Value ? (string)rdr["DeptCode"] : "";
                dp.DepartmentTitle = rdr["DeptName"] != DBNull.Value ? (string)rdr["DeptName"] : "";
                tsObj.TestDepartment = dp;
                tsObj.PanelID = rdr["pnl_id"] != DBNull.Value ? (string)rdr["pnl_id"] : "";
                TestGroup tg = new TestGroup();
                tg.GroupId = rdr["grp_id"] != DBNull.Value ? (string)rdr["grp_id"] : "";
                tsObj.TestGroup = tg;

                ReportGroup rg = new ReportGroup();
                rg.ReportGroupID =rdr["REPORT_GRP_ID"] != DBNull.Value ? (string)rdr["REPORT_GRP_ID"]:"";
                tsObj.ReportGroup = rg;

                LabTechnologist lt = new LabTechnologist();
                lt.ID = "0";
                tsObj.Technologist = lt;
                SpecimenCollectionRoom rm = new SpecimenCollectionRoom();
                rm.RoomID =rdr["Lab_Room"] != DBNull.Value ? (string)rdr["Lab_Room"]:"";
                rm.RoomTitle = rdr["roomtitle"] != DBNull.Value ? (string)rdr["roomtitle"] : "";
                tsObj.SpecimenCollectionRoom = rm;

                tsfee.TestSub = tsObj;
                testFees.Add(tsfee);
            }
            rdr.Close();
            return testFees;

        }

        #endregion

        #region GetFeeCategory
        public List<FeeCategory> GetFeeCats()
        {
            string packageName = "PKG_DIAG_SETUP.GET_FEE_CAT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetFeecat(packageName, parameterList);
        }
        private List<FeeCategory> GetFeecat(string packageName, OracleParameter[] parameterList)
        {
            List<FeeCategory> feeCats = new List<FeeCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                FeeCategory fcat = new FeeCategory();
                fcat.FeeCategoryID = (string)rdr[0];
                fcat.FeeCategoryTitle = (string)rdr[1];
                fcat.FeeCategoryTitleBeng = (string)rdr[2];
                fcat.FeeCategoryRemarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                feeCats.Add(fcat);
            }
            rdr.Close();
            return feeCats;
        }
        #endregion

        #region VerifyFeeCategory
        public int VerifyFeeCategory(string feecat)
        {
            packageName = "PKG_DIAG_SETUP.VERIFY_FEECATID";
            OracleParameter[] parameterList = new OracleParameter[] { 
                  new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                  new OracleParameter("FeeCat",OracleDbType.Varchar2,2,feecat,ParameterDirection.Input)
          };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveFeeCategory
        public short SaveFeeCategory(FeeCategory fcat)
        {
            string packageName = "PKG_DIAG_SETUP.INSERT_FEE_CAT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("CategoryName",OracleDbType.Varchar2,70,fcat.FeeCategoryTitle,ParameterDirection.Input),
                new OracleParameter("CategoryNameBeng",OracleDbType.Varchar2,70,fcat.FeeCategoryTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,fcat.FeeCategoryRemarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,fcat.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,fcat.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,fcat.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,fcat.EParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region UpdateFeeCategory
        public short UpdateFeeCategory(FeeCategory fecat)
        {
            string packageName = "PKG_DIAG_SETUP.UPDATE_FEE_CAT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Category ID",OracleDbType.Varchar2,2,fecat.FeeCategoryID,ParameterDirection.Input),
                new OracleParameter("Category Name",OracleDbType.Varchar2,70,fecat.FeeCategoryTitle,ParameterDirection.Input),
                new OracleParameter("Category NameBeng",OracleDbType.Varchar2,70,fecat.FeeCategoryTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,fecat.FeeCategoryRemarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,fecat.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,fecat.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,fecat.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,fecat.EParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region SaveMethodSetup
        public short SaveMethodSetup(TestMethod mac)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_METHOD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_machine_id",OracleDbType.Varchar2,3,mac.MethodID,ParameterDirection.Input),
                new OracleParameter("p_machine_Name",OracleDbType.Varchar2,500,mac.MethodTitle,ParameterDirection.Input),
                new OracleParameter("p_machine_Name_beng",OracleDbType.Varchar2,500,mac.MethodTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,mac.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mac.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mac.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,mac.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,mac.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateMethodSetup
        public short UpdateMethodSetup(TestMethod mac)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_METHOD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_machine_id",OracleDbType.Varchar2,3,mac.MethodID,ParameterDirection.Input),
                new OracleParameter("p_machine_Name",OracleDbType.Varchar2,500,mac.MethodTitle,ParameterDirection.Input),
                new OracleParameter("p_machine_Name_beng",OracleDbType.Varchar2,500,mac.MethodTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,mac.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mac.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mac.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,mac.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,mac.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetMethodSetup
        public List<TestMethod> GetMethodSetup()
        {
            string packagename = "PKG_DIAG_SETUP.GET_METHOD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetMethodSetupDetails(packagename, parameterList);
        }
        private List<TestMethod> GetMethodSetupDetails(string packagename, OracleParameter[] parameterList)
        {
            List<TestMethod> macs = new List<TestMethod>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestMethod mac = new TestMethod();
                mac.MethodID = (string)rdr["METHOD_ID"];
                mac.MethodTitle = (string)rdr["METHOD_TITLE"];
                mac.MethodTitleBeng = (string)rdr["METHOD_TITLE_BENG"];
                mac.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                macs.Add(mac);
            }
            rdr.Close();
            return macs;
        }
        #endregion

        #region SaveDiagPackageMaster
        public short SaveDiagPackageMaster(DiagPackage oDiagPackage)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_DIAG_PACKAGE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_package_id",OracleDbType.Varchar2,3,oDiagPackage.PackageID,ParameterDirection.Input),
                new OracleParameter("p_package_title",OracleDbType.Varchar2,500,oDiagPackage.PackageTitle,ParameterDirection.Input),
                new OracleParameter("p_package_title_beng",OracleDbType.Varchar2,500,oDiagPackage.PackageTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_package_amount",OracleDbType.Varchar2,200,oDiagPackage.PackageAmount,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oDiagPackage.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oDiagPackage.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oDiagPackage.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oDiagPackage.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oDiagPackage.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDiagPackageMaster
        public short UpdateDiagPackageMaster(DiagPackage oDiagPackage)
        {
            packageName = "PKG_DIAG_SETUP.UPDATE_DIAG_PACKAGE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_package_id",OracleDbType.Varchar2,3,oDiagPackage.PackageID,ParameterDirection.Input),
                new OracleParameter("p_package_title",OracleDbType.Varchar2,500,oDiagPackage.PackageTitle,ParameterDirection.Input),
                new OracleParameter("p_package_title_beng",OracleDbType.Varchar2,500,oDiagPackage.PackageTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_package_amount",OracleDbType.Varchar2,200,oDiagPackage.PackageAmount,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oDiagPackage.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oDiagPackage.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oDiagPackage.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oDiagPackage.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oDiagPackage.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetDiagPackageMaster
        public List<DiagPackage> GetDiagPackageMaster()
        {
            string packagename = "PKG_DIAG_SETUP.GET_DIAG_PACKAGE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDiagPackageMasterDetails(packagename, parameterList);
        }
        public List<TestFee> GetDiagPackageList()
        {
            string packagename = "PKG_DIAG_SETUP.GET_DIAG_PACKAGE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDiagPackageDetails(packagename, parameterList);
        }
        public List<DiagPackage> GetDiagPackageAmount(string Package)
        {
            string packagename = "PKG_DIAG_SETUP.GET_DIAG_PACKAGE_AMOUNT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_package_id",OracleDbType.Varchar2,3,Package,ParameterDirection.Input),
            };
            return GetDiagPackageMasterDetails(packagename, parameterList);
        }
        private List<DiagPackage> GetDiagPackageMasterDetails(string packagename, OracleParameter[] parameterList)
        {
            List<DiagPackage> macs = new List<DiagPackage>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                DiagPackage oDiagPackage = new DiagPackage();
                oDiagPackage.PackageID = (string)rdr["PACKAGE_ID"];
                oDiagPackage.PackageTitle = (string)rdr["PACKAGE_TITLE"];
                oDiagPackage.PackageTitleBeng = (string)rdr["PACKAGE_TITLE_BENG"];
                oDiagPackage.PackageAmount = Convert.ToDouble(rdr["PACKAGE_AMOUNT"].ToString());
                oDiagPackage.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                macs.Add(oDiagPackage);
            }
            rdr.Close();
            return macs;
        }

        private List<TestFee> GetDiagPackageDetails(string packagename, OracleParameter[] parameterList)
        {
            List<TestFee> macs = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                TestFee oTestFees = new TestFee();
                DiagPackage oDiagPackage = new DiagPackage();
                oDiagPackage.PackageID = (string)rdr["PACKAGE_ID"];
                oDiagPackage.PackageTitle = (string)rdr["PACKAGE_TITLE"];
                oDiagPackage.PackageTitleBeng = (string)rdr["PACKAGE_TITLE_BENG"];
                oDiagPackage.PackageAmount = Convert.ToDouble(rdr["PACKAGE_AMOUNT"].ToString());
                oDiagPackage.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["REMARKS"] : "";
                oTestFees.DiagPackage = oDiagPackage;
                macs.Add(oTestFees);
            }
            rdr.Close();
            return macs;
        }
        #endregion

        #region SaveDiagnosticTestFeePkg
        public short SaveDiagnosticTestFeePkg(TestFee tfee)
        {
            packageName = "PKG_DIAG_SETUP.INSERT_TEST_FEE_PKG";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_package_id",OracleDbType.Varchar2,4,tfee.DiagPackage.PackageID,ParameterDirection.Input),
                new OracleParameter("p_test_subs",OracleDbType.Varchar2,2000000,tfee.TestSub.AllTest,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,tfee.EParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,tfee.EParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,tfee.EParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,tfee.EParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetTestFeePkg      
        public List<TestFee> GetTestFeePkg(string Package)
        {
            string packageName = "PKG_DIAG_SETUP.GET_TEST_FEE_PKG";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_package_id",OracleDbType.Varchar2,4,Package,ParameterDirection.Input),               
            };
            return GetTestFeePkgDetails(packageName, parameterList);
        }
        private List<TestFee> GetTestFeePkgDetails(string packageName, OracleParameter[] parameterList)
        {
            List<TestFee> oTestFees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee oTestFee = new TestFee();
                TestSub oTestSub = new TestSub();
                DiagPackage oDiagPackage = new DiagPackage();
                oDiagPackage.PackageID = rdr["PACKAGE_ID"].ToString();
                oTestSub.TestSubID = rdr["TEST_DET_ID"].ToString();
                oTestSub.TestSubTitle = rdr["TEST_DET_TITLE"].ToString();
                oTestSub.PanelID = rdr["PNL_ID"].ToString();
                oTestSub.PosSerial = rdr["POS_SERIAL"].ToString();

                oTestFee.Fee = (decimal)rdr["fee"];
                oTestFee.DeptFee = (decimal)rdr["dept_amt"];
                oTestFee.RefdFee = (decimal)rdr["reff_dept_amt"];
                oTestFee.DoctorFee = (decimal)rdr["reff_doc_amt"];
                oTestFee.VAT = decimal.Parse(rdr["vat"].ToString());
                oTestFee.Discount = decimal.Parse(rdr["disc"].ToString());

                oTestFee.TestSub = oTestSub;

                oTestFees.Add(oTestFee);
            }
            rdr.Close();
            return oTestFees;

        }
        #endregion

       
    }
}
