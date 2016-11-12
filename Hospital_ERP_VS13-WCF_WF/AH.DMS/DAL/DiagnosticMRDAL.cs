using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.DMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.PatReg.MODEL;
using AH.DTMS.MODEL;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;
using AH.PRMS.MODEL;

namespace AH.DMS.DAL
{
   public class DiagnosticMRDAL
    {
       private string connString = Utility.GetConnectionString(Utility.Module.DMSMIS);

       #region SaveDiagnosticMR
       public string SaveDiagnosticMR(DiagnosticMR mr)
       {          
           //string tests = "";
           //string tests1 = "";
           //foreach (TestFee dt in mr.Tests)
           //{
           //    tests += dt.TestSub.SpecimenCollectionRoom.RoomID + ":" + (dt.TestSub.Technologist.ID == "" ? "0" : dt.TestSub.Technologist.ID) + ":" + dt.TestSub.ReportGroup.ReportGroupID + ":" + dt.TestSub.TestDepartment.DepartmentID + ":" + dt.TestSub.TestGroup.GroupId + ":" + dt.TestSub.TestMainID + ":" + dt.TestSub.TestSubID + ":" + dt.TestSub.PanelID + ":" + dt.FeeCategory + ":" + dt.Fee + ":" + dt.DeptFee + ":" + dt.RefdFee + ":" + dt.DoctorFee + ":" + dt.Discount + ":" + dt.VAT + ":" + dt.TestSub.LabRoom.RoomID + ";";             
           //}
           //foreach (TestFee dt in mr.Tests1)
           //{
           //    tests1 += dt.TestSub.SpecimenCollectionRoom.RoomID + ":" + (dt.TestSub.Technologist.ID == "" ? "0" : dt.TestSub.Technologist.ID) + ":" + dt.TestSub.ReportGroup.ReportGroupID + ":" + dt.TestSub.TestDepartment.DepartmentID + ":" + dt.TestSub.TestGroup.GroupId + ":" + dt.TestSub.TestMainID + ":" + dt.TestSub.TestSubID + ":" + dt.TestSub.PanelID + ":" + dt.FeeCategory + ":" + dt.Fee + ":" + dt.DeptFee + ":" + dt.RefdFee + ":" + dt.DoctorFee + ":" + dt.Discount + ":" + dt.VAT + ":" + dt.TestSub.LabRoom.RoomID + ";";
           //}

           string packageName = "PKG_Diag_MR_COLL.S_DIAG_MR_COLLECTION";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_trans_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_mr_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("PrescriptionNo",OracleDbType.Varchar2,30,mr.Prescription.TicketNo,ParameterDirection.Input),
              new OracleParameter("prescriptionType",OracleDbType.Varchar2,2,mr.Prescription.TicketType,ParameterDirection.Input),
              new OracleParameter("hcn",OracleDbType.Varchar2,30,mr.Patient.HCN,ParameterDirection.Input),
              new OracleParameter("PackageID",OracleDbType.Varchar2,30,mr.PackageID,ParameterDirection.Input),
              new OracleParameter("Year",OracleDbType.Varchar2,4,mr.Patient.AgeBreakDown.Year,ParameterDirection.Input),
              new OracleParameter("Month",OracleDbType.Varchar2,4,mr.Patient.AgeBreakDown.Month,ParameterDirection.Input),
              new OracleParameter("Day",OracleDbType.Varchar2,4,mr.Patient.AgeBreakDown.Day,ParameterDirection.Input),
              new OracleParameter("Hour",OracleDbType.Varchar2,4,mr.Patient.AgeBreakDown.Hour,ParameterDirection.Input),
              new OracleParameter("p_reff_org_id",OracleDbType.Varchar2,4,mr.RefdOrg.OrgID,ParameterDirection.Input),
              new OracleParameter("deptID",OracleDbType.Varchar2,5,mr.Patient.Department.DepartmentID,ParameterDirection.Input),
              new OracleParameter("unitID",OracleDbType.Varchar2,5,mr.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
              new OracleParameter("docID",OracleDbType.Varchar2,30,mr.Doctor.ID,ParameterDirection.Input),
              new OracleParameter("regID",OracleDbType.Varchar2,30,mr.Patient.RegistrationNo,ParameterDirection.Input),
              new OracleParameter("wardID",OracleDbType.Varchar2,5,mr.Patient.Bed.Ward.WardID,ParameterDirection.Input),
              new OracleParameter("bedID",OracleDbType.Varchar2,5,mr.Patient.Bed.BedID,ParameterDirection.Input),
              new OracleParameter("staffID",OracleDbType.Varchar2,30,mr.Patient.StaffID,ParameterDirection.Input),            
              new OracleParameter("P_TEST_COLLS",OracleDbType.Varchar2,20000,mr.TestString1,ParameterDirection.Input),
              new OracleParameter("purpose",OracleDbType.Varchar2,6,mr.DiagnosticPayment.PurposeID,ParameterDirection.Input),
              new OracleParameter("deptAmt",OracleDbType.Decimal,10,mr.DiagnosticPayment.DeptAmount,ParameterDirection.Input),
              new OracleParameter("ReffDeptAmt",OracleDbType.Decimal,10,mr.DiagnosticPayment.ReffDeptAmount,ParameterDirection.Input),
              new OracleParameter("vat",OracleDbType.Decimal,10,mr.DiagnosticPayment.VAT,ParameterDirection.Input),
              new OracleParameter("p_discount_type",OracleDbType.Varchar2,3,mr.test.DiscountType,ParameterDirection.Input),
              new OracleParameter("p_discount_reff",OracleDbType.Varchar2,30,mr.test.DiscountReff,ParameterDirection.Input),
              new OracleParameter("p_discount_authority",OracleDbType.Varchar2,30,mr.test.DiscountAuthority,ParameterDirection.Input),
              new OracleParameter("disc",OracleDbType.Decimal,10,mr.DiagnosticPayment.Discount,ParameterDirection.Input),
              new OracleParameter("adv",OracleDbType.Decimal,10,mr.DiagnosticPayment.Advance,ParameterDirection.Input),
              new OracleParameter("due",OracleDbType.Decimal,10,mr.DiagnosticPayment.PreviousDue,ParameterDirection.Input),
              new OracleParameter("p_net_amt",OracleDbType.Decimal,10,mr.DiagnosticPayment.NetAmount,ParameterDirection.Input),
              new OracleParameter("p_amount",OracleDbType.Decimal,10,mr.DiagnosticPayment.Amount,ParameterDirection.Input),
              new OracleParameter("payType",OracleDbType.Varchar2,2,mr.DiagnosticPayment.PaymentType,ParameterDirection.Input),
              new OracleParameter("remarks",OracleDbType.Varchar2,300,mr.Remarks,ParameterDirection.Input),
              new OracleParameter("p_dr_no",OracleDbType.Varchar2,100,mr.DRNo,ParameterDirection.Input),
              new OracleParameter("p_nrs_stn",OracleDbType.Varchar2,100,mr.NursingTestOrder.NursingStationID,ParameterDirection.Input),
              new OracleParameter("p_payment_string",OracleDbType.Varchar2,10000,mr.DiagnosticPayment.PaymentString,ParameterDirection.Input),
              new OracleParameter("eBy",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("entryDate",OracleDbType.Date,20,mr.EntryParameter.EntryDate,ParameterDirection.Input),
              new OracleParameter("comp",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("loc",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("mac",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)
              
             };           
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           OracleParameter prm1 = parameterList[1];        
          string DMR_No = (string)(OracleString)prm1.Value;
          return DMR_No; 
       }
       #endregion

       #region GetDueByHCN
       public List<DiagnosticMR> GetDueByHCN(string HCN)
       {
           string packageName = "PKG_Diag_MR_COLL.get_due_by_hcn";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_hcn",OracleDbType.Varchar2,30,HCN,ParameterDirection.Input)
            };
           return GetDueByHCNHist(packageName, parameterList);

       }
       private List<DiagnosticMR> GetDueByHCNHist(string packageName, OracleParameter[] parameterList)
       {
           List<DiagnosticMR> oDiagMRS = new List<DiagnosticMR>();

           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               DiagnosticMR oDiagMR = new DiagnosticMR();
               oDiagMR.MRNo = (string)rdr["MR_NO"].ToString();
               oDiagMR.DueStatus = rdr["DUE_STATUS"].ToString();

               Ticket oTicket = new Ticket();
               oTicket.TicketNo = rdr["TKT_NO"].ToString();
               oTicket.TicketType = rdr["TKT_TYPE"].ToString();
               oDiagMR.Prescription = oTicket;

               OPDPayment oPayment = new OPDPayment();
               oPayment.NetAmount = Convert.ToDecimal(rdr["NET_PAID"].ToString());
               oPayment.Advance = Convert.ToDecimal(rdr["ADVANCE"].ToString());
               oPayment.PreviousDue = Convert.ToDecimal(rdr["DUE"].ToString());
               oDiagMR.DiagnosticPayment = oPayment;

               oDiagMRS.Add(oDiagMR);

           }
           rdr.Close();
           return oDiagMRS;

       }

       #endregion

       #region GetDiagHistory
       public List<DiagnosticMR> GetDiagHistory(string regno)
       {
           string packageName = "PKG_DIAG_SETUP.GET_DIAG_HISTORY";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,"'"+regno+"'",ParameterDirection.Input)
            };
           return GetDiagHist(packageName, parameterList);

       }
       private List<DiagnosticMR> GetDiagHist(string packageName, OracleParameter[] parameterList)
       {
           List<DiagnosticMR> dghs = new List<DiagnosticMR>();
          
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               DiagnosticMR diag = new DiagnosticMR(); 
               diag.MRNo = (string)rdr[0];
               TestFee tfe = new TestFee();
               TestSub tsub = new TestSub();
               TestGroup tg = new TestGroup();
               tg.GroupId = (string)rdr[5];
               tsub.TestGroup = tg;
               tsub.TestMainTitle = (string)rdr[7];
               tsub.TestSubTitle = (string)rdr[9];
               //grp.GroupId = (string)rdr[4];
               //tfe.TestSub.TestGroup = grp;
               tfe.Fee = (Decimal)rdr[10];
               tfe.TestSub = tsub;
               diag.test = tfe;

               InPatient hcno = new InPatient();
               hcno.HCN = (string)rdr[1];
               diag.Patient = hcno;

               dghs.Add(diag);

           }
           rdr.Close();
           return dghs;

       }

       #endregion

       #region GetDraftList
       public List<DiagnosticMR> GetDraftList(string entryby)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_COLL_DRAFT";
           OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("EntryBy",OracleDbType.Varchar2,20,entryby,ParameterDirection.Input)

           };
           return GetDraftListsetup(packageName, parameterList);
       }
       private List<DiagnosticMR> GetDraftListsetup(string packageName, OracleParameter[] parameterList)
       {
           List<DiagnosticMR> diag = new List<DiagnosticMR>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {

               DiagnosticMR dg = new DiagnosticMR();
               dg.DraftNo = (string)rdr[0];
               dg.Date = DateTime.Parse(rdr[2].ToString());

               Ticket tkt = new Ticket();
               tkt.TicketNo = (string)rdr[5];
               dg.Prescription = tkt;

               TestFee fee = new TestFee();
               fee.Fee = decimal.Parse(rdr[3].ToString());
               dg.test = fee;

               InPatient hcn = new InPatient();
               hcn.HCN = (string)rdr[1];
               hcn.Name = (string)rdr[4];
               dg.Patient = hcn;

               diag.Add(dg);

           }
           rdr.Close();
           return diag;
       }
       #endregion

       #region SaveDiagnosticMRDraft
       public short SaveDiagnosticMRDraft(DiagnosticMR mr)
       {
           string tests = "";
           foreach (TestFee dt in mr.Tests)
           {
               tests += dt.TestSub.SpecimenCollectionRoom.RoomID + ":" + (dt.TestSub.Technologist.ID == "" ? "0" : dt.TestSub.Technologist.ID) + ":" + dt.TestSub.ReportGroup.ReportGroupID + ":" + dt.TestSub.TestDepartment + ":" + dt.TestSub.TestGroup + ":" + dt.TestSub.TestMainID + ":" + dt.TestSub.TestSubID + ":" + dt.FeeCategory + ":" + dt.Fee + ":" + dt.DeptFee + ":" + dt.RefdFee + ":" + dt.DoctorFee + ":" + dt.Discount + ":" + dt.VAT + ";";
           }
           string packageName = "PKG_Diag_MR_COLL.INSERT_DIAG_COLLECTION_DRAFT";
           OracleParameter[] parameterList = new OracleParameter[]{
             
               new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("PrescriptionNo",OracleDbType.Varchar2,30,mr.Prescription.TicketNo,ParameterDirection.Input),
               new OracleParameter("prescriptionType",OracleDbType.Varchar2,2,mr.Prescription.TicketType,ParameterDirection.Input),
               new OracleParameter("hcn",OracleDbType.Varchar2,30,mr.Patient.HCN,ParameterDirection.Input),
               new OracleParameter("deptID",OracleDbType.Varchar2,5,mr.Patient.Department.DepartmentID,ParameterDirection.Input),
               new OracleParameter("unitID",OracleDbType.Varchar2,5,mr.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
               new OracleParameter("docID",OracleDbType.Varchar2,30,mr.Doctor.ID,ParameterDirection.Input),
               new OracleParameter("regID",OracleDbType.Varchar2,30,mr.Patient.RegistrationNo,ParameterDirection.Input),
               new OracleParameter("StaffID",OracleDbType.Varchar2,30,mr.Patient.StaffID,ParameterDirection.Input),
               new OracleParameter("P_TEST_COLLS",OracleDbType.Varchar2,4000,tests,ParameterDirection.Input),
               new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("LocationID",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("MachineID",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)
       };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       #endregion

       #region UpdateReffDoctor
       public short UpdateReffDoctor(DiagnosticMR mr)
       {
           string packageName = "PKG_Diag_MR_COLL.UPDATE_REFD_DOCTOR";
           OracleParameter[] parameterList = new OracleParameter[]{             
               new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_mr_no",OracleDbType.Varchar2,30,mr.MRNo,ParameterDirection.Input),
               new OracleParameter("p_reff_org",OracleDbType.Varchar2,5,mr.RefdOrg.OrgID,ParameterDirection.Input),
               new OracleParameter("p_reff_doc",OracleDbType.Varchar2,30,mr.Doctor.ID,ParameterDirection.Input),
               new OracleParameter("p_remarks",OracleDbType.Varchar2,300,mr.Remarks,ParameterDirection.Input),              
               new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)
       };
           short i = DALHelper.Update(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       #endregion

       #region GetPatientMrNoWise
       public InPatient GetCurrentPatient(string mrno)
       {

           string packageName = "PKG_DIAG_SETUP.GET_CURRENT_PATIENT";
           OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
                
           };
           return GetPatregistration(packageName, parameterList);
       }
       public LoadPatient GetCurrentPatientByPhone(string PhoneNo)
       {

           string packageName = "PKG_DIAG_SETUP.GET_CURRENT_PATIENT_MOBILE";
           OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mobile_no",OracleDbType.Varchar2,30,PhoneNo,ParameterDirection.Input)
                
           };
           return GetPatregistrationByPhone(packageName, parameterList);
       }
        private LoadPatient GetPatregistrationByPhone(string packageName, OracleParameter[] parameterList)
       {
           LoadPatient patLoad = new LoadPatient();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           if(rdr.Read())
           {
               patLoad.MRNo=(string)rdr["mr_no"].ToString();
               InPatient pat=new InPatient();
               pat.Name = (string)rdr["PatientName"].ToString();
               pat.DOB =Convert.ToDateTime(rdr["DOB"].ToString());
               pat.HCN = (string)rdr["HCN"].ToString();
               pat.RegistrationNo = (string)rdr["reg_id"].ToString();
               pat.Sex = (string)rdr["Sex"].ToString();
               Age ag = new Age();
               ag.Year = int.Parse(rdr["age_y"].ToString());
               ag.Month = int.Parse(rdr["age_m"].ToString());
               ag.Day = int.Parse(rdr["age_d"].ToString());
               ag.Hour = int.Parse(rdr["age_h"].ToString());
               pat.Age = ag;   
               patLoad.InPatient=pat;
           }
           rdr.Close();
           return patLoad;
       }
       private InPatient GetPatregistration(string packageName, OracleParameter[] parameterList)
       {
           InPatient pat = new InPatient();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               pat.Name = (string)rdr["PatientName"].ToString();
               pat.DOB =Convert.ToDateTime(rdr["DOB"].ToString());
               pat.HCN = (string)rdr["HCN"].ToString();
               pat.RegistrationNo = (string)rdr["reg_id"].ToString();
               pat.Sex = (string)rdr["Sex"].ToString();
               Age ag = new Age();
               ag.Year = int.Parse(rdr["age_y"].ToString());
               ag.Month = int.Parse(rdr["age_m"].ToString());
               ag.Day = int.Parse(rdr["age_d"].ToString());
               ag.Hour = int.Parse(rdr["age_h"].ToString());
               pat.Age = ag;            
           }
           rdr.Close();
           return pat;
       }
       #endregion

       #region GetDmrCollMaster
       public DiagnosticMR GetDmrCollMaster(string mrno)
       {

           string packageName = "PKG_Diag_MR_COLL.GET_DMR_COLL_MASTER";
           OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
                
           };
           return GetDmrCollMasters(packageName, parameterList);
       }

       private DiagnosticMR GetDmrCollMasters(string packageName, OracleParameter[] parameterList)
       {
           DiagnosticMR dmr = new DiagnosticMR();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               dmr.MRNo = (string)rdr["MR_NO"].ToString();
               dmr.TransNo = (string)rdr["TRANSAC_NO"].ToString();
               Ticket otkt = new Ticket();
               otkt.TicketType = (string)rdr["TKT_TYPE"].ToString();
               dmr.Prescription = otkt;
               OPDPayment DiagnosticPayment = new OPDPayment();
               DiagnosticPayment.Amount = Convert.ToDecimal(rdr["NET_PAID"].ToString());
               DiagnosticPayment.PreviousDue = Convert.ToInt32(rdr["DUE"]);
               dmr.DiagnosticPayment = DiagnosticPayment;              
           }
           rdr.Close();
           return dmr;
       }
       #endregion

       #region SaveDuePayment

       public string SaveDuePayment(DuePayment oDuePay)
       {
           string packageName = "PKG_Diag_MR_COLL.INSERT_DUE_PAYMENT";
           OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_prev_mr_no",OracleDbType.Varchar2,30,oDuePay.DiagnosticMR.MRNo,ParameterDirection.Input),
                new OracleParameter("p_rev_hd_grp",OracleDbType.Varchar2,3,oDuePay.RevHdGrp,ParameterDirection.Input),
                new OracleParameter("p_rev_hd",OracleDbType.Varchar2,6,oDuePay.RevHd,ParameterDirection.Input),
                new OracleParameter("p_purpose_id",OracleDbType.Varchar2,6,oDuePay.PurposeId,ParameterDirection.Input),
                new OracleParameter("p_paid_amt",OracleDbType.Varchar2,300,oDuePay.PaidAmt,ParameterDirection.Input),  
                new OracleParameter("p_pay_type",OracleDbType.Varchar2,300,oDuePay.OPDPayment.PaymentType,ParameterDirection.Input), 
                new OracleParameter("p_staff_id",OracleDbType.Varchar2,30,oDuePay.StaffId,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oDuePay.Remarks,ParameterDirection.Input),
                new OracleParameter("p_payment_string",OracleDbType.Varchar2,10000,oDuePay.OPDPayment.PaymentString,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oDuePay.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oDuePay.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oDuePay.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oDuePay.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oDuePay.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return "1";         
           else return "0";
       }
       #endregion

       #region DMRTest
       public List<TestFee> GetReportTest(string mrno)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_TEST";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
           return GetRepTest(packageName, parameterList);
       }
       private List<TestFee> GetRepTest(string packageName, OracleParameter[] parameterList)
       {
           List<TestFee> testfees = new List<TestFee>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               TestFee pat = new TestFee();

               FeeCategory oFeeCat = new FeeCategory();
               oFeeCat.FeeCategoryID = (string)rdr[10].ToString();
               pat.FeeCategory = oFeeCat;              

               TestSub tsub = new TestSub();
               tsub.TestSubID = (string)rdr[1];
               tsub.TestSubTitle = (string)rdr[2];
               LabRoom lb = new LabRoom();
               lb.RoomID = (string)rdr[14];
               tsub.LabRoom = lb; 
               tsub.PanelID = (string)rdr[16];
               

               Department dp = new Department();
               dp.DepartmentID = (string)rdr[7];
               tsub.TestDepartment = dp;
               
               TestGroup tg = new TestGroup();
               tg.GroupId = (string)rdr[3];
               tsub.TestGroup = tg;

               Specimen spc = new Specimen();
               spc.SpecimenID = (string)rdr[13];
               tsub.Specimen = spc;

              
               ReportGroup rptgr = new ReportGroup();
               rptgr.ReportGroupID = (string)rdr[8];
               rptgr.ReportGroupTitle = (string)rdr[9];
               tsub.ReportGroup = rptgr;

              
               tsub.TestMainID = (string)rdr[5];
               tsub.TestMainTitle = (string)rdr[6];
             
               pat.TestSub = tsub;


               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;

       }
       #endregion

       #region GetAdvance
       public DiagnosticMR GetAdvance(string mrno)
       {

           string packageName = "PKG_Diag_MR_COLL.GET_ADVANCE";
           OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
                
           };
           return GetAdvancePayment(packageName, parameterList);
       }
       private DiagnosticMR GetAdvancePayment(string packageName, OracleParameter[] parameterList)
       {
           DiagnosticMR dmr = new DiagnosticMR();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {              
               OPDPayment DiagnosticPayment = new OPDPayment();
               DiagnosticPayment.NetAmount = Convert.ToDecimal(rdr["NET_PAID"].ToString());
               DiagnosticPayment.Advance = Convert.ToDecimal(rdr["advance"].ToString());
               dmr.DiagnosticPayment = DiagnosticPayment;
               dmr.DueStatus = rdr["DUE_STATUS"].ToString();
           }
           rdr.Close();
           return dmr;
       }
       #endregion

       #region DMRTest
       public List<TestFee> GetDmrTest(string mrno)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_TEST_FOR_SPC";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
           return GetReportTest(packageName, parameterList);
       }
       public List<TestFee> GetDmrTest(string mrno,string Dept,string reportGrp)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_TEST_FOR_SPC";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
           return GetReportTest(packageName, parameterList);
       }
       public List<TestFee> GetDmrTestForCancel(string mrno)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_TEST_FOR_CANCEL";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
           return GetReportTest(packageName, parameterList);
       }
       public List<TestFee> GetDmrTestForRefund(string mrno)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_TEST_FOR_REFUND";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
           return GetReportTest(packageName, parameterList);
       }
       private List<TestFee> GetReportTest(string packageName, OracleParameter[] parameterList)
       {
           List<TestFee> testfees = new List<TestFee>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               TestFee pat = new TestFee();

               FeeCategory oFeeCat = new FeeCategory();
               oFeeCat.FeeCategoryID = (string)rdr["FEE_CAT_ID"];
               pat.FeeCategory = oFeeCat;

               pat.Fee = Convert.ToDecimal(rdr["FEE"].ToString());
               pat.DeptFee = Convert.ToDecimal(rdr["DEPT_AMT"].ToString());
               pat.DoctorFee = Convert.ToDecimal(rdr["DOC_AMT"].ToString());
               pat.RefdFee = Convert.ToDecimal(rdr["REFF_DEPT_AMT"].ToString());
               pat.Discount = Convert.ToDecimal(rdr["DISC"].ToString());
               pat.VAT = Convert.ToDecimal(rdr["VAT"].ToString());

               TestSub tsub = new TestSub();
               tsub.TestSubID = (string)rdr["TEST_DET_ID"];
               tsub.TestSubTitle = (string)rdr["TESTDETAILS"];
              

               LabRoom lb = new LabRoom();
               lb.RoomID = (string)rdr["LAB_ROOM"];
               tsub.LabRoom = lb;
               tsub.PanelID = (string)rdr["PNL_ID"];
               tsub.PanelTitle = rdr["PNL_TITLE"] != DBNull.Value ? rdr["PNL_TITLE"].ToString() : "";

               Department dp = new Department();
               dp.DepartmentID = (string)rdr["DEPT_ID"];
               tsub.TestDepartment = dp;

               TestGroup tg = new TestGroup();
               tg.GroupId = (string)rdr["GROUP_ID"];
               tsub.TestGroup = tg;

               Specimen spc = new Specimen();
               spc.SpecimenID = (string)rdr["SPECIMEN_ID"];
               tsub.Specimen = spc;

               SpecimenCollectionRoom oSpc = new SpecimenCollectionRoom();
               oSpc.RoomID = (string)rdr["SPC_ROOM_ID"].ToString();
               tsub.SpecimenCollectionRoom = oSpc;

               SpecimenHolder oSph = new SpecimenHolder();
               oSph.HolderID = (string)rdr["CONTAINER_ID"].ToString();
               oSph.HolderQuantity = rdr["CONTAINER_QTY"].ToString();
               tsub.SpecimenHolder = oSph;

               ReportGroup rptgr = new ReportGroup();
               rptgr.ReportGroupID = (string)rdr["RPT_GRP_ID"];
               rptgr.ReportGroupTitle = rdr["REPORTGROUP"] != DBNull.Value ? (string)rdr["REPORTGROUP"].ToString() : "";
               tsub.ReportGroup = rptgr;

               tsub.TestMainID = (string)rdr["TEST_MAIN_ID"];
               tsub.TestMainTitle = (string)rdr["TESTNAME"];

               TestMethod oMet = new TestMethod();
               oMet.MethodID = (string)rdr["TEST_METHOD_ID"].ToString();
               tsub.TestMethod = oMet;

               tsub.AccCloseFlag = (string)rdr["ACC_CLOSE_FLAG"].ToString();
               tsub.TicketType = (string)rdr["TKT_TYPE"].ToString();
               tsub.TicketNo = (string)rdr["TKT_NO"].ToString();
               pat.TestSub = tsub;


               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;

       }     
       #endregion

       #region GetTotalTestFee
       public List<TestFee> GetTotalTestFee(string mrno)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_TEST_TOTAL_FEE";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
           return GetTotalFeeDetails(packageName, parameterList);
       }
        private List<TestFee> GetTotalFeeDetails(string packageName, OracleParameter[] parameterList)
       {
           List<TestFee> testfees = new List<TestFee>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               TestFee pat = new TestFee();
               pat.Advance = Convert.ToDecimal(rdr["ADVANCE"].ToString());
               pat.Due = Convert.ToDecimal(rdr["DUE"].ToString());
               pat.NetPaid = Convert.ToDecimal(rdr["NET_PAID"].ToString());
               pat.DueStatus = (String)rdr["DUE_STATUS"].ToString();
               AccountsPayment oAcc = new AccountsPayment();
               oAcc.CashAmount = Convert.ToDouble(rdr["CASH_AMT"].ToString());
               oAcc.DebitCardAmount = Convert.ToDouble(rdr["DEBIT_CARD_AMT"].ToString());
               oAcc.CreditCardAmount = Convert.ToDouble(rdr["CREDIT_CARD_AMT"].ToString());
               pat.AccountsPayment = oAcc;
               
               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;

       }     
       #endregion

       #region GetReffDoctor
        public List<DiagnosticMR> GetReffDoctor(string mrno)
        {
            string packageName = "PKG_Diag_MR_COLL.GET_DMR_REFF_DOCTOR";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
            };
            return GetReffDoctorDetails(packageName, parameterList);
        }
        private List<DiagnosticMR> GetReffDoctorDetails(string packageName, OracleParameter[] parameterList)
        {
            List<DiagnosticMR> oDiags = new List<DiagnosticMR>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DiagnosticMR oDiag = new DiagnosticMR();
                Ticket oTicket = new Ticket();
                oTicket.TicketType = rdr["TKT_TYPE"].ToString();
                oDiag.Prescription = oTicket;
                RefdOrg oReff = new RefdOrg();
                oReff.OrgID = rdr["REFF_ORG_ID"].ToString();
                oDiag.RefdOrg = oReff;
                Doctor oDoctor = new Doctor();
                oDoctor.ID = rdr["DOC_ID"].ToString();
                oDiag.Doctor = oDoctor;
                oDiag.Remarks= rdr["REMARKS"].ToString();

                oDiags.Add(oDiag);
            }
            rdr.Close();
            return oDiags;

        }
        #endregion

       #region GetDmrTestsForIPD
       public List<TestFee> GetDmrTestsForIPD(string RegNo)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_DMR_COLL_TEST_FOR_IPD";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_reg_id",OracleDbType.Varchar2,30,RegNo,ParameterDirection.Input)
            };
           return GetDmrTestsDetailsForIPD(packageName, parameterList);
       }
       private List<TestFee> GetDmrTestsDetailsForIPD(string packageName, OracleParameter[] parameterList)
       {
           List<TestFee> testfees = new List<TestFee>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               TestFee pat = new TestFee();

               FeeCategory oFeeCat = new FeeCategory();
               oFeeCat.FeeCategoryID = (string)rdr["FEE_CAT_ID"];
               pat.FeeCategory = oFeeCat;

               pat.Fee = Convert.ToDecimal(rdr["FEE"].ToString());
               pat.DeptFee = Convert.ToDecimal(rdr["DEPT_AMT"].ToString());
               pat.DoctorFee = Convert.ToDecimal(rdr["DOC_AMT"].ToString());
               pat.Discount = Convert.ToDecimal(rdr["DISC"].ToString());
               pat.VAT = Convert.ToDecimal(rdr["VAT"].ToString());

               TestSub tsub = new TestSub();
               tsub.TestSubID = (string)rdr["test_det_id"];
               tsub.TestSubTitle = (string)rdr["TestDetails"];

               LabRoom lb = new LabRoom();
               lb.RoomID = (string)rdr["LAB_ROOM_ID"];
               tsub.LabRoom = lb;
               tsub.PanelID = (string)rdr["pnl_id"];


               Department dp = new Department();
               dp.DepartmentID = (string)rdr["dept_id"];
               tsub.TestDepartment = dp;

               TestGroup tg = new TestGroup();
               tg.GroupId = (string)rdr["GROUP_ID"];
               tsub.TestGroup = tg;
              
               SpecimenCollectionRoom oSpc = new SpecimenCollectionRoom();
               oSpc.RoomID = (string)rdr["SPC_ROOM_ID"].ToString();
               tsub.SpecimenCollectionRoom = oSpc;
           
               ReportGroup rptgr = new ReportGroup();
               rptgr.ReportGroupID = (string)rdr["RPT_GRP_ID"];
               rptgr.ReportGroupTitle = (string)rdr["ReportGroup"];
               tsub.ReportGroup = rptgr;

               tsub.TestMainID = (string)rdr["test_main_id"];
               tsub.TestMainTitle = (string)rdr["TestName"];
               EntryParameter oEp = new EntryParameter();
               oEp.EntryDate =Convert.ToDateTime(rdr["ENTRY_DATE"]);
               tsub.EntryParameter = oEp;

               pat.TestSub = tsub;

               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;

       }
       #endregion

       #region GetNursingStation
       public List<NursingTestOrder> GetNursingStation()
       {
           string packageName = "PKG_Diag_MR_COLL.GET_NURSING_STATION";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
           return GetNursingStationDetails(packageName, parameterList);
       }
       private List<NursingTestOrder> GetNursingStationDetails(string packageName, OracleParameter[] parameterList)
       {
           List<NursingTestOrder> testfees = new List<NursingTestOrder>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               NursingTestOrder pat = new NursingTestOrder();
               pat.NursingStationID = (string)rdr["NS_STN_ID"];
               pat.ReqID = (string)rdr["DR_ID"];
               pat.NursingStationTitle = (string)rdr["NR_STN_TITLE"];                           
               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;
       }
       #endregion

       #region GetAccountsPayment
       public List<AccountsPayment> GetAccountsPayment(string CollectionDate,string UserID)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_COLL_FOR_ACCOUNTS";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_date",OracleDbType.Varchar2,50,CollectionDate,ParameterDirection.Input),
                new OracleParameter("p_user_id",OracleDbType.Varchar2,50,UserID,ParameterDirection.Input)
            };
           return GetAccountsPaymentDetails(packageName, parameterList);
       }
       private List<AccountsPayment> GetAccountsPaymentDetails(string packageName, OracleParameter[] parameterList)
       {
           List<AccountsPayment> oAccPays = new List<AccountsPayment>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               AccountsPayment pat = new AccountsPayment();
               pat.CashAmount = Convert.ToDouble(rdr["cash"]);
               pat.DebitCardAmount = Convert.ToDouble(rdr["Debit"]);
               pat.CreditCardAmount = Convert.ToDouble(rdr["Credit"]);
               pat.TotalCollection = Convert.ToDouble(rdr["Paid"]);
               pat.RefundAmount = Convert.ToDouble(rdr["Refund"]);
             
               oAccPays.Add(pat);
           }
           rdr.Close();
           return oAccPays;
       }
       #endregion

       #region GetCollectionSummary
       public List<OPDPayment> GetCollectionSummary(string StartDate, string EndDate)
       {
           string packageName = "PKG_Diag_MR_COLL.get_collection_statements";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,StartDate,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,EndDate,ParameterDirection.Input)
            };
           return GetCollectionSummaryDetails(packageName, parameterList);
       }
       private List<OPDPayment> GetCollectionSummaryDetails(string packageName, OracleParameter[] parameterList)
       {
           List<OPDPayment> oAccPays = new List<OPDPayment>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               OPDPayment pat = new OPDPayment();
               pat.PurposeID = (string)rdr["PURPOSE_ID"].ToString();
               pat.PurposeTitle = (string)rdr["PURPOSE_TITLE"].ToString();
               pat.CashAmount = Convert.ToDouble(rdr["CASH_AMT"]);
               pat.DebitCardAmount = Convert.ToDouble(rdr["DEBIT_CARD_AMT"]);
               pat.CreditCardAmount = Convert.ToDouble(rdr["CREDIT_CARD_AMT"]);
               pat.NetAmount = Convert.ToDecimal(rdr["NET_AMT"]);

               oAccPays.Add(pat);
           }
           rdr.Close();
           return oAccPays;
       }
       #endregion

       #region GetUserWiseCashCollection
       public List<MoneyReceiptRO> GetUserWiseCashCollection(string StartDate, string EndDate)
       {
           string packageName = "PKG_Diag_MR_COLL.get_user_wise_cash_coll";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,StartDate,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,EndDate,ParameterDirection.Input)
            };
           return GetUserWiseCashCollectionDetails(packageName, parameterList);
       }
       private List<MoneyReceiptRO> GetUserWiseCashCollectionDetails(string packageName, OracleParameter[] parameterList)
       {
           List<MoneyReceiptRO> oUserCashs = new List<MoneyReceiptRO>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               MoneyReceiptRO oUser = new MoneyReceiptRO();
               oUser.EntryBy = (string)rdr["ENTRY_BY"].ToString();
               oUser.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
               oUser.MRNumber = Convert.ToDouble(rdr["MR_NO"].ToString());
               oUser.NetAmt = Convert.ToDouble(rdr["NET_AMT"].ToString());

               oUserCashs.Add(oUser);
           }
           rdr.Close();
           return oUserCashs;
       }
       #endregion

       #region GetAllCollectionSummary
       public List<MoneyReceiptRO> GetAllCollectionSummary(string StartDate, string EndDate)
       {
           string packageName = "PKG_Diag_MR_COLL.get_collection_summary";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,StartDate,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,50,EndDate,ParameterDirection.Input)
            };
           return GetAllCollectionSummaryDetails(packageName, parameterList);
       }
       private List<MoneyReceiptRO> GetAllCollectionSummaryDetails(string packageName, OracleParameter[] parameterList)
       {
           List<MoneyReceiptRO> oCollections = new List<MoneyReceiptRO>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               MoneyReceiptRO oColl = new MoneyReceiptRO();
               oColl.MasterGroup = rdr["MasterGroup"] != DBNull.Value ? (string)rdr["MasterGroup"].ToString() : "";
               oColl.TestGroupID = rdr["GROUP_ID"] != DBNull.Value ? (string)rdr["GROUP_ID"].ToString() : "";
               oColl.TestGroupName = rdr["GRP_TITLE"] != DBNull.Value ? (string)rdr["GRP_TITLE"].ToString() : "";
               oColl.TestMainID = rdr["TEST_MAIN_ID"] != DBNull.Value ? (string)rdr["TEST_MAIN_ID"].ToString() : "";
               oColl.TestMainName = rdr["TEST_MAIN_TITLE"] != DBNull.Value ? (string)rdr["TEST_MAIN_TITLE"].ToString() : "";
               oColl.Qty = Convert.ToDouble(rdr["qty"].ToString());
               oColl.Amount = Convert.ToDouble(rdr["Amount"].ToString());
               oColl.Discount = Convert.ToDouble(rdr["Discount"].ToString());
               oColl.NetAmt = Convert.ToDouble(rdr["NetAmount"].ToString());              
               oColl.PaidAmt = Convert.ToDouble(rdr["AdvancePaid"].ToString());
               oColl.FullPaid = Convert.ToDouble(rdr["FullPaid"].ToString());
               oColl.Due = Convert.ToDouble(rdr["CurrentDue"].ToString());
               oColl.Vat = Convert.ToDouble(rdr["VAT"].ToString());
               oColl.TotalDiscount = Convert.ToDouble(rdr["TotDisc"].ToString());
               oColl.PrevDueColl = Convert.ToDouble(rdr["PrevDuePaid"].ToString());
               oColl.RefundAmt = Convert.ToDouble(rdr["Refund"].ToString());

               oCollections.Add(oColl);
           }
           rdr.Close();
           return oCollections;
       }
       #endregion

       #region SaveAccountsPayment
       public string SaveAccountsPayment(AccountsPayment oAccounts)
       {
           string packageName = "PKG_Diag_MR_COLL.INSERT_USER_CLOSE_REGISTER";
           OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_voucher_no",OracleDbType.Varchar2,50,oAccounts.VoucherNo,ParameterDirection.Output),
            new OracleParameter("p_user_id",OracleDbType.Varchar2,50,oAccounts.UserID,ParameterDirection.Input),          
            new OracleParameter("p_cash_amount",OracleDbType.Varchar2,500,oAccounts.CashAmount,ParameterDirection.Input),
            new OracleParameter("p_credit_amount",OracleDbType.Varchar2,500,oAccounts.CreditCardAmount,ParameterDirection.Input),
            new OracleParameter("p_debit_amount",OracleDbType.Varchar2,500,oAccounts.DebitCardAmount,ParameterDirection.Input),
            new OracleParameter("p_net_amount",OracleDbType.Varchar2,500,oAccounts.PaymentAmount,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oAccounts.Remarks,ParameterDirection.Input),
            new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oAccounts.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oAccounts.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("LocationID",OracleDbType.Varchar2,2,oAccounts.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("MachineID",OracleDbType.Varchar2,20,oAccounts.EntryParameter.MachineID,ParameterDirection.Input),
            new OracleParameter("p_date",OracleDbType.Varchar2,50,oAccounts.CollectionDate,ParameterDirection.Input),
        };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           OracleParameter prm1 = parameterList[1];
           string Voucher_No = (string)(OracleString)prm1.Value;
           return Voucher_No; 
          
           //if ((OracleDecimal)prm.Value == 1)
           //    return 1;
           //else return 0;
       }
       #endregion

       #region GetNursingStationRegNum
       public List<NursingTestOrder> GetNursingStationRegNum(string ReqNo)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_REG_ID_BY_REQ";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_req_id",OracleDbType.Varchar2,30,ReqNo,ParameterDirection.Input)
            };
           return GetNursingStationRegNumDetails(packageName, parameterList);
       }
       private List<NursingTestOrder> GetNursingStationRegNumDetails(string packageName, OracleParameter[] parameterList)
       {
           List<NursingTestOrder> testfees = new List<NursingTestOrder>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               NursingTestOrder pat = new NursingTestOrder();
               pat.RegID = (string)rdr["REG_ID"];                   
               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;
       }
       #endregion

       #region GetIPDTests
       public List<TestFee> GetIPDTests(string RegNo,string DrNo)
       {
           string packageName = "PKG_Diag_MR_COLL.GET_IPD_TESTS";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_reg_id",OracleDbType.Varchar2,30,RegNo,ParameterDirection.Input),
                new OracleParameter("p_dr_no",OracleDbType.Varchar2,30,DrNo,ParameterDirection.Input)
            };
           return GetIPDTestsDetails(packageName, parameterList);
       }
       private List<TestFee> GetIPDTestsDetails(string packageName, OracleParameter[] parameterList)
       {
           List<TestFee> testfees = new List<TestFee>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               TestFee pat = new TestFee();
               pat.Fee = Convert.ToDecimal(rdr["FEE"].ToString());
               pat.DeptFee = Convert.ToDecimal(rdr["DEPT_AMT"].ToString());
               pat.DoctorFee = Convert.ToDecimal(rdr["REFF_DOC_AMT"].ToString());
               pat.RefdFee = Convert.ToDecimal(rdr["REFF_DEPT_AMT"].ToString());
               pat.Discount = Convert.ToDecimal(rdr["DISC"].ToString());
               pat.VAT = Convert.ToDecimal(rdr["VAT"].ToString());

               EntryParameter oEntry = new EntryParameter();
               oEntry.Active = rdr["Active"].ToString();
               pat.EParameter = oEntry;

               TestSub tsub = new TestSub();
               tsub.TestSubID = (string)rdr["test_det_id"];
               tsub.TestSubTitle = (string)rdr["TEST_DET_TITLE"];
               FeeCategory oFeeCat = new FeeCategory();
               oFeeCat.FeeCategoryID = (string)rdr["FEE_CAT_ID"].ToString();
               oFeeCat.FeeCategoryTitle = (string)rdr["cat_title"].ToString();
               pat.FeeCategory = oFeeCat;
               LabRoom lb = new LabRoom();
               lb.RoomID = (string)rdr["LAB_ROOM_ID"];
               tsub.LabRoom = lb;
               tsub.PanelID = (string)rdr["pnl_id"];
               tsub.PanelTitle = rdr["pnl_title"] != DBNull.Value ? (string)rdr["pnl_title"] : "";

               Department dp = new Department();
               dp.DepartmentID = (string)rdr["dept_id"];
               dp.DepartmentTitle = (string)rdr["dept_title"];
               tsub.TestDepartment = dp;

               TestGroup tg = new TestGroup();
               tg.GroupId = (string)rdr["GROUP_ID"];
               tg.GroupTitle = (string)rdr["grp_tile"];
               tsub.TestGroup = tg;

               SpecimenCollectionRoom oSpc = new SpecimenCollectionRoom();
               oSpc.RoomID = (string)rdr["SPC_ROOM_ID"].ToString();
               oSpc.RoomTitle = (string)rdr["room_title"].ToString();
               tsub.SpecimenCollectionRoom = oSpc;

               ReportGroup rptgr = new ReportGroup();
               rptgr.ReportGroupID = (string)rdr["RPT_GRP_ID"];
               rptgr.ReportGroupTitle = (string)rdr["grp_title"];
               tsub.ReportGroup = rptgr;

               tsub.TestMainID = (string)rdr["test_main_id"];
               tsub.TestMainTitle = (string)rdr["TEST_MAIN_TITLE"];
             
               pat.TestSub = tsub;

               testfees.Add(pat);
           }
           rdr.Close();
           return testfees;

       }
       #endregion

       #region VerifyMRNo
       public string verifyMrno(string mrno)
       {
           string packageName = "PKG_Diag_MR_COLL.VERIFY_MRNO";
           OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Result",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
               new OracleParameter("MrNo",OracleDbType.Varchar2,30,mrno,ParameterDirection.Input)
           };
           short i = DALHelper.Insert(connString,packageName,parameterList);
           OracleParameter prm = parameterList[0];
           string output = (string)(OracleString)prm.Value;
           return output;
       }
#endregion

       #region SaveDiagnosticRefundMR
       public string SaveDiagnosticRefundMR(DiagnosticMR mr)
       {
           string packageName = "PKG_Diag_MR_COLL.REFUND_MR_COLLECTION";
           OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_trans_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_aprv_id",OracleDbType.Varchar2,30,mr.ApprovalID,ParameterDirection.Input),
              new OracleParameter("p_mr_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_paid_mr_no",OracleDbType.Varchar2,30,mr.MRNo,ParameterDirection.Input),                     
              new OracleParameter("P_TEST_COLLS",OracleDbType.Varchar2,20000,mr.TestString1,ParameterDirection.Input),
              new OracleParameter("p_purpose_id",OracleDbType.Varchar2,6,mr.PurposeID,ParameterDirection.Input),
              new OracleParameter("p_refd_amt",OracleDbType.Decimal,10,mr.RefundAmount,ParameterDirection.Input),
              new OracleParameter("p_refund_cause_id",OracleDbType.Varchar2,20,mr.TestRefundCause,ParameterDirection.Input),
              new OracleParameter("p_remarks",OracleDbType.Varchar2,100,mr.Remarks,ParameterDirection.Input),
              new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("p_entry_date",OracleDbType.Date,20,mr.EntryParameter.EntryDate,ParameterDirection.Input),
              new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)              
             };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           OracleParameter prm1 = parameterList[2];
           string DMR_No = (string)(OracleString)prm1.Value;
           return DMR_No;
       }
       #endregion

       #region SaveLabelTestAssociation
       public short SaveLabelTestAssociation(TestSub oTestSub)
       {
           string packageName = "PKG_DIAG_SETUP.INSERT_TEST_LABEL";
           OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_dept_id",OracleDbType.Varchar2,5,oTestSub.TestDepartment.DepartmentID,ParameterDirection.Input),
            new OracleParameter("p_grp_id",OracleDbType.Varchar2,5,oTestSub.TestGroup.GroupId,ParameterDirection.Input),
            new OracleParameter("p_test_main_id",OracleDbType.Varchar2,5,oTestSub.TestMainID,ParameterDirection.Input),
            new OracleParameter("p_test_det_id_base",OracleDbType.Varchar2,10,oTestSub.TestSubID,ParameterDirection.Input),
            new OracleParameter("p_base_string",OracleDbType.Varchar2,20000,oTestSub.AllTest,ParameterDirection.Input),
            new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oTestSub.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oTestSub.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oTestSub.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oTestSub.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           return 0;
       }
       #endregion

       #region GetTestForLabel

       public List<TestSub> GetTestLabel(string TestDetID)
       {
           string packageName = "PKG_DIAG_SETUP.GET_TEST_LABEL";
           OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_test_det_id",OracleDbType.Varchar2,30,TestDetID,ParameterDirection.Input)
            };
           return GetTestLabelDetails(packageName, parameterList);
       }
       private List<TestSub> GetTestLabelDetails(string packageName, OracleParameter[] parameterList)
       {
           List<TestSub> oTests = new List<TestSub>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {              
               TestSub tsub = new TestSub();
               tsub.TestSubID = (string)rdr["TEST_DET_ID_SUB"].ToString();
               tsub.TestSubTitle = (string)rdr["TEST_DET_TITLE"].ToString();
               tsub.LabelGroup = (string)rdr["LBL_GRP"].ToString();
               tsub.Priority = (string)rdr["PRIORITY"].ToString();
               
               oTests.Add(tsub);
           }
           rdr.Close();
           return oTests;

       }     
      
       #endregion

       #region GetPatByEmerPres
       public List<EmergencyMasterRO> GetPatByEmerPres(string Prescription)
       {
           string packageName = "AGH_DMS.PKG_EMERGENCY_SETUP.GET_PAT_EMR_PRES";
           OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_prescription_no",OracleDbType.Varchar2,30,Prescription,ParameterDirection.Input)
              };

           return GetEmergencyPrescriptionDetails(packageName, parameterList);
       }
       private List<EmergencyMasterRO> GetEmergencyPrescriptionDetails(string packageName, OracleParameter[] parameterList)
       {
           List<EmergencyMasterRO> oDMRs = new List<EmergencyMasterRO>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               EmergencyMasterRO oDMR = new EmergencyMasterRO();
               oDMR.EmergencyPrescriptionID = (string)rdr["E_PRES_NO"].ToString();
               oDMR.TransactionNo = (string)rdr["TRANSAC_NO"].ToString();
               oDMR.HCN = (string)rdr["HCN"].ToString();
               oDMR.PatientName = (string)rdr["PatientName"].ToString();
               oDMR.DOB =Convert.ToDateTime(rdr["DOB"].ToString());
               oDMR.Age = (string)rdr["Age"].ToString();
               oDMR.Gender = (string)rdr["Sex"].ToString();
               oDMR.Address = (string)rdr["Address"].ToString();
               oDMR.EntryByName = (string)rdr["ENTRY_BY_NAME"].ToString();
               oDMR.TicketFee = Convert.ToDouble(rdr["TKT_FEE"]);
               oDMR.ConsultantFee = Convert.ToDouble(rdr["CONSULT_FEE"]);
               oDMR.ReffOrgName = rdr["ORG_TITLE"].ToString();
               oDMR.DoctorName = rdr["DOC_TITLE"].ToString();
               oDMR.FormatDept = rdr["FormatDept"].ToString();
               oDMR.MobileNo = rdr["MobileNo"].ToString();

               oDMRs.Add(oDMR);
           }
           rdr.Close();
           return oDMRs;
       }
       #endregion

       #region GetPatByEmerPres
       public List<EmergencyMasterRO> GetEmerDiagBill(string HCN)
       {
           string packageName = "AGH_DMS.PKG_EMERGENCY_SETUP.GET_PAT_EMR_DIAG_BILL";
           OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_hcn",OracleDbType.Varchar2,30,HCN,ParameterDirection.Input)
              };

           return GetEmerDiagBillDetails(packageName, parameterList);
       }
       private List<EmergencyMasterRO> GetEmerDiagBillDetails(string packageName, OracleParameter[] parameterList)
       {
           List<EmergencyMasterRO> oDMRs = new List<EmergencyMasterRO>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               EmergencyMasterRO oDMR = new EmergencyMasterRO();
               if (!rdr.IsDBNull(0))
               {
                   oDMR.NetPaid = Convert.ToDouble(rdr["NET_PAID"]);
               }
               else
               {
                   oDMR.NetPaid = 0;
               }
               if (!rdr.IsDBNull(1))
               {
                   oDMR.Qty = Convert.ToDouble(rdr["Qty"]);
               }
               else
               {
                   oDMR.Qty = 0;
               }


               oDMRs.Add(oDMR);
           }
           rdr.Close();
           return oDMRs;
       }
       #endregion
    }
}




 //TEST_COLL_OBJ tsc = new TEST_COLL_OBJ();
            
 //            List<TEST_COLL_OBJ> tests = new List<TEST_COLL_OBJ>();
 //            TEST_COLL_OBJ testObj;
 //            string helper = string.Empty;
 //            foreach(DiagnosticTest dt in mrc.DiagnosticTestCollections)
 //            {
 //                testObj = new TEST_COLL_OBJ();
 //               testObj.DepartmentCode=dt.DeptCode;
 //               testObj.MainCode=dt.MainCode;
 //                testObj.SubCode=dt.TestCode;
 //                testObj.TestType=dt.TestType;
 //                testObj.TestCharge=dt.Charge;
 //                tests.Add(testObj);
 //            }

 //           using (OracleConnection conn = new OracleConnection(Utility.GetConnectionString))
 //           {
 //               OracleCommand cmd = conn.CreateCommand();
 //               cmd.CommandType = CommandType.StoredProcedure;
 //               cmd.CommandText = "PKG_MR_COLL.S_DIAG_MR_COLLECTION";
 //               cmd.Parameters.Add(":P_TICKET_NO", OracleDbType.Varchar2,25).Value = mrc.TicketNo;
 //               cmd.Parameters.Add(":P_PATIENT_NO", OracleDbType.Varchar2,25).Value = mrc.Patient.PatientNo;
 //               cmd.Parameters.Add(":p_REG_no", OracleDbType.Varchar2).Value = mrc.Patient.RegistrationNo;
 //               cmd.Parameters.Add(":p_receipt_no", OracleDbType.Varchar2,25).Direction =ParameterDirection.Output;
 //               cmd.Parameters.Add(":p_patient_name", OracleDbType.Varchar2).Value = mrc.Patient.Name;
 //               cmd.Parameters.Add(":P_DOC_DEPT",OracleDbType.Varchar2).Value=mrc.Patient.Department.Code;
 //               cmd.Parameters.Add(":P_DOCTOR_ID",OracleDbType.Varchar2).Value=mrc.Patient.Doctor.ID;
 //               cmd.Parameters.Add(":p_sex",OracleDbType.Varchar2).Value=mrc.Patient.Sex;
 //               cmd.Parameters.Add(":p_age",OracleDbType.Int32).Value=mrc.Patient.Age;
 //               cmd.Parameters.Add(":P_age_Indicator",OracleDbType.Varchar2).Value=mrc.Patient.AgeIndicator;
 //               cmd.Parameters.Add(":P_TEST_COLLS",OracleDbType.Array).Value=tests.ToArray();
 //               cmd.Parameters[":P_TEST_COLLS"].UdtTypeName = "TEST_COLLECTIONS";
 //               cmd.Parameters.Add(":p_total_charge",OracleDbType.Int32).Value=mrc.TotalAmount;
 //               cmd.Parameters.Add(":p_disc",OracleDbType.Int32).Value=mrc.Discount;
 //               cmd.Parameters.Add(":p_net_paid",OracleDbType.Int32).Value=mrc.NetTotalAmount;
 //               cmd.Parameters.Add(":p_indoor_out_door_flag",OracleDbType.Int32).Value=mrc.IsPatientAdmitted;
 //               cmd.Parameters.Add(":staffOrPoorPatientDisc",OracleDbType.Int32).Value=mrc.IsDisountForStaff;
 //               cmd.Parameters.Add(":p_staff_id",OracleDbType.Int32).Value=mrc.Patient.StaffIndicatorByID;
 //               cmd.Parameters.Add(":p_YRCODE",OracleDbType.Varchar2).Value=mrc.FiscalYear;
 //               cmd.Parameters.Add(":p_user_id",OracleDbType.Varchar2).Value=mrc.EntryParameter.EntryByCode;
 //               cmd.Parameters.Add(":Booth",OracleDbType.Varchar2).Value=mrc.EntryParameter.EntryBooth;

 //               try
 //               {
 //                   conn.Open();
 //                   int i = cmd.ExecuteNonQuery();
 //                   helper = cmd.Parameters[3].Value.ToString();
 //               }

