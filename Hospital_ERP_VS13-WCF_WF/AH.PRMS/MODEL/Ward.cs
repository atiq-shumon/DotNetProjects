using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PRMS.MODEL
{
    public class Ward
    {
        public string WardID { set; get; }
        public string WardNo { set; get; }
        public string WardTitle { set; get; }
        public string WardTitleBeng { set; get; }
        public string BuildingID { set; get; }
        public string NthFloor { set; get; }
        public string BlockNo { set; get; }
        public Int32 NoRoom { set; get; }
        public Int16 TotalBed { set; get; }
        public Department Department { set; get; }
        public BedType BedType { set; get; }
        public string WardInCharge { set; get; }
        public string AllowedGender { set; get; }
        public string AgeRange { set; get; }
        public string Remarks { set; get; }
        public short SerialPriority { set; get; }
        public string AgeGroupMin { set; get; }
        public string AgeGroupMax { set; get; }
        public string isGenderRestricted { set; get; }
        public string isDepartmentRestricted { set; get; }
        public string isAgeRestricted { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
