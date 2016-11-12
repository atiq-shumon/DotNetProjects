using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACCMS.MODEL;
using AH.ACCMS.DAL;
using AH.Shared.MODEL;

namespace AH.ACCMS.BLL
{
    public class CollectionSummaryBLL
    {
        public List<CollectionSummaryRO> GetCollectionDetails(string wherecondition)
        {
            return new CollectionSummaryDAL().GetCollectionDetails(wherecondition);
        }
        public List<CollectionSummaryRO> GetsSummary(string wherecondition)
        {
            return new CollectionSummaryDAL().GetsSummary(wherecondition);
        }
        public Dictionary<string,string> GetIndividualVoucherNo(int intvoucherType)
        {
          Dictionary<string,string>  obgVoucher=new Dictionary<string,string>();
          foreach (VoucherRO objVno in new CollectionSummaryDAL().GetIndividualVoucherNo(intvoucherType))
          {
              obgVoucher.Add(objVno.strVoucherNo, objVno.strVoucherNo);
          }
          return obgVoucher;

        }
        public List<VoucherRO> GetIndividualVoucherReports(string F_Date,string T_date,string strBranchID,int intVType,string strControlsName,string strVoucherNo="",string Poststatus="")
        {
            return new CollectionSummaryDAL().GetIndividualVoucherReports(F_Date, T_date, strBranchID, intVType, strControlsName, strVoucherNo, Poststatus);
        }
        public Dictionary<string, string> GetLedgerName(string strControl)
        {
            Dictionary<string, string> objLedger = new Dictionary<string, string>();
            foreach (LedgerRO objLNo in new CollectionSummaryDAL().GetLedgerInformation(strControl))
            {
                objLedger.Add(objLNo.strLedgerCode,objLNo.strLedgerName) ;
            }
            return objLedger;

        }
        public List<LedgerRO> GetLedgerDetailsReport(string strLedgercode,string strBranchId, string fDate, string tDate,string  strControl)
        {
            return new CollectionSummaryDAL().GetLedgerDetailsReport(strLedgercode, strBranchId, fDate, tDate, strControl);
        }
        public List<BalanceSheetRO> DisplayBalanceSheet(string strbranchId, string strFDate, string strTdate, string strDiff, int intPrimaryType, double dblAmount)
        {
            return new CollectionSummaryDAL().DisplayBalanceSheet(strbranchId, strFDate, strTdate, strDiff,intPrimaryType,dblAmount);
        }
        public List<BalanceSheetRO> GetBalanceSheetReports(string f_Date, string t_Date, string strBarnchId)
        {
            return new CollectionSummaryDAL().GetBalanceSheetReports(f_Date, t_Date, strBarnchId);
        }
        public List<InccomeExpensesRO> GetIncomeExpensesReports(string Control, string strBranchId, string F_Date, string T_Date,int primarytype)
        {
            return new CollectionSummaryDAL().GetIncomeExpensesReports(Control, strBranchId, F_Date, T_Date, primarytype);
        }
        public List<ProfitlossRO> GetProfitLossReports(string Control, string strBranchId, string F_Date, string T_Date, int primarytype)
        {
            return new CollectionSummaryDAL().GetProfitLossReports(Control, strBranchId, F_Date, T_Date, primarytype);
        }

        public List<TreeviewRO> GetTreeview(string strRefNo)
        {
            return new CollectionSummaryDAL().GetTreeview(strRefNo);
        }
        public Dictionary<string, string> LoadCategory()
        {
            Dictionary<string, string> obgcategory = new Dictionary<string, string>();
            foreach (CostCategory objcat in new CollectionSummaryDAL().LoadCategory())
            {
                obgcategory.Add(objcat.Categorycode, objcat.Categoryname);
            }
            return obgcategory;

        }
        public Dictionary<string, string> GetLedgerCodeAllocation()
        {
            Dictionary<string, string> obgLed = new Dictionary<string, string>();
            foreach (Ledgers objLedger in new CollectionSummaryDAL().GetLedgerCodeAllocation())
            {
                obgLed.Add(objLedger.strLedgerCode, objLedger.strLedgerName);
            }
            return obgLed;

        }
        public List<CostCenterTransation> GetCostCenterTransaction(string Control, string Where, string Where1)
        {
            return new CollectionSummaryDAL().GetCostcenterTransaction(Control, Where, Where1);

        }
        public List<CostCenterTransation> DisplayCostcenterTransaction(string Control, string Where, string Where1)
        {
            return new CollectionSummaryDAL().DisplayCostcenterTransaction(Control, Where, Where1);

        }

         public List<CostCategoryRO> GetCostCategoryReport(string control, string Where, string Branchid,string fDate,string tDate)
         {
             return new CollectionSummaryDAL().GetCostCategoryReport(control, Where, Branchid, fDate, tDate);
        }

         public List<CashflowRO> GetCashflowReport(string control, string Where, string Branchid, string fDate, string tDate)
         {
             return new CollectionSummaryDAL().GetCashflowReport(control, Where, Branchid, fDate, tDate);
         }
         public List<CostCategoryTreeview> GetCostcategoryTreeview(string control, string Where, string Where1)
         {
             return new CollectionSummaryDAL().GetCostcategoryTreeview(control, Where, Where1);
         }
         public List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1)
         {
             return new CollectionSummaryDAL().GetCostcenterTreeview(control, Where, Where1);
         }
         public List<CollectionRO> GetCollectionHospital(int Where, string F_Date, string T_Date, string strBranchId)
         {
             return new CollectionSummaryDAL().GetCollectionHospital(Where,F_Date, T_Date, strBranchId);
         }
        public List<BankReconcilationRO> GetBankReconcilationRpt(string Where, string F_Date, string T_Date, string strBranchId)
         {
             return new CollectionSummaryDAL().GetBankReconcilationRpt(Where, F_Date, T_Date, strBranchId);
         }

        public List<FixedAssets> GetLocation()
        {
            return new CollectionSummaryDAL().GetLocation();
        }

        public List<FixedAssets> Getsupplier()
        {
            return new CollectionSummaryDAL().Getsupplier();
        }
        public List<FixedAssetsAdjustment> GetFixedAssetsAdjustment()
        {
            return new AccountsDAL().GetFixedAssetsAdjustment();
        }

        public List<FixedAssetsRO> GetFixedAssetsRo(string F_Date, string T_Date,string strWhere)
        {
            return new CollectionSummaryDAL().GetFixedAssetsRo(F_Date, T_Date, strWhere);
        }

        public Dictionary<string, string> GetSupplierLedger(string Ledgergroup)
        {
            Dictionary<string, string> obgLed = new Dictionary<string, string>();
            foreach (Ledgers objLedger in new CollectionSummaryDAL().GetSupplierLedger(Ledgergroup))
            {
                obgLed.Add(objLedger.strLedgerCode, objLedger.strLedgerName);
            }
            return obgLed;

        }
        public Dictionary<string, string> GetManufacturerName()
        {
            Dictionary<string, string> objManu = new Dictionary<string, string>();
            foreach (FixedAssets Manufac in new CollectionSummaryDAL().GetManufacturerName())
            {
                objManu.Add(Manufac.ManufacturerCode, Manufac.ManufacturerName);
            }
            return objManu;

        }
        public List<FixedAssetsDetailsRO> GetFixedAssetsDetailsRo(string F_Date, string T_Date)
        {
            return new CollectionSummaryDAL().GetFixedAssetsDetailsRo(F_Date, T_Date);
        }
        public List<CashflowRO> GetCashOpening(string fDate, string tDate)
        {
            return new AccountsDAL().GetCashOpening(fDate, tDate);
        }

        public short UpdateScript(string strLedgercode, string grcode)
        {
            return new AccountsDAL().UpdateScript(strLedgercode, grcode);
        }
        public List<LedgerRO> GetLedgerInformationGrid(string strControl)
        {
            return new CollectionSummaryDAL().GetLedgerInformationGrid(strControl);
        }



        public List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate)
        {
            return new CollectionSummaryDAL().GetCollectionSummary(StartDate, EndDate);
        }

        public List<BankReconcilation> GetBankReconPost(string pwhere)
        {
            return new AccountsDAL().GetBankReconPost(pwhere);
        }

        



    }
}
