using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
    /// <summary>
    /// Summary description for IProductCategory
    /// </summary>
    public interface IProductCategoryDAL : ICommonDAL
    {

        //List<ProductCategoryInfoDTO> getProductCategoryData();

        List<ProductCategoryInfoDTO> GetProductCategoryInfo();
        
        ProductCategoryInfoDTO FindByPK(Guid pk);
    }
}