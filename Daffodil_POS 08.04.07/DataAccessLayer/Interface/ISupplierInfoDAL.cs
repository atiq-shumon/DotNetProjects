using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
    /// <summary>
    /// Summary description for ISupplierInfoDAL
    /// </summary>
    public interface ISupplierInfoDAL : ICommonDAL
    {
        List<SupplierInfoDTO> getSupplierInfoData();
        SupplierInfoDTO findByPKDTO(Guid pk);
        SupplierInfoDTO GetSupplierInfoBYCode(string strCode);
    }
}