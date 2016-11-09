using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
  public  class PurchaseReturnMainDTO : CommonDTO
    {
        private Guid strPU_PK;
        private Guid strSp_PK;
        private string strPurchaseReturnNo;
        private string strReferenceNo;
        private string strGRN_No;
        private DateTime strGRNDate;
        private string strRemarks;
        private decimal strTotalReturnAmount;
        private decimal strPurchaseDeduction;
        private decimal strPurchaseReturnAmount;
        
        private SupplierInfoDTO _supplierInfoDTO;
        private PurchaseMainDTO _PurchaseMainDTO;
        private List<PurchaseReturnSubDTO> _PurchaseReturnSubDTO;


        public  Guid PU_PK
        {
            set 
            {
                strPU_PK = value; 
            }
            get
            {
                return strPU_PK ; 
            }
        }
        public Guid Sp_PK
        {
            set { strSp_PK = value; }
            get { return strSp_PK; }
        }
        public string PurchaseReturnNo
        {
            set
            { strPurchaseReturnNo = value; }
            get
            { return strPurchaseReturnNo; }
        }
        
        public string GRN_No
        {
            set
            { strGRN_No = value; }
            get
            { return strGRN_No; }
        }
        public DateTime GRNDate
        {
            set { strGRNDate = value; }
            get { return strGRNDate; }
        }
        public string ReferenceNo
        {
            set { strReferenceNo = value; }
            get { return strReferenceNo; }
        }
        public string Remarks
        {
            set { strRemarks = value; }
            get { return strRemarks; }
        }
        public decimal TotalReturnAmount
        {
            set { strTotalReturnAmount = value; }
            get { return strTotalReturnAmount; }
        }

        public decimal PurchaseDeduction
        {
            set { strPurchaseDeduction  = value; }
            get { return strPurchaseDeduction; }
        }
      public decimal PurchaseReturnAmount
      {
          set { strPurchaseReturnAmount = value; }
          get { return strPurchaseReturnAmount; }
      }    

        public SupplierInfoDTO SupplierInfoDTO
        {
            get
            {
                return _supplierInfoDTO;
            }
            set
            {
                _supplierInfoDTO = value;
            }

        }

      public PurchaseMainDTO PurchaseMainDTO
      {
          get 
          {
              return _PurchaseMainDTO; 
          }
          set 
          {
              _PurchaseMainDTO = value; 
          }
      }
      public List<PurchaseReturnSubDTO> PurchaseReturnSubDTO
      {
          get
          {
              return _PurchaseReturnSubDTO ;
          }
          set
          {
              _PurchaseReturnSubDTO = value;
          }
      }


    }
}
