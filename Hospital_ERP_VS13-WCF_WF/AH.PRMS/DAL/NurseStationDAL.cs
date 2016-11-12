using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PRMS.DAL
{
    public class NurseStationDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.PRMIS);
        string packageName = string.Empty;
        public short SaveNurseStation(NurseStation nurse)
        {
            packageName = "PKG_NURSE_STATION.INSERT_NURSE_STATION";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("FloorNo",OracleDbType.Decimal,3,nurse.FloorNo,ParameterDirection.Input),
              new OracleParameter("NurseStationName",OracleDbType.Varchar2,200,nurse.NurseStationTitle,ParameterDirection.Input),
              new OracleParameter("NurseStationNameBeng",OracleDbType.Varchar2,200,nurse.NurseStationTitleBangla,ParameterDirection.Input),
              new OracleParameter("RoomId",OracleDbType.Varchar2,4,nurse.Room.RoomID,ParameterDirection.Input),
              new OracleParameter("IntercomNo",OracleDbType.Varchar2,7,nurse.IntercomNo,ParameterDirection.Input),
              new OracleParameter("Remarks",OracleDbType.Varchar2,200,nurse.Remarks,ParameterDirection.Input),
              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nurse.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,nurse.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,nurse.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,nurse.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }


        public List<NurseStation> GetNurseAllStation()
        {
            string packageName = "PKG_NURSE_STATION.GET_ALL_NURSE_STATION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GETNurseStation(packageName, parameterList);
        }
        private List<NurseStation> GETNurseStation(string packageName, OracleParameter[] parameterList)
        {
            List<NurseStation> oNurseList = new List<NurseStation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                NurseStation oNurse = new NurseStation();
                oNurse.NurseStationID = (string)rdr[0];
                oNurse.NurseStationTitle = (string)rdr[1];
                oNurse.NurseStationTitleBangla = (string)rdr[2];

                Room oRoom = new Room();
                oRoom.RoomID = (string)rdr[3];
                oNurse.Room = oRoom;
                oNurse.Remarks = !rdr.IsDBNull(4) ? (string)rdr[4] : "";
                oNurse.FloorNo = Convert.ToInt32(rdr[5]);
                oNurse.IntercomNo = !rdr.IsDBNull(6) ? (string)rdr[6] : "";

                oNurseList.Add(oNurse);

            }
            rdr.Close();
            return oNurseList;
        }

        public short UpdateNurseStation(NurseStation nurse)
        {
            packageName = "PKG_NURSE_STATION.UPDATE_NURSE_STATION";

            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("FloorNo",OracleDbType.Decimal,3,nurse.FloorNo,ParameterDirection.Input),
                new OracleParameter("NurseStationId",OracleDbType.Varchar2,2,nurse.NurseStationID,ParameterDirection.Input),
                new OracleParameter("NurseStationName",OracleDbType.Varchar2,200,nurse.NurseStationTitle,ParameterDirection.Input),
                new OracleParameter("NurseStationNameBeng",OracleDbType.Varchar2,200,nurse.NurseStationTitleBangla,ParameterDirection.Input),
                new OracleParameter("RoomId",OracleDbType.Varchar2,200,nurse.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("IntercomNo",OracleDbType.Varchar2,7,nurse.IntercomNo,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,nurse.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nurse.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,nurse.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,nurse.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,nurse.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<NurseStation> GetNurseStation()
        {
            string packageName = "PKG_NURSE_STATION.GET_NURSE_STATION";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)                      
            };
            return GetNurseStation(packageName, parameterList);
        }
        public List<NurseStation> GetNurseStationFloorWise(int floorNo)
        {
            string packageName = "PKG_NURSE_STATION.GET_NURSE_STATION_Floor_Wise";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("FloorNo",OracleDbType.Decimal,3,floorNo,ParameterDirection.Input)
            };
            return GetNurseStation(packageName, parameterList);
        }

        public List<NurseStation> GetNurseStation(string packageName, OracleParameter[] parameterList)
        {
            List<NurseStation> oNurseList = new List<NurseStation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                NurseStation oNurse = new NurseStation();
                oNurse.NurseStationID = (string)rdr["ns_stn_id"];
                oNurse.NurseStationTitle = (string)rdr["ns_stn_title"];
                oNurseList.Add(oNurse);
            }
            rdr.Close();
            return oNurseList;
        }

    }
}
