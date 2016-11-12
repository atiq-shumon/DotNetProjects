using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.NWMS.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using AH.OracleManager;
using System.Data;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;

namespace AH.NWMS.DAL
{
    public class NwmsReportDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.IPDMIS);

        public List<NWMSReportRO> GetDischargeSummary(string reg_ID)
        {
            string packageName = "AGH_IPD.PKG_NWMS_Reports.DischargeSumNAdv";
            OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("reg_ID",OracleDbType.Varchar2,20,reg_ID,ParameterDirection.Input)
           };

            List<NWMSReportRO> IPDPats = new List<NWMSReportRO>();
            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                NWMSReportRO IPDPat = new NWMSReportRO();

                IPDPat.HCN = (string)rdr["HCN"].ToString();
                IPDPat.RegistrationNo = (string)rdr["REG_ID"].ToString();
                IPDPat.Name = (string)rdr["PAT_NAME"].ToString();

                IPDPat.DepartmentID = (string)rdr["Dept_ID"].ToString();
                IPDPat.DepartmentTitle = (string)rdr["Dept_Title"].ToString();
                IPDPat.UnitId = (string)rdr["unit_id"].ToString();
                IPDPat.UnitTitle = (string)rdr["unit_title"].ToString();
                IPDPat.DeptUnitTitle = (string)rdr["DeptUnitTitle"].ToString();

                IPDPat.AgeFull = (string)rdr["Age"].ToString();
                IPDPat.BloodGroup = (string)rdr["BLOOD_GRP"].ToString();
                IPDPat.Gender = (string)rdr["Gender"].ToString();

                IPDPat.AdmissionDate = (DateTime)rdr["admission_date"];
                IPDPat.DischargeDate = (DateTime)rdr["Discharge_date"];

                IPDPat.DeptHeadID = (string)rdr["DEPT_HD_ID"].ToString();
                IPDPat.DeptHeadName = (string)rdr["DEPT_HD_NAME"].ToString();
                IPDPat.TreatingConsultant = (string)rdr["TreatingConsultant"].ToString();
                IPDPat.VisitingConsultant = (string)rdr["Visiting_Docs"].ToString();

                IPDPat.DisDiagnosis = (string)rdr["DISCHARGE_DIAGNOSIS"].ToString();
                IPDPat.DischargeStatus = (string)rdr["DISCHARGE_STATUS"].ToString();
                IPDPat.DischargeType = (string)rdr["DISCHARGE_TYPE"].ToString();

                IPDPat.CaseSummary = (string)rdr["CASE_SUMMARY"].ToString();
                IPDPat.HospitalCourse = (string)rdr["HOSPITAL_COURSE"].ToString();
                IPDPat.OperationNote = (string)rdr["OPERATION_NOTE"].ToString();
                IPDPat.IPDMedicineHistory = (string)rdr["IPDMedicineHistory"].ToString();

                IPDPat.Comorbidity = (string)rdr["Comorbidity"].ToString();
                IPDPat.ClinicalFindings = (string)rdr["CF"].ToString();

                IPDPat.Height = (string)rdr["HEIGHT"].ToString();
                IPDPat.Weight = (string)rdr["WEIGHT"].ToString();
                IPDPat.Bp = (string)rdr["BP"].ToString();
                IPDPat.Temparature = (string)rdr["TEMPARATURE"].ToString();
                IPDPat.SPOTWO = (string)rdr["SPOTWO"].ToString();
                IPDPat.OFC = (string)rdr["OFC"].ToString();

                IPDPat.DisDietAdvice = (string)rdr["DIET_ADVICE"].ToString();
                IPDPat.DisAdvice = (string)rdr["OAdvice"].ToString();
                IPDPat.DisDiag = (string)rdr["Diag"].ToString();
                IPDPat.DisMedicine = (string)rdr["Drugs"].ToString();
                IPDPat.NextVisitDate = (rdr["NEXT_VISIT_DATE"] == DBNull.Value ? string.Empty : Convert.ToString(((DateTime)rdr["NEXT_VISIT_DATE"]).ToString("dd MMM yyyy")));
                IPDPat.NxtVisitDept = (string)rdr["VISIT_TO_DEPT"].ToString();
                IPDPat.NxtVisitUnit = (string)rdr["VISIT_TO_UNIT"].ToString();
                IPDPat.NxtVisitDoc = (string)rdr["VISIT_TO_DOC"].ToString();

                IPDPats.Add(IPDPat);
            }
            rdr.Close();
            return IPDPats;
        }

        public List<NWMSReportRO> DischargeAdvice(string reg_ID)
        {
            string packageName = "AGH_IPD.PKG_NWMS_Reports.DischargeAdvice";
            OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("reg_ID",OracleDbType.Varchar2,20,reg_ID,ParameterDirection.Input)
           };

            List<NWMSReportRO> IPDPats = new List<NWMSReportRO>();
            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                NWMSReportRO IPDPat = new NWMSReportRO();

                IPDPat.HCN = (string)rdr["HCN"].ToString();
                IPDPat.RegistrationNo = (string)rdr["REG_ID"].ToString();
                IPDPat.Name = (string)rdr["PAT_NAME"].ToString();
                IPDPat.ReferenceNo = (string)rdr["REFF_NO"].ToString();
                IPDPat.BloodGroup = (string)rdr["BLOOD_GRP"].ToString();
                IPDPat.Gender = (string)rdr["Gender"].ToString();
                IPDPat.AgeFull = (string)rdr["Age"].ToString();
                IPDPat.StaffID = (string)rdr["STAFF_ID"].ToString();
                IPDPat.Email = (string)rdr["EMAIL"].ToString();
                IPDPat.CellPhone = (string)rdr["CELL_PHONE"].ToString();
                IPDPat.FathersName = (string)rdr["FNAME"].ToString();
                IPDPat.MothersName = (string)rdr["MNAME"].ToString();
                IPDPat.DepartmentID = (string)rdr["Dept_ID"].ToString();
                IPDPat.DepartmentTitle = (string)rdr["Dept_Title"].ToString();
                IPDPat.UnitId = (string)rdr["unit_id"].ToString();
                IPDPat.UnitTitle = (string)rdr["unit_title"].ToString();
                IPDPat.DeptHeadID = (string)rdr["doc_ID"].ToString();
                IPDPat.DeptHeadName = (string)rdr["dept_head_name"].ToString();
                IPDPat.AdmissionDate = (DateTime)rdr["admission_date"];
                IPDPat.DischargeDate = (DateTime)rdr["Discharge_date"];
                IPDPat.DisDietAdvice = (string)rdr["DIET_ADVICE"].ToString();
                IPDPat.DisAdvice = (string)rdr["OAdvice"].ToString();
                IPDPat.DisDiag = (string)rdr["Diag"].ToString();
                IPDPat.DisMedicine = (string)rdr["Drugs"].ToString();
                IPDPat.NextVisitDate = (rdr["NEXT_VISIT_DATE"] == DBNull.Value ? string.Empty :  Convert.ToString(((DateTime)rdr["NEXT_VISIT_DATE"]).ToString("dd MMM yyyy")));
                IPDPat.NxtVisitDept = (string)rdr["VISIT_TO_DEPT"].ToString();
                IPDPat.NxtVisitUnit = (string)rdr["VISIT_TO_UNIT"].ToString();
                IPDPat.NxtVisitDoc = (string)rdr["VISIT_TO_DOC"].ToString();

                IPDPats.Add(IPDPat);
            }
            rdr.Close();
            return IPDPats;
        }

      
    }
}
