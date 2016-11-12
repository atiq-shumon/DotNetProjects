using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.DUtility;

namespace AH.OPD.MODEL
{
    public class Ticket
    {
        public string TicketNo { set; get; }
        public string RefundedTicketNo { set; get; }
        public string TicketType { set; get; }
        public string TicketCategory { set; get; }
        public string TicketStatus { set; get; }
        public string NurseStationID { set; get; }
        public DateTime TicketValidity { set; get; }
        public DateTime VisitDate { set; get; }
        public DateTime? NextVisitDate { set; get; }
        public int NextVisitAfterDay { set; get; }
        public int NextVisitAfterMonth { set; get; }
        public int NextVisitAfterYear { set; get; }
        public Patient Patient { set; get; }
        public OPDPayment PatientPayment { set; get; }
        public Department TicketDepartment { set; get; }
        public PaediatricHistory PaediatricHistory { get; set; }
        public GynHistory GynHistory { get; set; }
        public OPDDoctorCallQ OPDCallQ { set; get; }
        public Doctor Doctor { set; get; }
        public Age PatientAge { set; get; }
        public double TicketFee { set; get; }
        public string PatSerial { set; get; }

        public string acc_close_flag{get; set;}
        public string CopyPrintedBY { set; get; }
        public string CopyPrinted { set; get; }
        public string PreviousTicketNo { set; get; }
        public Room Room { set; get; }
        public string AppointmentID { get; set; }
        public EntryParameter EntryParameter { set; get; }
        public string FeeCollection { set; get; }
        public string FeeRefund { set; get; }
        public string FeeTotal { set; get; }
        public string FeeCashAmount { set; get; }
        public string FeeCreditCardAmount { set; get; }
        public string FeeDebitCardAmount { set; get; }
        public string Remarks { set; get; }
        public string PurposeID { set; get; }
        public string AmountSendToAccountDate { set; get; }
       
    }
}
