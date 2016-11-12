using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACCMS.MODEL;
using AH.ACCMS.DAL;

namespace AH.ACCMS.BLL
{
   public class ACCMSSetupBLL
    {
        public short SavePurposeSetup(Purpose prs)
        {
            return new  ACCMSSetupDAL().SavePurposeSetup(prs);
        }
        public short SaveBranchSetup(Branch branch)
        {
            return new ACCMSSetupDAL().SaveBranchSetup(branch);
        }
        public short UpdateBranchSetup(Branch branch)
        {
            return new ACCMSSetupDAL().UpdateBranchSetup(branch);
        }
        public short DeleteBranch(Branch branch)
        {
            return new ACCMSSetupDAL().DeleteBranch(branch);
        }
        public short SaveGroupSetup(GroupsConfig grp)
        {
            return new AccountsDAL().SaveGroupSetup(grp);
        }
        public short SaveLedgerSetup(Ledgers  ledger)
        {
            return new AccountsDAL().SaveLedgerSetup(ledger);
        }
        public short UpdatePurpose(Purpose uprs)
        {
            return new ACCMSSetupDAL().UpdatePurpose(uprs);
        }
        public List<Purpose> GetPurpose()
        {
            return new ACCMSSetupDAL().GetPurpose();
        }
        public List<Branch> GetBranch()
        {
            return new ACCMSSetupDAL().GetBranch();
        }
        public int VerifyPurpose(string purposeid)
        {
            return new ACCMSSetupDAL().VerifyPurpose(purposeid);
        }
        public Dictionary<string, string> GetPurpose(string type)
        {
            Dictionary<string, string> purp = new Dictionary<string, string>();
            foreach (Purpose pur in new ACCMSSetupBLL().GetPurpose())
            {
                purp.Add(pur.PurposeID, pur.PurposeTitle);
            }
            return purp;
        }
        public Dictionary<string, string> GetGroups(string type)
        {
            Dictionary<string, string> groups = new Dictionary<string, string>();
            foreach (GroupsConfig grp in new ACCMSSetupDAL().Getgroup())
            {
                groups.Add(grp.GrName, grp.GrName );
            }
            
            return groups;
        }
        public List<GroupsConfig> GetGroupsConfiguration()
        {
            return new AccountsDAL().GetGroupsConfiguration();
        }
        public List<GroupsConfig> GetGroupTreeview()
        {
            return new AccountsDAL().GetGroupTreeview();
        }
        public List<Ledgers> GetLegerTreeview(string strGroups)
        {
            return new AccountsDAL().GetLedgerTreeview(strGroups);
        }
        public Dictionary<string, string> GetLedgerUnder(string type)
        {
            Dictionary<string, string> Ledger = new Dictionary<string, string>();
            foreach (Ledgers  led in new ACCMSSetupDAL().GetLedgerUnder())
            {
                Ledger.Add(led.strLedgerCode , led.strGrUnder);
            }
            return Ledger;
        }
        public List<Ledgers> GetDebitTotal()
        {
            return new AccountsDAL().GetDebitTotal();
        }
        public List<Ledgers> GetCreditTotal()
        {
            return new AccountsDAL().GetCreditTotal();
        }
        public List<Ledgers> GetLedgersNameDr()
        {
            return new AccountsDAL().GetLedgersNameDr();
        }
        public List<Ledgers> GetLedgersNameCr()
        {
            return new AccountsDAL().GetLedgersNameCr();
        }
        public List<Ledgers> CheckBankLedger(string strLedgersName)
        {
            return new AccountsDAL().CheckBankLedger(strLedgersName);
        }
        public List<Ledgers> GetAllLedgers()
        {
            return new AccountsDAL().GetAllLedgers();
        }
        public List<VoucherTransaction> GetVoucherNo(int  lngVoucherType)
        {
            return new AccountsDAL().GetVoucherNo(lngVoucherType);
        }
        public string SaveVoucherSetup(string strRefNo,VoucherTransaction objVoucher)
        {
            return new AccountsDAL().SaveVoucherSetup(strRefNo,objVoucher);
        }
        public short SaveVoucheChildrSetup(string strRefNo,VoucherTransaction objVoucher)
        {
            return new AccountsDAL().SaveVoucheChildrSetup(strRefNo, objVoucher);
        }
        public List<VoucherTransaction> GetVoucherTransactionDetails(int lngVoucherType, string fdate, string tdate, string Poststatus)
        {
            return new AccountsDAL().GetVoucherTransactionDetails(lngVoucherType,fdate,tdate,Poststatus );
        }
        public short UpdateGroupSetup(GroupsConfig objGroups)
        {
            return new AccountsDAL().UpdateGroupSetup(objGroups);
        }
        public short DeleteGroupSetup(GroupsConfig objGroups)
        {
            return new AccountsDAL().DeleteGroupSetup(objGroups);
        }
        public List<Ledgers> GetLedgersDetails()
        {
            return new AccountsDAL().GetLedgersDetails();
        }
        public short DeleteLedger(long lngSlNo)
        {
            return new AccountsDAL().DeleteLedger(lngSlNo);
        }
        public List<Ledgers> GetDisplayLedgers(long lngSlNo)
        {
            return new AccountsDAL().GetDisplayLedgers(lngSlNo);
        }
        public short UpdateLedgerSetup(Ledgers ldr)
        {
            return new AccountsDAL().UpdateLedgerSetup(ldr);
        }
        public List<Ledgers> GetLedegrCode(string strLedgerName)
        {
            return new AccountsDAL().GetLedegrCode(strLedgerName);
        }
        public List<Ledgers> GetLederName(string strLedgerCode)
        {
            return new AccountsDAL().GetLederName(strLedgerCode);
        }
        public short DeleteVoucher(string strVoucherNo, int vintVoucherType)
        {
            return new AccountsDAL().DeleteVoucher(strVoucherNo, vintVoucherType);
        }
        public short SaveFixedAssetsSetup(FixedAssets fassets)
        {
            return new AccountsDAL().SaveFixedAssetsSetup(fassets);
        }
        public List<FixedAssets> GetFixedAssetsLedger()
        {
            return new AccountsDAL().GetFixedAssetsLedger();
        }
        public List<VoucherTransaction> GetdisplayvoucherDetails(string strRefNo, int vType)
        {
            return new AccountsDAL().GetvoucherDetails(strRefNo, vType);
        }
        public List<LedgerRO> GetLedgerReports(string strVoucherNo)
        {
            return new CollectionSummaryDAL().GetLedgerReports(strVoucherNo);
        }
        public Dictionary<string, string> GetBranchConfig(string type)
        {
            Dictionary<string, string> objBran = new Dictionary<string, string>();
            foreach(Branch bran in new AccountsDAL().GetBranchConfig())
            {
                objBran.Add(bran.BranchID, bran.BranchName);
            }
            return objBran;
        }
        public List<TrailBalanceRO> GetTraiBalanceReports(string f_Date,string t_Date,string strBarnchId)
        {
            return new CollectionSummaryDAL().GetTraiBalanceReports(f_Date, t_Date, strBarnchId);
        }
        public List<TrailBalanceRO> DisplayTrailBalance(string strDiffName, double dblDiffAmount)
        {
            return new CollectionSummaryDAL().DisplayTrailBalance(strDiffName, dblDiffAmount); 
        }
        public List<VoucherTransaction> GetVoucherSearch(string strVoucherNo,int intvtype)
        {
            return new AccountsDAL().GetVoucherSearch(strVoucherNo, intvtype); 
        }
        public short InsertLedgerOpening(LedgerOpening objTran)
        {
            return new AccountsDAL().InsertLedgerOpening(objTran);
        }
        public short UpdateLedgerOpening(LedgerOpening objTran)
        {
            return new AccountsDAL().UpdateLedgerOpening(objTran);
        }
        public List<LedgerOpening> GetLedgerOpn()
        {
            return new AccountsDAL().GetLedgerOpnDetails();
        }
        public Dictionary<string, string> GetLedgersNameDrNew(string type)
        {
            Dictionary<string, string> ledger = new Dictionary<string, string>();
            foreach (Ledgers ldr in new AccountsDAL().GetLedgersNameDrNew())
            {
                ledger.Add(ldr.strLedgerCode, ldr.strLedgerName);
            }
            return ledger;
        }
       public Dictionary<string, string> GetBraNewConfig(string type)
        {
            Dictionary<string, string> Branch = new Dictionary<string, string>();
            foreach (Branch brn in new ACCMSSetupDAL().GetBranch())
            {
                Branch.Add(brn.BranchID, brn.BranchName);
            }
            return Branch;
        }
       public List<FixedAssets> LoadFixedAssetsLedger()
       {
           return new AccountsDAL().LoadFixedAssetsLedger();
       }

       public short UpdateFixedAssetsSetup(FixedAssets objTran)
       {
           return new AccountsDAL().UpdateFixedAssetsSetup(objTran);
       }
       public short DeleteFixedAssetsSetup(FixedAssets objTran)
       {
           return new AccountsDAL().DeleteFixedAssetsSetup(objTran);
       }
       public List<GroupsConfig> GetgroupDetails(string strGroupName)
       {
           return new AccountsDAL().GetgroupDetails(strGroupName);

       }
       public short SaveCategorySetup(CostCategory cat)
       {
           return new AccountsDAL().SaveCategorySetup(cat);
       }
       public short UpdateCategorySetup(CostCategory cat)
       {
           return new AccountsDAL().UpdateCategorySetup(cat);
       }
       public short DeleteCategorySetup(string strCatCode,CostCategory cat)
       {
           return new AccountsDAL().DeleteCategorySetup(strCatCode,cat);
       }
       public List<CostCategory> GetCostCategory()
       {
           return new CollectionSummaryDAL().GetCostCategory();
       }

       //public List<CostCenterTransation> GetCostCenterTransaction(string Where)
       //{
       //    return new CollectionSummaryDAL().GetCostcenterTransaction(Where);
       //}
       public List<CostCenterTransation> GetCostCenterTransaction(string Control, string Where, string Where1)
       {
           return new CollectionSummaryDAL().GetCostcenterTransaction(Control, Where, Where1);

       }
       public List<CostCenterTransation> DisplayCostcenterTransaction(string Control, string Where, string Where1)
       {
           return new CollectionSummaryDAL().DisplayCostcenterTransaction(Control, Where, Where1);

       }

       public short SaveCostCentertransaction(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount,CostCenterTransation oct)
       {
           return new AccountsDAL().SaveCostCentertransaction(strRefNo, strCategoryCode, stDate, strCostCenterCode, strLedgerCode, Amount, oct);
       }

       public short UpdateCostCenterTran(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount, CostCenterTransation oct)
       {
           return new AccountsDAL().UpdateCostCenterTran(strRefNo, strCategoryCode, stDate, strCostCenterCode, strLedgerCode, Amount,oct);
       }

       public short SaveTree(string strparent, string strgroup, string strgroup1)
       {
           return new AccountsDAL().SaveTree(strparent, strgroup, strgroup1);
       }
       public List<GroupsConfig> GetGroupTreeviewSelection(string strSelection)
      {
          return new AccountsDAL().GetGroupTreeviewSelection(strSelection);
      }
       public List<VoucherTransaction> GetArchieve(string Control, string strWhere, int intWhere1, string Fdate, string Tdate, string PostStatus)
      {
          return new AccountsDAL().GetArchieve(Control, strWhere, intWhere1, Fdate, Tdate, PostStatus);
      }
       public List<BankReconcilation> GetBankReconcilation(string Contol, string where, string Fdate, string Tdate)
     {
         return new AccountsDAL().GetBankReconcilation(Contol, where, Fdate, Tdate);
     }
       public List<BankReconcilation> GetParticulars(string Contol, string where, string where1)
     {
         return new AccountsDAL().GetParticulars(Contol, where, where1);
     }
    
       public Dictionary<string, string> GetLedgerNameBank()
    {
        Dictionary<string, string> objled = new Dictionary<string, string>();
        foreach (Ledgers ledger in new AccountsDAL().GetLedgerNameBank())
        {
            objled.Add(ledger.strLedgerCode, ledger.strLedgerName);
        }
        return objled;
    }
   public short SaveBankReconcilationSetup(string strRefNo, string strBID, int intVtype, string strDate, string strBrLcode, string strLcode, double dblDr, double dblCr,
                                                double dblChildAmount, string strtoby, string strChequeNo, string strchequeDate, string strBankDate, string strBkChargePer,
                                                double dblBkAmount, double dblNetAmount, string sstrPostStatus, BankReconcilation Br)
        {
            return new AccountsDAL().SaveBankReconcilationSetup(strRefNo, strBID, intVtype, strDate, strBrLcode, strLcode, dblDr, dblCr,
                                                      dblChildAmount, strtoby, strChequeNo, strchequeDate, strBankDate,strBkChargePer,
                                                    dblBkAmount, dblNetAmount, sstrPostStatus, Br);
        }
       public short SaveAdjustment(FixedAssetsAdjustment FaAdj)
    {
        return new AccountsDAL().SaveAdjustment(FaAdj);
    }
       public short UpdateAdjustment(FixedAssetsAdjustment FaAdj)
    {
        return new AccountsDAL().UpdateAdjustment(FaAdj);
    }
       public short DeleteAdjustment(FixedAssetsAdjustment FaAdj)
    {
        return new AccountsDAL().DeleteAdjustment(FaAdj);
    }

       public List<FixedAssets> GetFxdDepreciationLedger()
       {
           return new AccountsDAL().GetFxdDepreciationLedger();
       }
       public short SaveWrittenDownValue(string F_Date, string T_Date, string strWhere)
       {
           return new CollectionSummaryDAL().SaveWrittenDownValue(F_Date,T_Date,strWhere);
       }
       public List<TrailBalanceRO> GetTraiBalanceReportsLedger(string F_Date, string T_Date, string strBranchId)
       {
           return new CollectionSummaryDAL().GetTraiBalanceReportsLedger(F_Date, T_Date, strBranchId);
       }


       public short InsertFiscalYear(FinancialYear fy)
       {
           return new AccountsDAL().InsertFiscalYear(fy);
       }

       public short UpdateFiscalYear(FinancialYear fy)
       {
           return new AccountsDAL().UpdateFiscalYear(fy);
       }


       public List<FinancialYear> GetFiscalYear()
       {
           return new AccountsDAL().GetFiscalYear();
       }

       public List<FinancialYear> GetActiveFiscalYear()
       {
           return new AccountsDAL().GetActiveFiscalYear();
       }
       public short DeleteLedgerTreeview(string  strLedgerName,Ledgers fy)
       {
           return new AccountsDAL().DeleteLedgerTreeview(strLedgerName, fy);
       }

       public short DeleteGroupTreeview(string strGrName, GroupsConfig fy)
       {
           return new AccountsDAL().DeleteGroupTreeview(strGrName, fy);
       }

       public short InsertIntegretedBr(string MofuleRefNo, double dblTotalAmount, int voucheras, string strdate, string LedgerName, string ReverseLEdger, string Narration, int intModule, BankReconcilation fy)
       {
           return new AccountsDAL().InsertIntegretedBr(MofuleRefNo, dblTotalAmount, voucheras, strdate, LedgerName, ReverseLEdger, Narration, intModule, fy);
       }





   }
}
