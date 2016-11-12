using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class OPDTicketRO
    {
        public string TicketNo { get; set; }
        public string PreviousTicketNo { get; set; }
        public string PatientName { get; set; }
        public string HCN { get; set; }
        public string PatSerial { set; get; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string TransactionNo { get; set; }
        public string Staff_ID { get; set; }
        public string Case_ID { get; set; }
        public string Tkt_Type_ID { get; set; }
        public string Tkt_Cat { get; set; }
        public string Tkt_Status { get; set; }

        public string Dept_ID { get; set; }
        public string DepertmentName { get; set; }

        public string Unit_ID { get; set; }
        public string UnitName { get; set; }

        //public string Doctor_ID { get; set; }
        public string DoctorName { get; set; }

        public string TKT_Valid { get; set; }
        public string Copy_Printed { get; set; }
        public double TicketFee { set; get; }
        public double Consult_fee { get; set; }
        public double Refd_fee { get; set; }
        public double Dept_fee { get; set; }
        public double Discount { get; set; }
        public double VAT { get; set; }
        public string VoucherNo { set; get; }
        public double TotalAmount { set; get; }
        public double CashAmount { get; set; }    
        public double CreditCardAmount { get; set; }
        public double DebitCardAmount { get; set; }     
        public string EntryDate { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string HomePhone { get; set; }
        public string DOB { get; set; }
        public string DoctorID { get; set; }
        public string EntryBy { get; set; }
        public string RoomNo { get; set; }
        public string Room { get; set; }
        public string AppointmentID { get; set; }
        public string DoctorStatus { get; set; }



    }
}
