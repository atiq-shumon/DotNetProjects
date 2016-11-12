using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ACCMS.MODEL;
using AH.ACCMS.BLL;
using AH.Shared.MODEL;
using AH.ORGMS.BLL;

namespace AH.ACCMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ACCMSWS" in both code and config file together.
    public class ACCMSWS : IACCMSWS
    {
        public short SavePurposeSetup(Purpose prs)
        {
            return new ACCMSSetupBLL().SavePurposeSetup(prs);
        }
        public short UpdatePurpose(Purpose uprs)
        {
            return new ACCMSSetupBLL().UpdatePurpose(uprs);
        }
        public List<Purpose> GetPurpose()
        {
            return new ACCMSSetupBLL().GetPurpose();
        }
        public List<GroupsConfig> GetGroupsConfiguration()
        {
            return new ACCMSSetupBLL().GetGroupsConfiguration();
        }
        public List<Branch> GetBranch()
        {
            return new ACCMSSetupBLL().GetBranch();
        }
        public int VerifyPurpose(string purposeid)
        {
            return new ACCMSSetupBLL().VerifyPurpose(purposeid);
        }
        public List<CollectionSummaryRO> GetCollectionDetails(string wherecondition)
        {
            return new CollectionSummaryBLL().GetCollectionDetails(wherecondition);
        }
        public List<CollectionSummaryRO> GetsSummary(string wherecondition)
        {
            return new CollectionSummaryBLL().GetsSummary(wherecondition);
        }
        public short SaveBranchSetup(Branch branch)
        {
            return new ACCMSSetupBLL().SaveBranchSetup(branch);
        }
        public short SaveGroupSetup(GroupsConfig grp)
        {
            return new ACCMSSetupBLL().SaveGroupSetup(grp);
        }
        public Dictionary<string, string> GetGroups(string type)
        {
            return new ACCMSSetupBLL().GetGroups(type);
        }
        public List<GroupsConfig> GetGroupTreeview()
        {
            return new ACCMSSetupBLL().GetGroupTreeview();
        }
        public List<Ledgers> GetLegerTreeview(string strGroups)
        {
            return new ACCMSSetupBLL().GetLegerTreeview(strGroups);
        }
        public Dictionary<string, string> GetLedgerUnder(string type)
        {
            return new ACCMSSetupBLL().GetLedgerUnder(type);
        }
        public short SaveLedgerSetup(Ledgers  objLedger)
        {
            return new ACCMSSetupBLL().SaveLedgerSetup(objLedger);
        }
        public List<Ledgers> GetDebitTotal()
        {
            return new ACCMSSetupBLL().GetDebitTotal();
        }
        public List<Ledgers> GetCreditTotal()
        {
            return new ACCMSSetupBLL().GetCreditTotal();
        }
        public List<Ledgers> GetLedgersNameDr()
        {
            return new ACCMSSetupBLL().GetLedgersNameDr();
        }
        public List<Ledgers> GetLedgersNameCr()
        {
            return new ACCMSSetupBLL().GetLedgersNameCr();
        }
        public List<Ledgers> CheckBankLedger(string strLedgersName)
        {
            return new ACCMSSetupBLL().CheckBankLedger(strLedgersName);
        }
        public List<Ledgers> GetAllLedgers()
        {
            return new ACCMSSetupBLL().GetAllLedgers();
        }
        public List<VoucherTransaction> GetVoucherNo(int lngVoucherType)
        {
            return new ACCMSSetupBLL().GetVoucherNo(lngVoucherType);
        }
        public string SaveVoucherSetup(string strRefNo, VoucherTransaction objVoucher)
        {
            return new ACCMSSetupBLL().SaveVoucherSetup(strRefNo, objVoucher);
        }
        public short SaveVoucheChildrSetup(string strRefNo,VoucherTransaction objVoucher)
        {
            return new ACCMSSetupBLL().SaveVoucheChildrSetup(strRefNo, objVoucher);
        }
        public List<VoucherTransaction> GetVoucherTransactionDetails(int lngVoucherType, string fdate, string tdate, string Poststatus)
        {
            return new ACCMSSetupBLL().GetVoucherTransactionDetails(lngVoucherType,fdate,tdate,Poststatus);
        }
        public short UpdateBranchSetup(Branch branch)
        {
            return new ACCMSSetupBLL().UpdateBranchSetup(branch);
        }
        public short DeleteBranch(Branch branch)
        {
            return new ACCMSSetupBLL().DeleteBranch(branch);
        }
        public short UpdateGroupSetup(GroupsConfig groups)
        {
            return new ACCMSSetupBLL().UpdateGroupSetup(groups);
        }
        public short DeleteGroupSetup(GroupsConfig objGroups)
        {
            return new ACCMSSetupBLL().DeleteGroupSetup(objGroups);
        }
        public List<Ledgers> GetLedgersDetails()
        {
            return new ACCMSSetupBLL().GetLedgersDetails();
        }
        public short DeleteLedger(long lngSlNo)
        {
            return new ACCMSSetupBLL().DeleteLedger(lngSlNo);
        }
        public List<Ledgers> GetDisplayLedgers(long lngSlNo)
        {
            return new ACCMSSetupBLL().GetDisplayLedgers(lngSlNo);
        }
        public short UpdateLedgerSetup(Ledgers ldr)
        {
            return new ACCMSSetupBLL().UpdateLedgerSetup(ldr);
        }
        public List<Ledgers> GetLedegrCode(string strLedgerName)
        {
            return new ACCMSSetupBLL().GetLedegrCode(strLedgerName);
        }
        public List<Ledgers> GetLederName(string strLedgerCode)
        {
            return new ACCMSSetupBLL().GetLederName(strLedgerCode);
        }
        public short DeleteVoucher(string strVoucherNo,int vintVoucherType)
        {
            return new ACCMSSetupBLL().DeleteVoucher(strVoucherNo,vintVoucherType);
        }
        public short SaveFixedAssetsSetup(FixedAssets fassets)
        {
            return new ACCMSSetupBLL().SaveFixedAssetsSetup(fassets);
        }
        public List<FixedAssets> GetFixedAssetsLedger()
        {
            return new ACCMSSetupBLL().GetFixedAssetsLedger();
        }
        public List<VoucherTransaction> GetdisplayvoucherDetails(string strRefNo, int vType)
        {
            return new ACCMSSetupBLL().GetdisplayvoucherDetails(strRefNo, vType);
        }
        public List<LedgerRO> GetLedgerReports(string strVoucherNo)
        {
            return new ACCMSSetupBLL().GetLedgerReports(strVoucherNo);
        }
        public Dictionary<string, string> GetBranchConfig(string  strBranch)
        {
            return new ACCMSSetupBLL().GetBranchConfig(strBranch);
        }
        public List<TrailBalanceRO> GetTraiBalanceReports(string f_date,string t_date,string strBranchID)
        {
            return new ACCMSSetupBLL().GetTraiBalanceReports(f_date, t_date, strBranchID);
        }
        public List<TrailBalanceRO> DisplayTrailBalance(string strDiffName, double dblDiffAmount)
        {
            return new ACCMSSetupBLL().DisplayTrailBalance(strDiffName, dblDiffAmount);
        }
        public Dictionary <string,string> GetIndividualVoucherNo(int intvouchertype)
        {
            return new CollectionSummaryBLL().GetIndividualVoucherNo(intvouchertype);
        }
        public List<VoucherRO> GetIndividualVoucherReports(string F_Date, string T_date, string strBranchID, int intVType, string strControlsName, string strVoucherNo = "",string PostStatus="")
        {
            return new CollectionSummaryBLL().GetIndividualVoucherReports(F_Date, T_date, strBranchID, intVType, strControlsName, strVoucherNo,PostStatus);
        }
        public Dictionary<string, string> GetLedgerInformation(string strControl)
        {
            return new CollectionSummaryBLL().GetLedgerName(strControl);
        }
        public List<LedgerRO> GetLedgerDetailsReport(string strLedgercode,string strBranchId, string fDate, string tDate,string strControl)
        {
            return new CollectionSummaryBLL().GetLedgerDetailsReport(strLedgercode, strBranchId, fDate, tDate, strControl);
        }
        public List<VoucherTransaction> GetVoucherSearch(string strVoucherNo, int intvtype)
        {
            return new ACCMSSetupBLL().GetVoucherSearch(strVoucherNo, intvtype);
        }
        public short InsertLedgerOpening(LedgerOpening objTran)
        {
            return new ACCMSSetupBLL().InsertLedgerOpening(objTran);
        }
        public short UpdateLedgerOpening(LedgerOpening objTran)
        {
            return new ACCMSSetupBLL().UpdateLedgerOpening(objTran);
        }
        public List<LedgerOpening> GetLedgerOpn()
        {
            return new ACCMSSetupBLL().GetLedgerOpn();
        }

        public Dictionary<string, string> GetLedgersNameDrNew(string type)
        {
            return new ACCMSSetupBLL().GetLedgersNameDrNew(type);
        }

        public Dictionary<string, string> GetBraNewConfig(string type)
        {
            return new ACCMSSetupBLL().GetBraNewConfig(type);
        }
        public List<BalanceSheetRO> DisplayBalanceSheet(string strbranchId, string strFDate, string strTdate, string strDiff, int intPrimaryType, double dblAmount)
        {
            //return new CollectionSummaryBLL().DisplayBalanceSheet(strbranchId, strFDate, strTdate, strDiff,intPrimaryType,dblAmount);
            return new CollectionSummaryBLL().DisplayBalanceSheet(strbranchId, strFDate, strTdate, strDiff, intPrimaryType, dblAmount);
        }
        
        public List<BalanceSheetRO> GetBalanceSheetReports(string f_Date, string t_Date, string strBarnchId)
        {
            return new CollectionSummaryBLL().GetBalanceSheetReports(f_Date, t_Date, strBarnchId);
        }

        public List<InccomeExpensesRO> GetIncomeExpensesReports(string Control, string strBranchId, string F_Date, string T_Date, int primarytype)
        {
            return new CollectionSummaryBLL().GetIncomeExpensesReports(Control, strBranchId, F_Date, T_Date, primarytype);
        }

        public List<ProfitlossRO> GetProfitLossReports(string Control, string strBranchId, string F_Date, string T_Date, int primarytype)
        {
            return new CollectionSummaryBLL().GetProfitLossReports(Control, strBranchId, F_Date, T_Date, primarytype);
        }

        public List<FixedAssets> LoadFixedAssetsLedger()
        {
            return new ACCMSSetupBLL().LoadFixedAssetsLedger();
        }
        public short UpdateFixedAssetsSetup(FixedAssets objTran)
        {
            return new ACCMSSetupBLL().UpdateFixedAssetsSetup(objTran);
        }
        public short DeleteFixedAssetsSetup(FixedAssets objTran)
        {
            return new ACCMSSetupBLL().DeleteFixedAssetsSetup(objTran);
        }
        public List<TreeviewRO> GetTreeview(string strRefNo)
        {
            return new CollectionSummaryBLL().GetTreeview(strRefNo);
        }

        public List<GroupsConfig> GetgroupDetails(string strGroupName)
        {
            return new ACCMSSetupBLL().GetgroupDetails(strGroupName);
        }


        public short SaveCategorySetup(CostCategory cat)
        {
            return new ACCMSSetupBLL().SaveCategorySetup(cat);
        }
        public short UpdateCategorySetup(CostCategory cat)
        {
            return new ACCMSSetupBLL().UpdateCategorySetup(cat);
        }

        public short DeleteCategorySetup(string strCatCode,CostCategory cat)
        {
            return new ACCMSSetupBLL().DeleteCategorySetup(strCatCode,cat);
        }

        public List<CostCategory> GetCostCategory()
        {
            return new ACCMSSetupBLL().GetCostCategory();
        }
        public Dictionary<string, string> LoadCategory()
        {
            return new CollectionSummaryBLL().LoadCategory();
        }

        public short SaveRevenueHeadGr(RevenueHeadGroup rvgr)
        {
            return new RevenueSetupBLL() .SaveRevenueHeadGr(rvgr);
        }
        public short UpdateRevHdGr(RevenueHeadGroup urvgr)
        {
            return new RevenueSetupBLL().UpdateRevHdGr(urvgr);
        }
        public short SaveRevenueHead(RevenueHead rvihd)
        {
            return new RevenueSetupBLL().SaveRevenueHead(rvihd);
        }
        public short UpdateRevHead(RevenueHead urvshd)
        {
            return new RevenueSetupBLL().UpdateRevHead(urvshd);
        }
        public List<RevenueHeadGroup> GetRevHdGrps()
        {
            return new RevenueSetupBLL().GetRevHdGrps();
        }
        public int VerifyRevHdGr(string groupid)
        {
            return new RevenueSetupBLL().VerifyRevHdGr(groupid);
        }
        public Dictionary<string, string> GetRevHdGrps(string type)
        {
            Dictionary<string, string> rvgr = new Dictionary<string, string>();
            foreach (RevenueHeadGroup rvh in new RevenueSetupBLL().GetRevHdGrps())
            {
                rvgr.Add(rvh.ID, rvh.Title);
            }
            return rvgr;
        }

        public List<RevenueHead> GetRevenueHead()
        {
            return new RevenueSetupBLL().GetRevenueHead();
        }
        public List<RevenueHead> GetRevenueHeads(string headgr)
        {
            return new RevenueSetupBLL().GetRevenueHeads(headgr);
        }
        public Dictionary<string, string> GetRevenueHead(string type)
        {
            Dictionary<string, string> rvhd = new Dictionary<string, string>();

            foreach (RevenueHead rvh in new RevenueSetupBLL().GetRevenueHead())
            {
                rvhd.Add(rvh.ID, rvh.Title);
            }
            return rvhd;
        }
        public int VerifyRevHead(string headid)
        {
            return new RevenueSetupBLL().VerifyRevHead(headid);
        }
        public Dictionary<string, string> GetRevenueHeads(string type, string headgr)
        {
            Dictionary<string, string> revhd = new Dictionary<string, string>();
            foreach (RevenueHead rvhd in new RevenueSetupBLL().GetRevenueHeads(headgr))
            {
                revhd.Add(rvhd.ID, rvhd.Title);
            }
            return revhd;
        }

        public short SaveHeadAssign(DepartmentRevenueHead hdas)
        {
            return new RevenueSetupBLL().SaveHeadAssign(hdas);
        }
        public short UpdateHdAss(DepartmentRevenueHead uhdas)
        {
            return new RevenueSetupBLL().UpdateHdAss(uhdas);
        }
        public List<DepartmentRevenueHead> GetHeadAssign()
        {
            return new RevenueSetupBLL().GetHeadAssign();
        }
        public List<DepartmentRevenueHead> GetHeadAssign(string departmentID)
        {
            return new RevenueSetupBLL().GetHeadAssign(departmentID);
        }

        public Dictionary<string, string> GetRevenueGroup()
        {
            return new RevenueSetupBLL().GetRevenueGroup();
        }
        public Dictionary<string, string> GetLedgerCodeAllocation()
        {
            return new CollectionSummaryBLL().GetLedgerCodeAllocation();
        }
        public List<CostCenterTransation> GetCostCenterTransaction(string Control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostCenterTransaction(Control, Where, Where1);

        }
        public List<CostCenterTransation> DisplayCostcenterTransaction(string Control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().DisplayCostcenterTransaction(Control, Where, Where1);

        }
        public short SaveCostCentertransaction(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount,CostCenterTransation oct)
        {
            return new ACCMSSetupBLL().SaveCostCentertransaction(strRefNo, strCategoryCode, stDate, strCostCenterCode, strLedgerCode, Amount, oct);
        }

        public short UpdateCostCenterTran(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount, CostCenterTransation oct)
        {
            return new ACCMSSetupBLL().UpdateCostCenterTran(strRefNo, strCategoryCode, stDate, strCostCenterCode, strLedgerCode, Amount,oct);
        }
        public List<CostCategoryRO> GetCostCategoryReport(string control, string Where, string Branchid, string fDate, string tDate)
        {
            return new CollectionSummaryBLL().GetCostCategoryReport(control, Where, Branchid, fDate, tDate);
        }
        public List<CashflowRO> GetCashflowReport(string control, string Where, string Branchid, string fDate, string tDate)
        {
            return new CollectionSummaryBLL().GetCashflowReport(control, Where, Branchid, fDate, tDate);
        }
        public short SaveTree(string strparent, string strgroup, string strgroup1)
        {
            return new ACCMSSetupBLL().SaveTree(strparent, strgroup, strgroup1);
        }
        public List<CostCategoryTreeview> GetCostcategoryTreeview(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcategoryTreeview(control, Where, Where1);
        }
        public List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcenterTreeview(control, Where, Where1);
        }
        public List<CollectionRO> GetCollectionHospital(int Where, string F_Date, string T_Date, string strBranchId)
        {
            return new CollectionSummaryBLL().GetCollectionHospital(Where,F_Date, T_Date, strBranchId);
        }
        public List<GroupsConfig> GetGroupTreeviewSelection(string strSelection)
        {
            return new ACCMSSetupBLL().GetGroupTreeviewSelection(strSelection);
        }
        public List<VoucherTransaction> GetArchieve(string Control, string strWhere, int intWhere1, string Fdate, string Tdate, string PostStatus)
        {
            return new ACCMSSetupBLL().GetArchieve(Control, strWhere, intWhere1, Fdate, Tdate,PostStatus);
        }


        public List<BankReconcilation> GetBankReconcilation(string Contol, string where, string Fdate, string Tdate)
        {
            return new ACCMSSetupBLL().GetBankReconcilation(Contol, where, Fdate, Tdate);
        }
        public List<BankReconcilation> GetParticulars(string Contol, string where, string where1)
        {
            return new ACCMSSetupBLL().GetParticulars(Contol, where, where1);
        }
        public Dictionary<string, string> GetLedgerNameBank()
        {
            return new ACCMSSetupBLL().GetLedgerNameBank();
        }
        public short SaveBankReconcilationSetup(string strRefNo, string strBID, int intVtype, string strDate, string strBrLcode, string strLcode, double dblDr, double dblCr,
                                                double dblChildAmount, string strtoby, string strChequeNo, string strchequeDate, string strBankDate, string strBkChargePer,
                                                double dblBkAmount, double dblNetAmount, string sstrPostStatus, BankReconcilation Br)
        {
            return new ACCMSSetupBLL().SaveBankReconcilationSetup(strRefNo, strBID, intVtype, strDate, strBrLcode, strLcode, dblDr, dblCr,
                                                      dblChildAmount, strtoby, strChequeNo, strchequeDate, strBankDate, strBkChargePer,
                                                    dblBkAmount, dblNetAmount, sstrPostStatus, Br);
        }
        public List<BankReconcilationRO> GetBankReconcilationRpt(string Where, string F_Date, string T_Date, string strBranchId)
        {
            return new CollectionSummaryBLL().GetBankReconcilationRpt(Where, F_Date, T_Date, strBranchId);
        }
        public List<FixedAssets> GetLocation()
        {
            return new CollectionSummaryBLL().GetLocation();
        }

        public List<FixedAssets> Getsupplier()
        {
            return new CollectionSummaryBLL().Getsupplier();
        }

        public short SaveAdjustment(FixedAssetsAdjustment FaAdj)
        {
            return new ACCMSSetupBLL().SaveAdjustment(FaAdj);
        }
        public short UpdateAdjustment(FixedAssetsAdjustment FaAdj)
        {
            return new ACCMSSetupBLL().UpdateAdjustment(FaAdj);
        }

        public short DeleteAdjustment(FixedAssetsAdjustment FaAdj)
        {
            return new ACCMSSetupBLL().DeleteAdjustment(FaAdj);
        }
        public List<FixedAssetsAdjustment> GetFixedAssetsAdjustment()
        {
            return new CollectionSummaryBLL().GetFixedAssetsAdjustment();

        }
        public List<FixedAssetsRO> GetFixedAssetsRo(string F_Date, string T_Date, string strWhere)
        {
            return new CollectionSummaryBLL().GetFixedAssetsRo(F_Date, T_Date,strWhere);
        }
        public List<FixedAssets> GetFxdDepreciationLedger()
        {
            return new ACCMSSetupBLL().GetFxdDepreciationLedger();
        }
        public Dictionary<string, string> GetSupplierLedger(string Ledgergroup)
        {
            return new CollectionSummaryBLL().GetSupplierLedger(Ledgergroup);
        }
        public Dictionary<string, string> GetManufacturerName()
        {
            return new CollectionSummaryBLL().GetManufacturerName();
        }
        public List<FixedAssetsDetailsRO> GetFixedAssetsDetailsRo(string F_Date, string T_Date)
        {
            return new CollectionSummaryBLL().GetFixedAssetsDetailsRo(F_Date, T_Date);
        }
        public short SaveWrittenDownValue(string F_Date, string T_Date, string strWhere)
        {
            return new ACCMSSetupBLL().SaveWrittenDownValue(F_Date, T_Date, strWhere);
        }
        public List<TrailBalanceRO> GetTraiBalanceReportsLedger(string F_Date, string T_Date, string strBranchId)
        {
            return new ACCMSSetupBLL().GetTraiBalanceReportsLedger(F_Date, T_Date, strBranchId);
        }
        public List<CashflowRO> GetCashOpening(string fDate, string tDate)
        {
            return new CollectionSummaryBLL().GetCashOpening(fDate, tDate);
        }


        public short UpdateScript(string strLedgercode, string grcode)
        {
            return new CollectionSummaryBLL().UpdateScript(strLedgercode, grcode);
        }


        public short InsertFiscalYear(FinancialYear fy)
        {
            return new ACCMSSetupBLL().InsertFiscalYear(fy);
        }

        public short UpdateFiscalYear(FinancialYear fy)
        {
            return new ACCMSSetupBLL().UpdateFiscalYear(fy);
        }


        public List<FinancialYear> GetFiscalYear()
        {
            return new ACCMSSetupBLL().GetFiscalYear();
        }
        public List<FinancialYear> GetActiveFiscalYear()
        {
            return new ACCMSSetupBLL().GetActiveFiscalYear();
        }

        public short DeleteLedgerTreeview(string strLedgerName, Ledgers fy)
        {
            return new ACCMSSetupBLL().DeleteLedgerTreeview(strLedgerName,fy);
        }

        public short DeleteGroupTreeview(string strGrName, GroupsConfig fy)
        {
            return new ACCMSSetupBLL().DeleteGroupTreeview(strGrName, fy);
        }

        public List<LedgerRO> GetLedgerInformationGrid(string strControl)
        {
            return new CollectionSummaryBLL().GetLedgerInformationGrid(strControl);
        }

        public List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate)
        {
            return new CollectionSummaryBLL().GetCollectionSummary(StartDate, EndDate);
        }

        public List<BankReconcilation> GetBankReconPost(string pwhere)
        {
            return new CollectionSummaryBLL().GetBankReconPost(pwhere);
        }

        public short InsertIntegretedBr(string MofuleRefNo, double dblTotalAmount, int voucheras, string strdate, string LedgerName, string ReverseLEdger, string Narration, int intModule, BankReconcilation fy)
        {
            return new ACCMSSetupBLL().InsertIntegretedBr(MofuleRefNo, dblTotalAmount, voucheras, strdate, LedgerName, ReverseLEdger, Narration, intModule, fy);
        }

        public Dictionary<string, string> GetDeptGroupDicByType(string type)
        {
            return new AdministrationSetupBLL().GetDeptGroupDicByType(type);
        }

        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }


        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(deptgrp, deptid);
        }



    }
}
