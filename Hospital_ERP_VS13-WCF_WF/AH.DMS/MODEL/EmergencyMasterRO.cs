using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DMS.MODEL
{
    public class EmergencyMasterRO
    {
        public string EmergencyPrescriptionID { set; get; }
        public string TransactionNo { set; get; }
        public string PackageID { set; get; }
        public string FormatDept { set; get; }
        public string HCN { set; get; }
        public string Gender { set; get; }
        public string Address { set; get; }
        public string Age { set; get; }
        public string PatientName { set; get; }
        public string ReffOrgID { set; get; }
        public string ReffOrgName { set; get; }
        public string DoctorID { set; get; }
        public string DoctorName { set; get; }
        public string TicketType { set; get; }
        public double TicketFee { set; get; }
        public double ConsultantFee { set; get; }
        public double Vat { set; get; }
        public double Discount { set; get; }
        public string EntryBy { get; set; }
        public string EntryByName { get; set; }
        public double NetPaid { set; get; }
        public double Qty { set; get; }
        public DateTime DOB { set; get; }
        public string MobileNo { set; get; }
    }
}
