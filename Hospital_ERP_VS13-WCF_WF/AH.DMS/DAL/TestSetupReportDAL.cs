
using System;
using System.Collections.Generic;
using System.Data;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using Oracle.DataAccess.Client;

namespace AH.DMS.DAL
{
    public class TestSetupReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.DMSMIS);
        string packageName = string.Empty;
        public List<TestSetupRO> GetTestDetailsReport(string DeptID, string GroupID, string MainID)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_Test_Details";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_dep_id",OracleDbType.Varchar2,30,DeptID,ParameterDirection.Input),
                new OracleParameter ("p_group_id",OracleDbType.Varchar2,30,GroupID,ParameterDirection.Input),
                new OracleParameter ("p_main_id",OracleDbType.Varchar2,30,MainID,ParameterDirection.Input) 
              };

            return GetDetailSetup(packageName, parameterList);
        }
         private List<TestSetupRO> GetDetailSetup(string packagename, OracleParameter[] parameterList)
        {
            List<TestSetupRO> detsetup = new List<TestSetupRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                TestSetupRO detobj = new TestSetupRO();
                detobj.TDetID = (string)rdr["test_det_id"].ToString();
                detobj.TestDetails = (string)rdr["test_det_title"].ToString();
                detobj.TMainID = (string)rdr["test_main_id"].ToString();
                detobj.TMainTitle = (string)rdr["TEST_MAIN_TITLE"].ToString();
                detobj.DeptID = (string)rdr["DEPT_ID"].ToString();
                detobj.DepertmentName = (string)rdr["DEPT_TITLE"].ToString();
                detobj.GroupID = (string)rdr["GRP_ID"].ToString();
                detobj.GroupTitle = (string)rdr["GROUP_TITLE"].ToString();
                detobj.ShortCode = (string)rdr["SHORT_CODE"].ToString();
                detobj.ReportGroupID = (string)rdr["REPORT_GRP_ID"].ToString();
                detobj.ReportGroupTitle = (string)rdr["GRP_TITLE"].ToString();
                detobj.LabRoom = (string)rdr["lab_room_title"].ToString();
                detobj.SpcCollRoom = (string)rdr["ROOM_TITLE"].ToString();
                detobj.SpcTitle = (string)rdr["spc_title"].ToString();
                detobj.SpcConTitle = (string)rdr["CONTAINER_TITLE"].ToString();
                detobj.SpcConQty = (string)rdr["CONTAINER_QTY"].ToString();
                detobj.TestMethodTitle = (string)rdr["METHOD_TITLE"].ToString();
                
                detsetup.Add(detobj);
            };
            rdr.Close();
            return detsetup;

        }
        public List<TestSetupRO> GetDetailsTest(string DeptID)
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.Get_Test_Details";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_dept_id",OracleDbType.Varchar2,30,DeptID,ParameterDirection.Input)
              };

            return GetTestDetailsReportDetails(packageName, parameterList);
        }
        private List<TestSetupRO> GetTestDetailsReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<TestSetupRO> rDMSs = new List<TestSetupRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDMSs = CreateObjects(reader);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDMSs;
        }

        public List<TestSetupRO> GetAllPanelTest()
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.GET_ALL_PANEL_TESTS";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)                
              };

            return GetAllPanelTestDetails(packageName, parameterList);
        }
        private List<TestSetupRO> GetAllPanelTestDetails(string packagename, OracleParameter[] parameterList)
        {
            List<TestSetupRO> detsetup = new List<TestSetupRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                TestSetupRO detobj = new TestSetupRO();
                detobj.TDetID = (string)rdr["test_det_id"].ToString();
                detobj.TestDetails = (string)rdr["TESTDETAIL"].ToString();
                detobj.TMainID = (string)rdr["test_main_id"].ToString();
                detobj.TMainTitle = (string)rdr["TESTMAIN"].ToString();
                detobj.DeptID = (string)rdr["DeptCode"].ToString();
                detobj.DepertmentName = (string)rdr["DeptName"].ToString();
                detobj.GroupID = (string)rdr["grp_id"].ToString();
                detobj.GroupTitle = (string)rdr["group_title"].ToString();                
                detobj.TestCatID = (string)rdr["TEST_CAT_ID"].ToString();                
                detsetup.Add(detobj);
            };
            rdr.Close();
            return detsetup;
        }

        #region DataReaderMappingwithNUll
        private TestSetupRO MapObject(NullHandler oReader)
        {
            TestSetupRO oDMR = new TestSetupRO();
            oDMR.TMainID = oReader.GetString("TMainID");
            oDMR.TDetID = oReader.GetString("TDetID");
            oDMR.GroupID = oReader.GetString("GroupID");
            oDMR.GroupTitle = oReader.GetString("GroupTitle");
            oDMR.DeptID = oReader.GetString("DeptID");
            oDMR.DepertmentName = oReader.GetString("DepertmentName");
            oDMR.Fee_Cat_ID = oReader.GetString("Fee_Cat_ID");
            oDMR.Cat_Title = oReader.GetString("Cat_Title");
            oDMR.TestFee = Convert.ToDouble(oReader.GetDouble("TestFee"));
            oDMR.DepartmentAmount = oReader.GetString("DepartmentAmount");
            oDMR.Reff_Dept_Amt = oReader.GetString("Reff_Dept_Amt");
            oDMR.DoctorRefAmount = oReader.GetString("DoctorRefAmount");
            oDMR.VAT = Convert.ToDouble(oReader.GetDouble("VAT"));
            oDMR.Discount = Convert.ToDouble(oReader.GetDouble("Discount"));
            oDMR.TestName = oReader.GetString("TestName");
            oDMR.TestDetails = oReader.GetString("TestDetails");
            oDMR.EntryBy = oReader.GetString("EntryBy");
            oDMR.UpdateBy = oReader.GetString("UpdateBy");
            oDMR.Update_Date = oReader.GetString("Update_Date");
            return oDMR;
        }
        private TestSetupRO CreateObject(NullHandler oReader)
        {
            TestSetupRO oDMR = new TestSetupRO();
            oDMR = MapObject(oReader);
            return oDMR;
        }

        private List<TestSetupRO> CreateObjects(IDataReader oReader)
        {
            List<TestSetupRO> rDMSs = new List<TestSetupRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                TestSetupRO oItem = CreateObject(oHandler);
                rDMSs.Add(oItem);
            }

            return rDMSs;
        }

        #endregion

        public List<TestSetupRO> GetReportPanelTest()
        {
            string packageName = "AGH_DMS.DiagnosticManagementReport.get_panel_test";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
              };

            return GetPanelTestDetails(packageName, parameterList);
        }
        private List<TestSetupRO> GetPanelTestDetails(string packagename, OracleParameter[] parameterList)
        {
            List<TestSetupRO> detsetup = new List<TestSetupRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                TestSetupRO detobj = new TestSetupRO();
                detobj.PanelId = (string)rdr["PNL_ID"].ToString();
                detobj.PanelTitle = (string)rdr["PNL_TITLE"].ToString();
                detobj.TDetID = (string)rdr["TEST_DET_ID"].ToString();
                detobj.TestDetails = (string)rdr["TEST_DET_TITLE"].ToString();               
                detsetup.Add(detobj);
            };
            rdr.Close();
            return detsetup;

        }


    }
}
