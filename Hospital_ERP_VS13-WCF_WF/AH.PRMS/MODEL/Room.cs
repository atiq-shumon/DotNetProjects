using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.PRMS.MODEL
{
    public class Room
    {
        public Building Building { set; get; }
        public string RoomID { set; get; }
        public string RoomTitle { set; get; }
        public string RoomTitleBeng { set; get; }
        public short RoomNo { set; get; }
        public Department Department { set; get; }
        public string Block { set; get; }
        public string Floor { set; get; }
        public string Location { set; get; }
        public string RoomSft { set; get; }
        public RoomType RoomType { set; get; }
        public Int16 TotalBed { set; get; }
        public string AllowedGender { set; get; }
        public string AgeRange { set; get; }
        public short SerialPriority { set; get; }
        public string AgeGroupMin { set; get; }
        public string AgeGroupMax { set; get; }
        public string isGenderRestricted { set; get; }
        public string isDepartmentRestricted { set; get; }
        public string isAgeRestricted { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
