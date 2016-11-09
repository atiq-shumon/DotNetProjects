using System;
using System.Data;
using System.Web;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Common.Interface;

namespace DSL.POS.DataAccessLayer.Interface
{
    public interface  ISalesInfoDAL:ICommonDAL 
    {
        void Update(SalesMainInfoDTO oSalesMainInfoDTO);
        //SalesMainInfoDTO GetSalesInfoBYInvoiceNo(string strInvoiceNo);
    }
}
