using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.DMS.MODEL
{
    public class MoneyReceiptRO
    {
        
            #region Properties
            public string Age { get; set; }
            public string PatientName { get; set; }
            public string MasterGroup { set; get; }
            public double FullPaid { set; get; }
            public string MoneyReceipNo { get; set; }
            public double MRNumber { get; set; }
            public string RefundMoneyReceipNo { get; set; }
            public string TransactionNo { get; set; }
            public string TicketNo { get; set; }
            public string TicketType { get; set; }
            public string PackageID { get; set; }
            public string PackageTitle { get; set; }
            public double PackageAmount { get; set; }
            public string HCN { get; set; }
            public string DepertmentName { get; set; }           
            public double Vat { get; set; }
            public double Discount { get; set; }
            public double TotalDiscount { get; set; }
            public double IndividualDiscount { get; set; }
            public double Advance { get; set; }
            public double Due { get; set; }
            public double PrevDueColl { get; set; }
            public string DueStatus { set; get; }
            public double NetPaid { get; set; }
            public string PaymentType { get; set; }
            public string Remarks { get; set; }
            public string LAB_ROOM_NO { get; set; }
            public double Fee { get; set; }
            public double DeptFee { get; set; }
            public double DepositAmount { get; set; }
            public double Amount { get; set; }            
            public double Qty { get; set; }           
            public double NoOfTest { get; set; }
            public string TDetID { get; set; }
            public string TestName { get; set; }
            public string TestGroupID { get; set; }
            public string TestGroupName { get; set; }
            public string TestMainID { get; set; }
            public string TestCancelStatus { get; set; }
            public string TestMainName { get; set; }
            public string ReffOrgID { get; set; }
            public string ReffOrgName { get; set; }
            public string DoctorID { set; get; }
            public string DoctorName { get; set; }
            public string DoctorTitle { get; set; }
            public string Sex { get; set; }
            public string Address { get; set; }
            public string MobileNo { get; set; }
            public string HomePhone { get; set; }
            public string EntryBy { get; set; }
            public string newTransNo { set; get; }
            public double PaidAmt { get; set; }
            public double NetAmt { get; set; }
            public string EntryByName { set; get; }
            public string BedID { set; get; }
            public string BedTitle { set; get; }
            public string EntryDate { set; get; }
            public double CashAmt { set; get; }
            public double DrAmount { set; get; }
            public double CrAmount { set; get; }
            public double RefundAmt { set; get; }

            #endregion
        
    }
}
