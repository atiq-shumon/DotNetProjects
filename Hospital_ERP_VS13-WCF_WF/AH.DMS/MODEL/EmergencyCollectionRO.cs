using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DMS.MODEL
{
    public class EmergencyCollectionRO
    {
        public string Age { get; set; }
        public string PatientName { get; set; }
        public string MoneyReceipNo { get; set; }        
        public string TransactionNo { get; set; }
        public string HCN { get; set; }        
        public double Advance { get; set; }
        public double NetPaid { get; set; }
        public double Fee { get; set; }       
        public double Qty { get; set; }
        public string HeadID { get; set; }
        public string HeadName { get; set; }
        public string ReffOrgID { get; set; }
        public string ReffOrgName { get; set; }
        public string DoctorID { set; get; }
        public string DoctorName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }      
        public string EntryBy { get; set; }       
        public string EntryDate { set; get; }
        public double CashAmt { set; get; }
        public double DrAmount { set; get; }
        public double CrAmount { set; get; }
    }
}
