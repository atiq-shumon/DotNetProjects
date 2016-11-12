using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.OPD.MODEL;
using AH.APPOPD.MODEL;
//using AH.PatReg.MODEL;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.DTMS.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


namespace AH.OPD.DAL
{
    public class OPDDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);
        //public Dictionary<string, string> GetCases()
        //{
                                                                               
        //    //Dictionary<string, string> caseObj = new Dictionary<string, string>();
        //    //caseObj.Add("01", "Diabetes");
        //    //caseObj.Add("02", "Aptites");
        //    //caseObj.Add("03", "Ulcer");
        //    //caseObj.Add("04", "Gastric");
        //    //caseObj.Add("05", "Pain in back");
        //    //return caseObj;
        //}

        #region GetPatDoc
        public List<Ticket> GetPatDoc(string docid)
        {
            string packageName = "AGH_OPD.pkg_OPD.GET_Pat_Doctor_List";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("DoctorID",OracleDbType.Varchar2,30,docid,ParameterDirection.Input)
             
            };
            List<Ticket> tktlist = new List<Ticket>();
            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Ticket tktObj = new Ticket();
                tktObj.TicketNo = (string)rdr["TicketNo"];

                Patient pat = new Patient();
                pat.HCN = (string)rdr["HCN"];
                pat.Name = (string)rdr["PatName"];
                tktObj.Patient = pat;
                tktObj.TicketStatus = (string)rdr["tkt_status"];          
                tktlist.Add(tktObj);
            }
            rdr.Close();
            return tktlist;
        }
        #endregion


        #region SaveOPDTicket
        public string SaveOPDTicket(Ticket tkt)
        {
            string packageName = "PKG_OPD.INSERT_OPD_TKT_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]
            {
               new OracleParameter("ptkt_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
               new OracleParameter("patID",OracleDbType.Varchar2,30,tkt.Patient.HCN,ParameterDirection.Input),

               new OracleParameter("Serial",OracleDbType.Varchar2,30,tkt.PatSerial,ParameterDirection.Input),
               new OracleParameter("staffID",OracleDbType.Varchar2,30,tkt.Patient.StaffID,ParameterDirection.Input),
               new OracleParameter("caseID",OracleDbType.Varchar2,6,tkt.Patient.CaseID,ParameterDirection.Input),
            
               new OracleParameter("tktType",OracleDbType.Varchar2,3,tkt.TicketType,ParameterDirection.Input),
               new OracleParameter("tktCat",OracleDbType.Varchar2,3,tkt.TicketCategory,ParameterDirection.Input),
               new OracleParameter("tktStat",OracleDbType.Varchar2,2,tkt.TicketStatus,ParameterDirection.Input),
               
               new OracleParameter("tktDept",OracleDbType.Varchar2,5,tkt.Patient.Department.DepartmentID,ParameterDirection.Input),
               new OracleParameter("tktUnit",OracleDbType.Varchar2,5,tkt.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
               new OracleParameter("tktdoctor",OracleDbType.Varchar2,20,tkt.Doctor.ID,ParameterDirection.Input),
               new OracleParameter("ageY",OracleDbType.Varchar2,3,tkt.PatientAge.Year,ParameterDirection.Input),
               new OracleParameter("ageM",OracleDbType.Varchar2,3,tkt.PatientAge.Month,ParameterDirection.Input),
               new OracleParameter("ageD",OracleDbType.Varchar2,3,tkt.PatientAge.Day,ParameterDirection.Input),
               new OracleParameter("ageH",OracleDbType.Varchar2,3,tkt.PatientAge.Hour,ParameterDirection.Input),
               new OracleParameter("validity",OracleDbType.Date,15,tkt.TicketValidity,ParameterDirection.Input),
               new OracleParameter("cPrinted",OracleDbType.Varchar2,3,tkt.CopyPrinted,ParameterDirection.Input),
               new OracleParameter("prnBy",OracleDbType.Varchar2,20,tkt.EntryParameter.EntryBy,ParameterDirection.Input),

               new OracleParameter("prevTkt",OracleDbType.Varchar2,30,tkt.PreviousTicketNo,ParameterDirection.Input),
               new OracleParameter("tktFee",OracleDbType.Decimal,10,tkt.PatientPayment.Amount,ParameterDirection.Input),
               new OracleParameter("consltFee",OracleDbType.Decimal,10,tkt.PatientPayment.ConsultantFee,ParameterDirection.Input),

               new OracleParameter("refdFee",OracleDbType.Decimal,10,tkt.PatientPayment.RefferedFee,ParameterDirection.Input),
               new OracleParameter("deptFee",OracleDbType.Decimal,10,tkt.PatientPayment.ReffDeptAmount,ParameterDirection.Input),
               new OracleParameter("disc",OracleDbType.Decimal,10,tkt.PatientPayment.Discount,ParameterDirection.Input),

               new OracleParameter("vat",OracleDbType.Decimal,10,tkt.PatientPayment.VAT,ParameterDirection.Input),
               new OracleParameter("P_ROOM_ID",OracleDbType.Varchar2,10,tkt.Room.RoomID,ParameterDirection.Input),
               new OracleParameter("P_APPNT_ID",OracleDbType.Varchar2,30,tkt.AppointmentID,ParameterDirection.Input),

               new OracleParameter("purp",  OracleDbType.Varchar2,10,tkt.PatientPayment.PurposeID,ParameterDirection.Input),
               new OracleParameter("payType",OracleDbType.Varchar2,2,tkt.PatientPayment.PaymentType,ParameterDirection.Input),
               new OracleParameter("NetAmt", OracleDbType.Decimal,10,tkt.PatientPayment.NetAmount,ParameterDirection.Input),
               new OracleParameter("p_payment_string", OracleDbType.Varchar2,100000,tkt.PatientPayment.PaymentString,ParameterDirection.Input),
               new OracleParameter("Nursing_STN",OracleDbType.Varchar2,30,tkt.NurseStationID,ParameterDirection.Input),

               new OracleParameter("eBy",OracleDbType.Varchar2,20,tkt.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("entryDate",OracleDbType.Date,20,tkt.EntryParameter.EntryDate,ParameterDirection.Input),

               new OracleParameter("comp",OracleDbType.Varchar2,2,tkt.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("loc", OracleDbType.Varchar2,2,tkt.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("mac",OracleDbType.Varchar2,20,tkt.EntryParameter.MachineID,ParameterDirection.Input)
             };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            string ticketNo = (string)(OracleString)prm.Value;
            return ticketNo;
        }
        #endregion

        #region VerifyTicketNo
        public string VerifyTicketNo(string tktno)
        {
            string packageName = "PKG_OPD.verify_ticket";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("VerificationNo",OracleDbType.Varchar2,250,null,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,tktno,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;
        }

        #endregion

        #region GetTicketWithPatNoTktNo
        public Ticket GetTickets(string patientHCN, string ticketNO)
        {
            Ticket tktObj = new Ticket(); ;
            string packageName = "pkg_OPD.GET_TKT_MASTER";
            OracleParameter[] paramList = new OracleParameter[] 
            { 
                 new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("PatNo",OracleDbType.Varchar2,30,patientHCN,ParameterDirection.Input),
                 new OracleParameter("tktNo",OracleDbType.Varchar2,30,ticketNO,ParameterDirection.Input)
             
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, paramList);

            while (rdr.Read())
            {          
                tktObj.TicketNo = !rdr.IsDBNull(0) ? (String)rdr[0] : "";

                Patient patObj = new Patient();
                patObj.HCN = !rdr.IsDBNull(1) ? (String)rdr[1] : "";
                patObj.Name = !rdr.IsDBNull(2) ? (String)rdr[2] : "";
                patObj.Sex = !rdr.IsDBNull(3) ? (String)rdr[3] : "";
                patObj.AgeFull = !rdr.IsDBNull(4) ? (String)rdr[4] : "";
                patObj.StaffID = !rdr.IsDBNull(5) ? (String)rdr[5] : "";
                patObj.CaseID = !rdr.IsDBNull(6) ? (String)rdr[6] : "";

                tktObj.TicketType = !rdr.IsDBNull(7) ? (String)rdr[7] : "";
                tktObj.TicketCategory = !rdr.IsDBNull(8) ? (String)rdr[8] : "";
                tktObj.TicketStatus = !rdr.IsDBNull(9) ? (String)rdr[9] : "";

                Department dept = new Department();
                dept.DepartmentID = !rdr.IsDBNull(10) ? (String)rdr[10] : "";
                patObj.Department = dept;

                DepartmentUnit du = new DepartmentUnit();
                du.UnitId = !rdr.IsDBNull(11) ? (String)rdr[11] : "";
                patObj.DepartmentUnit = du;

                Doctor doc = new Doctor();
                doc.Name = !rdr.IsDBNull(12) ? (String)rdr[12] : "";
                doc.Degree1 = !rdr.IsDBNull(13) ? (String)rdr[13] : "";
                doc.Degree2 = !rdr.IsDBNull(14) ? (String)rdr[14] : "";
                doc.Degree3 = !rdr.IsDBNull(15) ? (String)rdr[15] : "";
                doc.Degree4 = !rdr.IsDBNull(16) ? (String)rdr[16] : "";

                Room rm = new Room();
                rm.RoomID = !rdr.IsDBNull(17) ? (String)rdr[17] : "";
                doc.Room = rm;

                doc.AvailableDays = !rdr.IsDBNull(18) ? (String)rdr[18] : "";
                patObj.BloodGroup = !rdr.IsDBNull(19) ? (String)rdr[19] : "";
                tktObj.Patient = patObj;
                tktObj.Doctor = doc;
            }
            return tktObj;
        }
        #endregion

        #region GetTicket
        public Ticket GetTicket(string prescriptionTicketNO)
        {
            Ticket tktObj = new Ticket();
            //AH.Shared.MODEL.AccountsPayment = new AccountsPayment();
            string packageName = "pkg_OPD.GET_TKT_MASTER";
            OracleParameter[] paramList = new OracleParameter[]
            { 
                 new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("p_prescription_ticketNO",OracleDbType.Varchar2,30,prescriptionTicketNO,ParameterDirection.Input)   
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, paramList);
            if (rdr.Read())
            {
                //int parentId = row[PARENTID] != DBNull.Value ? int.Parse(row[PARENTID].ToString()) : 0;
                tktObj.TicketNo = rdr["TicketNo"] != DBNull.Value ? Convert.ToString(rdr["TicketNo"]) : "";

                //tktObj.TicketNo = !rdr.IsDBNull(Convert.ToInt32("TicketNo")) ? (string)rdr["TicketNo"] : "";

                Patient patObj = new Patient();
                patObj.Name = rdr["Patient_Name"] != DBNull.Value ? Convert.ToString(rdr["Patient_Name"]) : "";
                patObj.HCN = rdr["HCN"] != DBNull.Value ? Convert.ToString(rdr["HCN"]) : "";
                patObj.Sex = rdr["Sex"] != DBNull.Value ? Convert.ToString(rdr["Sex"]) : "";

                patObj.AgeFull = rdr["age"] != DBNull.Value ? Convert.ToString(rdr["age"]) : "";
                patObj.StaffID = rdr["Staff_Id"] != DBNull.Value ? Convert.ToString(rdr["Staff_Id"]) : "";
                patObj.CaseID = rdr["Disease_case"] != DBNull.Value ? Convert.ToString(rdr["Disease_case"]) : "";


                tktObj.TicketType = rdr["ticket_type"] != DBNull.Value ? Convert.ToString(rdr["ticket_type"]) : "";
                tktObj.TicketCategory = rdr["ticket_category"] != DBNull.Value ? Convert.ToString(rdr["ticket_category"]) : "";
                tktObj.TicketStatus = rdr["ticket_status"] != DBNull.Value ? Convert.ToString(rdr["ticket_status"]) : "";

                Department dept = new Department();
                dept.DepartmentID = rdr["dept_id"] != DBNull.Value ? Convert.ToString(rdr["dept_id"]) : "";
                dept.DepartmentTitle = rdr["Department"] != DBNull.Value ? Convert.ToString(rdr["Department"]) : ""; //(string)rdr["Department"];
                patObj.Department = dept;

                DepartmentUnit unit = new DepartmentUnit();
                unit.UnitId = rdr["unit_id"] != DBNull.Value ? Convert.ToString(rdr["unit_id"]) : "";
                unit.UnitTitle = rdr["Unit"] != DBNull.Value ? Convert.ToString(rdr["Unit"]) : "";
                patObj.DepartmentUnit = unit;

                Doctor doc = new Doctor();
                doc.ID = rdr["doc_id"] != DBNull.Value ? Convert.ToString(rdr["doc_id"]) : "";
                doc.Name = rdr["Doctor"] != DBNull.Value ? Convert.ToString(rdr["Doctor"]) : "";
                doc.Degree1 = rdr["DegreeLine1"] != DBNull.Value ? Convert.ToString(rdr["DegreeLine1"]) : "";
                doc.Degree2 = rdr["DegreeLine2"] != DBNull.Value ? Convert.ToString(rdr["DegreeLine2"]) : "";
                doc.Degree3 = rdr["DegreeLine3"] != DBNull.Value ? Convert.ToString(rdr["DegreeLine3"]) : "";
                doc.Degree4 = rdr["DegreeLine4"] != DBNull.Value ? Convert.ToString(rdr["DegreeLine4"]) : "";
                doc.AvailableDays = rdr["available_days"] != DBNull.Value ? Convert.ToString(rdr["available_days"]) : "";

                Room room = new Room();
                room.RoomID = rdr["RoomID"] != DBNull.Value ? Convert.ToString(rdr["RoomID"]) : "";
                doc.Room = room;

                
                patObj.BloodGroup = rdr["Blood"] != DBNull.Value ? Convert.ToString(rdr["Blood"]) : "";
                //tktObj.TicketValidity = Convert.ToDateTime((DateTime)rdr[20]);
                //tktObj.CopyPrinted = !rdr.IsDBNull(21) ? (String)rdr[21] : "";
                //tktObj.CopyPrintedBY = !rdr.IsDBNull(22) ? (String)rdr[22] : "";
                //tktObj.PreviousTicketNo = !rdr.IsDBNull(23) ? (String)rdr[23] : "";
                //tktObj.TicketFee = Convert.ToDouble((Double)rdr[24]) ;

                patObj.DOB = (DateTime)rdr["dob"];
                patObj.Present_H_R_B = rdr["Home"] != DBNull.Value ? Convert.ToString(rdr["Home"]) : "";

                patObj.PresentThana = rdr["Thana"] != DBNull.Value ? Convert.ToString(rdr["Thana"]) : "";
                patObj.PresentDistrict = rdr["District"] != DBNull.Value ? Convert.ToString(rdr["District"]) : "";
                //patObj.Department.DepartmentID = rdr["dept_id"] != DBNull.Value ? Convert.ToString(rdr["dept_id"]) : ""; //(string)rdr["dept_id"];

                Age age = new Age();
                age.Year = int.Parse(rdr["age_y"].ToString());
                age.Month = int.Parse(rdr["age_m"].ToString());
                age.Day = int.Parse(rdr["age_d"].ToString());
                age.Hour = int.Parse(rdr["age_h"].ToString());

                OPDDoctorCallQ OCallQ = new OPDDoctorCallQ();
                OCallQ.Height = rdr["HEIGHT"] != DBNull.Value ? Convert.ToString(rdr["HEIGHT"]) : "";
                OCallQ.Weight = rdr["WEIGHT"] != DBNull.Value ? Convert.ToString(rdr["WEIGHT"]) : "";
                OCallQ.Bp = rdr["BP"] != DBNull.Value ? Convert.ToString(rdr["BP"]) : "";
                OCallQ.Temparature = rdr["TEMPARATURE"] != DBNull.Value ? Convert.ToString(rdr["TEMPARATURE"]) : "";
                OCallQ.SPOTWO = Convert.ToString(rdr["SPOTWO"] == DBNull.Value ? 0 : (decimal)rdr["SPOTWO"]);
                OCallQ.OFC = Convert.ToString(rdr["OFC"] == DBNull.Value ? 0 : (decimal)rdr["OFC"]);

                OCallQ.Allergy = (rdr["ALLERGY"] == DBNull.Value ? "0" : (string)rdr["ALLERGY"]);
                OCallQ.AllergyText = (rdr["ALLERGY_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ALLERGY_TEXT"]);
                OCallQ.Asthma = (rdr["ASTHMA"] == DBNull.Value ? "0" : (string)rdr["ASTHMA"]);
                OCallQ.AsthmaText = (rdr["ASTHMA_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ASTHMA_TEXT"]);
                OCallQ.Diabetes = (rdr["DIABETESMALLITUS"] == DBNull.Value ? "0" : (string)rdr["DIABETESMALLITUS"]);
                OCallQ.DiabetesText = (rdr["DIABETESMALLITUS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["DIABETESMALLITUS_TEXT"]);
                OCallQ.Pressure = (rdr["HYPERTENSION"] == DBNull.Value ? "0" : (string)rdr["HYPERTENSION"]);
                OCallQ.PressureText = (rdr["HYPERTENSION_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["HYPERTENSION_TEXT"]);
                OCallQ.HeartDisease = (rdr["HEART_DISEASE"] == DBNull.Value ? "0" : (string)rdr["HEART_DISEASE"]);
                OCallQ.HeartDiseaseText = (rdr["HEART_DISEASE_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["HEART_DISEASE_TEXT"]);
                OCallQ.KidneyDisease = (rdr["KIDNEY_DISEASE"] == DBNull.Value ? "0" : (string)rdr["KIDNEY_DISEASE"]);
                OCallQ.KidneyDiseaseText = (rdr["KIDNEY_DISEASE_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["KIDNEY_DISEASE_TEXT"]);
                OCallQ.Others = (rdr["OTHERS"] == DBNull.Value ? "0" : (string)rdr["OTHERS"]);
                OCallQ.OthersText = (rdr["OTHERS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["OTHERS_TEXT"]);

                OCallQ.PastMedicalHistory = (rdr["MEDICAL_HIS"] == DBNull.Value ? "0" : (string)rdr["MEDICAL_HIS"]);
                OCallQ.PastMedicalHistoryText = (rdr["MEDICAL_HIS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["MEDICAL_HIS_TEXT"]);
                OCallQ.PastSurgicalHistory = (rdr["SURGICAL_HIS"] == DBNull.Value ? "0" : (string)rdr["SURGICAL_HIS"]);
                OCallQ.PastSurgicalHistoryText = (rdr["SURGICAL_HIS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["SURGICAL_HIS_TEXT"]);
                OCallQ.FamilyHistory = (rdr["FAMILY_HIS"] == DBNull.Value ? "0" : (string)rdr["FAMILY_HIS"]);
                OCallQ.FamilyHistoryText = (rdr["FAMILY_HIS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["FAMILY_HIS_TEXT"]);

                PaediatricHistory OPaedHis = new PaediatricHistory();
                OPaedHis.Antenatal = (rdr["ANTE_NATAL_VALUE"] == DBNull.Value ? "0" : (string)rdr["ANTE_NATAL_VALUE"]);
                OPaedHis.AntenatalText = (rdr["ANTE_NATAL_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ANTE_NATAL_TEXT"]);

                OPaedHis.Natal = (rdr["NATAL_VALUE"] == DBNull.Value ? "0" : (string)rdr["NATAL_VALUE"]);
                OPaedHis.NatalText = (rdr["NATAL_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["NATAL_TEXT"]);

                OPaedHis.PostNatal = (rdr["POST_NATAL_VALUE"] == DBNull.Value ? "0" : (string)rdr["POST_NATAL_VALUE"]);
                OPaedHis.PostNatalText = (rdr["POST_NATAL_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["POST_NATAL_TEXT"]);

                OPaedHis.ExclusiveFeed = (rdr["X_FEED_PERIOD_VALUE"] == DBNull.Value ? "0" : (string)rdr["X_FEED_PERIOD_VALUE"]);
                OPaedHis.ExclusiveFeedText = (rdr["X_FEED_PERIOD_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["X_FEED_PERIOD_TEXT"]);

                OPaedHis.CompFeed = (rdr["COMP_FEED_VALUE"] == DBNull.Value ? "0" : (string)rdr["COMP_FEED_VALUE"]);
                OPaedHis.CompFeedText = (rdr["COMP_FEED_START_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["COMP_FEED_START_TEXT"]);
                OPaedHis.CompFeedWText = (rdr["COMP_FEED_START_WTEXT"] == DBNull.Value ? string.Empty : (string)rdr["COMP_FEED_START_WTEXT"]);

                OPaedHis.PresentFeed = (rdr["P_FEED_PERIOD_VALUE"] == DBNull.Value ? "0" : (string)rdr["P_FEED_PERIOD_VALUE"]);
                OPaedHis.PresentFeedText = (rdr["P_FEED_PERIOD_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["P_FEED_PERIOD_TEXT"]);

                OPaedHis.MileStoneOfDev = (rdr["P_MLST_VALUE"] == DBNull.Value ? "0" : (string)rdr["P_MLST_VALUE"]);
                OPaedHis.MileStoneOfDevText = (rdr["P_MLST_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["P_MLST_TEXT"]);

                OPaedHis.Immunization = (rdr["P_IMM_VALUE"] == DBNull.Value ? "0" : (string)rdr["P_IMM_VALUE"]);
                OPaedHis.ImmunizationText = (rdr["P_IMM_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["P_IMM_TEXT"]);

                OPaedHis.SocioEcoHistory = (rdr["P_SCO_VALUE"] == DBNull.Value ? "0" : (string)rdr["P_SCO_VALUE"]);
                OPaedHis.SocioEcoHistoryText = (rdr["P_SCO_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["P_SCO_TEXT"]);

                GynHistory OGynHistory = new GynHistory();
                OGynHistory.Gyn = (rdr["GYN_VALUE"] == DBNull.Value ? "0" : (string)rdr["GYN_VALUE"]);
                OGynHistory.GynText = (rdr["GYN_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["GYN_TEXT"]);

                OGynHistory.Obs = (rdr["OBS_VALUE"] == DBNull.Value ? "0" : (string)rdr["OBS_VALUE"]);
                OGynHistory.ObsText = (rdr["OBS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["OBS_TEXT"]);


                tktObj.GynHistory = OGynHistory;
                tktObj.PaediatricHistory = OPaedHis;
                tktObj.OPDCallQ = OCallQ;
                tktObj.Patient = patObj;
                tktObj.Doctor = doc;
                tktObj.TicketDepartment = dept;
                tktObj.PatientAge = age;
            }
            return tktObj;
        }
        #endregion

#region GetDiseaseCase
        public List<DiseaseCase> GetDiseaseCase()
        {
            string packageName = "PKG_OPD.GET_DISEASE_CASE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDiseaseCaseSetup(packageName, parameterList);
        }

        public List<DiseaseCase> GetDiseaseCase(string caseid)
        {
            string packageName = "PKG_OPD.GET_DISEASE_CASE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_case_id",OracleDbType.Varchar2,4,caseid,ParameterDirection.Input)
            };
            return GetDiseaseCaseSetup(packageName, parameterList);

        }
        private List<DiseaseCase> GetDiseaseCaseSetup(string packageName, OracleParameter[] parameterList)
        {
            List<DiseaseCase> depts = new List<DiseaseCase>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                DiseaseCase deptobj = new DiseaseCase();
                deptobj.DiseaseGrpID = (string)rdr["DIS_GRP_ID"].ToString();
                deptobj.DiseaseGrpTitle = (string)rdr["DIS_GRP_Title"].ToString();
                deptobj.CaseID = (string)rdr["CASE_ID"].ToString();
                deptobj.CaseTitle = (string)rdr["CASE_TITLE"];
                deptobj.CaseTitleBeng = (string)rdr["CASE_TITLE_BENG"];

                Department dept = new Department();
                dept.DepartmentID = rdr["DEPT_ID"] != DBNull.Value ? Convert.ToString(rdr["DEPT_ID"]) : "";
                dept.DepartmentTitle = rdr["Department"] != DBNull.Value ? Convert.ToString(rdr["Department"]) : "";
                deptobj.dept = dept;

                DepartmentUnit unit = new DepartmentUnit();
                unit.UnitId = rdr["UNIT_ID"] != DBNull.Value ? Convert.ToString(rdr["UNIT_ID"]) : "";
                unit.UnitTitle = rdr["Unit"] != DBNull.Value ? Convert.ToString(rdr["Unit"]) : "";
                deptobj.deptUnit = unit;

                deptobj.ShownCheckList = (string)rdr["IS_SHOWN_CHK_LIST"];
                deptobj.Remarks = rdr["REMARKS"] != DBNull.Value ? Convert.ToString(rdr["REMARKS"]) : "";
                depts.Add(deptobj);
            }
            rdr.Close();
            return depts;

        }
#endregion

#region SaveDisease
        public short SaveDisease(DiseaseCase tdis)
        {
            string packageName = "PKG_OPD.INSERT_DISEASE_CASE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Dis_Grp_ID",OracleDbType.Varchar2,4,tdis.DiseaseGrpID,ParameterDirection.Input),
                new OracleParameter("CaseTitle",OracleDbType.Varchar2,70,tdis.CaseTitle,ParameterDirection.Input),
                new OracleParameter("CaseTitleBeng",OracleDbType.Varchar2,200,tdis.CaseTitleBeng,ParameterDirection.Input),
                new OracleParameter("DEPT_ID",OracleDbType.Varchar2,5,tdis.dept.DepartmentID,ParameterDirection.Input),
                new OracleParameter("UNIT_ID",OracleDbType.Varchar2,5,tdis.deptUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("IS_SHOWN_CHK_LIST  ",OracleDbType.Varchar2,1,tdis.ShownCheckList,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tdis.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tdis.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tdis.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tdis.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tdis.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
#endregion

#region UpdateDisease
        public short UpdateDisease(DiseaseCase tDept)
        {
            string packageName = "PKG_OPD.UPDATE_DISEASE_CASE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Dis_Grp_ID",OracleDbType.Varchar2,4,tDept.DiseaseGrpID,ParameterDirection.Input),
                new OracleParameter("CaseID",OracleDbType.Varchar2,70,tDept.CaseID,ParameterDirection.Input),
                new OracleParameter("CaseTitle",OracleDbType.Varchar2,70,tDept.CaseTitle,ParameterDirection.Input),
                new OracleParameter("CaseTitleBeng",OracleDbType.Varchar2,200,tDept.CaseTitleBeng,ParameterDirection.Input),
                new OracleParameter("DEPT_ID",OracleDbType.Varchar2,5,tDept.dept.DepartmentID,ParameterDirection.Input),
                new OracleParameter("UNIT_ID",OracleDbType.Varchar2,5,tDept.deptUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("IS_SHOWN_CHK_LIST  ",OracleDbType.Varchar2,1,tDept.ShownCheckList,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tDept.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tDept.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tDept.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tDept.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tDept.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
#endregion 

#region SavePrescription
        public string SavePrescription(Prescription prs)
        {
            string packageName = "PKG_OPD.INSERT_OPD_Prescription";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,prs.TicketNo,ParameterDirection.Input),
                new OracleParameter("TicketType",OracleDbType.Varchar2,2,prs.TicketType,ParameterDirection.Input),
                new OracleParameter("Package",OracleDbType.Varchar2,30,prs.PackageName,ParameterDirection.Input),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,prs.Patient.HCN,ParameterDirection.Input),
                new OracleParameter("Staff",OracleDbType.Varchar2,30,prs.Patient.StaffID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,prs.TicketDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,prs.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorId",OracleDbType.Varchar2,30,prs.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("ageY",OracleDbType.Varchar2,3,prs.PatientAge.Year,ParameterDirection.Input),
                new OracleParameter("ageM",OracleDbType.Varchar2,3,prs.PatientAge.Month,ParameterDirection.Input),
                new OracleParameter("ageD",OracleDbType.Varchar2,3,prs.PatientAge.Day,ParameterDirection.Input),
                new OracleParameter("ageH",OracleDbType.Varchar2,3,prs.PatientAge.Hour,ParameterDirection.Input),
                new OracleParameter("Height",OracleDbType.Varchar2,5,prs.Height,ParameterDirection.Input),
                new OracleParameter("Weight",OracleDbType.Varchar2,6,prs.Weight,ParameterDirection.Input),
                new OracleParameter("BloodPulse",OracleDbType.Varchar2,7,prs.Bp,ParameterDirection.Input),
                new OracleParameter("Temparature",OracleDbType.Varchar2,5,prs.Temparature,ParameterDirection.Input),
                //new OracleParameter("VisitDate",OracleDbType.Date,prs.VisitDate,ParameterDirection.Input),
                new OracleParameter("NextVisitDate", OracleDbType.Date,30,prs.NextVisitDate,ParameterDirection.Input),
                new OracleParameter("NextVisitAfterDay",OracleDbType.Int32,prs.NextVisitAfterDay,ParameterDirection.Input),
                new OracleParameter("NextVisitAfterMonth",OracleDbType.Int32,prs.NextVisitAfterMonth,ParameterDirection.Input),
                new OracleParameter("NextVisitAfterYear",OracleDbType.Int32,prs.NextVisitAfterYear,ParameterDirection.Input),
                new OracleParameter("RfDept_id",OracleDbType.Varchar2,4,prs.RefDeptID.DepartmentID,ParameterDirection.Input), 
                new OracleParameter("RfUnit_id",OracleDbType.Varchar2,3,prs.RefUnitID.UnitId,ParameterDirection.Input), 
                new OracleParameter("RfDoctorID",OracleDbType.Varchar2,30,prs.RefDocID.ID,ParameterDirection.Input),
                new OracleParameter("Advice",OracleDbType.Varchar2,4000,prs.Advice,ParameterDirection.Input),
                new OracleParameter("tests",OracleDbType.Varchar2,4000,prs.CollTests,ParameterDirection.Input),
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,prs.Medicine,ParameterDirection.Input),
                new OracleParameter("complaints",OracleDbType.Varchar2,4000,prs.Complaints,ParameterDirection.Input),
                new OracleParameter("OtherComplaints",OracleDbType.Varchar2,4000,prs.OtherComplaints,ParameterDirection.Input),
                new OracleParameter("clinical_Findings",OracleDbType.Varchar2,4000,prs.ClinicalFindings,ParameterDirection.Input),
                new OracleParameter("clinical_diagnosis",OracleDbType.Varchar2,4000,prs.ClinicalDiagnosis,ParameterDirection.Input),
                new OracleParameter("comorbidIllness",OracleDbType.Varchar2,4000,prs.comorbidIllness,ParameterDirection.Input),
                new OracleParameter("Paediatric_His",OracleDbType.Varchar2,4000,prs.paediatricHis,ParameterDirection.Input),
                new OracleParameter("Gyn_His",OracleDbType.Varchar2,4000,prs.GynHis,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,prs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,prs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,prs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,prs.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[2], parameterList[3] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value + "~" + prm[2].Value;
            else return "0";
        }
#endregion

#region EditPrescription
        public string EditPrescription(Prescription prs)
        {
            string packageName = "PKG_OPD.Edit_OPD_Prescription";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,prs.TicketNo,ParameterDirection.Input),
                new OracleParameter("TicketType",OracleDbType.Varchar2,2,prs.TicketType,ParameterDirection.Input),
                new OracleParameter("Package",OracleDbType.Varchar2,30,prs.PackageName,ParameterDirection.Input),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,prs.Patient.HCN,ParameterDirection.Input),
                new OracleParameter("Staff",OracleDbType.Varchar2,30,prs.Patient.StaffID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,prs.TicketDepartment.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,prs.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorId",OracleDbType.Varchar2,30,prs.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("ageY",OracleDbType.Varchar2,3,prs.PatientAge.Year,ParameterDirection.Input),
                new OracleParameter("ageM",OracleDbType.Varchar2,3,prs.PatientAge.Month,ParameterDirection.Input),
                new OracleParameter("ageD",OracleDbType.Varchar2,3,prs.PatientAge.Day,ParameterDirection.Input),
                new OracleParameter("ageH",OracleDbType.Varchar2,3,prs.PatientAge.Hour,ParameterDirection.Input),
                new OracleParameter("Height",OracleDbType.Varchar2,5,prs.Height,ParameterDirection.Input),
                new OracleParameter("Weight",OracleDbType.Varchar2,6,prs.Weight,ParameterDirection.Input),
                new OracleParameter("BloodPulse",OracleDbType.Varchar2,7,prs.Bp,ParameterDirection.Input),
                new OracleParameter("Temparature",OracleDbType.Varchar2,5,prs.Temparature,ParameterDirection.Input),
                new OracleParameter("NextVisitDate", OracleDbType.Date,30,prs.NextVisitDate,ParameterDirection.Input),
                new OracleParameter("NextVisitAfterDay",OracleDbType.Int32,prs.NextVisitAfterDay,ParameterDirection.Input),
                new OracleParameter("NextVisitAfterMonth",OracleDbType.Int32,prs.NextVisitAfterMonth,ParameterDirection.Input),
                new OracleParameter("NextVisitAfterYear",OracleDbType.Int32,prs.NextVisitAfterYear,ParameterDirection.Input),
                new OracleParameter("RfDept_id",OracleDbType.Varchar2,4,prs.RefDeptID.DepartmentID,ParameterDirection.Input), 
                new OracleParameter("RfUnit_id",OracleDbType.Varchar2,3,prs.RefUnitID.UnitId,ParameterDirection.Input), 
                new OracleParameter("RfDoctorID",OracleDbType.Varchar2,30,prs.RefDocID.ID,ParameterDirection.Input),
                new OracleParameter("Advice",OracleDbType.Varchar2,4000,prs.Advice,ParameterDirection.Input),
                new OracleParameter("tests",OracleDbType.Varchar2,4000,prs.CollTests,ParameterDirection.Input),
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,prs.Medicine,ParameterDirection.Input),
                new OracleParameter("complaints",OracleDbType.Varchar2,4000,prs.Complaints,ParameterDirection.Input),
                new OracleParameter("OtherComplaints",OracleDbType.Varchar2,4000,prs.OtherComplaints,ParameterDirection.Input),
                new OracleParameter("clinical_Findings",OracleDbType.Varchar2,4000,prs.ClinicalFindings,ParameterDirection.Input),
                new OracleParameter("clinical_diagnosis",OracleDbType.Varchar2,4000,prs.ClinicalDiagnosis,ParameterDirection.Input),
                new OracleParameter("comorbidIllness",OracleDbType.Varchar2,4000,prs.comorbidIllness,ParameterDirection.Input),
                new OracleParameter("Paediatric_His",OracleDbType.Varchar2,4000,prs.paediatricHis,ParameterDirection.Input),
                new OracleParameter("Gyn_His",OracleDbType.Varchar2,4000,prs.GynHis,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,prs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,prs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,prs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,prs.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[2], parameterList[3] };

            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value + "~" + prm[2].Value;
            else return "0";
        }
#endregion

#region GetPrescriptionForEdit
        public Prescription GetPrescriptionForEdit(string tkt_no)
        {
            string packageName = "PKG_OPD.GET_PRESCRIPTION_For_Edit";
            Prescription prsE = new Prescription();
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,tkt_no,ParameterDirection.Input)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                prsE.Complaints = (rdr["COMPLAINTDetails"] == DBNull.Value ? string.Empty : (string)rdr["COMPLAINTDetails"]);
                prsE.ClinicalFindings = (rdr["CFDETAILS"] == DBNull.Value ? string.Empty : (string)rdr["CFDETAILS"]);
                prsE.ClinicalDiagnosis = (rdr["DIAGNOSISDetails"] == DBNull.Value ? string.Empty : (string)rdr["DIAGNOSISDetails"]);
                prsE.CollTests = (rdr["TESTDETAILS"] == DBNull.Value ? string.Empty : (string)rdr["TESTDETAILS"]);
                prsE.Advice = (rdr["ADVICEDetails"] == DBNull.Value ? string.Empty : (string)rdr["ADVICEDetails"]);
                prsE.Medicine = (rdr["DrugsDetails"] == DBNull.Value ? string.Empty : (string)rdr["DrugsDetails"]);
              //  prsE.comorbidIllness = (rdr["Comorbid_Illness"] == DBNull.Value ? string.Empty : (string)rdr["Comorbid_Illness"]);
               // prsE.paediatricHis = (rdr["Paediatric_History"] == DBNull.Value ? string.Empty : (string)rdr["Paediatric_History"]);
                prsE.Refered = (rdr["Refered"] == DBNull.Value ? string.Empty : (string)rdr["Refered"]);
            }
            rdr.Close();
            return prsE;
        }
#endregion GetPrescriptionForEdit

        #region GetPrescriptionTests
        public List<TestFee> GetPrescriptionTests(string ticketno, string feecat)
        {
            string packageName = "PKG_OPD.GET_PRESCRIPTION_TESTS";
            OracleParameter[] parameterList = new OracleParameter[] 
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,ticketno,ParameterDirection.Input),
                new OracleParameter("FeeCategory",OracleDbType.Varchar2,2,feecat,ParameterDirection.Input)
            };
            return PrescriptionTests(packageName, parameterList);
        }

        public List<TestFee> GetPrescriptionTests(string ticketno, string feecat,string status)
        {
            string packageName = "PKG_OPD.GET_PRESCRIPTION_TESTS";
            OracleParameter[] parameterList = new OracleParameter[] 
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,ticketno,ParameterDirection.Input),
                new OracleParameter("FeeCategory",OracleDbType.Varchar2,2,feecat,ParameterDirection.Input),
                new OracleParameter("status",OracleDbType.Varchar2,2,status,ParameterDirection.Input)
            };
            return PrescriptionTests(packageName, parameterList);
        }

        private List<TestFee> PrescriptionTests(string packageName, OracleParameter[] parameterList)
        {
            List<TestFee> tfee = new List<TestFee>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestFee tf = new TestFee();
                TestSub ts = new TestSub();
                tf.Fee = decimal.Parse(rdr["FEE"].ToString());
                tf.DeptFee = decimal.Parse(rdr["DEPT_AMT"].ToString());
                tf.RefdFee = decimal.Parse(rdr["REFF_DEPT_AMT"].ToString());
                tf.DoctorFee = decimal.Parse(rdr["REFF_DOC_AMT"].ToString());
                tf.Discount = decimal.Parse(rdr["DISC"].ToString());
                
                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr["DEPT_ID"];
                dpt.DepartmentTitle = (string)rdr["Department"];
                ts.TestDepartment = dpt;

                TestGroup tg = new TestGroup();
                tg.GroupId = (string)rdr["GROUP_ID"];
                tg.GroupTitle = (string)rdr["GroupName"];
                ts.TestGroup = tg;

                ts.TestMainID = (string)rdr["TEST_MAIN_ID"];
                ts.TestMainTitle = (string)rdr["TestMain"];
                ts.PanelID = (string)rdr["pnl_id"].ToString();
             
                LabTechnologist lt = new LabTechnologist();
                lt.ID = "0";

                ts.TestSubID = (string)rdr["TEST_DET_ID"];
                ts.TestSubTitle = (string)rdr["Details"];
                ts.Technologist = lt;
                FeeCategory ofeecat = new FeeCategory();
                ofeecat.FeeCategoryID = (string)rdr["FEE_CAT_ID"].ToString();
                ofeecat.FeeCategoryTitle = (string)rdr["CAT_TITLE"].ToString();
                tf.FeeCategory = ofeecat;
                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = (string)rdr["RPT_GRP_ID"];
               
                ts.ReportGroup = rpt;
                SpecimenCollectionRoom rm = new SpecimenCollectionRoom();
                rm.RoomID = (string)rdr["SPC_COLL_ROOM"];
                rm.RoomTitle = rdr["SpcRoomTitle"].ToString();
                ts.SpecimenCollectionRoom = rm;
                LabRoom oLabRoom = new LabRoom();
                oLabRoom.RoomID = (string)rdr["LAB_ROOM"];
                oLabRoom.RoomTitle = rdr["RoomTitle"].ToString();
                ts.LabRoom = oLabRoom;
                tf.TestSub = ts;

                EntryParameter Oen = new EntryParameter();
                Oen.Active = (string)rdr["ACTIVE"];

                tf.EParameter = Oen;
                tfee.Add(tf);
            }
            rdr.Close();
            return tfee;

        }
        #endregion

        #region GetPrescriptionList
        public List<Ticket> GetPrescriptionList(string docid)
        {
            string packageName = "pkg_OPD.GET_TICKETLIST";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("DoctorID",OracleDbType.Varchar2,30,docid,ParameterDirection.Input)
             
            };
            List<Ticket> tktlist = new List<Ticket>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Ticket tktObj = new Ticket();
                tktObj.TicketNo = (string)rdr[0];
                Patient pat = new Patient();
                pat.HCN = (string)rdr[1];
                pat.Name = (string)rdr[2];
                tktObj.TicketStatus = (string)rdr[3];
                tktObj.Patient = pat; 
                tktlist.Add(tktObj);
            }
            rdr.Close();
            return tktlist;

        }
        #endregion

#region ClinicalFindingsNew(09/07/15)
        public short SaveClinicalFindingsGrp(ClinicalFindingsGroup cfGrp)
        {
            string packageName = "PKG_OPD.INSERT_CLINICAL_FINDING_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Cf_Grp_Title",OracleDbType.Varchar2,70,cfGrp.CfGrpTitle,ParameterDirection.Input),
                new OracleParameter("Cf_Grp_Title_Beng",OracleDbType.Varchar2,200,cfGrp.CfGrpTitleBeng,ParameterDirection.Input),
                new OracleParameter("Cf_Grp_Category",OracleDbType.Varchar2,1,cfGrp.CfGrpCategory,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,cfGrp.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,cfGrp.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cfGrp.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cfGrp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cfGrp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cfGrp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cfGrp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<ClinicalFindingsGroup> GetClinicalFindingsGroups()
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDINGS_GRPS";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) };
            return GetCfGrp(packageName, parameterList);
        }

        public List<ClinicalFindingsGroup> GetClinicalFindingsGroup(string cfGrpTitle)
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDINGS_GRP";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("CfGrpTitle",OracleDbType.Varchar2,70,cfGrpTitle,ParameterDirection.Input)
            };
            return GetCfGrp(packageName, parameterList);
        }

        private List<ClinicalFindingsGroup> GetCfGrp(string packageName, OracleParameter[] parameterList)
        {
            List<ClinicalFindingsGroup> cfGrp = new List<ClinicalFindingsGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ClinicalFindingsGroup OcfGrp = new ClinicalFindingsGroup();
                OcfGrp.CfGrpID = (string)rdr[0];
                OcfGrp.CfGrpTitle = (string)rdr[1];
                OcfGrp.CfGrpTitleBeng = (string)rdr[2];
                OcfGrp.CfGrpCategory = (string)rdr[3];

                Department odept = new Department();
                odept.DepartmentID = !rdr.IsDBNull(4) ? (string)rdr[4] : "";
                odept.DepartmentTitle = !rdr.IsDBNull(5) ? (string)rdr[5] : "";
                OcfGrp.Department = odept;

                DepartmentUnit deptUnit = new DepartmentUnit();
                deptUnit.UnitId = !rdr.IsDBNull(6) ? (string)rdr[6] : "";
                deptUnit.UnitTitle = !rdr.IsDBNull(7) ? (string)rdr[7] : "";
                OcfGrp.DepartmentUnit = deptUnit;

                OcfGrp.Remarks = !rdr.IsDBNull(8) ? (string)rdr[8] : "";
                cfGrp.Add(OcfGrp);
            }
            rdr.Close();
            return cfGrp;
        }

        public short UpdateClinicalFindingsGrp(ClinicalFindingsGroup cfGrp)
        {
            string packageName = "PKG_OPD.UPDATE_CLINICAL_FINDING_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Cf_Grp_ID",OracleDbType.Varchar2,70,cfGrp.CfGrpID,ParameterDirection.Input),
                new OracleParameter("Cf_Grp_Title",OracleDbType.Varchar2,70,cfGrp.CfGrpTitle,ParameterDirection.Input),
                new OracleParameter("Cf_Grp_Title_Beng",OracleDbType.Varchar2,200,cfGrp.CfGrpTitleBeng,ParameterDirection.Input),
                new OracleParameter("Cf_Grp_Category",OracleDbType.Varchar2,1,cfGrp.CfGrpCategory,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,cfGrp.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,cfGrp.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cfGrp.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cfGrp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cfGrp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cfGrp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cfGrp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<ClinicalFindingsGroup> GetClinicalFindingsGroup()
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_Clinical_Findings_grp_Dict";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<ClinicalFindingsGroup> oCfGrps = new List<ClinicalFindingsGroup>();
            while (rdr.Read())
            {
                ClinicalFindingsGroup oCfGrp = new ClinicalFindingsGroup();
                oCfGrp.CfGrpID = (String)rdr["CF_GRP_ID"];
                oCfGrp.CfGrpTitle = (String)rdr["CF_GRP_TITLE"];
                oCfGrps.Add(oCfGrp);
            }
            rdr.Close();
            return oCfGrps;
        }

        public short SaveClinicalFindings(ClinicalFindings cf)
        {
            string packageName = "PKG_OPD.INSERT_CLINICAL_FINDING";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Cf_Grp_ID",OracleDbType.Varchar2,2,cf.FindingsGrpID,ParameterDirection.Input),
                new OracleParameter("Cf_Parent_ID",OracleDbType.Varchar2,4,cf.FindingsParentID,ParameterDirection.Input),
                new OracleParameter("Cf_Title",OracleDbType.Varchar2,70,cf.FindingsTitle,ParameterDirection.Input),
                new OracleParameter("Cf_Title_Beng",OracleDbType.Varchar2,200,cf.FindingsTitleBeng,ParameterDirection.Input), 
                new OracleParameter("Cf_Level",OracleDbType.Varchar2,10,cf.FindingsLevel,ParameterDirection.Input), 
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cf.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cf.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cf.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cf.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cf.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public List<ClinicalFindings> GetClinicalFindings()
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDINGS";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) };
            return GetCf(packageName, parameterList);
        }

        public List<ClinicalFindings> GetClinicalFinding(string cfTitle)
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("CfTitle",OracleDbType.Varchar2,70,cfTitle,ParameterDirection.Input)
            };
            return GetCf(packageName, parameterList);
        }
        public List<ClinicalFindings> GetClinicalFindingByGroup(string cfGrpID)
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDING_BYGROUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("cfGrpID",OracleDbType.Varchar2,70,cfGrpID,ParameterDirection.Input)
            };
            return GetCf(packageName, parameterList);
        }
        public List<ClinicalFindings> GetClinicalFindingByGroupNParent(string cfGrpID, string cfParentID)
        {
            string packageName = "PKG_OPD.GET_CF_BY_GROUP_PARENT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("cfGrpID",OracleDbType.Varchar2,70,cfGrpID,ParameterDirection.Input),
                new OracleParameter("cfParentID",OracleDbType.Varchar2,70,cfParentID,ParameterDirection.Input)
            };
            return GetCf(packageName, parameterList);
        }

        private List<ClinicalFindings> GetCf(string packageName, OracleParameter[] parameterList)
        {
            List<ClinicalFindings> cf = new List<ClinicalFindings>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ClinicalFindings Ocf = new ClinicalFindings();
                Ocf.FindingsGrpID = (string)rdr[0];
                Ocf.FindingsParentID = (string)rdr[1];
               //Ocf.FindingsParentTitle = !rdr.IsDBNull(2) ? (string)rdr[2]: "";
                Ocf.FindingsID = (string)rdr["CF_ID"];
                Ocf.FindingsTitle = (string)rdr["CF_TITLE"];
                Ocf.FindingsTitleBeng = (string)rdr[4];
                Ocf.FindingsLevel = !rdr.IsDBNull(5) ? Convert.ToString((decimal)rdr[5]): "0"; //(string)rdr[5] : "0"; 
                Ocf.Remarks = !rdr.IsDBNull(6) ? (string)rdr[6] : "";
                cf.Add(Ocf);
            }
            rdr.Close();
            return cf;
        }

        public List<ClinicalFindings> GetCfTree()
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_CF_Tree";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<ClinicalFindings> Ocfs = new List<ClinicalFindings>();
            while (rdr.Read())
            {
                ClinicalFindings Ocf = new ClinicalFindings();
                Ocf.GrpCategoryTitle = (string)rdr[0];
                Ocf.FindingsGrpID = (string)rdr[1];
                Ocf.FindingsGrpTitle = (string)rdr[2];
                Ocf.FindingsParentID = (string)rdr[3];
                Ocf.FindingsParentTitle = !rdr.IsDBNull(4) ? Convert.ToString((string)rdr[4]) : "";
                Ocf.FindingsID = (string)rdr["CF_ID"];
                Ocf.FindingsTitle = (string)rdr["CF_TITLE"];
                Ocf.FindingsLevel = !rdr.IsDBNull(7) ? Convert.ToString((decimal)rdr[7]) : "0"; //(string)rdr[5] : "0"; 

                Department odept = new Department();
                odept.DepartmentID = !rdr.IsDBNull(8) ? (string)rdr[8] : "";
                odept.DepartmentTitle = !rdr.IsDBNull(9) ? (string)rdr[9] : "";
                Ocf.Department = odept;

                DepartmentUnit deptUnit = new DepartmentUnit();
                deptUnit.UnitId = !rdr.IsDBNull(10) ? (string)rdr[10] : "";
                deptUnit.UnitTitle = !rdr.IsDBNull(11) ? (string)rdr[11] : "";
                Ocf.DepartmentUnit = deptUnit;

                Ocfs.Add(Ocf);
            }
            rdr.Close();
            return Ocfs;
        }
        public short UpdateClinicalFindings(ClinicalFindings cf)
        {
            string packageName = "PKG_OPD.UPDATE_CLINICAL_FINDING";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Cf_Grp_ID",OracleDbType.Varchar2,70,cf.FindingsGrpID,ParameterDirection.Input),
                new OracleParameter("Cf_ID",OracleDbType.Varchar2,4,cf.FindingsID,ParameterDirection.Input),
                new OracleParameter("Cf_Parent_ID",OracleDbType.Varchar2,4,cf.FindingsParentID,ParameterDirection.Input),
                new OracleParameter("Cf_Title",OracleDbType.Varchar2,70,cf.FindingsTitle,ParameterDirection.Input),
                new OracleParameter("Cf_Title_Beng",OracleDbType.Varchar2,200,cf.FindingsTitleBeng,ParameterDirection.Input), 
                new OracleParameter("Cf_Level",OracleDbType.Varchar2,10,cf.FindingsLevel,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cf.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cf.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cf.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cf.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cf.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public short SaveClinicalFindingsValue(ClinicalFindingsValues cfv)
        {
            string packageName = "PKG_OPD.INSERT_CLINICAL_FINDING_VALUE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ClinicalFindingsValTitle",OracleDbType.Varchar2,70,cfv.FindingsValTitle,ParameterDirection.Input),
                new OracleParameter("ClinicalFindingsValBeng",OracleDbType.Varchar2,200,cfv.FindingsValTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cfv.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cfv.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cfv.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cfv.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cfv.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<ClinicalFindingsValues> GetClinicalFindingsValues()
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDINGS_VALUES";
            OracleParameter[] parameterList = new OracleParameter[] 
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) 
            };
            return GetClinicalFindingsVal(packageName,parameterList);
        }

        public List<ClinicalFindingsValues> GetClinicalFindingsValue(string findingsvaltitle)
        {
            string packageName = "PKG_OPD.GET_CLINICAL_FINDINGS_VALUE";
            OracleParameter[] parameterList = new OracleParameter[] 
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ClinicalFindingsValTitle",OracleDbType.Varchar2,70,findingsvaltitle,ParameterDirection.Input)
            };
            return GetClinicalFindingsVal(packageName, parameterList);
        }

        public short UpdateClinicalFindingsValue(ClinicalFindingsValues cfv)
        {
            string packageName = "PKG_OPD.UPDATE_CLINICAL_FINDING_VALUE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ClinicalFindingsValID",OracleDbType.Varchar2,70,cfv.FindingsValID,ParameterDirection.Input),
                new OracleParameter("ClinicalFindingsValTitle",OracleDbType.Varchar2,70,cfv.FindingsValTitle,ParameterDirection.Input),
                new OracleParameter("ClinicalFindingsValBeng",OracleDbType.Varchar2,200,cfv.FindingsValTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cfv.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cfv.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cfv.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cfv.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cfv.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        private List<ClinicalFindingsValues> GetClinicalFindingsVal(string packageName, OracleParameter[] parameterList)
        {
            List<ClinicalFindingsValues> cfvs = new List<ClinicalFindingsValues>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                ClinicalFindingsValues cfv = new ClinicalFindingsValues();
                cfv.FindingsValID = (string)rdr[0];
                cfv.FindingsValTitle = (string)rdr[1];
                cfv.FindingsValTitleBeng = (string)rdr[2];
                cfv.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                cfvs.Add(cfv);
            }
            rdr.Close();
            return cfvs;
        }


        public short SaveCFAssignedValue(ClinicalFindingsValueAssign cfvalA)
        {
            string packageName = "PKG_OPD.INSERT_CF_VALUE_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("AssignValue",OracleDbType.Varchar2,5000,cfvalA.AssignedFindingsValue,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cfvalA.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cfvalA.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cfvalA.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cfvalA.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public List<ClinicalFindingsValueAssign> getCFAssignedValue(string cfID)
        {
            string packageName = "PKG_OPD.GET_ASSIGNED_VALUE";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("cfID",OracleDbType.Varchar2,5,cfID,ParameterDirection.Input)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<ClinicalFindingsValueAssign> oClinicalFindingsValueAssign = new List<ClinicalFindingsValueAssign>();
            while (rdr.Read())
            {
                ClinicalFindingsValueAssign sCFAssignedValue = new ClinicalFindingsValueAssign();
                sCFAssignedValue.FindingsValID = (String)rdr["CHK_ID"];
                sCFAssignedValue.FindingsValTitle = (String)rdr["CHK_TITLE"];
                oClinicalFindingsValueAssign.Add(sCFAssignedValue);
            }
            rdr.Close();
            return oClinicalFindingsValueAssign;
        }
#endregion ClinicalFindingsNew(09/07/15)

#region SaveClinicalDiagnosis
        public short SaveClinicalDiagnosis(ClinicalDiagnosis cl)
        {
            string packageName = "PKG_OPD.INSERT_CLINICAL_DIAGNOSIS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DiagnosisTitle",OracleDbType.Varchar2,70,cl.DiagTitle,ParameterDirection.Input),
                new OracleParameter("DiagnosisTitleBeng",OracleDbType.Varchar2,200,cl.DiagTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cl.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cl.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cl.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cl.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cl.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
#endregion SaveClinicalDiagnosis

        public List<ClinicalDiagnosis> GetClinicalDiagnosis()
        {
            string packageName = "PKG_OPD.GET_CLINICAL_DIAGNOSIS";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) };
            return GetClinicalDiag(packageName,parameterList);
        }

        public List<ClinicalDiagnosis> GetClinicalDiagnos(string diagtitle)
        {
            string packageName = "PKG_OPD.GET_CLINICAL_DIAGNOSIS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DiagTitle",OracleDbType.Varchar2,70,diagtitle,ParameterDirection.Input)
            };
            return GetClinicalDiag(packageName, parameterList);
        }

        #region UpdateClinicalDiagnosis
        public short UpdateClinicalDiagnosis(ClinicalDiagnosis cl)
        {
            string packageName = "PKG_OPD.UPDATE_CLINICAL_DIAGNOSIS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DiagnosisID",OracleDbType.Varchar2,70,cl.DiagID,ParameterDirection.Input),
                new OracleParameter("DiagnosisTitle",OracleDbType.Varchar2,70,cl.DiagTitle,ParameterDirection.Input),
                new OracleParameter("DiagnosisTitleBeng",OracleDbType.Varchar2,200,cl.DiagTitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,cl.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,cl.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,cl.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,cl.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,cl.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        private List<ClinicalDiagnosis> GetClinicalDiag(string packageName,OracleParameter[] parameterList)
        {
            List<ClinicalDiagnosis> clnk = new List<ClinicalDiagnosis>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                ClinicalDiagnosis cl = new ClinicalDiagnosis();
                cl.DiagID = (string)rdr[0];
                cl.DiagTitle = (string)rdr[1];
                cl.DiagTitleBeng = (string)rdr[2];
                cl.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                clnk.Add(cl);
            }
            rdr.Close();
            return clnk;
        }

        public short SaveComplaint(Complaints com)
        {
            string packageName = "PKG_OPD.INSERT_COMPLAINTS";
            OracleParameter[] parameterList = new OracleParameter[] {
             new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
             new OracleParameter("ComplaintsTitle",OracleDbType.Varchar2,200,com.ComplaintTitle,ParameterDirection.Input),
             new OracleParameter("ComplaintsTitleBengali",OracleDbType.Varchar2,200,com.ComplaintTitleBeng,ParameterDirection.Input),
             new OracleParameter("DepartmnetID",OracleDbType.Varchar2,7,com.Department.DepartmentID,ParameterDirection.Input),
             new OracleParameter("Remarks",OracleDbType.Varchar2,300,com.Remarks,ParameterDirection.Input),
             new OracleParameter("EntryBy",OracleDbType.Varchar2,20,com.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("CompanyID",OracleDbType.Varchar2,2,com.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("LocationID",OracleDbType.Varchar2,2,com.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("MachineID",OracleDbType.Varchar2,20,com.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short UpdateComplaint(Complaints com)
        {
            string packageName = "PKG_OPD.UPDATE_COMPLAINTS";
            OracleParameter[] parameterList = new OracleParameter[] {
             new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
             new OracleParameter("ComplaintsID",OracleDbType.Varchar2,4,com.ID,ParameterDirection.Input),
             new OracleParameter("ComplaintsTitle",OracleDbType.Varchar2,200,com.ComplaintTitle,ParameterDirection.Input),
             new OracleParameter("ComplaintsTitleBengali",OracleDbType.Varchar2,200,com.ComplaintTitleBeng,ParameterDirection.Input),
             new OracleParameter("DepartmnetID",OracleDbType.Varchar2,7,com.Department.DepartmentID,ParameterDirection.Input),
             new OracleParameter("Remarks",OracleDbType.Varchar2,300,com.Remarks,ParameterDirection.Input),
             new OracleParameter("EntryBy",OracleDbType.Varchar2,20,com.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("CompanyID",OracleDbType.Varchar2,2,com.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("LocationID",OracleDbType.Varchar2,2,com.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("MachineID",OracleDbType.Varchar2,20,com.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #region GetComplaints
        public List<Complaints> GetComplaints()
        {
            string packageName = "PKG_OPD.GET_COMPLAINTS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
               };
            return GetComplain(packageName, parameterList);
        }
        public List<Complaints> GetComplaints(string comptitle)
        {
            string packageName = "PKG_OPD.GET_COMPLAINTS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ComplaintTitle",OracleDbType.Varchar2,200,comptitle,ParameterDirection.Input)
               };
            return GetComplain(packageName, parameterList);
        }

        private List<Complaints> GetComplain(string packageName, OracleParameter[] parameterList)
        {
            List<Complaints> lscom = new List<Complaints>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                Complaints com = new Complaints();
                com.ID = (string)rdr[0];
                com.ComplaintTitle = (string)rdr[1];
                com.ComplaintTitleBeng = (string)rdr[2];
                com.Remarks = !rdr.IsDBNull(5) ? (string)rdr[5] : "";

                Department dpt = new Department();
                dpt.DepartmentID = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                dpt.DepartmentTitle = !rdr.IsDBNull(4) ?(string)rdr[4] : "";
                //dpt.DepartmentTitle = (string)rdr[5];
                com.Department = dpt;

                lscom.Add(com);
            }
            rdr.Close();
            return lscom;
        }
        #endregion

        #region InsertUpdateDoctorCall
        public OPDDoctorCall InsUpdDocCall(OPDDoctorCall oOPDDoctorCall)
        {
            string packageName = "AGH_OPD.PKG_OPD.Insert_Update_DoctorCall";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_departmentID",OracleDbType.Varchar2,30,oOPDDoctorCall.Department.DepartmentID,ParameterDirection.Input),
             new OracleParameter ("p_UnitID",OracleDbType.Varchar2,300,oOPDDoctorCall.DepartmentUnit.UnitId,ParameterDirection.Input),
             new OracleParameter ("p_docID",OracleDbType.Varchar2,300,oOPDDoctorCall.Doctor.ID,ParameterDirection.Input),
             //new OracleParameter ("p_nurseID",OracleDbType.Varchar2,300,oOPDDoctorCall.NurseID,ParameterDirection.Input),
             //new OracleParameter ("p_nstationID",OracleDbType.Varchar2,300,oOPDDoctorCall.NStationID,ParameterDirection.Input),
             //new OracleParameter ("p_roomID",OracleDbType.Varchar2,300,oOPDDoctorCall.RoomNo,ParameterDirection.Input),
             //new OracleParameter ("p_presno",OracleDbType.Varchar2,300,oOPDDoctorCall.Prescription.TicketNo,ParameterDirection.Input),
             new OracleParameter ("p_status",OracleDbType.Varchar2,300,oOPDDoctorCall.Status,ParameterDirection.Input),
             //new OracleParameter ("p_date",OracleDbType.Varchar2,300,oOPDDoctorCall.EntryDate,ParameterDirection.Input),
            };

            return InsUpdDocCallDetails(packageName, parameterList);
        }

        private OPDDoctorCall InsUpdDocCallDetails(string packageName, OracleParameter[] parameterList)
        {
            OPDDoctorCall oOPDDoctorCall = new OPDDoctorCall();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return oOPDDoctorCall;
        }     
        #endregion
        //--------------------------------------------------Insert OPD Doctor---------------------------------------------------------------
        #region Insert OPD Doctor
        public List<OPDDoctor> InsertDoctorRoom(OPDDoctor oOPDDoctor)
        {
            string packageName = "AGH_OPD.PKG_OPD.Insert_OPD_Doctor";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_RoomGroup",OracleDbType.Varchar2,30,oOPDDoctor.RoomGroup,ParameterDirection.Input),  

             new OracleParameter ("p_RoomID",OracleDbType.NVarchar2,30,oOPDDoctor.Room.RoomID,ParameterDirection.Input), 
             new OracleParameter ("p_dept_id",OracleDbType.NVarchar2,10,oOPDDoctor.Department.DepartmentID,ParameterDirection.Input), 
             new OracleParameter ("p_unit_id",OracleDbType.NVarchar2,6,oOPDDoctor.DepartmentUnit.UnitId,ParameterDirection.Input), 
             new OracleParameter ("p_DoctorID",OracleDbType.NVarchar2,30,oOPDDoctor.Doctor.ID,ParameterDirection.Input),
        
             new OracleParameter ("p_visit_starttime",OracleDbType.Varchar2,15,oOPDDoctor.VisStartTime,ParameterDirection.Input),
             new OracleParameter ("p_visit_endtime",OracleDbType.Varchar2,15,oOPDDoctor.VisEndTime,ParameterDirection.Input),

             new OracleParameter ("p_firstvisit",OracleDbType.Decimal,30,oOPDDoctor.VisFirst,ParameterDirection.Input),
             new OracleParameter ("p_drfistvisit",OracleDbType.Decimal,30,oOPDDoctor.DrVisFirst,ParameterDirection.Input),
             new OracleParameter ("p_secondvisit",OracleDbType.Decimal,30,oOPDDoctor.VisSecond,ParameterDirection.Input),
             new OracleParameter ("p_drsecondvisit",OracleDbType.Decimal,30,oOPDDoctor.DrVisSecond,ParameterDirection.Input),

             new OracleParameter ("p_thirdvisit",OracleDbType.Decimal,30,oOPDDoctor.VisThird,ParameterDirection.Input),
             new OracleParameter ("p_drthirdvisit",OracleDbType.Decimal,30,oOPDDoctor.DrVisThird,ParameterDirection.Input),
             new OracleParameter ("p_fourthvisit",OracleDbType.Decimal,30,oOPDDoctor.VisFourth,ParameterDirection.Input),
             new OracleParameter ("p_drfourtvisit",OracleDbType.Decimal,30,oOPDDoctor.DrVisFourth,ParameterDirection.Input),

             new OracleParameter ("p_rptvisit",OracleDbType.Decimal,30,oOPDDoctor.RptVisit,ParameterDirection.Input),
             new OracleParameter ("p_drrptvisit",OracleDbType.Decimal,30,oOPDDoctor.DrRptVisit,ParameterDirection.Input),

             new OracleParameter ("p_visitcycle",OracleDbType.Decimal,30,oOPDDoctor.VisitCycle,ParameterDirection.Input),
             new OracleParameter ("p_maxpatbar",OracleDbType.Decimal,30,oOPDDoctor.MaxPatBar,ParameterDirection.Input),
             new OracleParameter ("p_avg_patmin",OracleDbType.Decimal,30,oOPDDoctor.AvgPatMin,ParameterDirection.Input),

             new OracleParameter ("p_degree_line1",OracleDbType.Varchar2,200,oOPDDoctor.DegreeLine1,ParameterDirection.Input),
             new OracleParameter ("p_degree_line2",OracleDbType.Varchar2,200,oOPDDoctor.DegreeLine2,ParameterDirection.Input),
             new OracleParameter ("p_degree_line3",OracleDbType.Varchar2,200,oOPDDoctor.DegreeLine3,ParameterDirection.Input),
             new OracleParameter ("p_degree_line4",OracleDbType.Varchar2,200,oOPDDoctor.DegreeLine4,ParameterDirection.Input),

             new OracleParameter ("p_EntryBy",OracleDbType.Varchar2,30,oOPDDoctor.EntryParameter.EntryBy,ParameterDirection.Input),
             
            };
            return InsertDoctorRoomList(packageName, parameterList);
        }

        //public OPDDoctor InsertDoctorRoomList(string packageName, OracleParameter[] parameterList)
        //{
        //    IDataReader reader = null;
        //    OPDDoctor oOPDDoctor = new OPDDoctor();
        //    EntryParameter oEntryParameter = new EntryParameter();
        //    oEntryParameter.ErrorMessage = "";
        //    oOPDDoctor.EntryParameter = oEntryParameter;
        //    try
        //    {
        //        reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
        //        NullHandler oReader = new NullHandler(reader);
        //        if (reader.Read())
        //        {
        //            oOPDDoctor = CreateObject(oReader);
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
        //        oOPDDoctor.EntryParameter = oEntryParameter;
        //    }
        //    return oOPDDoctor;
        //}

        private List<OPDDoctor> InsertDoctorRoomList(string packageName, OracleParameter[] parameterList)
        {
            List<OPDDoctor> rDRSs = new List<OPDDoctor>();
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

        private List<OPDDoctor> CreateObjects(IDataReader oReader)
        {
            List<OPDDoctor> rDRSs = new List<OPDDoctor>();

            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDDoctor oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDDoctor CreateObject(NullHandler oReader)
        {
            OPDDoctor oDRS = new OPDDoctor();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private OPDDoctor MapObject(NullHandler oReader)
        {
            OPDDoctor oDRS = new OPDDoctor();

            oDRS.RoomGroup = oReader.GetString("ROOM_GRP");

            Room oRoom = new Room();
            oRoom.RoomID = oReader.GetString("ROOM_ID");     
            oRoom.RoomNo = Convert.ToInt16(oReader.GetString("RoomNo"));
            oDRS.Room = oRoom;

            //oDRS.Department = oReader.GetString("Department");

            Department odept = new Department();
            odept.DepartmentID = oReader.GetString("Department");
            oDRS.Department = odept;


            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = oReader.GetString("Unit");
            oDRS.DepartmentUnit = deptUnit;

            Doctor oDoctor = new Doctor();
            oDoctor.ID = oReader.GetString("Doc_ID");
            oDoctor.Name = oReader.GetString("DOCTORNAME");
            oDRS.Doctor = oDoctor;

            //oDRS.VisStartTime = Convert.ToString(oReader.GetDateTime("VisStartTime").ToString("hh:mm:ss"));
            oDRS.VisStartTime = Convert.ToString(oReader.GetString("VisStartTime"));
            oDRS.VisEndTime = Convert.ToString(oReader.GetString("VisEndTime"));
            //oDRS.VisEndTime = Convert.ToString(oReader.GetDateTime("VisEndTime").ToString("hh:mm:ss"));

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

            oDRS.DegreeLine1 = oReader.GetString("degree1");
            oDRS.DegreeLine2 = oReader.GetString("degree2");
            oDRS.DegreeLine3 = oReader.GetString("degree3");
            oDRS.DegreeLine4 = oReader.GetString("degree4");

            EntryParameter oEP = new EntryParameter();
            oEP.EntryBy = oReader.GetString("EntryBy");
            oEP.EntryDate = Convert.ToDateTime(oReader.GetDateTime("Entry_Date").ToString("dd MMM yyyy"));
            oDRS.EntryParameter = oEP;

            return oDRS;
        }
        #endregion
        //-----------------------------------------------get OPD doctor with Room--------------------- 
        

    //---------------------------------delete OPD doctor----------------------------------------------
        public List<OPDDoctor> DeleteOPDDoctor(string docID)
        {

            string packageName = "AGH_OPD.PKG_OPD.Delete_OPD_Doctor";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_doc_id",OracleDbType.Varchar2,15, docID,ParameterDirection.Input)
            };

            return InsertDoctorRoomList(packageName, parameterList);
        }
    //-------------------------------------------------------------------------------------------------

        #region GetDoctorRoomNO
        public List<OPDDoctor> GetDocRoomNo(string DoctorID)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_DoctorRoomNo";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_doctorid",OracleDbType.Varchar2,30,DoctorID,ParameterDirection.Input),  
            };

            return DoctorRoomNOs(packageName, parameterList);
        }

        private List<OPDDoctor> DoctorRoomNOs(string packageName, OracleParameter[] parameterList)
        {
            List<OPDDoctor> rDRSs = new List<OPDDoctor>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsDRNo(reader);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return rDRSs;
        }

        private List<OPDDoctor> CreateObjectsDRNo(IDataReader oReader)
        {
            List<OPDDoctor> rDRSs = new List<OPDDoctor>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDDoctor oItem = CreateObjectDRNo(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDDoctor CreateObjectDRNo(NullHandler oReader)
        {
            OPDDoctor oDRS = new OPDDoctor();
            oDRS = MapObjectDRNo(oReader);
            return oDRS;
        }

        private OPDDoctor MapObjectDRNo(NullHandler oReader)
        {
            OPDDoctor oDRS = new OPDDoctor();
          
            Room oRoom = new Room();
            oRoom.RoomID = oReader.GetString("ROOM_ID");
            oRoom.RoomNo = Convert.ToInt16(oReader.GetString("RoomNo"));
            oDRS.Room = oRoom;

            oDRS.RoomGroup = oReader.GetString("ROOM_GRP");

            Doctor oDoctor = new Doctor();
            oDoctor.ID = oReader.GetString("DOC_ID");
            oDoctor.Name = oReader.GetString("DOCTORNAME");
            oDRS.Doctor = oDoctor;

            EntryParameter oEP = new EntryParameter();
            oEP.EntryDate = Convert.ToDateTime(oReader.GetDateTime("ENTRY_DATE").ToString("dd MMM yyyy"));
            oDRS.EntryParameter = oEP;

            return oDRS;
        }
        #endregion

        #region NurseRoomAllocation
        public List<OPDNurseRoomAllocation> GetNurseRoom()
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_NurseRoom";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)               
            };
            return NurseRoomDetails(packageName, parameterList);
        }

        public List<OPDNurseRoomAllocation> InsertNurseRoom(OPDNurseRoomAllocation oOPDNRAll)
        {
            string packageName = "AGH_OPD.PKG_OPD.Insert_NurseRoom";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_RoomGroup",OracleDbType.Varchar2,30,oOPDNRAll.RoomGroup,ParameterDirection.Input),    
             new OracleParameter ("p_RoomID",OracleDbType.Varchar2,30,oOPDNRAll.Room.RoomID,ParameterDirection.Input),
             new OracleParameter ("p_NurseID",OracleDbType.Varchar2,30,oOPDNRAll.Nurse.ID,ParameterDirection.Input),
             new OracleParameter ("p_EntryBy",OracleDbType.Varchar2,30,oOPDNRAll.EntryParameter.EntryBy,ParameterDirection.Input),
             
            };
            return NurseRoomDetails(packageName, parameterList);
        }

        private List<OPDNurseRoomAllocation> NurseRoomDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDNurseRoomAllocation> rDRSs = new List<OPDNurseRoomAllocation>();
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
        private List<OPDNurseRoomAllocation> CreateObjectsNurse(IDataReader oReader)
        {
            List<OPDNurseRoomAllocation> rDRSs = new List<OPDNurseRoomAllocation>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDNurseRoomAllocation oItem = CreateObjectNurse(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDNurseRoomAllocation CreateObjectNurse(NullHandler oReader)
        {
            OPDNurseRoomAllocation oDRS = new OPDNurseRoomAllocation();
            oDRS = MapObjectNurse(oReader);
            return oDRS;
        }

        private OPDNurseRoomAllocation MapObjectNurse(NullHandler oReader)
        {
            OPDNurseRoomAllocation oDRS = new OPDNurseRoomAllocation();
            EntryParameter oEP = new EntryParameter();
            Room oRoom = new Room();
            Nurse oNurse = new Nurse();

            oRoom.RoomID = oReader.GetString("ROOM_ID");
            oRoom.RoomNo = Convert.ToInt16(oReader.GetString("RoomNo"));
            oDRS.Room = oRoom;

            oDRS.RoomGroup = oReader.GetString("ROOM_GRP");

            oNurse.ID = oReader.GetString("Nurse_ID");
            oNurse.Name = oReader.GetString("NurseName");
            oDRS.Nurse = oNurse;

            oEP.EntryDate = Convert.ToDateTime(oReader.GetDateTime("ENTRY_DATE").ToString("dd MMM yyyy"));
            oDRS.EntryParameter = oEP;

            return oDRS;
        }
        #endregion

        #region CheckPatientOldNew
        public string ChkPatOldNew(string DocID, string p_hcn)
        {           
            string packageName = "AGH_OPD.PKG_OPD.Check_Pat_Old_New";

            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_docid",OracleDbType.Varchar2,30,DocID,ParameterDirection.Input),         
             new OracleParameter ("p_hcn",OracleDbType.Varchar2,30,p_hcn,ParameterDirection.Input) 
            };
            return ChkPatOldNewDetails(packageName, parameterList,  DocID,  p_hcn);
        }

        private string ChkPatOldNewDetails(string packageName, OracleParameter[] parameterList, string DocID, string p_hcn)
        {
            string count = "";
            //IDataReader reader = null;
           
            try
            {
                OracleConnection con = new OracleConnection(connString);//("Data Source = HospitalERP; user id = agh_opd; password = aghit");                
                //OracleCommand cmd = new OracleCommand("select count(OPDTM.HCN) as patchkcount from   T_OPD_TKT_MASTER OPDTM,T_OPD_DOC_RM_ALLOC OPDDrRA  where OPDTM.Doc_ID = OPDDrRA.Doc_ID and OPDTM.Doc_ID='00005' and OPDTM.hcn='H0114-0000011' and ((sysdate-(select max(OPDTM.entry_date) from T_OPD_TKT_MASTER where  Doc_ID='00005' and hcn='H0114-0000011'))<=OPDDRRA.VST_CYCLE)");

                OracleCommand cmd = new OracleCommand("AGH_OPD.PKG_OPD.Check_Pat_Old_New", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_test_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;  
                cmd.Parameters.Add("p_docid", OracleDbType.Varchar2,20).Value = DocID;
                cmd.Parameters.Add("p_hcn", OracleDbType.Varchar2,30).Value = p_hcn;

                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = con;
                OracleDataReader dr;
                con.Open();                 
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr["cntvisit"].ToString();
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return count;
        }
        #endregion


        #region GetDrRoom
        public string GetDrRoom(string DocID)
        {
            //string count = "";
            string packageName = "AGH_OPD.PKG_OPD.Get_Dr_RoomNo";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_doctor_id",OracleDbType.Varchar2,30,DocID,ParameterDirection.Input)         
            
            };
            return GetDrRoomDetails(packageName, parameterList, DocID);
        }

        private string GetDrRoomDetails(string packageName, OracleParameter[] parameterList, string DocID)
        {
            string count = "";    
            try
            {
                OracleConnection con = new OracleConnection(connString);
                OracleCommand cmd = new OracleCommand("AGH_OPD.PKG_OPD.Get_Dr_RoomNo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_test_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_doctor_id", OracleDbType.Varchar2).Value = DocID;
                OracleDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr["Room_ID"].ToString();
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return count;
        }
        #endregion

        public List<OPDDoctorCallQ> GetDoctorsList(string nsStnID)
        {
            string packageName = "PKG_OPD.Get_DoctorsList";
            OracleParameter[] parameterList = new OracleParameter[] 
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("nsStnID",OracleDbType.Varchar2,6,nsStnID,ParameterDirection.Input)             
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            List<OPDDoctorCallQ> oDoctorsLIST = new List<OPDDoctorCallQ>();
            while (rdr.Read())
            {
                OPDDoctorCallQ oDrCallQ = new OPDDoctorCallQ();

                oDrCallQ.DoctorName = (rdr["DOCTORNAME"] == DBNull.Value ? string.Empty : (string)rdr["DOCTORNAME"]);
                oDrCallQ.Doc_ID = (string)rdr["DOC_ID"];
                oDrCallQ.DoctorStatus = (string)rdr["Status"];

                oDrCallQ.Dept_ID = (rdr["DEPT_ID"] == DBNull.Value ? string.Empty : (string)rdr["DEPT_ID"]);
                oDrCallQ.DepertmentName = (string)rdr["DEPARTMENT"];

                oDrCallQ.UnitId = (string)rdr["UNIT_ID"];
                oDrCallQ.UnitName = (string)rdr["UNIT"];

                oDrCallQ.PatientCount =Convert.ToDecimal(rdr["Pat_count"].ToString()).ToString();
                oDrCallQ.RoomNo = (string)rdr["ROOM_ID"];
                oDrCallQ.Room = (string)rdr["roomno"];

                oDoctorsLIST.Add(oDrCallQ);
            }
            rdr.Close();
            return oDoctorsLIST;
        }
        public short UpdateCallQ(OPDDoctorCallQ Q)
        {
            string packageName = "PKG_OPD.Update_Pat_Health_Info";
            OracleParameter[] parameterList = new OracleParameter[] {
             new OracleParameter ("p_test_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output),        
             new OracleParameter ("P_NURSE_STATION_ID",OracleDbType.Varchar2,30,Q.NStationID,ParameterDirection.Input),
             new OracleParameter ("P_ROOM_NO",OracleDbType.Varchar2,30,Q.RoomNo,ParameterDirection.Input),
             new OracleParameter ("P_PRES_NO",OracleDbType.Varchar2,30,Q.TicketNo,ParameterDirection.Input),
             new OracleParameter ("P_HEIGHT",OracleDbType.Varchar2,9,Q.Height,ParameterDirection.Input),
             new OracleParameter ("P_WEIGHT",OracleDbType.Varchar2,6,Q.Weight,ParameterDirection.Input),
             new OracleParameter ("P_BP",OracleDbType.Varchar2,7,Q.Bp,ParameterDirection.Input),
             new OracleParameter ("P_TEMPARATURE",OracleDbType.Varchar2,3,Q.Temparature,ParameterDirection.Input),
             new OracleParameter ("P_SPOTWO",OracleDbType.Int32,10,Q.SPOTWO,ParameterDirection.Input),
             new OracleParameter ("P_OFC",OracleDbType.Int32,10,Q.OFC,ParameterDirection.Input),

             new OracleParameter ("P_ALLERGY",OracleDbType.Varchar2,10,Q.Allergy,ParameterDirection.Input),
             new OracleParameter ("P_ALLERGY_text",OracleDbType.Varchar2,200,Q.AllergyText,ParameterDirection.Input),
             new OracleParameter ("P_ASTHMA",OracleDbType.Varchar2,1,Q.Asthma,ParameterDirection.Input),
             new OracleParameter ("P_ASTHMA_text",OracleDbType.Varchar2,200,Q.AsthmaText,ParameterDirection.Input),
             new OracleParameter ("P_DIABETES",OracleDbType.Varchar2,1,Q.Diabetes,ParameterDirection.Input),
             new OracleParameter ("P_DIABETES_text",OracleDbType.Varchar2,200,Q.DiabetesText,ParameterDirection.Input),
             new OracleParameter ("P_PRESSURE",OracleDbType.Varchar2,1,Q.Pressure,ParameterDirection.Input),
             new OracleParameter ("P_PRESSURE_text",OracleDbType.Varchar2,200,Q.PressureText,ParameterDirection.Input),
             new OracleParameter ("P_HEART_DISEASE",OracleDbType.Varchar2,1,Q.HeartDisease,ParameterDirection.Input),
             new OracleParameter ("P_HEART_DISEASE_text",OracleDbType.Varchar2,200,Q.HeartDiseaseText,ParameterDirection.Input),
             new OracleParameter ("P_KIDNEY_DISEASE",OracleDbType.Varchar2,1,Q.KidneyDisease,ParameterDirection.Input),
             new OracleParameter ("P_KIDNEY_DISEASE_text",OracleDbType.Varchar2,200,Q.KidneyDiseaseText,ParameterDirection.Input),
             new OracleParameter ("P_Others",OracleDbType.Varchar2,1,Q.Others,ParameterDirection.Input),
             new OracleParameter ("P_Others_text",OracleDbType.Varchar2,200,Q.OthersText,ParameterDirection.Input),
             new OracleParameter ("P_PMedHis",OracleDbType.Varchar2,1,Q.PastMedicalHistory,ParameterDirection.Input),
             new OracleParameter ("P_PMedHis_text",OracleDbType.Varchar2,200,Q.PastMedicalHistoryText,ParameterDirection.Input),
             new OracleParameter ("P_PSurgHis",OracleDbType.Varchar2,1,Q.PastSurgicalHistory,ParameterDirection.Input),
             new OracleParameter ("P_PSurgHis_text",OracleDbType.Varchar2,200,Q.PastSurgicalHistoryText,ParameterDirection.Input),
             new OracleParameter ("P_PFamilyHis",OracleDbType.Varchar2,1,Q.FamilyHistory,ParameterDirection.Input),
             new OracleParameter ("P_PFamilyHis_text",OracleDbType.Varchar2,200,Q.FamilyHistoryText,ParameterDirection.Input),

             new OracleParameter("entryBy",OracleDbType.Varchar2,20,Q.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("comp",OracleDbType.Varchar2,2,Q.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("loc",OracleDbType.Varchar2,2,Q.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("mac",OracleDbType.Varchar2,20,Q.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public OPDDoctorCallQ GetPatHealthInfo(string Ticket)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_Pat_Health_Info";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Ticket",OracleDbType.Varchar2,30,Ticket,ParameterDirection.Input)              
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            OPDDoctorCallQ oPatHealthInfo = new OPDDoctorCallQ();

            while (rdr.Read())
            {
                oPatHealthInfo.Height = (rdr["HEIGHT"] == DBNull.Value ? string.Empty : (string)rdr["HEIGHT"]);
                oPatHealthInfo.Weight = (rdr["WEIGHT"] == DBNull.Value ? string.Empty : (string)rdr["WEIGHT"]);
                oPatHealthInfo.Bp = (rdr["BP"] == DBNull.Value ? string.Empty : (string)rdr["BP"]);
                oPatHealthInfo.Temparature = (rdr["TEMPARATURE"] == DBNull.Value ? string.Empty : (string)rdr["TEMPARATURE"]);
                oPatHealthInfo.SPOTWO = Convert.ToString(rdr["SPOTWO"] == DBNull.Value ? 0 : (decimal)rdr["SPOTWO"]);
                oPatHealthInfo.OFC = Convert.ToString(rdr["OFC"] == DBNull.Value ? 0 : (decimal)rdr["OFC"]);

                /*A.HEIGHT, A.WEIGHT, A.BP, A.TEMPARATURE, 
                B.ALLERGY, B.ALLERGY, B.ALLERGY_TEXT, B.ASTHMA, B.ASTHMA_TEXT, B.DIABETESMALLITUS, 
                B.DIABETESMALLITUS_TEXT, B.HYPERTENSION, B.HYPERTENSION_TEXT, 
                B.HEART_DISEASE, B.HEART_DISEASE_TEXT,  B.KIDNEY_DISEASE,B.KIDNEY_DISEASE_TEXT */

                oPatHealthInfo.Allergy = (string)rdr["ALLERGY"];
                oPatHealthInfo.AllergyText = (rdr["ALLERGY_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ALLERGY_TEXT"]);
                oPatHealthInfo.Asthma = (string)rdr["ASTHMA"];
                oPatHealthInfo.AsthmaText =  (rdr["ASTHMA_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["ASTHMA_TEXT"]);
                oPatHealthInfo.Diabetes = (string)rdr["DIABETESMALLITUS"];
                oPatHealthInfo.DiabetesText = (rdr["DIABETESMALLITUS_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["DIABETESMALLITUS_TEXT"]);
                oPatHealthInfo.Pressure = (string)rdr["HYPERTENSION"];
                oPatHealthInfo.PressureText = (rdr["HYPERTENSION_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["HYPERTENSION_TEXT"]);
                oPatHealthInfo.HeartDisease = (string)rdr["HEART_DISEASE"];
                oPatHealthInfo.HeartDiseaseText = (rdr["HEART_DISEASE_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["HEART_DISEASE_TEXT"]);
                oPatHealthInfo.KidneyDisease = (string)rdr["KIDNEY_DISEASE"];
                oPatHealthInfo.KidneyDiseaseText = (rdr["KIDNEY_DISEASE_TEXT"] == DBNull.Value ? string.Empty : (string)rdr["KIDNEY_DISEASE_TEXT"]);
            }
            rdr.Close();
            return oPatHealthInfo;
        }
        //Get_Disease_group
        public List<DiseaseCase> getDiseaseGroup()
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_Disease_group";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<DiseaseCase> oDiseaseCase = new List<DiseaseCase>();
            while (rdr.Read())
            {
                DiseaseCase sDisGrp = new DiseaseCase();
                sDisGrp.DiseaseGrpID = (String)rdr["GRP_ID"];
                sDisGrp.DiseaseGrpTitle = (String)rdr["GRP_TITLE"];
                oDiseaseCase.Add(sDisGrp);
            }
            rdr.Close();
            return oDiseaseCase;
        }

        public List<Ticket> GetTicketList(string userID, string date)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_Ticket_List";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("userID",OracleDbType.Varchar2,30,userID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,date,ParameterDirection.Input) 
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            List<Ticket> oTicket = new List<Ticket>();

            while (rdr.Read())
            {
                Ticket tktObj = new Ticket();
                tktObj.TicketNo = (rdr["tkt_no"] == DBNull.Value ? string.Empty : (string)rdr["tkt_no"]);

                Patient pat = new Patient();
                pat.HCN = (rdr["hcn"] == DBNull.Value ? string.Empty : (string)rdr["hcn"]);

                tktObj.TicketStatus = (rdr["tkt_status"] == DBNull.Value ? string.Empty : (string)rdr["tkt_status"]);
                tktObj.TicketFee =Convert.ToDouble((decimal)rdr["tkt_fee"]);
                tktObj.acc_close_flag = (string)rdr["acc_close_flag"];

                tktObj.Patient = pat;
                oTicket.Add(tktObj);
            }
            rdr.Close();
            return oTicket;
        }
        public Ticket GetTicketStatusForRefundOrCancel(string ticket)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_Tik_Status_For_RefCncl";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ticket",OracleDbType.Varchar2,30,ticket,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            Ticket tktObj = new Ticket();
            while (rdr.Read())
            {
                
                tktObj.TicketNo = (rdr["tkt_no"] == DBNull.Value ? string.Empty : (string)rdr["tkt_no"]);
                Patient pat = new Patient();
                pat.HCN = (rdr["hcn"] == DBNull.Value ? string.Empty : (string)rdr["hcn"]);

                tktObj.TicketCategory = (rdr["tkt_cat"] == DBNull.Value ? string.Empty : (string)rdr["tkt_cat"]);
                tktObj.TicketStatus = (rdr["tkt_status"] == DBNull.Value ? string.Empty : (string)rdr["tkt_status"]);
                tktObj.TicketFee = Convert.ToDouble((decimal)rdr["tkt_fee"]);
                tktObj.acc_close_flag = (string)rdr["acc_close_flag"];

                tktObj.FeeCashAmount = Convert.ToString(rdr["CASH_AMT"] == DBNull.Value ? 0 : (decimal)rdr["CASH_AMT"]);

                EntryParameter oen = new EntryParameter();
                oen.EntryBy = (string)rdr["user_id"];
                oen.EntryName = (string)rdr["user_name"];

                tktObj.EntryParameter = oen;
             

                tktObj.Patient = pat;
            }
            rdr.Close();
            return tktObj;
        }
        public short CancelTicket(string ticketNo, string userid)
        {
            string packageName = "PKG_OPD.Cancel_Ticket";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output),        
             new OracleParameter ("tkt_no",OracleDbType.Varchar2,30,ticketNo,ParameterDirection.Input),
             new OracleParameter ("user_id",OracleDbType.Varchar2,30,userid,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public string RefundTicket(Ticket tkt)
        {
            string packageName = "PKG_OPD.Refund_Ticket";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter("R_tkt_no",OracleDbType.Varchar2,30,tkt.RefundedTicketNo,ParameterDirection.Output),
             new OracleParameter("tkt_no",OracleDbType.Varchar2,30,tkt.TicketNo,ParameterDirection.Input),  
             new OracleParameter("purpose_id",OracleDbType.Varchar2,4,tkt.PurposeID,ParameterDirection.Input),
             new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tkt.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tkt.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("LocationID",OracleDbType.Varchar2,2,tkt.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("MachineID",OracleDbType.Varchar2,20,tkt.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string RticketNo = (string)(OracleString)prm.Value;
            return RticketNo;
        }
        public AccountsPayment GetTicketFees(string userID, string date)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_Amount_Ticket_Fee";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("userID",OracleDbType.Varchar2,30,userID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,date,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            AccountsPayment tktObj = new AccountsPayment();
            while (rdr.Read())
            {
                tktObj.TotalCollection =Convert.ToDouble( rdr["Collection"] == DBNull.Value ? 0 : (decimal)rdr["Collection"]);
                tktObj.RefundAmount = Convert.ToDouble( rdr["Refund"] == DBNull.Value ? 0 : (decimal)rdr["Refund"]);
                tktObj.PaymentAmount = Convert.ToDouble( rdr["Total"] == DBNull.Value ? 0 : (decimal)rdr["Total"]);

                tktObj.CashAmount =Convert.ToDouble(  rdr["CASH_AMT"] == DBNull.Value ? 0 : (decimal)rdr["CASH_AMT"]);
                tktObj.CreditCardAmount =Convert.ToDouble(  rdr["CREDIT_CARD_AMT"] == DBNull.Value ? 0 : (decimal)rdr["CREDIT_CARD_AMT"]);
                tktObj.DebitCardAmount =Convert.ToDouble(  rdr["DEBIT_CARD_AMT"] == DBNull.Value ? 0 : (decimal)rdr["DEBIT_CARD_AMT"]);
            }
            rdr.Close();
            return tktObj;
        }
        public short InsertUserCloseRegister(AccountsPayment tktFee)//(Ticket tktFee)
        {
            string packageName = "AGH_OPD.PKG_OPD.INSERT_USER_CLOSE_REGISTER";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("p_test_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output), 
                new OracleParameter("userID",OracleDbType.Varchar2,30,tktFee.EntryParameter.EntryBy,ParameterDirection.Input),

                new OracleParameter("CASH_AMT",OracleDbType.Varchar2,300,tktFee.CashAmount,ParameterDirection.Input),
                new OracleParameter("CREDIT_CARD_AMT",OracleDbType.Varchar2,300,tktFee.CreditCardAmount,ParameterDirection.Input),
                new OracleParameter("DEBIT_CARD_AMT",OracleDbType.Varchar2,300,tktFee.DebitCardAmount,ParameterDirection.Input),

                new OracleParameter("Tkt_fee",OracleDbType.Varchar2,300,tktFee.PaymentAmount,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tktFee.Remarks,ParameterDirection.Input),

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tktFee.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tktFee.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tktFee.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tktFee.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,tktFee.CollectionDate,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }


        public List<OPDPrescriptionReportNewRO> GetOPDPatTree(string HCN)
        {
            string packageName = "Pkg_OPD_Reports.Get_OPD_PAT_VTree";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,70,HCN,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            List<OPDPrescriptionReportNewRO> OPrsList = new List<OPDPrescriptionReportNewRO>();

            while (rdr.Read())
            {
                OPDPrescriptionReportNewRO Oprs = new OPDPrescriptionReportNewRO();

                Oprs.VisitDate = Convert.ToString(((DateTime)rdr["VDate"]).ToString("dd/MM/yyyy"));
                Oprs.TicketNo = (string)rdr["TicketNo"];
                Oprs.HCN = (string)rdr["HCN"];
                Oprs.Dept = (string)rdr["Dept_ID"];
                Oprs.DeptName = (string)rdr["Dept_Name"];
                Oprs.Unit = (string)rdr["Unit_ID"];
                Oprs.UnitName = (string)rdr["Unit_Name"];
                Oprs.ComplaintsTitle = (string)rdr["COMPLAINTs"];
                Oprs.ClinicalFindings = (rdr["ClinicalFindings"] == DBNull.Value ? string.Empty : (string)rdr["ClinicalFindings"]);
                Oprs.Diagnosis =  (rdr["Impressions"] == DBNull.Value ? string.Empty : (string)rdr["Impressions"]);
                Oprs.TestDetailsName = (rdr["Tests"] == DBNull.Value ? string.Empty : (string)rdr["Tests"]);
                Oprs.Medicine = (rdr["Medicines"] == DBNull.Value ? string.Empty : (string)rdr["Medicines"]);
                Oprs.Advice = (rdr["Advices"] == DBNull.Value ? string.Empty : (string)rdr["Advices"]);

                OPrsList.Add(Oprs);
            }
            rdr.Close();
            return OPrsList;
        }

        //public List<OpdAppointment> Appointment(string hcn)
        //{
        //    List<OpdAppointment> oAppointmentLIST = new List<OpdAppointment>();
        //    string packageName = "AGH_APMS.pkg_apms_setup.GetPatientAppointmentDetails";  //AGH_APMS.pkg_apms_setup. GetPatientAppointmentDetails

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {             
        //     new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
        //     new OracleParameter ("hcn",OracleDbType.Varchar2,15,hcn,ParameterDirection.Input),         
        //    };

        //    OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        OpdAppointment app = new OpdAppointment();

        //        Department oDept = new Department();
        //        oDept.DepartmentID = (rdr["DEPT_ID"] == DBNull.Value ? string.Empty : (string)rdr["DEPT_ID"]);

        //        DepartmentUnit dept = new DepartmentUnit();
        //        dept.UnitId= (string)rdr["Unit_ID"];
        //        app.DepartmentUnit = dept;
        //        app.Department = oDept;

        //         Doctor oDoctor = new Doctor();
        //         oDoctor.ID = (string)rdr["DOCTOR_ID"];
        //         //oDoctor.Name = (rdr["DOCTORNAME"] == DBNull.Value ? string.Empty : (string)rdr["DOCTORNAME"]);
        //         app.Doctor = oDoctor;

        //         app.TokenNo = (string)rdr["APP_TOKEN_NO"];
        //         app.ApproxSTime = (string)rdr["APPROX_S_TIME"];
        //         app.ApproxETime = (string)rdr["APPROX_E_TIME"];

        //         oAppointmentLIST.Add(app);
        //     }
        //    rdr.Close();
        //    return oAppointmentLIST;
        //}
    }


}
