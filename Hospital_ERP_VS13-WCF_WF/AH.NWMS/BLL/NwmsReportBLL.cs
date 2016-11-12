using AH.NWMS.DAL;
using AH.NWMS.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.NWMS.BLL
{
    public class NwmsReportBLL
    {
        public List<NWMSReportRO> GetDischargeSummary(string reg_ID)
        {
            return new NwmsReportDAL().GetDischargeSummary(reg_ID);
        }

        public List<NWMSReportRO> DischargeAdvice(string reg_ID)
        {
            return new NwmsReportDAL().DischargeAdvice(reg_ID);
        }
    }
}
