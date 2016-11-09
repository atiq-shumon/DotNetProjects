using System;
using System.Collections.Generic;
using System.Text;
using System.Data; 
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
 public interface IOpeningBalanceDAL : ICommonDAL 
    {
     
     List<OpeningBalanceDTO> getOpeningBalanceInfo();
     DataSet getDataSetOpeningBalanceInfo();
    }
}
