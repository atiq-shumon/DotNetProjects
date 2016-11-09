using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
using System.Collections.Generic;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for BranchTypeInfoDTO
    /// </summary>
    public class BranchTypeInfoDTO : CommonDTO
    {
        private string _BT_Code;
        private string _BT_Name;

        public string BT_Code
        {
            set
            {
                _BT_Code = value;
            }
            get
            {
                return _BT_Code;
            }
        }
        public string BT_Name
        {
            set
            {
                _BT_Name = value;
            }
            get
            {
                return _BT_Name;
            }
        }
    
        public BranchTypeInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}