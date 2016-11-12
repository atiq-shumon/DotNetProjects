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
    public class IPDReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;


        //public List<DischargeReportRO> GetPatDischargeBillSummary(string regID)
        //{
        //    string packageName = "Pkg_IPD_Reports.Get_Pat_Discharge_Bill_Summary";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("Reg_ID",OracleDbType.Varchar2,20,regID,ParameterDirection.Input)
        //    };
        //    return GetPatDischargeBillSummary(packageName, parameterList);

        //}
        //private List<DischargeReportRO> GetPatDischargeBillSummary(string packageName, OracleParameter[] parameterList)
        //{
        //    List<DischargeReportRO> DisRpts = new List<DischargeReportRO>();
           

        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        DischargeReportRO DisRO = new DischargeReportRO();
        //        DisRO.HCN = (string)rdr["HCN"];
        //        DisRO.RegistrationNo = (string)rdr["Reg_id"];
        //        DisRO.PatientName = (string)rdr["Pat_name"];
        //        DisRO.Age = (string)rdr["AGE"];
        //        DisRO.Gender= (string)rdr["Gender"];            
        //        DisRO.Total = (decimal)rdr["AMOUNT"];
        //        DisRO.Vat = (decimal)rdr["Vat"];
        //        DisRO.Discount = (decimal)rdr["Disc"];
        //        DisRO.NetAmount = (decimal)rdr["Net_Total"];
        //        DisRO.DepartmentTitle = (string)rdr["Dept_Title"];             
        //        DisRO.UnitTitle = (string)rdr["Unit_title"];
        //        DisRO.HeadTitle = (string)rdr["Head_Title"];
        //        DisRO.AdmissionDate = (DateTime)rdr["Adm_Date"];
        //        DisRO.ReleaseDate = (DateTime)rdr["Discharge_Date"];
        //        DisRO.AdvancePayment = (decimal)rdr["Advance_payment"];
        //        DisRO.BedType = (string)rdr["Bed_Type"];
        //        DisRO.BedNo = (string)rdr["Bed_No"];
        //        DisRO.DepartmentHeadName = (string)rdr["Department_Head_Name"];

           
        //        DisRpts.Add(DisRO);
        //    }
        //    rdr.Close();
        //    return DisRpts;
        //}

        ////==============================Discharge Report Bill Details=========================//
        //public List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string regID)
        //{
        //    string packageName = "Pkg_IPD_Reports.Get_Pat_Discharge_Bill_Details";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("Reg_ID",OracleDbType.Varchar2,20,regID,ParameterDirection.Input)
        //    };
        //    return GetPatDischargeBillDetails(packageName, parameterList);

        //}
        //private List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string packageName, OracleParameter[] parameterList)
        //{
        //    List<PatientDischargeBillDetailsRO> DisRpts = new List<PatientDischargeBillDetailsRO>();

        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        PatientDischargeBillDetailsRO DisRO = new PatientDischargeBillDetailsRO();
        //        DisRO.HCN = (string)rdr["HCN"];
        //        DisRO.RegistrationId = (string)rdr["Reg_id"];
        //        DisRO.PatientName = (string)rdr["Pat_name"];
        //        DisRO.Age = (string)rdr["AGE"];
        //        DisRO.Gender = (string)rdr["Gender"];
        //        DisRO.RoomTitle = (string)rdr["Room_title"];
        //        DisRO.BedTitle = (string)rdr["bed_Title"];
        //        DisRO.DepartmentHeadName = (string)rdr["Dept_Head_Name"];
        //        DisRO.RevenueHead = (string)rdr["Rev_Head"];
        //        DisRO.Quantity = Convert.ToDecimal( rdr["Qty"]).ToString();
        //        DisRO.Title = (string)rdr["title"];
        //        DisRO.Date = (DateTime)rdr["Date"];
        //        DisRO.Dr = Convert.ToInt32( rdr["dr"]);
        //        DisRO.Cr=Convert.ToInt32( rdr["cr"]);
        //        DisRO.AdmissionDate = (DateTime)rdr["Adm_Date"];
        //       // DisRO.DischargeDate = (DateTime)rdr["Discharge_Date"];                            
        //        DisRpts.Add(DisRO);
        //    }
        //    rdr.Close();
        //    return DisRpts;
        //}
        public List<IPDDeathRO> DeathCertificate(string regID)
        {
            string packageName = "Pkg_IPD_Reports.Get_Death_Certificate";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,30,regID,ParameterDirection.Input)
            };
            return DeathCertificate(packageName, parameterList);

        }
        private List<IPDDeathRO> DeathCertificate(string packageName, OracleParameter[] parameterList)
        {
            List<IPDDeathRO> deaths = new List<IPDDeathRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IPDDeathRO deth = new IPDDeathRO();
                deth.HCN = (string)rdr["HCN"].ToString();
                deth.RegistrationNo = (string)rdr["REG_ID"].ToString();
                deth.PatientName = (string)rdr["PAT_NAME"].ToString();
                deth.Age = (string)rdr["AGE"].ToString();
                deth.Gender = (string)rdr["SEX"].ToString();
                deth.Email = (string)rdr["EMAIL"].ToString();
                deth.Religion = (string)rdr["RELIGION"].ToString();
                deth.BloodGroup = (string)rdr["BLOOD_GRP"].ToString();
                deth.Address = (string)rdr["HO_VI_AR_RD"].ToString();
                deth.FatherName = (string)rdr["FNAME"].ToString();
                deth.MotherName = (string)rdr["MNAME"].ToString();
                deth.CellPhone = (string)rdr["CELL_PHONE"].ToString();
                deth.Country = (string)rdr["COUNTRY"].ToString();
                deth.DeathReason = (string)rdr["DEATH_REASON_ID"].ToString();
                deth.BedTitle = (string)rdr["BED_NO"].ToString();
                deth.DepartmentTitle = (string)rdr["DEPT_TITLE"].ToString();
                deth.UnitTitle = (string)rdr["UNIT_TITLE"].ToString();
                deth.Remarks = (string)rdr["REMARKS"].ToString();
                deth.AdmissionDate = (DateTime)rdr["ADM_DATE"];
                deth.ReleaseDate = (DateTime)rdr["DISCHARGE_DATE"];
                deth.DeathDateTime = (DateTime)rdr["DEATH_DTTM"];
                deth.DeathNotes = (string)rdr["DEATH_NOTES"].ToString();
                deth.Consultant = (string)rdr["CONSULTANT"].ToString();

                deaths.Add(deth);
            }
            rdr.Close();
            return deaths;
        }
        public List<IPDBirthCertificateRO> BirthCertificate(string regID)
        {
            string packageName = "Pkg_IPD_Reports.Get_Birth_Certificate";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,30,regID,ParameterDirection.Input)
            };
            return BirthCertificate(packageName, parameterList);

        }
        private List<IPDBirthCertificateRO> BirthCertificate(string packageName, OracleParameter[] parameterList)
        {
            List<IPDBirthCertificateRO> births = new List<IPDBirthCertificateRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IPDBirthCertificateRO birth = new IPDBirthCertificateRO();
                birth.ChildID = (string)rdr["CHILD_ID"].ToString();
                birth.MotherHCN = (string)rdr["MOT_HCN"].ToString();
                birth.ChildHCN = (string)rdr["CHILD_HCN"].ToString();
                birth.MotherRegistrationNo = (string)rdr["MOT_REG_ID"].ToString();
                birth.MotherName = (string)rdr["MOTHERNAME"].ToString();
                birth.FatherName = (string)rdr["FATHERNAME"].ToString();         
                //birth.Age = (string)rdr["AGE"].ToString();
                birth.Gender = (string)rdr["SEX"].ToString();
                birth.Email = (string)rdr["EMAIL"].ToString();
                //birth.Religion = (string)rdr["RELIGION"].ToString();
                birth.BloodGroup = (string)rdr["BLOOD_GRP"].ToString();
                birth.Address = (string)rdr["HO_VI_AR_RD"].ToString();
                birth.DoctorName = (string)rdr["DOCTORNAME"].ToString();
                birth.CellPhone = (string)rdr["CELL_PHONE"].ToString();
                birth.Country = (string)rdr["COUNTRY"].ToString();
                birth.DepartmentTitle = (string)rdr["DEPT_TITLE"].ToString();
                birth.UnitTitle = (string)rdr["UNIT_TITLE"].ToString();
                birth.BirthDateTime = (DateTime)rdr["BIRTH_DTTM"];
                birth.BirthMarks = (string)rdr["BIRTH_MARK"];
                birth.BirthType = (string)rdr["BIRTH_TYPE"];
                birth.HealthStatus = (string)rdr["HEALTH_STATUS"];
                birth.BirthHeight = (string)rdr["BIRTH_HEIGHT"];
                birth.BirthWeight = (string)rdr["BIRTH_WEIGHT"];
                birth.DischargeWeight = (string)rdr["DISCHARGE_WEIGHT"];
                birth.Remarks = (string)rdr["REMARKS"].ToString();
                birth.AuthorizeBy = (string)rdr["AUTHORIZEBY"].ToString();
                births.Add(birth);
            }
            rdr.Close();
            return births;
        }
    }
}
