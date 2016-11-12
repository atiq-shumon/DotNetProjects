using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Globalization;


namespace AH.IPDShared.DAL
{
    public class IPDSharedDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;

        public InPatient GetAdmittedPatient(string RegistrationNo)
        {
            string packageName = "PKG_IPD.GET_CURRENT_PATIENT";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegNo",OracleDbType.Varchar2,30,RegistrationNo,ParameterDirection.Input)
            };
            return GetPatregistration(packageName, parameterList);

        }
        public List<InPatient> GetAdmittedPatientList()
        {
            string packageName = "PKG_IPD.GET_ADMITTED_PATIENT_LIST";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetAdmPatientList(packageName, parameterList);

        }
        public List<InPatient> PatList()
        {
            string packageName = "PKG_IPD.GET_ADMITTED_PATIENT_LIST";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetAdmPatientList(packageName, parameterList);

        }
        public List<InPatient> BedTransferPatList()
        {
            string packageName = "PKG_IPD.Get_Bed_Trans_Pat_List";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetAdmPatientList(packageName, parameterList);

        }
        private List<InPatient> GetAdmPatientList(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> inpList = new List<InPatient>();
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

                Bed bd = new Bed();
                bd.BedNo = (string)rdr["bed_no"];
                bd.BedTitle = (string)rdr["bed_title"];
                inp.Bed = bd;


                Room rm = new Room();
                rm.RoomID = Convert.ToInt16(rdr["room_id"]).ToString();
                rm.RoomTitle = (string)rdr["room_title"];
                rm.Floor = (string)rdr["floor_no"].ToString();
                inp.Room = rm;

                OPDPayment pay = new OPDPayment();
                //pay.TransactionNo = (string)rdr["trans_no"];
                pay.Amount = Convert.ToDecimal(rdr["amount"]);
                inp.Payment = pay;

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
                inp.Photo = (string)rdr["photo_path"];
                inp.AdmissionDate = (DateTime)rdr["DT"];
                //  inp.HourDifference = Convert.ToInt32(rdr["Hour_diff"]);
                inpList.Add(inp);

            }
            rdr.Close();
            return inpList;
        }
        private InPatient GetPatregistration(string packageName, OracleParameter[] parameterList)
        {
            InPatient inp = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {

                inp.Name = (string)rdr["pat_name"];
                inp.HCN = (string)rdr["hcn"];
                inp.Sex = (string)rdr["sex"];
                inp.RegistrationNo = (string)rdr["reg_id"];
                inp.DOB = (DateTime)rdr["DOB"];
                inp.StaffID = (string)rdr["staff_id"];
                inp.ReferenceNo = (string)rdr["REFF_NO"];

                Bed bd = new Bed();
                bd.BedNo= (string)rdr["bed_no"];
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

                //OPDPayment pay = new OPDPayment();
                //pay.TransactionNo = (string)rdr["trans_no"];
                //inp.Payment = pay;

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
                inp.Photo = (string)rdr["photo_path"];
                inp.HourDifference = Convert.ToInt32(rdr["Hour_diff"]);

                NurseStation nrsTn = new NurseStation();
                nrsTn.NurseStationID = (string)rdr["NURSE_STN_ID"];
                inp.NurseStation = nrsTn;
            }
            rdr.Close();
            return inp;
        }

        public InPatient GetPatientDetails(string presID)
        {
            string packageName = "PKG_IPD.GET_PAT_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PrescriptionID",OracleDbType.Varchar2,30,presID,ParameterDirection.Input)             
            };
            return GetPatientDetails(packageName, parameterList);
        }

        private InPatient GetPatientDetails(string packageName, OracleParameter[] parameterList)
        {

            InPatient oPat = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                oPat.HCN = (string)rdr["HCN"];
                oPat.Name = (string)rdr["PAT_NAME"];
                oPat.Sex = (string)rdr["SEX"];
                oPat.DOB = (DateTime)rdr["DOB"];
                oPat.StaffID = (string)rdr["STAFF_ID"];

                Department oDept = new Department();
                oDept.DepartmentTitle = (string)rdr["Dept_Title"];
                oPat.Department = oDept;

                DepartmentUnit dUnit = new DepartmentUnit();
                dUnit.UnitTitle = (string)rdr["Unit_Title"];
                oPat.DepartmentUnit = dUnit;

                Doctor doc = new Doctor();
                doc.ID = (string)rdr["Doc_ID"];
                doc.Name = (string)rdr["Reff_Doc_name"];//!rdr.IsDBNull(6) ? (string)rdr["Reff_Doc_name"] : "";
                oPat.Doctor = doc;

            }
            rdr.Close();
            return oPat;
        }

        public string verifyPatient(string regno)
        {
            packageName = "PKG_IPD.P_VERIFY_INPATIENT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
                new OracleParameter("Registration",OracleDbType.Varchar2,30,regno,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;
        }
        //=============================================//
      
        public InPatient GetPatRegID(string bedID)
        {
            string packageName = "PKG_IPD.GET_PATIENT_REGID";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("BedID",OracleDbType.Varchar2,30,bedID,ParameterDirection.Input)
            };
            return GetPatDetails(packageName, parameterList);

        }
        private InPatient GetPatDetails(string packageName, OracleParameter[] parameterList)
        {
            InPatient inp = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                inp.RegistrationNo = (string)rdr["reg_id"];
            }
            rdr.Close();
            return inp;
        }
        public List<InPatient> GetAdmittedPatientListNSWise(string nurseStationId)
        {
            string packageName = "PKG_IPD.GET_Pat_List_NS_Wise";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_ns_id",OracleDbType.Varchar2,7,nurseStationId,ParameterDirection.Input)
            };
            return GetAdmittedPatientList(packageName, parameterList);

        }
        public List<InPatient>NSWisePatientListDiet(string nurseStationId,string dietTypeId,DateTime date,string mealid)
        {
            string packageName = "PKG_IPD.GET_NS_Wise_Diet_Pat_List";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("P_NS_ID",OracleDbType.Varchar2,10,nurseStationId,ParameterDirection.Input),
                new OracleParameter("P_Diet_Type",OracleDbType.Varchar2,10,dietTypeId,ParameterDirection.Input),
                new OracleParameter("p_date",OracleDbType.Date,15,date,ParameterDirection.Input),
                new OracleParameter("p_mealId",OracleDbType.Varchar2,5,mealid,ParameterDirection.Input)
            };
            return GetAdmittedPatientList(packageName, parameterList);

        }
        public List<InPatient> OrderdNSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid)
        {
            string packageName = "PKG_IPD.GET_Orderd_Diet_Pat_List";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("P_NS_ID",OracleDbType.Varchar2,10,nurseStationId,ParameterDirection.Input),
                new OracleParameter("P_Diet_Type",OracleDbType.Varchar2,10,dietTypeId,ParameterDirection.Input),
                new OracleParameter("p_date",OracleDbType.Date,15,date,ParameterDirection.Input),
                new OracleParameter("p_mealId",OracleDbType.Varchar2,5,mealid,ParameterDirection.Input)
            };
            return GetAdmittedPatientList(packageName, parameterList);

        }
        public List<InPatient> ReadyToDelevPatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid)
        {
            string packageName = "PKG_IPD.GET_Ready_To_Del_Diet_List";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("P_NS_ID",OracleDbType.Varchar2,10,nurseStationId,ParameterDirection.Input),
                new OracleParameter("P_Diet_Type",OracleDbType.Varchar2,10,dietTypeId,ParameterDirection.Input),
                new OracleParameter("p_date",OracleDbType.Date,15,date,ParameterDirection.Input),
                new OracleParameter("p_mealId",OracleDbType.Varchar2,5,mealid,ParameterDirection.Input)
            };
            return GetAdmittedPatientList(packageName, parameterList);

        }
        private List<InPatient> GetAdmittedPatientList(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> inpList = new List<InPatient>();
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

                Bed bd = new Bed();
                bd.BedNo = (string)rdr["bed_no"];
                bd.BedTitle = (string)rdr["bed_title"];
                inp.Bed = bd;


                Room rm = new Room();
                rm.RoomID = Convert.ToInt16(rdr["room_id"]).ToString();
                rm.RoomTitle = (string)rdr["room_title"];
                rm.Floor = (string)rdr["floor_no"].ToString();
                inp.Room = rm;

                OPDPayment pay = new OPDPayment();
                //pay.TransactionNo = (string)rdr["trans_no"];
                pay.Amount = Convert.ToDecimal(rdr["amount"]);
                inp.Payment = pay;

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
                inp.AdmissionDate = (DateTime)rdr["DT"];
                //  inp.HourDifference = Convert.ToInt32(rdr["Hour_diff"]);
                inpList.Add(inp);

            }
            rdr.Close();
            return inpList;
        }
        public List<InPatient> GetNewPatient()
        {
            string packageName = "PKG_IPD.GET_New_Patient";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)             
            };
            return GetNewPatient(packageName, parameterList);

        }

        private List<InPatient> GetNewPatient(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> inps = new List<InPatient>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InPatient inp = new InPatient();
                inp.RegistrationNo = (string)rdr["reg_id"];
                inps.Add(inp);
            }
            rdr.Close();
            return inps;
        }


        //================================IPD Doctor Setup======================================// 
        public short InsertIPDDoctors(IPDDoctor oIPDDOc)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.INSERT_IPD_Doctor";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
               
                new OracleParameter("DeptGrpID",OracleDbType.Varchar2,5,oIPDDOc.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("DeptID",OracleDbType.Varchar2,5,oIPDDOc.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,5,oIPDDOc.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorID",OracleDbType.Varchar2,50,oIPDDOc.ID,ParameterDirection.Input),

                new OracleParameter("Visit_Fee",OracleDbType.Double,30,oIPDDOc.IPDVisitingFee,ParameterDirection.Input),
                new OracleParameter("Doctors_Fee",OracleDbType.Double,30,oIPDDOc.DoctorsVisitingFee,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,oIPDDOc.Remarks,ParameterDirection.Input),

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oIPDDOc.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,10,oIPDDOc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,10,oIPDDOc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oIPDDOc.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connstring, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }
      
       public List<IPDDoctor> GetIPDDoctorsList()
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Get_IPD_Doctor";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

           return GetIPDDoctorsList(packageName, parameterList);
       }
     
       private List<IPDDoctor> GetIPDDoctorsList(string packageName, OracleParameter[] parameterList)
       {
           List<IPDDoctor> IPDDocs = new List<IPDDoctor>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read()) 
           {
               IPDDoctor IPDDoc = new IPDDoctor();

               Department dpt = new Department();

               DepartmentType odptTyp = new DepartmentType();
               odptTyp.TypeID = (string)rdr["DeptGrpType"].ToString();

               DepartmentGroup oDptGrp = new DepartmentGroup();
               oDptGrp.DepartmentGroupID = (string)rdr["DeptGrpID"].ToString();

               dpt.DepartmentType = odptTyp;
               dpt.DepartmentGroup = oDptGrp;

               dpt.DepartmentID = (string)rdr["DeptID"].ToString();
               dpt.DepartmentTitle = (string)rdr["Department"].ToString();

               DepartmentUnit oUnit = new DepartmentUnit();
               oUnit.UnitId = (string)rdr["UnitID"].ToString();
               oUnit.UnitTitle = (string)rdr["Unit"].ToString();


               IPDDoc.ID = (string)rdr["DocID"].ToString();
               IPDDoc.Name = (string)rdr["DoctorsName"].ToString();

               IPDDoc.IPDVisitingFee = Convert.ToDouble(rdr["VisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["VisitingFee"]);
               IPDDoc.DoctorsVisitingFee = Convert.ToDouble(rdr["DocsVisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["DocsVisitingFee"]);

               IPDDoc.Remarks = (string)rdr["remarks"].ToString();

               IPDDoc.Department = dpt;
               IPDDoc.DepartmentUnit = oUnit;


               IPDDocs.Add(IPDDoc);
           }
           rdr.Close();
           return IPDDocs;
       }

       public List<IPDDoctor> GetIPDDoctorsList_ByDept(string dept_id, string unit_id)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Get_IPD_Doctor_ByDept";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("Dept",OracleDbType.Varchar2,30,dept_id,ParameterDirection.Input),
             new OracleParameter("Unit",OracleDbType.Varchar2,30,unit_id,ParameterDirection.Input)
           };

           return GetIPDDoctorsList(packageName, parameterList);
       }
       public List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Get_Doc_Fee_Details";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("reg_ID",OracleDbType.Varchar2,20,reg_ID,ParameterDirection.Input)
           };

           List<IPDDoctor> IPDDocs = new List<IPDDoctor>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               IPDDoctor IPDDoc = new IPDDoctor();

               IPDDoc.VisitNo = (string)rdr["VISIT_NO"].ToString();
               Department dpt = new Department();
               dpt.DepartmentID = (string)rdr["DeptID"].ToString();
               dpt.DepartmentTitle = (string)rdr["Department"].ToString();

               DepartmentUnit oUnit = new DepartmentUnit();
               oUnit.UnitId = (string)rdr["UnitID"].ToString();
               oUnit.UnitTitle = (string)rdr["Unit"].ToString();

               IPDDoc.ID = (string)rdr["DocID"].ToString();
               IPDDoc.Name = (string)rdr["DoctorsName"].ToString();

               IPDDoc.IPDVisitingFee = Convert.ToDouble(rdr["VisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["VisitingFee"]);

               EntryParameter en = new EntryParameter();
               en.EntryDate = DateTime.ParseExact(Convert.ToString(rdr["ENTRY_DATE"]), "dd/MM/yyyy HH:mm:ss", new CultureInfo("en-US"));

               IPDDoc.EntryParameter = en;
               IPDDoc.Department = dpt;
               IPDDoc.DepartmentUnit = oUnit;
               IPDDocs.Add(IPDDoc);
           }
           rdr.Close();
           return IPDDocs;
       }
       public IPDDoctor GetDoctorsDetails(string DocID)
       {
           string packageName = "PKG_NWMS_DOCTORS_VISIT.Get_Doctors_Details";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("DocID",OracleDbType.Varchar2,30,DocID,ParameterDirection.Input)
           };

           IPDDoctor oIPDDoc = new IPDDoctor();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               oIPDDoc.Name = (string)rdr["DoctorsName"];
               oIPDDoc.IPDVisitingFee = Convert.ToDouble(rdr["VisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["VisitingFee"]);
               oIPDDoc.DoctorsVisitingFee = Convert.ToDouble(rdr["DocsVisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["DocsVisitingFee"]);
           }
           rdr.Close();
           return oIPDDoc;
       }
       public List<InPatient> GetAdmittedAllPatList()
       {
           string packageName = "PKG_IPD.Get_Admitted_All_Pat_List";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
           return GetAdmittedAllPatList(packageName, parameterList);

       }
       public List<InPatient> GetAdmDateWisePatList(DateTime fromDate, DateTime toDate)
       {
           string packageName = "PKG_IPD.Get_Adm_Date_Wise_Pat_List";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("FromDate",OracleDbType.Date,20,fromDate,ParameterDirection.Input),
                new OracleParameter("ToDate",OracleDbType.Date,20,toDate,ParameterDirection.Input)
            };
           return GetAdmittedAllPatList(packageName, parameterList);
       }

       
       public List<InPatient> GetBedTransferDateWisePatList(DateTime fromDate, DateTime toDate)
       {
           string packageName = "PKG_IPD.Get_Bed_Trans_Pat_List";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("FromDate",OracleDbType.Date,20,fromDate,ParameterDirection.Input),
                new OracleParameter("ToDate",OracleDbType.Date,20,toDate,ParameterDirection.Input)
            };
           return GetAdmittedAllPatList(packageName, parameterList);

       }
       public List<InPatient> GetDischargeDateWisePatList(DateTime fromDate, DateTime toDate)
       {
           string packageName = "PKG_IPD.Get_Dis_Date_Wise_Pat_List";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("FromDate",OracleDbType.Date,20,fromDate,ParameterDirection.Input),
                new OracleParameter("ToDate",OracleDbType.Date,20,toDate,ParameterDirection.Input)
            };
           return GetAdmittedAllPatList(packageName, parameterList);

       }
       private List<InPatient> GetAdmittedAllPatList(string packageName, OracleParameter[] parameterList)
       {
           List<InPatient> inpList = new List<InPatient>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               InPatient inp = new InPatient();
               inp.Name = (string)rdr["PAT_NAME"];
               inp.HCN = (string)rdr["HCN"];
               inp.Sex = (string)rdr["SEX"];
               inp.RegistrationNo = (string)rdr["REG_ID"];
               inp.AgeFull = (string)rdr["AGE"];
               inp.StaffID = (string)rdr["STAFF_ID"];

               Bed bd = new Bed();
               bd.BedNo = (string)rdr["BED_NO"];
               bd.BedTitle = (string)rdr["BED_TITLE"];
               inp.Bed = bd;


               Room rm = new Room();
               rm.RoomID = Convert.ToInt16(rdr["ROOM_ID"]).ToString();
               rm.RoomTitle = (string)rdr["ROOM_TITLE"];
               rm.Floor = (string)rdr["FLOOR_NO"].ToString();
               inp.Room = rm;

               OPDPayment pay = new OPDPayment();
               //pay.TransactionNo = (string)rdr["trans_no"];
               pay.Amount = Convert.ToDecimal(rdr["AMOUNT"]);
               inp.Payment = pay;

               Department dpt = new Department();
               dpt.DepartmentID = (string)rdr["DEPT_ID"];
               dpt.DepartmentTitle = (string)rdr["DEPT_TITLE"];
               dpt.DepartmentUnitHead = !rdr.IsDBNull(12) ? (string)rdr["DEPT_HEAD_NAME"] : "";
               inp.Department = dpt;

               Doctor doc = new Doctor();
               doc.ID = (string)rdr["DOC_ID"];
             //  doc.Name = !rdr.IsDBNull(12) ? (string)rdr["Reff_Doc_name"] : ""; 
               inp.Doctor = doc;

               DepartmentUnit unt = new DepartmentUnit();
               unt.UnitId = (string)rdr["UNIT_ID"];
               unt.UnitTitle = (string)rdr["UNIT_TITLE"];
               inp.DepartmentUnit = unt;

               inp.Email = !rdr.IsDBNull(7) ? (string)rdr["Email"] : "";
               inp.CellPhone = (string)rdr["CELL_PHONE"];
               inp.Religion = (string)rdr["RELIGION"];
               inp.BloodGroup = !rdr.IsDBNull(7) ? (string)rdr["BLOOD_GRP"] : "";
               inp.FathersName = !rdr.IsDBNull(8) ? (string)rdr["FNAME"] : "";
               inp.MothersName = !rdr.IsDBNull(9) ? (string)rdr["MNAME"] : "";
               inp.Photo = (string)rdr["PHOTO_PATH"];
               inp.AdmissionDate = (DateTime)rdr["DT"];
               inp.BedTransferDateTime = (DateTime)rdr["ADM_DATE"];
               inp.dischargeFlag =Convert.ToChar(rdr["DISCHARGE_FLAG"]);
               inp.CurrentDietTitle = !rdr.IsDBNull(34)?(string)rdr["CurrentDiet"]:"";
               char var = inp.dischargeFlag;
               if (var.ToString() == "1")
               {
                   inp.DischargeDate = (DateTime)(rdr["DISCHARGE_DATE"]);
               }
               NurseStation nrsTn = new NurseStation();
               nrsTn.NurseStationID = (string)rdr["NURSE_STN_ID"];
               inp.NurseStation = nrsTn;
               inpList.Add(inp);

           }
           rdr.Close();
           return inpList;
        }
        //======================================================================//

  
    }
}
