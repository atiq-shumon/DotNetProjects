using AH.IPD.DAL;
using AH.IPD.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.BLL
{
 public class IPDDischargeReportBLL
    {
     public List<DischargeReportRO> GetPatDischargeBillSummary(string regID)
     {
         return new IPDDischargeReportDAL().GetPatDischargeBillSummary(regID);
     }
     public List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string regID)
     {
         return new IPDDischargeReportDAL().GetPatDischargeBillDetails(regID);
     }
     public List<AdvanceDepositRO> GetAdvPayment(string regno)
     {
         return new IPDDischargeReportDAL().GetAdvPayment(regno);
     }

    }
}
