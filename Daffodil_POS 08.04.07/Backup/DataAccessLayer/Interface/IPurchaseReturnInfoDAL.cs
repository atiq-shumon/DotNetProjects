using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
    public interface IPurchaseReturnInfoDAL : ICommonDAL
    {
        void Update(PurchaseReturnMainDTO oPurchaseReturnMainDTO);

        PurchaseReturnMainDTO GetPurchaseInfoBYGRNNo(string strGRNNo);

    }
}
