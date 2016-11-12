using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
    public class PatientDischargeBillDetailsRO
    {
        public  string HCN{get;set;}
        public string RegistrationId { get; set; }
        public  string PatientName{get;set;}
        public  string Age{get;set;}
        public  string Gender{get;set;}
        public  string RoomTitle{get;set;}
        public  string BedTitle{get;set;}
        public string DepartmentHeadName { get; set; }
        public  string RevenueHead { get; set; }
        public  DateTime Date { get; set; }
        public  DateTime AdmissionDate{get;set;}
        public  DateTime DischargeDate{get;set;}
        public  string Quantity { get; set; }
        public  string Title { get; set; }
        public  int Dr { get; set; }
        public  int Cr { get; set; }
     
    }
}
