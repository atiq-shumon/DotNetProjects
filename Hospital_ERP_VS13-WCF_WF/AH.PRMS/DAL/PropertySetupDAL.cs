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
    public class PropertySetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.PRMIS);
        string packageName = string.Empty;

        #region GetBuildings
        public List<Building> GetBuildings()
        {
            string packageName = "PKG_PRMS_SETUP.GET_BUILD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
       };
            return GetBuild(packageName, parameterList);
        }
        private List<Building> GetBuild(string packageName, OracleParameter[] parameterList)
        {
            List<Building> blds = new List<Building>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Building bldobj = new Building();
                bldobj.BuildingID = (string)rdr[0];
                bldobj.BuildingTitle = (string)rdr[1];
                bldobj.BuildingTitleBeng = (string)rdr[2];
                blds.Add(bldobj);
            }
            rdr.Close();
            return blds;
        }
        #endregion

        #region GetRooms
        public List<Room> GetRooms()
        {
            string packageName = "PKG_PRMS_SETUP.GET_ROOM_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };
            return GetRoomsetup(packageName, parameterList);

        }
        public List<Room> GetRoomByBuild(string building,string roomtype)
        {
            string packageName = "PKG_PRMS_SETUP.GET_ROOM_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("BuildingID",OracleDbType.Varchar2,2,building,ParameterDirection.Input),
               new OracleParameter("RoomType",OracleDbType.Varchar2,2,roomtype,ParameterDirection.Input)
           };
            return GetRoomsetup(packageName, parameterList);

        }
        private List<Room> GetRoomsetup(string packageName, OracleParameter[] parameterList)
        {
            List<Room> rms = new List<Room>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Room trm = new Room();
                trm.RoomID = (string)rdr[1];
                trm.RoomTitle = (string)rdr[3];
                trm.RoomTitleBeng = (string)rdr[4];
                trm.RoomNo = short.Parse(rdr[6].ToString());
                trm.TotalBed = Int16.Parse(rdr["no_of_bed"].ToString());
                trm.AllowedGender = (string)rdr["allw_gender"];
                trm.AgeGroupMin = !rdr.IsDBNull(rdr.GetOrdinal("age_grp_min")) ? (string)rdr["age_grp_min"] : "";
                trm.AgeGroupMax = !rdr.IsDBNull(rdr.GetOrdinal("age_grp_max")) ? (string)rdr["age_grp_max"] : "";
                trm.isGenderRestricted = !rdr.IsDBNull(rdr.GetOrdinal("is_gender_rstcd")) ? (string)rdr["is_gender_rstcd"] : "";
                trm.isDepartmentRestricted = !rdr.IsDBNull(rdr.GetOrdinal("is_dept_rstcd")) ? (string)rdr["is_dept_rstcd"] : "";
                trm.isAgeRestricted = !rdr.IsDBNull(rdr.GetOrdinal("is_age_rstcd")) ? (string)rdr["is_age_rstcd"] : "";
                trm.SerialPriority = short.Parse(rdr["serial_priority"].ToString());

                Building bld = new Building();
                bld.BuildingID = (string)rdr[0];
                trm.Building = bld;

                RoomType rtp = new RoomType();
                rtp.ID = (string)rdr[5];
                trm.RoomType = rtp;

                //Department dpt = new Department();
                //dpt.DepartmentID = (string)rdr[2];
                //trm.Department = dpt;


                trm.RoomNo = short.Parse(rdr[6].ToString());
                trm.Block = (string)rdr[7];
                trm.Floor = (string)rdr[8];
                trm.Location = (string)rdr[9];
                trm.RoomSft = (string)rdr[10];

                rms.Add(trm);
            }
            rdr.Close();
            return rms;
        }
        #endregion

        #region VerifyRoomSetup
        public int VerifyRoomSetup(string roomno)
        {
            packageName = "PKG_PRMS_SETUP.VERIFY_RMSETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("RoomID",OracleDbType.Varchar2,4,roomno,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveRoomsetup
        public short SaveRoomsetup(Room trm)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_ROOM_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("BuildingID",OracleDbType.Varchar2,2,trm.Building.BuildingID,ParameterDirection.Input),
           new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,trm.Department.DepartmentID,ParameterDirection.Input),
           new OracleParameter("RoomType",OracleDbType.Varchar2,2,trm.RoomType.ID,ParameterDirection.Input),
           new OracleParameter("RoomName",OracleDbType.Varchar2,70,trm.RoomTitle,ParameterDirection.Input),
           new OracleParameter("RoomNameBeng",OracleDbType.Varchar2,70,trm.RoomTitleBeng,ParameterDirection.Input),
           new OracleParameter("RoomNo",OracleDbType.Varchar2,4,trm.RoomNo,ParameterDirection.Input),
           new OracleParameter("Block",OracleDbType.Varchar2,2,trm.Block,ParameterDirection.Input),
           new OracleParameter("Floor",OracleDbType.Varchar2,2,trm.Floor,ParameterDirection.Input),
           new OracleParameter("Location",OracleDbType.Varchar2,20,trm.Location,ParameterDirection.Input),
           new OracleParameter("RoomSize",OracleDbType.Varchar2,10,trm.RoomSft,ParameterDirection.Input),
           new OracleParameter("TotalBed",OracleDbType.Int16,trm.TotalBed,ParameterDirection.Input),
           new OracleParameter("Gender",OracleDbType.Varchar2,2,trm.AllowedGender,ParameterDirection.Input),
           new OracleParameter("AgeGroupMin",OracleDbType.Varchar2,3,trm.AgeGroupMin,ParameterDirection.Input),
           new OracleParameter("AgeGroupMax",OracleDbType.Varchar2,3,trm.AgeGroupMax,ParameterDirection.Input),
           new OracleParameter("GenderRestricted",OracleDbType.Char,1,trm.isGenderRestricted,ParameterDirection.Input),
           new OracleParameter("DepartmentRestricted",OracleDbType.Char,1,trm.isDepartmentRestricted,ParameterDirection.Input),
           new OracleParameter("AgeRestricted",OracleDbType.Char,1,trm.isAgeRestricted,ParameterDirection.Input),
           new OracleParameter("SerialPriority",OracleDbType.Int32,trm.SerialPriority,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,trm.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,trm.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,trm.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,trm.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateRoomSetup
        public short UpdateRoomSetup(Room urm)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_ROOM_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("RoomID",OracleDbType.Varchar2,4,urm.RoomID,ParameterDirection.Input),
           new OracleParameter("BuildingID",OracleDbType.Varchar2,2,urm.Building.BuildingID,ParameterDirection.Input),           
           new OracleParameter("RoomName",OracleDbType.Varchar2,70,urm.RoomTitle,ParameterDirection.Input),
           new OracleParameter("RoomNameBeng",OracleDbType.Varchar2,70,urm.RoomTitleBeng,ParameterDirection.Input),
           new OracleParameter("RoomNo",OracleDbType.Varchar2,4,urm.RoomNo,ParameterDirection.Input),
           new OracleParameter("Block",OracleDbType.Varchar2,2,urm.Block,ParameterDirection.Input),
           new OracleParameter("Floor",OracleDbType.Varchar2,2,urm.Floor,ParameterDirection.Input),
           new OracleParameter("Location",OracleDbType.Varchar2,20,urm.Location,ParameterDirection.Input),
           new OracleParameter("RoomSize",OracleDbType.Varchar2,10,urm.RoomSft,ParameterDirection.Input),
           new OracleParameter("RoomType",OracleDbType.Varchar2,2,urm.RoomType.ID,ParameterDirection.Input),
           new OracleParameter("IsGenderRestricted",OracleDbType.Char,1,urm.isGenderRestricted,ParameterDirection.Input),
           new OracleParameter("IsDepartmentRestricted",OracleDbType.Char,1,urm.isDepartmentRestricted,ParameterDirection.Input),
           new OracleParameter("IsAgeRestricted",OracleDbType.Char,1,urm.isAgeRestricted,ParameterDirection.Input),
           new OracleParameter("AllowGender",OracleDbType.Varchar2,2,urm.AllowedGender,ParameterDirection.Input),
           new OracleParameter("AgeGroupMin",OracleDbType.Varchar2,3,urm.AgeGroupMin,ParameterDirection.Input),
           new OracleParameter("AgeGroupMax",OracleDbType.Varchar2,3,urm.AgeGroupMax,ParameterDirection.Input),
           new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,urm.Department.DepartmentID,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,urm.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,urm.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,urm.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,urm.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetBedfacility
        public List<BedFacility> GetBedfacility()
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_FACILITY";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
       };
            return GetBedfac(packageName, parameterList);
        }
        private List<BedFacility> GetBedfac(string packageName, OracleParameter[] parameterList)
        {
            List<BedFacility> bdfacs = new List<BedFacility>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedFacility bedfacobj = new BedFacility();
                bedfacobj.ID = (string)rdr[0].ToString();
                bedfacobj.Title = (string)rdr[1].ToString();
                bedfacobj.TitleBeng = (string)rdr[2].ToString();
                bedfacobj.TV = short.Parse(rdr[3].ToString());
                bedfacobj.Fridge = short.Parse(rdr[4].ToString());
                bedfacobj.Sofa = short.Parse(rdr[5].ToString());
                bedfacobj.Internet = short.Parse(rdr[6].ToString());
                bedfacobj.Newspaper = short.Parse(rdr[7].ToString());
                bedfacobj.Corridor = short.Parse(rdr[8].ToString());
                bedfacobj.Veranda = short.Parse(rdr[9].ToString());
                bedfacobj.Almirah = short.Parse(rdr[10].ToString());
                bedfacobj.XtraBed = short.Parse(rdr[11].ToString());
                bedfacobj.MaxAllowedPerson = short.Parse(rdr[12].ToString());
                bedfacobj.AC = short.Parse(rdr[13].ToString());
                bedfacobj.WashRoom = short.Parse(rdr[14].ToString());
                bedfacobj.Remarks = !rdr.IsDBNull(15) ? (string)rdr[15] : "";
                bdfacs.Add(bedfacobj);
            }
            rdr.Close();
            return bdfacs;

        }
        #endregion

        #region VerifyBedFacility
        public int VerifyBedFacility(string facid)
        {
            packageName = "PKG_PRMS_SETUP.VERIFY_BEDFACILITY";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("FacilityID",OracleDbType.Varchar2,3,facid,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveBedfacility
        public short SaveBedfacility(BedFacility bdfac)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_BED_FACILITY";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("FacilityName",OracleDbType.Varchar2,350,bdfac.Title,ParameterDirection.Input),
           new OracleParameter("FacilityNameBeng",OracleDbType.Varchar2,350,bdfac.TitleBeng,ParameterDirection.Input),
           new OracleParameter("TV",OracleDbType.Int16,bdfac.TV,ParameterDirection.Input),
           new OracleParameter("Fridge",OracleDbType.Int16,bdfac.Fridge,ParameterDirection.Input),
           new OracleParameter("Sofa",OracleDbType.Int16,bdfac.Sofa,ParameterDirection.Input),
           new OracleParameter("Internet",OracleDbType.Int16,bdfac.Internet,ParameterDirection.Input),
           new OracleParameter("Newspaper",OracleDbType.Int16,bdfac.Newspaper,ParameterDirection.Input),
           new OracleParameter("Corridor",OracleDbType.Int16,bdfac.Corridor,ParameterDirection.Input),
           new OracleParameter("Veranda",OracleDbType.Int16,bdfac.Veranda,ParameterDirection.Input),
           new OracleParameter("Almirah",OracleDbType.Int16,bdfac.Almirah,ParameterDirection.Input),
           new OracleParameter("ExtraBed",OracleDbType.Int16,bdfac.XtraBed,ParameterDirection.Input),
           new OracleParameter("MaxPerson",OracleDbType.Int16,bdfac.MaxAllowedPerson,ParameterDirection.Input),
           new OracleParameter("AC",OracleDbType.Int16,bdfac.AC,ParameterDirection.Input),
           new OracleParameter("WashRoom",OracleDbType.Int16,bdfac.WashRoom,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,bdfac.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,30,bdfac.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,bdfac.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,bdfac.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,bdfac.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateBedFacility
        public short UpdateBedFacility(BedFacility ubdfac)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_BED_FACILITY";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("FacilityID",OracleDbType.Varchar2,3,ubdfac.ID,ParameterDirection.Input),
           new OracleParameter("FacilityName",OracleDbType.Varchar2,350,ubdfac.Title,ParameterDirection.Input),
           new OracleParameter("FacilityNameBeng",OracleDbType.Varchar2,350,ubdfac.TitleBeng,ParameterDirection.Input),
           new OracleParameter("TV",OracleDbType.Int16,ubdfac.TV,ParameterDirection.Input),
           new OracleParameter("Fridge",OracleDbType.Int16,ubdfac.Fridge,ParameterDirection.Input),
           new OracleParameter("Sofa",OracleDbType.Int16,ubdfac.Sofa,ParameterDirection.Input),
           new OracleParameter("Internet",OracleDbType.Int16,ubdfac.Internet,ParameterDirection.Input),
           new OracleParameter("Newspaper",OracleDbType.Int16,ubdfac.Newspaper,ParameterDirection.Input),
           new OracleParameter("Corridor",OracleDbType.Int16,ubdfac.Corridor,ParameterDirection.Input),
           new OracleParameter("Veranda",OracleDbType.Int16,ubdfac.Veranda,ParameterDirection.Input),
           new OracleParameter("Almirah",OracleDbType.Int16,ubdfac.Almirah,ParameterDirection.Input),
           new OracleParameter("ExtraBed",OracleDbType.Int16,ubdfac.XtraBed,ParameterDirection.Input),
           new OracleParameter("MaxPerson",OracleDbType.Int16,ubdfac.MaxAllowedPerson,ParameterDirection.Input),
           new OracleParameter("AC",OracleDbType.Int16,ubdfac.AC,ParameterDirection.Input),
           new OracleParameter("WashRoom",OracleDbType.Int16,ubdfac.WashRoom,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,ubdfac.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,30,ubdfac.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ubdfac.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,ubdfac.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,ubdfac.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region GetBedtype
        public List<BedType> GetBedtype()
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
       };
            return GetBdType(packageName, parameterList);
        }
        private List<BedType> GetBdType(string packageName, OracleParameter[] parameterList)
        {
            List<BedType> bdtps = new List<BedType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedType btpobj = new BedType();
                btpobj.ID = (string)rdr[1].ToString();
                btpobj.Title = (string)rdr[2].ToString();
                btpobj.TitleBeng = (string)rdr[3].ToString();
                btpobj.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";

                BedFacility bfs = new BedFacility();
                bfs.ID = (string)rdr[0];
                btpobj.BedFacility = bfs;

                bdtps.Add(btpobj);
            }
            rdr.Close();
            return bdtps;


        }
        #endregion

        #region VerifyBedType
        public int VerifyBedType(string typeid)
        {
            packageName = "PKG_PRMS_SETUP.VERIFY_BEDTYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("TypeID",OracleDbType.Varchar2,2,typeid,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveBedtype
        public short SaveBedtype(BedType bdtype)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_BED_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("TypeName",OracleDbType.Varchar2,70,bdtype.Title,ParameterDirection.Input),
           new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,bdtype.TitleBeng,ParameterDirection.Input),
           new OracleParameter("FacilityID",OracleDbType.Varchar2,3,bdtype.BedFacility.ID,ParameterDirection.Input),
           new OracleParameter("SerialPriority",OracleDbType.Int32,bdtype.SerialPriority,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,bdtype.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,bdtype.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,bdtype.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,bdtype.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,bdtype.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateBedType
        public short UpdateBedType(BedType ubdtype)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_BED_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("TypeID",OracleDbType.Varchar2,2,ubdtype.ID,ParameterDirection.Input),
           new OracleParameter("TypeName",OracleDbType.Varchar2,70,ubdtype.Title,ParameterDirection.Input),
           new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,ubdtype.TitleBeng,ParameterDirection.Input),
           new OracleParameter("FacilityID",OracleDbType.Varchar2,3,ubdtype.BedFacility.ID,ParameterDirection.Input),
           new OracleParameter("SerialPriority",OracleDbType.Int32,ubdtype.SerialPriority,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,ubdtype.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ubdtype.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ubdtype.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,ubdtype.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,ubdtype.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetWards
        public List<Ward> GetWards()
        {
            string packageName = "PKG_PRMS_SETUP.GET_WARD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
       };
            return GetWardsSetup(packageName, parameterList);
        }
        private List<Ward> GetWardsSetup(string packageName, OracleParameter[] parameterList)
        {
            List<Ward> wrd = new List<Ward>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ward wrdobj = new Ward();
                wrdobj.WardID = (string)rdr[0];
                wrdobj.WardNo = (string)rdr[1];
                wrdobj.WardTitle = (string)rdr[2];
                wrdobj.WardTitleBeng = (string)rdr[3];

                wrdobj.NthFloor = (string)rdr[5];
                wrdobj.BlockNo = (string)rdr[6];
                wrdobj.NoRoom = Int32.Parse(rdr[7].ToString());
                wrdobj.TotalBed = Int16.Parse(rdr[8].ToString());
                wrdobj.AllowedGender = (string)rdr[10];
                wrdobj.AgeGroupMin = !rdr.IsDBNull(11) ? (string)rdr[11] : "";
                wrdobj.AgeGroupMax = !rdr.IsDBNull(12) ? (string)rdr[12] : "";
                wrdobj.isGenderRestricted = !rdr.IsDBNull(13) ? (string)rdr[13] : "";
                wrdobj.isDepartmentRestricted = !rdr.IsDBNull(14) ? (string)rdr[14] : "";
                wrdobj.isAgeRestricted = !rdr.IsDBNull(15) ? (string)rdr[15] : "";
                wrdobj.SerialPriority = short.Parse(rdr[16].ToString());
                wrdobj.Remarks = !rdr.IsDBNull(17) ? (string)rdr[17] : "";

                BedType btp = new BedType();
                btp.ID = (string)rdr[4];
                wrdobj.BedType = btp;

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr[18];
                wrdobj.Department = dpt;

                wrd.Add(wrdobj);
            }
            rdr.Close();
            return wrd;
        }
        #endregion

        #region VerifyWardSetup
        public int VerifyWardSetup(string wardid)
        {
            packageName = "PKG_PRMS_SETUP.VERIFY_WARDSETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("WardId",OracleDbType.Varchar2,5,wardid,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveWardsetup
        public short SaveWardsetup(Ward twrd)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_WARD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,twrd.BedType.ID,ParameterDirection.Input),
           new OracleParameter("WardNo",OracleDbType.Varchar2,20,twrd.WardNo,ParameterDirection.Input),
           new OracleParameter("WardName",OracleDbType.Varchar2,70,twrd.WardTitle,ParameterDirection.Input),
           new OracleParameter("WardNameBeng",OracleDbType.Varchar2,70,twrd.WardTitleBeng,ParameterDirection.Input),
           new OracleParameter("BuildingID",OracleDbType.Varchar2,3,twrd.BuildingID,ParameterDirection.Input),
           new OracleParameter("Floor",OracleDbType.Varchar2,2,twrd.NthFloor,ParameterDirection.Input),
           new OracleParameter("Block",OracleDbType.Varchar2,30,twrd.BlockNo,ParameterDirection.Input),
           new OracleParameter("NoofRooms",OracleDbType.Int32,twrd.NoRoom,ParameterDirection.Input),
           new OracleParameter("TotalBed",OracleDbType.Int16,twrd.TotalBed,ParameterDirection.Input),
           new OracleParameter("Department",OracleDbType.Varchar2,4,twrd.Department.DepartmentID,ParameterDirection.Input),
           new OracleParameter("Gender",OracleDbType.Varchar2,2,twrd.AllowedGender,ParameterDirection.Input),
           new OracleParameter("AgeGroupMin",OracleDbType.Varchar2,3,twrd.AgeGroupMin,ParameterDirection.Input),
           new OracleParameter("AgeGroupMax",OracleDbType.Varchar2,3,twrd.AgeGroupMax,ParameterDirection.Input),
           new OracleParameter("GenderRestricted",OracleDbType.Char,1,twrd.isGenderRestricted,ParameterDirection.Input),
           new OracleParameter("DepartmentRestricted",OracleDbType.Char,1,twrd.isDepartmentRestricted,ParameterDirection.Input),
           new OracleParameter("AgeRestricted",OracleDbType.Char,1,twrd.isAgeRestricted,ParameterDirection.Input),
           new OracleParameter("SerialPriority",OracleDbType.Int32,twrd.SerialPriority,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,twrd.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,twrd.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,twrd.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,twrd.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,twrd.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateWardSetup
        public short UpdateWardSetup(Ward uwrd)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_WARD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("WardID",OracleDbType.Varchar2,5,uwrd.WardID,ParameterDirection.Input),
           new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,uwrd.BedType.ID,ParameterDirection.Input),
           new OracleParameter("WardNo",OracleDbType.Varchar2,20,uwrd.WardNo,ParameterDirection.Input),
           new OracleParameter("WardName",OracleDbType.Varchar2,70,uwrd.WardTitle,ParameterDirection.Input),
           new OracleParameter("WardNameBeng",OracleDbType.Varchar2,70,uwrd.WardTitleBeng,ParameterDirection.Input),
           //new OracleParameter("BuildingID",OracleDbType.Varchar2,3,uwrd.BuildingID,ParameterDirection.Input),
           new OracleParameter("Floor",OracleDbType.Varchar2,2,uwrd.NthFloor,ParameterDirection.Input),
           new OracleParameter("Block",OracleDbType.Varchar2,30,uwrd.BlockNo,ParameterDirection.Input),
           new OracleParameter("No of Rooms",OracleDbType.Int32,uwrd.NoRoom,ParameterDirection.Input),
           new OracleParameter("TotalBed",OracleDbType.Int16,uwrd.TotalBed,ParameterDirection.Input),
           //new OracleParameter("Department",OracleDbType.Varchar2,4,uwrd.Department.DepartmentID,ParameterDirection.Input),
           new OracleParameter("Gender",OracleDbType.Varchar2,2,uwrd.AllowedGender,ParameterDirection.Input),
           new OracleParameter("AgeGroupMin",OracleDbType.Varchar2,3,uwrd.AgeGroupMin,ParameterDirection.Input),
           new OracleParameter("AgeGroupMax",OracleDbType.Varchar2,3,uwrd.AgeGroupMax,ParameterDirection.Input),
           new OracleParameter("IsGenderRestricted",OracleDbType.Char,1,uwrd.isGenderRestricted,ParameterDirection.Input),
           new OracleParameter("IsDeptRestricted",OracleDbType.Char,1,uwrd.isDepartmentRestricted,ParameterDirection.Input),
           new OracleParameter("IsAgerestricted",OracleDbType.Char,1,uwrd.isAgeRestricted,ParameterDirection.Input),
           new OracleParameter("SerialPriority",OracleDbType.Int32,uwrd.SerialPriority,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,uwrd.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,uwrd.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,uwrd.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,uwrd.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,uwrd.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetBeds
        public List<Bed> GetBeds()
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
       };
            return GetBedsetup(packageName, parameterList);
        }
        public List<Bed> GetRoomBedType(string bedtype)
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,bedtype,ParameterDirection.Input)
       };
            return GetBedsetup(packageName, parameterList);
        }
        public List<Bed> GetLevelWiseBeds(string nsstn, string level)
        {
            string packageName = "PKG_PRMS_SETUP.GET_LEVEL_WISE_BEDS";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
           new OracleParameter("NurseStation",OracleDbType.Varchar2,2,nsstn,ParameterDirection.Input),
           new OracleParameter("Level",OracleDbType.Varchar2,2,level,ParameterDirection.Input)
       };
            return GetBedsetup(packageName, parameterList);
        }
        public List<Bed> GetNurseBeds(string nsstn,string level)
        {
            string packageName = "PKG_PRMS_SETUP.GET_NURSELEVELWISE_BEDS";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
           new OracleParameter("NurseStation",OracleDbType.Varchar2,2,nsstn,ParameterDirection.Input),
           new OracleParameter("Level",OracleDbType.Varchar2,2,level,ParameterDirection.Input)
       };
            return GetBedsetup(packageName, parameterList);
        }
       // public List<Bed> GetBedByroom(string roomid, string bedtype)
       // {
       //     string packageName = "PKG_PRMS_SETUP.GET_BED_SETUP";
       //     OracleParameter[] parameterList = new OracleParameter[]{
       //    new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
       //    new OracleParameter("RoomId",OracleDbType.Varchar2,5,roomid,ParameterDirection.Input),
       //    new OracleParameter("BedType",OracleDbType.Varchar2,2,bedtype,ParameterDirection.Input)
       //};
       //     return GetBedsetup(packageName, parameterList);
       // }
        public List<Bed> GetBedSets(string bedtype,string bedstatus)
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,bedtype,ParameterDirection.Input),           
           new OracleParameter("BedStatus",OracleDbType.Varchar2,1,bedstatus,ParameterDirection.Input)
          
       };
            return GetBedsetup(packageName, parameterList);
        }
        private List<Bed> GetBedsetup(string packageName, OracleParameter[] parameterList)
        {
            List<Bed> bds = new List<Bed>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Bed tbed = new Bed();
                tbed.BedID = (string)rdr["bed_id"];
                tbed.BedNo = (string)rdr["bed_no"];
                tbed.BedTitle = (string)rdr["bed_title"];
                tbed.BedTitleBeng = (string)rdr["bed_title_beng"];
                tbed.BedStatus = (string)rdr["bed_status_id"];
                tbed.SerialNo = short.Parse(rdr["serial_no"].ToString());
                tbed.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                tbed.Floor = (string)rdr["floor_no"];

                Building obuild = new Building();
                obuild.BuildingID = (string)rdr["build_id"];
                obuild.BuildingTitle = (string)rdr["BuildingName"];
                tbed.Building = obuild;

                BedType bt = new BedType();
                bt.ID = (string)rdr["bed_type_id"];
                bt.Title = (string)rdr["BedType"];
                //bt.BedFacility.ID = (string)rdr[3];
                tbed.BedType = bt;

                BedFacility bfs = new BedFacility();
                bfs.ID = (string)rdr["facility_id"];
                bfs.Title = (string)rdr["BedFacility"];
                tbed.Facility = bfs;

                NurseStation ons = new NurseStation();
                ons.NurseStationID = (string)rdr["ns_stn_id"];
                ons.NurseStationTitle = !rdr.IsDBNull(rdr.GetOrdinal("NursingStation")) ? (string)rdr["NursingStation"] : "";
                tbed.NurseStation = ons;

                //Department dpt = new Department();
                //dpt.DepartmentID = (string)rdr["dept_id"];
                //dpt.DepartmentTitle = (string)rdr["Department"];
                //tbed.Department = dpt;

                //Ward wd = new Ward();
                //wd.WardID = (string)rdr["ward_id"];
                //wd.WardTitle = (string)rdr["Ward"];
                //tbed.Ward = wd;

                Room rm = new Room();
                rm.RoomID = (string)rdr["room_id"];
                rm.RoomTitle = (string)rdr["Room"];
                tbed.Room = rm;



                bds.Add(tbed);
            }
            rdr.Close();
            return bds;
        }
        #endregion

        #region VerifyBedSetup
        public int VerifyBedSetup(string bedno)
        {
            packageName = "PKG_PRMS_SETUP.VERIFY_BEDSETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("BedId",OracleDbType.Varchar2,4,bedno,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveBedsetup
        public short SaveBedsetup(Bed tbed)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_BED_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("BuildID",OracleDbType.Varchar2,2,tbed.Building.BuildingID,ParameterDirection.Input),
           new OracleParameter("Floor",OracleDbType.Varchar2,2,tbed.Floor,ParameterDirection.Input),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,tbed.BedType.ID,ParameterDirection.Input),
           //new OracleParameter("Department",OracleDbType.Varchar2,5,tbed.Department.DepartmentID,ParameterDirection.Input),
           new OracleParameter("BedFacility",OracleDbType.Varchar2,2,tbed.Facility.ID,ParameterDirection.Input),
           new OracleParameter("RoomID",OracleDbType.Varchar2,4,tbed.Room.RoomID,ParameterDirection.Input),
           new OracleParameter("NurseStation",OracleDbType.Varchar2,2,tbed.NurseStation.NurseStationID,ParameterDirection.Input),
           new OracleParameter("BedNo",OracleDbType.Varchar2,20,tbed.BedNo,ParameterDirection.Input),
           new OracleParameter("BedTitle",OracleDbType.Varchar2,70,tbed.BedTitle,ParameterDirection.Input),
           new OracleParameter("BedTitleBeng",OracleDbType.Varchar2,70,tbed.BedTitleBeng,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,tbed.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tbed.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tbed.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,tbed.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,tbed.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateBedSetup
        public short UpdateBedSetup(Bed ubed)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_BED_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("BedId",OracleDbType.Varchar2,4,ubed.BedID,ParameterDirection.Input),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,ubed.BedType.ID,ParameterDirection.Input),
           new OracleParameter("BedFacility",OracleDbType.Varchar2,3,ubed.Facility.ID,ParameterDirection.Input),
           new OracleParameter("RoomID",OracleDbType.Varchar2,4,ubed.Room.RoomID,ParameterDirection.Input),
           new OracleParameter("NurseStation",OracleDbType.Varchar2,2,ubed.NurseStation.NurseStationID,ParameterDirection.Input),
           new OracleParameter("BedNo",OracleDbType.Varchar2,20,ubed.BedNo,ParameterDirection.Input),
           new OracleParameter("BedTitle",OracleDbType.Varchar2,70,ubed.BedTitle,ParameterDirection.Input),
           new OracleParameter("BedTitleBeng",OracleDbType.Varchar2,70,ubed.BedTitleBeng,ParameterDirection.Input),
           new OracleParameter("BedStatus",OracleDbType.Varchar2,20,ubed.BedStatus,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,ubed.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ubed.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ubed.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,ubed.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,ubed.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VerifyRoomType
        public int VerifyRoomType(string typeid)
        {
            packageName = "PKG_PRMS_SETUP.VERIFY_RMTYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
           new OracleParameter("TypeId",OracleDbType.Varchar2,2,typeid,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region SaveRoomType
        public short SaveRoomType(RoomType trm)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_ROOM_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("TypeName",OracleDbType.Varchar2,70,trm.Title,ParameterDirection.Input),
           new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,trm.TitleBeng,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,trm.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,trm.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,trm.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,trm.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,trm.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateRoomType
        public short UpdateRoomType(RoomType utrm)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_ROOM_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("TypeID",OracleDbType.Varchar2,2,utrm.ID,ParameterDirection.Input),
           new OracleParameter("TypeName",OracleDbType.Varchar2,70,utrm.Title,ParameterDirection.Input),
           new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,utrm.TitleBeng,ParameterDirection.Input),
           new OracleParameter("Remarks",OracleDbType.Varchar2,200,utrm.Remarks,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,utrm.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,utrm.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,utrm.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,utrm.EntryParameter.MachineID,ParameterDirection.Input)

       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetRoomTypes
        public List<RoomType> GetRoomTypes()
        {
            packageName = "PKG_PRMS_SETUP.GET_ROOM_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
       };
            return GetRoomTypeSet(packageName, parameterList);
        }
        private List<RoomType> GetRoomTypeSet(string packageName, OracleParameter[] parameterList)
        {
            List<RoomType> rmtp = new List<RoomType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RoomType rmtpset = new RoomType();
                rmtpset.ID = (string)rdr[0];
                rmtpset.Title = (string)rdr[1];
                rmtpset.TitleBeng = (string)rdr[2];
                rmtpset.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                rmtp.Add(rmtpset);

            }
            rdr.Close();
            return rmtp;

        }
        #endregion

    }
}
