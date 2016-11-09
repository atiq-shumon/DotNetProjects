using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
    public class SalesReturnSubDTO :CommonDTO 
    {

        private Guid guSALRM_PK;
        private Guid guP_PK;
        private decimal strSalesRate;
        private decimal strSalesQuantity;
        private decimal strVatAmount;
        private decimal strTaxAmount;
        private decimal strDiscount;
        private decimal strTotalAmount;

        public Guid SALRM_PK
        {
            get { return guSALRM_PK; }
            set { guSALRM_PK = value; }
        }
        public Guid P_PK
        {
            set { guP_PK = value; }
            get { return guP_PK; }
        }
        public decimal SalesRate
        {
            set { strSalesRate = value; }
            get { return strSalesRate; }
        }
        public decimal SalesQuantity
        {
            set { strSalesQuantity = value; }
            get { return strSalesQuantity; }
        }
        public decimal VatAmount
        {
            set { strVatAmount = value; }
            get { return strVatAmount; }
        }
        public decimal TaxAmount
        {
            set { strTaxAmount = value; }
            get { return strTaxAmount; }
        }
        public decimal Discount
        {
            set { strDiscount = value; }
            get { return strDiscount; }

        }

        public decimal TotalAmount
        {
            get
            {
                return strTotalAmount;
            }
            set
            {
                strTotalAmount = value;
            }
        }
    }
}
