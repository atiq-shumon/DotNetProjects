using AH.DUtility;
using AH.IPD.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.DAL
{
    public class IPDDischargeReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;


        public List<DischargeReportRO> GetPatDischargeBillSummary(string regID)
        {
            string packageName = "Pkg_IPD_Reports.Get_Pat_Discharge_Bill_Summary";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,20,regID,ParameterDirection.Input)
            };
            return GetPatDischargeBillSummary(packageName, parameterList);

        }
        private List<DischargeReportRO> GetPatDischargeBillSummary(string packageName, OracleParameter[] parameterList)
        {
            List<DischargeReportRO> DisRpts = new List<DischargeReportRO>();
           

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DischargeReportRO DisRO = new DischargeReportRO();
                DisRO.HCN = (string)rdr["HCN"];
                DisRO.RegistrationNo = (string)rdr["Reg_id"];
                DisRO.PatientName = (string)rdr["Pat_name"];
                DisRO.Age = (string)rdr["AGE"];
                DisRO.Gender= (string)rdr["Gender"];            
                DisRO.Total = (decimal)rdr["AMOUNT"];
                DisRO.Vat = (decimal)rdr["Vat"];
                DisRO.Discount = (decimal)rdr["Disc"];
                DisRO.NetAmount = (decimal)rdr["Net_Total"];
                DisRO.DepartmentTitle = (string)rdr["Dept_Title"];             
                DisRO.UnitTitle = (string)rdr["Unit_title"];
                DisRO.HeadTitle = (string)rdr["Head_Title"];
                DisRO.AdmissionDate = (DateTime)rdr["Adm_Date"];
                DisRO.ReleaseDate = (DateTime)rdr["Discharge_Date"];
                DisRO.AdvancePayment = (decimal)rdr["Advance_payment"];
                DisRO.BedType = (string)rdr["Bed_Type"];
                DisRO.BedNo = (string)rdr["Bed_No"];
                DisRO.DepartmentHeadName = (string)rdr["Department_Head_Name"];
                DisRO.Quantity = Convert.ToInt32(rdr["bedQnty"]).ToString();

           
                DisRpts.Add(DisRO);
            }
            rdr.Close();
            return DisRpts;
        }

        //==============================Discharge Report Bill Details=========================//
        public List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string regID)
        {
            string packageName = "Pkg_IPD_Reports.Get_Pat_Discharge_Bill_Details";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,20,regID,ParameterDirection.Input)
            };
            return GetPatDischargeBillDetails(packageName, parameterList);

        }
        private List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PatientDischargeBillDetailsRO> DisRpts = new List<PatientDischargeBillDetailsRO>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PatientDischargeBillDetailsRO DisRO = new PatientDischargeBillDetailsRO();
                DisRO.HCN = (string)rdr["HCN"];
                DisRO.RegistrationId = (string)rdr["Reg_id"];
                DisRO.PatientName = (string)rdr["Pat_name"];
                DisRO.Age = (string)rdr["AGE"];
                DisRO.Gender = (string)rdr["Gender"];
                DisRO.RoomTitle = (string)rdr["Room_title"];
                DisRO.BedTitle = (string)rdr["bed_Title"];
                DisRO.DepartmentHeadName = (string)rdr["Dept_Head_Name"];
                DisRO.RevenueHead = (string)rdr["Rev_Head"];
                DisRO.Quantity = Convert.ToDecimal( rdr["Qty"]).ToString();
                DisRO.Title = (string)rdr["title"];
                DisRO.Date = (DateTime)rdr["Date"];
                DisRO.Dr = Convert.ToInt32( rdr["dr"]);
                DisRO.Cr=Convert.ToInt32( rdr["cr"]);
                DisRO.AdmissionDate = (DateTime)rdr["Adm_Date"];
                DisRO.DischargeDate = (DateTime)rdr["Discharge_Date"];                            
                DisRpts.Add(DisRO);
            }
            rdr.Close();
            return DisRpts;
        }

        public List<AdvanceDepositRO> GetAdvPayment(string regno)
        {
            string packageName = "PKG_IPD.GET_DEPOSIT_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,regno,ParameterDirection.Input)
            };
            return GetAdvan(packageName, parameterList);
        }
        private List<AdvanceDepositRO> GetAdvan(string packageName, OracleParameter[] parameterList)
        {
            List<AdvanceDepositRO> adpay = new List<AdvanceDepositRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AdvanceDepositRO payment = new AdvanceDepositRO();
                payment.DepositDate = (DateTime)rdr[11];
                payment.DepositeType = (string)rdr[3];
                payment.Amount = Convert.ToInt32(rdr["amount"]);
                payment.TransNo = (string)rdr["trans_no"];

                adpay.Add(payment);
            }
            rdr.Close();
            return adpay;
        }
    }
}
