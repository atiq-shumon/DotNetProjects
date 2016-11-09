using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
using System.Collections.Generic;

namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for BranchInfoDTO
    /// </summary>
    /// 

    public class BranchInfoDTO : CommonDTO
    {
        private string _BranchCode;
        private Guid _BT_PK;
        private string _BranchName;
        private string _ContactPerson;
        private string _ContactPersonPhone;
        private string _BranchPrefix;
        private string _BranchAddress;
        private string _Telephone1;
        private string _Telephone2;
        private string _Telephone3;
        private string _Fax;
        private string _EMail;
        private Decimal _CashInSafeLimit;
        private BranchTypeInfoDTO _BranchTypeInfoDTO;

        public BranchTypeInfoDTO BranchTypeInfoDTO
        {
            get
            {
                return _BranchTypeInfoDTO ;
            }
            set
            {
                _BranchTypeInfoDTO = value;
            }
        }

        public Guid BT_PK
        {
            set
            {
                _BT_PK = value;
            }
            get
            {
                return _BT_PK;
            }
        }

        public string BranchCode
        {
            set
            {
                _BranchCode = value;
            }
            get
            {
                return _BranchCode;
            }
        }


        public string BranchName
        {
            set
            {
                _BranchName = value;
            }
            get
            {
                return _BranchName;
            }
        }

        public string ContactPerson
        {
            set
            {
                _ContactPerson = value;
            }
            get
            {
                return _ContactPerson;
            }
        }
        public string ContactPersonPhone
        {
            set
            {
                _ContactPersonPhone = value;
            }
            get
            {
                return _ContactPersonPhone;
            }
        }
        public string BranchPrefix
        {
            set
            {
                _BranchPrefix = value;
            }
            get
            {
                return _BranchPrefix;
            }
        }
        public string BranchAddress
        {
            set
            {
                _BranchAddress = value;
            }
            get
            {
                return _BranchAddress;
            }
        }
        public string Telephone1
        {
            set
            {
                _Telephone1 = value;
            }
            get
            {
                return _Telephone1;
            }
        }
        public string Telephone2
        {
            set
            {
                _Telephone2 = value;
            }
            get
            {
                return _Telephone2;
            }
        }
        public string Telephone3
        {
            set
            {
                _Telephone3 = value;
            }
            get
            {
                return _Telephone3;
            }
        }
        public string Fax
        {
            set
            {
                _Fax = value;
            }
            get
            {
                return _Fax;
            }
        }
        public string EMail
        {
            set
            {
                _EMail = value;
            }
            get
            {
                return _EMail;
            }
        }
        public Decimal CashInSafeLimit
        {
            set
            {
                _CashInSafeLimit = value;
            }
            get
            {
                return _CashInSafeLimit;
            }
        }
   
        public BranchInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}