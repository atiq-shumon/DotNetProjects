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
    public class TripDAL
    {
        private string connString = Utility.GetConnectionString();

        public string BookTripRequest(Trip trip)
        {
            //trip.TripRequestID=
            //     ,trip.Biker.LogIn.LogInID=""
            //         ,trip.EntryParameter.Session=""

            string packageName = "pkg_trip.book_customer_trip_request";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_result",OracleDbType.Decimal,30,null,ParameterDirection.Output),
                          new OracleParameter("p_trip_request_id",OracleDbType.Decimal,5,trip.TripRequestID,ParameterDirection.Input),
                          new OracleParameter("p_login_id",OracleDbType.Decimal,5,trip.Biker.LogIn.LogInID,ParameterDirection.Input),
                          new OracleParameter("p_session_id",OracleDbType.Varchar2,250,trip.EntryParameter.Session,ParameterDirection.Input),
                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            Int32 result = Convert.ToInt32((decimal)(OracleDecimal)prm.Value.ToString());
            return result.ToString();

        }

        public string SaveTripRequest(Trip trip)
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

            string packageName = "pkg_trip.save_customer_trip_request";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_req_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                          new OracleParameter("p_logInID",OracleDbType.Varchar2,150,trip.Customer.LogIn.LogInID,ParameterDirection.Input),
                          new OracleParameter("p_location",OracleDbType.Varchar2,150,trip.Location,ParameterDirection.Input),
                          new OracleParameter("p_destination",OracleDbType.Varchar2,150,trip.Destination,ParameterDirection.Input),
                          new OracleParameter("p_location_co_ord",OracleDbType.Varchar2,250,trip.LocationCoOrdinate,ParameterDirection.Input),
                          new OracleParameter("p_request_time",OracleDbType.Date,30,trip.RequestedTime,ParameterDirection.Input),
                          new OracleParameter("p_session_id",OracleDbType.Varchar2,150,trip.EntryParameter.Session,ParameterDirection.Input)
                        };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }


        #region GetTripRequest

        public List<Trip> GetTripRequest()
        {
            string packageName = "pkg_trip.get_customer_trip_request";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                       };

            return GetTripRequestLoc(packageName, parameterList);
        }

        public List<Trip> GetBookedRequest(string logInID)
        {
            string packageName = "pkg_trip.get_biker_selected_trip";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                          new OracleParameter("p_logInID",OracleDbType.Varchar2,150,logInID,ParameterDirection.Input)
                       };

            return GetTripRequestLoc(packageName, parameterList);
        }
        private List<Trip> GetTripRequestLoc(string packageName, OracleParameter[] parameterList)
        {
            List<Trip> oTrips = new List<Trip>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Trip oTrip = new Trip();

                oTrip.TripRequestID = Convert.ToInt32((decimal)(OracleDecimal)(rdr["trip_request_id"].ToString()));
                Customer oCust = new Customer();
                oCust.ID = rdr["customer_id"].ToString();
                oCust.CellPhone = (rdr["cell_phone"] == DBNull.Value ? string.Empty : rdr["cell_phone"].ToString());
                oCust.FirstName = (rdr["First_Name"] == DBNull.Value ? string.Empty : rdr["First_Name"].ToString());
                oCust.MiddleName = (rdr["Middle_name"] == DBNull.Value ? string.Empty : rdr["Middle_name"].ToString());
                oCust.LastName = (rdr["Last_Name"] == DBNull.Value ? string.Empty : rdr["Last_Name"].ToString());
                oTrip.Customer = oCust;
                Biker biker = new Biker();
                biker.ID = rdr["biker_id"].ToString();

                oTrip.Location = rdr["location"].ToString();
                oTrip.Destination = rdr["destination"].ToString();
                oTrip.LocationCoOrdinate = rdr["location_co_ord"].ToString();
                oTrip.RequestedTime = (DateTime)rdr["request_time"];
                oTrips.Add(oTrip);
            }
            rdr.Close();
            return oTrips;

        }
        #endregion
        #region Start Trip
        // api/trip/PostStartTrip
        //trip.TripRequestID=""
        //trip.Customer.ID=""
        //trip.LocationCoOrdinate=""
        //trip.Biker.LogIn.LogInID=""
        //trip.EntryParameter.Session=""

        public string StartTrip(Trip trip)
        {
            string packageName = "pkg_trip.customer_trip_start";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_trip_id",OracleDbType.Decimal,20,null,ParameterDirection.Output),
                          new OracleParameter("p_trip_request_id",OracleDbType.Decimal,5,trip.TripRequestID,ParameterDirection.Input),
                          new OracleParameter("p_customer_id",OracleDbType.Decimal,5,trip.Customer.ID,ParameterDirection.Input),
                          new OracleParameter("p_start_cord",OracleDbType.Varchar2,250,trip.LocationCoOrdinate,ParameterDirection.Input),
                          new OracleParameter("p_login_id",OracleDbType.Decimal,5,trip.Biker.LogIn.LogInID,ParameterDirection.Input),           
                          new OracleParameter("p_session_id",OracleDbType.Varchar2,250,trip.EntryParameter.Session,ParameterDirection.Input)
                     };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            Int32 result = Convert.ToInt32((decimal)(OracleDecimal)prm.Value.ToString());
            return result.ToString();

        }
        #endregion
        #region Biker's running trip
        public List<Trip> GetBikersRunningTrip(string logInID)
        {

           // trip.Biker.LogIn.LogInID
           // trip.Biker.LogIn.EntryParameter.Session
            string packageName = "pkg_trip.customer_trip_running";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                          new OracleParameter("p_logInID",OracleDbType.Varchar2,150,logInID,ParameterDirection.Input)
                         
                       };

            return GetBikersRunningTripLoc(packageName, parameterList);
        }
        private List<Trip> GetBikersRunningTripLoc(string packageName, OracleParameter[] parameterList)
        {
            List<Trip> oTrips = new List<Trip>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Trip oTrip = new Trip();

                oTrip.TripID = Convert.ToInt32((decimal)(OracleDecimal)(rdr["trip_id"].ToString()));
                Customer oCust = new Customer();
                oCust.ID = rdr["customer_id"].ToString();
                oCust.CellPhone = (rdr["cell_phone"] == DBNull.Value ? string.Empty : rdr["cell_phone"].ToString());
                oCust.FirstName = (rdr["First_Name"] == DBNull.Value ? string.Empty : rdr["First_Name"].ToString());
                oCust.MiddleName = (rdr["Middle_name"] == DBNull.Value ? string.Empty : rdr["Middle_name"].ToString());
                oCust.LastName = (rdr["Last_Name"] == DBNull.Value ? string.Empty : rdr["Last_Name"].ToString());
                oTrip.Customer = oCust;
                Biker biker = new Biker();
                biker.ID = rdr["biker_id"].ToString();

                oTrip.Location = rdr["location"].ToString();
                oTrip.Destination = rdr["destination"].ToString();
                oTrip.LocationCoOrdinate = rdr["location_co_ord"].ToString();
                oTrip.RequestedTime = (DateTime)rdr["request_time"];
                oTrip.StartTime = (DateTime)rdr["start_time"];
                oTrips.Add(oTrip);
            }
            rdr.Close();
            return oTrips;

        }
        #endregion






        #region End Trip
        public string EndTrip(Trip trip)
        {
            //api/trip/PostEndTrip
            //trip.TripID=""
            //trip.Bill.TotalDistance=""
            //trip.Bill.TotalBill=""
            //trip.LocationCoOrdinate=""
            //trip.Biker.LogIn.LogInID=""
            //trip.EntryParameter.Session="" 

            string packageName = "pkg_trip.customer_trip_end";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_is_end",OracleDbType.Decimal,4,null,ParameterDirection.Output),
                          new OracleParameter("p_trip_id",OracleDbType.Decimal,5,trip.TripID,ParameterDirection.Input),
                          new OracleParameter("p_total_distance",OracleDbType.Decimal,5,trip.Bill.TotalDistance,ParameterDirection.Input),
                          new OracleParameter("p_total_due",OracleDbType.Decimal,5,trip.Bill.TotalBill,ParameterDirection.Input),
                          new OracleParameter("p_start_cord",OracleDbType.Varchar2,250,trip.LocationCoOrdinate,ParameterDirection.Input),
                          new OracleParameter("p_login_id",OracleDbType.Decimal,5,trip.Biker.LogIn.LogInID,ParameterDirection.Input),
                          new OracleParameter("p_session_id",OracleDbType.Varchar2,250,trip.EntryParameter.Session,ParameterDirection.Input)
                      };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            Int32 result = Convert.ToInt32((decimal)(OracleDecimal)prm.Value.ToString());
            return result.ToString();

        }
        #endregion

    }
}
