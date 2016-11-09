using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
    public interface ISalesReturnInfoDAL : ICommonDAL 
    {
        void Update(SalesReturnMainDTO oSalesReturnMainDTO);
        //SalesMainInfoDTO GetSalesInfoBYInvoiceNo(string strInvoiceNo);
        SalesReturnMainDTO GetSalesInfoBYInvoiceNo(string strInvoiceNo);
    }
}
