using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
   public  class SalesMainInfoDTO:CommonDTO
    {
       private string strDeliveryNo;
       private DateTime strDeliveryDate;
       private Guid guCust_PK;
       private decimal strTotalAmount;
       private decimal strPaidAmount;
       private decimal strDueAmount;
       private decimal strTotalDiscount;
       private decimal strPaymentAmount;
       private string strPaymentMode;
       private Guid guBo_PK;
       private string strRemarks;

       private List<SalesSubInfoDTO> _salesSubInfoDTO;
       private MemberInfoDTO _memberInfoDTO;

       public MemberInfoDTO MemberInfoDTO
       {
           get { return _memberInfoDTO; }
           set { _memberInfoDTO = value; }
       }

       public List<SalesSubInfoDTO> SalesSubInfoDTO
       {
           get { return  _salesSubInfoDTO; }
           set { _salesSubInfoDTO = value; }
       }
        
       public string DeliveryNo
        {
            set{strDeliveryNo = value;}
            get{return strDeliveryNo;}
        }

       public DateTime DeliveryDate
        {
            set{strDeliveryDate = value;}
            get{return strDeliveryDate;}
        }
        
        public Guid Cust_PK
        {
            set{guCust_PK = value;}
            get{return guCust_PK;}
        }
        public decimal TotalAmount
        {            
            set{strTotalAmount = value;}
            get{return strTotalAmount;}
        }
       
        public decimal PaidAmount
        {
            set{strPaidAmount = value;}
            get{return strPaidAmount;}
        }
       
        public decimal DueAmount
        {
            set{strDueAmount = value;}
            get{return strDueAmount;}
        }

       public decimal TotalDiscount
        {
            set { strTotalDiscount = value; }
            get { return strTotalDiscount; }
        }
        public decimal PaymentAmount
        {
            set { strPaymentAmount = value; }
            get { return strPaymentAmount; }
        }

        public string PaymentMode
        {
            set { strPaymentMode = value; }
            get { return strPaymentMode; }
        }
        public Guid Bo_PK
        {
            set { guBo_PK=value; }
            get { return guBo_PK; }
        }
        public string Remarks
        {
            set { strRemarks = value; }
            get { return strRemarks; }
        }

               public SalesMainInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }
}
