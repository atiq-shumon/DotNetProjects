using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.PatReg.MODEL;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.ACCMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.IPD.MODEL;
using AH.IPDShared.MODEL;

namespace AH.IPD.DAL
{
    public class IPDCertificateDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;

        public string SavePatientDeath(PatientDeath death)
        {
            packageName = "AGH_IPD.Pkg_IPD_Certificate.INSERT_DEATH_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                   new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
               //   new OracleParameter("P_Reg_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output), 
                   new OracleParameter("HCN_No",OracleDbType.Varchar2,30,death.InPatient.HCN,ParameterDirection.Input),  
                   new OracleParameter("Reg_Id",OracleDbType.Varchar2,30,death.InPatient.RegistrationNo,ParameterDirection.Input),
                   new OracleParameter("Dept_grp_id",OracleDbType.Varchar2,5,death.InPatient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                   new OracleParameter("Department",OracleDbType.Varchar2,5,death.InPatient.Department.DepartmentID,ParameterDirection.Input),
                   new OracleParameter("Unit",OracleDbType.Varchar2,5,death.InPatient.DepartmentUnit.UnitId,ParameterDirection.Input),
                   new OracleParameter("p_bed_id",OracleDbType.Varchar2,5,death.InPatient.Bed.BedID,ParameterDirection.Input),
                   new OracleParameter("p_doctor_id",OracleDbType.Varchar2,7,death.InPatient.Doctor.ID,ParameterDirection.Input),
                   new OracleParameter("p_nurse_id",OracleDbType.Varchar2,5,death.InPatient.DutyNurse.ID,ParameterDirection.Input),
                   new OracleParameter("p_death_reason_id",OracleDbType.Varchar2,5,death.DeathReasonID,ParameterDirection.Input),
                   new OracleParameter("p_death_notes",OracleDbType.Varchar2,500,death.DeathNotes,ParameterDirection.Input),
                   new OracleParameter("p_death_dttm",OracleDbType.Date,death.DeathDTTM,ParameterDirection.Input),
                   new OracleParameter("p_remarks",OracleDbType.Varchar2,500,death.Remarks,ParameterDirection.Input),           
                   new OracleParameter("EntryBy",OracleDbType.Varchar2,20,death.EntryParameter.EntryBy,ParameterDirection.Input),
                   new OracleParameter("CompanyID",OracleDbType.Varchar2,2,death.EntryParameter.CompanyID,ParameterDirection.Input),
                   new OracleParameter("LocationID",OracleDbType.Varchar2,2,death.EntryParameter.LocationID,ParameterDirection.Input),
                   new OracleParameter("MachineID",OracleDbType.Varchar2,20,death.EntryParameter.MachineID,ParameterDirection.Input)
             
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[1] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value.ToString();
            else return "0";

        }
        public string SaveChildBirth(IPDBirth birth)
        {
            packageName = "AGH_IPD.Pkg_IPD_Certificate.INSERT_BIRTH_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                   new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                   new OracleParameter("P_Child_Hcn",OracleDbType.Varchar2,30,birth.ChildHCN,ParameterDirection.Input), 
                   new OracleParameter("p_Mot_Hcn",OracleDbType.Varchar2,30,birth.InPatient.HCN,ParameterDirection.Input),  
                   new OracleParameter("p_Mot_Reg_Id",OracleDbType.Varchar2,30,birth.InPatient.RegistrationNo,ParameterDirection.Input),                 
                   new OracleParameter("p_bed_id",OracleDbType.Varchar2,5,birth.InPatient.Bed.BedID,ParameterDirection.Input),
                   new OracleParameter("p_Dept_grp_id",OracleDbType.Varchar2,5,birth.DeptGroupID,ParameterDirection.Input),
                   new OracleParameter("p_Department_id",OracleDbType.Varchar2,5,birth.DepartmentID,ParameterDirection.Input),
                   new OracleParameter("p_Unit_id",OracleDbType.Varchar2,5,birth.UnitId,ParameterDirection.Input),
                   new OracleParameter("p_doctor_id",OracleDbType.Varchar2,7,birth.DoctorId,ParameterDirection.Input),
                   new OracleParameter("p_nurse_id",OracleDbType.Varchar2,7,birth.NurseID,ParameterDirection.Input),
                   new OracleParameter("p_birth_type",OracleDbType.Varchar2,3,birth.BirthType,ParameterDirection.Input),
                   new OracleParameter("p_Gender",OracleDbType.Varchar2,1,birth.Gender,ParameterDirection.Input),
                   new OracleParameter("p_Blood_Group",OracleDbType.Varchar2,2,birth.BloodGroup,ParameterDirection.Input),
                   new OracleParameter("p_Birth_Height",OracleDbType.Varchar2,5,birth.BirthHeight,ParameterDirection.Input),
                   new OracleParameter("p_Birth_Weight",OracleDbType.Varchar2,5,birth.BirthWeight,ParameterDirection.Input),
                   new OracleParameter("p_Discharge_Weight",OracleDbType.Varchar2,5,birth.DischargeWeight,ParameterDirection.Input),
                   new OracleParameter("p_Birth_DTTM",OracleDbType.Date,birth.BirthDateTime,ParameterDirection.Input),
                   new OracleParameter("p_Complexion",OracleDbType.Varchar2,10,birth.Complexion,ParameterDirection.Input),
                   new OracleParameter("p_Birth_Marks",OracleDbType.Varchar2,1000,birth.BirthMark,ParameterDirection.Input),
                   new OracleParameter("p_Health_Status",OracleDbType.Varchar2,5,birth.HealthStatus,ParameterDirection.Input),
                   new OracleParameter("p_Govt_Reg_Id",OracleDbType.Varchar2,30,birth.GovtRegistrationNo,ParameterDirection.Input),                
                   new OracleParameter("p_remarks",OracleDbType.Varchar2,1000,birth.Remarks,ParameterDirection.Input),           
                   new OracleParameter("EntryBy",OracleDbType.Varchar2,20,birth.EntryParameter.EntryBy,ParameterDirection.Input),
                   new OracleParameter("CompanyID",OracleDbType.Varchar2,2,birth.EntryParameter.CompanyID,ParameterDirection.Input),
                   new OracleParameter("LocationID",OracleDbType.Varchar2,2,birth.EntryParameter.LocationID,ParameterDirection.Input),
                   new OracleParameter("MachineID",OracleDbType.Varchar2,20,birth.EntryParameter.MachineID,ParameterDirection.Input)
             
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[1] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value.ToString();
            else return "0";

        }
        public PatientDeath GetDeathPatient(string RegistrationNo)
        {
            string packageName = "PKG_IPD.GET_CURRENT_PATIENT";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegNo",OracleDbType.Varchar2,30,RegistrationNo,ParameterDirection.Input)
            };
            return GetDeathPatient(packageName, parameterList);
        }
        private PatientDeath GetDeathPatient(string packageName, OracleParameter[] parameterList)
        {
            PatientDeath death = new PatientDeath();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InPatient inp = new InPatient();
                inp.Name = (string)rdr["pat_name"];
                inp.HCN = (string)rdr["hcn"];
                inp.Sex = (string)rdr["sex"];
                inp.RegistrationNo = (string)rdr["reg_id"];
                inp.DOB = (DateTime)rdr["DOB"];
                inp.StaffID = (string)rdr["staff_id"];
                inp.ReferenceNo = (string)rdr["REFF_NO"];

                Bed bd = new Bed();
                bd.BedNo = (string)rdr["bed_no"];
                bd.BedTitle = (string)rdr["bed_title"];

                BedType bedType = new BedType();
                bedType.Title = (string)rdr["type_title"];
                bedType.ID = (string)rdr["TYPE_ID"];

                BedFacility bedFac = new BedFacility();
                bedFac.Title = (string)rdr["facility_title"];
                bedFac.ID = (string)rdr["FACILITY_ID"];
                bedType.BedFacility = bedFac;

                bd.BedType = bedType;

                inp.Bed = bd;

                Room rm = new Room();
                rm.RoomID = Convert.ToInt16(rdr["room_id"]).ToString();
                rm.RoomTitle = (string)rdr["room_title"];
                rm.Floor = (string)rdr["floor_no"].ToString();
                inp.Room = rm;

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr["dept_id"];
                dpt.DepartmentTitle = (string)rdr["dept_title"];
                dpt.DepartmentUnitHead = !rdr.IsDBNull(12) ? (string)rdr["Dept_Head_Name"] : "";
                inp.Department = dpt;

                Doctor doc = new Doctor();
                doc.ID = (string)rdr["Doc_ID"];
                //  doc.Name = !rdr.IsDBNull(12) ? (string)rdr["Reff_Doc_name"] : ""; 
                inp.Doctor = doc;

                DepartmentUnit unt = new DepartmentUnit();
                unt.UnitId = (string)rdr["unit_id"];
                unt.UnitTitle = (string)rdr["unit_title"];
                inp.DepartmentUnit = unt;

                inp.Email = !rdr.IsDBNull(7) ? (string)rdr["Email"] : "";
                inp.CellPhone = (string)rdr["Cell_Phone"];
                inp.Religion = (string)rdr["religion"];
                inp.BloodGroup = !rdr.IsDBNull(7) ? (string)rdr["blood_grp"] : "";
                inp.FathersName = !rdr.IsDBNull(8) ? (string)rdr["fname"] : "";
                inp.MothersName = !rdr.IsDBNull(9) ? (string)rdr["mname"] : "";
                inp.CellPhone = (string)rdr["cell_phone"];
                inp.Photo = (string)rdr["photo_path"];
                inp.HourDifference = Convert.ToInt32(rdr["Hour_diff"]);

                NurseStation nrsTn = new NurseStation();
                nrsTn.NurseStationID = (string)rdr["NURSE_STN_ID"];
                inp.NurseStation = nrsTn;
            }
            rdr.Close();
            return death;
        }
        //public IPDBirthCertificateRO GetBirthCertificate(string RegistrationNo)
        //{
        //    string packageName = "PKG_IPD.GET_CURRENT_PATIENT";

        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("RegNo",OracleDbType.Varchar2,30,RegistrationNo,ParameterDirection.Input)
        //    };
        //    return GetDeathPatient(packageName, parameterList);
        //}
        //private IPDBirthCertificateRO GetDeathPatient(string packageName, OracleParameter[] parameterList)
        //{
        //    IPDBirthCertificateRO death = new IPDBirthCertificateRO();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        InPatient inp = new InPatient();
        //        inp.Name = (string)rdr["pat_name"];
        //        inp.HCN = (string)rdr["hcn"];
        //        inp.Sex = (string)rdr["sex"];
        //        inp.RegistrationNo = (string)rdr["reg_id"];
        //        inp.DOB = (DateTime)rdr["DOB"];
        //        inp.StaffID = (string)rdr["staff_id"];
        //        inp.ReferenceNo = (string)rdr["REFF_NO"];

        //        Bed bd = new Bed();
        //        bd.BedNo = (string)rdr["bed_no"];
        //        bd.BedTitle = (string)rdr["bed_title"];

        //        BedType bedType = new BedType();
        //        bedType.Title = (string)rdr["type_title"];
        //        bedType.ID = (string)rdr["TYPE_ID"];

        //        BedFacility bedFac = new BedFacility();
        //        bedFac.Title = (string)rdr["facility_title"];
        //        bedFac.ID = (string)rdr["FACILITY_ID"];
        //        bedType.BedFacility = bedFac;

        //        bd.BedType = bedType;

        //        inp.Bed = bd;

        //        Room rm = new Room();
        //        rm.RoomID = Convert.ToInt16(rdr["room_id"]).ToString();
        //        rm.RoomTitle = (string)rdr["room_title"];
        //        rm.Floor = (string)rdr["floor_no"].ToString();
        //        inp.Room = rm;

        //        Department dpt = new Department();
        //        dpt.DepartmentID = (string)rdr["dept_id"];
        //        dpt.DepartmentTitle = (string)rdr["dept_title"];
        //        dpt.DepartmentUnitHead = !rdr.IsDBNull(12) ? (string)rdr["Dept_Head_Name"] : "";
        //        inp.Department = dpt;

        //        Doctor doc = new Doctor();
        //        doc.ID = (string)rdr["Doc_ID"];
        //        //  doc.Name = !rdr.IsDBNull(12) ? (string)rdr["Reff_Doc_name"] : ""; 
        //        inp.Doctor = doc;

        //        DepartmentUnit unt = new DepartmentUnit();
        //        unt.UnitId = (string)rdr["unit_id"];
        //        unt.UnitTitle = (string)rdr["unit_title"];
        //        inp.DepartmentUnit = unt;

        //        inp.Email = !rdr.IsDBNull(7) ? (string)rdr["Email"] : "";
        //        inp.CellPhone = (string)rdr["Cell_Phone"];
        //        inp.Religion = (string)rdr["religion"];
        //        inp.BloodGroup = !rdr.IsDBNull(7) ? (string)rdr["blood_grp"] : "";
        //        inp.FathersName = !rdr.IsDBNull(8) ? (string)rdr["fname"] : "";
        //        inp.MothersName = !rdr.IsDBNull(9) ? (string)rdr["mname"] : "";
        //        inp.CellPhone = (string)rdr["cell_phone"];
        //        inp.Photo = (string)rdr["photo_path"];
        //        inp.HourDifference = Convert.ToInt32(rdr["Hour_diff"]);

        //        NurseStation nrsTn = new NurseStation();
        //        nrsTn.NurseStationID = (string)rdr["NURSE_STN_ID"];
        //        inp.NurseStation = nrsTn;
        //    }
        //    rdr.Close();
        //    return death;
        //}
    }
}
