using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for SupplierInfoDTO
    /// </summary>
    /// 


    public class SupplierInfoDTO : CommonDTO
    {
        private string strSupplierCode;
        private string strSupplierName;
        private string strContractPerson;
        private string strShortName;
        private string strAddress;
        private string strPhone;
        private string strFax;
        private string strEmail;
        private string strWebAddress;



        public string SupplierCode
        {
            set
            {
                strSupplierCode = value;
            }
            get
            {
                return strSupplierCode;
            }

        }

        public string SupplierName
        {
            set
            {
                strSupplierName = value;
            }
            get
            {
                return strSupplierName;
            }
        }

        public string ContractPerson
        {
            set
            {
                strContractPerson = value;
            }
            get
            {
                return strContractPerson;
            }
        }
        public string ShortName
        {
            set
            {
                strShortName = value;
            }
            get
            {
                return strShortName;
            }
        }
        public string Address
        {
            set
            {
                strAddress = value;
            }
            get
            {
                return strAddress;
            }
        }

        public string Phone
        {
            set
            {
                strPhone = value;
            }
            get
            {
                return strPhone;
            }
        }
        public string Fax
        {
            set
            {
                strFax = value;
            }
            get
            {
                return strFax;
            }
        }
        public string Email
        {
            set
            {
                strEmail = value;
            }
            get
            {
                return strEmail;
            }
        }
        public string WebAddress
        {
            set
            {
                strWebAddress = value;
            }
            get
            {
                return strWebAddress;
            }
        }

        public SupplierInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}