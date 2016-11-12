using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.DAL;
using AH.PRMS.MODEL;

namespace AH.PRMS.BLL
{
    public class PropertySetupBLL
    {
        public int VerifyRoomSetup(string roomno)
        {
            return new PropertySetupDAL().VerifyRoomSetup(roomno);
        }
        public short SaveRoomsetup(Room trm)
        {
            return new PropertySetupDAL().SaveRoomsetup(trm);
        }
        public short UpdateRoomSetup(Room urm)
        {
            return new PropertySetupDAL().UpdateRoomSetup(urm);
        }
        public int VerifyBedFacility(string facid)
        {
            return new PropertySetupDAL().VerifyBedFacility(facid);
        }
        public short SaveBedfacility(BedFacility bdfac)
        {
            return new PropertySetupDAL().SaveBedfacility(bdfac);
        }
        public short UpdateBedFacility(BedFacility ubdfac)
        {
            return new PropertySetupDAL().UpdateBedFacility(ubdfac);
        }
        public int VerifyBedType(string typeid)
        {
            return new PropertySetupDAL().VerifyBedType(typeid);
        }
        public short SaveBedtype(BedType bdtype)
        {
            return new PropertySetupDAL().SaveBedtype(bdtype);
        }
        public short UpdateBedType(BedType ubdtype)
        {
            return new PropertySetupDAL().UpdateBedType(ubdtype);
        }
        public int VerifyWardSetup(string wardid)
        {
            return new PropertySetupDAL().VerifyWardSetup(wardid);
        }
        public short SaveWardsetup(Ward tward)
        {
            return new PropertySetupDAL().SaveWardsetup(tward);
        }
        public short UpdateWardSetup(Ward uwrd)
        {
            return new PropertySetupDAL().UpdateWardSetup(uwrd);
        }
        public int VerifyBedSetup(string bedno)
        {
            return new PropertySetupDAL().VerifyBedSetup(bedno);
        }
        public short SaveBedsetup(Bed tbed)
        {
            return new PropertySetupDAL().SaveBedsetup(tbed);
        }
        public short UpdateBedSetup(Bed ubed)
        {
            return new PropertySetupDAL().UpdateBedSetup(ubed);
        }
        public List<BedFacility> GetBedfacility()
        {
            return new PropertySetupDAL().GetBedfacility();
        }
        public Dictionary<string, string> GetBedfacility(string type)
        {
            Dictionary<string, string> bfds = new Dictionary<string, string>();

            foreach (BedFacility bf in new PropertySetupDAL().GetBedfacility())
            {
                bfds.Add(bf.ID, bf.Title);
            }

            return bfds;
        }
        public Dictionary<string, string> GetBuildings(string type)
        {
            Dictionary<string, string> blds = new Dictionary<string, string>();

            foreach (Building bl in new PropertySetupDAL().GetBuildings())
            {
                blds.Add(bl.BuildingID, bl.BuildingTitle);
            }

            return blds;
        }
        public List<BedType> GetBedtype()
        {
            return new PropertySetupDAL().GetBedtype();
        }
        public Dictionary<string, string> GetBedtype(string type)
        {
            Dictionary<string, string> bdtps = new Dictionary<string, string>();

            foreach (BedType btps in new PropertySetupDAL().GetBedtype())
            {
                bdtps.Add(btps.ID, btps.Title);
            }
            return bdtps;
        }
        public List<Ward> GetWards()
        {
            return new PropertySetupDAL().GetWards();
        }
        public List<Bed> GetBeds()
        {
            return new PropertySetupDAL().GetBeds();
        }
        //public List<Bed> GetBedByroom(string roomid, string bedtype)
        //{
        //    return new PropertySetupDAL().GetBedByroom(roomid,bedtype);
        //}
        //public Dictionary<string, string> GetBedByroom(string type, string roomid, string bedtype)
        //{
        //    Dictionary<string, string> bds = new Dictionary<string, string>();

        //    if (type == "D")
        //    {

        //        foreach (Bed bd in new PropertySetupDAL().GetBedByroom(roomid, bedtype))
        //        {
        //            bds.Add(bd.BedID, bd.BedNo);
        //        }
        //    }
        //    else if (type == "E")
        //    {
        //        foreach (Bed bd in new PropertySetupDAL().GetBedByroom(roomid, bedtype))
        //        {
        //            bds.Add(bd.Room.RoomID, bd.Room.RoomTitle);
        //        }

        //    }
        //    return bds;
        //}
        public List<Bed> GetBedSets(string bedtype, string bedstatus)
        {
            return new PropertySetupDAL().GetBedSets(bedtype,bedstatus);
        }
        public List<Bed> GetRoomBedType(string bedtype)
        {

            return new PropertySetupDAL().GetRoomBedType(bedtype);
        }
        public Dictionary<string, string> GetRoomByBedType(string type, string bedtype)
        {
            Dictionary<string, string> bds = new Dictionary<string, string>();
            foreach (Bed bd in new PropertySetupDAL().GetRoomBedType(bedtype))
            {
                bds.Add(bd.Room.RoomID, bd.Room.RoomTitle);
            }
            return bds;
        }
        public Dictionary<string, string> GetBedSets(string type, string bedtype,  string bedstatus)
        {
            Dictionary<string, string> bds = new Dictionary<string, string>();
            foreach (Bed bd in new PropertySetupDAL().GetBedSets(bedtype,bedstatus))
            {
                bds.Add(bd.BedID, bd.BedNo);
            }
            return bds;
        }
        public Dictionary<string, string> GetBeds(string type)
        {
            Dictionary<string, string> bds = new Dictionary<string, string>();

            foreach (Bed bd in new PropertySetupBLL().GetBeds())
            {
                bds.Add(bd.BedID, bd.BedNo);
            }
            return bds;
        }
        public Dictionary<string, string> GetWards(string type)
        {
            Dictionary<string, string> twrds = new Dictionary<string, string>();

            foreach (Ward wrd in new PropertySetupDAL().GetWards())
            {
                twrds.Add(wrd.WardID, wrd.WardTitle);
            }
            return twrds;

        }
        public List<Room> GetRooms()
        {
            return new PropertySetupDAL().GetRooms();
        }
        public List<Room> GetRoomByBuild(string building,string roomtype)
        {
            return new PropertySetupDAL().GetRoomByBuild(building,roomtype);
        }
        public Dictionary<string, string> GetRooms(string types)
        {
            Dictionary<string, string> trms = new Dictionary<string, string>();
            foreach (Room rms in new PropertySetupDAL().GetRooms())
            {
                trms.Add(rms.RoomID, rms.RoomTitle);
            }
            return trms;
        }
        public int VerifyRoomType(string typeid)
        {
            return new PropertySetupDAL().VerifyRoomType(typeid);
        }
        public short SaveRoomType(RoomType trm)
        {
            return new PropertySetupDAL().SaveRoomType(trm);
        }
        public short UpdateRoomType(RoomType utrm)
        {
            return new PropertySetupDAL().UpdateRoomType(utrm);
        }
        public List<RoomType> GetRoomTypes()
        {
            return new PropertySetupDAL().GetRoomTypes();
        }
        public Dictionary<string, string> GetRoomTypes(string type)
        {
            Dictionary<string, string> rmtps = new Dictionary<string, string>();
            foreach (RoomType rmt in new PropertySetupDAL().GetRoomTypes())
            {
                rmtps.Add(rmt.ID, rmt.Title);
            }
            return rmtps;
        }
        
        
        
        public Dictionary<string, short> GetRoomSet(string type)
        {
            Dictionary<string, short> tset = new Dictionary<string, short>();
            foreach (Room set in new PropertySetupDAL().GetRooms())
            {
                tset.Add(set.RoomID, set.RoomNo);
            }
            return tset;
        }
        public List<Bed> GetLevelWiseBeds(string nsstn, string level)
        {
            return new PropertySetupDAL().GetLevelWiseBeds(nsstn,level);
        }
        public List<Bed> GetNurseBeds(string nsstn, string level)
        {
            return new PropertySetupDAL().GetNurseBeds(nsstn,level);
        }
       
    }
}
