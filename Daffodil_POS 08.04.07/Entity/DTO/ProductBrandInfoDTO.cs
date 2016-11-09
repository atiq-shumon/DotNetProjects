using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for ProductBrandInfoDt
    /// </summary>
    public class ProductBrandInfoDTO : CommonDTO
    {
        private string _PB_Code;
        private string _PB_Name;

        public string PB_Code
        {
            set { _PB_Code = value; }
            get { return _PB_Code; }
        }

        public string PB_Name
        {
            set { _PB_Name = value; }
            get { return _PB_Name; }
        }
        public ProductBrandInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}