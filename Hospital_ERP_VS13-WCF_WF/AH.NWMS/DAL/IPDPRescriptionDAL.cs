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

namespace AH.NWMS.DAL
{
   public class IPDPrescriptionDAL
    {
       private string connString = Utility.GetConnectionString(Utility.Module.IPDMIS);
      
     /*  public IPDDoctor GetDoctorsDetails(string DocID)
       {
           string packageName = "PKG_NWMS_DOCTORS_VISIT.Get_Doctors_Details";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("DocID",OracleDbType.Varchar2,30,DocID,ParameterDirection.Input)
           };

           IPDDoctor oIPDDoc = new IPDDoctor();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               oIPDDoc.Name = (string)rdr["DoctorsName"];
               oIPDDoc.IPDVisitingFee = Convert.ToDouble(rdr["VisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["VisitingFee"]);
               oIPDDoc.DoctorsVisitingFee = Convert.ToDouble(rdr["DocsVisitingFee"] == DBNull.Value ? 0 : (decimal)rdr["DocsVisitingFee"]);

           }
           rdr.Close();
           return oIPDDoc;
       }*/


#region SaveEditPrescription
       public short SaveIPDPrescription(IPDPrescription Iprs)
       {
           string packageName = "PKG_NWMS_DOCTORS_VISIT.INSERT_IPD_PRESCRIPTION";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,20,Iprs.Patient.HCN,ParameterDirection.Input),
                new OracleParameter("RegID",OracleDbType.Varchar2,20,Iprs.Patient.RegistrationNo,ParameterDirection.Input),
                new OracleParameter("DeptGroup",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,Iprs.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Doc",OracleDbType.Varchar2,5,Iprs.Patient.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("FloorId",OracleDbType.Varchar2,30,Iprs.Patient.Room.Floor,ParameterDirection.Input),
                new OracleParameter("RoomNo",OracleDbType.Varchar2,10,Iprs.Patient.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("BedCatTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.Facility.ID,ParameterDirection.Input),
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,Iprs.Patient.Bed.BedNo,ParameterDirection.Input),
                new OracleParameter("NsStnId",OracleDbType.Varchar2,5,Iprs.Patient.NurseStation.NurseStationID,ParameterDirection.Input),
                new OracleParameter("tests",OracleDbType.Varchar2,4000,Iprs.Prescription.CollTests,ParameterDirection.Input),
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,Iprs.Prescription.Medicine,ParameterDirection.Input),
                new OracleParameter("IPDVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.IPDVisitingFee,ParameterDirection.Input),
                new OracleParameter("DocVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.DoctorsVisitingFee,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       public short EditIPDPrescription(IPDPrescription Iprs)
       {
           string packageName = "PKG_NWMS_DOCTORS_VISIT.Update_IPD_PRESCRIPTION";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,20,Iprs.Patient.HCN,ParameterDirection.Input),
                new OracleParameter("RegID",OracleDbType.Varchar2,20,Iprs.Patient.RegistrationNo,ParameterDirection.Input),
                new OracleParameter("Visit_Number",OracleDbType.Varchar2,20,Iprs.DocVisitID,ParameterDirection.Input),
                new OracleParameter("DeptGroup",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,Iprs.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Doc",OracleDbType.Varchar2,5,Iprs.Patient.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("FloorId",OracleDbType.Varchar2,30,Iprs.Patient.Room.Floor,ParameterDirection.Input),
                new OracleParameter("RoomNo",OracleDbType.Varchar2,10,Iprs.Patient.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("BedCatTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.Facility.ID,ParameterDirection.Input),
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,Iprs.Patient.Bed.BedNo,ParameterDirection.Input),
                new OracleParameter("NsStnId",OracleDbType.Varchar2,5,Iprs.Patient.NurseStation.NurseStationID,ParameterDirection.Input),
                new OracleParameter("tests",OracleDbType.Varchar2,4000,Iprs.Prescription.CollTests,ParameterDirection.Input),
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,Iprs.Prescription.Medicine,ParameterDirection.Input),
                new OracleParameter("IPDVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.IPDVisitingFee,ParameterDirection.Input),
                new OracleParameter("DocVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.DoctorsVisitingFee,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }


       public IPDPrescription GetIPDPrescriptionForEdit(string visit_no, string Reg_ID)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.GET_IPD_Prescription_Edit";

           IPDPrescription prsI = new IPDPrescription();
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Visit_No",OracleDbType.Varchar2,30,visit_no,ParameterDirection.Input),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,30,Reg_ID,ParameterDirection.Input)
            };

           OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               Prescription prs = new Prescription();
               prs.CollTests = (rdr["TestDetails"] == DBNull.Value ? string.Empty : (string)rdr["TestDetails"]);
               prs.Medicine = (rdr["DrugsDetails"] == DBNull.Value ? string.Empty : (string)rdr["DrugsDetails"]);

               prsI.Prescription = prs;
           }
           rdr.Close();
           return prsI;
       }


#endregion SaveEditPrescription

#region GetPrescribedDrugs&Test

       public List<IPDPrescription> GetPrescribedDrugs(string regId)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Get_Drugs_For_Requisition";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("regId",OracleDbType.Varchar2,30,regId,ParameterDirection.Input)
           };

           List<IPDPrescription> oIPDPrss = new List<IPDPrescription>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               IPDPrescription oIPDPrs = new IPDPrescription();
               oIPDPrs.DocVisitID = (string)rdr["VISIT_NO"];

               DrugDose oDrugDose = new DrugDose();

               DrugMaster oDrugMaster = new DrugMaster();
               oDrugMaster.ID = (string)rdr["DRUG_ID"];
               oDrugMaster.Name = (string)rdr["DRUGNAME"];

               DrugGroup oDrugGroup = new DrugGroup();
               oDrugGroup.ID = (string)rdr["group_id"];
               oDrugMaster.DrugGroup = oDrugGroup;

               oDrugMaster.CalculatedQty = float.Parse(rdr["T_AMT"].ToString()); //Convert.ToDouble((float)rdr["T_AMT"]);
               oDrugMaster.RemainingQty = float.Parse(rdr["R_AMT"].ToString());
               oDrugDose.DrugMaster = oDrugMaster;

               oIPDPrs.Drugs = oDrugDose;
               oIPDPrss.Add(oIPDPrs);
           }
           rdr.Close();
           return oIPDPrss;
       }


       public List<IPDPrescription> GetPrescribedTests(string regId)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Get_Tests_For_Requisition";
           OracleParameter[] parameterList = new OracleParameter[]
           {
             new OracleParameter("pCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("regId",OracleDbType.Varchar2,30,regId,ParameterDirection.Input)
           };

           List<IPDPrescription> oIPDPrss = new List<IPDPrescription>();
           OracleDataReader rdr;

           rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               IPDPrescription oIPDPrs = new IPDPrescription();
               oIPDPrs.DocVisitID = (string)rdr["VISIT_NO"];

               TestSub test = new TestSub();
               test.TestMainID = (string)rdr["TEST_MAIN_ID"];
               test.TestMainTitle = (string)rdr["TEST_MAIN_TITLE"];
               test.TestSubID = (string)rdr["TEST_DET_ID"];
               test.TestSubTitle = (string)rdr["TEST_DET_TITLE"];

               oIPDPrs.Tests = test;
               oIPDPrss.Add(oIPDPrs);
           }
           rdr.Close();
           return oIPDPrss;
       }
#endregion GetPrescribedDrugs&Test

#region SaveEditDischargeAdvices
       public short SaveDischargeAdvices(IPDPrescription Iprs)
       {
           string packageName = "PKG_NWMS_DOCTORS_VISIT.INSERT_DISCHARGE_SumNADVICES";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),                   //1
                new OracleParameter("HCN",OracleDbType.Varchar2,20,Iprs.Patient.HCN,ParameterDirection.Input),      //2
                new OracleParameter("RegID",OracleDbType.Varchar2,20,Iprs.Patient.RegistrationNo,ParameterDirection.Input),                 //3
                new OracleParameter("DeptGroup",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input), //4
                new OracleParameter("Department",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentID,ParameterDirection.Input),    //5
                new OracleParameter("Unit",OracleDbType.Varchar2,5,Iprs.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),            //6
                new OracleParameter("Doc",OracleDbType.Varchar2,5,Iprs.Patient.Doctor.ID,ParameterDirection.Input),                          //7
                new OracleParameter("FloorId",OracleDbType.Varchar2,30,Iprs.Patient.Room.Floor,ParameterDirection.Input),                    //8
                new OracleParameter("RoomNo",OracleDbType.Varchar2,10,Iprs.Patient.Room.RoomID,ParameterDirection.Input),                    //9
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.BedType.ID,ParameterDirection.Input),               //10
                new OracleParameter("BedCatTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.Facility.ID,ParameterDirection.Input),            //11
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,Iprs.Patient.Bed.BedNo,ParameterDirection.Input),                         //12
                new OracleParameter("NsStnId",OracleDbType.Varchar2,5,Iprs.Patient.NurseStation.NurseStationID,ParameterDirection.Input),      //13
                            
                new OracleParameter("DietAdvice",OracleDbType.Varchar2,4000,Iprs.DietAdvice,ParameterDirection.Input),                          //14
                new OracleParameter("tests",OracleDbType.Varchar2,4000,Iprs.Prescription.CollTests,ParameterDirection.Input),                   //15   
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,Iprs.Prescription.Medicine,ParameterDirection.Input),                    //16
                new OracleParameter("Advies",OracleDbType.Varchar2,4000,Iprs.Prescription.Advice,ParameterDirection.Input),                     //17
                    
                new OracleParameter("IPDVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.IPDVisitingFee,ParameterDirection.Input),       //18
                new OracleParameter("DocVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.DoctorsVisitingFee,ParameterDirection.Input),   //19

                new OracleParameter("DISCHARGE_STATUS",OracleDbType.Varchar2,3000,Iprs.DischargeStatus,ParameterDirection.Input),           //20
                new OracleParameter("DISCHARGE_TYPE",OracleDbType.Varchar2,3000,Iprs.DischargeType,ParameterDirection.Input),               //21    
                new OracleParameter("DISCHARGE_DIAGNOSIS",OracleDbType.Varchar2,3000,Iprs.DischargeDiagnosis,ParameterDirection.Input),     //22
                new OracleParameter("CASE_SUMMARY",OracleDbType.Varchar2,3000,Iprs.CaseSummary,ParameterDirection.Input),                   //23
                new OracleParameter("HOSPITAL_COURSE",OracleDbType.Varchar2,3000,Iprs.HospitalCourse,ParameterDirection.Input),             //24
                new OracleParameter("OPERATION_NOTE",OracleDbType.Varchar2,3000,Iprs.OperationNote,ParameterDirection.Input),               //25

                new OracleParameter("NextVisitDate",OracleDbType.Date,30,Iprs.Prescription.NextVisitDate,ParameterDirection.Input),           //26
                new OracleParameter("VISIT_TO_DEPT_GRP_ID",OracleDbType.Varchar2,4,Iprs.RefDeptGrp,ParameterDirection.Input), //27
                new OracleParameter("VISIT_TO_DEPT_ID",OracleDbType.Varchar2,4,Iprs.Prescription.RefDeptID.DepartmentID,ParameterDirection.Input), //28
                new OracleParameter("VISIT_TO_UNIT_ID",OracleDbType.Varchar2,3,Iprs.Prescription.RefUnitID.UnitId,ParameterDirection.Input),        //29
                new OracleParameter("VISIT_TO_DOC_ID",OracleDbType.Varchar2,30,Iprs.Prescription.RefDocID.ID,ParameterDirection.Input),             //30

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.EntryBy,ParameterDirection.Input),          //31
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.CompanyID,ParameterDirection.Input),       //32
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.LocationID,ParameterDirection.Input),     //33
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.MachineID,ParameterDirection.Input)       //34
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       public short EditDischargeAdvices(IPDPrescription Iprs)
       {
           string packageName = "PKG_NWMS_DOCTORS_VISIT.Update_DISCHARGE_SumNADVICES";
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),                   //1
                new OracleParameter("HCN",OracleDbType.Varchar2,20,Iprs.Patient.HCN,ParameterDirection.Input),      //2
                new OracleParameter("RegID",OracleDbType.Varchar2,20,Iprs.Patient.RegistrationNo,ParameterDirection.Input),                 //3
                new OracleParameter("DeptGroup",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input), //4
                new OracleParameter("Department",OracleDbType.Varchar2,5,Iprs.Patient.Department.DepartmentID,ParameterDirection.Input),    //5
                new OracleParameter("Unit",OracleDbType.Varchar2,5,Iprs.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),            //6
                new OracleParameter("Doc",OracleDbType.Varchar2,5,Iprs.Patient.Doctor.ID,ParameterDirection.Input),                          //7
                new OracleParameter("FloorId",OracleDbType.Varchar2,30,Iprs.Patient.Room.Floor,ParameterDirection.Input),                    //8
                new OracleParameter("RoomNo",OracleDbType.Varchar2,10,Iprs.Patient.Room.RoomID,ParameterDirection.Input),                    //9
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.BedType.ID,ParameterDirection.Input),               //10
                new OracleParameter("BedCatTypeID",OracleDbType.Varchar2,2,Iprs.Patient.Bed.Facility.ID,ParameterDirection.Input),            //11
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,Iprs.Patient.Bed.BedNo,ParameterDirection.Input),                         //12
                new OracleParameter("NsStnId",OracleDbType.Varchar2,5,Iprs.Patient.NurseStation.NurseStationID,ParameterDirection.Input),      //13
                            
                new OracleParameter("DietAdvice",OracleDbType.Varchar2,4000,Iprs.DietAdvice,ParameterDirection.Input),                          //14
                new OracleParameter("tests",OracleDbType.Varchar2,4000,Iprs.Prescription.CollTests,ParameterDirection.Input),                   //15   
                new OracleParameter("Drugs",OracleDbType.Varchar2,4000,Iprs.Prescription.Medicine,ParameterDirection.Input),                    //16
                new OracleParameter("Advies",OracleDbType.Varchar2,4000,Iprs.Prescription.Advice,ParameterDirection.Input),                     //17
                    
                new OracleParameter("IPDVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.IPDVisitingFee,ParameterDirection.Input),       //18
                new OracleParameter("DocVisitingFee",OracleDbType.Double,100,Iprs.IPDDoctor.DoctorsVisitingFee,ParameterDirection.Input),   //19

                new OracleParameter("DISCHARGE_STATUS",OracleDbType.Varchar2,3000,Iprs.DischargeStatus,ParameterDirection.Input),           //20
                new OracleParameter("DISCHARGE_TYPE",OracleDbType.Varchar2,3000,Iprs.DischargeType,ParameterDirection.Input),               //21    
                new OracleParameter("DISCHARGE_DIAGNOSIS",OracleDbType.Varchar2,3000,Iprs.DischargeDiagnosis,ParameterDirection.Input),     //22
                new OracleParameter("CASE_SUMMARY",OracleDbType.Varchar2,3000,Iprs.CaseSummary,ParameterDirection.Input),                   //23
                new OracleParameter("HOSPITAL_COURSE",OracleDbType.Varchar2,3000,Iprs.HospitalCourse,ParameterDirection.Input),             //24
                new OracleParameter("OPERATION_NOTE",OracleDbType.Varchar2,3000,Iprs.OperationNote,ParameterDirection.Input),               //25

                new OracleParameter("NextVisitDate",OracleDbType.Date,30,Iprs.Prescription.NextVisitDate,ParameterDirection.Input),           //26
                new OracleParameter("VISIT_TO_DEPT_GRP_ID",OracleDbType.Varchar2,4,Iprs.RefDeptGrp,ParameterDirection.Input), //27
                new OracleParameter("VISIT_TO_DEPT_ID",OracleDbType.Varchar2,4,Iprs.Prescription.RefDeptID.DepartmentID,ParameterDirection.Input), //28
                new OracleParameter("VISIT_TO_UNIT_ID",OracleDbType.Varchar2,3,Iprs.Prescription.RefUnitID.UnitId,ParameterDirection.Input),        //29
                new OracleParameter("VISIT_TO_DOC_ID",OracleDbType.Varchar2,30,Iprs.Prescription.RefDocID.ID,ParameterDirection.Input),             //30

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.EntryBy,ParameterDirection.Input),          //31
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.CompanyID,ParameterDirection.Input),       //32
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,Iprs.Prescription.EntryParameter.LocationID,ParameterDirection.Input),     //33
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,Iprs.Prescription.EntryParameter.MachineID,ParameterDirection.Input)       //34
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }

       public IPDPrescription GetDischargeAdvicesForEdit(string tkt_no)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.GET_DISCHARGE_ADV_For_Edit";

           IPDPrescription prsI = new IPDPrescription();
           OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,tkt_no,ParameterDirection.Input)
            };

           OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
           while (rdr.Read())
           {
               Prescription prs = new Prescription();
               prs.CollTests = (rdr["TESTDETAILS"] == DBNull.Value ? string.Empty : (string)rdr["TESTDETAILS"]);
               prs.Advice = (rdr["ADVICEDETAILS"] == DBNull.Value ? string.Empty : (string)rdr["ADVICEDETAILS"]);
               prs.Medicine = (rdr["DRUGSDETAILS"] == DBNull.Value ? string.Empty : (string)rdr["DRUGSDETAILS"]);
               prs.Refered = (rdr["NEXTVISIT"] == DBNull.Value ? string.Empty : (string)rdr["NEXTVISIT"]);
               prsI.Prescription = prs;

               prsI.DischargeStatus = (rdr["DISCHARGE_STATUS"] == DBNull.Value ? string.Empty : (string)rdr["DISCHARGE_STATUS"]);
               prsI.DischargeType = (rdr["DISCHARGE_TYPE"] == DBNull.Value ? string.Empty : (string)rdr["DISCHARGE_TYPE"]);

               prsI.DischargeDiagnosis = (rdr["DISCHARGE_DIAGNOSIS"] == DBNull.Value ? string.Empty : (string)rdr["DISCHARGE_DIAGNOSIS"]);
               prsI.CaseSummary = (rdr["CASE_SUMMARY"] == DBNull.Value ? string.Empty : (string)rdr["CASE_SUMMARY"]);
               prsI.HospitalCourse = (rdr["HOSPITAL_COURSE"] == DBNull.Value ? string.Empty : (string)rdr["HOSPITAL_COURSE"]);
               prsI.OperationNote = (rdr["OPERATION_NOTE"] == DBNull.Value ? string.Empty : (string)rdr["OPERATION_NOTE"]);
               prsI.DietAdvice = (rdr["DIET_ADVICE"] == DBNull.Value ? string.Empty : (string)rdr["DIET_ADVICE"]);
           }
           rdr.Close();
           return prsI;
       }
#endregion SaveEditDischargeAdvices

      
       public short IsDischargeAdvCreated(string regId)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Is_Discharge_Adv_Created";
           OracleParameter[] parameterList = new OracleParameter[]
           {
               new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
               new OracleParameter("regId",OracleDbType.Varchar2,30,regId,ParameterDirection.Input)
           };
          short i = DALHelper.Insert(connString, packageName, parameterList);
          OracleParameter prm = parameterList[0];
          if ((OracleDecimal)prm.Value == 1)
              return 1;
          else return 0;
       }

       public short IsDrugReqDone(string visit_id, string drug_id)
       {
           string packageName = "AGH_IPD.PKG_NWMS_DOCTORS_VISIT.Is_DrugReqDone";
           OracleParameter[] parameterList = new OracleParameter[]
           {
               new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
               new OracleParameter("visit_id",OracleDbType.Varchar2,30,visit_id,ParameterDirection.Input),
               new OracleParameter("drug_id",OracleDbType.Varchar2,30,drug_id,ParameterDirection.Input),
           };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[0];
           if ((OracleDecimal)prm.Value == 1)
               return 1;
           else return 0;
       }
    }
}
