using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.PatReg.DAL;

namespace AH.PatReg.BLL
{
    public class PetRegReportBLL
    {
        public List<PatRegRO> GetPatientRegistartionDetailsbyHCN(string WhereCondition)
        {
            return new PatientRegistrationReportDAL().GetPatientRegistartionReport(WhereCondition);
        }

        public List<PatRegRO> GetPatientRegistartionDetailsbyDateRange(string WhereCondition)
        {
            return new PatientRegistrationReportDAL().GetPatientRegistartionReportDR(WhereCondition);
        }

        public List<PatRegRO> GetPatientRegistartionDetails()
        {
            return new PatientRegistrationReportDAL().GetsPatientReg();
        }
        public List<PatRegRO> PatientAdvanceSearch(string WhereCondition)
        {
            return new PatientRegistrationReportDAL().PatientAdvanceSearch(WhereCondition);
        }
    }
}
