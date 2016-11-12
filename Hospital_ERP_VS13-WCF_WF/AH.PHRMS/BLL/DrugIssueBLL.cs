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
    public class DrugIssueBLL
    {
        public string SaveDrugIssue(DrugIssue di)
        {
            return new DrugIssueDAL().SaveDrugIssue(di);
        }
        public string SaveIssueReturn(IssueReturn oret)
        {
            return new DrugIssueDAL().SaveIssueReturn(oret);
        }
        public List<DrugIssue> GetIssueDetails(string issueID)
        {
            return new DrugIssueDAL().GetIssueDetails(issueID);
        }
        public List<DrugIssue> GetIssueDetailsByRegID(string regid)
        {
            return new DrugIssueDAL().GetIssueDetailsByRegID(regid);
        }
        public AccountsPayment GetTicketFees(string userID, string date)
        {
            return new DrugIssueDAL().GetTicketFees(userID,date);
        }
        public short InsertUserCloseRegister(AccountsPayment tktFee)
        {
            return new DrugIssueDAL().InsertUserCloseRegister(tktFee);
        }
    }
}
