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
    public class BikerDAL
    {
        private string connString = Utility.GetConnectionString();
        public string SaveBiker(Biker biker)
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
            string packageName = "pkg_Biker.save_biker";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("p_f_name",OracleDbType.Varchar2,150,biker.FirstName,ParameterDirection.Input),
                          new OracleParameter("p_m_name",OracleDbType.Varchar2,150,biker.MiddleName,ParameterDirection.Input),
                          new OracleParameter("p_l_name",OracleDbType.Varchar2,150,biker.LastName,ParameterDirection.Input),
                          new OracleParameter("p_email",OracleDbType.Varchar2,250,biker.Email,ParameterDirection.Input),
                          new OracleParameter("p_cellphone",OracleDbType.Varchar2,30,biker.CellPhone,ParameterDirection.Input),
                          new OracleParameter("p_licence_no",OracleDbType.Varchar2,30,biker.LicenseNo,ParameterDirection.Input),
                          new OracleParameter("p_vehicle_type",OracleDbType.Varchar2,30,biker.VehicleType,ParameterDirection.Input),
                          new OracleParameter("address1",OracleDbType.Varchar2,150,biker.Address.Address1,ParameterDirection.Input),
                          new OracleParameter("address2",OracleDbType.Varchar2,150,biker.Address.Address2,ParameterDirection.Input),
                          new OracleParameter("road",OracleDbType.Varchar2,150,biker.Address.Road,ParameterDirection.Input),
                          new OracleParameter("city",OracleDbType.Varchar2,150,biker.Address.City,ParameterDirection.Input),
                          new OracleParameter("distict",OracleDbType.Varchar2,30,biker.Address.District,ParameterDirection.Input),
                          new OracleParameter("division",OracleDbType.Varchar2,150,biker.Address.Division,ParameterDirection.Input),
                          new OracleParameter("thana",OracleDbType.Varchar2,30,biker.Address.Thana,ParameterDirection.Input),
                          new OracleParameter("addrtype",OracleDbType.Varchar2,30,biker.Address.AddressType.TypeID,ParameterDirection.Input),
                          new OracleParameter("loginType",OracleDbType.Varchar2,150,biker.LogIn.LogInType,ParameterDirection.Input),
                          new OracleParameter("userName",OracleDbType.Varchar2,30,biker.LogIn.UserName,ParameterDirection.Input),
                          new OracleParameter("password",OracleDbType.Varchar2,30,biker.LogIn.Password,ParameterDirection.Input)

                         };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }


        #region GetDriver
        public List<Biker> GetBiker()
        {
            string packageName = "pkg_Biker.get_biker";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             };
            return GetBikerLoc(packageName, parameterList);
        }
        private List<Biker> GetBikerLoc(string packageName, OracleParameter[] parameterList)
        {
            List<Biker> oBikers = new List<Biker>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Biker oBiker = new Biker();

                oBiker.ID = rdr["biker_id"].ToString();
                oBiker.FirstName = rdr["first_name"].ToString();
                oBiker.MiddleName = rdr["middle_name"].ToString();
                oBiker.LastName = rdr["last_name"].ToString();
                oBiker.Email = rdr["email"].ToString();
                oBiker.CellPhone = rdr["cell_phone"].ToString();
                oBiker.LicenseNo=rdr["licence_no"].ToString();
                oBiker.VehicleType=rdr["vehicle_type"].ToString();

                oBikers.Add(oBiker);
            }
            rdr.Close();
            return oBikers;

        }
        #endregion

        #region GetBiker by ID
        public List<Biker> GetBiker(string id)
        {
            string packageName = "pkg_Biker.get_biker";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("id", OracleDbType.Varchar2,20,id,ParameterDirection.Input),
             };
            return GetBikerLoc(packageName, parameterList);
        }
        #endregion

        #region login Biker
        public Session LoginBiker(string id, string password)
        {
            string packageName = "pkg_Biker.login_biker";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("session", OracleDbType.Varchar2,50,null,ParameterDirection.Output),
                  new OracleParameter("user_name", OracleDbType.Varchar2,350,null,ParameterDirection.Output),
                  new OracleParameter("login_id", OracleDbType.Int32,350,null,ParameterDirection.Output),
                   new OracleParameter("email", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                     new OracleParameter("fname", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                      new OracleParameter("mname", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                      new OracleParameter("lname", OracleDbType.Varchar2,500,null,ParameterDirection.Output),
                     //  new OracleParameter("hasCC", OracleDbType.Varchar2,2,null,ParameterDirection.Output),
                   new OracleParameter("phone", OracleDbType.Varchar2,50,id,ParameterDirection.Input),
                 new OracleParameter("password", OracleDbType.Varchar2,30,password,ParameterDirection.Input),
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            OracleParameter prm1 = parameterList[1];
            string result1 = (string)(OracleString)prm1.Value;

            OracleParameter prm2 = parameterList[2];
            Int32 result2 = (Int32)(OracleDecimal)prm2.Value;

            OracleParameter prm3 = parameterList[3];
            string result3 = (string)(OracleString)prm3.Value;

            OracleParameter prm4 = parameterList[4];
            string result4 = (string)(OracleString)prm4.Value;

            OracleParameter prm5 = parameterList[5];
            string result5 = (string)(OracleString)prm5.Value;

            OracleParameter prm6 = parameterList[6];
            string result6 = (string)(OracleString)prm6.Value;
            

            //string result8 = (string)(OracleString)prm.Value;
            //OracleParameter prm8 = parameterList[7];


            Session session = new Session();
            session.SessionID = result;
            session.UserName = result1;
            session.LogInID = result2;
            session.Email = result3;
            session.FirstName = result4;
            session.MiddleName = result5;
            session.LastName = result6;
            //session.HasCreditCardInfo = result8[0];
            return session;
        }
        #endregion

       // #region logout Driver
       // public string LogoutDriver( string sessionid,string id)
       // {
       //     string packageName = "pkg_Driver.logout_driver";
       //     OracleParameter[] parameterList = new OracleParameter[] {
       //          new OracleParameter("session", OracleDbType.RefCursor,sessionid,ParameterDirection.Input),
       //          new OracleParameter("id", OracleDbType.RefCursor,id,ParameterDirection.Input)
                 
       //      };
       //     short i = DALHelper.Insert(connString, packageName, parameterList);
       //     //OracleParameter prm = parameterList[0];
       //     //string result = (string)(OracleString)prm.Value;

       //     return i.ToString();
       // }
       // #endregion
    }
}
