using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
        public class OPDPrescriptionRO
        {
            public string PatientName { get; set; }
            public string TicketNo { get; set; }
            public string HCN { get; set; }
            public string BloodGroup { get; set; }
            public string Sex { get; set; }
            public string Age { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
            public string BP { get; set; }
            public string Temparature { get; set; }
            public string TestGroup { get; set; }
            public string TestMain { get; set; }
            public string TestDetailsName { get; set; }
            public string DoctorName { get; set; }
            public string VisitDate { get; set; }
            public string Advice { get; set; }
            public string Diagnosis { get; set; }
            public string Medicine { get; set; }
            public string ComplaintsTitle { get; set; }
        }
    }

