using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.IPDShared.MODEL;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.DMS.DAL;
using AH.DTMS.MODEL;
using AH.HR.BLL;
using AH.ORGMS.BLL;
using AH.IPDShared.BLL;

namespace AH.DMS.BLL
{
    public class OtherRefferrenceSetupBLL
    {
        public short SaveReffdOrg(RefdOrg oReff)
        {
            return new OtherRefferrenceSetupDAL().SaveReffdOrg(oReff);
        }
        public short UpdateReffdOrg(RefdOrg oReff)
        {
            return new OtherRefferrenceSetupDAL().UpdateReffdOrg(oReff);
        }
        public List<RefdOrg> GetReffdOrg()
        {
            return new OtherRefferrenceSetupDAL().GetReffdOrg();
        }
        public Dictionary<string, string> GetReffdOrgDic(string type)
        {
            Dictionary<string, string> oOrgDict = new Dictionary<string, string>();
            oOrgDict.Add("", "--Select--");
            foreach (RefdOrg oOrg in new OtherRefferrenceSetupDAL().GetReffdOrg())
            {
                oOrgDict.Add(oOrg.OrgID, oOrg.OrgTitle);
            }
            return oOrgDict;
        }
        public short SaveReffdDoc(RefdDoc oReff)
        {
            return new OtherRefferrenceSetupDAL().SaveReffdDoc(oReff);
        }
        public short UpdateReffdDoc(RefdDoc oReff)
        {
            return new OtherRefferrenceSetupDAL().UpdateReffdDoc(oReff);
        }
        public List<RefdDoc> GetReffdDoc(string OrgID)
        {
            return new OtherRefferrenceSetupDAL().GetReffdDoc(OrgID);
        }
        public Dictionary<string, string> GetReffdDocDic(string OrgID)
        {
            Dictionary<string, string> oDocDict = new Dictionary<string, string>();
            oDocDict.Add("", "--Select--");
            foreach (RefdDoc oDoc in new OtherRefferrenceSetupDAL().GetReffdDoc(OrgID))
            {
                oDocDict.Add(oDoc.DocID, oDoc.DocTitle);
            }
            return oDocDict;
        }
    }
}
