using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for ProductSubCategoryInfoDTO
    /// </summary>
    public class ProductSubCategoryInfoDTO : CommonDTO
    {
        private string pkSubCode;
        private string categorySubDescription;
        private Guid pc_PK;
        
        public Guid PC_PK
        {
            set
            {
                pc_PK = value;
            }
            get
            {
                return pc_PK;
            }
        }


        public string PSC_Code
        {
            set
            {
                pkSubCode = value;
            }
            get
            {
                return pkSubCode;
            }

        }
        
        public string PSC_Description
        {
            set
            {
                categorySubDescription = value;
            }
            get
            {
                return categorySubDescription;
            }

        }
        
        public ProductSubCategoryInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}