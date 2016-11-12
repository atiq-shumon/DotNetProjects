using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.DRS.MODEL;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;
using AH.DTMS.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.DMS.MODEL;

namespace AH.DRS.DAL
{
    public class DRDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.DRSMIS);

        public string SaveDiagnosticResult(DiagnosticReport dr)
        {

            //string results = "";
            //foreach (ResultHead rh in dr.heads)
            //{
            //    results += rh.Machine.MachineID+"$"+rh.ResultGroup.ResultHeadGroupID + "$" + rh.ResultHeadID + "$" + rh.ResultValue + "$"+rh.SpecimenID+"$"+rh.TestSub.TestSubID+";";
            //}


            string packageName = "PKG_DRS.SAVE_T_DR_DET_DRAFT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,7,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),                      
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        public string SaveVerifiedDiagnosticResult(DiagnosticReport dr)
        {

            //string results = "";
            //foreach (ResultHead rh in dr.heads)
            //{
            //    results += rh.Machine.MachineID + ":" + rh.ResultGroup.ResultHeadGroupID + ":" + rh.ResultHeadID + ":" + rh.ResultValue + ":" + rh.SpecimenCollectionID + ":" + rh.DraftResultID + ";";
            //}


            string packageName = "PKG_DRS.SAVE_VERIFIED_DIAG_RES";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),                     
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,1000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),      
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        public string VerifyDiagnosticResult(DiagnosticReport dr)
        {

            //string results = "";
            //foreach (DiagnosticReport rh in dr.heads)
            //{
            //    results += rh.ResultGroup.ResultHeadGroupID + ":" + rh.ResultHeadID + ":" + rh.ResultValue + ":" + rh.SpecimenCollectionID + ":" + rh.DraftResultID + ";";
            //}


            string packageName = "PKG_DRS.VERIFY_DIAG_RESULT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          // new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                          new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                          //new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          //new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          //new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("RprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),                        
                          new OracleParameter("Advice",OracleDbType.Varchar2,1000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),                         
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),                      
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return "1";
            else return "0";

        }


        public List<SpecimenCollection> GetReportListToVerify(string rptSection, string rptGroup)
        {
            string packageName = "PKG_DRS.GET_REPORT_LIST_TO_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input)

            };
            return GetUndeliv(packageName, parameterList);
        }
        public List<SpecimenCollection> GetOPDDMRToVerify(string rptSection, string rptGroup)
        {
            string packageName = "PKG_DRS.GET_OPD_DMR_FOR_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input)

            };
            return GetUndeliv(packageName, parameterList);
        }
        public List<SpecimenCollection> GetReportListToFinalised(string rptSection, string rptGroup)
        {
            string packageName = "PKG_DRS.GET_REPORT_LIST_TO_FINALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input)

            };
            return GetUndeliv(packageName, parameterList);
        }
        public List<SpecimenCollection> GetOPDDMRToFinalised(string rptSection, string rptGroup)
        {
            string packageName = "PKG_DRS.GET_OPD_DMR_TO_FINALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input)

            };
            return GetUndeliv(packageName, parameterList);
        }
        private List<SpecimenCollection> GetUndeliv(string packageName, OracleParameter[] parameterList)
        {
            List<SpecimenCollection> spc = new List<SpecimenCollection>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                SpecimenCollection coll = new SpecimenCollection();
                // coll.SpecimenCollectionID = (string)rdr[0];
                InPatient pt = new InPatient();
                pt.HCN = (string)rdr[1];
                pt.Name = (string)rdr[2];
                coll.Patient = pt;
                DiagnosticMR mr = new DiagnosticMR();
                mr.MRNo = (string)rdr[0];
                coll.DiagnosticMR = mr;
                spc.Add(coll);
            }
            rdr.Close();
            return spc;
        }
        //=============================================25-10-201====================================//

        public List<DiagnosticReport> GetResultToVerify(string mrID, string rptgr)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_RESULT_TO_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input)
            };
            return GetResultToVerify(packageName, parameterList);
        }
        public List<DiagnosticReport> GetLatestResultToVerify(string mrID, string rptgr)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_LATEST_RESULT_TO_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input)
            };
            return GetResultToVerify(packageName, parameterList);
        }
        public List<DiagnosticReport> GetStainDraftResult(string mrID, string rptgr, string testDetailsID)
        {
            string packageName = "AGH_DRS.PKG_DRS.Get_STAIN_DRAFT_RESULT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input),
                new OracleParameter("testDetailsID",OracleDbType.Varchar2,30,testDetailsID,ParameterDirection.Input)
            };
            return GetResultToVerify(packageName, parameterList);
        }
        public List<DiagnosticReport> GetResultToFinalised(string mrID, string rptgr)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_RESULT_TO_FINALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input)
            };
            return GetResultToFinalised(packageName, parameterList);
        }
        public List<DiagnosticReport> GetStainResultToFinalised(string mrID, string rptgr, string testDetailsID)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_STAIN_VERIFIED_RESLT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input),
                new OracleParameter("testDetailsID",OracleDbType.Varchar2,30,testDetailsID,ParameterDirection.Input)
            };
            return GetResultToFinalised(packageName, parameterList);
        }
        private List<DiagnosticReport> GetResultToVerify(string packageName, OracleParameter[] parameterList)
        {
            List<DiagnosticReport> oDiags = new List<DiagnosticReport>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticReport oDiag = new DiagnosticReport();

                ResultHead resHead = new ResultHead();
                resHead.ResultHeadID = !rdr.IsDBNull(0) ? (string)rdr["RES_HD_ID"] : "";
                oDiag.DraftResultID = !rdr.IsDBNull(9) ? (string)rdr["DRFT_RS_ID"] : "";

                TestSub tsub = new TestSub();
                tsub.TestSubID = !rdr.IsDBNull(11) ? (string)rdr["TEST_DET_ID"] : "";
                tsub.TestSubTitle = !rdr.IsDBNull(10) ? (string)rdr["TEST_DET_TITLE"] : "";
                resHead.TestSub = tsub;

                ResultHeadGroup hdrst = new ResultHeadGroup();
                hdrst.ResultHeadGroupID = !rdr.IsDBNull(1) ? (string)rdr["RES_HD_GRP_ID"] : "";

                resHead.ResultGroup = hdrst;
                resHead.ResultHeadTitle = !rdr.IsDBNull(2) ? (string)rdr["RES_HD_TITLE"] : "";

                resHead.ResultValue = !rdr.IsDBNull(3) ? (string)rdr["RESULT"] : "";
                Machine oMachine = new Machine();
                oMachine.MachineID = !rdr.IsDBNull(4) ? (string)rdr["machine_id"] : "";
                oMachine.MachineTitle = !rdr.IsDBNull(5) ?(string)rdr["MACHINE_TITLE"]:"";
                resHead.Machine = oMachine;
                resHead.RangeText = !rdr.IsDBNull(6) ? (string)rdr["REFF_VAL_TEXT"] : "";

                SpecimenCollection spcColl = new SpecimenCollection();
                spcColl.SpecimenCollectionID = !rdr.IsDBNull(7) ? (string)rdr["SPC_COLL_ID"] : "";
                oDiag.SpecimenCollection = spcColl;

                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["ENTRY_DATE"];
                resHead.EntryParameter = ep;

                oDiag.head = resHead;
                oDiags.Add(oDiag);
            }
            rdr.Close();
            return oDiags;
        }
        private List<DiagnosticReport> GetResultToFinalised(string packageName, OracleParameter[] parameterList)
        {

            List<DiagnosticReport> oDiags = new List<DiagnosticReport>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticReport oDiag = new DiagnosticReport();
                ResultHead resHead = new ResultHead();

                resHead.ResultHeadID = (string)rdr[0];
                oDiag.DraftResultID = (string)rdr["DRFT_RS_ID"].ToString();
                // oDiag.ResultID = (string)rdr["RESULT_ID"].ToString();


                TestSub tsub = new TestSub();
                tsub.TestSubID = !rdr.IsDBNull(12) ? (string)rdr[12] : "";
                tsub.TestSubTitle = !rdr.IsDBNull(13) ? (string)rdr[13] : "";
                resHead.TestSub = tsub;

                ResultHeadGroup hdrst = new ResultHeadGroup();
                hdrst.ResultHeadGroupID = !rdr.IsDBNull(1) ? (string)rdr[1] : "";

                resHead.ResultGroup = hdrst;
                resHead.ResultHeadTitle =!rdr.IsDBNull(2) ? (string)rdr[2]:"";

                resHead.ResultValue = !rdr.IsDBNull(3) ? (string)rdr["result"] : "";
                Machine oMachine = new Machine();
                oMachine.MachineID = !rdr.IsDBNull(4) ? (string)rdr["machine_id"] : "";
                oMachine.MachineTitle = (string)rdr["machine_title"];
                resHead.Machine = oMachine;
                resHead.RangeText = !rdr.IsDBNull(6) ? (string)rdr["reff_val_text"] : "";

                SpecimenCollection spcColl = new SpecimenCollection();
                spcColl.SpecimenCollectionID = (string)rdr["SPC_COLL_ID"];
                oDiag.SpecimenCollection = spcColl;

                oDiag.Comments = !rdr.IsDBNull(10) ? (string)rdr["COMMENTS"] : "";
                oDiag.Advice = !rdr.IsDBNull(11) ? (string)rdr["ADVICE"] : "";

                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["ENTRY_DATE"];
                resHead.EntryParameter = ep;

                oDiag.head = resHead;
                oDiags.Add(oDiag);
            }
            rdr.Close();
            return oDiags;
        }


        //======================================================01-11-2014==================================================//
        public string UpdateDiagnosticResult(DiagnosticReport dr)
        {
            string results = "";
            foreach (ResultHead rh in dr.heads)
            {
                results += rh.ResultGroup.ResultHeadGroupID + ":" + rh.ResultHeadID + ":" + rh.ResultValue + ";";
            }


            string packageName = "PKG_DRS.UPDATE_DIAG_RESULT";
            OracleParameter[] parameterList = new OracleParameter[]{
                              new OracleParameter("p_erow",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                              new OracleParameter("p_result_id",OracleDbType.Varchar2,30,dr.SpecimenCollection.result_id,ParameterDirection.Input),
                              new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.Specimen.SpecimenID,ParameterDirection.Input),
                              new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                              new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                              new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                              new OracleParameter("p_rpt_group",OracleDbType.Varchar2,30,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),
                              new OracleParameter("results",OracleDbType.Varchar2,50000,results,ParameterDirection.Input),
                              new OracleParameter("Advice",OracleDbType.Varchar2,1000,dr.Advice,ParameterDirection.Input),
                              new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),
                              new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                              new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                              new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                              new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                             };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;
        }
        public List<NursingTree> GetNursStationWiseMoneyReceipt(string nsID)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_NRS_DMR_FOR_IPD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("nsID",OracleDbType.Varchar2,4,nsID,ParameterDirection.Input)
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        public List<NursingTree> GetMRForEmergencySampleColl(string nsID)
        {
            string packageName = "AGH_DRS.PKG_DRS.MR_For_Emrg_Sample_Coll";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("nsID",OracleDbType.Varchar2,4,nsID,ParameterDirection.Input)
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        private List<NursingTree> GetNursingStationWiseMoneyReceipt(string packageName, OracleParameter[] parameterList)
        {
            List<NursingTree> oNurs = new List<NursingTree>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                NursingTree Nurs = new NursingTree();
                Nurs.NursingStationID = (string)rdr["ns_stn_id"];
                Nurs.NursingStationTitle = (string)rdr["Ns_STN_TITLE"];
                Nurs.ReqID = (string)rdr["MR_NO"];
                oNurs.Add(Nurs);
            }
            rdr.Close();
            return oNurs;
        }
        public List<NursingTree> GetNurseStatonWiseMRNoForSampleReciv(string p_tkt_type)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_NRS_MR_No_FOR_Sample_Recv";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) ,
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_tkt_type,ParameterDirection.Input)
            };
            return GetNursStationWise(packageName, parameterList);
        }
        private List<NursingTree> GetNursStationWise(string packageName, OracleParameter[] parameterList)
        {
            List<NursingTree> oNurs = new List<NursingTree>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                NursingTree Nurs = new NursingTree();
                Nurs.NursingStationID = (string)rdr["ns_stn_id"];
                Nurs.NursingStationTitle = (string)rdr["Ns_STN_TITLE"];
                Nurs.ReqID =  !rdr.IsDBNull(0)?(string)rdr["MR_ID"]:"";
                oNurs.Add(Nurs);
            }
            rdr.Close();
            return oNurs;
        }
        public List<NursingTree> GetNursStationWiseMRNoForResult(string rptGroupId, string deptId,string p_tkt_type)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_Mr_NS_Wise_NO_FOR_RESULT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("DeptId",OracleDbType.Varchar2,4,deptId,ParameterDirection.Input),
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_tkt_type,ParameterDirection.Input)
            };
            return GetNursStationWise(packageName, parameterList);
        }
        public List<NursingTree> GET_IPD_SPEC_NO_FOR_RESL_STAN(string rptGroupId, string deptId, string p_tkt_type)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_IPD_SPEC_NO_FOR_RESL_STAN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("DeptId",OracleDbType.Varchar2,4,deptId,ParameterDirection.Input)  ,
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_tkt_type,ParameterDirection.Input)
            };
            return GetNursStationWise(packageName, parameterList);
        }
        public List<NursingTree> MBioIPDNursStationWiseSpecimenNoForResult(string rptGroupId, string deptId,string p_tkt_type)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.MBIO_IPD_SPCIMEN_NO_FOR_RESLT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("DeptId",OracleDbType.Varchar2,4,deptId,ParameterDirection.Input),
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_tkt_type,ParameterDirection.Input)
            };
            return GetNursStationWise(packageName, parameterList);
        }
        public List<NursingTree> GetNurseStationMrForVerified(string rptGroupId, string rptSection,string p_ns_id)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_NSTN_MR_FOR_VERIFIED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("rptSection",OracleDbType.Varchar2,4,rptSection,ParameterDirection.Input),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_ns_id,ParameterDirection.Input)
               
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        public List<NursingTree> MBioNSTNMrForVerified(string rptGroupId, string rptSection,string p_tkt_type)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.MBIO_NSTN_DMR_FOR_VERIFIED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("rptSection",OracleDbType.Varchar2,4,rptSection,ParameterDirection.Input),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_tkt_type,ParameterDirection.Input)
               
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        public List<NursingTree> GetNurseStnWiseMrForFinalised(string rptGroupId, string rptSection, string p_ns_id)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_NSTN_MR_FOR_FINALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("rptSection",OracleDbType.Varchar2,4,rptSection,ParameterDirection.Input),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("p_ns_id",OracleDbType.Varchar2,4,p_ns_id,ParameterDirection.Input)               
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        public List<NursingTree> MBioNSTNMrForFinalised(string rptGroupId, string rptSection,string p_tkt_type)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.MBIO_NSTN_DMR_FOR_FINALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("rptSection",OracleDbType.Varchar2,4,rptSection,ParameterDirection.Input),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("p_tkt_type",OracleDbType.Varchar2,4,p_tkt_type,ParameterDirection.Input)            
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        public List<ResultHead> GetResHead(string mrID, string reportGroupID, string machineID)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_RESULT_HEAD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input) ,
                new OracleParameter("reportGroupID",OracleDbType.Varchar2,5,reportGroupID,ParameterDirection.Input),
                new OracleParameter("machineID",OracleDbType.Varchar2,10,machineID,ParameterDirection.Input)
            };
            return GetResHead(packageName, parameterList);
        }
        public List<ResultHead> GetResHeads(string mrID, string reportGroupID, string testDetailsID)
        {
            string packageName = "AGH_DRS.PKG_DRS_MICROBIOLOGY.GET_RESULT_HEAD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input) ,
                new OracleParameter("reportGroupID",OracleDbType.Varchar2,5,reportGroupID,ParameterDirection.Input),
                new OracleParameter("testDetailsID",OracleDbType.Varchar2,7,testDetailsID,ParameterDirection.Input)
            };
            return GetResHead(packageName, parameterList);
        }
        private List<ResultHead> GetResHead(string packageName, OracleParameter[] parameterList)
        {
            List<ResultHead> reshd = new List<ResultHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ResultHead reshdobj = new ResultHead();

                TestSub tsub = new TestSub();
                tsub.TestSubID = !rdr.IsDBNull(0) ? (string)rdr[0] : "";
                tsub.TestSubTitle = !rdr.IsDBNull(1) ? (string)rdr[1] : "";
                reshdobj.TestSub = tsub;

                reshdobj.ResultHeadID = (string)rdr["RES_HD_ID"].ToString();
                reshdobj.ResultHeadTitle = (string)rdr["RES_HD_TITLE"].ToString();

                ResultHeadGroup hdrst = new ResultHeadGroup();
                hdrst.ResultHeadGroupID = (string)rdr["HD_GRP_ID"].ToString();
                reshdobj.ResultGroup = hdrst;

                reshdobj.RangeText = !rdr.IsDBNull(5) ? (string)rdr["reff_val_text"] : "";

                //SpecimenCollection spc = new SpecimenCollection();
                //spc.SpecimenCollectionID = (string)rdr["SPC_COLL_ID"].ToString();
                reshdobj.SpecimenID = !rdr.IsDBNull(6) ? (string)rdr["SPC_COLL_ID"] : "";


                reshd.Add(reshdobj);
            }
            rdr.Close();
            return reshd;
        }

        public List<SpecimenCollection> OPDPendingMoneyRecipt()
        {
            string packageName = "PKG_DRS.OPD_PENDING_MR_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return OPDPendingSpecimenList(packageName, parameterList);
        }
        public List<SpecimenCollection> OPDPendingSpecimenListForResult(string rptGroupId, string deptId)
        {
            string packageName = "PKG_DRS.OPD_SPECIMEN_LIST_FOR_RESULT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("DeptId",OracleDbType.Varchar2,4,deptId,ParameterDirection.Input)
            };
            return OPDPendingSpecimenList(packageName, parameterList);
        }
        public List<SpecimenCollection> STN_OPD_SPECIMEN_LIST_RSLT(string rptGroupId, string deptId)
        {
            string packageName = "PKG_DRS.STN_OPD_SPECIMEN_LIST_RSLT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("DeptId",OracleDbType.Varchar2,4,deptId,ParameterDirection.Input)
            };
            return OPDPendingSpecimenList(packageName, parameterList);
        }
        public List<SpecimenCollection> MBioOPDPendingSpcmenLstForRslt(string rptGroupId, string deptId)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.MBIO_OPD_SPCMEN_LIST_FOR_RESLT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RptGroupId",OracleDbType.Varchar2,4,rptGroupId,ParameterDirection.Input),
                new OracleParameter("DeptId",OracleDbType.Varchar2,4,deptId,ParameterDirection.Input)
            };
            return OPDPendingSpecimenList(packageName, parameterList);
        }
        private List<SpecimenCollection> OPDPendingSpecimenList(string packageName, OracleParameter[] parameterList)
        {
            List<SpecimenCollection> spc = new List<SpecimenCollection>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                SpecimenCollection coll = new SpecimenCollection();

                DiagnosticMR mr = new DiagnosticMR();
                mr.MRNo = !rdr.IsDBNull(0) ? (string)rdr[0] : "";
                coll.DiagnosticMR = mr;
                spc.Add(coll);
            }
            rdr.Close();
            return spc;
        }
        public string SaveFinalDiagnosticResult(DiagnosticReport dr)
        {
            //string results = "";
            //foreach (ResultHead rh in dr.heads)
            //{
            //    results += rh.Machine.MachineID + ":" + rh.ResultGroup.ResultHeadGroupID + ":" + rh.ResultHeadID + ":" + rh.ResultValue + ":"+rh.SpecimenCollectionID+";";
            //}

            string packageName = "PKG_DRS.SAVE_FINAL_DIAG_RES";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                      //  new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,1000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),      
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;
            return result;

        }

        public List<DiagnosticReport> GetUpdatedVerifiedResult(string mrID, string rptgr)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_UPDATED_VERIFIED_RESULT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input)
            };
            return GetVerifiedResult(packageName, parameterList);
        }
        public List<DiagnosticReport> GetFinalisedResult(string mrID, string rptgr)
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_FINSALISED_RESULT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input)
            };
            return GetVerifiedResult(packageName, parameterList);
        }
        private List<DiagnosticReport> GetVerifiedResult(string packageName, OracleParameter[] parameterList)
        {

            List<DiagnosticReport> oDiags = new List<DiagnosticReport>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticReport oDiag = new DiagnosticReport();

                ResultHead resHead = new ResultHead();
                resHead.ResultHeadTitle = (string)rdr[1];

                resHead.ResultValue = !rdr.IsDBNull(2) ? (string)rdr["result"] : "";
                Machine oMachine = new Machine();
                oMachine.MachineTitle = (string)rdr["machine_title"];
                resHead.Machine = oMachine;

                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["dt"];
                resHead.EntryParameter = ep;
                oDiag.head = resHead;
                oDiags.Add(oDiag);
            }
            rdr.Close();
            return oDiags;
        }
        public string SaveStainResult(DiagnosticReport dr)
        {
            string packageName = "PKG_DRS.SAVE_T_DR_DET_DRAFT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),                      
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        public string STN_SAVE_T_DR_DET_DRAFT(DiagnosticReport dr)
        {
            string packageName = "PKG_DRS.STN_SAVE_T_DR_DET_DRAFT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),                      
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }

        public string SaveMicroBiologyResult(DiagnosticReport dr)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.SAVE_MICRO_BIOLOGY_DRAFT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_draft_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input), 
                          new OracleParameter("p_test_deatils_id",OracleDbType.Varchar2,7,dr.TestDetailsID,ParameterDirection.Input), 
                          new OracleParameter("p_is_growth",OracleDbType.Char,1,dr.IsGrowth,ParameterDirection.Input),
                          new OracleParameter("p_result_a",OracleDbType.Varchar2,1000,dr.GrowthResultsA,ParameterDirection.Input),
                          new OracleParameter("p_result_b",OracleDbType.Varchar2,1000,dr.GrowthResultsB,ParameterDirection.Input),
                          new OracleParameter("p_result_c",OracleDbType.Varchar2,1000,dr.GrowthResultsC,ParameterDirection.Input),
                          new OracleParameter("p_tempareture",OracleDbType.Varchar2,1000,dr.Tempareture,ParameterDirection.Input),
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,5000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),  
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        public DiagnosticReport GetNoGrowthResultToVerify(string mrID, string rptgr, string testDetailsID)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.GET_NO_GROWTH_RESULT_TO_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input),
                new OracleParameter("testDetailsID",OracleDbType.Varchar2,7,testDetailsID,ParameterDirection.Input)
            };
            return GetResult(packageName, parameterList);
        }
        public DiagnosticReport GetNoGrowthResultToFinal(string mrID, string rptgr,string testDetailsID)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.GET_NO_GROWTH_RESULT_TO_FINAL";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input),
                new OracleParameter("TestDetailsID",OracleDbType.Varchar2,10,testDetailsID,ParameterDirection.Input)
            };
            return GetResult(packageName, parameterList);
        }
        private DiagnosticReport GetResult(string packageName, OracleParameter[] parameterList)
        {

            DiagnosticReport oDiags = new DiagnosticReport();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {              
                oDiags.GrowthResultsA = (string)rdr["GROWTH_RESULT_A"];
                oDiags.Tempareture = !rdr.IsDBNull(1) ? (string)rdr["TEMPERATURE"] : "";
                oDiags.Comments = !rdr.IsDBNull(2) ? (string)rdr["COMMENTS"] : "";

            }
            rdr.Close();
            return oDiags;
        }
        public string SaveMicroBiologyVerifiedResult(DiagnosticReport dr)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.SAVE_MICRO_BIOLOGY_VERIFY_RSLT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("resultID",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                          new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input), 
                          new OracleParameter("p_testDetails_ID",OracleDbType.Varchar2,7,dr.TestDetailsID,ParameterDirection.Input), 
                          new OracleParameter("p_is_growth",OracleDbType.Char,1,dr.IsGrowth,ParameterDirection.Input),
                          new OracleParameter("p_result_a",OracleDbType.Varchar2,1000,dr.GrowthResultsA,ParameterDirection.Input),
                          new OracleParameter("p_result_b",OracleDbType.Varchar2,1000,dr.GrowthResultsB,ParameterDirection.Input),
                          new OracleParameter("p_result_c",OracleDbType.Varchar2,1000,dr.GrowthResultsC,ParameterDirection.Input),
                          new OracleParameter("p_tempareture",OracleDbType.Varchar2,1000,dr.Tempareture,ParameterDirection.Input),
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,5000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),  
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        public List<DiagnosticMR> GetMicroBioRprtLstToVerify(string rptSection, string rptGroup)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.GET_REPORT_LIST_TO_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input)

            };
            return MoneyReceiptList(packageName, parameterList);
        }
        public List<DiagnosticMR> GetMicroBioRprtLstToFinalised(string rptSection, string rptGroup)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.GET_REPORT_LIST_TO_FUNALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input)

            };
            return MoneyReceiptList(packageName, parameterList);
        }
        private List<DiagnosticMR> MoneyReceiptList(string packageName, OracleParameter[] parameterList)
        {
            List<DiagnosticMR> spc = new List<DiagnosticMR>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticMR mr = new DiagnosticMR();
                mr.MRNo = (string)rdr[0];
                spc.Add(mr);
            }
            rdr.Close();
            return spc;
        }
        public List<NursingTree> GetIPDMRList()
        {
            string packageName = "AGH_DRS.PKG_DRS.GET_IPD_MR_LIST_TO_PRINT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            
            };
            return GetNursingStationWiseMoneyReceipt(packageName, parameterList);
        }
        public string SaveMicroBiologyFinaldResult(DiagnosticReport dr)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.SAVE_MICRO_BIOLOGY_FINAL_RSLT";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_draft_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                          new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input), 
                          new OracleParameter("p_testDetails_ID",OracleDbType.Varchar2,7,dr.TestDetailsID,ParameterDirection.Input), 
                          new OracleParameter("p_is_growth",OracleDbType.Char,1,dr.IsGrowth,ParameterDirection.Input),
                          new OracleParameter("p_result_a",OracleDbType.Varchar2,1000,dr.GrowthResultsA,ParameterDirection.Input),
                          new OracleParameter("p_result_b",OracleDbType.Varchar2,1000,dr.GrowthResultsB,ParameterDirection.Input),
                          new OracleParameter("p_result_c",OracleDbType.Varchar2,1000,dr.GrowthResultsC,ParameterDirection.Input),
                          new OracleParameter("p_tempareture",OracleDbType.Varchar2,1000,dr.Tempareture,ParameterDirection.Input),
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,5000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),  
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }

        public List<SpecimenCollection> BulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
        {
            string packageName = "PKG_DRS.GET_REPORT_LIST_TO_PRINT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
                new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
                new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)

            };
            return GetReportList(packageName, parameterList);
        }

        private List<SpecimenCollection> GetReportList(string packageName, OracleParameter[] parameterList)
        {
            List<SpecimenCollection> spc = new List<SpecimenCollection>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                SpecimenCollection coll = new SpecimenCollection();
                coll.result_id = (string)rdr["Result_Id"];

                ReportGroup Rptgrp = new ReportGroup();
                Rptgrp.ReportGroupTitle = (string)rdr["ReportGroup"];
                Rptgrp.ReportGroupID = (string)rdr["RPT_GROUP"];

                ReportSection RptSec = new ReportSection();
                RptSec.ReportSectionTitle = (string)rdr["ReportSec"];
                Rptgrp.ReportSection = RptSec;
                coll.ReportGroup = Rptgrp;

                InPatient pt = new InPatient();
                pt.HCN = (string)rdr[1];
                pt.Name = (string)rdr[2];
                coll.Patient = pt;
                DiagnosticMR mr = new DiagnosticMR();
                mr.MRNo = (string)rdr[0];
                coll.DiagnosticMR = mr;
                spc.Add(coll);
            }
            rdr.Close();
            return spc;
        }

        public string UpdatePrintFlag(DiagnosticReport dr)
        {
            string packageName = "PKG_DRS.UPDATE_PRINT_FLAG";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_erows",OracleDbType.Varchar2,5,null,ParameterDirection.Output),                                           
                          new OracleParameter("result_id",OracleDbType.Varchar2,10000,dr.Results,ParameterDirection.Input),                  
                          new OracleParameter("p_update_by",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }

        public List<DiagnosticReport> GetMicroBioResultToVerify(string mrID, string rptgr, string testDetailsID)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.GET_GROWTH_RESULT_TO_VERIFY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input),
                 new OracleParameter("testDetailsID",OracleDbType.Varchar2,30,testDetailsID,ParameterDirection.Input)
            };
            return GetMicroBioResultToVerify(packageName, parameterList);
        }
        public List<DiagnosticReport> GetMicroBioResultToFinalised(string mrID, string rptgr, string specimanID,string testDeatils)
        {
            string packageName = "PKG_DRS_MICROBIOLOGY.GET_GROWTH_RESULT_TO_FINALISED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptgr,ParameterDirection.Input),
                new OracleParameter("specimanID",OracleDbType.Varchar2,30,specimanID,ParameterDirection.Input),
                new OracleParameter("TestDeatils",OracleDbType.Varchar2,30,testDeatils,ParameterDirection.Input)

            };
            return GetMicroBioResultToVerify(packageName, parameterList);
        }

        private List<DiagnosticReport> GetMicroBioResultToVerify(string packageName, OracleParameter[] parameterList)
        {

            List<DiagnosticReport> oDiags = new List<DiagnosticReport>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticReport oDiag = new DiagnosticReport();
                oDiag.DraftResultID = (string)rdr["DRFT_RS_ID"];

                SpecimenCollection spcColl = new SpecimenCollection();
                spcColl.SpecimenCollectionID = (string)rdr["SPC_COLL_ID"];
                oDiag.SpecimenCollection = spcColl;

                ResultHead resHead = new ResultHead();
                resHead.ResultHeadTitle = (string)rdr["RES_HD_TITLE"];
                resHead.ResultHeadID = (string)rdr["RES_HD_ID"];

                ResultHeadGroup hdrst = new ResultHeadGroup();
                hdrst.ResultHeadGroupID = (string)rdr["RES_HD_GRP_ID"].ToString();
                resHead.ResultGroup = hdrst;

                oDiag.GrowthResultsA = (string)rdr["GROWTH_RESULT_A"];
                oDiag.GrowthResultsB = !rdr.IsDBNull(1) ? (string)rdr["GROWTH_RESULT_B"] : "";
                oDiag.GrowthResultsC = !rdr.IsDBNull(2) ? (string)rdr["GROWTH_RESULT_C"] : "";
                oDiag.Tempareture = !rdr.IsDBNull(3) ? (string)rdr["TEMPERATURE"] : "";
                oDiag.Comments = !rdr.IsDBNull(9) ? (string)rdr["COMMENTS"] : "";
                oDiag.ResultA = (string)rdr["RESULT_A"];
                oDiag.ResultB = !rdr.IsDBNull(6) ? (string)rdr["RESULT_B"] : "";
                oDiag.ResultC = !rdr.IsDBNull(7) ? (string)rdr["RESULT_C"] : "";

                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["dt"];
                resHead.EntryParameter = ep;
                oDiag.head = resHead;
                oDiags.Add(oDiag);
            }
            rdr.Close();
            return oDiags;
        }

        public List<DiagnosticMR> GetMrListToPrint()
        {
            string packageName = "PKG_DRS.GET_MR_LIST_TO_PRINT";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)           
            };
            return GetMrListToPrint(packageName, parameterList);
        }
        private List<DiagnosticMR> GetMrListToPrint(string packageName, OracleParameter[] parameterList)
        {
            List<DiagnosticMR> oDmr = new List<DiagnosticMR>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticMR mr = new DiagnosticMR();
                mr.MRNo = (string)rdr[0];
                oDmr.Add(mr);
            }
            rdr.Close();
            return oDmr;
        }
        public List<SpecimenCollection> GetAllReport(string moneyReciptID)
        {
            string packageName = "PKG_DRS.GET_ALL_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("moneyReciptID",OracleDbType.Varchar2,30,moneyReciptID,ParameterDirection.Input)      
            };
            return GetReport(packageName, parameterList);
        }
        public List<SpecimenCollection> GetAllReportsByMRID(string moneyReciptID)
        {
            string packageName = "PKG_DRS.GET_ALL_REPORT_BY_MR_ID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("moneyReciptID",OracleDbType.Varchar2,30,moneyReciptID,ParameterDirection.Input)      
            };
            return GetReport(packageName, parameterList);
        }
        private List<SpecimenCollection> GetReport(string packageName, OracleParameter[] parameterList)
        {
            List<SpecimenCollection> spc = new List<SpecimenCollection>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                SpecimenCollection coll = new SpecimenCollection();
                coll.SpecimenCollectionID = (string)rdr["SPC_COLL_ID"];
                coll.result_id = !rdr.IsDBNull(4) ? (string)rdr["Result_Id"] : "";

                InPatient pt = new InPatient();
                pt.HCN = (string)rdr["HCN"];
                pt.Name = (string)rdr["patient_Name"];
                pt.DOB = (DateTime)rdr["age"];
                pt.Sex = (string)rdr["gender"];
                coll.Patient = pt;

                ReportGroup Rptgrp = new ReportGroup();
                Rptgrp.ReportGroupTitle = (string)rdr["ReportGroup"];
                Rptgrp.ReportGroupID = (string)rdr["RPT_GRP_ID"];

                ReportSection RptSec = new ReportSection();
                RptSec.ReportSectionTitle = (string)rdr["ReportSec"];
                Rptgrp.ReportSection = RptSec;
                coll.ReportGroup = Rptgrp;

                coll.TestTitle = (string)rdr["TEST_DET_TITLE"];
                spc.Add(coll);
            }
            rdr.Close();
            return spc;
        }

       public string SaveDiagnosResultFromMachin(string deptID, string rptSecID, string rptGrpID, string comID, string locID, string macID)       
        {
            string packageName = "PKG_DRS.Result_Save_From_Machine";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("department",OracleDbType.Varchar2,7,deptID,ParameterDirection.Input),                         
            new OracleParameter("ReprtSection",OracleDbType.Varchar2,7,rptSecID,ParameterDirection.Input),
            new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,rptGrpID,ParameterDirection.Input),
            new OracleParameter("comID",OracleDbType.Varchar2,20,comID,ParameterDirection.Input),                         
            new OracleParameter("locID",OracleDbType.Varchar2,20,locID,ParameterDirection.Input),
            new OracleParameter("macID",OracleDbType.Varchar2,20,macID,ParameterDirection.Input),                 
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
           // OracleParameter prm = parameterList[0];
            string result = "";//(string)(OracleString)prm.Value;
            return result;

        }
       public string SaveFinalDiagnosticResultPreview(DiagnosticReport dr)
       {
           string packageName = "PKG_DRS.SAVE_FINAL_RESULT_PREV";
           OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),                
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,1000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),      
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)
                         };

           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           string result = (string)(OracleString)prm.Value;
           return result;

       }
       public string SaveMicroBiologyFinaldResultPrev(DiagnosticReport dr)
       {
           string packageName = "PKG_DRS_MICROBIOLOGY.SAVE_MICRO_BIO_RSLT_PREV";
           OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_draft_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                          new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_spec_no",OracleDbType.Varchar2,30,dr.SpecimenCollection.SpecimenCollectionID,ParameterDirection.Input),
                          new OracleParameter("HCN",OracleDbType.Varchar2,30,dr.Patient.HCN,ParameterDirection.Input),
                          new OracleParameter("RegID",OracleDbType.Varchar2,30,dr.Patient.RegistrationNo,ParameterDirection.Input),
                          new OracleParameter("MrNo",OracleDbType.Varchar2,30,dr.DiagnosticMR.MRNo,ParameterDirection.Input),
                          new OracleParameter("ReprtSection",OracleDbType.Varchar2,4,dr.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                          new OracleParameter("p_rpt_group",OracleDbType.Varchar2,7,dr.ReportGroup.ReportGroupID,ParameterDirection.Input), 
                          new OracleParameter("p_testDetails_ID",OracleDbType.Varchar2,7,dr.TestDetailsID,ParameterDirection.Input), 
                          new OracleParameter("p_is_growth",OracleDbType.Char,1,dr.IsGrowth,ParameterDirection.Input),
                          new OracleParameter("p_result_a",OracleDbType.Varchar2,1000,dr.GrowthResultsA,ParameterDirection.Input),
                          new OracleParameter("p_result_b",OracleDbType.Varchar2,1000,dr.GrowthResultsB,ParameterDirection.Input),
                          new OracleParameter("p_result_c",OracleDbType.Varchar2,1000,dr.GrowthResultsC,ParameterDirection.Input),
                          new OracleParameter("p_tempareture",OracleDbType.Varchar2,1000,dr.Tempareture,ParameterDirection.Input),
                          new OracleParameter("results",OracleDbType.Varchar2,50000,dr.Results,ParameterDirection.Input),
                          new OracleParameter("Advice",OracleDbType.Varchar2,5000,dr.Advice,ParameterDirection.Input),
                          new OracleParameter("Comments",OracleDbType.Varchar2,1000,dr.Comments,ParameterDirection.Input),  
                          new OracleParameter("remarks",OracleDbType.Varchar2,7000,dr.SpecimenCollection.Remarks,ParameterDirection.Input),
                          new OracleParameter("eBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                          new OracleParameter("comp",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                          new OracleParameter("loc",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                          new OracleParameter("mac",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)

                         };


           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           string result = (string)(OracleString)prm.Value;

           return result;

       }
       public List<InvestigationReportRO> MoneyReceiptLifeCycle(string mrID)
       {
           string packageName = "AGH_DRS.Pkg_DRS.GetMoneyReceiptLifeCycle";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input)                         
            };
           return MoneyReceiptLifeCycle(packageName, parameterList);
       }
       private List<InvestigationReportRO> MoneyReceiptLifeCycle(string packageName, OracleParameter[] parameterList)
       {
           List<InvestigationReportRO> oDiags = new List<InvestigationReportRO>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               InvestigationReportRO oDRS = new InvestigationReportRO();
               oDRS.HCN = (string)rdr["HCN"].ToString();
               oDRS.RegistrationNo = (string)rdr["REG_ID"].ToString();
               oDRS.MRNo = (string)rdr["MR_ID"].ToString();
               oDRS.PatientName = (string)rdr["patient_Name"].ToString();
               oDRS.Age = (string)rdr["Age"].ToString();
               oDRS.Sex = (string)rdr["gender"].ToString();          
               oDRS.result_id = (string)rdr["RESULT_ID"].ToString();
               oDRS.ReportGroup = (string)rdr["reportGroup"].ToString();            
               oDRS.TestDetailID = (string)rdr["testName"].ToString();
               oDRS.SampleCollected = (string)(rdr["SAMPLE_COLL_BY"]).ToString();
               oDRS.SampleCollectedDate = (string)(rdr["SAMPLE_COLL_DATE"]).ToString();
               oDRS.SampleReceivedBy = (string)(rdr["SAMPLE_RECIV_BY"]).ToString();
               oDRS.SampleReceivedByDate = (string)(rdr["SAMPLE_RECIV_DATE"]).ToString();
               oDRS.SpecimenNo = (string)rdr["SAMPLE_COLL_ID"].ToString();           
               oDRS.ResultEntryBy = (string)rdr["RESULT_ENTRY_BY"].ToString();
               oDRS.ResultEntryDate = (string)rdr["RESULT_ENTRY_DATE"].ToString();
               oDRS.MREntryBy = (string)rdr["MR_COLL_BY"].ToString();
               oDRS.MREntryDate = (string)rdr["MR_COLL_DATE"].ToString();
               oDRS.VerifiedBy = (string)rdr["VERIFIED_BY"].ToString();
               oDRS.VerifiedByDate = (string)rdr["VERIFIED_DATE"].ToString();
               oDRS.EntryBy = (string)rdr["FINALIZED_BY"].ToString();
               oDRS.FinalizedDate = (string)rdr["FINALIZED_DATE"].ToString();
               oDRS.PrintedBY = (string)rdr["PRINT_BY"].ToString();
               oDRS.PrintedDate = (string)rdr["PRINT_DATE"].ToString();
               oDRS.RePrintedBY = (string)rdr["REPRINT_BY"].ToString();
               oDRS.RePrintedDate = (string)rdr["REPRINT_DATE"].ToString();
               oDRS.IsCancel = Convert.ToChar(rdr["IS_CANCEL"]);
               oDRS.CancelBy = (string)rdr["CANCEL_BY"].ToString();
          
               oDiags.Add(oDRS);
           }
           rdr.Close();
           return oDiags;
       }

    
    }
}
