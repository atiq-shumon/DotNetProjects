using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.PRMS.MODEL;

namespace AH.OPD.DAL
{
    public class OPDRoomGrpAssignDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);
        string packageName = string.Empty;

        public List<OPDRoomGrpAssign> GetOPDRooms(string BuildingID, string RmType)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_OPD_Room";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter ("BuildingID",OracleDbType.Varchar2,30,BuildingID,ParameterDirection.Input),
                new OracleParameter ("RoomType",OracleDbType.Varchar2,30,RmType,ParameterDirection.Input)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<OPDRoomGrpAssign> oGetRooms = new List<OPDRoomGrpAssign>();
            while (rdr.Read())
            {
                OPDRoomGrpAssign rm = new OPDRoomGrpAssign();
                rm.RoomID = (String)rdr["ROOM_ID"];
                rm.RoomNO = (String)rdr["ROOM_NO"];
                oGetRooms.Add(rm);
            }
            rdr.Close();
            return oGetRooms;

        } 


        public List<OPDDoctorCallQ> InsDrRoom(string NurseID)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Ins_OPD_Call_Que";
            OracleParameter[] parameterList = new OracleParameter[]
            {
              new OracleParameter ("P_NurseID",OracleDbType.Varchar2,30,"1",ParameterDirection.Input)           
            };
            return InsDrRoomDetails(packageName, parameterList);
        }
        private List<OPDDoctorCallQ> InsDrRoomDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDDoctorCallQ> oOPDDoctorCallQs = new List<OPDDoctorCallQ>();
            IDataReader reader = null;            
            reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList); 
            return oOPDDoctorCallQs;
        }
        public List<Room> GETs_Room_No(string RoomGrp)
        {
            string packageName = "AGH_OPD.PKG_OPD.GETs_Room_No";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
             new OracleParameter ("p_room_grp",OracleDbType.Varchar2,30,RoomGrp,ParameterDirection.Input),
            };
            return InsRoomGroupDetails(packageName, parameterList);
        }
        public List<Room> test()
        {          
            string packageName = "AGH_OPD.PKG_OPD.GETs_Room_No_Grp_Ass";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter ("p_test_cursor1",OracleDbType.RefCursor,"",ParameterDirection.Output),           
            };
            return test1(packageName, parameterList);
        }
        //---------------------------------------------------------New 23/12/2014------------------------------------------------------------
        #region InsertRoomGroup()
        public short InsertRoomGroup(OPDRoomGrpAssign oRoom)
        {
                string packageName = "AGH_OPD.PKG_OPD.Insert_Room_Group";
                OracleParameter[] parameterList = new OracleParameter[]
                    {             
                    new OracleParameter ("p_test_cursor",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),  
                     new OracleParameter ("p_RoomGroup",OracleDbType.Varchar2,10,oRoom.RoomGroup,ParameterDirection.Input), //Room Group         
                     new OracleParameter ("p_RoomID",OracleDbType.NVarchar2,10,oRoom.RoomID,ParameterDirection.Input),   //Room ID                      
                     new OracleParameter ("p_EntryBy",OracleDbType.NVarchar2,30,oRoom.EntryParameter.EntryBy,ParameterDirection.Input)
                    };

                short i = DALHelper.Insert(connString, packageName, parameterList);
                OracleParameter prm = parameterList[0];
                if ((OracleDecimal)prm.Value == 1)
                    return 1;
                else return 0;
        }
        #endregion
        #region GetRoomGroup()
       
        public List<OPDRoomGrpAssign> GetRoomGroup()
        {
            string packageName = "AGH_OPD.PKG_OPD.GET_Room_Group";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
            };

            return GetRoomGroups(packageName, parameterList);
        }
        public List<OPDRoomGrpAssign> GetRoomGroup(string RoomGrp)
        {
            string packageName = "AGH_OPD.PKG_OPD.GET_Room_Group";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
             new OracleParameter ("p_RoomGroup",OracleDbType.Varchar2,30,RoomGrp,ParameterDirection.Input)
            };

            return GetRoomGroups(packageName, parameterList);
        }

        private List<OPDRoomGrpAssign> GetRoomGroups(string packageName, OracleParameter[] parameterList)
        {
            List<OPDRoomGrpAssign> oGetRoomGroupLIST = new List<OPDRoomGrpAssign>();
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                OPDRoomGrpAssign oRoomGroup = new OPDRoomGrpAssign();
               
                oRoomGroup.RoomGroup = (string)rdr["ROOM_GRP"];
                oRoomGroup.RoomID = (string)rdr["ROOM_ID"];
                oRoomGroup.RoomNO = (string)rdr["ROOM_NO"];

                EntryParameter oEP = new EntryParameter();
                oEP.EntryDate =(DateTime)rdr["ENTRY_DATE"];
                oRoomGroup.EntryParameter = oEP;

                oGetRoomGroupLIST.Add(oRoomGroup);
            }
            rdr.Close();
            return oGetRoomGroupLIST;
        }
   //-----------------------------------------------------search by group id ---------------------
      
        #endregion
        //---------------------------------------------------------New 23/12/2014------------------------------------------------------------
        public List<Room> UpdateRoomGroup(Room oRoom)
        {
                string packageName = "AGH_OPD.PKG_OPD.UpdateRoomGroup";
                OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_RoomGroup",OracleDbType.Varchar2,30,oRoom.RoomSft,ParameterDirection.Input), //Room Group 
             new OracleParameter ("p_RoomID",OracleDbType.Varchar2,30,oRoom.RoomID,ParameterDirection.Input),               
             new OracleParameter ("p_EntryBy",OracleDbType.Varchar2,30,oRoom.EntryParameter.EntryBy,ParameterDirection.Input),
            };

             return InsRoomGroupDetails(packageName, parameterList);
        }
        private List<Room> InsRoomGroupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Room> oRooms = new List<Room>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    oRooms = CreateObjects(reader);
                }
            }

            catch (Exception e)
            {
                EntryParameter oEP = new EntryParameter();
                Room oRoom = new Room();                
                oEP.ErrorMessage = "";
                oEP.ErrorMessage = e.Message.Split('!')[0]; 
                oRoom.EntryParameter = oEP;
                oRooms.Add(oRoom);
            }

            return oRooms;
        }
        private List<Room> CreateObjects(IDataReader oReader)
        {
            List<Room> oRooms = new List<Room>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                Room oItem = CreateObject(oHandler);
                oRooms.Add(oItem);
            }
            return oRooms;
        }
        private Room CreateObject(NullHandler oReader)
        {
            Room oRoom = new Room();
            oRoom = MapObject(oReader);
            return oRoom;
        }
        private Room MapObject(NullHandler oReader)
        {
            Room oRoom = new Room();
            EntryParameter oEP = new EntryParameter();         
            oRoom.RoomSft = oReader.GetString("room_grp");
            oRoom.RoomID = oReader.GetString("room_id");
            oRoom.RoomNo = Convert.ToInt16(oReader.GetString("roomno"));
            oEP.EntryDate = Convert.ToDateTime(oReader.GetDateTime("entry_date").ToString("dd MMM yyyy"));
            oRoom.EntryParameter = oEP;
            return oRoom;
        }

        //New 
        private List<Room> test1(string packageName, OracleParameter[] parameterList)
        {
            List<Room> oRooms = new List<Room>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    oRooms = CreateObjects(reader);
                }
            }
            catch (Exception e)
            {
                EntryParameter oEP = new EntryParameter();
                Room oRoom = new Room();
                oEP.ErrorMessage = "";
                oEP.ErrorMessage = e.Message.Split('!')[0];
                oRoom.EntryParameter = oEP;
                oRooms.Add(oRoom);
            }

            return oRooms;
        }
    }
}
