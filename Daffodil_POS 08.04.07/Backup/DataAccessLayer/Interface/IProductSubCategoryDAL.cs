using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Collections;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
    /// <summary>
    /// Summary description for IProductSubCategoryDAL
    /// </summary>
    public interface IProductSubCategoryDAL : ICommonDAL
    {
        List<ProductSubCategoryInfoDTO> getProductSubCategoryData();
        List<ProductSubCategoryInfoDTO> getProductSubCategoryDataByPC(Guid guid);
        ProductSubCategoryInfoDTO FindByPK(Guid guid);
    }
}