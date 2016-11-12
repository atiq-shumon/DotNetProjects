using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.OPD.MODEL;
using AH.OracleManager;
using AH.Shared.MODEL;
using System.Data;
using Oracle.DataAccess.Client;

namespace AH.OPD.DAL
{
    public class OPDDrRoomAllRODAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);

        public List<OPDDrRoomAllRO> GetDocRoomAllRO()
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_DoctorRoom";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)               
            };

            return GetDocRoomAllRODetails(packageName, parameterList);
        }

        private List<OPDDrRoomAllRO> GetDocRoomAllRODetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDDrRoomAllRO> rDRSs = new List<OPDDrRoomAllRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjects(reader);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            } 

            return rDRSs;
        }

        private List<OPDDrRoomAllRO> CreateObjects(IDataReader oReader)
        {
            List<OPDDrRoomAllRO> rDRSs = new List<OPDDrRoomAllRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDDrRoomAllRO oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDDrRoomAllRO CreateObject(NullHandler oReader)
        {
            OPDDrRoomAllRO oDRS = new OPDDrRoomAllRO();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private OPDDrRoomAllRO MapObject(NullHandler oReader)
        {
            OPDDrRoomAllRO oDRS = new OPDDrRoomAllRO();

            oDRS.ROOM_ID = oReader.GetString("ROOM_ID");
            oDRS.RoomNo = oReader.GetString("RoomNo");
            oDRS.ROOM_GRP = oReader.GetString("ROOM_GRP");
            oDRS.VisStartTime = Convert.ToString(oReader.GetDateTime("VisStartTime").ToShortTimeString());
            oDRS.VisEndTime = Convert.ToString(oReader.GetDateTime("VisEndTime").ToShortTimeString());
            oDRS.VisFirst = oReader.GetString("VisFirst");
            oDRS.DrVisFirst = oReader.GetString("DrVisFirst");
            oDRS.VisSecond = oReader.GetString("VisSecond"); 
            oDRS.DrVisSecond = oReader.GetString("DrVisSecond");
            oDRS.VisThird = oReader.GetString("VisThird");
            oDRS.DrVisThird = oReader.GetString("DrVisThird");
            oDRS.VisFourth = oReader.GetString("VisFourth");
            oDRS.DrVisFourth = oReader.GetString("DrVisFourth");
            oDRS.RptVisit = oReader.GetString("RptVisit");
            oDRS.DrRptVisit = oReader.GetString("DrRptVisit"); 
            oDRS.VisitCycle = oReader.GetString("VisitCycle");
            oDRS.MaxPatBar = oReader.GetString("MaxPatBar");
            oDRS.AvgPatMin = oReader.GetString("AvgPatMin");  
            oDRS.DOC_ID = oReader.GetString("DOC_ID");
            oDRS.DoctorName = oReader.GetString("DoctorName"); 
            oDRS.EntryBy = oReader.GetString("EntryBy");
            oDRS.ENTRY_DATE = Convert.ToString(oReader.GetDateTime("ENTRY_DATE").ToString("dd MMM yyyy"));   
            oDRS.Department = oReader.GetString("Department");
            oDRS.Unit = oReader.GetString("Unit");

            return oDRS;
        }
    }
}
