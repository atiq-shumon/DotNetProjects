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
    /// Summary description for IBoothInfoDAL
    /// </summary>
    public interface IBoothInfoDAL : ICommonDAL
    {
        List<BoothInfoDTO> getBoothInfoData();
        BoothInfoDTO findByPKDTO(Guid pk);
        BoothInfoDTO findByPK_AllDTO(Guid pk);
        BoothInfoDTO findBoothInfoByCodeDTO(short BoothCode);
    }
}