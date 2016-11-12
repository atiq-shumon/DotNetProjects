using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.BLL
{
    public  class ACCMSConstraint
    {
        public const string DEFAULT_DATE_FORMAT = "dd-mm-yyyy";
        public const string gcEND_OF_LIST = "End of List";
        

    public enum GROUPTYPE
    {
        MainGroup = 1,
        Subgroup = 2
    }
    public enum SUBGROUPTYPE
    {
        BankAccounts = 100,
        Cash = 101,
        Customer = 202,
        Supplier = 203,
        SalesRep = 204,
        OtherLedger = 205,
        FixedAssets = 206,
        Sales = 211,
        Purchase = 212,
        DirectExpenses = 213,
        OtherIncome = 215,
        ProfitandLoss = 301,
        BranchAccount = 217,

    }
    public enum LEDGERZEROLEVELTYPE
    {
        Asset = 1,
        Liability = 2,
        Income = 3,
        Expenses = 4
    }

    public enum VoucherType
    {
        vtPayment = 1,
        vtReceipt = 2,
        vtJournal = 3,
        vtContra = 4
    }
   public enum ACTIONMODE
    {
        AddMode = 1,
        EditMode = 2,
        DispMode = 3
    }
   public static double val(string x)
   {
       try
       {
           return double.Parse(x);
       }
       catch
       {
           return 0.0;
       }
   }

   public static string cvtOraDate(DateTime vdteDate)
   {
       string strdate;
       strdate = string.Format("{0}-{1}-{2}", vdteDate.Day, vdteDate.Month, vdteDate.Year);
       //strdate = "Convert (DateTime  ,'" + strdate + "', 103)";

       return strdate;
   }
   

}
}