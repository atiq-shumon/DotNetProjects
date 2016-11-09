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
    /// Summary description for IProductUnitDAL
    /// </summary>
    public interface IProductUnitDAL : ICommonDAL
    {
        List<ProductUnitInfoDTO> GetProductUnitInfo();

        ArrayList GetData();

        ProductUnitInfoDTO FindByPK(Guid guid);
    }
}