using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.OracleManager;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


using TaxiCabAppLib.Models;

namespace TaxiCabAppLib.DAL
{
    public class RideDAL
    {
        private string connString = Utility.GetConnectionString();
        #region RequestRide
        public string RequestRide(Ride ride)
        {
            string packageName = "pkg_ride.customer_ride_request";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("p_ride_req_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                      //  new OracleParameter("p_drft_rs_id",OracleDbType.Varchar2,30,dr.DraftResultID,ParameterDirection.Input),
                          new OracleParameter("session",OracleDbType.Varchar2,30,ride.Session,ParameterDirection.Input),
                          new OracleParameter("cust",OracleDbType.Varchar2,30,ride.Customer.ID,ParameterDirection.Input),
                          new OracleParameter("source",OracleDbType.Varchar2,30,ride.RideSource,ParameterDirection.Input),
                          new OracleParameter("dest",OracleDbType.Varchar2,30,ride.RideDestination,ParameterDirection.Input),
                          new OracleParameter("req_time",OracleDbType.Varchar2,30,ride.RequestedRideTime,ParameterDirection.Input),
                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        #endregion

        #region StartRide
        public string StartRide(Ride ride)
        {
            string packageName = "pkg_ride.customer_ride_start";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("session",OracleDbType.Varchar2,30,ride.Session,ParameterDirection.Input),
                          new OracleParameter("cust",OracleDbType.Varchar2,30,ride.Customer.ID,ParameterDirection.Input),
                          new OracleParameter("source",OracleDbType.Varchar2,30,ride.RideSource,ParameterDirection.Input),
                          new OracleParameter("dest",OracleDbType.Varchar2,30,ride.RideDestination,ParameterDirection.Input),
                          new OracleParameter("driver",OracleDbType.Varchar2,30,ride.Driver.ID,ParameterDirection.Input),
                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //string result = (string)(OracleString)prm.Value;
            string result = i.ToString();
            return result;

        }
        #endregion


        #region EndRide
        public string EndRide(Ride ride)
        {
            string packageName = "pkg_ride.customer_ride_end";
            OracleParameter[] parameterList = new OracleParameter[]{
                          new OracleParameter("session",OracleDbType.Varchar2,30,ride.Session,ParameterDirection.Input),
                          new OracleParameter("cust",OracleDbType.Varchar2,30,ride.Customer.ID,ParameterDirection.Input),
                          new OracleParameter("dest",OracleDbType.Varchar2,30,ride.RideDestination,ParameterDirection.Input),
                          new OracleParameter("distance",OracleDbType.Varchar2,30,ride.Distance,ParameterDirection.Input),
                         };


            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string result = (string)(OracleString)prm.Value;

            return result;

        }
        #endregion
         
       #region RideQueue
        public List<Ride> GetRideQueue()
        {
            string packageName = "pkg_ride.get_all_pending_ride_req";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             };
            return GetRideQueueLoc(packageName, parameterList);
        }
       #endregion
        private List<Ride> GetRideQueueLoc(string packageName, OracleParameter[] parameterList)
        {
            List<Ride> oRides = new List<Ride>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Ride oRide = new Ride();
                Customer oCustomer=new Customer();

                oCustomer.ID = rdr["cust_id"].ToString();
                oRide.Customer=oCustomer;
                oRide.RideSource = rdr["RIDE_SOURCE"].ToString();
                oRide.RideDestination = rdr["RIDE_DESTINATION"].ToString();

                oRides.Add(oRide);
            }
            rdr.Close();
            return oRides;

        }
      
    }
}
