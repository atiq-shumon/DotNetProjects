using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.INVMS.DAL;

namespace AH.INVMS.BLL
{
    public class IRSetupBLL
    {
        public short SaveIssueRequisition(IssueRequisition oissue)
        {
            return new IRSetupDAL().SaveIssueRequisition(oissue);
        }
        public List<IssueRequisition> GetIRNumbers()
        {
            return new IRSetupDAL().GetIRNumbers();
        }
        public List<IssueRequisition> GetIRDetails(string irid)
        {
            return new IRSetupDAL().GetIRDetails(irid);
        }
    }
}
