using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using DSL.POS.DTO.Common.DTO;
using DSL.POS.DTO.DTO;


namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for BoothInfoDTO
    /// </summary>
    public class BoothInfoDTO : CommonDTO
    {
        
        private Guid br_PK;
        private int  strBoothNo;
        private Decimal strBoothCashLimit;
        private Boolean chrBoothStatus;
        private BranchInfoDTO _BranchCode;
        private string _machineID;
        //private BranchInfoDTO _BranchInfoDTO;

        //public BranchInfoDTO BranchInfoDTO
        //{
        //    get
        //    {
        //        return _BranchInfoDTO;
        //    }
        //    set
        //    {
        //        _BranchInfoDTO = value; 
        //    }
        //}
        public Guid BR_PK
        {
            set
            {
                br_PK = value;
            }
            get
            {
                return br_PK;
            }
        }

        public BranchInfoDTO BranchCode
        {
            get { return _BranchCode; }
            set { _BranchCode = value; }
        }

        public int BoothNo
        {
            set
            {
                strBoothNo = value;
            }
            get
            {
                return strBoothNo;
            }

        }

        public Decimal BoothCashLimit
        {
            set
            {
                strBoothCashLimit = value;
            }
            get
            {
                return strBoothCashLimit;
            }

        }
        public Boolean BoothStatus
        {
            set
            {
                chrBoothStatus = value;
            }
            get
            {
                return chrBoothStatus;
            }

        }
        public string MachineID
        {
            set
            {
                if (MachineID == null )
                {
                    _machineID = "";
                }
                else 
                    _machineID = value;
            }
            get
            {
                return _machineID;
            }
        }

        public BoothInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}