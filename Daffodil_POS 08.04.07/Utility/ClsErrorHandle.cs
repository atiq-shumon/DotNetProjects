using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DSL.POS.Common.Utility
{
    public class ClsErrorHandle
    {
        public ClsErrorHandle()
        {
            //throw new System.NotImplementedException();            
        }
        public string ErrorString(Exception Exp)
        {

            if (Exp.GetType().Name == "IndexOutOfRangeException")
            {
                return "Parameter index is out of range.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "DivideByZeroException")
            {
                return "Division by zero attempted.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "NullReferenceException")
            {
                return "Object reference not set to an instance of an object.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "SqlException")
            {
                return "Wrong Sql Query.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "FormatException")
            {
                return "Input string is not in a correct format.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "InvalidOperationException")
            {
                return "Timeout expired.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "FileNotFoundException")
            {
                return "File not found.";// + Exp.InnerException.Source;
            }
            else if (Exp.GetType().Name == "IOException")
            {
                return "File is used by another user.";// + Exp.InnerException.Source;
            }
            else
            {
                return Exp.ToString();
                //return Exp.Message.ToString();
            }
           
            //FormatException 

            //if(IndexOutOfRangeException.Equals(Exp.ToString()))
            ////return "Error";
            ////return Exp.ToString();

            //return "test";
        }
        public void ErrorMethod()
        {
            try
            {
                //
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
