using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;
using AH.PRMS.BLL;
using AH.DUtility;
using AH.ORGMS.BLL;

//using AH.HR.BLL;
//using AH.ACCMS.BLL;


namespace AH.PRMS.Facade
{
    //NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PRMSWS" in both code and config file together.
    public class PRMSWS : IPRMSWS
    {
        public int VerifyRoomSetup(string roomno)
        {
            return new PropertySetupBLL().VerifyRoomSetup(roomno);
        }
        public short SaveRoomsetup(Room troom)
        {
            return new PropertySetupBLL().SaveRoomsetup(troom);
        }
        public short UpdateRoomSetup(Room urm)
        {
            return new PropertySetupBLL().UpdateRoomSetup(urm);
        }
        public int VerifyBedFacility(string facid)
        {
            return new PropertySetupBLL().VerifyBedFacility(facid);
        }
        public short UpdateBedFacility(BedFacility ubdfac)
        {
            return new PropertySetupBLL().UpdateBedFacility(ubdfac);
        }
        public short SaveBedfacility(BedFacility bedfac)
        {
            return new PropertySetupBLL().SaveBedfacility(bedfac);
        }
        public int VerifyBedType(string typeid)
        {
            return new PropertySetupBLL().VerifyBedType(typeid);
        }
        public short SaveBedtype(BedType btype)
        {
            return new PropertySetupBLL().SaveBedtype(btype);
        }
        public short UpdateBedType(BedType ubdtype)
        {
            return new PropertySetupBLL().UpdateBedType(ubdtype);
        }
        public int VerifyWardSetup(string wardid)
        {
            return new PropertySetupBLL().VerifyWardSetup(wardid);
        }
        public short SaveWardsetup(Ward tward)
        {
            return new PropertySetupBLL().SaveWardsetup(tward);
        }
        public short UpdateWardSetup(Ward uwrd)
        {
            return new PropertySetupBLL().UpdateWardSetup(uwrd);
        }
        public int VerifyBedSetup(string bedno)
        {
            return new PropertySetupBLL().VerifyBedSetup(bedno);
        }
        public short SaveBedsetup(Bed tbed)
        {
            return new PropertySetupBLL().SaveBedsetup(tbed);
        }
        public short UpdateBedSetup(Bed ubed)
        {
            return new PropertySetupBLL().UpdateBedSetup(ubed);
        }
        public List<BedFacility> GetBedfacility()
        {
            return new PropertySetupBLL().GetBedfacility();
        }
        public Dictionary<string, string> GetBedfacility(string type)
        {
            return new PropertySetupBLL().GetBedfacility(type);
        }
        public List<short> GetNumbers(short min, short max)
        {
            return Utility.GetNumbers(min, max);
        }
        //public List<short> GetOneToTen()
        //{
        //    return Utility.GetOneToTen();
        //}
        //public List<short> GetOneToTwenty()
        //{
        //    return Utility.GetOneToTwenty();
        //}
        public List<BedType> GetBedtype()
        {
            return new PropertySetupBLL().GetBedtype();
        }
        public List<Ward> GetWards()
        {
            return new PropertySetupBLL().GetWards();
        }
        public Dictionary<string, string> GetBuildings(string type)
        {
            return new PropertySetupBLL().GetBuildings(type);
        }
        public Dictionary<string, string> GetDepartments(string type)
        {
            return new AdministrationSetupBLL().GetDepartments(type);
        }
        public Dictionary<String, String> GetAllowedGender(string type)
        {
            return Utility.GetAllowedGender();
        }
        public List<Bed> GetBeds()
        {
            return new PropertySetupBLL().GetBeds();
        }
        public Dictionary<string, string> GetWards(string type)
        {
            return new PropertySetupBLL().GetWards(type);
        }
        public Dictionary<string, string> GetBedtype(string type)
        {
            return new PropertySetupBLL().GetBedtype(type);
        }
        public List<Room> GetRooms()
        {
            return new PropertySetupBLL().GetRooms();
        }
        public Dictionary<string, string> GetRooms(string types)
        {
            return new PropertySetupBLL().GetRooms(types);
        }

        public Dictionary<string, string> GetBedStatus()
        {
            return Utility.GetBedStatus();
        }
        public int VerifyRoomType(string typeid)
        {
            return new PropertySetupBLL().VerifyRoomType(typeid);
        }
        public short SaveRoomType(RoomType trm)
        {
            return new PropertySetupBLL().SaveRoomType(trm);
        }
        public short UpdateRoomType(RoomType utrm)
        {
            return new PropertySetupBLL().UpdateRoomType(utrm);
        }
        public List<RoomType> GetRoomTypes()
        {
            return new PropertySetupBLL().GetRoomTypes();
        }
        public Dictionary<string, string> GetRoomTypes(string type)
        {
            return new PropertySetupBLL().GetRoomTypes(type);
        }
        public Dictionary<string, string> GetBeds(string type)
        {
            return new PropertySetupBLL().GetBeds(type);
        }        
        public List<Bed> GetBedSets(string bedtype, string bedstatus)
        {
            return new PropertySetupBLL().GetBedSets(bedtype,bedstatus);
        }
        public Dictionary<string, string> GetBedSets(string type, string bedtype,  string bedstatus)
        {
            return new PropertySetupBLL().GetBedSets(type,bedtype,bedstatus);
        }
        //public List<Bed> GetBedByroom(string roomid, string bedtype)
        //{
        //    return new PropertySetupBLL().GetBedByroom(roomid,bedtype);
        //}
        public List<Bed> GetRoomBedType(string bedtype)
        {
            return new PropertySetupBLL().GetRoomBedType(bedtype);
        }
        public Dictionary<string, string> GetRoomByBedType(string type, string bedtype)
        {
            return new PropertySetupBLL().GetRoomByBedType(type, bedtype);
        }
        public List<Room> GetRoomByBuild(string building,string roomtype)
        {
            return new PropertySetupBLL().GetRoomByBuild(building,roomtype);
        }
        public List<NurseStation> GetNurseStation()
        {
            return new NurseStationBLL().GetNurseStation();
        }
        public Dictionary<string, string> GetNurseStationDic(string type)
        {
            Dictionary<string, string> nurseDic = new Dictionary<string, string>();
            foreach (NurseStation nurse in new NurseStationBLL().GetNurseStation())
            {
                nurseDic.Add(nurse.NurseStationID, nurse.NurseStationTitle);
            }
            return nurseDic;
        }
        public short SaveNurseStation(NurseStation nurse)
        {
            return new NurseStationBLL().SaveNurseStation(nurse);
        }
        public List<NurseStation> GetNurseAllStation()
        {
            return new NurseStationBLL().GetNurseAllStation();
        }
        public short UpdateNurseStation(NurseStation nurse)
        {
            return new NurseStationBLL().UpdateNurseStation(nurse);
        }
        public List<NurseStation> GetNurseStationFloorWise(int floorNo)
        {
            return new NurseStationBLL().GetNurseStationFloorWise(floorNo);
        }
       
      
        //public List<BedCharges> GetBedRateSetup(string bedtype, string headgroup)
        //{
        //    return new PropertySetupBLL().GetBedRateSetup(bedtype, headgroup);
        //}
    }
}
