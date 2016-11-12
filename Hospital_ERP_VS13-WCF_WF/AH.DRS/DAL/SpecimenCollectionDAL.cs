using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.IPDShared.MODEL;
using AH.DRS.MODEL;
using AH.DTMS.MODEL;
using AH.DMS.MODEL;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.Shared.MODEL;

namespace AH.DRS.DAL
{
    public class SpecimenCollectionDAL
    {
        string connString = Utility.GetConnectionString(Utility.Module.DRSMIS);
        string packageName = string.Empty;
        public string SaveSpecimenCollection(SpecimenCollection spcColl)
        {

            //List<TestFee> fees = new List<TestFee>();
            //string collTests = "";
            //foreach (TestFee tf in spcColl.Tests)
            //{
            //    collTests += tf.TestSub.Specimen.SpecimenID + ":" + tf.TestSub.LabRoom.RoomID + ":" + "0:" + tf.TestSub.ReportGroup.ReportGroupID + ":" + tf.TestSub.TestDepartment.DepartmentID + ":" + tf.TestSub.TestGroup.GroupId + ":" + tf.TestSub.TestMainID
            //        + ":" + tf.TestSub.TestSubID + ":" + tf.FeeCategory + ":" + tf.TestSub.PanelID + ":" + tf.TestSub.MRTestSubID + ":" + tf.TestSub.TestMethod.MethodID + ";";
            //}


            string packageName = "PKG_DRS.SAVE_SPC_COLL";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("spcCollId",OracleDbType.Varchar2,30,spcColl.SpecimenCollectionID,ParameterDirection.Output),
              new OracleParameter("hcn",OracleDbType.Varchar2,30,spcColl.Patient.HCN,ParameterDirection.Input),
              new OracleParameter("regNo",OracleDbType.Varchar2,30,spcColl.Patient.RegistrationNo,ParameterDirection.Input),
              new OracleParameter("mrNo",OracleDbType.Varchar2,30,spcColl.DiagnosticMR.MRNo,ParameterDirection.Input),
              new OracleParameter("prio",OracleDbType.Varchar2,1,spcColl.ReportPriority,ParameterDirection.Input),
              new OracleParameter("remarks",OracleDbType.Varchar2,200,spcColl.Remarks,ParameterDirection.Input),
              new OracleParameter("tests",OracleDbType.Varchar2,30000,spcColl.CollTests,ParameterDirection.Input),
              new OracleParameter("eby",OracleDbType.Varchar2,30,spcColl.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("compId",OracleDbType.Varchar2,3,spcColl.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("locId",OracleDbType.Varchar2,3,spcColl.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("macId",OracleDbType.Varchar2,20,spcColl.EntryParameter.MachineID,ParameterDirection.Input),
            };

            //OracleParameter udType = parameterList[11];
            //udType.UdtTypeName="SPC_COLLECTIONS";

            short i = DALHelper.Insert(connString, packageName, parameterList);

            OracleParameter prm = parameterList[0];
            // if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
            string specimenCollNo = (string)(OracleString)prm.Value;

            return specimenCollNo;
        }

        public SpecimenCollection GetSpecimenCollection(string spcId)
        {
            SpecimenCollection spc = new SpecimenCollection();
            string packageName = "PKG_DRS.GET_SPEC_COLL";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("SpecimenId",OracleDbType.Varchar2,30,spcId,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Specimen spec = new Specimen();
                spec.SpecimenID = (string)rdr["spc_id"];
                spec.SpecimenTitle = (string)rdr["spc_title"].ToString();
                spc.Specimen = spec;

                ReportGroup rptgr = new ReportGroup();
                rptgr.ReportGroupID = (string)rdr["rpt_grp_id"];
                spc.ReportGroup = rptgr;

                DiagnosticMR dm = new DiagnosticMR();
                dm.MRNo = (string)rdr["mr_id"];
                spc.DiagnosticMR = dm;

                InPatient pat = new InPatient();
                pat.Name = (string)rdr["pat_name"];
                pat.HCN = (string)rdr["hcn"];
                pat.DOB = (DateTime)rdr["age"];
                pat.Sex = (string)rdr["gender"];
                pat.RegistrationNo = (string)rdr["reg_id"];
                spc.Patient = pat;

            }
            return spc;
        }

        public DiagnosticReport GetSpecimenCollectionByResultID(string resultId,string test_detail_id)
        {
            DiagnosticReport oDiag = new DiagnosticReport();
            string packageName = "PKG_DRS.GET_SPEC_COLL_BY_RESULT_ID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("result_id",OracleDbType.Varchar2,30,resultId,ParameterDirection.Input),
                new OracleParameter("test_detail_id",OracleDbType.Varchar2,6,test_detail_id,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Specimen spec = new Specimen();
                spec.SpecimenID = !rdr.IsDBNull(10)?(string)rdr["SPC_COLL_ID"]:"";
                spec.SpecimenTitle = (string)rdr["Spc_Title"];
                oDiag.Specimen = spec;

                ReportGroup rptgr = new ReportGroup();
                rptgr.ReportGroupID = (string)rdr["RPT_GRP_ID"];
                oDiag.ReportGroup = rptgr;

                DiagnosticMR dm = new DiagnosticMR();
                dm.MRNo = (string)rdr["MR_ID"];
                oDiag.DiagnosticMR = dm;

                InPatient pat = new InPatient();
                pat.Name = (string)rdr["Patname"];
                pat.HCN = (string)rdr["hcn"];
                pat.DOB = (DateTime)rdr["age"];
                pat.Sex = (string)rdr["gender"];
                pat.RegistrationNo = (string)rdr["reg_id"];
                oDiag.Patient = pat;
                oDiag.IsGrowth =Convert.ToInt16(!rdr.IsDBNull(10) ?(rdr["isGrowth"] ):2);

                oDiag.Comments = !rdr.IsDBNull(11) ? (string)rdr["comments"] : "";
                //oDiag.Advice = !rdr.IsDBNull(9) ? (string)rdr["advice"] : ""; 
                

            }
            return oDiag;
        }
        public string verifySpecimenNumbers(string spcno, string deptid, string reportid)
        {
            string packageName = "PKG_DRS.VERIFY_SPECIMENNO";
            OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Result",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
               new OracleParameter("SpecimenNo",OracleDbType.Varchar2,30,spcno,ParameterDirection.Input),
               new OracleParameter("DepartmentId",OracleDbType.Varchar2,4,deptid,ParameterDirection.Input),
               new OracleParameter("ReportGroupId",OracleDbType.Varchar2,4,reportid,ParameterDirection.Input)
           };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;
        }
        public List<TestFee> GetSpcCollectedTest(string mrNo)
        {
            string packageName = "PKG_DRS.GET_SPC_COLLECTEDTEST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrNo",OracleDbType.Varchar2,30,mrNo,ParameterDirection.Input)
                //new OracleParameter("deptID",OracleDbType.Varchar2,5,deptID,ParameterDirection.Input),
                //new OracleParameter("reportGroup",OracleDbType.Varchar2,5,reportGroup,ParameterDirection.Input)
            };
            return GetSpcTest(packageName,parameterList);

        }

        public List<TestFee> GetSpcCollforCancellation(string mrNo)
        {
            string packageName = "PKG_DRS.GET_SPC_COLL_FOR_CANCL";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrNo",OracleDbType.Varchar2,30,mrNo,ParameterDirection.Input)
                //new OracleParameter("deptID",OracleDbType.Varchar2,5,deptID,ParameterDirection.Input),
                //new OracleParameter("reportGroup",OracleDbType.Varchar2,5,reportGroup,ParameterDirection.Input)
            };
            return GetSpcTest(packageName, parameterList);

        }
        private List<TestFee> GetSpcTest(string packageName, OracleParameter[] parameterList)
        {
            List<TestFee> testfees = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee pat = new TestFee();
                FeeCategory feeCat = new FeeCategory();
                feeCat.FeeCategoryID = (string)rdr[10];
                pat.FeeCategory = feeCat;

                //FeeCategory fcat = new FeeCategory();
                //fcat.FeeCategoryID = (string)rdr[10];
                //pat.FeeCategory = fcat;
                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["entry_date"];
                pat.EParameter = ep;

                TestSub tsub = new TestSub();
                tsub.TestSubID = (string)rdr[1];
                tsub.TestSubTitle = (string)rdr[2];
                tsub.LabelGroup = (string)rdr["LBL_GRP"].ToString();

                LabRoom lb = new LabRoom();
                lb.RoomID = (string)rdr[12];
                tsub.LabRoom = lb;
                tsub.PanelID = (string)rdr[13];
                tsub.PanelTitle = !rdr.IsDBNull(14) ?(string)rdr[14]:"";
                
                Department dp = new Department();
                dp.DepartmentID = (string)rdr[7];
                tsub.TestDepartment = dp;

                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr[3];
                tsub.TestGroup = tg;

                Specimen spc = new Specimen();
                spc.SpecimenID = (string)rdr[11];
                tsub.Specimen = spc;

                SpecimenHolder spcHolder = new SpecimenHolder();
                spcHolder.HolderTitle = (string)rdr["holder_title"];
                pat.SpecimenHolder = spcHolder;

                ReportGroup rptgr = new ReportGroup();
                rptgr.ReportGroupID = (string)rdr[8];
                rptgr.ReportGroupTitle = (string)rdr[9];
                tsub.ReportGroup = rptgr;


                tsub.TestMainID = (string)rdr[5];
                tsub.TestMainTitle = (string)rdr[6];
                pat.TestSub = tsub;

                testfees.Add(pat);
            }
            rdr.Close();
            return testfees;
        }


        public List<TestSub> GetSpcTestReportGroup( string spcNo,string reportGroup)
        {
            string packageName = "PKG_DRS.GET_RPT_GRP_TEST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("specID",OracleDbType.Varchar2,30,spcNo,ParameterDirection.Input),
                 new OracleParameter("RptGrp",OracleDbType.Varchar2,30,reportGroup,ParameterDirection.Input)
              };
            return GetSpcTestbyReportGroup(packageName, parameterList);

        }
        public List<TestSub> GetTestByMRID(string mrID, string reportGroup)
        {
            string packageName = "PKG_DRS.GET_TEST_BY_MR_ID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MrNo",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("RptGrp",OracleDbType.Varchar2,30,reportGroup,ParameterDirection.Input)
              };
            return GetSpcTestbyReportGroup(packageName, parameterList);

        }
        public List<TestSub> GetReportTestDetails(string mrID,string reportGroup)
        {
            string packageName = "PKG_DRS.GET_RPT_TEST_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               // new OracleParameter("specID",OracleDbType.Varchar2,30,spcNo,ParameterDirection.Input),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("RptGrp",OracleDbType.Varchar2,30,reportGroup,ParameterDirection.Input)
              };
            return GetSpcTestbyReportGroup(packageName, parameterList);

        }
        public List<TestSub> GetTestNameForVerify(string mrID, string reportGroup)
        {
            string packageName = "PKG_DRS.GET_TEST_NAME_FOR_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),          
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("RptGrp",OracleDbType.Varchar2,30,reportGroup,ParameterDirection.Input)
              };
            return GetSpcTestbyReportGroup(packageName, parameterList);

        }
        public List<TestSub> GetTestNameForFinalize(string mrID, string reportGroup)
        {
            string packageName = "PKG_DRS.GET_TEST_NAME_FOR_FINALIZE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),          
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("RptGrp",OracleDbType.Varchar2,30,reportGroup,ParameterDirection.Input)
              };
            return GetSpcTestbyReportGroup(packageName, parameterList);

        }
        private List<TestSub> GetSpcTestbyReportGroup(string packageName, OracleParameter[] parameterList)
        {
            List<TestSub> tests = new List<TestSub>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestSub tsub = new TestSub();
                tsub.TestSubTitle =  !rdr.IsDBNull(0) ?(string)rdr[0]:"";
                tsub.TestMainTitle = (string)rdr[1];
                tsub.TestSubTitleAlias = (string)rdr[2];
                tsub.TestSubID = (string)rdr[3];
               
                Specimen spcman=new Specimen ();
                spcman.SpecimenID =  !rdr.IsDBNull(4) ?(string)rdr[4]:"";
                tsub.Specimen = spcman;
                tests.Add(tsub);
            }
            rdr.Close();
            return tests;
        }
        public string verifySpecimenNo(string spcno)
        {
            string packageName = "PKG_DRS.VERIFY_SPECIMENNO";
            OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Result",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
               new OracleParameter("SpecimenNo",OracleDbType.Varchar2,30,spcno,ParameterDirection.Input),
             
           };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;
        }


        //==================================Update Sample Received By============================//
        public short UpdateSpecimenReceivedBy(SpecimenCollection spcColl)
        {                     
            string packageName = "PKG_DRS.UPDATE_SPC_SAMPLE_RECEIVED_BY";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),           
              new OracleParameter("tests",OracleDbType.Varchar2,10000,spcColl.CollTests,ParameterDirection.Input),
              new OracleParameter("eby",OracleDbType.Varchar2,30,spcColl.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("compId",OracleDbType.Varchar2,3,spcColl.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("locId",OracleDbType.Varchar2,3,spcColl.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("macId",OracleDbType.Varchar2,20,spcColl.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
          
        }
        public short CancelSpecimanCollection(SpecimenCollection spcColl)
        {
            string packageName = "PKG_DRS.Cancel_Sample_coll";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),           
              new OracleParameter("tests",OracleDbType.Varchar2,10000,spcColl.CollTests,ParameterDirection.Input),
              new OracleParameter("eby",OracleDbType.Varchar2,30,spcColl.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("compId",OracleDbType.Varchar2,3,spcColl.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("locId",OracleDbType.Varchar2,3,spcColl.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("macId",OracleDbType.Varchar2,20,spcColl.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }

        public List<SpecimenCollection> GetDiagnosticMoneyReceiptList()
        {          
            string packageName = "PKG_DRS.GET_MONEY_RECEIPT_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)              
            };
            return GetSpecimenList(packageName, parameterList);
        }

        public List<SpecimenCollection> GetSpecimenList(string deptID, string rpt_group_id)
        {
            string packageName = "PKG_DRS.GET_SPECIMEN_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)  ,
                new OracleParameter("deptID",OracleDbType.Varchar2,5,deptID,ParameterDirection.Input),
                new OracleParameter("rpt_group_id",OracleDbType.Varchar2,5,rpt_group_id,ParameterDirection.Input)                           
            };
            return GetSpecimenList(packageName, parameterList);
        }
         public List<SpecimenCollection> GetSpecimenList(string packageName, OracleParameter[] parameterList)
           {
               List<SpecimenCollection> spcs = new List<SpecimenCollection>();
               OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                SpecimenCollection spc = new SpecimenCollection();              
                spc.SpecimenCollectionID = (string)rdr["spc_coll_id"];

                DiagnosticMR dm = new DiagnosticMR();
                dm.MRNo = (string)rdr["mr_id"];
                spc.DiagnosticMR = dm;

                InPatient pat = new InPatient();
                pat.Name = (string)rdr["patname"];
                pat.HCN = (string)rdr["hcn"];            
                spc.Patient = pat;

                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["entry_date"];
                spc.EntryParameter = ep;
                spcs.Add(spc);

            }
            return spcs;
        }
         #region DMRTest
         public List<TestFee> GetDmrTestForSpc(string mrno)
         {
             string packageName = "AGH_DRS.PKG_DRS.GetDmrTestForSpc";
             OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
             return GetDMRTestDetails(packageName, parameterList);
         }
         private List<TestFee> GetDMRTestDetails(string packageName, OracleParameter[] parameterList)
         {
             List<TestFee> testfees = new List<TestFee>();
             OracleDataReader rdr;
             rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
             while (rdr.Read())
             {
                 TestFee pat = new TestFee();

                 FeeCategory feeCat = new FeeCategory();
                 feeCat.FeeCategoryID = (string)rdr["FEE_CAT_ID"];
                 pat.FeeCategory = feeCat;

                 EntryParameter ep = new EntryParameter();
                 ep.EntryDate = (DateTime)rdr["dt"];
                 pat.EParameter = ep;

                 TestSub tsub = new TestSub();
                 tsub.TestSubID = (string)rdr["TEST_DET_ID"];
                 tsub.TestSubTitle = (string)rdr["TESTDETAILS"];
                 tsub.MRTestSubID = (string)rdr["MR_Test_ID"];
                 tsub.LabelGroup = (string)rdr["LBL_GRP"].ToString();
                 LabRoom lb = new LabRoom();
                 lb.RoomID = (string)rdr["LAB_ROOM"];
                 tsub.LabRoom = lb;
                 tsub.PanelID = (string)rdr["PNL_ID"];
                 tsub.PanelTitle = rdr["PNL_TITLE"] != DBNull.Value ? rdr["PNL_TITLE"].ToString() : "";

                 Department dp = new Department();
                 dp.DepartmentID = (string)rdr["DEPT_ID"];
                 tsub.TestDepartment = dp;

                 TestGroup tg = new TestGroup();
                 tg.GroupId = (string)rdr["GROUP_ID"];
                 tsub.TestGroup = tg;

                 Specimen spc = new Specimen();
                 spc.SpecimenID = (string)rdr["SPECIMEN_ID"];
                 tsub.Specimen = spc;

                 SpecimenHolder spcHolder = new SpecimenHolder();
                 spcHolder.HolderTitle = (string)rdr["holder_title"];
                 spcHolder.HolderID = (string)rdr["HOLDER_ID"];
                 pat.SpecimenHolder = spcHolder;

                 ReportGroup rptgr = new ReportGroup();
                 rptgr.ReportGroupID = (string)rdr["RPT_GRP_ID"];
                 rptgr.ReportGroupTitle = (string)rdr["REPORTGROUP"];
                 tsub.ReportGroup = rptgr;

                 tsub.TestMainID = (string)rdr["TEST_MAIN_ID"];
                 tsub.TestMainTitle = (string)rdr["TESTNAME"];

                 TestMethod oMet = new TestMethod();
                 oMet.MethodID = (string)rdr["TEST_METHOD_ID"].ToString();
                 tsub.TestMethod = oMet;
                 
                 pat.TestSub = tsub;
                 testfees.Add(pat);
             }
             rdr.Close();
             return testfees;

         }
         #endregion
         public List<TestFee> GetEntryReportDetails(string mrno,string reportGroupID)
         {
             string packageName = "AGH_DRS.PKG_DRS_MICROBIOLOGY.GET_ENTRY_REPORT_DETAILS";
             OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input),
                 new OracleParameter("reportGroupID",OracleDbType.Varchar2,10,reportGroupID,ParameterDirection.Input)
            };
             return ReportDeatilsID(packageName, parameterList);
         }


         private List<TestFee> ReportDeatilsID(string packageName, OracleParameter[] parameterList)
         {
             List<TestFee> testfees = new List<TestFee>();
             OracleDataReader rdr;
             rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
             while (rdr.Read())
             {
                 TestFee pat = new TestFee();

                 TestSub tsub = new TestSub();
                 tsub.TestSubID = (string)rdr["TEST_DET_ID"];
                 pat.TestSub = tsub;

                 testfees.Add(pat);
             }
             rdr.Close();
             return testfees;

         }
         public List<DiagnosticReport> PatientListForLabelPrint(string mrID)
         {
             List<DiagnosticReport> oDiags = new List<DiagnosticReport>();

             string packageName = "PKG_DRS.Get_Patient_List_For_Lbl";
             OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mr_id",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),           
            };
             OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
             while (rdr.Read())
             {
                 DiagnosticReport oDiag = new DiagnosticReport();

                 ReportGroup rptgr = new ReportGroup();
                 rptgr.ReportGroupID = (string)rdr["RPT_GRP_ID"];
                 rptgr.ReportGroupTitle = (string)rdr["REPORTGROUPTITLE"];
                 oDiag.ReportGroup = rptgr;

                 DiagnosticMR dm = new DiagnosticMR();
                 dm.MRNo = (string)rdr["MR_NO"];
                 oDiag.DiagnosticMR = dm;

                 InPatient pat = new InPatient();
                 pat.Name = (string)rdr["PATNAME"];
                 pat.HCN = (string)rdr["hcn"];

                 pat.Sex = (string)rdr["GENDER"];
                 oDiag.Patient = pat;

                 EntryParameter ep = new EntryParameter();
                 ep.EntryDate = (DateTime)rdr["DATES"];
                 oDiag.EntryParameter = ep;
                 oDiag.Age = (string)rdr["AGE"];

                 oDiags.Add(oDiag);
            
             }
             return oDiags;
         }
         public string SaveSpecimenCancellation(SpecimenCollection spcColl)
         {

             //List<TestFee> fees = new List<TestFee>();
             //string collTests = "";
             //foreach (TestFee tf in spcColl.Tests)
             //{
             //    collTests += tf.TestSub.Specimen.SpecimenID + ":" + tf.TestSub.LabRoom.RoomID + ":" + "0:" + tf.TestSub.ReportGroup.ReportGroupID + ":" + tf.TestSub.TestDepartment.DepartmentID + ":" + tf.TestSub.TestGroup.GroupId + ":" + tf.TestSub.TestMainID
             //        + ":" + tf.TestSub.TestSubID + ":" + tf.FeeCategory + ":" + tf.TestSub.PanelID + ":" + tf.TestSub.MRTestSubID + ":" + tf.TestSub.TestMethod.MethodID + ";";
             //}


             string packageName = "PKG_DRS.Cancel_Sample_Cancel";
             OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("spcCollId",OracleDbType.Varchar2,30,spcColl.SpecimenCollectionID,ParameterDirection.Output),
              new OracleParameter("hcn",OracleDbType.Varchar2,30,spcColl.Patient.HCN,ParameterDirection.Input),
              new OracleParameter("regNo",OracleDbType.Varchar2,30,spcColl.Patient.RegistrationNo,ParameterDirection.Input),
              new OracleParameter("mrNo",OracleDbType.Varchar2,30,spcColl.DiagnosticMR.MRNo,ParameterDirection.Input),
              new OracleParameter("prio",OracleDbType.Varchar2,1,spcColl.ReportPriority,ParameterDirection.Input),
              new OracleParameter("remarks",OracleDbType.Varchar2,200,spcColl.Remarks,ParameterDirection.Input),
              new OracleParameter("tests",OracleDbType.Varchar2,30000,spcColl.CollTests,ParameterDirection.Input),
              new OracleParameter("eby",OracleDbType.Varchar2,30,spcColl.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("compId",OracleDbType.Varchar2,3,spcColl.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("locId",OracleDbType.Varchar2,3,spcColl.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("macId",OracleDbType.Varchar2,20,spcColl.EntryParameter.MachineID,ParameterDirection.Input),
            };

             //OracleParameter udType = parameterList[11];
             //udType.UdtTypeName="SPC_COLLECTIONS";

             short i = DALHelper.Insert(connString, packageName, parameterList);

             OracleParameter prm = parameterList[0];
             // if ((OracleDecimal)prm.Value == 1)
             //    return 1;
             //else return 0;
             string specimenCollNo = (string)(OracleString)prm.Value;

             return specimenCollNo;
         }

    }
}
