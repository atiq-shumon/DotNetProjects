using AH.IPD.DAL;
using AH.IPD.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.BLL
{
    public class IPDReportBLL
    {
     //public List<DischargeReportRO> GetPatDischargeBillSummary(string regID)
     //{
     //    return new IPDDischargeReportDAL().GetPatDischargeBillSummary(regID);
     //}
     //public List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string regID)
     //{
     //    return new IPDDischargeReportDAL().GetPatDischargeBillDetails(regID);
     //}
        public List<IPDDeathRO> DeathCertificate(string regID)
        {
            return new IPDReportDAL().DeathCertificate(regID);
        }
        public List<IPDBirthCertificateRO> BirthCertificate(string regID)
        {
            return new IPDReportDAL().BirthCertificate(regID);
        }
    }
}
