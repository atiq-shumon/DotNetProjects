using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class Nominee
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public string NomineeId { set; get; }
        public string NomineeName { set; get; }
        public string NomineeNameBeng { set; get; }
        public string NomineeFatName { set; get; }
        public string NomineeFatNameBeng { set; get; }
        public string NomineeMotName { set; get; }
        public string NomineeMotNameBeng { set; get; }
        public string NomineeSpouseName { set; get; }
        public string NomineeSpouseNameBeng { set; get; }
        public string Religion { set; get; }
        public string Sex { set; get; }
        public string BloodGroup { set; get; }
        public string DOB { set; get; }
        public string MaritialStatus { set; get; }
        public string Nationality { set; get; }
        public string PhotoPath { set; get; }
        public string SignaturePath { set; get; }
        public string PersonalEmail { set; get; }
        public string HomePhone { set; get; }
        public string CellPhone { set; get; }
        public string NationalID { set; get; }
        public string Occupation { set; get; }
        public string NomineeSerial { set; get; }
        public string RelationWithStaff { set; get; }
        public string PresentAddress { set; get; }
        public string ParmanentAddress { set; get; }
        public string WorkAddress { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
