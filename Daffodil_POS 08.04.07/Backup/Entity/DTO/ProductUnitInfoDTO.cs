using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for ProductUnitInfoDTO
    /// </summary>
    public class ProductUnitInfoDTO : CommonDTO
    {
        private string _PU_Code;
        private string _PU_Name;

        public string PU_Code
        {
            set
            {
                _PU_Code = value;
            }
            get
            {
                return _PU_Code;
            }
        }

        public string PU_Name
        {
            set
            {
                _PU_Name = value;
            }
            get
            {
                return _PU_Name;
            }
        }
        public ProductUnitInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}