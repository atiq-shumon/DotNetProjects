using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DTMS.MODEL;
using AH.DTMS.DAL;

namespace AH.DTMS.BLL
{
   public class DRSetupBLL
    {
        public List<Specimen> GetSpec()
        {
            return new DRSetupDAL().GetSpec();
        }
        public Dictionary<string, string> GetSpec(string type)
        {
            Dictionary<string, string> spcset = new Dictionary<string, string>();
            foreach (Specimen spc in new DRSetupBLL().GetSpec())
            {
                spcset.Add(spc.SpecimenID, spc.SpecimenTitle);
            }
            return spcset;
        }

        public int VerifySpecSetup(string spcid)
        {
            return new DRSetupDAL().VerifySpecSetup(spcid);
        }
        public short SaveSpecsetup(Specimen spc)
        {
            return new DRSetupDAL().SaveSpecsetup(spc);
        }
        public short UpdateSpecimen(Specimen uspc)
        {
            return new DRSetupDAL().UpdateSpecimen(uspc);
        }

        public int VerifyReportGroup(string groupid)
        {
            return new DRSetupDAL().VerifyReportGroup(groupid);
        }
        public short SaveReportGr(ReportGroup reptgr)
        {
            return new DRSetupDAL().SaveReportGr(reptgr);
        }
        public short UpdateReportGr(ReportGroup urepgr)
        {
            return new DRSetupDAL().UpdateReportGr(urepgr);
        }
        public int VerifyResHdGrp(string hdgrpid)
        {
            return new DRSetupDAL().VerifyResHdGrp(hdgrpid);
        }
        public short SaveReshdGr(ResultHeadGroup reshdgrp)
        {
            return new DRSetupDAL().SaveReshdGr(reshdgrp);
        }
        public short UpdateReshdGr(ResultHeadGroup ureshdgr)
        {
            return new DRSetupDAL().UpdateReshdGr(ureshdgr);
        }
        public int VerifyResUnit(string runit)
        {
            return new DRSetupDAL().VerifyResUnit(runit);
        }
        public short SaveRshdUnit(ResultHeadUnit rshunit)
        {
            return new DRSetupDAL().SaveRshdUnit(rshunit);
        }
        public short UpdateResUnit(ResultHeadUnit ursunit)
        {
            return new DRSetupDAL().UpdateResUnit(ursunit);
        }

        public int VerifyResHd(string headId)
        {
            return new DRSetupDAL().VerifyResHd(headId);
        }
        public short SaveReshd(ResultHead reshd)
        {
            return new DRSetupDAL().SaveReshd(reshd);
        }
        public short UpdateReshd(ResultHead ureshd)
        {
            return new DRSetupDAL().UpdateReshd(ureshd);
        }
        public List<ReportGroup> GetRptgrp()
        {
            return new DRSetupDAL().GetRptgrp();
        }
        public List<ReportGroup> GetRptgrpSetup(string dept)
        {
            return new DRSetupDAL().GetRptgrpSetup(dept);
        }
       public List<ReportGroup> GetRptgrpDet(string dept,string sec)
        {
            return new DRSetupDAL().GetRptgrpDet(dept, sec);
        }
       public Dictionary<string, string> GetGrpByDeptSecDic(string dept, string sec)
       {
           Dictionary<string, string> rptgrs = new Dictionary<string, string>();
           rptgrs.Add("", "--Select--");
           foreach (ResultHeadGroup rpt in new DRSetupBLL().GetResultHeaddGrp(dept, sec))
           {
               rptgrs.Add(rpt.ResultHeadGroupID, rpt.ResultHeadGroupTitle);
           }
           return rptgrs;
       }
       public List<ReportGroup> GetRptgrpBySec(string sec)
       {
           return new DRSetupDAL().GetRptgrpBySec(sec);
       }
       public Dictionary<string, string> GetRptgrpDic(string sec)
       {
           Dictionary<string, string> rptgrs = new Dictionary<string, string>();
           rptgrs.Add("", "--Select--");
           foreach (ReportGroup rpt in new DRSetupBLL().GetRptgrpBySec(sec))
           {
               rptgrs.Add(rpt.ReportGroupID, rpt.ReportGroupTitle);
           }
           return rptgrs;
       }
        public Dictionary<string, string> GetRptgrp(string type)
        {
            Dictionary<string, string> rptgrs = new Dictionary<string, string>();
            foreach (ReportGroup rpt in new DRSetupBLL().GetRptgrp())
            {
                rptgrs.Add(rpt.ReportGroupID, rpt.ReportGroupTitle);
            }
            return rptgrs;
        }
        public Dictionary<string, string> GetRptgrpSetup(string type, string dept)
        {
            Dictionary<string, string> rptgrs = new Dictionary<string, string>();
            foreach (ReportGroup rpt in new DRSetupDAL().GetRptgrpSetup(dept))
            {
                rptgrs.Add(rpt.ReportGroupID, rpt.ReportGroupTitle);
            }
            return rptgrs;
        }
       public short SaveReportSection(ReportSection repgr)
        {
            return new DRSetupDAL().SaveReportSection(repgr);
        }

        public short UpdateReportSection(ReportSection repgr)
       {
           return new DRSetupDAL().UpdateReportSection(repgr);
       }
       public List<ReportSection> GetReportSection()
        {
            return new DRSetupDAL().GetReportSection();
        }
       public List<ReportSection> GetReportSectionSetup(string dept)
       {
           return new DRSetupDAL().GetReportSectionSetup(dept);
       }
       public Dictionary<string, string> GetRptSecSetup(string dept)
       {
           Dictionary<string, string> rptgrs = new Dictionary<string, string>();
           rptgrs.Add("", "--Select--");
           foreach (ReportSection rpt in new DRSetupDAL().GetReportSectionSetup(dept))
           {
               rptgrs.Add(rpt.ReportSectionID, rpt.ReportSectionTitle);
           }
           return rptgrs;
       }
       public Dictionary<string, string> GetRptSecDic(string type)
       {
           Dictionary<string, string> rptgrs = new Dictionary<string, string>();
           rptgrs.Add("", "--Select--");
           foreach (ReportSection rpt in new DRSetupDAL().GetReportSection())
           {
               rptgrs.Add(rpt.ReportSectionID, rpt.ReportSectionTitle);
           }
           return rptgrs;
       }
        public List<ResultHeadGroup> GetResHdGrp()
        {
            return new DRSetupDAL().GetResHdGrp();
        }
        public List<ResultHeadGroup> GetResultHeaddGrp(string Dept,string Sec)
        {
            return new DRSetupDAL().GetResultHeaddGrp(Dept, Sec);
        }
        public Dictionary<string, string> GetResHdGrp(string type)
        {
            Dictionary<string, string> reshds = new Dictionary<string, string>();
            reshds.Add("", "--Select--");
            foreach (ResultHeadGroup rshdgr in new DRSetupBLL().GetResHdGrp())
            {
                reshds.Add(rshdgr.ResultHeadGroupID, rshdgr.ResultHeadGroupTitle);
            }
            return reshds;
        }
        public List<ResultHeadUnit> GetResUnit()
        {
            return new DRSetupDAL().GetResUnit();
        }
        public Dictionary<string, string> GetResUnit(string type)
        {
            Dictionary<string, string> rsunts = new Dictionary<string, string>();
            rsunts.Add("", "--Select--");
            foreach (ResultHeadUnit runit in new DRSetupBLL().GetResUnit())
            {
                rsunts.Add(runit.UnitID, runit.UnitTitle);
            }
            return rsunts;
        }

        public List<ResultHead> GetResultHd()
        {
            return new DRSetupDAL().GetResultHd();
        }
        public List<ResultHead> GetResultHd(string reportGroup)
        {
            return new DRSetupDAL().GetResultHd(reportGroup);
        }
        public List<ResultHead> GetResultHeads(string reportGroup)
        {
            return new DRSetupDAL().GetResultHds(reportGroup);
        }
        public List<ResultHead> GetResultHdBySecGrp(string sec,string grp)
        {
            return new DRSetupDAL().GetResultHdBySecGrp(sec,grp);
        }
        public int VerifySpecHolder(string spchold)
        {
            return new DRSetupDAL().VerifySpecHolder(spchold);
        }
        public short SaveSpecHolder(SpecimenHolder spchld)
        {
            return new DRSetupDAL().SaveSpecHolder(spchld);
        }
        public short UpdateSpcHolder(SpecimenHolder usphl)
        {
            return new DRSetupDAL().UpdateSpcHolder(usphl);
        }

        public List<SpecimenHolder> GetSpecHolder()
        {
            return new DRSetupDAL().GetSpecHolder();
        }
        public List<SpecimenHolder> GetSpecimenHolder(string ColorCode)
        {
            return new DRSetupDAL().GetSpecimenHolder(ColorCode);
        }
        public Dictionary<string, string> GetSpecHolder(string type)
        {
            Dictionary<string, string> spchld = new Dictionary<string, string>();
            foreach (SpecimenHolder spech in new DRSetupBLL().GetSpecHolder())
            {
                spchld.Add(spech.HolderID, spech.HolderTitle);
            }
            return spchld;
        }
       public List<ResultHead> GetResultHdReff()
        {
            return new DRSetupDAL().GetResultHdReff();
        }
       public short SaveMachineSetup(Machine mac)
       {
           return new DRSetupDAL().SaveMachineSetup(mac);
       }
       public short UpdateMachineSetup(Machine mac)
       {
            return new DRSetupDAL().UpdateMachineSetup(mac);
       }
       public List<Machine> GetMachineSetup()
       {
           return new DRSetupDAL().GetMachineSetup();
       }
       public Dictionary<string, string> GetMacSetup(string type)
       {
           Dictionary<string, string> spcset = new Dictionary<string, string>();
           spcset.Add("", "--Select--");
           foreach (Machine spc in new DRSetupBLL().GetMachineSetup())
           {
               spcset.Add(spc.MachineID, spc.MachineTitle);
           }
           return spcset;
       }
        public short SaveQualitativeGrpSetup(Qualitative oQual)
       {
           return new DRSetupDAL().SaveQualitativeGrpSetup(oQual);
       }
       public short UpdateQualitativeGrpSetup(Qualitative oQual)
        {
            return new DRSetupDAL().UpdateQualitativeGrpSetup(oQual);
        }
        public List<Qualitative> GetQualitativeGrpSetup()
       {
           return new DRSetupDAL().GetQualitativeGrpSetup();
       }
        public Dictionary<string, string> GetQualitativeGrp(string type)
        {
            Dictionary<string, string> spcset = new Dictionary<string, string>();
            spcset.Add("", "--Select--");
            foreach (Qualitative spc in new DRSetupBLL().GetQualitativeGrpSetup())
            {
                spcset.Add(spc.GroupID, spc.GroupTitle);
            }
            return spcset;
        }
        public short SaveQualitativeGrpDetailsSetup(QualitativeDetail oQual)
        {
            return new DRSetupDAL().SaveQualitativeGrpDetailsSetup(oQual);
        }
        public short UpdateQualitativeGrpDetailsSetup(QualitativeDetail oQual)
        {
            return new DRSetupDAL().UpdateQualitativeGrpDetailsSetup(oQual);
        }
        public List<QualitativeDetail> GetQualitativeGrpDetails()
        {
            return new DRSetupDAL().GetQualitativeGrpDetails();
        }
        public List<QualitativeDetail> GetQtGrpDetails(string Group)
        {
            return new DRSetupDAL().GetQtGrpDetails(Group);
        }
        public short SaveColorCodeSetup(ColorCode oColor)
        {
            return new DRSetupDAL().SaveColorCodeSetup(oColor);
        }
        public short UpdateColorCodeSetup(ColorCode oColor)
       {
           return new DRSetupDAL().UpdateColorCodeSetup(oColor);
       }
        public List<ColorCode> GetColorCodeSetup()
       {
           return new DRSetupDAL().GetColorCodeSetup();
       }
       public Dictionary<string, string> GetColorCode(string type)
       {
           Dictionary<string, string> spcset = new Dictionary<string, string>();
           foreach (ColorCode spc in new DRSetupBLL().GetColorCodeSetup())
           {
               spcset.Add(spc.ColorID, spc.ColorTitle);
           }
           return spcset;
       }
       public List<ResultHeadRO> GetResultHdFReport(string Section, string Group)
       {
           return new DRSetupDAL().GetResultHdFReport(Section, Group);
       }
       public List<ResultHeadRO> GetResultHeadReport(string sec, string grp)
       {
           return new DRSetupDAL().GetResultHeadReport(sec, grp);
       }
       public short SaveResultHeadMapping(ResultHead reshd)
       {
           return new DRSetupDAL().SaveResultHeadMapping(reshd);
       }
        public short UpdateResultHeadMapping(ResultHead reshd)
       {
           return new DRSetupDAL().UpdateResultHeadMapping(reshd);
       }
       public List<ResultHead> GetResultHdMap(string TestDetails)
       {
           return new DRSetupDAL().GetResultHdMap(TestDetails);
       }
       public List<ResultHead> GetResultHdForMap(string TestDetails, string ReportGroup)
       {
           return new DRSetupDAL().GetResultHdForMap(TestDetails, ReportGroup);
       }
       public List<ResultHead> GetRprGrpByTest(string TestDetails)
       {
           return new DRSetupDAL().GetRprGrpByTest(TestDetails);
       }
       public List<ResultHead> GetHdByGrp(string ReportGrp)
       {
           return new DRSetupDAL().GetHdByGrp(ReportGrp);
       }
       public List<ResultHeadRO> GetReportResultHd(string TestDetails)
       {
           return new DRSetupDAL().GetReportResultHd(TestDetails);
       }
    }
}
