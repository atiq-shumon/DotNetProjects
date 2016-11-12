using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DUtility;
using AH.OracleManager;
using AH.PHRMS.MODEL;
using AH.PRMS.MODEL;
using AH.INVMS.MODEL;
using AH.DRUGS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PHRMS.DAL
{
    public class DrugIssueDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region SaveDrugIssue
        public string SaveDrugIssue(DrugIssue di)
        {
            string packageName = "PKG_ISSUE.SAVE_ISSUE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,di.ID,ParameterDirection.Output),
                new OracleParameter("Pharmacy",OracleDbType.Varchar2,6,di.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("DemandRequisition",OracleDbType.Varchar2,15,di.NurseDemandRequisition.DrID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,di.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,4,di.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("Consumption",OracleDbType.Varchar2,10,di.ConsumptionID,ParameterDirection.Input),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,di.HCN,ParameterDirection.Input),
                new OracleParameter("PrescriptionNo",OracleDbType.Varchar2,30,di.TicketNo,ParameterDirection.Input),
                new OracleParameter("RegID",OracleDbType.Varchar2,15,di.RegID,ParameterDirection.Input),
                new OracleParameter("StaffID",OracleDbType.Varchar2,30,di.Staff,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,10,di.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,10,di.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Doctor",OracleDbType.Varchar2,30,di.Doctor,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,10,di.TransactionType,ParameterDirection.Input),
                new OracleParameter("IssueDate",OracleDbType.Date,di.IssueDate,ParameterDirection.Input),
                new OracleParameter("ReceivedBy",OracleDbType.Varchar2,20,di.EmployeeMaster.ID,ParameterDirection.Input),
                new OracleParameter("IssueType",OracleDbType.Varchar2,1,di.IssueType,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,di.Remarks,ParameterDirection.Input),
                new OracleParameter("IssueDetails",OracleDbType.Varchar2,32000,di.IssueString,ParameterDirection.Input),
                new OracleParameter("PurposeID",OracleDbType.Varchar2,20,di.PharmacyPayment.PurposeID,ParameterDirection.Input),
                new OracleParameter("DepartmentFee",OracleDbType.Int32,di.PharmacyPayment.DeptAmount,ParameterDirection.Input),
                new OracleParameter("Discount",OracleDbType.Int32,di.PharmacyPayment.Discount,ParameterDirection.Input),
                new OracleParameter("VAT",OracleDbType.Int32,di.PharmacyPayment.VAT,ParameterDirection.Input),
                new OracleParameter("NetAmount",OracleDbType.Int32,di.PharmacyPayment.NetAmount,ParameterDirection.Input),
                new OracleParameter("PayType",OracleDbType.Varchar2,1,di.PharmacyPayment.PaymentType,ParameterDirection.Input),
                new OracleParameter("PaymentString",OracleDbType.Varchar2,100000,di.PharmacyPayment.PaymentString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,di.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,di.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,di.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,di.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            //OracleParameter prm = parameterList[0];
            string regno = (string)(OracleString)prm.Value;
            return regno;
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
        }
        #endregion

        #region SaveIssueReturn
        public string SaveIssueReturn(AH.PHRMS.MODEL.IssueReturn oret)
        {
            string packageName = "PKG_ISSUE_RETURN.SAVE_ISSUE_RETURN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReturnID",OracleDbType.Varchar2,15,oret.ID,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,oret.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,oret.DrugIssue.ID,ParameterDirection.Input),
                //new OracleParameter("BatchID",OracleDbType.Varchar2,15,oret.DrugIssue.BatchID,ParameterDirection.Input),
                new OracleParameter("ReturnDate",OracleDbType.Date,oret.ReturnDate,ParameterDirection.Input),
                new OracleParameter("ReturnType",OracleDbType.Varchar2,2,oret.ReturnType,ParameterDirection.Input),
                new OracleParameter("ReturnFrom",OracleDbType.Varchar2,10,oret.ReturnFrom,ParameterDirection.Input),
                new OracleParameter("ReturnCause",OracleDbType.Varchar2,5,oret.ReturnCause,ParameterDirection.Input),
                new OracleParameter("NetAmount",OracleDbType.Int32,oret.NetAmount,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,100,oret.Remarks,ParameterDirection.Input),
                new OracleParameter("ReturnDetails",OracleDbType.Varchar2,32000,oret.ReturnDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oret.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oret.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oret.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oret.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            //OracleParameter prm = parameterList[0];
            string regno = (string)(OracleString)prm.Value;
            return regno;

        }
        #endregion

        #region GetIssueDetails

        public List<DrugIssue> GetIssueDetails(string issueID)
        {
            string packageName = "PKG_ISSUE.GET_ISSUE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,issueID,ParameterDirection.Input)
            };
            return GetIssue(packageName,parameterList);
        }
        public List<DrugIssue> GetIssueDetailsByRegID(string regid)
        {
            string packageName = "PKG_ISSUE.GET_ISSUE_DETAILSBYREGID";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegID",OracleDbType.Varchar2,15,regid,ParameterDirection.Input)
            };
            return GetIssue(packageName, parameterList);
        }
        private List<DrugIssue> GetIssue(string packageName,OracleParameter[] parameterList)
        {
            List<DrugIssue> odrug = new List<DrugIssue>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                DrugIssue dem = new DrugIssue();
                dem.ID = (string)rdr["IssueID"];
                dem.IssueDate = DateTime.Parse(rdr["IssueDate"].ToString());
                dem.IssueQty = float.Parse(rdr["IssueQty"].ToString());
                dem.ReturnQty = float.Parse(rdr["RETURNQTY"].ToString());
                dem.IssueType = (string)rdr["ISSUETYPE"];
                dem.BatchID = (string)rdr["BATCHNO"];
                dem.DRID = (string)rdr["DRID"];
                dem.CompareQty = float.Parse(rdr["COMPAREQTY"].ToString());


                Warehouse ophr = new Warehouse();
                ophr.TypeID = (string)rdr["PharmacyID"];
                ophr.TypeName = (string)rdr["PharmacyName"];
                dem.Warehouse = ophr;

                DrugMaster omaster = new DrugMaster();
                omaster.ID = (string)rdr["DrugID"];
                omaster.Name = (string)rdr["DrugName"];
                omaster.Urate = float.Parse(rdr["RATE"].ToString());
                omaster.VAT = float.Parse(rdr["VAT"].ToString());
                omaster.Discount = float.Parse(rdr["DISCOUNT"].ToString());
                omaster.NetAmount = float.Parse(rdr["NETAMOUNT"].ToString());


                DrugCompany dc = new DrugCompany();
                dc.ID = (string)rdr["DrugCompanyID"];
                dc.Name = (string)rdr["DrugCompany"];
                omaster.DrugCompany = dc;

                DrugGroup dg = new DrugGroup();
                dg.ID = (string)rdr["DrugGroupID"];
                dg.Name = (string)rdr["DrugGroup"];
                omaster.DrugGroup = dg;

                DrugPackType dpac = new DrugPackType();
                dpac.ID = (string)rdr["DrugTypeID"];
                dpac.Name = (string)rdr["DrugPacketType"];
                omaster.DrugPackType = dpac;

                DrugUnit un = new DrugUnit();
                un.ID = (string)rdr["DrugUnitID"];
                un.Name = (string)rdr["DrugUnit"];
                omaster.DrugUnit = un;

                dem.DrugMaster = omaster;

                odrug.Add(dem);

            }
            rdr.Close();
            return odrug;

        }
        #endregion

        #region Get_PharmacyAmount_Fee
        public AccountsPayment GetTicketFees(string userID, string date)
        {
            string packageName = "PKG_PAYMENT.Get_PharmacyAmount_Fee";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("userID",OracleDbType.Varchar2,30,userID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,date,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            AccountsPayment tktObj = new AccountsPayment();
            while (rdr.Read())
            {

                tktObj.TotalCollection = !rdr.IsDBNull(rdr.GetOrdinal("Collection")) ? Convert.ToDouble(rdr["Collection"]) : 0;
                tktObj.RefundAmount = !rdr.IsDBNull(rdr.GetOrdinal("Refund")) ? Convert.ToDouble(rdr["Refund"]) : 0;
                tktObj.PaymentAmount = !rdr.IsDBNull(rdr.GetOrdinal("Total")) ? Convert.ToDouble(rdr["Total"]) : 0;

                tktObj.CashAmount = !rdr.IsDBNull(rdr.GetOrdinal("CASH_AMT")) ? Convert.ToDouble(rdr["CASH_AMT"]) : 0;
                tktObj.CreditCardAmount = !rdr.IsDBNull(rdr.GetOrdinal("CREDIT_CARD_AMT")) ? Convert.ToDouble(rdr["CREDIT_CARD_AMT"]) : 0;
                tktObj.DebitCardAmount = !rdr.IsDBNull(rdr.GetOrdinal("DEBIT_CARD_AMT")) ? Convert.ToDouble(rdr["DEBIT_CARD_AMT"]) : 0;
            }
            rdr.Close();
            return tktObj;
        }
        #endregion

        #region SaveUserCloseRegister
        public short InsertUserCloseRegister(AccountsPayment tktFee)//(Ticket tktFee)
        {
            string packageName = "PKG_PAYMENT.INSERT_USER_CLOSE_REGISTER";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("p_test_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output), 
                new OracleParameter("userID",OracleDbType.Varchar2,30,tktFee.EntryParameter.EntryBy,ParameterDirection.Input),

                new OracleParameter("CASH_AMT",OracleDbType.Int32,tktFee.CashAmount,ParameterDirection.Input),
                new OracleParameter("CREDIT_CARD_AMT",OracleDbType.Int32,tktFee.CreditCardAmount,ParameterDirection.Input),
                new OracleParameter("DEBIT_CARD_AMT",OracleDbType.Int32,tktFee.DebitCardAmount,ParameterDirection.Input),

                new OracleParameter("Tkt_fee",OracleDbType.Int32,tktFee.PaymentAmount,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tktFee.Remarks,ParameterDirection.Input),

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tktFee.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tktFee.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tktFee.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tktFee.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,tktFee.CollectionDate,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

    }
}
