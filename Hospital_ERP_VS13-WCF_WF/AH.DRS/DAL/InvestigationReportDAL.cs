using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.DRS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;

namespace AH.DRS.DAL
{
    
    public class InvestigationReportDAL
    {
            int count;

            private string connstring = Utility.GetConnectionString(Utility.Module.DRSMIS);
            string packageName = string.Empty;
            #region Search
            public List<InvestigationReportRO> GetInvestigationReport(string MRNo)
            {
              
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Investigation_Report";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
            };
                return GetInvestigationReportDetails(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetInvestigationReportPreview(string MRNo,string reportSection,string reportGroup)
            {

                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Preview_Invest_Rrt";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                 new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                 new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,MRNo,ParameterDirection.Input) ,
                 new OracleParameter ("p_rpt_section",OracleDbType.Varchar2,30,reportSection,ParameterDirection.Input) ,
                 new OracleParameter ("p_ReportGroup",OracleDbType.Varchar2,30,reportGroup,ParameterDirection.Input) 
                };
                return GetInvestigationReportDetails(packageName, parameterList);
            }

            public List<InvestigationReportRO> GetBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
            {

                string packageName = "AGH_DRS.Pkg_DRS_Report.Bulk_Report_Print";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
             new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
             new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
             new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
            };
                return GetInvestigationReportDetails(packageName, parameterList);
            }
            public List<InvestigationReportRO> MBioBulkReportPrint(string rptSection, string rptGroup, string FromDate, string ToDate)
            {

                string packageName = "AGH_DRS.Pkg_DRS_Report.Bulk_Report_Print_MBio";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
             new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
             new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
             new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
            };
                return MapObject(packageName, parameterList);
            }
            private List<InvestigationReportRO> GetInvestigationReportDetails(string packageName, OracleParameter[] parameterList)
            {
                List<InvestigationReportRO> rDRSs = new List<InvestigationReportRO>();
                IDataReader reader = null;
                try
                {
                    reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                    if (reader.FieldCount > 0)
                    {
                        rDRSs = CreateObjects(reader);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return rDRSs;
            }
            
            #endregion
            #region SpecimenF:\HospitalFiles\AH.DRS\DAL\InvestigationReportDAL.cs
            public List<SpecimenRO> GetSpecimens(string SpecimenNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Specimens";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_spc_no",OracleDbType.Varchar2,300,SpecimenNo,ParameterDirection.Input) 
            };
                return GetSpecimenDetails(packageName, parameterList);
            }

            public List<SpecimenRO> GetSpecimensReprint(string mrID)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Specimens_Reprint";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("mrID",OracleDbType.Varchar2,300,mrID,ParameterDirection.Input) 
            };
                return GetSpecimenDetails(packageName, parameterList);
            }
            private List<SpecimenRO> GetSpecimenDetails(string packageName, OracleParameter[] parameterList)
            {
                List<SpecimenRO> rDRSs = new List<SpecimenRO>();
                IDataReader reader = null;
                try
                {
                    reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                    if (reader.FieldCount > 0)
                    {
                        rDRSs = CreateObjectsSpc(reader);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return rDRSs;
            }
            #endregion
            #region DataReaderMappingwithNUll
            private InvestigationReportRO MapObject(NullHandler oReader)
            {
                InvestigationReportRO oDRS = new InvestigationReportRO();
                oDRS.HCN = oReader.GetString("HCN");
                oDRS.RegistrationNo = oReader.GetString("RegistrationNo");
                oDRS.MRNo = oReader.GetString("MRNo");
                oDRS.PatientName = oReader.GetString("PatientName");
                oDRS.Age = oReader.GetString("Age");
                oDRS.Sex = oReader.GetString("Sex");
                oDRS.Address = oReader.GetString("Address");
                oDRS.MobileNo = oReader.GetString("MobileNo");
                oDRS.HomePhone = oReader.GetString("HomePhone");
                oDRS.result_id = oReader.GetString("result_id");
                oDRS.SpecimenNo = oReader.GetString("SpecimenNo");
                oDRS.Doctorname = oReader.GetString("Doctorname");
                oDRS.UnitName = oReader.GetString("UnitName");
                oDRS.DepartmentName = oReader.GetString("DepartmentName");      
                oDRS.BedNo = oReader.GetString("BedNo");
                oDRS.ReportType = oReader.GetString("comments_title");
                oDRS.ReportGroup = oReader.GetString("ReportGroup");
                oDRS.DMAdvice = oReader.GetString("DMAdvice");
                if (oDRS.DMAdvice.Length > 0)
                {
                    oDRS.DMAdvice = oReader.GetString("DMAdvice").ToString().Replace("\\r\\n", Environment.NewLine);
                }
                oDRS.DMComments = oReader.GetString("DMComments");
                if (oDRS.DMComments.Length > 0)
                {
                    oDRS.DMComments = oReader.GetString("DMComments").ToString().Replace("\\r\\n", Environment.NewLine);
                }
                oDRS.DMRemarks = oReader.GetString("DMRemarks");
                oDRS.SampleDate = oReader.GetDateTime("SampleDate").ToString("dd MM yyyy");
                if (oDRS.ReportGroup == "Stain Report")
                {
                    oDRS.DDResult = oReader.GetString("DDResult").Replace("\\r\\n", Environment.NewLine);
                }
                else
                {
                    oDRS.DDResult = oReader.GetString("DDResult");
                }               
                oDRS.DDRemarks = oReader.GetString("DDRemarks");
                oDRS.HDGroup = oReader.GetString("HDGroup");
                oDRS.HDTitle = oReader.GetString("HDTitle");
                oDRS.HDRefValue = oReader.GetString("HDRefValue");
                oDRS.HDSerial = oReader.GetString("HDSerial");
                oDRS.HDUnit = oReader.GetString("HDUnit");
                oDRS.MachineTitle = oReader.GetString("Machine_Title");
                oDRS.VerifiedBy = oReader.GetString("Verified_by");
                oDRS.EntryBy = oReader.GetString("entry_by");
                oDRS.TicketType = oReader.GetString("ticket_type");         
                oDRS.Specimen = oReader.GetString("SPECIMEN");        
                oDRS.ReportSection = oReader.GetString("RrptSection");
                oDRS.TestMethodTitle = oReader.GetString("test_method_title");
                oDRS.IsInterpretation = oReader.GetChar("IS_INTERPRETATION");
                oDRS.InterpretationText = oReader.GetString("INTERPERTATION_TEXT");
                oDRS.SampleCollected = oReader.GetString("SAMPLECOLLECTEDBY");
                oDRS.SampleCollectedDate = oReader.GetString("SAMPLECOLLECTEDDATE");
                oDRS.SampleReceivedBy = oReader.GetString("SAMPLERECEIVEDBY");
                oDRS.SampleReceivedByDate = oReader.GetString("SAMPLERECEIVEDDATE");
                oDRS.VerifiedByDesignation = oReader.GetString("VERIFIED_BY_DESIG");
                oDRS.FinalizeByDesignation = oReader.GetString("FINALISED_BY_DESIG");
                oDRS.IsPrint = oReader.GetString("IS_PRINTED");
                oDRS.VerifiedByDate = oReader.GetString("VERIFIED_DATE");
                oDRS.FinalizedDate = oReader.GetString("FINALISED_DATE");
                //oDRS.serial = oReader.GetString("SERIAL");
            
                return oDRS;
            }
            private InvestigationReportRO CreateObject(NullHandler oReader)
            {
                InvestigationReportRO oDRS = new InvestigationReportRO();
                oDRS = MapObject(oReader);
                return oDRS;
            }
            private List<InvestigationReportRO> CreateObjects(IDataReader oReader)
            {
                List<InvestigationReportRO> rDRSs = new List<InvestigationReportRO>();
                NullHandler oHandler = new NullHandler(oReader);
                while (oReader.Read())
                {
                    InvestigationReportRO oItem = CreateObject(oHandler);
                    rDRSs.Add(oItem);
                }
                return rDRSs;
            }

           
            #endregion

            #region Specimen
            private SpecimenRO MapObjectSpc(NullHandler oReader)
            {
                SpecimenRO oDRS = new SpecimenRO();          
                oDRS.SPC_COLL_ID = oReader.GetString("SPC_COLL_ID");
               // oDRS.SPC_ID = oReader.GetString("SPC_ID");
               // oDRS.HCN = oReader.GetString("HCN");
                oDRS.PatientName = oReader.GetString("PatientName");
                oDRS.MR_ID = oReader.GetString("MR_ID");
                oDRS.Sex = oReader.GetString("Sex");
               // oDRS.Grp_Title = oReader.GetString("Grp_Title");
               // oDRS.Test_Main_Title = oReader.GetString("Test_Main_Title");
               // oDRS.Test_Det_Title = oReader.GetString("Test_Det_Title");
                oDRS.TestDate = oReader.GetDateTime("TestDate").ToString("dd MMM yyyy hh:mm");
              //  oDRS.TestDate = oReader.GetString("TestDate");
               // oDRS.Room_Title = oReader.GetString("Room_Title");
               // oDRS.CELL_PHONE = oReader.GetString("CELL_PHONE");
                oDRS.ShortCode = oReader.GetString("short_code");
             //   oDRS.TestDetailId = oReader.GetString("TEST_DET_ID");
                return oDRS;
            }
            private SpecimenRO CreateObjectSpc(NullHandler oReader)
            {
                SpecimenRO oDRS = new SpecimenRO();
                oDRS = MapObjectSpc(oReader);
                return oDRS;
            }
            private List<SpecimenRO> CreateObjectsSpc(IDataReader oReader)
            {
                List<SpecimenRO> rDRSs = new List<SpecimenRO>();
                NullHandler oHandler = new NullHandler(oReader);
                while (oReader.Read())
                {
                    SpecimenRO oItem = CreateObjectSpc(oHandler);
                    rDRSs.Add(oItem);
                }
                return rDRSs;
            }
            #endregion
            public List<InvestigationReportRO> GetMicroBioReport(string MRNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Micro_Bio_Report";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
               int cnt= GetMicroBioResCnt(MRNo);
                return MapObject(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultA(string MRNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultA";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultAA(string MRNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultAA";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultBB(string MRNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultBB";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultB(string MRNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultB";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultC(string MRNo)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultC";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
           
            public int GetMicroBioResCnt(string MRNo)
            {
                count = 0;
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Micro_Bio_Rpt_Cnt";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,MRNo,ParameterDirection.Input) 
                 };
                 OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    count = Convert.ToInt32(!rdr.IsDBNull(0) ? (rdr["count"]) : 1);                 
                }
                return count;
            }
           
            private List<InvestigationReportRO> MapObject(string packageName, OracleParameter[] parameterList)
            {             
                List<InvestigationReportRO> oDiags = new List<InvestigationReportRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {                
                    InvestigationReportRO oDRS = new InvestigationReportRO();
                    oDRS.HCN = (string)rdr["HCN"];

                    oDRS.RegistrationNo =  (string)rdr["RegistrationNo"];
                    oDRS.MRNo = (string)rdr["MRNo"];
                    oDRS.PatientName =  (string)rdr["PatientName"];
                    oDRS.Age = (string)rdr["Age"];
                    oDRS.Sex =  (string)rdr["Sex"];
                    oDRS.Address = (string)rdr["Address"];
                    oDRS.MobileNo = (string)rdr["MobileNo"];
                    oDRS.HomePhone =  (string)rdr["HomePhone"].ToString();
                    oDRS.result_id =  (string)rdr["result_id"];
                  //  oDRS.SpecimenNo = (string)rdr["SpecimenNo"];
                    oDRS.Doctorname = (string)rdr["Doctorname"].ToString();
                    oDRS.UnitName =!rdr.IsDBNull(15)?(string)rdr["UnitName"]:"";
                    oDRS.DepartmentName =  (string)rdr["DepartmentName"].ToString();
                    oDRS.BedNo =  (string)rdr["BedNo"].ToString();
                    oDRS.ReportType =  (string)rdr["comments_title"].ToString();
                    oDRS.ReportGroup = (string)rdr["ReportGroup"].ToString() ;
                    oDRS.DMAdvice = (string)rdr["DMAdvice"].ToString();
                    if (oDRS.DMAdvice.Length> 0)
                    {
                        oDRS.DMAdvice = (string)rdr["DMAdvice"].ToString().Replace("\\r\\n", Environment.NewLine);
                    }
                    oDRS.DMComments = (string)rdr["DMComments"].ToString();
                    if (oDRS.DMComments.Length>0)
                    {
                         oDRS.DMComments = (string)rdr["DMComments"].ToString().Replace("\\r\\n", Environment.NewLine);
                    }
                    oDRS.DMRemarks = (string)rdr["DMRemarks"].ToString();
                    oDRS.SampleDate = (string)rdr["SampleDate"].ToString();
                    oDRS.HDTitle = !rdr.IsDBNull(34)?(string)rdr["RES_HD_TITLE"]:"";
               
                    oDRS.GrowthResultA = Utility.GetStringPart((string)rdr["GROWTH_RESULT_A"].ToString().Replace("\\r\\n", Environment.NewLine), "~");
                    oDRS.PowerA = Utility.GetStringPart((string)rdr["GROWTH_RESULT_A"].ToString().Replace("\\r\\n", Environment.NewLine), "~", true);

                    oDRS.GrowthResultB = (string)rdr["GROWTH_RESULT_B"].ToString();
                    if (oDRS.GrowthResultB.Length > 0)
                    {
                        oDRS.GrowthResultB = Utility.GetStringPart((string)rdr["GROWTH_RESULT_B"].ToString().Replace("\\r\\n", Environment.NewLine), "~");
                        oDRS.PowerB = Utility.GetStringPart((string)rdr["GROWTH_RESULT_B"].ToString().Replace("\\r\\n", Environment.NewLine), "~", true);
                    }
                    oDRS.GrowthResultC = (string)rdr["GROWTH_RESULT_C"].ToString();
                    if (oDRS.GrowthResultC.Length > 0)
                    {
                        oDRS.GrowthResultC = Utility.GetStringPart((string)rdr["GROWTH_RESULT_C"].ToString().Replace("\\r\\n", Environment.NewLine), "~");
                        oDRS.PowerC = Utility.GetStringPart((string)rdr["GROWTH_RESULT_C"].ToString().Replace("\\r\\n", Environment.NewLine), "~", true);
                    }
                    oDRS.Temperature =  !rdr.IsDBNull(26)?(string)rdr["TEMPERATURE"].ToString().Replace("\\r\\n", Environment.NewLine):"";
                    //oDRS.GrowthResultC = (string)rdr["GROWTH_RESULT_C"].ToString().Replace("\\r\\n", Environment.NewLine);
                    if (oDRS.Temperature.Length > 0)
                    {
                       // oDRS.Temperature = (string)rdr["TEMPERATURE"].ToString().Replace("\\r\\n", Environment.NewLine);
                        oDRS.Temperature = Utility.GetStringPart((string)rdr["TEMPERATURE"].ToString(), "+");
                        string var = Utility.GetStringPart((string)rdr["TEMPERATURE"].ToString(), "+", false);
                        if (var.Length != 0)
                        {
                            oDRS.Hour = Utility.GetStringPart(var, "+");
                            oDRS.dayHours = Utility.GetStringPart(var, "+", true);
                        }
                    }
                  
                    oDRS.ResultA =!rdr.IsDBNull(31)? (string)rdr["RESULT_A"]:"";
                    oDRS.ResultB =!rdr.IsDBNull(32)? (string)rdr["RESULT_B"]:"";
                    oDRS.ResultC = !rdr.IsDBNull(33)?(string)rdr["RESULT_C"]:"";
                   
                    oDRS.VerifiedBy =  (string)rdr["Verified_by"].ToString();
                    oDRS.EntryBy =  (string)rdr["entry_by"].ToString();
                    oDRS.TicketType = (string)rdr["ticket_type"].ToString();            
                    oDRS.Specimen = (string)rdr["SPECIMEN"].ToString();            
                    oDRS.ReportSection =  (string)rdr["RrptSection"].ToString();
                    oDRS.TestMethodTitle = (string)rdr["test_method_title"].ToString();
                    oDRS.IsGrowth = (string)(rdr["IS_GROWTH"]).ToString();
                    oDRS.SampleCollected = (string)(rdr["SAMPLECOLLECTEDBY"]).ToString();
                    oDRS.SampleCollectedDate = (string)(rdr["SAMPLECOLLECTEDDATE"]).ToString();
                    oDRS.SampleReceivedBy = (string)(rdr["SAMPLERECEIVEDBY"]).ToString();
                    oDRS.SampleReceivedByDate = (string)(rdr["SAMPLERECEIVEDDATE"]).ToString();
                    oDRS.VerifiedByDesignation = (string)(rdr["VERIFIED_BY_DESIG"]).ToString();
                    oDRS.FinalizeByDesignation = (string)(rdr["FINALISED_BY_DESIG"]).ToString();
                    oDRS.VerifiedByDate = (string)(rdr["VERIFIED_DATE"]).ToString();
                    oDRS.FinalizedDate = (string)(rdr["FINALISED_DATE"]).ToString();
                    oDRS.count = count;
                    oDiags.Add(oDRS);
                }
                rdr.Close();
                return oDiags;
            }
            public List<InvestigationReportRO> GetWorkSheet(string mrID, string reportSectionID)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_WorkSheet";
                OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input) ,
                new OracleParameter("reportSectionID",OracleDbType.Varchar2,5,reportSectionID,ParameterDirection.Input)             
            };
                return GetWorkSheet(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetWorkSheetForUI(string reportSectionID,string mrID)
            {
                string packageName = "AGH_DRS.Pkg_DRS.Get_WorkSheet";
                OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),             
                new OracleParameter("reportSectionID",OracleDbType.Varchar2,5,reportSectionID,ParameterDirection.Input),
                new OracleParameter("mrID",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input)  
            };
                return GetWorkSheet(packageName, parameterList);
            }      
            private List<InvestigationReportRO> GetWorkSheet(string packageName, OracleParameter[] parameterList)
            {
                List<InvestigationReportRO> oDiags = new List<InvestigationReportRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    InvestigationReportRO oDRS = new InvestigationReportRO();
                    oDRS.HCN = (string)rdr["HCN"].ToString();
                    oDRS.RegistrationNo = (string)rdr["RegistrationNo"].ToString();
                    oDRS.MRNo = (string)rdr["MRNo"].ToString();
                    oDRS.PatientName = (string)rdr["PATIENTNAME"];
                    oDRS.Age = (string)rdr["Age"].ToString();
                    oDRS.Sex = (string)rdr["Sex"].ToString();
                    oDRS.MobileNo = (string)rdr["MOBILENO"].ToString();                         
                    oDRS.Doctorname = (string)rdr["Doctorname"].ToString();
                    oDRS.UnitName = (string)rdr["UnitName"].ToString();
                    oDRS.DepartmentName = (string)rdr["DepartmentName"].ToString();
                    oDRS.BedNo = (string)rdr["BedNo"].ToString();
                    oDRS.ReportSection = (string)rdr["RRPTSECTION"].ToString();
                    oDRS.ReportGroup = (string)rdr["REPORTGROUP"].ToString();
                    oDRS.Specimen = (string)rdr["SPECIMEN"].ToString();
                    oDRS.TicketType = (string)rdr["TICKET_TYPE"].ToString();
                    oDRS.TestDetailID = (string)rdr["TESTNAME"].ToString();
                    oDRS.SampleCollected = (string)(rdr["SAMPLECOLLECTEDBY"]).ToString();
                    oDRS.SampleCollectedDate = (string)(rdr["SAMPLECOLLECTEDDATE"]).ToString();
                    oDRS.SampleReceivedBy = (string)(rdr["SAMPLERECEIVEDBY"]).ToString();
                    oDRS.SampleReceivedByDate = (string)(rdr["SAMPLERECEIVEDDATE"]).ToString();
                    oDRS.SpecimenNo = (string)rdr["SAMPLE_ID"].ToString();
                    oDRS.Priority = (string)rdr["CAT_TITLE"].ToString();
                    oDRS.ReportSectionID = (string)rdr["reportSectionID"].ToString();
                    oDiags.Add(oDRS);
                }
                rdr.Close();
                return oDiags;
            }

            public List<InvestigationReportRO> PatientListForLabelPrintReport(string mrID,string reportGroupID)
            {
                List<InvestigationReportRO> oDiags = new List<InvestigationReportRO>();

                string packageName = "Pkg_DRS_Report.Get_Patient_List_For_Lbl_Rrt";
                OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mr_id",OracleDbType.Varchar2,30,mrID,ParameterDirection.Input),
                new OracleParameter("p_report_group_id",OracleDbType.Varchar2,30,reportGroupID,ParameterDirection.Input)
                };
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
               // OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {            
                    InvestigationReportRO oDRS = new InvestigationReportRO();
                    oDRS.HCN = (string)rdr["HCN"].ToString();
                    oDRS.MRNo = (string)rdr["MR_NO"].ToString();
                    oDRS.PatientName = (string)rdr["PATNAME"].ToString();       
                    oDRS.Age = (string)rdr["Age"].ToString();
                    oDRS.Sex = (string)rdr["GENDER"].ToString();
                    oDRS.ReportGroup = (string)rdr["REPORTGROUPTITLE"].ToString();
                    oDRS.SampleDate = (string)rdr["dates"].ToString();
                    oDiags.Add(oDRS);

                }
                return oDiags;
            }
            public List<InvestigationReportRO> GetMicroBioResultA1(string MRNo,string reportGrpID,string TestDetailsId)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultA1";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,MRNo,ParameterDirection.Input) ,
                new OracleParameter ("p_reportGrpID",OracleDbType.Varchar2,7,reportGrpID,ParameterDirection.Input) ,
                new OracleParameter ("p_TestDetailsId",OracleDbType.Varchar2,7,TestDetailsId,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultB1(string MRNo, string reportGrpID, string TestDetailsId)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultB1";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,MRNo,ParameterDirection.Input) ,
                new OracleParameter ("p_reportGrpID",OracleDbType.Varchar2,7,reportGrpID,ParameterDirection.Input) ,
                new OracleParameter ("p_TestDetailsId",OracleDbType.Varchar2,7,TestDetailsId,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultC1(string MRNo, string reportGrpID, string TestDetailsId)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultC1";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,MRNo,ParameterDirection.Input) ,
                new OracleParameter ("p_reportGrpID",OracleDbType.Varchar2,7,reportGrpID,ParameterDirection.Input) ,
                new OracleParameter ("p_TestDetailsId",OracleDbType.Varchar2,7,TestDetailsId,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultA2(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
               string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultA2";
               OracleParameter[] parameterList = new OracleParameter[]  {

               new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
               new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
               new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
               new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
               new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
                 };
               return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultB2(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultB2";
                OracleParameter[] parameterList = new OracleParameter[]  {
                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
                new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
                new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultC2(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                 string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultC2";
                 OracleParameter[] parameterList = new OracleParameter[]  {
                 new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                 new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                 new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
                 new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
                 new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
                 };
                 return GrowthResult(packageName, parameterList);
            }

            public string PathologyReportVerify(string reportID)
            {
                string packageName = "Pkg_DRS_Report.Pathology_Rpt_Verify";
                OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Result",OracleDbType.Varchar2,10,null,ParameterDirection.Output),
               new OracleParameter("ReportID",OracleDbType.Varchar2,30,reportID,ParameterDirection.Input),
             
           };
                short i = DALHelper.Insert(connstring, packageName, parameterList);
                OracleParameter prm = parameterList[0];
                string output = (string)(OracleString)prm.Value;
                return output;
            }
            public string MBIOReportVerify(string reportID)
            {
                string packageName = "Pkg_DRS_Report.MBIO_Rpt_Verify";
                OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Result",OracleDbType.Varchar2,10,null,ParameterDirection.Output),
               new OracleParameter("ReportID",OracleDbType.Varchar2,30,reportID,ParameterDirection.Input),
             
           };
                short i = DALHelper.Insert(connstring, packageName, parameterList);
                OracleParameter prm = parameterList[0];
                string output = (string)(OracleString)prm.Value;
                return output;
            }
            private List<InvestigationReportRO> GrowthResult(string packageName, OracleParameter[] parameterList)
            {
                List<InvestigationReportRO> oDiags = new List<InvestigationReportRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    InvestigationReportRO oDRS = new InvestigationReportRO();

                    oDRS.HDTitle = (string)rdr["RES_HD_TITLE"].ToString();
                    oDRS.ResultA = (string)rdr["RESULT_A"].ToString();
                    oDRS.ResultB = (string)rdr["RESULT_B"].ToString();
                    oDRS.ResultC = (string)rdr["RESULT_C"].ToString();
                    oDiags.Add(oDRS);
                }
                rdr.Close();
                return oDiags;
            }
            public List<InvestigationReportRO> GetMicroBioResultABulk(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_Result_A_Bulk";
                OracleParameter[] parameterList = new OracleParameter[]  {
                 new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                 new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                 new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
                 new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
                 new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
                 };
                return GrowthResult(packageName, parameterList);
            }

            public List<InvestigationReportRO> GetMicroBioResultBBulk(string rptSection, string rptGroup, string FromDate, string ToDate)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultB_Bulk";
                OracleParameter[] parameterList = new OracleParameter[]  {
                 new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                 new OracleParameter("ReportSection",OracleDbType.Varchar2,7,rptSection,ParameterDirection.Input),
                 new OracleParameter("ReportGroup",OracleDbType.Varchar2,7,rptGroup,ParameterDirection.Input),
                 new OracleParameter("FromDate",OracleDbType.Varchar2,10,FromDate,ParameterDirection.Input),
                 new OracleParameter("ToDate",OracleDbType.Varchar2,10,ToDate,ParameterDirection.Input)
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioReportPreview(string resultID)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_DRS_Micro_Bio_Report_Prev";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,resultID,ParameterDirection.Input) 
                 };
                int cnt = GetMicroBioResCnt(resultID);
                return MapObject(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultAPreview(string resultID)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultA_Prev";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,resultID,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
            public List<InvestigationReportRO> GetMicroBioResultBPreview(string resultID)
            {
                string packageName = "AGH_DRS.Pkg_DRS_Report.Get_Micro_Bio_ResultB_Prev";
                OracleParameter[] parameterList = new OracleParameter[]  {

                new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_mrno",OracleDbType.Varchar2,300,resultID,ParameterDirection.Input) 
                 };
                return GrowthResult(packageName, parameterList);
            }
        }
    }

