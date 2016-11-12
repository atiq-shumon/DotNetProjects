using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.DAL;
using AH.INVMS.MODEL;

namespace AH.INVMS.BLL
{
    public class POBLL
    {
        public string SavePurchaseOrder(PurchaseOrder opurchaseorder)
        {
            return new PODAL().SavePurchaseOrder(opurchaseorder);
        }
        public List<PurchaseOrder> GetPONumbers()
        {
            return new PODAL().GetPONumbers();
        }
        public List<PurchaseOrder> GetPODetails(string poid)
        {
            return new PODAL().GetPODetails(poid);
        }       
        public short SaveTermsandCondition(TermsAndConditions oterms)
        {
            return new PODAL().SaveTermsandCondition(oterms);
        }
        public short ModifyTermsandCondition(TermsAndConditions oterms)
        {
            return new PODAL().ModifyTermsandCondition(oterms);
        }
        public List<TermsAndConditions> GetTermsandCondition()
        {
            return new PODAL().GetTermsandCondition();
        }
        public List<PurchaseOrder> GetPORecord(string itemid)
        {
            return new PODAL().GetPORecord(itemid);
        }
        public int VarifyPOForModify(string poid)
        {
            return new PODAL().VarifyPOForModify(poid);
        }
    }
}
