using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace DSL.POS.DataAccessLayer.Common.Interface
{
    /// <summary>
    /// Summary description for ICommonDAL
    /// </summary>
    public interface ICommonDAL
    {
        void Save(object Obj);

        //Guid Find_PK(object obj);
        void Delete(object Obj);

    }
}