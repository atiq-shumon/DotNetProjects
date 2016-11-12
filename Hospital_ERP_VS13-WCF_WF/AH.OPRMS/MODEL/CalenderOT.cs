using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.OPRMS.MODEL
{
    public  class CalenderOT
    {
        public int intCol { get; set; }
        public int intRow { get; set; }
        public string RegNo { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string RegDate { get; set; }
        public string Fromtime { get; set; }
        public string Totime { get; set; }
        public string ScheduleID { get; set; }
        public string DoctorsCode { get; set; }
        public string InchargeId { get; set; }
        public string InchargeName { get; set; }
        public string Thetername { get; set; }
        public string TheterId { get; set; }
        public string PackageName { get; set; }
        public string PackageId { get; set; }
        public int status { get; set; }
        public string Comments { get; set; }
        public string scheduleId { get; set; }
        public string TimeSlot { get; set; }
        public string doctorsName { get; set; }
        public string packageitem { get; set; }
        public string packageitemRate { get; set; }
        public string Oprtype { get; set; }
        public string OprID { get; set; }
        public string OprName { get; set; }
        public double  PackageAmount { get; set; }
        public string AvailableFromTime { get; set; }
        public string AvailablrToTime { get; set; }
        public EntryParameter EntryParameter { set; get; }


    }
}
