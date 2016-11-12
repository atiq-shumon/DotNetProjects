using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AH.DMS.MODEL;
using AH.DTMS.MODEL;
using AH.DTMS.DAL;
//using AH.DMS.DAL;

namespace AH.DTMS.BLL
{
    public class DiagnosticSetupBLL
    {
        public List<TestGroup> GetDiagnGrp()
        {
            return new DiagnosticSetupDAL().GetDiagnGrp();
        }
        public List<TestGroup> GetDiagnGrpTest(string department)
        {
            return new DiagnosticSetupDAL().GetDiagnGrp(department);
        }
        public Dictionary<string, string> GetDiagnGrp(string type, string department)
        {
            Dictionary<string, string> diagrs = new Dictionary<string, string>();
            foreach (TestGroup digrs in new DiagnosticSetupDAL().GetDiagnGrp(department))
            {
                diagrs.Add(digrs.GroupId, digrs.GroupTitle);
            }
            return diagrs;
        }
        public Dictionary<string, string> GetDiagnGrp(string type)
        {
            Dictionary<string, string> diagrs = new Dictionary<string, string>();
            foreach (TestGroup digrs in new DiagnosticSetupBLL().GetDiagnGrp())
            {
                diagrs.Add(digrs.GroupId, digrs.GroupTitle);
            }
            return diagrs;
        }
        public int VerifyTestFee(string detail)
        {
            return new DiagnosticSetupDAL().VerifyTestFee(detail);
        }
        public List<TestFee> GetTestFee(string dept, string group, string main, string feeCategory)
        {
            return new DiagnosticSetupDAL().GetTestFee(dept, group, main, feeCategory);
        }
        public List<TestFee> GetTestFeeGrp(string group, string detail)
        {
            return new DiagnosticSetupDAL().GetTestFeeGrp(group, detail);
        }
         public List<TestFee> GetTestFeeGrpid(string group, string detailid)
        {
            return new DiagnosticSetupDAL().GetTestFeeGrpid(group, detailid);
        }
        public int VerifyTestGroup(string groupId)
        {
            return new DiagnosticSetupDAL().VerifyTestGroup(groupId);
        }
        public short SaveTestGroup(TestGroup grp)
        {
            return new DiagnosticSetupDAL().SaveTestGroup(grp);
        }
        public short UpdateGroup(TestGroup upd)
        {
            return new DiagnosticSetupDAL().UpdateGroup(upd);
        }
        public int VerifyTestMain(string mainid)
        {
            return new DiagnosticSetupDAL().VerifyTestMain(mainid);
        }
        public short SaveTestMain(TestMain tsmain)
        {
            return new DiagnosticSetupDAL().SaveTestMain(tsmain);
        }
        public short UpdateTestMain(TestMain tmain)
        {
            return new DiagnosticSetupDAL().UpdateTestMain(tmain);
        }
        public short SaveTestPanel(GroupPanel tspanel)
        {
            return new DiagnosticSetupDAL().SaveTestPanel(tspanel);
        }
        public short UpdateTestPanel(GroupPanel tspanel)
        {
            return new DiagnosticSetupDAL().UpdateTestPanel(tspanel);
        }
        public int VerifyTestDetail(string detailid)
        {
            return new DiagnosticSetupDAL().VerifyTestDetail(detailid);
        }
        public short SaveTestDetail(TestSub tsDetail)
        {
            return new DiagnosticSetupDAL().SaveTestDetail(tsDetail);
        }
        public short UpdateTestDetail(TestSub tdtail)
        {
            return new DiagnosticSetupDAL().UpdateTestDetail(tdtail);
        }
        public short SaveTestFee(TestFee tfee)
        {
            return new DiagnosticSetupDAL().SaveTestFee(tfee);
        }
        public short UpdateTestFee(TestFee tfee)
        {
            return new DiagnosticSetupDAL().UpdateTestFee(tfee);
        }
        public short UpdateDiagnosticTestFee(TestFee tfee)
        {
            return new DiagnosticSetupDAL().UpdateDiagnosticTestFee(tfee);
        }
        public int VerifyTestCat(string catid)
        {
            return new DiagnosticSetupDAL().VerifyTestCat(catid);
        }
        public short SaveCategory(TestCategory testCat)
        {
            return new DiagnosticSetupDAL().SaveCategory(testCat);
        }
        public short UpdateCategory(TestCategory tcat)
        {
            return new DiagnosticSetupDAL().UpdateCategory(tcat);
        }
        public List<TestMain> GetTestMain()
        {
            return new DiagnosticSetupDAL().GetTestMain();
        }
        public List<TestMain> GetTestMain(string department, string group)
        {
            return new DiagnosticSetupDAL().GetTestMain(department, group);
        }

        public Dictionary<string, string> GetTestMain(string type, string department, string group)
        {
            Dictionary<string, string> tmns = new Dictionary<string, string>();
            foreach (TestMain tmain in new DiagnosticSetupDAL().GetTestMain(department, group))
            {
                tmns.Add(tmain.TestMainID, tmain.TestMainTitle);
            }
            return tmns;
        }
        public Dictionary<string, string> GetTestMain(string type)
        {
            Dictionary<string, string> tmns = new Dictionary<string, string>();
            foreach (TestMain tmain in new DiagnosticSetupBLL().GetTestMain())
            {
                tmns.Add(tmain.TestMainID, tmain.TestMainTitle);
            }
            return tmns;
        }
        public List<GroupPanel> GetPanelSetup()
        {
            return new DiagnosticSetupDAL().GetPanelSetup();
        }
        public Dictionary<string, string> GetPanelSetup(string type)
        {
            Dictionary<string, string> tpnl = new Dictionary<string, string>();
            foreach (GroupPanel pnl in new DiagnosticSetupBLL().GetPanelSetup())
            {
                tpnl.Add(pnl.PanelID, pnl.PanelTitle);
            }
            return tpnl;
        }
        public List<TestSub> GetTestDetail()
        {
            return new DiagnosticSetupDAL().GetTestDetail();
        }
        public Dictionary<string, string> GetTestDetail(string type)
        {
            Dictionary<string, string> tcats = new Dictionary<string, string>();
            foreach (TestSub tcatset in new DiagnosticSetupBLL().GetTestDetail())
            {
                tcats.Add(tcatset.TestSubID, tcatset.TestSubTitle);
            }

            return tcats;
        }
        public List<TestSub> GetTestDetails(string deptid, string group, string main)
        {
            return new DiagnosticSetupDAL().GetTestDetails(deptid, group, main);
        }
        public Dictionary<string, string> GetTestDetailsDict(string deptid,string group,string main)
        {
            Dictionary<string, string> tcats = new Dictionary<string, string>();
            foreach (TestSub tcatset in new DiagnosticSetupBLL().GetTestDetails(deptid, group, main))
            {
                tcats.Add(tcatset.TestSubID, tcatset.TestSubTitle);
            }

            return tcats;
        }
        public List<TestSub> GetUnassignTest(string deptid, string group, string main)
        {
            return new DiagnosticSetupDAL().GetUnassignTest(deptid, group, main);
        }
        public Dictionary<string, string> GetTestDetails(string type, string deptid, string group, string main)
        {
            Dictionary<string, string> tdtails = new Dictionary<string, string>();
            if (type == "D")
            {
                foreach (TestSub dtails in new DiagnosticSetupDAL().GetTestDets(deptid, group, main))
                {
                    tdtails.Add(dtails.TestSubID, dtails.TestSubTitle);
                }
            }
            if (type == "A")
            {
                foreach (TestSub dtails in new DiagnosticSetupDAL().GetUnassignTest(deptid, group, main))
                {
                    tdtails.Add(dtails.TestSubID, dtails.TestSubTitle);
                }
            }
            return tdtails;
        }
        public List<TestSub> GetTestForDetailsSetup(string Mode,string deptid, string group, string main)
        {
            return new DiagnosticSetupDAL().GetTestForDetailsSetup(Mode,deptid, group, main);
        }
        public Dictionary<string, string> GetTestDetsDict(string type, string deptid, string group, string main)
        {
            Dictionary<string, string> tdtails = new Dictionary<string, string>();
            if (type == "D")
            {
                foreach (TestSub dtails in new DiagnosticSetupDAL().GetTestDets(deptid, group, main))
                {
                    tdtails.Add(dtails.TestSubID, dtails.TestSubTitle);
                }
            }
            if (type == "A")
            {
                foreach (TestSub dtails in new DiagnosticSetupDAL().GetUnassignTest(deptid, group, main))
                {
                    tdtails.Add(dtails.TestSubID, dtails.TestSubTitle);
                }
            }
            return tdtails;
        }
        public List<TestCategory> GetCategories()
        {
            return new DiagnosticSetupDAL().GetCategories();
        }
        public Dictionary<string, string> GetCategories(string type)
        {
            Dictionary<string, string> tcats = new Dictionary<string, string>();
            foreach (TestCategory tcatset in new DiagnosticSetupBLL().GetCategories())
            {
                tcats.Add(tcatset.TestCategoryID, tcatset.TestCategoryTitle);
            }

            return tcats;
        }
        public List<TestFee> GetTestFee()
        {
            return new DiagnosticSetupDAL().GetTestFee();
        }
        public int VerifyFeeCategory(string feecat)
        {
            return new DiagnosticSetupDAL().VerifyFeeCategory(feecat);
        }
        public short SaveFeeCategory(FeeCategory fcat)
        {
            return new DiagnosticSetupDAL().SaveFeeCategory(fcat);
        }
        public short UpdateFeeCategory(FeeCategory fecat)
        {
            return new DiagnosticSetupDAL().UpdateFeeCategory(fecat);
        }
        public List<FeeCategory> GetFeeCats()
        {
            return new DiagnosticSetupDAL().GetFeeCats();
        }
        public Dictionary<string, string> GetFeecats(string type)
        {
            Dictionary<string, string> fcats = new Dictionary<string, string>();
            foreach (FeeCategory fcatset in new DiagnosticSetupBLL().GetFeeCats())
            {
                fcats.Add(fcatset.FeeCategoryID, fcatset.FeeCategoryTitle);
            }

            return fcats;
        }
        public short InsertPanelTests(TestSub oTestDetails)
        //public List<TestSub> InsertPanelTests(TestSub oTestDetails)
        {
            return new DiagnosticSetupDAL().InsertPanelTests(oTestDetails);
        }
        //public short UpdatePanelTests(TestSub oTestDetails)
        //{
        //    return new DiagnosticSetupDAL().UpdatePanelTests(oTestDetails);
        //}

        public List<TestFee> GetPanelTests(string PanelId)
        {
            return new DiagnosticSetupDAL().GetPanelTests(PanelId);
        }
        public List<TestFee> GetPanelTest(string PanelId)
        {
            return new DiagnosticSetupDAL().GetPanelTest(PanelId);
        }
        public List<TestFee> GetTestDet(string group, string detail)
        {
            return new DiagnosticSetupDAL().GetTestDet(group, detail);
        }
        public List<TestFee> GetTestUnedrPanel(string PanelId)
        {
            return new DiagnosticSetupDAL().GetTestUnedrPanel(PanelId);
        }
        public List<TestSub>GetSpcTestDetail()
        {
            return new DiagnosticSetupDAL().GetSpcTestDetail();
        }
        public short SaveMethodSetup(TestMethod mac)
        {
            return new DiagnosticSetupDAL().SaveMethodSetup(mac);
        }
        public short UpdateMethodSetup(TestMethod mac)
        {
            return new DiagnosticSetupDAL().UpdateMethodSetup(mac);
        }
         public List<TestMethod> GetMethodSetup()
        {
            return new DiagnosticSetupDAL().GetMethodSetup();
        }
         public Dictionary<string, string> GetMethod(string type)
         {
             Dictionary<string, string> fcats = new Dictionary<string, string>();
             foreach (TestMethod fcatset in new DiagnosticSetupBLL().GetMethodSetup())
             {
                 fcats.Add(fcatset.MethodID, fcatset.MethodTitle);
             }

             return fcats;
         }
         public List<TestFee> GetTestFeeGrp()
         {
             return new DiagnosticSetupDAL().GetTestFeeGrp();
         }
         public List<TestFee> GetAllMappingTest(string Mode,string FeeCatagory)
         {
             return new DiagnosticSetupDAL().GetAllMappingTest(Mode,FeeCatagory);
         }
        public List<TestSub> GetTestDets(string deptid, string group, string main)
         {
             return new DiagnosticSetupDAL().GetTestDets(deptid, group, main);
         }
        public List<TestSub> GetTestName(string deptid, string group, string main,string ReportSection,string ReportGroup)
        {
            return new DiagnosticSetupDAL().GetTestName(deptid, group, main, ReportSection, ReportGroup);
        }
        public short SaveDiagPackageMaster(DiagPackage oDiagPackage)
        {
            return new DiagnosticSetupDAL().SaveDiagPackageMaster(oDiagPackage);
        }
        public short UpdateDiagPackageMaster(DiagPackage oDiagPackage)
        {
            return new DiagnosticSetupDAL().UpdateDiagPackageMaster(oDiagPackage);
        }
        public List<DiagPackage> GetDiagPackageMaster()
        {
            return new DiagnosticSetupDAL().GetDiagPackageMaster();
        }
        public List<TestFee> GetDiagPackageList()
        {
            return new DiagnosticSetupDAL().GetDiagPackageList();
        }
        public Dictionary<string, string> GetDiagPackageDict(string type)
        {
            Dictionary<string, string> fcats = new Dictionary<string, string>();
            foreach (DiagPackage fcatset in new DiagnosticSetupBLL().GetDiagPackageMaster())
            {
                fcats.Add(fcatset.PackageID, fcatset.PackageTitle);
            }
            return fcats;
        }
        public List<DiagPackage> GetDiagPackageAmount(string Package)
        {
            return new DiagnosticSetupDAL().GetDiagPackageAmount(Package);
        }
        public List<TestFee> GetAllTestForPackage()
        {
            return new DiagnosticSetupDAL().GetAllTestForPackage();
        }
        public short SaveDiagnosticTestFeePkg(TestFee tfee)
        {
            return new DiagnosticSetupDAL().SaveDiagnosticTestFeePkg(tfee);
        }
        public List<TestFee> GetTestFeePkg(string Package)
        {
            return new DiagnosticSetupDAL().GetTestFeePkg(Package);
        }
        public List<TestFee> GetAllPackageTest(string PackageID)
        {
            return new DiagnosticSetupDAL().GetAllPackageTest(PackageID);
        }
        public List<TestFee> GetAllMappingTestLike(string FeeCatagory,string TestDetails)
        {
            return new DiagnosticSetupDAL().GetAllMappingTestLike(FeeCatagory, TestDetails);
        }
    }
}
