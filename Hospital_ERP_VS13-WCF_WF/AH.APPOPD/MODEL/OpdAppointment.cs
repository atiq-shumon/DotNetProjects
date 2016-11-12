using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;



namespace AH.APPOPD.MODEL
{
    public class OpdAppointment 
    {
        public AppointmentClient AppointmentClient { get; set; }
        public Patient Patient { set; get; }
        public string AppointID { get; set; }
        public string AppointmentType { get; set; }
        public string AppointmentMode { get; set; }
        public string VisitType { get; set; }
        public string VisitorType { get; set; }
        public string BookingType { get; set; }
        public string BatchID { get; set; }
        public string PackageID { get; set; }   
        public string  TokenNo { get; set; }
        public string StatusChangeCause { get; set; }
        public string CompelitionStatus { get; set; }
        public string ServiceID { get; set; }
        public DateTime RequestedDate { get; set; }
        public string  AppointDate { get; set; }
        public string  ApproxSTime { get; set; }
        public string  ApproxETime { get; set; }
        public char AllowAutonotification { get; set; }
        public Department Department { get; set; }
        public DepartmentUnit DepartmentUnit { get; set; }
        public Doctor Doctor { get; set; }
        public EntryParameter EntryParameter { get; set; }

    }
}
