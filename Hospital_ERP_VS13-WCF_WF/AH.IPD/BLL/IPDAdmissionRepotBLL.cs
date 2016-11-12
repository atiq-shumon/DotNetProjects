
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.IPD.DAL;
using AH.DUtility;
using AH.IPD.MODEL;
using AH.Shared.MODEL;

namespace AH.IPD.BLL
{
    public class IPDAdmissionRepotBLL
    {
        public List<AdmissionReportRO> GetAdmissionMoneyReceipt(string moneyReceiptNo)
        {
            return new IPDAdmissionReportDAL().GetAdmissionMoneyReceipt(moneyReceiptNo);
        }
        public List<AdmissionReportRO> GetAdmissionCard(string moneyReceiptNo)
        {
            return new IPDAdmissionReportDAL().GetAdmissionCard(moneyReceiptNo);
        }
        public List<AdmissionReportRO> GetAdmittedPatReportList(DateTime fromDate, DateTime toDate)
        {
            return new IPDAdmissionReportDAL().GetAdmittedPatReportList(fromDate, toDate);
        }
     
    }
}
