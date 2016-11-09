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
    /// Summary description for IBranchInfoDAL
    /// </summary>
    public interface IBranchInfoDAL : ICommonDAL
    {
        List<BranchInfoDTO> GetBranchInfo();
        BranchInfoDTO findByPK(Guid pk);
    }
}
