using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;



namespace AH.PRMS.MODEL
{
   

    public class Bed
    {
        public Ward Ward { set; get; }
        public Building Building { set; get; }
        public string BedID { set; get; }
        public string BedTitle { set; get; }
        public string BedTitleBeng { set; get; }
        public BedType BedType { set; get; }
        public Department Department { set; get; }
        public BedFacility Facility { set; get; }
        public Room Room { set; get; }
        public NurseStation NurseStation { set; get; }
        public string Floor { set; get; }
        //public BedCharges BedCharges { set; get; }
        public string BedChargesString { set; get; }
        public string BedNo { set; get; }
        public string BedStatus { set; get; }
        public string RegistrationNo { set; get; }
        public short SerialNo { set; get; }
        public string Remarks { set; get; }
        public int NoOfDays { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
