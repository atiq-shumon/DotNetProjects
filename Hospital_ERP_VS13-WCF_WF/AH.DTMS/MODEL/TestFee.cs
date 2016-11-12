using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.PRMS.MODEL;

//using AH.IPD.MODEL;



namespace AH.DTMS.MODEL
{
    public class TestFee
    {
        public TestSub TestSub { set; get; }
        public SpecimenHolder SpecimenHolder { set; get; }
        public FeeCategory FeeCategory { set; get; }
        public AccountsPayment AccountsPayment { set; get; }
        public decimal Fee { set; get; }
        public decimal RefdFee { set; get; }
        public decimal DeptFee { set; get; }
        public decimal DoctorFee { set; get; }
        public decimal VAT { set; get; }
        public decimal Discount { set; get; }
        public string DiscountType { set; get; }
        public string DiscountReff { set; get; }
        public string DiscountAuthority { set; get; }
        public decimal Advance { set; get; }
        public decimal Due { set; get; }
        public string DueStatus { set; get; }
        public decimal NetPaid { set; get; }
        public string Mode { set; get; }
        public LabRoom LabRoom { set; get; }
        public DiagPackage DiagPackage { set; get; }
        public EntryParameter EParameter { set; get; }

    }
}
