using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PatReg.MODEL
{
    public class PatRegRO
    {
        public string PatientName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string DateofBirth { get; set; }
        public string Sex { get; set; }
        public string pat_name_beng { get; set; }
        public string fname_beng { get; set; }
        public string mname_beng { get; set; }
        public string spouse_name_beng { get; set; }
        public string GuardianName { get; set; }
        public string guardian_name_beng { get; set; }
        public string RelationshipGuardian { get; set; }
        public string Religion { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string EducationLevel { get; set; }
        public string Occupation { get; set; }
        public string IncomeGroup { get; set; }
        public string YearlyIncome { get; set; }
        public string NID { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string Address { get; set; }
        public string ho_vi_ar_rd_beng { get; set; }
        public string post_code { get; set; }
        public string thana_code { get; set; }
        public string district_code { get; set; }
        public string per_ho_vi_ar_rd { get; set; }
        public string per_post_code { get; set; }
        public string per_thana_code { get; set; }
        public string per_district_code { get; set; }
        public string e_cont_person { get; set; }
        public string e_cont_person_beng { get; set; }
        public string e_address { get; set; }
        public string e_address_beng { get; set; }
        public string e_cell_phone { get; set; }
        public string e_home_phone { get; set; }
        public string e_rel_with_pat { get; set; }
        public string staff_id { get; set; }
        public string corporate_id { get; set; }
        public string category_id { get; set; }
        public string EntryDate { get; set; }
        public string HCN { get; set; }
    }
}
