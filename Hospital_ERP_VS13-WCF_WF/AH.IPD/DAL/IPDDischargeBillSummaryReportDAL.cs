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
    public class IPDDischargeBillSummaryReportDAL
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

           
                DisRpts.Add(DisRO);
            }
            rdr.Close();
            return DisRpts;
        }
    }
}
