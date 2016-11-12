using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
   public class DischargeReportRO
    {
        public string HCN { get; set; }
        public string RegistrationNo { get; set; }
        //public string MRNo { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string DepartmentID { get; set; }
        public string DepartmentTitle { get; set; }
        public string UnitTitle { get; set; }
        public string WardTitle { get; set; }
        public string WardNo { get; set; }
        //public string RoomNo { get; set; }
        public string BedNo { get; set; }
        public string BedType { get; set; }
       // public string BedType { get; set; }
        public string DepartmentHeadName { get; set; }
        public decimal AdvancePayment { get; set; }
        public decimal Total { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public string HeadTitle { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Quantity { get; set; }
    }
}
