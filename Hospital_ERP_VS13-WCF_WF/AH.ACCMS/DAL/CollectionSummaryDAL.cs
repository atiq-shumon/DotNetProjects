using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ACCMS.MODEL;
using Oracle.DataAccess.Client;
using AH.OracleManager;
using AH.Shared.MODEL;

namespace AH.ACCMS.DAL
{
      public class CollectionSummaryDAL
        {
          private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
            string packageName = string.Empty;
            #region GetsforGrid
            public List<CollectionSummaryRO> GetCollectionDetails(string wherecondition)
            {
                string packageName = "AGH_ACCMS.PKG_ACCMS_Report.GET_Collection_Details";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_Where_Condition",OracleDbType.Varchar2,3000, wherecondition,ParameterDirection.Input)
            };
                return GetsDetails(packageName, parameterList);
            }
            private List<CollectionSummaryRO> GetsDetails(string packageName, OracleParameter[] parameterList)
            {
                List<CollectionSummaryRO> rDRSs = new List<CollectionSummaryRO>();
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
            #region DataReaderMappingwithNUllGrid
            private CollectionSummaryRO MapObject(NullHandler oReader)
            {
                CollectionSummaryRO oDRS = new CollectionSummaryRO();
                oDRS.Transac_NO = oReader.GetString("Transac_NO");
                oDRS.Purpose_ID = oReader.GetString("Purpose_ID");
                oDRS.Purpose_Title = oReader.GetString("Purpose_Title");
                oDRS.Purpose_Title_Beng = oReader.GetString("Purpose_Title_Beng");
                oDRS.Net_Amt = oReader.GetDouble("Net_Amt");
                oDRS.TransactionDate = oReader.GetDateTime("TransactionDate").ToString("dd MMM yyyy");
                return oDRS;
            }
            private CollectionSummaryRO CreateObject(NullHandler oReader)
            {
                CollectionSummaryRO oDRS = new CollectionSummaryRO();
                oDRS = MapObject(oReader);
                return oDRS;
            }
            private List<CollectionSummaryRO> CreateObjects(IDataReader oReader)
            {
                List<CollectionSummaryRO> rDRSs = new List<CollectionSummaryRO>();
                NullHandler oHandler = new NullHandler(oReader);
                while (oReader.Read())
                {
                    CollectionSummaryRO oItem = CreateObject(oHandler);
                    rDRSs.Add(oItem);
                }
                return rDRSs;
            }
            #endregion
            public List<CollectionSummaryRO> GetsSummary(string wherecondition)
            {
                string packageName = "AGH_ACCMS.PKG_ACCMS_Report.GETs_Collection_Summary";
                OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_Where_Condition",OracleDbType.Varchar2,3000, wherecondition,ParameterDirection.Input)
            };
                return GetsSummary(packageName, parameterList);
            }
            private List<CollectionSummaryRO> GetsSummary(string packageName, OracleParameter[] parameterList)
            {
                List<CollectionSummaryRO> rDRSs = new List<CollectionSummaryRO>();
                IDataReader reader = null;
                try
                {
                    reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                    if (reader.FieldCount > 0)
                    {
                        rDRSs = CreateObjectsSummary(reader);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return rDRSs;
            }
            //public Dictionary <string,string  > GetGroups()
        
            //{
            //    string packageName = "PKG_ACCOUNTS_SETUP.Loadgroup";
            //    OracleParameter[] parameterList = new OracleParameter[]
            //        {
            //         new OracleParameter ("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            
            //        };
            //   // return GetGroups(packageName, parameterList); ;

            //}
            #region DataReaderMappingwithNUllGrid
            private CollectionSummaryRO MapObjectSummary(NullHandler oReader)
            {
                CollectionSummaryRO oDRS = new CollectionSummaryRO();
                oDRS.Purpose_ID = oReader.GetString("Purpose_ID");
                oDRS.Purpose_Title = oReader.GetString("Purpose_Title");
                oDRS.Net_Amt = oReader.GetDouble("Net_Amt");
                return oDRS;
            }
            private CollectionSummaryRO CreateObjectSummary(NullHandler oReader)
            {
                CollectionSummaryRO oDRS = new CollectionSummaryRO();
                oDRS = MapObjectSummary(oReader);
                return oDRS;
            }
            private List<CollectionSummaryRO> CreateObjectsSummary(IDataReader oReader)
            {
                List<CollectionSummaryRO> rDRSs = new List<CollectionSummaryRO>();
                NullHandler oHandler = new NullHandler(oReader);
                while (oReader.Read())
                {
                    CollectionSummaryRO oItem = CreateObjectSummary(oHandler);
                    rDRSs.Add(oItem);
                }
                return rDRSs;
            }
            #endregion
            #endregion
            #region "Collection"
            public List<LedgerRO> GetLedgerReports(string strRefNo)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetLedgerReports";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("ParamVoucherNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input)
                };
                return GetLedgerReports(packageName, parameterList);
            }
            private List<LedgerRO> GetLedgerReports(string packageName, OracleParameter[] parameterList)
            {
                List<LedgerRO> rLedger = new List<LedgerRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    LedgerRO objLedger = new LedgerRO();
                    objLedger.strVoucherNo = rdr["ref_no"].ToString();
                    objLedger.strChequeNo = rdr["cheque_number"].ToString();
                    if (rdr["cheque_date"].ToString() != "")
                    {
                        objLedger.dteChecueDate = System.DateTime.Parse(rdr["cheque_date"].ToString());
                    }
                   
                    objLedger.strDrawnon = rdr["cheque_drawn_on"].ToString();
                    objLedger.dteDate = System.DateTime.Parse(rdr["voucher_date"].ToString());
                    objLedger.strLedgerName = rdr["l_name"].ToString();
                    objLedger.strsingleNarration = rdr["narration"].ToString();
                    objLedger.strNarration = rdr["voucher_narration"].ToString();
                    objLedger.dblDrAmount = Utility.val( rdr["debit_amount"].ToString());
                    objLedger.dblCrAmount = Utility.val(rdr["credit_amount"].ToString());
                    rLedger.Add(objLedger);
                }
                rdr.Close();
                return rLedger;
            }
            public List<TrailBalanceRO> GetTraiBalanceReports(string F_Date, string T_Date, string strBranchId)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.SaveTrailBalance";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pfdate",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("PtDate",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                    new OracleParameter("Pbranchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                };
                return GetTraiBalanceReports(packageName, parameterList);
            }
            private List<TrailBalanceRO> GetTraiBalanceReports(string packageName, OracleParameter[] parameterList)
            {
                List<TrailBalanceRO> objTraiBalance = new List<TrailBalanceRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    TrailBalanceRO objTrail = new TrailBalanceRO();
                    objTrail.strGrName = rdr["gr_name"].ToString();
                    objTrail.strGrParent = rdr["gr_parent"].ToString();
                    objTrail.dblOpening = Utility.val(rdr["gr_opening"].ToString());
                    objTrail.dblDebitAmount = Utility.val(rdr["gr_debit"].ToString());
                    objTrail.dblCreditAmount = Utility.val(rdr["gr_credit"].ToString());
                    objTraiBalance.Add(objTrail);
                }
                rdr.Close();
                return objTraiBalance;
            }

            public List<TrailBalanceRO> GetTraiBalanceReportsLedger(string F_Date, string T_Date, string strBranchId)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.SaveTrailBalanceLedger";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pfdate",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("PtDate",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                    new OracleParameter("Pbranchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                };
                return GetTraiBalanceReportsLedger(packageName, parameterList);
            }
            private List<TrailBalanceRO> GetTraiBalanceReportsLedger(string packageName, OracleParameter[] parameterList)
            {
                List<TrailBalanceRO> objTraiBalance = new List<TrailBalanceRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    TrailBalanceRO objTrail = new TrailBalanceRO();
                    objTrail.strGrName = rdr["gr_name"].ToString();
                    objTrail.strGrParent = rdr["gr_parent"].ToString();
                    objTrail.dblOpening = Utility.val(rdr["gr_opening"].ToString());
                    objTrail.dblDebitAmount = Utility.val(rdr["gr_debit"].ToString());
                    objTrail.dblCreditAmount = Utility.val(rdr["gr_credit"].ToString());
                    objTraiBalance.Add(objTrail);
                }
                rdr.Close();
                return objTraiBalance;
            }

            public List<TrailBalanceRO> DisplayTrailBalance(string strDiffName, double dblDiffAmount)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetTrailbalance";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Paramgroup",OracleDbType.Varchar2,60,strDiffName,ParameterDirection.Input),
                    new OracleParameter("ParamDiffValue",OracleDbType.Double,60,dblDiffAmount,ParameterDirection.Input),
                };
                return DisplayTrailBalance(packageName, parameterList);
            }
            private List<TrailBalanceRO> DisplayTrailBalance(string packageName, OracleParameter[] parameterList)
            {
                List<TrailBalanceRO> objTraiBalance = new List<TrailBalanceRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    TrailBalanceRO objTrail = new TrailBalanceRO();
                    objTrail.strGrName = rdr["gr_name"].ToString();
                    objTrail.strGrParent = rdr["gr_parent"].ToString();
                    objTrail.dblOpening = Utility.val(rdr["gr_opening"].ToString());
                    objTrail.dblDebitAmount = Utility.val(rdr["gr_debit"].ToString());
                    objTrail.dblCreditAmount = Utility.val(rdr["gr_credit"].ToString());
                    objTraiBalance.Add(objTrail);
                }
                rdr.Close();
                return objTraiBalance;
            }
            public List<VoucherRO> GetIndividualVoucherNo(int intVoucherType)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetvoucherNo";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Paramvoucher",OracleDbType.Int16,2,intVoucherType,ParameterDirection.Input),
                };
                return GetIndividualVoucherNo(packageName, parameterList);
            }
            private List<VoucherRO> GetIndividualVoucherNo(string packageName, OracleParameter[] parameterList)
            {
                List<VoucherRO> objvoucherNo = new List<VoucherRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    VoucherRO oVoucher = new VoucherRO();
                    oVoucher.strVoucherNo = rdr["ref_no"].ToString();
                    objvoucherNo.Add(oVoucher);
                }
                rdr.Close();
                return objvoucherNo;
            }
            public List<VoucherRO> GetIndividualVoucherReports(string F_Date, string T_Date, string strBranchId,
                                                                  int intVoucherType, string strControls,string strVoucherNo="",string Poststatus="")
            {
                string packageName = "PKG_ACCOUNTS_REPORT.DisplayvoucherDetails";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                    new OracleParameter("ParaFDate",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("ParaTDate",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                    new OracleParameter("ParamsBranchID",OracleDbType.Varchar2 ,5,strBranchId,ParameterDirection.Input),
                    new OracleParameter("ParamvoucherType",OracleDbType.Int16,2,intVoucherType,ParameterDirection.Input),
                    new OracleParameter("ParamsVoucherNo",OracleDbType.Varchar2,60,strVoucherNo,ParameterDirection.Input),
                    new OracleParameter("PControlName",OracleDbType.Varchar2,60,strControls,ParameterDirection.Input),
                    new OracleParameter("Poststatus",OracleDbType.Varchar2,2,Poststatus,ParameterDirection.Input),
                };
                return GetIndividualVoucherReports(packageName, parameterList);
            }
            private List<VoucherRO> GetIndividualVoucherReports(string packageName, OracleParameter[] parameterList)
            {
                List<VoucherRO> objvoucherNo = new List<VoucherRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    VoucherRO oVoucher = new VoucherRO();
                    oVoucher.strVoucherNo = rdr["ref_no"].ToString();
                    oVoucher.strChequeNo = rdr["cheque_number"].ToString();
                    if (rdr["cheque_date"].ToString() != "")
                    {
                        oVoucher.dteChecueDate = Convert.ToDateTime(rdr["cheque_date"].ToString());
                    }
                    oVoucher.strDrawnon = rdr["cheque_drawn_on"].ToString();
                    oVoucher.dteDate = Convert.ToDateTime(rdr["voucher_date"].ToString());
                    oVoucher.strLedgerName = rdr["l_name"].ToString();
                    oVoucher.strsingleNarration = rdr["narration"].ToString();
                    oVoucher.strNarration = rdr["voucher_narration"].ToString();
                    oVoucher.dblDrAmount =  Convert.ToDouble(rdr["debit_amount"]);
                    oVoucher.dblCrAmount = Convert.ToDouble( rdr["credit_amount"]);
                    if (rdr["codeallocation"].ToString() != "")
                    {
                        oVoucher.CodeAllocation = rdr["codeallocation"].ToString();
                    }
                    else
                    {
                        oVoucher.CodeAllocation = "";
                    
                    }

                    objvoucherNo.Add(oVoucher);
                }
                rdr.Close();
                return objvoucherNo;
            }
            public List<LedgerRO> GetLedgerInformation(string strControl)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetLedgerInformation";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pcontrol",OracleDbType.Varchar2,100,strControl,ParameterDirection.Input),
                };
                return GetLedgerInformation(packageName, parameterList);
            }
            private List<LedgerRO> GetLedgerInformation(string packageName, OracleParameter[] parameterList)
            {
                List<LedgerRO> objLedger = new List<LedgerRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    LedgerRO oLedger = new LedgerRO();
                    oLedger.strLedgerName = rdr["l_name"].ToString();
                    oLedger.strLedgerCode = rdr["l_code"].ToString();
                    objLedger.Add(oLedger);
                }
                rdr.Close();
                return objLedger;
            }
            public List<LedgerRO> GetLedgerDetailsReport(string strLedgerCode,string strBranchId,string fDate,string tDate,string strControl)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetLedgerReport";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pbranchid",OracleDbType.Varchar2,5,strBranchId,ParameterDirection.Input),
                    new OracleParameter("PLedgerCode",OracleDbType.Varchar2,30,strLedgerCode,ParameterDirection.Input),
                    new OracleParameter("Pfate",OracleDbType.Varchar2,30,fDate,ParameterDirection.Input),
                    new OracleParameter("Ptdate",OracleDbType.Varchar2,30,tDate,ParameterDirection.Input),
                    new OracleParameter("PControl",OracleDbType.Varchar2,30,strControl,ParameterDirection.Input),
                };
                if (strControl == "Ledger")
                {
                    return GetLedgerDetailsReport(packageName, parameterList);
                }
                else if (strControl == "Payable")
                {
                    return GetLedgerDetailsReport(packageName, parameterList);
                }
                else
                {
                    return GetGroupDetailsReport(packageName, parameterList);
                }
            }
            private List<LedgerRO> GetLedgerDetailsReport(string packageName, OracleParameter[] parameterList)
            {
                List<LedgerRO> objLedger = new List<LedgerRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    LedgerRO oLedger = new LedgerRO();
                    if (rdr["ledger_code"].ToString() != "")
                    {
                        oLedger.strLedgerCode = (string)rdr["ledger_code"];
                    }
                    oLedger.strLedgerName =(string)  rdr["l_name"];
                    if (rdr["voucher_date"].ToString() != "")
                    {
                        oLedger.dteDate = Convert.ToDateTime(rdr["voucher_date"].ToString());
                    }
                    oLedger.intVouchertype = Convert.ToInt16(rdr["voucher_type"]);
                    oLedger.strVoucherNo  = rdr["ref_no"].ToString();
                    oLedger.dblDrAmount = Convert.ToDouble(rdr["debit_amount"]);
                    oLedger.dblCrAmount = Convert.ToDouble(rdr["credit_amount"]);
                    oLedger.dblOpening = Convert.ToDouble(rdr["opening_balance"]);
                    if (Convert.ToString(rdr["module_ref_no"]) != "")
                    {
                        oLedger.strAgnstRefNo = rdr["module_ref_no"].ToString();
                    }
                    if (Convert.ToString(rdr["codeallocation"]) != "")
                    {
                        oLedger.codeAllocation = rdr["codeallocation"].ToString();
                    }
                    else
                    {
                        oLedger.codeAllocation = "";
                    }

                    objLedger.Add(oLedger);
                }
                rdr.Close();
                return objLedger;
            }
            private List<LedgerRO> GetGroupDetailsReport(string packageName, OracleParameter[] parameterList)
            {
                List<LedgerRO> objLedger = new List<LedgerRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    LedgerRO oLedger = new LedgerRO();
                    if (rdr["ledger_code"].ToString() != "")
                    {
                        oLedger.strLedgerCode = (string)rdr["ledger_code"];
                    }
                    oLedger.strLedgerName = (string)rdr["l_name"];
                    //if (rdr["voucher_date"].ToString() != "")
                    //{
                    //    oLedger.dteDate = Convert.ToDateTime(rdr["voucher_date"].ToString());
                    //}
                    //oLedger.intVouchertype = Convert.ToInt16(rdr["voucher_type"]);
                    //oLedger.strVoucherNo = rdr["ref_no"].ToString();
                    oLedger.dblDrAmount = Convert.ToDouble(rdr["debit_amount"]);
                    oLedger.dblCrAmount = Convert.ToDouble(rdr["credit_amount"]);
                    oLedger.dblOpening = Convert.ToDouble(rdr["opening_balance"]);
                    if (Convert.ToString(rdr["codeallocation"]) != "")
                    {
                        oLedger.codeAllocation = rdr["codeallocation"].ToString();
                    }
                    else
                    {
                        oLedger.codeAllocation = "";
                    }
                    objLedger.Add(oLedger);
                }
                rdr.Close();
                return objLedger;
            }
            public List<BalanceSheetRO> DisplayBalanceSheet(string strbranchId,string strFDate,string strTdate,string strDiff,int intPrimaryType,double dblAmount)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetbalanceSheet";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("branchid",OracleDbType.Varchar2,60,strbranchId,ParameterDirection.Input),
                    //new OracleParameter("fDate",OracleDbType.Varchar2,30,strFDate,ParameterDirection.Input),
                    //new OracleParameter("tDate",OracleDbType.Varchar2,30,strTdate,ParameterDirection.Input),
                    new OracleParameter("Paramgroup",OracleDbType.Varchar2,30,strDiff,ParameterDirection.Input),
                    new OracleParameter("Primarytype",OracleDbType.Int16,1,intPrimaryType,ParameterDirection.Input),
                    new OracleParameter("ParamDiffValue",OracleDbType.Double,30,dblAmount,ParameterDirection.Input),
                };
                return DisplayBalanceSheet(packageName, parameterList);
            }
            private List<BalanceSheetRO> DisplayBalanceSheet(string packageName, OracleParameter[] parameterList)
            {
                List<BalanceSheetRO> objBalanceSheet = new List<BalanceSheetRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    BalanceSheetRO objBal = new BalanceSheetRO();
                    objBal.grName = rdr["gr_name"].ToString();
                    objBal.grParent  = rdr["gr_parent"].ToString();
                    objBal.intPrimaryType  = Convert.ToInt16(rdr["gr_primary_type"].ToString());
                    objBal.gr_amount = Utility.val(rdr["gr_amount"].ToString());
                    objBalanceSheet.Add(objBal);
                }
                rdr.Close();
                return objBalanceSheet;
            }
            //public List<BalanceSheetRO> GetBalanceSheetReports(string F_Date, string T_Date, string strBranchId)
            //{
            //    string packageName = "PKG_ACCOUNTS_REPORT.Savebalancesheet";
            //    OracleParameter[] parameterList = new OracleParameter[]
            //    {
            //        new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            //        new OracleParameter("branchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
            //        new OracleParameter("fDate",OracleDbType.Varchar2,30,F_Date,ParameterDirection.Input),
            //        new OracleParameter("tDate",OracleDbType.Varchar2,30,T_Date,ParameterDirection.Input),
            //    };
            //    return GetBalanceSheetReports(packageName, parameterList);
            //}
            //private List<BalanceSheetRO> GetBalanceSheetReports(string packageName, OracleParameter[] parameterList)
            //{
            //    List<BalanceSheetRO> objTraiBalance = new List<BalanceSheetRO>();
            //    OracleDataReader rdr;
            //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            //    while (rdr.Read())
            //    {
            //        BalanceSheetRO objTrail = new BalanceSheetRO();
            //        objTrail.grName  = rdr["gr_name"].ToString();
            //        objTrail.grParent  = rdr["gr_parent"].ToString();
            //        objTrail.intPrimaryType = Convert.ToInt16(rdr["gr_primary_type"].ToString());
            //        objTrail.gr_amount = Utility.val(rdr["gr_amount"].ToString());
                    
            //        objTraiBalance.Add(objTrail);
            //    }
            //    rdr.Close();
            //    return objTraiBalance;
            //}


            public List<BalanceSheetRO> GetBalanceSheetReports(string F_Date, string T_Date, string strBranchId)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetbalancesheetReport";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("branchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                    new OracleParameter("fDate",OracleDbType.Varchar2,30,F_Date,ParameterDirection.Input),
                    new OracleParameter("tDate",OracleDbType.Varchar2,30,T_Date,ParameterDirection.Input),
                };
                return GetBalanceSheetReports(packageName, parameterList);
            }
            private List<BalanceSheetRO> GetBalanceSheetReports(string packageName, OracleParameter[] parameterList)
            {
                List<BalanceSheetRO> objTraiBalance = new List<BalanceSheetRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    BalanceSheetRO objTrail = new BalanceSheetRO();
                    objTrail.grName = rdr["gr_name"].ToString();
                    objTrail.grParent = rdr["gr_parent"].ToString();
                    objTrail.intPrimaryType = Convert.ToInt16(rdr["gr_primary_type"].ToString());
                    objTrail.gr_amount = Utility.val(rdr["gr_amount"].ToString());
                    objTrail.Sequence = Convert.ToInt32(rdr["Seq"]);

                    objTraiBalance.Add(objTrail);
                }
                rdr.Close();
                return objTraiBalance;
            }




            public List<InccomeExpensesRO> GetIncomeExpensesReports(string Control, string strBranchId, string F_Date, string T_Date,int primarytype)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetincomeExpenses";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Control",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("branchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                    new OracleParameter("fDate",OracleDbType.Varchar2,30,F_Date,ParameterDirection.Input),
                    new OracleParameter("tDate",OracleDbType.Varchar2,30,T_Date,ParameterDirection.Input),
                };
                return GetIncomeExpensesReports(packageName, parameterList,primarytype);
            }
            private List<InccomeExpensesRO> GetIncomeExpensesReports(string packageName, OracleParameter[] parameterList, int primarytype)
            {
                List<InccomeExpensesRO> objIncomeExpneses = new List<InccomeExpensesRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    InccomeExpensesRO objIncExp = new InccomeExpensesRO();
                    if (primarytype == 3)
                    {
                        objIncExp.dblIncome = Convert.ToDouble(rdr["Income"].ToString());
                    }
                    else if (primarytype == 4)
                    {
                        objIncExp.dblExpenses = Convert.ToDouble(rdr["expenses"].ToString());
                    }
                    objIncomeExpneses.Add(objIncExp);
                }
                rdr.Close();
                return objIncomeExpneses;
            }
            public List<ProfitlossRO> GetProfitLossReports(string Control, string strBranchId, string F_Date, string T_Date, int primarytype)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetProfitLoss";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Control",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("branchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                    new OracleParameter("fDate",OracleDbType.Varchar2,30,F_Date,ParameterDirection.Input),
                    new OracleParameter("tDate",OracleDbType.Varchar2,30,T_Date,ParameterDirection.Input),
                };
                return GetProfitLossReports(packageName, parameterList, primarytype);
            }
            private List<ProfitlossRO> GetProfitLossReports(string packageName, OracleParameter[] parameterList, int primarytype)
            {
                List<ProfitlossRO> objProfitLoss = new List<ProfitlossRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    ProfitlossRO objProfit = new ProfitlossRO();
                    objProfit.GroupName = rdr["gr_parent"].ToString();
                    objProfit.LedgerName = rdr["l_name"].ToString();
                    objProfit.primaryType = Convert.ToUInt16(rdr["gr_primary_type"].ToString());
                    objProfit.amount = Convert.ToDouble(rdr["Amount"].ToString());
                    objProfit.seq = Convert.ToInt16(rdr["Seq"]);
                    objProfitLoss.Add(objProfit);
                }
                rdr.Close();
                return objProfitLoss;
            }
            public List<TreeviewRO> GetTreeview(string strRefNo)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetTreeview";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("ParamVoucherNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input)
                };
                return GetTreeview(packageName, parameterList);
            }
            private List<TreeviewRO> GetTreeview(string packageName, OracleParameter[] parameterList)
            {
                List<TreeviewRO> rtreeview = new List<TreeviewRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    TreeviewRO objTree = new TreeviewRO();
                    objTree.grname = rdr["gr_name"].ToString();
                    objTree.lname = rdr["l_name"].ToString();
                    objTree.grprimarytype = Convert.ToInt16(rdr["gr_primary_type"].ToString());
                    objTree.grlevel = Convert.ToInt16(rdr["gr_level"].ToString());
                    objTree.grparent = rdr["gr_one_down"].ToString();
                    rtreeview.Add(objTree);
                }
                rdr.Close();
                return rtreeview;
            }
            public List<CostCategory> GetCostCategory()
            {
                string packageName = "PKG_ACCOUNTS_SETUP.GetCostCategory";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("ParamVoucherNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input)
                };
                return GetCostCategory(packageName, parameterList);
            }
            private List<CostCategory> GetCostCategory(string packageName, OracleParameter[] parameterList)
            {
                List<CostCategory> cat = new List<CostCategory>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCategory objcat = new CostCategory();
                    objcat.Categorycode = rdr["category_Code"].ToString();
                    objcat.Categoryname = rdr["category_name"].ToString();

                    cat.Add(objcat);
                }
                rdr.Close();
                return cat;
            }
            public List<CostCategory> LoadCategory()
            {
                string packageName = "PKG_ACCOUNTS_SETUP.LoadCostCategory";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("ParamVoucherNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input)
                };
                return LoadCategory(packageName, parameterList);
            }
            private List<CostCategory> LoadCategory(string packageName, OracleParameter[] parameterList)
            {
                List<CostCategory> cat = new List<CostCategory>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCategory objcat = new CostCategory();
                    objcat.Categorycode = rdr["category_Code"].ToString();
                    objcat.Categoryname = rdr["category_name"].ToString();

                    cat.Add(objcat);
                }
                rdr.Close();
                return cat;
            }
            public List<Ledgers> GetLedgerCodeAllocation()
            {
                string packageName = "PKG_ACCOUNTS_SETUP.get_Load_ledger";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
                return GetLedgerCode(packageName, parameterList);
            }
            private List<Ledgers> GetLedgerCode(string packageName, OracleParameter[] parameterList)
            {
                List<Ledgers> rLedger = new List<Ledgers>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    Ledgers objLedger = new Ledgers();
                    if (rdr["l_code"].ToString() != "")
                    {
                        objLedger.strLedgerCode  = rdr["l_code"].ToString();
                    }
                    else
                    {
                        objLedger.strLedgerCode = "";
                    }
                    if (rdr["l_code_alloc"].ToString() != "")
                    {
                        objLedger.CodeAllocation = rdr["l_code_alloc"].ToString();
                    }
                    else
                    {
                        objLedger.CodeAllocation = "";
                    }

                    if (rdr["l_name"].ToString() != "")
                    {
                        objLedger.strLedgerName = rdr["l_code_alloc"].ToString() + " " + rdr["l_name"].ToString();
                    }
                    else
                    {
                        objLedger.strLedgerName = "";
                    }


                    rLedger.Add(objLedger);
                }
                rdr.Close();
                return rLedger;
            }
            public List<CostCenterTransation> GetCostcenterTransaction(string control, string Where, string Where1)
            {
                string packageName = "PKG_ACCOUNTS_SETUP.Get_cost_center_Item";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,Where1,ParameterDirection.Input),

                };
                return GetCostcenterTransaction(packageName, parameterList);
            }
            private List<CostCenterTransation> GetCostcenterTransaction(string packageName, OracleParameter[] parameterList)
            {
                List<CostCenterTransation> oblCostCategory = new List<CostCenterTransation>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCenterTransation objC = new CostCenterTransation();
                    if (rdr["acc_code"].ToString() != "")
                    {
                        objC.LedgerCode = rdr["acc_code"].ToString();
                    }
                    else
                    {
                        objC.LedgerCode = "";
                    }

                    if (rdr["category_code"].ToString() != "")
                    {
                        objC.Categorycode  = rdr["category_code"].ToString();
                    }
                    else
                    {
                        objC.Categorycode = "";
                    }

                    if (rdr["category_name"].ToString() != "")
                    {
                        objC.CategoryTitle  = rdr["category_name"].ToString();
                    }
                    else
                    {
                        objC.CategoryTitle = "";
                    }


                    if (rdr["cost_center_id"].ToString() != "")
                    {
                        objC.CostCenteCode = rdr["cost_center_id"].ToString();
                    }
                    else
                    {
                        objC.CostCenteCode = "";
                    }

                    if (rdr["cost_center_title"].ToString() != "")
                    {
                        objC.CoatCenterName   = rdr["cost_center_title"].ToString();
                    }
                    else
                    {
                        objC.CoatCenterName = "";
                    }
                    oblCostCategory.Add(objC);
                }
                rdr.Close();
                return oblCostCategory;
            }
            public List<CostCenterTransation> DisplayCostcenterTransaction(string control, string Where, string Where1)
            {
                string packageName = "PKG_ACCOUNTS_SETUP.Get_cost_center_Item";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,Where1,ParameterDirection.Input),
                };
                return DisplayCostcenterTransaction(packageName, parameterList);
            }
            private List<CostCenterTransation> DisplayCostcenterTransaction(string packageName, OracleParameter[] parameterList)
            {
                List<CostCenterTransation> oblCostCategory = new List<CostCenterTransation>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCenterTransation objC = new CostCenterTransation();
                    if (rdr["category_code"].ToString() != "")
                    {
                        objC.Categorycode = rdr["category_code"].ToString();
                    }
                    else
                    {
                        objC.Categorycode = "";
                    }

                    if (rdr["category_name"].ToString() != "")
                    {
                        objC.CategoryTitle = rdr["category_name"].ToString();
                    }
                    else
                    {
                        objC.CategoryTitle = "";
                    }


                    if (rdr["cost_center_code"].ToString() != "")
                    {
                        objC.CostCenteCode = rdr["cost_center_code"].ToString();
                    }
                    else
                    {
                        objC.CostCenteCode = "";
                    }

                    if (rdr["cost_center_title"].ToString() != "")
                    {
                        objC.CoatCenterName = rdr["cost_center_title"].ToString();
                    }
                    else
                    {
                        objC.CoatCenterName = "";
                    }
                    if (rdr["l_code"].ToString() != "")
                    {
                        objC.LedgerCode = rdr["l_code"].ToString();
                    }
                    else
                    {
                        objC.LedgerCode = "";
                    }

                    objC.Amount = Convert.ToDouble(rdr["tran_amount"]);

                    oblCostCategory.Add(objC);
                }
                rdr.Close();
                return oblCostCategory;
            }
            public List<CostCategoryRO> GetCostCategoryReport(string control, string Where, string Branchid,string fDate,string tDate)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetCostCategoryReport";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Control",OracleDbType.Varchar2,control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("branchid",OracleDbType.Varchar2,Branchid,ParameterDirection.Input),
                    new OracleParameter("fDate",OracleDbType.Varchar2,fDate,ParameterDirection.Input),
                    new OracleParameter("tDate",OracleDbType.Varchar2,tDate,ParameterDirection.Input),
                };
                return GetCostCategoryReport(packageName, parameterList);
            }
            private List<CostCategoryRO> GetCostCategoryReport(string packageName, OracleParameter[] parameterList)
            {
                List<CostCategoryRO> oblCostCategory = new List<CostCategoryRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCategoryRO objC = new CostCategoryRO();
                    if (rdr["category_code"].ToString() != "")
                    {
                        objC.Categorycode = rdr["category_code"].ToString();
                    }
                    else
                    {
                        objC.Categorycode = "";
                    }

                    if (rdr["category_name"].ToString() != "")
                    {
                        objC.CategoryTitle = rdr["category_name"].ToString();
                    }
                    else
                    {
                        objC.CategoryTitle = "";
                    }


                    if (rdr["cost_center_code"].ToString() != "")
                    {
                        objC.CostCenteCode = rdr["cost_center_code"].ToString();
                    }
                    else
                    {
                        objC.CostCenteCode = "";
                    }

                    if (rdr["cost_center_title"].ToString() != "")
                    {
                        objC.CoatCenterName = rdr["cost_center_title"].ToString();
                    }
                    else
                    {
                        objC.CoatCenterName = "";
                    }

                    if (rdr["l_code"].ToString() != "")
                    {
                        objC.LedgerCode = rdr["l_code"].ToString();
                    }
                    else
                    {
                        objC.LedgerCode = "";
                    }
                    if (rdr["l_name"].ToString() != "")
                    {
                        objC.lName = rdr["l_name"].ToString();
                    }
                    else
                    {
                        objC.lName = "";
                    }
                    if (rdr["tran_date"].ToString() != "")
                    {
                        objC.TranDate = Convert.ToDateTime(rdr["tran_date"]);
                    }
                  
                    objC.Amount = Convert.ToDouble(rdr["tran_amount"]);

                    oblCostCategory.Add(objC);
                }
                rdr.Close();
                return oblCostCategory;
            }
            public List<CashflowRO> GetCashflowReport(string control, string Where, string Branchid, string fDate, string tDate)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetCashflowReport";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("Control",OracleDbType.Varchar2,control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("branchid",OracleDbType.Varchar2,Branchid,ParameterDirection.Input),
                    new OracleParameter("fDate",OracleDbType.Varchar2,fDate,ParameterDirection.Input),
                    new OracleParameter("tDate",OracleDbType.Varchar2,tDate,ParameterDirection.Input),
                };
                return GetCashflowReport(packageName, parameterList);
            }
            private List<CashflowRO> GetCashflowReport(string packageName, OracleParameter[] parameterList)
            {
                List<CashflowRO> objCashflow = new List<CashflowRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CashflowRO objC = new CashflowRO();
                    if (rdr["cashflow_type"].ToString() != "")
                    {
                        objC.Cashflowtype = rdr["cashflow_type"].ToString();
                    }
                    else
                    {
                        objC.Cashflowtype = "";
                    }

                    if (rdr["cashflow_group"].ToString() != "")
                    {
                        objC.CashflowGroup = rdr["cashflow_group"].ToString();
                    }
                    else
                    {
                        objC.CashflowGroup = "";
                    }


                    if (rdr["cashflow_ledger"].ToString() != "")
                    {
                        objC.CashflowLedger = rdr["cashflow_ledger"].ToString();
                    }
                    else
                    {
                        objC.CashflowLedger = "";
                    }

                    if (rdr["cashflow_sign"].ToString() != "")
                    {
                        objC.CashflowSign = rdr["cashflow_sign"].ToString();
                    }
                    else
                    {
                        objC.CashflowSign = "";
                    }

                    if (rdr["cashflow_amount"].ToString() != "")
                    {
                        objC.CashflowAmount = Convert.ToDouble(rdr["cashflow_amount"]);
                    }
                    else
                    {
                        objC.CashflowAmount = 0;
                    }

                    objCashflow.Add(objC);
                }
                rdr.Close();
                return objCashflow;
            }
            public List<CostCategoryTreeview> GetCostcategoryTreeview(string control, string Where, string Where1)
            {
                string packageName = "PKG_ACCOUNTS_SETUP.Get_cost_center_Item";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,Where1,ParameterDirection.Input),

                };
                return GetCostcategoryTreeview(packageName, parameterList);
            }
            private List<CostCategoryTreeview> GetCostcategoryTreeview(string packageName, OracleParameter[] parameterList)
            {
                List<CostCategoryTreeview> oblCostCategory = new List<CostCategoryTreeview>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCategoryTreeview objC = new CostCategoryTreeview();
                    if (rdr["category_code"].ToString() != "")
                    {
                        objC.CategoryID = rdr["category_code"].ToString();
                    }
                    else
                    {
                        objC.CategoryID = "";
                    }

                    if (rdr["category_name"].ToString() != "")
                    {
                        objC.CategoryName  = rdr["category_name"].ToString();
                    }
                    else
                    {
                        objC.CategoryName = "";
                    }


                    //if (rdr["cost_center_id"].ToString() != "")
                    //{
                    //    objC.CostCenterID = rdr["cost_center_id"].ToString();
                    //}
                    //else
                    //{
                    //    objC.CostCenterID = "";
                    //}

                    //if (rdr["cost_center_title"].ToString() != "")
                    //{
                    //    objC.CostcenterName = rdr["cost_center_title"].ToString();
                    //}
                    //else
                    //{
                    //    objC.CostcenterName = "";
                    //}

                    //if (rdr["cost_category_code"].ToString() != "")
                    //{
                    //    objC.CostCenterCategory = rdr["cost_category_code"].ToString();
                    //}
                    //else
                    //{
                    //    objC.CostCenterCategory = "";
                    //}

                    oblCostCategory.Add(objC);
                }
                rdr.Close();
                return oblCostCategory;
            }
            public List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1)
            {
                string packageName = "PKG_ACCOUNTS_SETUP.Get_cost_center_Item";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,Where1,ParameterDirection.Input),

                };
                return GetCostcenterTreeview(packageName, parameterList);
            }
            private List<CostCategoryTreeview> GetCostcenterTreeview(string packageName, OracleParameter[] parameterList)
            {
                List<CostCategoryTreeview> oblCostCategory = new List<CostCategoryTreeview>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CostCategoryTreeview objC = new CostCategoryTreeview();

                    if (rdr["cost_center_id"].ToString() != "")
                    {
                        objC.CostCenterID = rdr["cost_center_id"].ToString();
                    }
                    else
                    {
                        objC.CostCenterID = "";
                    }

                    if (rdr["cost_center_title"].ToString() != "")
                    {
                        objC.CostcenterName = rdr["cost_center_title"].ToString();
                    }
                    else
                    {
                        objC.CostcenterName = "";
                    }

                    if (rdr["cost_category_code"].ToString() != "")
                    {
                        objC.CostCenterCategory = rdr["cost_category_code"].ToString();
                    }
                    else
                    {
                        objC.CostCenterCategory = "";
                    }

                    oblCostCategory.Add(objC);
                }
                rdr.Close();
                return oblCostCategory;
            }
            #endregion

            public List<CollectionRO> GetCollectionHospital(int Where, string F_Date, string T_Date, string strBranchId)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetHospitalCollection";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Int16,2,Where,ParameterDirection.Input),
                    new OracleParameter("Pbranchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                    new OracleParameter("Pfdate",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("PtDate",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                    
                };
                return GetCollectionHospital(packageName, parameterList);
            }
            private List<CollectionRO> GetCollectionHospital(string packageName, OracleParameter[] parameterList)
            {
                List<CollectionRO> objCollection = new List<CollectionRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    CollectionRO coll = new CollectionRO();
                    coll.Lname = rdr["l_name"].ToString();
                    coll.Lcode = rdr["l_code"].ToString();
                    coll.CodeAllocation = rdr["l_code_alloc"].ToString();
                    coll.RefNo = rdr["ref_no"].ToString();
                    coll.moduleRefNo = rdr["module_ref_no"].ToString();
                    coll.voucherType = Convert.ToInt16(rdr["voucher_type"].ToString());
                    coll.NetAmount = Convert.ToDouble(rdr["voucher_net_amount"]);
                    coll.voucherdate = Convert.ToDateTime(rdr["voucher_date"].ToString());

                    objCollection.Add(coll);
                }
                rdr.Close();
                return objCollection;
            }
            public List<BankReconcilationRO> GetBankReconcilationRpt(string Where, string F_Date, string T_Date, string strBranchId)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetBankReconcilation";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                    //new OracleParameter("Pbranchid",OracleDbType.Varchar2,60,strBranchId,ParameterDirection.Input),
                    new OracleParameter("Pfdate",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("PtDate",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                    
                };
                return GetBankReconcilationRpt(packageName, parameterList);
            }
            private List<BankReconcilationRO> GetBankReconcilationRpt(string packageName, OracleParameter[] parameterList)
            {
                List<BankReconcilationRO> objCollection = new List<BankReconcilationRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    BankReconcilationRO coll = new BankReconcilationRO();
                    if (rdr["comp_voucher_date"].ToString() != "")
                    {
                        coll.voucherDate = Convert.ToDateTime(rdr["comp_voucher_date"].ToString());
                    }
                    
                    if (rdr["bank_date"].ToString() != "")
                    {
                        coll.BankDate = Convert.ToDateTime(rdr["bank_date"].ToString());
                    }
                    if (rdr["cheque_no"].ToString() != "")
                    {
                        coll.chequeNo  =rdr["cheque_no"].ToString();
                    }
                    coll.lcode = rdr["l_code"].ToString();
                    coll.lName = rdr["l_name"].ToString();
                    coll.voucherType = Convert.ToInt16(rdr["comp_voucher_type"].ToString());
                    coll.VoucherToby = rdr["voucher_toby"].ToString();
                    coll.DebitAmount = Convert.ToDouble(rdr["dr"]);
                    coll.CreditAmount = Convert.ToDouble(rdr["cr"]);
                    coll.childAmount = Convert.ToDouble(rdr["childamnt"]);
                    coll.Opening = Convert.ToDouble(rdr["opening"]);

                    coll.bankChargePer = Convert.ToDouble(rdr["bank_charge_per"]);
                    coll.bankChargeAmount = Convert.ToDouble(rdr["bank_charge_amount"]);
                    coll.bankChargeNetAmount = Convert.ToDouble(rdr["net_amount"]);


                    objCollection.Add(coll);
                }
                rdr.Close();
                return objCollection;
            }
            public List<FixedAssets> GetLocation()
            {
                string packageName = "PKG_FIXED_ASSETS.GetstoreLocation";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    
                };
                return GetLocation(packageName, parameterList);
            }
            private List<FixedAssets> GetLocation(string packageName, OracleParameter[] parameterList)
            {
                List<FixedAssets> objFxd = new List<FixedAssets>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    FixedAssets coll = new FixedAssets();
                    if (rdr["storeid"].ToString() != "")
                    {
                        coll.Locationcode = rdr["storeid"].ToString();
                    }
                    else
                    {
                        coll.Locationcode = "";
                    }
                    if (rdr["storename"].ToString() != "")
                    {
                        coll.LocationName = rdr["storename"].ToString();
                    }
                    else
                    {
                        coll.LocationName = "";
                    }
                    objFxd.Add(coll);
                }
                rdr.Close();
                return objFxd;
            }

            public List<FixedAssets> Getsupplier()
            {
                string packageName = "PKG_FIXED_ASSETS.GetSupplier";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    
                };
                return Getsupplier(packageName, parameterList);
            }
            private List<FixedAssets> Getsupplier(string packageName, OracleParameter[] parameterList)
            {
                List<FixedAssets> objFxd = new List<FixedAssets>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    FixedAssets coll = new FixedAssets();
                    if (rdr["id"].ToString() != "")
                    {
                        coll.supplierCode = rdr["id"].ToString();
                    }
                    else
                    {
                        coll.supplierCode = "";
                    }
                    if (rdr["name"].ToString() != "")
                    {
                        coll.SupplierName = rdr["name"].ToString();
                    }
                    else
                    {
                        coll.SupplierName = "";
                    }
                    objFxd.Add(coll);
                }
                rdr.Close();
                return objFxd;
            }

            public short SaveWrittenDownValue(string F_Date, string T_Date, string strWhere)
            {
                packageName = "PKG_ACCOUNTS_REPORT.GetWrittendownValue";
                OracleParameter[] parameterList = new OracleParameter[]{
                 new OracleParameter("gdteFinicialYearFrom",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                 new OracleParameter("uctxtAsOn",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                 new OracleParameter("pledgercode",OracleDbType.Varchar2,10000,strWhere,ParameterDirection.Input)
            };
                short i = DALHelper.Insert(connstring, packageName, parameterList);
               // OracleParameter prm = parameterList[0];
                //if ((OracleDecimal)prm.Value == 1)
                //    return 1;
                //else return 0;
                return 1;
            }
           


            public List<FixedAssetsRO> GetFixedAssetsRo(string F_Date, string T_Date,string strWhere)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetWrittendownValue";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("gdteFinicialYearFrom",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("uctxtAsOn",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                    new OracleParameter("pledgercode",OracleDbType.Varchar2,10000,strWhere,ParameterDirection.Input)

                };
                return GetFixedAssetsRo(packageName, parameterList);
            }
            private List<FixedAssetsRO> GetFixedAssetsRo(string packageName, OracleParameter[] parameterList)
            {
                List<FixedAssetsRO> objCollection = new List<FixedAssetsRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    FixedAssetsRO coll = new FixedAssetsRO();
                    coll.assetnumber = rdr["asset_number"].ToString();
                    coll.lname = rdr["l_name"].ToString();
                    coll.branchid = rdr["branch_id"].ToString();
                    coll.assetprebal = Convert.ToDouble(rdr["asset_prev_bal"].ToString());
                    coll.assetaddthisperiod = Convert.ToDouble(rdr["asset_add_this_period"].ToString());
                    coll.assetdisposalthisperiod = Convert.ToDouble(rdr["asset_disposal_this_period"].ToString());
                    
                    coll.assetdeprate = Convert.ToDouble(rdr["asset_dep_rate"]);
                    
                    coll.assetdepthisperiod = Convert.ToDouble(rdr["asset_dep_this_period"].ToString());
                    coll.assetdepaccu = Convert.ToDouble (rdr["asset_dep_accu"].ToString());
                    coll.assetdepadjustment = Convert.ToDouble(rdr["asset_dep_adjustment"].ToString());
                    
                    coll.assetpurchasevalue = Convert.ToDouble(rdr["asset_purchase_value"].ToString());
                    coll.noofdays = Convert.ToInt64(rdr["no_of_days"].ToString());
                    objCollection.Add(coll);
                }
                rdr.Close();
                return objCollection;
            }
            public List<Ledgers> GetSupplierLedger(string Where)
            {
                string packageName = "PKG_ACCOUNTS_SETUP.GetSupplierGroup";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                    
                };
                return GetSupplierLedger(packageName, parameterList);
            }
            private List<Ledgers> GetSupplierLedger(string packageName, OracleParameter[] parameterList)
            {
                List<Ledgers> objLdr = new List<Ledgers>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    Ledgers coll = new Ledgers();
                    if (rdr["l_code"].ToString() != "")
                    {
                        coll.strLedgerCode = rdr["l_code"].ToString();
                    }
                    else
                    {
                        coll.strLedgerCode = "";
                    }

                    if (rdr["l_name"].ToString() != "")
                    {
                        coll.strLedgerName = rdr["l_name"].ToString();
                    }
                    else
                    {
                        coll.strLedgerName = "";
                    }
                    objLdr.Add(coll);
                }
                rdr.Close();
                return objLdr;
            }
            public List<FixedAssets> GetManufacturerName()
            {
                string packageName = "PKG_FIXED_ASSETS.GetManufacturerName";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   // new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                    
                };
                return GetManufacturerName(packageName, parameterList);
            }
            private List<FixedAssets> GetManufacturerName(string packageName, OracleParameter[] parameterList)
            {
                List<FixedAssets> objFxd = new List<FixedAssets>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    FixedAssets coll = new FixedAssets();
                    if (rdr["id"].ToString() != "")
                    {
                        coll.ManufacturerCode = rdr["id"].ToString();
                    }
                    else
                    {
                        coll.ManufacturerCode = "";
                    }

                    if (rdr["name"].ToString() != "")
                    {
                        coll.ManufacturerName = rdr["name"].ToString();
                    }
                    else
                    {
                        coll.ManufacturerName = "";
                    }
                    objFxd.Add(coll);
                }
                rdr.Close();
                return objFxd;
            }


            public List<FixedAssetsDetailsRO> GetFixedAssetsDetailsRo(string F_Date, string T_Date)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.getfixedassetsdetails";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pfdate",OracleDbType.Varchar2,60,F_Date,ParameterDirection.Input),
                    new OracleParameter("ptdate",OracleDbType.Varchar2,60,T_Date,ParameterDirection.Input),
                   // new OracleParameter("pledgercode",OracleDbType.Varchar2,10000,strWhere,ParameterDirection.Input)

                };
                return GetFixedAssetsDetailsRo(packageName, parameterList);
            }
            private List<FixedAssetsDetailsRO> GetFixedAssetsDetailsRo(string packageName, OracleParameter[] parameterList)
            {
                List<FixedAssetsDetailsRO> objCollection = new List<FixedAssetsDetailsRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    FixedAssetsDetailsRO coll = new FixedAssetsDetailsRO();
                    coll.assetslNo = rdr["asset_serial"].ToString();
                    coll.Lname = rdr["l_name"].ToString();
                    coll.Lcode = rdr["ledger_code"].ToString();
                    coll.manuafacturerDate = rdr["manufacturerdate"].ToString();
                    coll.locId = rdr["loc_id"].ToString();
                    coll.locationName = rdr["store_title"].ToString();
                    coll.suppid = rdr["supp_id"].ToString();
                    coll.supplierName = rdr["suppname"].ToString();
                    coll.purchaseDate = rdr["purchasedate"].ToString();
                    coll.purchasecost = Convert.ToDouble(rdr["purchase_cost"].ToString());
                    coll.effectivedate = rdr["dep_eff_date"].ToString();
                    coll.depMethod = Convert.ToInt16( rdr["dep_method"].ToString());
                    coll.assetslife = Convert.ToInt32(rdr["asset_life"].ToString());
                    coll.depRate = Convert.ToDouble(rdr["asset_dep_rate"].ToString());
                    coll.accumalateddep = Convert.ToInt64(rdr["asset_accu_dep"].ToString());
                    coll.writtnvalue = Convert.ToInt64(rdr["asset_written_value"].ToString());
                    coll.percent = Convert.ToInt64(rdr["asset_percent"].ToString());
                    coll.salvagevalue = Convert.ToInt64(rdr["asset_salvage_value"].ToString());
                    coll.manufacturercode = rdr["manufacturers_code"].ToString();
                    coll.manufacturerName = rdr["name"].ToString();
                    coll.modelNo = rdr["model_no"].ToString();
                    coll.countryoforigin = rdr["country_of_origin"].ToString();
                    coll.identificationNo = rdr["assets_identification_no"].ToString();
                    coll.FloorNo = rdr["floor_no"].ToString();
                    objCollection.Add(coll);
                }
                rdr.Close();
                return objCollection;
            }

            public List<LedgerRO> GetLedgerInformationGrid(string strControl)
            {
                string packageName = "PKG_ACCOUNTS_REPORT.GetLedgerInformationGrid";
                OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pcontrol",OracleDbType.Varchar2,100,strControl,ParameterDirection.Input),
                };
                return GetLedgerInformationGrid(packageName, parameterList);
            }
            private List<LedgerRO> GetLedgerInformationGrid(string packageName, OracleParameter[] parameterList)
            {
                List<LedgerRO> objLedger = new List<LedgerRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    LedgerRO oLedger = new LedgerRO();
                    oLedger.strLedgerName = rdr["l_name"].ToString();
                    oLedger.strLedgerCode = rdr["l_code"].ToString();
                    if (rdr["codeallocation"].ToString() != "")
                    {
                        oLedger.codeAllocation = rdr["codeallocation"].ToString();
                    }
                    else
                    {
                        oLedger.codeAllocation = "";
                    }

                    objLedger.Add(oLedger);
                }
                rdr.Close();
                return objLedger;
            }


            public List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate)
            {
                string packageName = "PKG_ACCOUNTS_SETUP.get_collection_statements";
                OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,StartDate,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,EndDate,ParameterDirection.Input)
            };
                return GetCollectionSummaryDetails(packageName, parameterList);
            }
            private List<OPDPayment> GetCollectionSummaryDetails(string packageName, OracleParameter[] parameterList)
            {
                List<OPDPayment> oAccPays = new List<OPDPayment>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    OPDPayment pat = new OPDPayment();
                    pat.PurposeID = (string)rdr["PURPOSE_ID"].ToString();
                    pat.PurposeTitle = (string)rdr["PURPOSE_TITLE"].ToString();
                    pat.CashAmount = Convert.ToDouble(rdr["CASH_AMT"]);
                    pat.DebitCardAmount = Convert.ToDouble(rdr["DEBIT_CARD_AMT"]);
                    pat.CreditCardAmount = Convert.ToDouble(rdr["CREDIT_CARD_AMT"]);
                    pat.NetAmount = Convert.ToDecimal(rdr["NET_AMT"]);

                    oAccPays.Add(pat);
                }
                rdr.Close();
                return oAccPays;
            }

          



        }
    }
