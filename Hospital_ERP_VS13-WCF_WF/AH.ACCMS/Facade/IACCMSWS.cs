using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ACCMS.MODEL;
using AH.Shared.MODEL;
namespace AH.ACCMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IACCMSWS" in both code and config file together.
    [ServiceContract]
    public interface IACCMSWS
    {
        [OperationContract]
        short SavePurposeSetup(Purpose prs);
        [OperationContract]
        short UpdatePurpose(Purpose uprs);
        [OperationContract]
        List<Purpose> GetPurpose();
        [OperationContract]
        int VerifyPurpose(string purposeid);
        [OperationContract]
        List<CollectionSummaryRO> GetCollectionDetails(string wherecondition);
        [OperationContract]
        List<CollectionSummaryRO> GetsSummary(string wherecondition);
        [OperationContract]
        short SaveBranchSetup(Branch Branch);
        [OperationContract]
        List<Branch> GetBranch();
        [OperationContract]
        Dictionary<string, string> GetGroups(string type);
        [OperationContract]
        short SaveGroupSetup(GroupsConfig grp);
        [OperationContract]
        List<GroupsConfig> GetGroupsConfiguration();
        [OperationContract]
        List<GroupsConfig> GetGroupTreeview();
        [OperationContract]
        List<Ledgers> GetLegerTreeview(string strGroups);
        [OperationContract]
        Dictionary<string, string> GetLedgerUnder(string type);
        [OperationContract]
        short SaveLedgerSetup(Ledgers Ledger);
        [OperationContract]
        List<Ledgers> GetDebitTotal();
        [OperationContract]
        List<Ledgers> GetCreditTotal();
        [OperationContract]
        List<Ledgers> GetLedgersNameDr();
        [OperationContract]
        List<Ledgers> GetLedgersNameCr();
        [OperationContract]
        List<Ledgers> CheckBankLedger(string  strLedgerName);
        [OperationContract]
        List<Ledgers> GetAllLedgers();
        [OperationContract]
        List<VoucherTransaction> GetVoucherNo(int  lngVoucherType);
        [OperationContract]
        string SaveVoucherSetup(string strRefNo,VoucherTransaction objVoucher);
        [OperationContract]
        short SaveVoucheChildrSetup(string strRefNo,VoucherTransaction objVoucher);
        [OperationContract]
        //List<VoucherTransaction> GetVoucherTransactionDetails(int lngVoucherType, string fdate, string tdate);
        List<VoucherTransaction> GetVoucherTransactionDetails(int lngVoucherType, string fdate, string tdate, string Poststatus);
        [OperationContract]
        short UpdateBranchSetup(Branch Branch);
        [OperationContract]
        short DeleteBranch(Branch Branch);
        [OperationContract]
        short UpdateGroupSetup(GroupsConfig groups);
        [OperationContract]
        short DeleteGroupSetup(GroupsConfig groups);
        [OperationContract]
        List<Ledgers> GetLedgersDetails();
        [OperationContract]
        short DeleteLedger(long lngSlNo);
        [OperationContract]
        List<Ledgers> GetDisplayLedgers(long lngSlNo);
        [OperationContract]
        short UpdateLedgerSetup(Ledgers ldr);
        [OperationContract]
        List<Ledgers> GetLedegrCode(string strLedgerName);
        [OperationContract]
        List<Ledgers> GetLederName(string strLedgerCode);
        [OperationContract]
        short DeleteVoucher(string strVoucherNo, int vintVoucherType);
        [OperationContract]
        short SaveFixedAssetsSetup(FixedAssets fassets);
        [OperationContract]
        List<FixedAssets> GetFixedAssetsLedger();
        [OperationContract]
        List<VoucherTransaction> GetdisplayvoucherDetails(string  strRefNo, int vType);
        [OperationContract]
        List<LedgerRO> GetLedgerReports(string strRefNo);
        [OperationContract]
        Dictionary<string, string> GetBranchConfig(string type);
        [OperationContract]
        List<TrailBalanceRO> GetTraiBalanceReports(string f_date, string t_date, string strBranchID);
        [OperationContract]
        List<TrailBalanceRO> DisplayTrailBalance(string strDiffName, double dblDiffAmount);
        [OperationContract]
        Dictionary<string, string> GetIndividualVoucherNo(int intvouchertype);
        [OperationContract]
        List<VoucherRO> GetIndividualVoucherReports(string F_Date, string T_date, string strBranchID, int intVType, string strControlsName, string strVoucherNo = "", string PostStatus = "");
        [OperationContract]
        Dictionary<string, string> GetLedgerInformation(string strControl);
        [OperationContract]
        List<LedgerRO> GetLedgerDetailsReport(string strLedgercode, string strBranchId, string fDate, string tDate, string strControl);
        [OperationContract]
        List<VoucherTransaction> GetVoucherSearch(string strVoucherNo, int intvtype);
        [OperationContract]
        short InsertLedgerOpening(LedgerOpening objTran);
        [OperationContract]
        short UpdateLedgerOpening(LedgerOpening objTran);
        [OperationContract]
        List<LedgerOpening> GetLedgerOpn();
        [OperationContract]
        Dictionary<string, string> GetLedgersNameDrNew(string type);
        [OperationContract]
        Dictionary<string, string> GetBraNewConfig(string type);
        [OperationContract]
        List<BalanceSheetRO> DisplayBalanceSheet(string strbranchId, string strFDate, string strTdate, string strDiff, int intPrimaryType, double dblAmount);
        [OperationContract]
        List<BalanceSheetRO> GetBalanceSheetReports(string f_Date, string t_Date, string strBarnchId);
        [OperationContract]
        List<InccomeExpensesRO> GetIncomeExpensesReports(string Control, string strBranchId, string F_Date, string T_Date, int primarytype);
        [OperationContract]
        List<ProfitlossRO> GetProfitLossReports(string Control, string strBranchId, string F_Date, string T_Date, int primarytype);
        [OperationContract]
        List<FixedAssets> LoadFixedAssetsLedger();
        [OperationContract]
        short UpdateFixedAssetsSetup(FixedAssets objTran);
        [OperationContract]
        short DeleteFixedAssetsSetup(FixedAssets objTran);
        [OperationContract]
        List<TreeviewRO> GetTreeview(string strRefNo);
        [OperationContract]
        List<GroupsConfig> GetgroupDetails(string strGroupName);
        [OperationContract]
        short SaveCategorySetup(CostCategory cat);
        [OperationContract]
        short UpdateCategorySetup(CostCategory cat);
        [OperationContract]
        short DeleteCategorySetup(string strCatCode, CostCategory cat);
        [OperationContract]
        List<CostCategory> GetCostCategory();
        [OperationContract]
        Dictionary<string, string> LoadCategory();
        [OperationContract]
        short SaveRevenueHeadGr(RevenueHeadGroup rvgr);
        [OperationContract]
        short UpdateRevHdGr(RevenueHeadGroup urvgr);
        [OperationContract]
        short SaveRevenueHead(RevenueHead rvihd);
        [OperationContract]
        short UpdateRevHead(RevenueHead urvshd);
        [OperationContract]
        List<RevenueHeadGroup> GetRevHdGrps();
        [OperationContract]
        int VerifyRevHdGr(string groupid);
        //[OperationContract]
        //Dictionary<string, string> GetRevHdGrps(string type);
        [OperationContract]
        List<RevenueHead> GetRevenueHead();
        [OperationContract]
        List<RevenueHead> GetRevenueHeads(string headgr);
        [OperationContract]
        int VerifyRevHead(string headid);
        [OperationContract]
        short SaveHeadAssign(DepartmentRevenueHead hdas);
        [OperationContract]
        short UpdateHdAss(DepartmentRevenueHead uhdas);
        [OperationContract]
        List<DepartmentRevenueHead> GetHeadAssign();
        [OperationContract]
        Dictionary<string, string> GetRevenueGroup();
        [OperationContract]
        Dictionary<string, string> GetLedgerCodeAllocation();
        [OperationContract]
        List<CostCenterTransation> GetCostCenterTransaction(string Control, string Where,string Where1);
        [OperationContract]
        List<CostCenterTransation> DisplayCostcenterTransaction(string Control, string Where, string Where1);
        [OperationContract]
        short SaveCostCentertransaction(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount,CostCenterTransation oct);
        [OperationContract]

        short UpdateCostCenterTran(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount,CostCenterTransation oct);
        [OperationContract]
        List<CostCategoryRO> GetCostCategoryReport(string control, string Where, string Branchid, string fDate, string tDate);
        [OperationContract]
        List<CashflowRO> GetCashflowReport(string control, string Where, string Branchid, string fDate, string tDate);
        [OperationContract]
        short SaveTree(string strparent, string strgroup, string strgroup1);
        [OperationContract]
        List<CostCategoryTreeview> GetCostcategoryTreeview(string control, string Where, string Where1);
        [OperationContract]
        List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1);
        [OperationContract]
        List<CollectionRO> GetCollectionHospital(int Where, string F_Date, string T_Date, string strBranchId);
        [OperationContract]
        List<GroupsConfig> GetGroupTreeviewSelection(string strSelection);
        [OperationContract]
        List<VoucherTransaction> GetArchieve(string Control, string strWhere, int intWhere1, string Fdate, string Tdate, string PostStatus);
        [OperationContract]
        List<BankReconcilation> GetBankReconcilation(string Contol, string where, string Fdate, string Tdate);
        [OperationContract]
        List<BankReconcilation> GetParticulars(string Contol, string where, string where1);
        [OperationContract]
        Dictionary<string, string> GetLedgerNameBank();
        [OperationContract]
        short SaveBankReconcilationSetup(string strRefNo, string strBID, int intVtype, string strDate, string strBrLcode, string strLcode, double dblDr, double dblCr,
                                               double dblChildAmount, string strtoby, string strChequeNo, string strchequeDate, string strBankDate, string strBkChargePer,
                                               double dblBkAmount, double dblNetAmount, string sstrPostStatus, BankReconcilation Br);
        [OperationContract]
        List<BankReconcilationRO> GetBankReconcilationRpt(string Where, string F_Date, string T_Date, string strBranchId);
        [OperationContract]
        List<FixedAssets> GetLocation();
        [OperationContract]
        List<FixedAssets> Getsupplier();
        [OperationContract]
        short SaveAdjustment(FixedAssetsAdjustment FaAdj);
        [OperationContract]
        short UpdateAdjustment(FixedAssetsAdjustment FaAdj);
        [OperationContract]
        short DeleteAdjustment(FixedAssetsAdjustment FaAdj);
        [OperationContract]
        List<FixedAssetsAdjustment> GetFixedAssetsAdjustment();
        [OperationContract]
        List<FixedAssetsRO> GetFixedAssetsRo(string F_Date, string T_Date, string strWhere);
        [OperationContract]
        List<FixedAssets> GetFxdDepreciationLedger();
        [OperationContract]
        Dictionary<string, string> GetSupplierLedger(string Ledgergroup);
        [OperationContract]
        Dictionary<string, string> GetManufacturerName();
        [OperationContract]
        List<FixedAssetsDetailsRO> GetFixedAssetsDetailsRo(string F_Date, string T_Date);
        [OperationContract]
        short SaveWrittenDownValue(string F_Date, string T_Date, string strWhere);
        [OperationContract]
        List<TrailBalanceRO> GetTraiBalanceReportsLedger(string F_Date, string T_Date, string strBranchId);
        [OperationContract]
        List<CashflowRO> GetCashOpening(string fDate, string tDate);
        [OperationContract]
        short UpdateScript(string strLedgercode, string grcode);

        [OperationContract]
        short InsertFiscalYear(FinancialYear fy);
        [OperationContract]
        short UpdateFiscalYear(FinancialYear fy);
        [OperationContract]
        List<FinancialYear> GetFiscalYear();

        [OperationContract]
        List<FinancialYear> GetActiveFiscalYear();
        [OperationContract]
        short DeleteLedgerTreeview(string strLedgerName, Ledgers fy);

        [OperationContract]
        short DeleteGroupTreeview(string strGrName, GroupsConfig fy);
        [OperationContract]
        List<LedgerRO> GetLedgerInformationGrid(string strControl);
        [OperationContract]
        List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate);
        [OperationContract]
        List<BankReconcilation> GetBankReconPost(string pwhere);
        [OperationContract]
        short InsertIntegretedBr(string MofuleRefNo, double dblTotalAmount, int voucheras, string strdate, string LedgerName, string ReverseLEdger, string Narration, int intModule, BankReconcilation fy);

        [OperationContract]
        Dictionary<string, string> GetDeptGroupDicByType(string type);

        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);

        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid);

    }
}
