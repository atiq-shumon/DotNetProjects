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
    /// Summary description for IProductInfoDAL
    /// </summary>
    public interface IProductInfoDAL : ICommonDAL
    {
        List<ProductInfoDTO> GetProductInfo();
        ProductInfoDTO FindByPK(Guid pk);
        Guid GetPKBYCode(string strCode);
    }
}