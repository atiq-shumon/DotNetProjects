using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace DSL.POS.Common.Utility
{
    /// <summary>
    /// Summary description for Constants
    /// </summary>
    public class Constants
    {

        public static string KEY_CONNECTION_STRING = "connection-string";
        public static string CONNECTION_OBJECT = "connection-object";
        public static string TRANSACTION_OBJECT = "transaction-object";
        public static string THREAD_STORAGE = "thread-storage";

        public static string SUCCESS_KEY = "success";
        public static string FAILURE_KEY = "failure";
        public static string DEFULT_USER = "ADMIN";

        public Constants()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
