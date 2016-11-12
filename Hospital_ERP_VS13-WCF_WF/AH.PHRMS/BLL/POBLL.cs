using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PHRMS.DAL;
using AH.PHRMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PHRMS.BLL
{
    public class POBLL
    {
        public string SavePurchaseOrder(PurchaseOrder po)
        {
            return new PODAL().SavePurchaseOrder(po);
        }
        public List<PurchaseOrder> GetPONumbers(string pharmacyID)
        {
            return new PODAL().GetPONumbers(pharmacyID);
        }
        public List<PurchaseOrder> GetPODetails(string poid, string phrid)
        {
            return new PODAL().GetPODetails(poid,phrid);
        }
        public short SavePOType(POTypes type)
        {
            return new PODAL().SavePOType(type);
        }
        public List<POTypes> GetPOTypes()
        {
            return new PODAL().GetPOTypes();
        }       
        public short ModifyPOType(POTypes type)
        {
            return new PODAL().ModifyPOType(type);
        }
     
        public List<PurchaseOrder> GetPOList(string poid)
        {
            return new PODAL().GetPOList(poid);
        }
        public List<PurchaseOrder> GetPONum()
        {
            return new PODAL().GetPONum();
        }
        public short SaveTermsandCondition(TermsAndConditions oterms)
        {
            return new PODAL().SaveTermsandCondition(oterms);
        }
        public List<TermsAndConditions> GetTermsandCondition()
        {
            return new PODAL().GetTermsandCondition();
        }
        public short ModifyTermsandCondition(TermsAndConditions oterms)
        {
            return new PODAL().ModifyTermsandCondition(oterms);
        }
    }
}
