using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.PatReg.MODEL;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.ACCMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.IPD.MODEL;

namespace AH.IPD.DAL
{
   public class IPDAdmissionReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;


        public List<AdmissionReportRO>GetAdmissionMoneyReceipt(string moneyReceiptNo)
        {
            string packageName = "Pkg_IPD_Reports.Get_Admission_Money_Receipt";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MonyRecNo",OracleDbType.Varchar2,20,moneyReceiptNo,ParameterDirection.Input)
            };
            return GetAdmissionMoneyReceipt(packageName, parameterList);

        }
        public List<AdmissionReportRO> GetAdmissionCard(string admissionID)
        {
            string packageName = "Pkg_IPD_Reports.Get_Admission_Card";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("admissionID",OracleDbType.Varchar2,20,admissionID,ParameterDirection.Input)
            };
            return GetAdmissionMoneyReceipt(packageName, parameterList);

        }
        private List<AdmissionReportRO> GetAdmissionMoneyReceipt(string packageName, OracleParameter[] parameterList)
        {
            List<AdmissionReportRO> AdmRpts = new List<AdmissionReportRO>();
            AdmissionReportRO AdmisionRO = new AdmissionReportRO();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AdmisionRO.HCN = (string)rdr["HCN"];
                AdmisionRO.MRNo = (string)rdr["Trans_No"];
                AdmisionRO.RegistrationNo = (string)rdr["Registration_id"];
                AdmisionRO.PatientName = (string)rdr["Patient_name"];
                AdmisionRO.Age = (string)rdr["AGE"];
                AdmisionRO.Sex = (string)rdr["Sex"];
                AdmisionRO.Amount = (decimal)rdr["AMOUNT"];
                AdmisionRO.DepartmentTitle = (string)rdr["Department_Title"];              
                AdmisionRO.RoomNo= (string)rdr["Room_No"];
                AdmisionRO.BedNo = (string)rdr["Bed_No"];
                AdmisionRO.BedType = (string)rdr["Bed_Type"];
                AdmisionRO.AdmissionDate = (DateTime)rdr["Admission_Date"];
                AdmisionRO.EntryBY = (string)rdr["entry_by"];
                AdmisionRO.UnitTitle = (string)rdr["UNIT_TITLE"];
                AdmRpts.Add(AdmisionRO);
            }
            rdr.Close();
            return AdmRpts;
        }
        public List<AdmissionReportRO> GetAdmittedPatReportList(DateTime fromDate, DateTime toDate)
        {
            string packageName = "Pkg_IPD_Reports.Get_Admitted_Pat_List";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),             
                new OracleParameter("FromDate",OracleDbType.Date,20,fromDate,ParameterDirection.Input),
                new OracleParameter("ToDate",OracleDbType.Date,20,toDate,ParameterDirection.Input)
            };
            return GetAdmittedPatientList(packageName, parameterList);

        }

        private List<AdmissionReportRO> GetAdmittedPatientList(string packageName, OracleParameter[] parameterList)
        {
            List<AdmissionReportRO> AdmRpts = new List<AdmissionReportRO>();
           
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AdmissionReportRO AdmisionRO = new AdmissionReportRO();
                AdmisionRO.HCN = (string)rdr["HCN"];
             //   AdmisionRO.MRNo = (string)rdr["Trans_No"];
                AdmisionRO.RegistrationNo = (string)rdr["Reg_id"];
                AdmisionRO.PatientName = (string)rdr["Pat_name"];

                AdmisionRO.Age = (string)rdr["Age"].ToString();
                AdmisionRO.Sex = (string)rdr["Sex"];
               // AdmisionRO.Amount = (decimal)rdr["AMOUNT"];
                AdmisionRO.DepartmentTitle = (string)rdr["Dept_Title"];
                AdmisionRO.UnitTitle = (string)rdr["unit_Title"];
               // AdmisionRO.RoomNo = (string)rdr["Room_No"];
                //AdmisionRO.BedNo = (string)rdr["Bed_No"];
               // AdmisionRO.BedType = (string)rdr["Bed_Type"];
                AdmisionRO.AdmissionDate = (DateTime)rdr["dt"];
             //   AdmisionRO.DischargeDate = (!rdr.IsDBNull(30) ?(DateTime)rdr["DISCHARGE_DATE"]:"").ToString();
              
                AdmRpts.Add(AdmisionRO);
            }
            rdr.Close();
            return AdmRpts;
        }
       
    }
}
