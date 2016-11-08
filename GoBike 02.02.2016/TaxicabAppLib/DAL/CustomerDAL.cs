using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using TaxiCabAppLib.Models;


namespace TaxiCabAppLib.DAL
{
    public class CustomerDAL
    {
        private string connString = Utility.GetConnectionString();
        public string SaveCustomer(Customer customer)
        {
            //Customer customer = new Customer();
            //Address addr = new Address();
            //addr.Address1 = "Test Address 1";
            //addr.Address2 = "Test Addr2";
            //addr.City = "Dhaka";
            //addr.District = "Dhaka";
            //addr.Division = "Dhaka";
            //addr.Thana = "Dhaka";
            //addr.Road = "Test Road";
            //addr.AddressType = new AddressType() { TypeID = 1, TypeName = "Permanent" };

            //customer.FirstName = "A.N.M.";
            //customer.MiddleName = "Atiqur ";
            //customer.LastName = "Rahman";
            //customer.CellPhone = "01724001585";
            //customer.Email = "codebd007@gmail.com";
            //customer.NID = "432423432";
            //customer.LogIn = new LogIn() { LogInID = 1, LogInType = "1", Password = "123", UserName = "atiqur" };
            //customer.Address = addr;
           string packageName = "pkg_Customer.save_customer";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_f_name",OracleDbType.Varchar2,150,customer.FirstName,ParameterDirection.Input),
                          new OracleParameter("p_m_name",OracleDbType.Varchar2,150,customer.MiddleName,ParameterDirection.Input),
                          new OracleParameter("p_l_name",OracleDbType.Varchar2,150,customer.LastName,ParameterDirection.Input),
                          new OracleParameter("p_email",OracleDbType.Varchar2,250,customer.Email,ParameterDirection.Input),
                          new OracleParameter("p_cellphone",OracleDbType.Varchar2,30,customer.CellPhone,ParameterDirection.Input),
                          new OracleParameter("address1",OracleDbType.Varchar2,150,customer.Address.Address1,ParameterDirection.Input),
                          new OracleParameter("address2",OracleDbType.Varchar2,150,customer.Address.Address2,ParameterDirection.Input),
                          new OracleParameter("road",OracleDbType.Varchar2,150,customer.Address.Road,ParameterDirection.Input),
                          new OracleParameter("city",OracleDbType.Varchar2,150,customer.Address.City,ParameterDirection.Input),
                          new OracleParameter("distict",OracleDbType.Varchar2,30,customer.Address.District,ParameterDirection.Input),
                          new OracleParameter("division",OracleDbType.Varchar2,150,customer.Address.Division,ParameterDirection.Input),
                          new OracleParameter("thana",OracleDbType.Varchar2,30,customer.Address.Thana,ParameterDirection.Input),
                          new OracleParameter("addrtype",OracleDbType.Varchar2,30,customer.Address.AddressType.TypeID,ParameterDirection.Input),
                          new OracleParameter("loginType",OracleDbType.Varchar2,150,customer.LogIn.LogInType,ParameterDirection.Input),
                          new OracleParameter("userName",OracleDbType.Varchar2,30,customer.LogIn.UserName,ParameterDirection.Input),
                          new OracleParameter("password",OracleDbType.Varchar2,30,customer.LogIn.Password,ParameterDirection.Input)

                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;
            
        }


        #region GetCustomer
        public List<Customer> GetCustomer()
        {
            string packageName = "pkg_Customer.get_customer";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             };
            return GetCustomerLoc(packageName, parameterList);
        }
        private List<Customer> GetCustomerLoc(string packageName, OracleParameter[] parameterList)
        {
            List<Customer> oCusts = new List<Customer>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Customer oCust = new Customer();

                oCust.ID = rdr["customer_id"].ToString();
                oCust.FirstName = rdr["First_name"].ToString();
                oCust.MiddleName = rdr["middle_name"].ToString();
                oCust.LastName = rdr["last_name"].ToString();
                oCust.CellPhone = rdr["cell_phone"].ToString();
                oCust.Email = rdr["email"].ToString();
                oCusts.Add(oCust);
            }
            rdr.Close();
            return oCusts;

        }
        #endregion

        #region GetCustomer by ID
        public List<Customer> GetCustomer(string id)
        {
            string packageName = "pkg_Customer.get_customer";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("id", OracleDbType.Varchar2,id,ParameterDirection.Input),
             };
            return GetCustomerLoc(packageName, parameterList);
        }
        #endregion

        #region login Customer
        public Session LoginCustomer(string id,string password)
        {
            string packageName = "pkg_Customer.login_customer";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("session", OracleDbType.Varchar2,50,null,ParameterDirection.Output),
                  new OracleParameter("user_name", OracleDbType.Varchar2,350,null,ParameterDirection.Output),
                  new OracleParameter("login_id", OracleDbType.Int32,350,null,ParameterDirection.Output),
                   new OracleParameter("email", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                     new OracleParameter("fname", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                      new OracleParameter("mname", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                      new OracleParameter("lname", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                       new OracleParameter("hasCC", OracleDbType.Varchar2,2,null,ParameterDirection.Output),
                   new OracleParameter("phone", OracleDbType.Varchar2,50,id,ParameterDirection.Input),
                 new OracleParameter("password", OracleDbType.Varchar2,30,password,ParameterDirection.Input),
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            OracleParameter prm1 = parameterList[1];
            string result1 = (string)(OracleString)prm1.Value;

            OracleParameter prm2 = parameterList[2];
            Int32 result2= (Int32)(OracleDecimal)prm2.Value;

            OracleParameter prm3 = parameterList[3];
            string result3 = (string)(OracleString)prm3.Value;

            OracleParameter prm4 = parameterList[4];
            string result4 = (string)(OracleString)prm4.Value;

            OracleParameter prm5 = parameterList[5];
            string result5 = (string)(OracleString)prm5.Value;

            OracleParameter prm6 = parameterList[6];
            string result6 = (string)(OracleString)prm6.Value;

            OracleParameter prm7 = parameterList[7];
            string result7 = (string)(OracleString)prm7.Value;
           


            Session session = new Session();
            session.SessionID = result;
            session.UserName = result1;
            session.LogInID = result2;
            session.Email = result3;
            session.FirstName = result4;
            session.MiddleName = result5;
            session.LastName = result6;
            session.HasCreditCardInfo =result7[0];
            return session;
        }
       #endregion

        #region logout Customer
        public string LogoutCustomer( string sessionid,string id)
        {
            string packageName = "pkg_Customer.logout_customer";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("session", OracleDbType.RefCursor,sessionid,ParameterDirection.Input),
                 new OracleParameter("id", OracleDbType.RefCursor,id,ParameterDirection.Input)
                 
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //string result = (string)(OracleString)prm.Value;

            return i.ToString();
        }
        #endregion

        #region Save Customer CC
        public short SaveCustomerCC(CC cc)
        {
            //CC cc = new CC();
            //cc.Customer.LogIn.LogInID = 1;
            //cc.CCName = "Card Holder Name";
            //cc.Expire = "0223";
            //cc.CCCode = "717";
            //cc.CCType.TypeID = "1";
            //cc.EntryParameter.Session = "session ID";

            string packageName = "pkg_Customer.save_customer_cc";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ccId", OracleDbType.Varchar2,50,null,ParameterDirection.Output),
                  new OracleParameter("p_login_id", OracleDbType.Int32,cc.Customer.LogIn.LogInID,ParameterDirection.Input),
                 new OracleParameter("p_cc_name", OracleDbType.Varchar2,300,cc.CCName,ParameterDirection.Input),
                 new OracleParameter("p_expire", OracleDbType.Varchar2,30,cc.Expire,ParameterDirection.Input),
                 new OracleParameter("p_cc_code", OracleDbType.Varchar2,30,cc.CCCode,ParameterDirection.Input),
                 new OracleParameter("p_cc_type_id", OracleDbType.Varchar2,30,cc.CCType.TypeID,ParameterDirection.Input),
                 new OracleParameter("p_session_id", OracleDbType.Varchar2,30,cc.EntryParameter.Session,ParameterDirection.Input)
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;
            if (result == "0")
            {
                return 0;
            }
            else { return 1; }
        }
        #endregion

        #region GetCustomerCC
        public List<CC> GetCustomerCC(string logInID)
        {
           // get_customer_cc(p_test_cursor out TEST_PACKAGE.TEST_TYPE,p_login_id in number)
            string packageName = "pkg_Customer.get_customer_cc";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                  new OracleParameter("p_login_id", OracleDbType.Int32,logInID,ParameterDirection.Input)
             };
            return GetCustomerCCLoc(packageName, parameterList);
        }
        private List<CC> GetCustomerCCLoc(string packageName, OracleParameter[] parameterList)
        {
            List<CC> oCCs = new List<CC>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                CC oCC = new CC();

                oCC.CCName = rdr["cc_name"].ToString();
                oCC.Expire = rdr["expire"].ToString();
                oCC.CCCode = rdr["cc_code"].ToString();
                //CCType oCCType = new CCType();
                //oCCType.TypeID = (Int32)rdr["cc_type_id"];
                //oCC.CCType = oCCType;
                oCCs.Add(oCC);
            }
            rdr.Close();
            return oCCs;

        }
        #endregion

    }
}
