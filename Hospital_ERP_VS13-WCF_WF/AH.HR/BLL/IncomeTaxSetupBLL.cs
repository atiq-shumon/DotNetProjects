using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.HR.DAL;
using AH.Shared.MODEL;

namespace AH.HR.BLL
{
    public class IncomeTaxSetupBLL
    {
        public short SaveIncomeTax(IncomeTax oIncomeTax)
        {
            return new IncomeTaxSetupDAL().SaveIncomeTax(oIncomeTax);
        }
         public short UpdateIncomeTax(IncomeTax oIncomeTax)
        {
            return new IncomeTaxSetupDAL().UpdateIncomeTax(oIncomeTax);
        }
         public List<IncomeTax> GetIncomeTax(string oIncomeTax)
         {
             return new IncomeTaxSetupDAL().GetIncomeTax(oIncomeTax);
         }
        public List<IncomeTax> GetIncomeTaxInfo(string FiscalYear,string Category)
         {
             return new IncomeTaxSetupDAL().GetIncomeTaxInfo(FiscalYear, Category);
         }
    }
}
