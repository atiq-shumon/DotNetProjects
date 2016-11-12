using AH.IPD.DAL;
using AH.IPD.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.BLL
{
 public class IPDDischargeBillSummaryReportBLL
    {
     public List<DischargeReportRO> GetPatDischargeBillSummary(string regID)
     {
         return new IPDDischargeBillSummaryReportDAL().GetPatDischargeBillSummary(regID);
     }
    }
}
