using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AH.PatReg.MODEL;
using AH.IPD.DAL;
using AH.DUtility;
using AH.Shared.MODEL;
using AH.IPD.MODEL;

namespace AH.IPD.BLL
{
    public class IPDCertificateBLL
    {
        public string SavePatientDeath(PatientDeath death)
        {
            return new IPDCertificateDAL().SavePatientDeath(death);
        }
        public string SaveChildBirth(IPDBirth birth)
        {
            return new IPDCertificateDAL().SaveChildBirth(birth);
        }
    }
}
