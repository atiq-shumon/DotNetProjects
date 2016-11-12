using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.OPD.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;

namespace AH.OPD.DAL
{
    public class OPDNurseRAllRODAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);

        public List<OPDNurseRoomAllRO> GetNurseRoomRO()
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.GETs_OPD_NRAlloc_RO";      
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)               
            };
            return NurseRoomDetails(packageName, parameterList);
        }

        private List<OPDNurseRoomAllRO> NurseRoomDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDNurseRoomAllRO> rDRSs = new List<OPDNurseRoomAllRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsNurse(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        private List<OPDNurseRoomAllRO> CreateObjectsNurse(IDataReader oReader)
        {
            List<OPDNurseRoomAllRO> rDRSs = new List<OPDNurseRoomAllRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDNurseRoomAllRO oItem = CreateObjectNurse(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDNurseRoomAllRO CreateObjectNurse(NullHandler oReader)
        {
            OPDNurseRoomAllRO oDRS = new OPDNurseRoomAllRO();
            oDRS = MapObjectNurse(oReader);
            return oDRS;
        }

        private OPDNurseRoomAllRO MapObjectNurse(NullHandler oReader)
        {
            OPDNurseRoomAllRO oDRS = new OPDNurseRoomAllRO();

            oDRS.ROOM_GRP = oReader.GetString("ROOM_GRP");
            oDRS.RoomNo = oReader.GetString("RoomNo");
            //oDRS.Nurse_ID = oReader.GetString("Nurse_ID");
            //oDRS.NurseName = oReader.GetString("NurseName");
            return oDRS;
        }
    }
}
