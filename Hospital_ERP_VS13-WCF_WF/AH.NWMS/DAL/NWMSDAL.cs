using System.Data;
using AH.DUtility;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using AH.NWMS.MODEL;
using AH.OracleManager;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.IPDShared.MODEL;
using AH.DRUGS.MODEL;
using AH.DTMS.MODEL;
using System.Collections.Generic;
using System;
using AH.Shared.MODEL;
using AH.OPD.MODEL;
using System.Globalization;



namespace AH.NWMS.DAL
{
   public class NWMSDAL
    {
       private string connString = Utility.GetConnectionString(Utility.Module.IPDMIS);

       public List<DrugDose> GetDrugs(string age, string name, string drugID)
       {
           List<DrugDose> oDrugDoses = new List<DrugDose>();
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.GET_DRUGS_BY_NAMEAGE";
           OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("age",OracleDbType.Varchar2,30,age,ParameterDirection.Input), 
                new OracleParameter("name",OracleDbType.Varchar2,30,name,ParameterDirection.Input),
                new OracleParameter("drugID",OracleDbType.Varchar2,30,drugID,ParameterDirection.Input)
            };
           OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               DrugDose oDrugDose = new DrugDose();
               DrugMaster oDrugMaster = new DrugMaster();
               oDrugMaster.ID = (string)rdr["DRUGID"];
               oDrugMaster.Name = (string)rdr["DRUGNAME"];

               DrugCompany oDrugCompany = new DrugCompany();
               oDrugCompany.ID = (string)rdr["COMPANYID"];
               oDrugCompany.Name = (string)rdr["COMPANYNAME"];
               oDrugMaster.DrugCompany = oDrugCompany;

               DrugGroup oDrugGroup = new DrugGroup();
               oDrugGroup.ID = (string)rdr["GROUPID"];
               oDrugGroup.Name = (string)rdr["GROUPNAME"];
               oDrugMaster.DrugGroup = oDrugGroup;

               DrugUnit oDrugUnit = new DrugUnit();
               oDrugUnit.ID = (string)rdr["UNITID"];
               oDrugUnit.Name = (string)rdr["UNITNAME"];
               oDrugMaster.DrugUnit = oDrugUnit;

               DrugPackType oDrugPackType = new DrugPackType();
               oDrugPackType.ID = (string)rdr["TYPEID"];
               oDrugPackType.Name = (string)rdr["PACKNAME"];
               oDrugMaster.DrugPackType = oDrugPackType;

               oDrugDose.DrugMaster = oDrugMaster;
               oDrugDoses.Add(oDrugDose);
           }
           rdr.Close();
           return oDrugDoses;
       }

       public List<DrugDose> GetAllProvidedDrugs(string  regID)
       {
           List<DrugDose> oDrugDoses = new List<DrugDose>();
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Get_All_Provided_Drug";
           OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("regID",OracleDbType.Varchar2,30,regID,ParameterDirection.Input)
            };
           OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               DrugDose oDrugDose = new DrugDose();
               DrugMaster oDrugMaster = new DrugMaster();
               oDrugMaster.ID =Convert.ToString((decimal)rdr["NUM"]);
               oDrugMaster.Name = (string)rdr["MEDICINE"];

               DrugGroup oDrugGroup = new DrugGroup();
               oDrugGroup.Name = (string)rdr["GENERICNAME"];
               oDrugMaster.DrugGroup = oDrugGroup;

               oDrugDose.B_A_MealName = (string)rdr["MEDICINEDOSE"];

               oDrugDose.DrugMaster = oDrugMaster;
               oDrugDoses.Add(oDrugDose);
           }
           rdr.Close();
           return oDrugDoses;
       }


       #region SaveNurseRequisition
       public short SaveNurseRequisition(NurseRequisition nrq)
       {
        //   string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Insert_Nurse_requisition";
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Insert_Nurse_requisition_new";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,nrq.Patient.HCN,ParameterDirection.Input),
                new OracleParameter("StaffID",OracleDbType.Varchar2,2,nrq.Patient.StaffID,ParameterDirection.Input),
                new OracleParameter("DeptID",OracleDbType.Varchar2,10,nrq.Patient.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,10,nrq.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorID",OracleDbType.Varchar2,30,nrq.Patient.Doctor.ID,ParameterDirection.Input),

                new OracleParameter("Prescription_ID",OracleDbType.Varchar2,30,nrq.Patient.ReferenceNo,ParameterDirection.Input),
                new OracleParameter("AgeY",OracleDbType.Varchar2,15,nrq.Patient.Age.Year,ParameterDirection.Input),
                new OracleParameter("AgeM",OracleDbType.Varchar2,15,nrq.Patient.Age.Month,ParameterDirection.Input),
                new OracleParameter("AgeD",OracleDbType.Varchar2,15,nrq.Patient.Age.Day,ParameterDirection.Input),
                new OracleParameter("AgeH",OracleDbType.Varchar2,15,nrq.Patient.Age.Hour,ParameterDirection.Input),
                new OracleParameter("Net_amount",OracleDbType.Varchar2,30,nrq.testsNetFee,ParameterDirection.Input),
                new OracleParameter("Bed_ID",OracleDbType.Varchar2,30,nrq.Patient.Bed.BedID,ParameterDirection.Input),

                new OracleParameter("RegID",OracleDbType.Varchar2,30,nrq.Patient.RegistrationNo,ParameterDirection.Input),
                new OracleParameter("NsStn",OracleDbType.Varchar2,10,nrq.Patient.NurseStation.NurseStationID,ParameterDirection.Input),
                new OracleParameter("remarks",OracleDbType.Varchar2,200,nrq.Patient.Remarks,ParameterDirection.Input),                           
                
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,nrq.drugs,ParameterDirection.Input),
                new OracleParameter("tests",OracleDbType.Varchar2,4000,nrq.tests,ParameterDirection.Input),  
               
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nrq.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,nrq.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,nrq.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,nrq.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }
       #endregion

       public short ChangeBedStatus(Bed bdst)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Change_Bed_Status";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("BedID",OracleDbType.Varchar2,4,bdst.BedID,ParameterDirection.Input), 
                new OracleParameter("BedStatus",OracleDbType.Varchar2,2,bdst.BedStatus,ParameterDirection.Input), 
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,bdst.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,bdst.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,bdst.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,bdst.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       public List<NWMSReceiveRequisition> ReceiveRequisition(string regId)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Get_Drug_ForReceive";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("regId",OracleDbType.Varchar2,30,regId,ParameterDirection.Input)
           };

           List<NWMSReceiveRequisition> reqRcv = new List<NWMSReceiveRequisition>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               NWMSReceiveRequisition oReqRcv = new NWMSReceiveRequisition();
               oReqRcv.RequisitionID = (string)rdr["dr_id"];

               DrugDose oDrugDose = new  DrugDose();

               DrugMaster oDrugMaster =new DrugMaster();
               oDrugMaster.ID = (string)rdr["DRUG_ID"];
               oDrugMaster.Name = (string)rdr["DRUGNAME"];

               DrugCompany oDrugCompany = new DrugCompany();
               oDrugCompany.ID = (string)rdr["drug_comp_id"];
               oDrugCompany.Name = (string)rdr["COMPANYNAME"];
               oDrugMaster.DrugCompany = oDrugCompany;

               DrugGroup oDrugGroup = new DrugGroup();
               oDrugGroup.ID = (string)rdr["group_id"];
               oDrugGroup.Name = (string)rdr["GROUPNAME"];
               oDrugMaster.DrugGroup = oDrugGroup;

               DrugUnit oDrugUnit = new DrugUnit();
               oDrugUnit.ID = (string)rdr["drug_unit_id"];
               oDrugUnit.Name = (string)rdr["UNITNAME"];
               oDrugMaster.DrugUnit = oDrugUnit;

               DrugPackType oDrugPackType = new DrugPackType();
               oDrugPackType.ID = (string)rdr["drug_type_id"];
               oDrugPackType.Name = (string)rdr["PACKNAME"];
               oDrugMaster.DrugPackType = oDrugPackType;

               oReqRcv.RequisitionQty =Convert.ToString((decimal)rdr["dr_qty"]);
               oReqRcv.RemainingQty = Convert.ToString((decimal)rdr["rem_qty"]);
               oReqRcv.ReceivedQty = Convert.ToString((decimal)rdr["rcv_qty"]);
               oReqRcv.ReceiveStatus = (string)rdr["receive_status"];

               oDrugDose.DrugMaster = oDrugMaster;
               oReqRcv.Drugs = oDrugDose;
               reqRcv.Add(oReqRcv);
           }
           rdr.Close();
           return reqRcv;
       }


       public List<NWMSReceiveRequisition> ReceiveReqTest(string regId)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Get_Test_ForReceive";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("regId",OracleDbType.Varchar2,30,regId,ParameterDirection.Input)
           };

           List<NWMSReceiveRequisition> reqRcv = new List<NWMSReceiveRequisition>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               /* D.dr_id, D.TEST_MAIN_ID , D.TEST_DET_ID ,TestTitle, D.LAB_ROOM_ID, D.RPT_GRP_ID, D.DEPT_ID , D.GROUP_ID */

               NWMSReceiveRequisition oReqRcvT = new NWMSReceiveRequisition();
               oReqRcvT.RequisitionID = (string)rdr["dr_id"];

               TestSub test = new TestSub();
               test.TestMainID = (string)rdr["TEST_MAIN_ID"];
               test.TestMainTitle = (string)rdr["TEST_MAIN_TITLE"];
               test.TestSubID = (string)rdr["TEST_DET_ID"];
               test.TestSubTitle = (string)rdr["TEST_DET_TITLE"];

               LabRoom lbrm = new LabRoom();
               lbrm.RoomID = (string)rdr["LAB_ROOM_ID"].ToString();
               test.LabRoom = lbrm;

               ReportGroup rpt = new ReportGroup();
               rpt.ReportGroupID = (string)rdr["RPT_GRP_ID"].ToString();
               rpt.ReportGroupTitle = (string)rdr["RPT_GRP_TITLE"].ToString();
               test.ReportGroup = rpt;

               Department dp = new Department();
               dp.DepartmentID = (string)rdr["DEPT_ID"].ToString();
               dp.DepartmentTitle = (string)rdr["DEPT_TITLE"].ToString();
               test.TestDepartment = dp;

               TestGroup tg = new TestGroup();
               tg.GroupId = (string)rdr["GROUP_ID"].ToString();
               tg.GroupTitle = (string)rdr["GRP_TITLE"].ToString();
               test.TestGroup = tg;

               oReqRcvT.DiagMR = (string)rdr["MR_NO"].ToString();
               oReqRcvT.DiagSecID = (string)rdr["SEC_ID"].ToString();
               oReqRcvT.DiagResultID = (rdr["RESULT_ID"] == DBNull.Value ? string.Empty : (string)rdr["RESULT_ID"]);
               oReqRcvT.Tests = test;
               reqRcv.Add(oReqRcvT);
           }
           rdr.Close();
           return reqRcv;
       }

       public short CheckIssueIDforRcv(string issue_id)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Check_Issue_ID_Rcv";
           OracleParameter[] parameterList = new OracleParameter[]
           {
               new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
               new OracleParameter("IssueID",OracleDbType.Varchar2,30,issue_id,ParameterDirection.Input)
           };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       public short VerifyIssueID(string issue_id, string Reg_id)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Verify_Issue_ID";
           OracleParameter[] parameterList = new OracleParameter[]
           {
               new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
               new OracleParameter("IssueID",OracleDbType.Varchar2,30,issue_id,ParameterDirection.Input),
               new OracleParameter("RegID",OracleDbType.Varchar2,30,Reg_id,ParameterDirection.Input)
           };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       public short SaveDrugReqRcv(NWMSReceiveRequisition DrugRcv)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Update_Drug_Received_Details";
           OracleParameter[] parameterList = new OracleParameter[]
           {
               new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),

               new OracleParameter("HCN",OracleDbType.Varchar2,30,DrugRcv.Patient.HCN,ParameterDirection.Input),
               new OracleParameter("RegID",OracleDbType.Varchar2,30,DrugRcv.Patient.RegistrationNo,ParameterDirection.Input),
               new OracleParameter("Room_ID",OracleDbType.Varchar2,10,DrugRcv.Patient.Room.RoomID,ParameterDirection.Input),
               new OracleParameter("Bed_ID",OracleDbType.Varchar2,10,DrugRcv.Patient.Bed.BedNo,ParameterDirection.Input),
               new OracleParameter("Bed_Type_ID",OracleDbType.Varchar2,10,DrugRcv.Patient.Bed.BedType.Title,ParameterDirection.Input),
               new OracleParameter("NsStn",OracleDbType.Varchar2,10,DrugRcv.Patient.NurseStation.NurseStationID,ParameterDirection.Input),
               new OracleParameter("Phr_ID",OracleDbType.Varchar2,6,DrugRcv.pharmacyID,ParameterDirection.Input),
               new OracleParameter("Req_ID",OracleDbType.Varchar2,15,DrugRcv.RequisitionID,ParameterDirection.Input),
               new OracleParameter("Issue_ID",OracleDbType.Varchar2,15,DrugRcv.IssueID,ParameterDirection.Input),

               new OracleParameter("Issue_Details",OracleDbType.Varchar2,600,DrugRcv.IssueDetails,ParameterDirection.Input),

               new OracleParameter("eBy",OracleDbType.Varchar2,20,DrugRcv.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("comp",OracleDbType.Varchar2,10,DrugRcv.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("loc",OracleDbType.Varchar2,10,DrugRcv.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("mac",OracleDbType.Varchar2,20,DrugRcv.EntryParameter.MachineID,ParameterDirection.Input)
             };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       #region IPDDoctors
      /* public short InsertIPDDoctors(IPDDoctor oIPDDOc)
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
           short i = DALHelper.Insert(connString, packageName, parameterList);
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
       private List<IPDDoctor> GetIPDDoctorsList(string packageName, OracleParameter[] parameterList)
       {
           List<IPDDoctor> IPDDocs = new List<IPDDoctor>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
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

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
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
       }*/
       //  Cancel_IPD_Drugs
       #endregion IPDDoctors
       #region CancelIPDDrugs
       public short CancelIPDDrugs(NurseRequisition nrq)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Cancel_IPD_Drugs";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("CanceledDrugs",OracleDbType.Varchar2,4000,nrq.drugs,ParameterDirection.Input),       
        
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nrq.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,nrq.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,nrq.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,nrq.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           if ((OracleDecimal)prm.Value == 2)
               return 2;
           else return 0;
       }
       #endregion



       #region IssueFromNurseStn
       public short IssueFromNurseStn(NurseRequisition nrq)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Insert_Nursing_Issue";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("str_ID",OracleDbType.Varchar2,30,nrq.StoreID,ParameterDirection.Input),
                new OracleParameter("RegID",OracleDbType.Varchar2,30,nrq.Patient.RegistrationNo,ParameterDirection.Input),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,nrq.Patient.HCN,ParameterDirection.Input),

                new OracleParameter("DeptGrpID",OracleDbType.Varchar2,10,nrq.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("DeptID",OracleDbType.Varchar2,10,nrq.Patient.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,10,nrq.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("WardID",OracleDbType.Varchar2,30,nrq.Patient.Ward.WardID,ParameterDirection.Input),
                new OracleParameter("RoomID",OracleDbType.Varchar2,30,nrq.Patient.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,30,nrq.Patient.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("BedID",OracleDbType.Varchar2,30,nrq.Patient.Bed.BedID,ParameterDirection.Input),                        
                new OracleParameter("AccessoriesBill",OracleDbType.Varchar2,40,nrq.AccessoriesBill,ParameterDirection.Input),

                new OracleParameter("IssueDetails",OracleDbType.Varchar2,4000,nrq.IssueDetails,ParameterDirection.Input),
                
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,nrq.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,nrq.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,nrq.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,nrq.EntryParameter.MachineID,ParameterDirection.Input)
            };

           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }
       #endregion IssueFromNurseStn

        /*  public OPDDoctorCallQ GetPatHealthInfo(string Hcn)
       {
           string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Get_Pat_Common_prblms";
           OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Hcn",OracleDbType.Varchar2,30,Hcn,ParameterDirection.Input)              
            };
           OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           OPDDoctorCallQ oPatHealthInfo = new OPDDoctorCallQ();

           while (rdr.Read())
           {
               oPatHealthInfo.Allergy = (string)rdr["ALLERGY"];
               //oPatHealthInfo.Gastric = (string)rdr["GASTRIC"];
               oPatHealthInfo.Asthma = (string)rdr["ASTHMA"];
               oPatHealthInfo.Diabetes = (string)rdr["DIABETES"];
               oPatHealthInfo.Pressure = (string)rdr["PRESSURE"];
               oPatHealthInfo.HeartDisease = (string)rdr["HEART_DISEASE"];
               oPatHealthInfo.KidneyDisease = (string)rdr["KIDNEY_DISEASE"];
              // oPatHealthInfo.Tuberculosis = (string)rdr["TUBERCULOSIS"];
           }
           rdr.Close();
           return oPatHealthInfo;
       }*/
   
   }
}
