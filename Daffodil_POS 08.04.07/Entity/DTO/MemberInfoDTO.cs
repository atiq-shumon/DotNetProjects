using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
    public class MemberInfoDTO: CommonDTO 
    {
        private string strCustId;
        private string strManualId;
        private string strCustName;
        private string strCustAtten;
        private string strContactPerson;
        private string strCustAddr;
        private string strCustPhone;
        private string strCustFax;
        private string strCustEmail;
        private string strWebSite;
        private DateTime strBirthDay;
        //private DateTime strBirthDay;
        private string strMobile;
        private decimal  strCreditLimit;

        public string CustId
        {
            set
            {
                strCustId = value;
            }
            get
            {
                return strCustId;
            }

        }

        public string ManualId
        {
            set
            {
                strManualId = value;
            }
            get
            {
                return strManualId;
            }

        }
        public string CustName
        {
            set
            {
                strCustName = value;
            }
            get
            {
                return strCustName;
            }

        }
        public string CustAtten
        {
            set
            {
                strCustAtten = value;
            }
            get
            {
                return strCustAtten;
            }

        }
        public string ContactPerson
        {
            set
            {
                strContactPerson = value;
            }
            get
            {
                return strContactPerson;
            }

        }
        public string CustAddr
        {
            set
            {
                strCustAddr = value;
            }
            get
            {
                return strCustAddr;
            }

        }
        public string CustPhone
        {
            set
            {
                strCustPhone = value;
            }
            get
            {
                return strCustPhone;
            }

        }
        public string CustFax
        {
            set
            {
                strCustFax = value;
            }
            get
            {
                return strCustFax;
            }

        }
        public string CustEmail
        {
            set
            {
                strCustEmail = value;
            }
            get
            {
                return strCustEmail;
            }
        }
        public string WebSite
        {
            set
            {
                strWebSite = value;
            }
            get
            {
                return strWebSite;
            }
        }

        public DateTime BirthDay
        {
            set
            {
                strBirthDay = value;
            }
            get
            {
                return strBirthDay;
            }

        }
        public string Mobile
        {
            set
            {
                strMobile = value;
            }
            get
            {
                return strMobile;
            }

        }
        public decimal CreditLimit
        {
            set
            {
                strCreditLimit = value;
            }
            get
            {
                return strCreditLimit;
            }

        }

    }
}
