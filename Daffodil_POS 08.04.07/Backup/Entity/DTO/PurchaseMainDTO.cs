using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for PurchaseMainDTO
    /// </summary>
    public class PurchaseMainDTO : CommonDTO
    {
        private string strGRN_No;
        private DateTime  strGRNDate;
        private string strReferenceNo;
        private Guid strSp_PK;
        private decimal strTotalAmount;
        private decimal strDiscount;
        private List<PurchaseSubDTO> _purchaseSubInfoDTO;
        private SupplierInfoDTO _supplierInfoDTO;

        public string GRN_No
        {
            set
            { strGRN_No = value; }
            get
            { return strGRN_No; }
        }
        public DateTime  GRNDate
        {
            set { strGRNDate = value; }
            get { return strGRNDate; }
        }
        public string ReferenceNo
        {
            set { strReferenceNo = value; }
            get { return strReferenceNo; }
        }
        public Guid Sp_PK
        {
            set { strSp_PK = value; }
            get { return strSp_PK; }
        }
        public decimal TotalAmount
        {
            set { strTotalAmount = value; }
            get { return strTotalAmount; }
        }
        public decimal Discount
        {
            set { strDiscount = value; }
            get { return strDiscount; }
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

        public List<PurchaseSubDTO> PurchaseSubDTO
        {
            get
            {
                return _purchaseSubInfoDTO;
            }
            set
            {
                _purchaseSubInfoDTO = value;
            }
        }
    }
}
