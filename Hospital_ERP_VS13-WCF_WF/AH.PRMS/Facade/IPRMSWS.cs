using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PRMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPRMSWS" in both code and config file together.
    [ServiceContract]
    public interface IPRMSWS
    {
        [OperationContract]
        int VerifyRoomSetup(string roomno);
        [OperationContract]
        short SaveRoomsetup(Room troom);
        [OperationContract]
        short UpdateRoomSetup(Room urm);
        [OperationContract]
        int VerifyBedFacility(string facid);
        [OperationContract]
        short UpdateBedFacility(BedFacility ubdfac);
        [OperationContract]
        short SaveBedfacility(BedFacility bedfac);
        [OperationContract]
        int VerifyBedType(string typeid);
        [OperationContract]
        short SaveBedtype(BedType btype);
        [OperationContract]
        short UpdateBedType(BedType ubdtype);
        [OperationContract]
        int VerifyWardSetup(string wardid);
        [OperationContract]
        short SaveWardsetup(Ward tward);
        [OperationContract]
        short UpdateWardSetup(Ward uwrd);
        [OperationContract]
        int VerifyBedSetup(string bedid);
        [OperationContract]
        short SaveBedsetup(Bed tbed);
        [OperationContract]
        short UpdateBedSetup(Bed ubed);
        [OperationContract]
        List<BedFacility> GetBedfacility();
        [OperationContract(Name = "GetBedfacilityDict")]
        Dictionary<string, string> GetBedfacility(string type);
        [OperationContract]
        List<short> GetNumbers(short min, short max);
        //[OperationContract]
        //List<short> GetOneToTen();
        //[OperationContract]
        //List<short> GetOneToTwenty();
        [OperationContract]
        List<BedType> GetBedtype();
        [OperationContract]
        Dictionary<string, string> GetBedStatus();
        [OperationContract]
        List<Ward> GetWards();
        [OperationContract(Name = "GetWardsDict")]
        Dictionary<string, string> GetWards(string type);
        [OperationContract(Name = "GetBuildingDict")]
        Dictionary<string, string> GetBuildings(string type);
        [OperationContract(Name = "GetDepartmentDict")]
        Dictionary<string, string> GetDepartments(string type);
        [OperationContract(Name = "GetGenderDict")]
        Dictionary<String, String> GetAllowedGender(string type);
        [OperationContract]
        List<Bed> GetBeds();
        [OperationContract(Name = "GetBedtypeDict")]
        Dictionary<string, string> GetBedtype(string type);
        [OperationContract]
        List<Room> GetRooms();
        [OperationContract(Name = "GetRoomsDict")]
        Dictionary<string, string> GetRooms(string types);
        [OperationContract]
        int VerifyRoomType(string typeid);
        [OperationContract]
        short SaveRoomType(RoomType trm);
        [OperationContract]
        short UpdateRoomType(RoomType utrm);
        [OperationContract]
        List<RoomType> GetRoomTypes();
        [OperationContract(Name = "GetRoomTypeDict")]
        Dictionary<string, string> GetRoomTypes(string type);
        [OperationContract]
        List<Bed> GetBedSets(string bedtype, string bedstatus);
        [OperationContract(Name = "GetBedList")]
        Dictionary<string, string> GetBedSets(string type, string bedtype, string bedstatus);
        //[OperationContract]
        //List<Bed> GetBedByroom(string roomid, string bedtype);
        [OperationContract]
        List<Bed> GetRoomBedType(string bedtype);
        [OperationContract(Name = "GetRoomBedTypeDict")]
        Dictionary<string, string> GetRoomByBedType(string type, string bedtype);
        [OperationContract]
        List<Room> GetRoomByBuild(string building, string roomtype);        
        //[OperationContract]
        //List<BedCharges> GetBedRateSetup(string bedtype, string headgroup);
        [OperationContract]
        List<NurseStation> GetNurseStation();
        [OperationContract]
        Dictionary<string, string> GetNurseStationDic(string type);
        [OperationContract]
        short SaveNurseStation(NurseStation nurse);
        [OperationContract]
        List<NurseStation> GetNurseAllStation();
        [OperationContract]
        short UpdateNurseStation(NurseStation nurse);
        [OperationContract]
        List<NurseStation> GetNurseStationFloorWise(int floorNo);
        
    }
}
