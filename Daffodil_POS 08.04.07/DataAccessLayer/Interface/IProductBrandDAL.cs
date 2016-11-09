using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using DSL.POS.DataAccessLayer.Common.Interface;
using DSL.POS.DTO.DTO;

namespace DSL.POS.DataAccessLayer.Interface
{
    /// <summary>
    /// Summary description for IProductBrandDAL
    /// </summary>
    public interface IProductBrandDAL : ICommonDAL
    {
        List<ProductBrandInfoDTO> GetProductBrand();

        ArrayList GetData();
        
        ProductBrandInfoDTO FindByPK(Guid guid);
    }
}