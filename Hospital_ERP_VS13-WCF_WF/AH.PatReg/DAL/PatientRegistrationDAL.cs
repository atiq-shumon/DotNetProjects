using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.DUtility;
using AH.PatReg.MODEL;
using AH.OracleManager;
using AH.Shared.MODEL;

namespace AH.PatReg.DAL
{
    public class PatientRegistrationDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.RegMIS);

        //public string Insert(Patient pat,OPDPayment payment)
        public string Insert(Patient pat)
        {
            string packageName = "AGH_PAT_REG.pkg_registration.save_pat_master";
            OracleParameter[] parameterList = new OracleParameter[] { 
            new OracleParameter("Pid", OracleDbType.Varchar2,50,null, ParameterDirection.Output),
            new OracleParameter("patName",OracleDbType.Varchar2,150,pat.Name,ParameterDirection.Input),
            new OracleParameter("patNameB",OracleDbType.Varchar2,150,pat.NameBeng,ParameterDirection.Input),
            new OracleParameter("FatherName", OracleDbType.Varchar2,150,pat.FathersName,ParameterDirection.Input),
            new OracleParameter("FatherNameB", OracleDbType.Varchar2,150,pat.FathersNameBeng,ParameterDirection.Input),
            new OracleParameter("MotherName", OracleDbType.Varchar2,150,pat.MothersName,ParameterDirection.Input),
            new OracleParameter("MotherNameB", OracleDbType.Varchar2,150,pat.MothersNameBeng,ParameterDirection.Input),
            new OracleParameter("GuardianName", OracleDbType.Varchar2,150,pat.GuardianName,ParameterDirection.Input),
            new OracleParameter("GuardianNameB", OracleDbType.Varchar2,150,pat.GuardianNameBeng,ParameterDirection.Input),
            new OracleParameter("RelationWithGuard", OracleDbType.Varchar2,5,pat.RelationWithGuardian,ParameterDirection.Input),
            new OracleParameter("SpouseName", OracleDbType.Varchar2,150,pat.SpouseName,ParameterDirection.Input),
            new OracleParameter("SpouseNameB", OracleDbType.Varchar2,150,pat.SpouseNameBeng,ParameterDirection.Input),
            new OracleParameter("DOB", OracleDbType.Date,30,pat.DOB,ParameterDirection.Input),
            new OracleParameter("Sex", OracleDbType.Char,1,pat.Sex,ParameterDirection.Input),
            new OracleParameter("Religion", OracleDbType.Char,1,pat.Religion,ParameterDirection.Input),
            new OracleParameter("BloodGroup", OracleDbType.Varchar2,4,pat.BloodGroup,ParameterDirection.Input),
            new OracleParameter("MaritalStatus", OracleDbType.Char,1,pat.MaritalStatus,ParameterDirection.Input),
            new OracleParameter("EducationLevel", OracleDbType.Char,1,pat.MaxEducation,ParameterDirection.Input),
            new OracleParameter("Occupation", OracleDbType.Varchar2,30,pat.Occupation,ParameterDirection.Input),
            new OracleParameter("IncomeGroup", OracleDbType.Varchar2,1,pat.IncomeGroup,ParameterDirection.Input),           
            new OracleParameter("YearlyIncome", OracleDbType.Int64,10,pat.YearlyIncome,ParameterDirection.Input),
            new OracleParameter("NID", OracleDbType.Varchar2,50,pat.NID,ParameterDirection.Input),
            new OracleParameter("email", OracleDbType.Varchar2,70,pat.Email,ParameterDirection.Input),
            new OracleParameter("CellPhone", OracleDbType.Varchar2,20,pat.CellPhone,ParameterDirection.Input),
            new OracleParameter("HomePhone", OracleDbType.Varchar2,20,pat.HomePhone,ParameterDirection.Input),
            new OracleParameter("ho_vi_ar_rd", OracleDbType.Varchar2,200,pat.Present_H_R_B,ParameterDirection.Input),
            new OracleParameter("ho_vi_ar_rd_B", OracleDbType.Varchar2,200,pat.Present_H_R_B_Beng,ParameterDirection.Input),
            new OracleParameter("post_code", OracleDbType.Varchar2,10,pat.Present_Post,ParameterDirection.Input),
            new OracleParameter("thana", OracleDbType.Varchar2,100,pat.PresentThana,ParameterDirection.Input),
            new OracleParameter("district", OracleDbType.Varchar2,100,pat.PresentDistrict,ParameterDirection.Input),
            new OracleParameter("country", OracleDbType.Varchar2,100,pat.PresentDistrict,ParameterDirection.Input),
            new OracleParameter("p_ho_vi_ar_rd", OracleDbType.Varchar2,200,pat.Permanent_H_R_B,ParameterDirection.Input),
            new OracleParameter("p_post_code", OracleDbType.Varchar2,10,pat.Permanent_Post,ParameterDirection.Input),
            new OracleParameter("p_thana", OracleDbType.Varchar2,100,pat.PermanentThana,ParameterDirection.Input),
            new OracleParameter("p_district", OracleDbType.Varchar2,100,pat.PermanentDistrict,ParameterDirection.Input),
            new OracleParameter("e_contact_person", OracleDbType.Varchar2,150,pat.EmergencyContactPerson,ParameterDirection.Input),
            new OracleParameter("e_contact_personB", OracleDbType.Varchar2,150,pat.EmergencyContactPersonBeng,ParameterDirection.Input),
            new OracleParameter("e_address", OracleDbType.Varchar2,200,pat.EmergencyAddress,ParameterDirection.Input),
            new OracleParameter("e_addressB", OracleDbType.Varchar2,200,pat.EmergencyAddressBeng,ParameterDirection.Input),
            new OracleParameter("e_cell_phone", OracleDbType.Varchar2,20,pat.EmergencyCellPhone,ParameterDirection.Input),
            new OracleParameter("e_home_phone", OracleDbType.Varchar2,20,pat.HomePhone,ParameterDirection.Input),
            new OracleParameter("e_rel_with_pat", OracleDbType.Varchar2,20,pat.EmergencyPersonRelation,ParameterDirection.Input),
            new OracleParameter("e_thana_code", OracleDbType.Varchar2,100,pat.EmergencyAddressThana,ParameterDirection.Input),
            new OracleParameter("e_district_code", OracleDbType.Varchar2,100,pat.EmergencyAddressDistrict,ParameterDirection.Input),
            new OracleParameter("e_email", OracleDbType.Varchar2,70,pat.EmergencyPersonEmail,ParameterDirection.Input),
            new OracleParameter("staff_type_id", OracleDbType.Varchar2,3,pat.staff_type_id,ParameterDirection.Input),
            new OracleParameter("staff_id", OracleDbType.Varchar2,30,pat.StaffID,ParameterDirection.Input),
            new OracleParameter("dependent_ID", OracleDbType.Varchar2,30,pat.Dependent_ID,ParameterDirection.Input),
            new OracleParameter("is_staff_self", OracleDbType.Varchar2,1,pat.Is_staff_self,ParameterDirection.Input),
            new OracleParameter("corporate_id", OracleDbType.Varchar2,30,pat.CorporateID,ParameterDirection.Input),
            new OracleParameter("category_id", OracleDbType.Varchar2,5,pat.CategoryID,ParameterDirection.Input),
            new OracleParameter("photo_path", OracleDbType.Varchar2,300,pat.Photo,ParameterDirection.Input),
            new OracleParameter("AppointID",OracleDbType.Varchar2,30,pat.AppointmentID,ParameterDirection.Input),

          /*  new OracleParameter("dept",OracleDbType.Varchar2,20,payment.Department,ParameterDirection.Input),
            new OracleParameter("ReffDept",OracleDbType.Varchar2,20,payment.ReffDept,ParameterDirection.Input),
            new OracleParameter("deptUnit",OracleDbType.Varchar2,20,payment.DepartmentUnit,ParameterDirection.Input),
            new OracleParameter("ReffDeptUnit",OracleDbType.Varchar2,20,payment.ReffDeptUnit,ParameterDirection.Input),
            new OracleParameter("Purpose",OracleDbType.Varchar2,20,payment.PurposeID,ParameterDirection.Input), 
            new OracleParameter("deptAmt",OracleDbType.Decimal,30,payment.DeptAmount,ParameterDirection.Input), 
            new OracleParameter("ReffdeptAmt",OracleDbType.Decimal,30,payment.ReffDeptAmount,ParameterDirection.Input), 
            new OracleParameter("discount",OracleDbType.Decimal,30,payment.Discount,ParameterDirection.Input), 
            new OracleParameter("discountby",OracleDbType.Varchar2,30,payment.DiscountBy,ParameterDirection.Input), 
            new OracleParameter("Vat",OracleDbType.Decimal,30,payment.VAT,ParameterDirection.Input), 
            new OracleParameter("total",OracleDbType.Decimal,30,payment.NetAmount,ParameterDirection.Input), 
            new OracleParameter("regNo",OracleDbType.Varchar2,30,payment.RegistrationNo,ParameterDirection.Input),
            new OracleParameter("pType",OracleDbType.Varchar2,30,payment.PaymentType,ParameterDirection.Input),
            new OracleParameter("Payment_string",OracleDbType.Varchar2,100000,payment.PaymentString,ParameterDirection.Input),*/

            new OracleParameter ("P_ALLERGY",OracleDbType.Varchar2,10,pat.Allergy,ParameterDirection.Input),
            new OracleParameter ("P_ALLERGY_text",OracleDbType.Varchar2,300,pat.AllergyText,ParameterDirection.Input),
          
            new OracleParameter("Entry_by", OracleDbType.Varchar2,15,pat.EntryParameter.EntryBy,ParameterDirection.Input),
            //new OracleParameter("Entry_date", OracleDbType.Varchar2,15,pat.EntryDate,ParameterDirection.Input),
            new OracleParameter("company_id", OracleDbType.Varchar2,15,pat.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("location_id", OracleDbType.Varchar2,15,pat.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("machine_id", OracleDbType.Varchar2,15,pat.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }

        public short UpdatePatientDetails(Patient pat)
        {
            string packageName = "AGH_PAT_REG.pkg_registration.update_pat_master";
            OracleParameter[] parameterList = new OracleParameter[] { 
            new OracleParameter("p_out",OracleDbType.Int32,null,ParameterDirection.Output),
            new OracleParameter("Pid", OracleDbType.Varchar2,30,pat.HCN, ParameterDirection.Input),
            new OracleParameter("patName",OracleDbType.Varchar2,150,pat.Name,ParameterDirection.Input),
            new OracleParameter("patNameB",OracleDbType.Varchar2,150,pat.NameBeng,ParameterDirection.Input),
            new OracleParameter("FatherName", OracleDbType.Varchar2,150,pat.FathersName,ParameterDirection.Input),
            new OracleParameter("FatherNameB", OracleDbType.Varchar2,150,pat.FathersNameBeng,ParameterDirection.Input),
            new OracleParameter("MotherName", OracleDbType.Varchar2,150,pat.MothersName,ParameterDirection.Input),
            new OracleParameter("MotherNameB", OracleDbType.Varchar2,150,pat.MothersNameBeng,ParameterDirection.Input),
            new OracleParameter("GuardianName", OracleDbType.Varchar2,150,pat.GuardianName,ParameterDirection.Input),
            new OracleParameter("GuardianNameB", OracleDbType.Varchar2,150,pat.GuardianNameBeng,ParameterDirection.Input),
            new OracleParameter("RelationWithGuard", OracleDbType.Varchar2,5,pat.RelationWithGuardian,ParameterDirection.Input),
            new OracleParameter("SpouseName", OracleDbType.Varchar2,150,pat.SpouseName,ParameterDirection.Input),
            new OracleParameter("SpouseNameB", OracleDbType.Varchar2,150,pat.SpouseNameBeng,ParameterDirection.Input),
            new OracleParameter("DOB", OracleDbType.Date,30,pat.DOB,ParameterDirection.Input),
            new OracleParameter("Sex", OracleDbType.Char,1,pat.Sex,ParameterDirection.Input),
            new OracleParameter("Religion", OracleDbType.Char,1,pat.Religion,ParameterDirection.Input),
            new OracleParameter("BloodGroup", OracleDbType.Varchar2,4,pat.BloodGroup,ParameterDirection.Input),
            new OracleParameter("MaritalStatus", OracleDbType.Char,1,pat.MaritalStatus,ParameterDirection.Input),
            new OracleParameter("EducationLevel", OracleDbType.Char,1,pat.MaxEducation,ParameterDirection.Input),
            new OracleParameter("Occupation", OracleDbType.Varchar2,30,pat.Occupation,ParameterDirection.Input),
            new OracleParameter("IncomeGroup", OracleDbType.Varchar2,1,pat.IncomeGroup,ParameterDirection.Input),
            new OracleParameter("YearlyIncome", OracleDbType.Int64,10,pat.YearlyIncome,ParameterDirection.Input),
            new OracleParameter("NID", OracleDbType.Varchar2,50,pat.NID,ParameterDirection.Input),
            new OracleParameter("email", OracleDbType.Varchar2,70,pat.Email,ParameterDirection.Input),
            new OracleParameter("CellPhone", OracleDbType.Varchar2,20,pat.CellPhone,ParameterDirection.Input),
            new OracleParameter("HomePhone", OracleDbType.Varchar2,20,pat.HomePhone,ParameterDirection.Input),
            new OracleParameter("ho_vi_ar_rd", OracleDbType.Varchar2,200,pat.Present_H_R_B,ParameterDirection.Input),
            new OracleParameter("ho_vi_ar_rd_B", OracleDbType.Varchar2,200,pat.Present_H_R_B_Beng,ParameterDirection.Input),
            new OracleParameter("post_code", OracleDbType.Varchar2,10,pat.Present_Post,ParameterDirection.Input),
            new OracleParameter("thana", OracleDbType.Varchar2,100,pat.PresentThana,ParameterDirection.Input),
            new OracleParameter("district", OracleDbType.Varchar2,100,pat.PresentDistrict,ParameterDirection.Input),
            new OracleParameter("country", OracleDbType.Varchar2,100,pat.PresentDistrict,ParameterDirection.Input),
            new OracleParameter("p_ho_vi_ar_rd", OracleDbType.Varchar2,200,pat.Permanent_H_R_B,ParameterDirection.Input),
            new OracleParameter("p_post_code", OracleDbType.Varchar2,10,pat.Permanent_Post,ParameterDirection.Input),
            new OracleParameter("p_thana", OracleDbType.Varchar2,100,pat.PermanentThana,ParameterDirection.Input),
            new OracleParameter("p_district", OracleDbType.Varchar2,100,pat.PermanentDistrict,ParameterDirection.Input),
            new OracleParameter("e_contact_person", OracleDbType.Varchar2,150,pat.EmergencyContactPerson,ParameterDirection.Input),
            new OracleParameter("e_contact_personB", OracleDbType.Varchar2,150,pat.EmergencyContactPersonBeng,ParameterDirection.Input),
            new OracleParameter("e_address", OracleDbType.Varchar2,200,pat.EmergencyAddress,ParameterDirection.Input),
            new OracleParameter("e_addressB", OracleDbType.Varchar2,200,pat.EmergencyAddressBeng,ParameterDirection.Input),
            new OracleParameter("e_cell_phone", OracleDbType.Varchar2,20,pat.EmergencyCellPhone,ParameterDirection.Input),
            new OracleParameter("e_home_phone", OracleDbType.Varchar2,20,pat.HomePhone,ParameterDirection.Input),
            new OracleParameter("e_rel_with_pat", OracleDbType.Varchar2,20,pat.EmergencyPersonRelation,ParameterDirection.Input),
            new OracleParameter("e_thana_code", OracleDbType.Varchar2,100,pat.EmergencyAddressThana,ParameterDirection.Input),
            new OracleParameter("e_district_code", OracleDbType.Varchar2,100,pat.EmergencyAddressDistrict,ParameterDirection.Input),
            new OracleParameter("e_email", OracleDbType.Varchar2,70,pat.EmergencyPersonEmail,ParameterDirection.Input),
            new OracleParameter("staff_type_id", OracleDbType.Varchar2,3,pat.staff_type_id,ParameterDirection.Input),
            new OracleParameter("staff_id", OracleDbType.Varchar2,30,pat.StaffID,ParameterDirection.Input),
            new OracleParameter("dependent_ID", OracleDbType.Varchar2,30,pat.Dependent_ID,ParameterDirection.Input),
            new OracleParameter("is_staff_self", OracleDbType.Varchar2,1,pat.Is_staff_self,ParameterDirection.Input),
            new OracleParameter("corporate_id", OracleDbType.Varchar2,30,pat.CorporateID,ParameterDirection.Input),
            new OracleParameter("category_id", OracleDbType.Varchar2,5,pat.CategoryID,ParameterDirection.Input),
            new OracleParameter("photo_path", OracleDbType.Varchar2,300,pat.Photo,ParameterDirection.Input),

            new OracleParameter ("P_ALLERGY",OracleDbType.Varchar2,10,pat.Allergy,ParameterDirection.Input),
            new OracleParameter ("P_ALLERGY_text",OracleDbType.Varchar2,300,pat.AllergyText,ParameterDirection.Input),

            new OracleParameter("Entry_by", OracleDbType.Varchar2,15,pat.EntryParameter.EntryBy,ParameterDirection.Input),           
            new OracleParameter("company_id", OracleDbType.Varchar2,15,pat.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("location_id", OracleDbType.Varchar2,15,pat.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("machine_id", OracleDbType.Varchar2,15,pat.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public string CardIssue(OPDPayment payment)
        {
            string packageName = "pkg_registration.reg_card_issue";
            OracleParameter[] parameterList = new OracleParameter[]
          { 
            new OracleParameter("transacNo", OracleDbType.Varchar2,50,null, ParameterDirection.Output),
            new OracleParameter("dept",OracleDbType.Varchar2,20,payment.Department,ParameterDirection.Input),
            new OracleParameter("ReffDept",OracleDbType.Varchar2,20,payment.ReffDept,ParameterDirection.Input),
            new OracleParameter("deptUnit",OracleDbType.Varchar2,20,payment.DepartmentUnit,ParameterDirection.Input),
            new OracleParameter("ReffDeptUnit",OracleDbType.Varchar2,20,payment.ReffDeptUnit,ParameterDirection.Input),
            new OracleParameter("Purpose",OracleDbType.Varchar2,20,payment.PurposeID,ParameterDirection.Input), 
            new OracleParameter("deptAmt",OracleDbType.Decimal,30,payment.DeptAmount,ParameterDirection.Input), 
            new OracleParameter("ReffdeptAmt",OracleDbType.Decimal,30,payment.ReffDeptAmount,ParameterDirection.Input), 
            new OracleParameter("discount",OracleDbType.Decimal,30,payment.Discount,ParameterDirection.Input), 
            new OracleParameter("Vat",OracleDbType.Decimal,30,payment.VAT,ParameterDirection.Input), 
            new OracleParameter("total",OracleDbType.Decimal,30,payment.NetAmount,ParameterDirection.Input), 
            new OracleParameter("TransactionDate", OracleDbType.Date,30,payment.PaymentDate,ParameterDirection.Input),
            new OracleParameter("staffId",OracleDbType.Varchar2,30,payment.Staff,ParameterDirection.Input),
            new OracleParameter("patNo",OracleDbType.Varchar2,30,payment.HCN,ParameterDirection.Input),
            new OracleParameter("regNo",OracleDbType.Varchar2,30,payment.RegistrationNo,ParameterDirection.Input),
            new OracleParameter("pType",OracleDbType.Varchar2,30,payment.PaymentType,ParameterDirection.Input),
            new OracleParameter("payment_string",OracleDbType.Varchar2,100000,payment.PaymentString,ParameterDirection.Input),
            new OracleParameter("Entry_by", OracleDbType.Varchar2,15,payment.EntryBy,ParameterDirection.Input),
            new OracleParameter("Entry_date", OracleDbType.Date,15,payment.EntryDate,ParameterDirection.Input),
            new OracleParameter("company_id", OracleDbType.Varchar2,15,payment.CompanyID,ParameterDirection.Input),
            new OracleParameter("location_id", OracleDbType.Varchar2,15,payment.LocationID,ParameterDirection.Input),
            new OracleParameter("machine_id", OracleDbType.Varchar2,15,payment.MachineID,ParameterDirection.Input)
        };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }

        public string VerifyPatientNo(string patNo)
        {
            string packageName = "pkg_registration.verify_pat_no";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
            new OracleParameter(":PatName", OracleDbType.Varchar2,250,null, ParameterDirection.Output),
            new OracleParameter(":patNo",OracleDbType.Varchar2,30,patNo,ParameterDirection.Input)
            };

            DALHelper.GetValue(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string patName = (string)(OracleString)prm.Value;
            return patName;
        }
        public Patient GetPatient(string pId)
        {
            Patient pat = new Patient();
            string packageName = "AGH_PAT_REG.pkg_registration.get_reg_pat";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pid",OracleDbType.Varchar2,30,pId,ParameterDirection.Input),                
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                pat.HCN = (String)rdr["HCN"];
                pat.Name = (String)rdr["PAT_NAME"];
                pat.DOB = (DateTime)rdr["DOB"];
                pat.Sex = (String)rdr["SEX"];
                pat.NameBeng = (rdr["PAT_NAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["PAT_NAME_BENG"]);
                pat.FathersName = (rdr["FNAME"] == DBNull.Value ? string.Empty : (string)rdr["FNAME"]);
                pat.FathersNameBeng = (rdr["FNAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["FNAME_BENG"]);
                pat.MothersName = (rdr["MNAME"] == DBNull.Value ? string.Empty : (string)rdr["MNAME"]);
                pat.MothersNameBeng = (rdr["MNAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["MNAME_BENG"]);

                pat.SpouseName = (rdr["SPOUSE_NAME"] == DBNull.Value ? string.Empty : (string)rdr["SPOUSE_NAME"]);
                pat.SpouseNameBeng = (rdr["SPOUSE_NAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["SPOUSE_NAME_BENG"]);
                pat.GuardianName = (rdr["GUARDIAN_NAME"] == DBNull.Value ? string.Empty : (string)rdr["GUARDIAN_NAME"]);
                pat.GuardianNameBeng = (rdr["GUARDIAN_NAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["GUARDIAN_NAME_BENG"]);
                pat.RelationWithGuardian = (rdr["RELATION_WITH_GUARD"] == DBNull.Value ? string.Empty : (string)rdr["RELATION_WITH_GUARD"]);
                pat.Religion = (String)rdr["RELIGION"];
                pat.BloodGroup = (String)rdr["BLOOD_GRP"];

                pat.MaritalStatus = (String)rdr["MARITAL_STATUS"];
                pat.MaxEducation = (rdr["EDUCATION_LEVEL"] == DBNull.Value ? string.Empty : (string)rdr["EDUCATION_LEVEL"]);
                pat.Occupation = (String)rdr["OCCUPATION"];

                pat.IncomeGroup = (rdr["INCOME_GROUP"] == DBNull.Value ? string.Empty : (string)rdr["INCOME_GROUP"]);
                pat.YearlyIncome = Convert.ToString(rdr["YEARLY_INCOME"] == DBNull.Value ? 0 : (decimal)rdr["HO_VI_AR_RD"]);
                pat.NID = (rdr["NID"] == DBNull.Value ? string.Empty : (string)rdr["NID"]);
                pat.Email = (rdr["EMAIL"] == DBNull.Value ? string.Empty : (string)rdr["EMAIL"]);
                pat.CellPhone = (rdr["CELL_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["CELL_PHONE"]);
                pat.HomePhone = (rdr["HOME_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["HOME_PHONE"]);

                pat.Present_H_R_B = (rdr["HO_VI_AR_RD"] == DBNull.Value ? string.Empty : (string)rdr["HO_VI_AR_RD"]);
                pat.Present_H_R_B_Beng = (rdr["HO_VI_AR_RD_BENG"] == DBNull.Value ? string.Empty : (string)rdr["HO_VI_AR_RD_BENG"]);
                pat.Present_Post = (rdr["POST_CODE"] == DBNull.Value ? string.Empty : (string)rdr["POST_CODE"]);
                pat.PresentDistrict = (String)rdr["DISTRICT_CODE"];
                pat.PresentThana = (String)rdr["THANA_CODE"];

                pat.Country = (String)rdr["COUNTRY"];

                pat.Permanent_H_R_B = (rdr["PER_HO_VI_AR_RD"] == DBNull.Value ? string.Empty : (string)rdr["PER_HO_VI_AR_RD"]);
                pat.Permanent_Post = (rdr["PER_POST_CODE"] == DBNull.Value ? string.Empty : (string)rdr["PER_POST_CODE"]);
                pat.PermanentDistrict = (String)rdr["PER_DISTRICT_CODE"];
                pat.PermanentThana = (String)rdr["PER_THANA_CODE"];

                pat.EmergencyContactPerson = (rdr["E_CONT_PERSON"] == DBNull.Value ? string.Empty : (string)rdr["E_CONT_PERSON"]);
                pat.EmergencyContactPersonBeng = (rdr["E_CONT_PERSON_BENG"] == DBNull.Value ? string.Empty : (string)rdr["E_CONT_PERSON_BENG"]);
                pat.EmergencyAddress = (rdr["E_ADDRESS"] == DBNull.Value ? string.Empty : (string)rdr["E_ADDRESS"]);

                pat.EmergencyAddressBeng = (rdr["E_ADDRESS_BENG"] == DBNull.Value ? string.Empty : (string)rdr["E_ADDRESS_BENG"]);
                pat.EmergencyCellPhone = (rdr["E_CELL_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["E_CELL_PHONE"]);
                pat.EmergencyHomePhone = (rdr["E_HOME_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["E_HOME_PHONE"]);
                pat.EmergencyPersonRelation = (rdr["E_REL_WITH_PAT"] == DBNull.Value ? string.Empty : (string)rdr["E_REL_WITH_PAT"]);
                pat.EmergencyAddressDistrict = (rdr["E_DISTRICT_CODE"] == DBNull.Value ? string.Empty : (string)rdr["E_DISTRICT_CODE"]);
                pat.EmergencyAddressThana = (rdr["E_THANA_CODE"] == DBNull.Value ? string.Empty : (string)rdr["E_THANA_CODE"]);
                pat.EmergencyPersonEmail = (rdr["E_EMAIL"] == DBNull.Value ? string.Empty : (string)rdr["E_EMAIL"]);

                pat.staff_type_id = (rdr["STAFF_TYPE_ID"] == DBNull.Value ? string.Empty : (string)rdr["STAFF_TYPE_ID"]);
                pat.StaffID = (rdr["STAFF_ID"] == DBNull.Value ? string.Empty : (string)rdr["STAFF_ID"]);
                pat.Dependent_ID = (rdr["DEPENDENT_ID"] == DBNull.Value ? string.Empty : (string)rdr["DEPENDENT_ID"]);
                pat.Is_staff_self = (rdr["IS_STAFF_SELF"] == DBNull.Value ? string.Empty : (string)rdr["IS_STAFF_SELF"]);
                pat.CorporateID = (rdr["CORPORATE_ID"] == DBNull.Value ? string.Empty : (string)rdr["CORPORATE_ID"]);
                pat.CategoryID = (rdr["CATEGORY_ID"] == DBNull.Value ? string.Empty : (string)rdr["CATEGORY_ID"]);

                pat.Photo = (rdr["PHOTO_PATH"] == DBNull.Value ? string.Empty : (string)rdr["PHOTO_PATH"]);

                pat.Allergy = (rdr["ALLERGY"] == DBNull.Value ? "0" : (string)rdr["ALLERGY"]);
                pat.AllergyText = (rdr["ALLERGY_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ALLERGY_TEXT"]);
            }
            rdr.Close();
            return pat;
        }
        public Patient GetStaffTypePatient(string staffID, string isStaffSelf)
        {
            Patient spat = new Patient();
            string packageName = "AGH_PAT_REG.pkg_registration.get_staff_type_patient";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("staffID",OracleDbType.Varchar2,30,staffID,ParameterDirection.Input),  
                new OracleParameter("isStaffSelf",OracleDbType.Varchar2,1,isStaffSelf,ParameterDirection.Input),  
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                spat.HCN = (String)rdr["HCN"];
                // spat.StaffID = !rdr.IsDBNull(1) ? (String)rdr["STAFF_ID"] : "";
                //spat.Is_staff_self = !rdr.IsDBNull(2) ? (String)rdr["IS_STAFF_SELF"] : "";
            }
            rdr.Close();
            return spat;
        }

        public List<Patient> ViewList()
        {
            string packageName = "pkg_registration.view_registration";
            OracleParameter[] parameterList = new OracleParameter[]
           { 
            new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            List<Patient> patients = new List<Patient>();
            OracleDataReader rdr;
            OracleConnection conn = new OracleConnection();
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Patient patObj = new Patient();
                patObj.Name = (String)rdr[0].ToString();
                patObj.FathersName = (String)rdr.GetOracleString(1);
                patients.Add(patObj);
            }
            rdr.Close();
            return patients;
        }

        public short SaveStaffType(StaffType sType)
        {
            string packageName = "AGH_PAT_REG.pkg_registration.insert_Staff_Type";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TypeTitle",OracleDbType.Varchar2,60,sType.TypeTitle,ParameterDirection.Input),
                new OracleParameter("TypeTitleBeng",OracleDbType.Varchar2,60,sType.TypeTitleBeng,ParameterDirection.Input),             
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,sType.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,sType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,20,sType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,20,sType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,sType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public short UpdateStaffType(StaffType sType)
        {
            string packageName = "AGH_PAT_REG.pkg_registration.Update_Staff_Type";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TypeID",OracleDbType.Varchar2,2,sType.TypeID,ParameterDirection.Input),
                new OracleParameter("TypeTitle",OracleDbType.Varchar2,60,sType.TypeTitle,ParameterDirection.Input),
                new OracleParameter("TypeTitleBeng",OracleDbType.Varchar2,60,sType.TypeTitleBeng,ParameterDirection.Input),             
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,sType.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,sType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,20,sType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,20,sType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,sType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public List<StaffType> getStaffType()
        {
            string packageName = "AGH_PAT_REG.pkg_registration.get_staff_type";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<StaffType> oStaffTypeLIST = new List<StaffType>();
            while (rdr.Read())
            {
                StaffType sType = new StaffType();
                sType.TypeID = (String)rdr["TYPE_ID"];
                sType.TypeTitle = (String)rdr["TYPE_TITLE"];
                sType.TypeTitleBeng = (String)rdr["TYPE_TITLE_BENG"];
                sType.Remarks = !rdr.IsDBNull(3) ? (String)rdr["REMARKS"] : "";

                oStaffTypeLIST.Add(sType);
            }
            rdr.Close();
            return oStaffTypeLIST;
        }


        public List<Patient> GetPatientsDetails()
        {
            string packageName = "AGH_PAT_REG.pkg_registration.Get_Patient_Details";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)               
            };
            return GetPatForAll(packageName, parameterList);
        }

        private List<Patient> GetPatForAll(string packageName, OracleParameter[] parameterList)
        {
            List<Patient> oPatientDetailsLIST = new List<Patient>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                Patient pat = new Patient();
                pat.HCN = (String)rdr["HCN"];
                pat.Name = (String)rdr["PAT_NAME"];
                pat.DOB = (DateTime)rdr["DOB"];
                pat.Sex = (String)rdr["SEX"];
                pat.NameBeng = (rdr["PAT_NAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["PAT_NAME_BENG"]);
                pat.FathersName = (rdr["FNAME"] == DBNull.Value ? string.Empty : (string)rdr["FNAME"]);
                pat.FathersNameBeng = (rdr["FNAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["FNAME_BENG"]);
                pat.MothersName = (rdr["MNAME"] == DBNull.Value ? string.Empty : (string)rdr["MNAME"]);
                pat.MothersNameBeng = (rdr["MNAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["MNAME_BENG"]);

                pat.SpouseName = (rdr["SPOUSE_NAME"] == DBNull.Value ? string.Empty : (string)rdr["SPOUSE_NAME"]);
                pat.SpouseNameBeng = (rdr["SPOUSE_NAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["SPOUSE_NAME_BENG"]);
                pat.GuardianName = (rdr["GUARDIAN_NAME"] == DBNull.Value ? string.Empty : (string)rdr["GUARDIAN_NAME"]);
                pat.GuardianNameBeng = (rdr["GUARDIAN_NAME_BENG"] == DBNull.Value ? string.Empty : (string)rdr["GUARDIAN_NAME_BENG"]);
                pat.RelationWithGuardian = (rdr["RELATION_WITH_GUARD"] == DBNull.Value ? string.Empty : (string)rdr["RELATION_WITH_GUARD"]);
                pat.Religion = (String)rdr["RELIGION"];
                pat.BloodGroup = (String)rdr["BLOOD_GRP"];

                pat.MaritalStatus = (String)rdr["MARITAL_STATUS"];
                pat.MaxEducation = (rdr["EDUCATION_LEVEL"] == DBNull.Value ? string.Empty : (string)rdr["EDUCATION_LEVEL"]);
                pat.Occupation = (String)rdr["OCCUPATION"];

                pat.IncomeGroup = (rdr["INCOME_GROUP"] == DBNull.Value ? string.Empty : (string)rdr["INCOME_GROUP"]);
                pat.YearlyIncome = Convert.ToString(rdr["YEARLY_INCOME"] == DBNull.Value ? 0 : (decimal)rdr["HO_VI_AR_RD"]);
                pat.NID = (rdr["NID"] == DBNull.Value ? string.Empty : (string)rdr["NID"]);
                pat.Email = (rdr["EMAIL"] == DBNull.Value ? string.Empty : (string)rdr["EMAIL"]);
                pat.CellPhone = (rdr["CELL_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["CELL_PHONE"]);
                pat.HomePhone = (rdr["HOME_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["HOME_PHONE"]);

                pat.Present_H_R_B = (rdr["HO_VI_AR_RD"] == DBNull.Value ? string.Empty : (string)rdr["HO_VI_AR_RD"]);
                pat.Present_H_R_B_Beng = (rdr["HO_VI_AR_RD_BENG"] == DBNull.Value ? string.Empty : (string)rdr["HO_VI_AR_RD_BENG"]);
                pat.Present_Post = (rdr["POST_CODE"] == DBNull.Value ? string.Empty : (string)rdr["POST_CODE"]);
                pat.PresentDistrict = (String)rdr["DISTRICT_CODE"];
                pat.PresentThana = (String)rdr["THANA_CODE"];

                pat.Country = (String)rdr["COUNTRY"];

                pat.Permanent_H_R_B = (rdr["PER_HO_VI_AR_RD"] == DBNull.Value ? string.Empty : (string)rdr["PER_HO_VI_AR_RD"]);
                pat.Permanent_Post = (rdr["PER_POST_CODE"] == DBNull.Value ? string.Empty : (string)rdr["PER_POST_CODE"]);
                pat.PermanentDistrict = (String)rdr["PER_DISTRICT_CODE"];
                pat.PermanentThana = (String)rdr["PER_THANA_CODE"];

                pat.EmergencyContactPerson = (rdr["E_CONT_PERSON"] == DBNull.Value ? string.Empty : (string)rdr["E_CONT_PERSON"]);
                pat.EmergencyContactPersonBeng = (rdr["E_CONT_PERSON_BENG"] == DBNull.Value ? string.Empty : (string)rdr["E_CONT_PERSON_BENG"]);
                pat.EmergencyAddress = (rdr["E_ADDRESS"] == DBNull.Value ? string.Empty : (string)rdr["E_ADDRESS"]);

                pat.EmergencyAddressBeng = (rdr["E_ADDRESS_BENG"] == DBNull.Value ? string.Empty : (string)rdr["E_ADDRESS_BENG"]);
                pat.EmergencyCellPhone = (rdr["E_CELL_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["E_CELL_PHONE"]);
                pat.EmergencyHomePhone = (rdr["E_HOME_PHONE"] == DBNull.Value ? string.Empty : (string)rdr["E_HOME_PHONE"]);
                pat.EmergencyPersonRelation = (rdr["E_REL_WITH_PAT"] == DBNull.Value ? string.Empty : (string)rdr["E_REL_WITH_PAT"]);
                pat.EmergencyAddressDistrict = (rdr["E_DISTRICT_CODE"] == DBNull.Value ? string.Empty : (string)rdr["E_DISTRICT_CODE"]);
                pat.EmergencyAddressThana = (rdr["E_THANA_CODE"] == DBNull.Value ? string.Empty : (string)rdr["E_THANA_CODE"]);
                pat.EmergencyPersonEmail = (rdr["E_EMAIL"] == DBNull.Value ? string.Empty : (string)rdr["E_EMAIL"]);

                pat.staff_type_id = (rdr["STAFF_TYPE_ID"] == DBNull.Value ? string.Empty : (string)rdr["STAFF_TYPE_ID"]);
                pat.StaffID = (rdr["STAFF_ID"] == DBNull.Value ? string.Empty : (string)rdr["STAFF_ID"]);
                pat.Dependent_ID = (rdr["DEPENDENT_ID"] == DBNull.Value ? string.Empty : (string)rdr["DEPENDENT_ID"]);
                pat.Is_staff_self = (rdr["IS_STAFF_SELF"] == DBNull.Value ? string.Empty : (string)rdr["IS_STAFF_SELF"]);
                pat.CorporateID = (rdr["CORPORATE_ID"] == DBNull.Value ? string.Empty : (string)rdr["CORPORATE_ID"]);
                pat.CategoryID = (rdr["CATEGORY_ID"] == DBNull.Value ? string.Empty : (string)rdr["CATEGORY_ID"]);

                pat.Photo = (rdr["PHOTO_PATH"] == DBNull.Value ? string.Empty : (string)rdr["PHOTO_PATH"]);

                pat.Allergy = (rdr["ALLERGY"] == DBNull.Value ? "0" : (string)rdr["ALLERGY"]);
                pat.AllergyText = (rdr["ALLERGY_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ALLERGY_TEXT"]);
                oPatientDetailsLIST.Add(pat);
            }
            rdr.Close();
            return oPatientDetailsLIST;

        }

        public List<Patient> GetPatientDetails(string name, string cell)
        {
            string packageName = "AGH_PAT_REG.pkg_registration.Get_Patient_Details_By_Cell";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("name",OracleDbType.Varchar2,30,name,ParameterDirection.Input),
                new OracleParameter("cell",OracleDbType.Varchar2,30,cell,ParameterDirection.Input)
               
            };
            return GetPatForAll(packageName, parameterList);
        }


        public List<Patient> GetPatientDetailsAppointment(string parameter)
        {
            string packageName = "AGH_PAT_REG.pkg_registration.Get_Pat_Details_ForAppointment";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("hcnORCell",OracleDbType.Varchar2,30,parameter,ParameterDirection.Input),          
            };
            return GetPatForAll(packageName, parameterList);
        }

        public List<Patient> SearchPatients(string DOB, string name = "", string fname = "", string cell = "")
        {
            string packageName = "AGH_PAT_REG.pkg_registration.Search_Patient";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DOB",OracleDbType.Varchar2,20,DOB,ParameterDirection.Input),
                new OracleParameter("name",OracleDbType.Varchar2,30,name,ParameterDirection.Input),
                new OracleParameter("fname",OracleDbType.Varchar2,30,fname,ParameterDirection.Input),
                new OracleParameter("cell",OracleDbType.Varchar2,20,cell,ParameterDirection.Input)
                  
            };
            return GetPatForAll(packageName, parameterList);
        }

        public short SaveCorpType(CorporateType corpType)
        {
            string packageName = "pkg_registration.Insert_Corp_Information";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("CorpTypeID",OracleDbType.Varchar2,2,corpType.CorpTypeID,ParameterDirection.Input),
                new OracleParameter("CorpTypeTitle",OracleDbType.Varchar2,200,corpType.CorpTitle,ParameterDirection.Input),
                new OracleParameter("CorpTypeTitleBeng",OracleDbType.Varchar2,200,corpType.CorpTitleBeng,ParameterDirection.Input),             
                new OracleParameter("Corp_Address",OracleDbType.Varchar2,500,corpType.CorpAddress,ParameterDirection.Input),
                new OracleParameter("Corp_web",OracleDbType.Varchar2,50,corpType.CorpWeb,ParameterDirection.Input),
                new OracleParameter("Corp_email",OracleDbType.Varchar2,50,corpType.CorpEmail,ParameterDirection.Input),
                new OracleParameter("Corp_phone",OracleDbType.Varchar2,50,corpType.CorpPhone,ParameterDirection.Input),
                new OracleParameter("Corp_mobile",OracleDbType.Varchar2,50,corpType.CorpMobile,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,corpType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,20,corpType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,20,corpType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,corpType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public short UpdateCorpType(CorporateType corpType)
        {
            string packageName = "pkg_registration.Update_Corp_Type";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("CorpID",OracleDbType.Varchar2,2,corpType.CorpID,ParameterDirection.Input),
                new OracleParameter("CorpTypeID",OracleDbType.Varchar2,2,corpType.CorpTypeID,ParameterDirection.Input),
                new OracleParameter("CorpTypeTitle",OracleDbType.Varchar2,200,corpType.CorpTitle,ParameterDirection.Input),
                new OracleParameter("CorpTypeTitleBeng",OracleDbType.Varchar2,200,corpType.CorpTitleBeng,ParameterDirection.Input),             
                new OracleParameter("Corp_Address",OracleDbType.Varchar2,500,corpType.CorpAddress,ParameterDirection.Input),
                new OracleParameter("Corp_web",OracleDbType.Varchar2,50,corpType.CorpWeb,ParameterDirection.Input),
                new OracleParameter("Corp_email",OracleDbType.Varchar2,50,corpType.CorpEmail,ParameterDirection.Input),
                new OracleParameter("Corp_phone",OracleDbType.Varchar2,50,corpType.CorpPhone,ParameterDirection.Input),
                new OracleParameter("Corp_mobile",OracleDbType.Varchar2,50,corpType.CorpMobile,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,corpType.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,20,corpType.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,20,corpType.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,corpType.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<CorporateType> GetCorpTypes()
        {
            string packageName = "pkg_registration.get_Corp_types";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) };
            return GetCrpTypes(packageName, parameterList);
        }

        private List<CorporateType> GetCrpTypes(string packageName, OracleParameter[] parameterList)
        {
            List<CorporateType> CorpTypes = new List<CorporateType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            
            while (rdr.Read())
            {
                CorporateType Ocr = new CorporateType();
                Ocr.CorpID = (string)rdr[0];
                Ocr.CorpTypeID = (string)rdr[1];
                Ocr.CorpTitle = (string)rdr[2];
                Ocr.CorpTitleBeng = (string)rdr[3];
                Ocr.CorpAddress = (string)rdr[4];
                Ocr.CorpWeb = !rdr.IsDBNull(5) ? (string)rdr[5] : "";
                Ocr.CorpEmail = !rdr.IsDBNull(6) ? (string)rdr[6] : "";
                Ocr.CorpPhone = !rdr.IsDBNull(7) ? (string)rdr[7] : "";
                Ocr.CorpMobile = !rdr.IsDBNull(8) ? (string)rdr[8] : "";
                CorpTypes.Add(Ocr);
            }
            rdr.Close();
            return CorpTypes;
        }

        public Patient GetPatient()
        {
            Patient pat = new Patient();
            string packageName = "AGH_PAT_REG.pkg_registration.Get_Patient_Details";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                //new OracleParameter("pid",OracleDbType.Varchar2,30,pId,ParameterDirection.Input),                
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                pat.HCN = (String)rdr["HCN"];
                pat.Name = (String)rdr["PAT_NAME"];
                pat.DOB = (DateTime)rdr["DOB"];
                pat.Sex = (String)rdr["SEX"];
                pat.NameBeng = !rdr.IsDBNull(4) ? (String)rdr["PAT_NAME_BENG"] : "";
                pat.FathersName = !rdr.IsDBNull(5) ? (String)rdr["FNAME"] : "";
                pat.FathersNameBeng = !rdr.IsDBNull(6) ? (String)rdr["FNAME_BENG"] : "";
                pat.MothersName = !rdr.IsDBNull(7) ? (String)rdr["MNAME"] : "";
                pat.MothersNameBeng = !rdr.IsDBNull(8) ? (String)rdr["MNAME_BENG"] : "";

                pat.SpouseName = !rdr.IsDBNull(9) ? (String)rdr["SPOUSE_NAME"] : "";
                pat.SpouseNameBeng = !rdr.IsDBNull(10) ? (String)rdr["SPOUSE_NAME_BENG"] : "";
                pat.GuardianName = !rdr.IsDBNull(11) ? (String)rdr["GUARDIAN_NAME"] : "";
                pat.GuardianNameBeng = !rdr.IsDBNull(12) ? (String)rdr["GUARDIAN_NAME_BENG"] : "";
                pat.RelationWithGuardian = !rdr.IsDBNull(13) ? (String)rdr["RELATION_WITH_GUARD"] : "";
                pat.DOB = (DateTime)rdr["DOB"];
                pat.Religion = (String)rdr["RELIGION"];
                pat.BloodGroup = (String)rdr["BLOOD_GRP"];

                pat.MaritalStatus = (String)rdr["MARITAL_STATUS"];
                pat.MaxEducation = (String)rdr["EDUCATION_LEVEL"];
                pat.Occupation = (String)rdr["OCCUPATION"];

                pat.IncomeGroup = !rdr.IsDBNull(20) ? (String)rdr["INCOME_GROUP"] : "";
                pat.YearlyIncome = !rdr.IsDBNull(21) ? (String)rdr["YEARLY_INCOME"] : "";
                pat.NID = !rdr.IsDBNull(22) ? (String)rdr["NID"] : "";
                pat.Email = !rdr.IsDBNull(23) ? (String)rdr["EMAIL"] : "";
                pat.CellPhone = !rdr.IsDBNull(24) ? (String)rdr["CELL_PHONE"] : "";
                pat.HomePhone = !rdr.IsDBNull(25) ? (String)rdr["HOME_PHONE"] : "";

                pat.Present_H_R_B = !rdr.IsDBNull(26) ? (String)rdr["HO_VI_AR_RD"] : "";
                pat.Present_H_R_B_Beng = !rdr.IsDBNull(27) ? (String)rdr["HO_VI_AR_RD_BENG"] : "";
                pat.Present_Post = !rdr.IsDBNull(28) ? (String)rdr["POST_CODE"] : "";
                pat.PresentThana = (String)rdr["THANA_CODE"];
                pat.PresentDistrict = (String)rdr["DISTRICT_CODE"];

                pat.Permanent_H_R_B = !rdr.IsDBNull(31) ? (String)rdr["PER_HO_VI_AR_RD"] : "";
                pat.Permanent_Post = !rdr.IsDBNull(32) ? (String)rdr["PER_POST_CODE"] : "";
                pat.PermanentThana = (String)rdr["PER_THANA_CODE"];
                pat.PermanentDistrict = (String)rdr["PER_DISTRICT_CODE"];

                pat.EmergencyContactPerson = !rdr.IsDBNull(35) ? (String)rdr["E_CONT_PERSON"] : "";
                pat.EmergencyContactPersonBeng = !rdr.IsDBNull(36) ? (String)rdr["E_CONT_PERSON_BENG"] : "";
                pat.EmergencyAddress = !rdr.IsDBNull(37) ? (String)rdr["E_ADDRESS"] : "";
                pat.EmergencyAddressBeng = !rdr.IsDBNull(38) ? (String)rdr["E_ADDRESS_BENG"] : "";
                pat.EmergencyCellPhone = !rdr.IsDBNull(39) ? (String)rdr["E_CELL_PHONE"] : "";
                pat.EmergencyHomePhone = !rdr.IsDBNull(40) ? (String)rdr["E_HOME_PHONE"] : "";
                pat.EmergencyPersonRelation = !rdr.IsDBNull(41) ? (String)rdr["E_REL_WITH_PAT"] : "";
                pat.EmergencyAddressThana = !rdr.IsDBNull(42) ? (String)rdr["E_THANA_CODE"] : "";
                pat.EmergencyAddressDistrict = !rdr.IsDBNull(43) ? (String)rdr["E_DISTRICT_CODE"] : "";
                pat.EmergencyPersonEmail = !rdr.IsDBNull(44) ? (String)rdr["E_EMAIL"] : "";

                pat.staff_type_id = !rdr.IsDBNull(45) ? (String)rdr["STAFF_TYPE_ID"] : "";
                pat.StaffID = !rdr.IsDBNull(46) ? (String)rdr["STAFF_ID"] : "";
                pat.Dependent_ID = !rdr.IsDBNull(47) ? (String)rdr["DEPENDENT_ID"] : "";
                pat.Is_staff_self = !rdr.IsDBNull(48) ? (String)rdr["IS_STAFF_SELF"] : "";
                pat.CorporateID = !rdr.IsDBNull(49) ? (String)rdr["CORPORATE_ID"] : "";
                pat.CategoryID = !rdr.IsDBNull(50) ? (String)rdr["CATEGORY_ID"] : "";

                pat.Photo = !rdr.IsDBNull(52) ? (String)rdr["PHOTO_PATH"] : "";

            }
            rdr.Close();
            return pat;
        }

        public List<Patient> VerifyMobileOldORNew(string mobile_number)
        {
            string packageName = "pkg_registration.verify_mbl_oldORnew";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("mobile_number",OracleDbType.Varchar2,30,mobile_number,ParameterDirection.Input)              
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<Patient> oPatmobile = new  List<Patient>();

            while (rdr.Read())
            {
                Patient opat = new Patient();
                opat.HCN = (string)rdr["HCN"];
                opat.Name = (string)rdr["PAT_NAME"];

                oPatmobile.Add(opat);
            }
            rdr.Close();
            return oPatmobile;
        }
    }
}