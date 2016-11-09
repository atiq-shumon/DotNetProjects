using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for ProductCategoryInfo
    /// </summary>
    public class ProductCategoryInfoDTO : CommonDTO
    {
        private string pkCode;
        private string categoryDescription;

        public string PC_Code
        {
            set
            {
                pkCode = value;
            }
            get
            {
                return pkCode;
            }

        }

        public string PC_Description
        {
            set
            {
                categoryDescription = value;
            }
            get
            {
                return categoryDescription;
            }

        }

        public ProductCategoryInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}