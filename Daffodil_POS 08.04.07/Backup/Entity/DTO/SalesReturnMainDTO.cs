using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
    public class SalesReturnMainDTO :CommonDTO 
    {
        private string strReturnNo;
        private DateTime dtSalesReturnDate;
        private Guid guCust_PK;
        private string strReturnMode;
        private decimal strTotalReturnAmount;
        private decimal strReturnAmount;
        private string strInvoiceNo;
        private string dtInvoiceDate;
        private string strRemarks;
        private Guid guBo_PK;

        private List<SalesReturnSubDTO> _SalesReturnSubDTO;
        private MemberInfoDTO _memberInfoDTO;
        private SalesMainInfoDTO _SalesMainInfoDTO;

        public SalesMainInfoDTO SalesMainInfoDTO
        {
            get { return _SalesMainInfoDTO; }
            set { _SalesMainInfoDTO = value; }
        }

        public MemberInfoDTO MemberInfoDTO
        {
            get { return _memberInfoDTO; }
            set { _memberInfoDTO = value; }
        }

        public List<SalesReturnSubDTO> SalesReturnSubDTO
        {
            get { return _SalesReturnSubDTO; }
            set { _SalesReturnSubDTO = value; }
        }

        public string ReturnNo
        {
            set { strReturnNo = value; }
            get { return strReturnNo; }
        }

        public DateTime SalesReturnDate
        {
            set { dtSalesReturnDate = value; }
            get { return dtSalesReturnDate; }
        }

        public Guid Cust_PK
        {
            set { guCust_PK = value; }
            get { return guCust_PK; }
        }

        public string ReturnMode
        {
            set { strReturnMode = value; }
            get { return strReturnMode; }
        }

        public decimal TotalReturnAmount
        {
            set { strTotalReturnAmount = value; }
            get { return strTotalReturnAmount; }
        }

        public decimal ReturnAmount
        {
            set { strReturnAmount = value; }
            get { return strReturnAmount; }
        }

        public string InvoiceNo
        {
            set { strInvoiceNo = value; }
            get { return strInvoiceNo; }
        }

        public string InvoiceDate
        {
            set { dtInvoiceDate = value; }
            get { return dtInvoiceDate; }
        }

        public string Remarks
        {
            set { strRemarks = value; }
            get { return strRemarks; }
        }

        public Guid Bo_PK
        {
            set { guBo_PK = value; }
            get { return guBo_PK; }
        }
        
    }
}
