using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.PatReg.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PatReg.DAL
{
    public class PatientRegistrationReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.RegMIS);
        string packageName = string.Empty;

        #region Search
        public List<PatRegRO> GetPatientRegistartionReport(string WhereCondition)
        {
            string packageName = "AGH_PAT_REG.Pkg_Pat_Reg_Report.Get_Pat_Registration_Details";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_whereCondition",OracleDbType.Varchar2,3000,WhereCondition,ParameterDirection.Input) 
            };

            return GetPatientRegistartionReportDetails(packageName, parameterList);
        }

        public List<PatRegRO> GetPatientRegistartionReportDR(string WhereCondition)
        {
            string packageName = "AGH_PAT_REG.Pkg_Pat_Reg_Report.Get_Pat_Registration_DetailsDR";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_whereCondition",OracleDbType.Varchar2,3000,WhereCondition,ParameterDirection.Input) 
            };

            return GetPatientRegistartionReportDetails(packageName, parameterList);
        }

        private List<PatRegRO> GetPatientRegistartionReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PatRegRO> rDRSs = new List<PatRegRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjects(reader);
                }
            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return rDRSs;
        }

        public List<PatRegRO> GetsPatientReg()
        {
            string packageName = "AGH_PAT_REG.Pkg_Pat_Reg_Report.Gets_Pat_Registration";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };

            return GetPatientRegistartionReportDetails(packageName, parameterList);
        }

        public List<PatRegRO> PatientAdvanceSearch(string WhereCondition)
        {
            string packageName = "AGH_PAT_REG.Pkg_Pat_Reg_Report.Adv_Search_Patient";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_whereCondition",OracleDbType.Varchar2,3000,WhereCondition,ParameterDirection.Input) 
            };

            return GetPatientRegistartionReportDetails(packageName, parameterList);
        }
        #endregion

        #region DataReaderMappingwithNUll

        private PatRegRO MapObject(NullHandler oReader)
        {
            PatRegRO oDRS = new PatRegRO();
            oDRS.HCN = oReader.GetString("HCN");
            oDRS.PatientName = oReader.GetString("PatientName");
            oDRS.DateofBirth = oReader.GetDateTime("DateofBirth").ToString("dd MMM yyyy");
            oDRS.Sex = oReader.GetString("Sex");
            oDRS.pat_name_beng = oReader.GetString("pat_name_beng");
            oDRS.FatherName = oReader.GetString("FatherName");
            oDRS.fname_beng = oReader.GetString("fname_beng");
            oDRS.MotherName = oReader.GetString("MotherName");
            oDRS.mname_beng = oReader.GetString("mname_beng");
            oDRS.SpouseName = oReader.GetString("SpouseName");
            oDRS.EntryDate = oReader.GetDateTime("EntryDate").ToString("dd MMM yyyy");
            oDRS.spouse_name_beng = oReader.GetString("spouse_name_beng");
            oDRS.GuardianName = oReader.GetString("GuardianName");
            oDRS.guardian_name_beng = oReader.GetString("guardian_name_beng");
            oDRS.RelationshipGuardian = oReader.GetString("RelationshipGuardian");
            oDRS.Religion = oReader.GetString("Religion");
            oDRS.BloodGroup = oReader.GetString("BloodGroup");
            oDRS.MaritalStatus = oReader.GetString("MaritalStatus");
            oDRS.EducationLevel = oReader.GetString("EducationLevel");
            oDRS.Occupation = oReader.GetString("Occupation");
            oDRS.IncomeGroup = oReader.GetString("IncomeGroup");
            oDRS.YearlyIncome = oReader.GetString("YearlyIncome");
            oDRS.NID = oReader.GetString("NID");
            oDRS.Email = oReader.GetString("Email");
            oDRS.MobileNo = oReader.GetString("MobileNo");
            oDRS.HomePhoneNo = oReader.GetString("HomePhoneNo");
            oDRS.Address = oReader.GetString("Address");
            oDRS.ho_vi_ar_rd_beng = oReader.GetString("ho_vi_ar_rd_beng");
            oDRS.post_code = oReader.GetString("post_code");
            oDRS.thana_code = oReader.GetString("thana_code");
            oDRS.district_code = oReader.GetString("district_code");
            oDRS.per_ho_vi_ar_rd = oReader.GetString("per_ho_vi_ar_rd");
            oDRS.per_post_code = oReader.GetString("per_post_code");
            oDRS.per_thana_code = oReader.GetString("per_thana_code");
            oDRS.per_district_code = oReader.GetString("per_district_code");
            oDRS.e_cont_person = oReader.GetString("e_cont_person");
            oDRS.e_cont_person_beng = oReader.GetString("e_cont_person_beng");
            oDRS.e_address = oReader.GetString("e_address");
            oDRS.e_address_beng = oReader.GetString("e_address_beng");
            oDRS.e_cell_phone = oReader.GetString("e_cell_phone");
            oDRS.e_home_phone = oReader.GetString("e_home_phone");
            oDRS.e_rel_with_pat = oReader.GetString("e_rel_with_pat");
            oDRS.staff_id = oReader.GetString("staff_id");
            oDRS.corporate_id = oReader.GetString("corporate_id");
            oDRS.category_id = oReader.GetString("category_id");


            return oDRS;
        }

        private PatRegRO CreateObject(NullHandler oReader)
        {
            PatRegRO oDRS = new PatRegRO();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private List<PatRegRO> CreateObjects(IDataReader oReader)
        {
            List<PatRegRO> rDRSs = new List<PatRegRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                PatRegRO oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        #endregion

    }
}
