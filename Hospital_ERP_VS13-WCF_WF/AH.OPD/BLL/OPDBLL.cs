using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DLayer.OPD;
using AH.OPD.MODEL;
using AH.APPOPD.MODEL;
using AH.DTMS.MODEL;
using AH.DTMS.BLL;
using AH.OPD.DAL;
using AH.DUtility;
using AH.HR.BLL;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.ORGMS.BLL;
using AH.DRUGS.BLL;
using AH.Shared.MODEL;

namespace AH.OPD.BLL
{
    public class OPDBLL
    {
        public Dictionary<string, string> GetOPDRoomsDict(string BuildingID, string RmType)
        {
            Dictionary<string, string> grm = new Dictionary<string, string>();
            grm.Add("", "--Select--");
            foreach (OPDRoomGrpAssign rm in new OPDRoomGrpAssignDAL().GetOPDRooms( BuildingID,RmType))
            {
                grm.Add(rm.RoomID, rm.RoomNO);
            }
            return grm;
        } 

        public Dictionary<string, string> GetOPDDoctorsDict(string dept, string unit)
        {
            Dictionary<string, string> odic = new Dictionary<string, string>();

            foreach (OPDDoctor i in new OPDDoctorsDAL().GetOPDDoctors(dept, unit))
            {
                odic.Add(i.Doctor.ID, i.Doctor.Name);
            }
            return odic;
        }

        public List<OPDDoctor> GetOPDDoctors(string DeptID, string UnitID)
        {
             return new OPDDoctorsDAL().GetOPDDoctors(DeptID, UnitID);
        }

        public Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID)
        {
            return new EmployeeSpecializationSetupBLL().GetEmpDic(DeptID, UnitID);
            //return new AdministrationSetupBLL().GetEmpDic(Utility.GetDesignationGroupCode(Utility.DesignationGroupCode.Doctor), DeptID, UnitID);
        }

        //Fauzul 20 Aug 2014
        public List<OPDNurseRoomAllRO> GetNurseRoomRO()
        {
            return new OPDNurseRAllRODAL().GetNurseRoomRO();
        }

        public List<OPDDrRoomAllRO> GetDocRoomAllRO()
        {
            return new OPDDrRoomAllRODAL().GetDocRoomAllRO();
        }
        //Fauzul 10 Aug 2014
        public List<Room> GETs_Room_No(string RoomGrp)
        {
            return new OPDRoomGrpAssignDAL().GETs_Room_No(RoomGrp);
        }

        //Fauzul 05 Aug 2014
        public List<Ticket> GetPatDoc(string docid)
        {
            return new OPDDAL().GetPatDoc(docid);
        }      
            
        public List<OPDDoctorCallQ> InsDrRoom(string DocID)
        {
            return new OPDRoomGrpAssignDAL().InsDrRoom("");
        }
        //Fauzul 02 Aug 2014
        public List<Room> UpdateRoomGroup(Room oRoom)
        {
            return new OPDRoomGrpAssignDAL().UpdateRoomGroup(oRoom);
        }
        public short InsertRoomGroup(OPDRoomGrpAssign oRoom)
        {
            return new OPDRoomGrpAssignDAL().InsertRoomGroup(oRoom);
        }

        public List<OPDRoomGrpAssign> GetRoomGroup(string RoomGrp)
        {
            return new OPDRoomGrpAssignDAL().GetRoomGroup(RoomGrp);
        }
        public List<OPDRoomGrpAssign> GetRoomGroup()
        {
            return new OPDRoomGrpAssignDAL().GetRoomGroup();
        }
        public List<Room> test()
        {
            return new OPDRoomGrpAssignDAL().test();
        }
        //Fauzul 16 Jul 2014
        public string GetDrRoom(string DocID)
        {
            return new OPDDAL().GetDrRoom(DocID);
        }

        //Fauzul 9 Jul 2014
        public string ChkPatOldNew(string DocID, string p_hcn)
        {
            return new OPDDAL().ChkPatOldNew(DocID, p_hcn);
        }
        //Fauzul 3 July 2014
        public List<OPDNurseRoomAllocation> InsertNurseRoom(OPDNurseRoomAllocation oNurseRoomAllocation)
        {
            return new OPDDAL().InsertNurseRoom(oNurseRoomAllocation);
        }

        //Fauzul 3 July 2014
        public List<OPDNurseRoomAllocation> GetNurseRoom()
        {
            return new OPDDAL().GetNurseRoom();
        }
        //Fauzul 2 July 2014
        
        //Fauzul 2 July 2014
        public List<OPDDoctor> GetDocRoomNo(string DoctorID)
        {
            return new OPDDAL().GetDocRoomNo(DoctorID);
        }

        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }
        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(deptgrp, deptid);
        }
     
        //public Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID)  //-----------------
        //{
        //return new AdministrationSetupBLL().GetEmployeesDic(Utility.GetDesignationGroupCode(Utility.DesignationGroupCode.Doctor), DeptID, UnitID);  
        //    return new AdministrationSetupBLL().GetEmployeesDic(Utility.GetDesignationGroupCode(Utility.DesignationGroupCode.Doctor), DeptID, UnitID);
        //}

        public Dictionary<string, string> GetPrescriptionTypes()
        {
            return DUtility.Utility.GetPrescriptionTypes();
        }
        public Age CalculateAge(DateTime dob)
        {
            return Utility.CalculateAge(dob);
        }
        public string SaveOPDTicket(Ticket tkt)
        {
            return new OPDDAL().SaveOPDTicket(tkt);
        }
        public Dictionary<string, string> GetDoctors(string dept, string unit)
        {
            return new EmployeeSpecializationSetupBLL().GetDoctorSetup("o", dept, unit);
        }

        public List<RptTicket> GetTickets(string patientHCN, string ticketNO)
        {
            List<RptTicket> tkts = new List<RptTicket>();
            Ticket tkt = new OPDDAL().GetTickets(patientHCN, ticketNO);
            RptTicket rptTkt = new RptTicket();
            rptTkt.TicketNo = tkt.TicketNo;

            tkts.Add(rptTkt);
            return tkts;

            //return new OPDDAL().GetTickets(patientHCN, ticketNO);
        }

        //public List<RptTicket> GetTickets(string patientNo, string tktNo)
        //{
        //    List<RptTicket> tkts = new List<RptTicket>();

        //    Ticket tkt = new OPDDAL().GetTickets(patientNo, tktNo);

        //    RptTicket rptTkt = new RptTicket();
        //    rptTkt.TicketNo = tkt.TicketNo;
        //    //rptTkt.HCN = tkt.Patient.HCN;
        //    //rptTkt.Name = tkt.Patient.Name;
        //    //rptTkt.Sex = tkt.Patient.Sex;
        //    //rptTkt.Age = tkt.Patient.AgeFull;
        //    //rptTkt.Department = tkt.Patient.Department.DepartmentID;
        //    //rptTkt.Unit = tkt.Patient.DepartmentUnit.UnitId;
        //    //rptTkt.PrimaryCase = tkt.Patient.CaseID;
        //    //rptTkt.DoctorName = tkt.Doctor.Name;
        //    //rptTkt.RoomNo = tkt.Doctor.Room.RoomID;
        //    //rptTkt.VisitingDate = tkt.Doctor.AvailableDays;
        //    //rptTkt.DoctorsDegree1 = tkt.Doctor.Degree1;
        //    //rptTkt.DoctorsDegree2 = tkt.Doctor.Degree2;
        //    //rptTkt.DoctorsDegree3 = tkt.Doctor.Degree3;
        //    //rptTkt.DoctorsDegree4 = tkt.Doctor.Degree4;
        //    //rptTkt.BloodGroup = tkt.Patient.BloodGroup;

        //    tkts.Add(rptTkt);
        //    return tkts;
        //}

        public Ticket GetTicket( string prescriptionTicketNO)
        {
            return new OPDDAL().GetTicket(prescriptionTicketNO);
        }

        public List<DiseaseCase> getDiseaseGroup()
        {
            return new OPDDAL().getDiseaseGroup();
        }
        public Dictionary<string, string> getDiseaseGroupDic(string type)
        {
            Dictionary<string, string> adrsn = new Dictionary<string, string>();
            adrsn.Add("", "--Select--");
            foreach (DiseaseCase adm in new OPDDAL().getDiseaseGroup())
            {
                adrsn.Add(adm.DiseaseGrpID, adm.DiseaseGrpTitle);
            }
            return adrsn;
        }

        public List<DiseaseCase> GetDiseaseCase()
        {
            return new OPDDAL().GetDiseaseCase();
        }
        public short SaveDisease(DiseaseCase tDept)
        {
            return new OPDDAL().SaveDisease(tDept);
        }
        public short UpdateDisease(DiseaseCase tDept)
        {
            return new OPDDAL().UpdateDisease(tDept);
        }
        public Dictionary<string, string> GetDiseaseCase(string type)
        {
            Dictionary<string, string> caseid = new Dictionary<string, string>();

            foreach (DiseaseCase cs in new OPDDAL().GetDiseaseCase())
            {
                caseid.Add(cs.CaseID, cs.CaseTitle);
            }
            return caseid;
        }
        //public List<TestGroup> GetDiagnGrp(string department)
        //{
        //    //return new DiagnosticSetupBLL().GetDiagnGrp(department);
        //    return new DiagnosticSetupBLL().GetDiagnGrp(department);
        //}

        public Dictionary<string, string> GetDiagnGrp(string type, string department)
        {
            return new DiagnosticSetupBLL().GetDiagnGrp(type, department);
        }
        public List<TestMain> GetTestMain(string department, string group)
        {
            return new DiagnosticSetupBLL().GetTestMain(department, group);      
        }
        public List<TestSub> GetTestDetails(string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDetails(deptid, group, main);  
        }
        public string SavePrescription(Prescription prs)
        {
            return new OPDDAL().SavePrescription(prs);
        } 
        public string EditPrescription(Prescription prs)
        {
            return new OPDDAL().EditPrescription(prs);
        } 
        public string VerifyTicketNo(string tktno,bool isPrescribed)
        {
            if (tktno == "")
            {
                return Utility.GetMsg(Utility.Msg.ValidPatNo);
            }
            string tckt = new OPDDAL().VerifyTicketNo(tktno);
            string msg = "";
           
            if (tckt == "0")
            { 
              msg = "Invalid prescription";
            }
            if (tckt == "1")
            {
              msg = "Regular Prescription already refund";
            }
            if (tckt == "2")
            {
              msg = "Refunded prescription";
            }
            if (tckt == "3")
            {
              msg = "Canceled prescription";
            }
            if (isPrescribed == false && tckt == "4")
            {
              msg = "1";
            }
            if (isPrescribed == true && tckt == "4")
            {
              msg = "Not Prescribed Yet";
            }
            if (isPrescribed == true && tckt == "5")
            {
              msg = "1";
            }
            if (isPrescribed == false && tckt == "5")
            {
              msg = " Shown to Doctor";
            }
            return msg;
        }
        public List<TestFee> GetPrescriptionTests(string ticketno, string feecat)
        {
            return new OPDDAL().GetPrescriptionTests(ticketno, feecat);
        }
        public List<TestFee> GetPrescriptionTests(string ticketno, string feecat,string status)
        {
            return new OPDDAL().GetPrescriptionTests(ticketno, feecat, status);
        }
        public List<Ticket> GetPrescriptionList(string docid)
        {
            return new OPDDAL().GetPrescriptionList(docid);
        }
#region ClinicalFindingsNew(09/07/15)
        public short SaveClinicalFindingsGrp(ClinicalFindingsGroup cfGrp)
        {
            return new OPDDAL().SaveClinicalFindingsGrp(cfGrp);
        }
        public short UpdateClinicalFindingsGrp(ClinicalFindingsGroup cfGrp)
        {
            return new OPDDAL().UpdateClinicalFindingsGrp(cfGrp);
        }
        public List<ClinicalFindingsGroup> GetClinicalFindingsGroups()
        {
            return new OPDDAL().GetClinicalFindingsGroups();
        }
        public List<ClinicalFindingsGroup> GetClinicalFindingsGroup(string cfGrpTitle)
        {
            return new OPDDAL().GetClinicalFindingsGroup(cfGrpTitle);
        }
        public Dictionary<string, string> GetClinicalFindingsGroupDict(string type)
        {
            Dictionary<string, string> cfGrpDict = new Dictionary<string, string>();
            cfGrpDict.Add("", "--Select--");
            foreach (ClinicalFindingsGroup cfGrp in new OPDDAL().GetClinicalFindingsGroup())
            {
                cfGrpDict.Add(cfGrp.CfGrpID, cfGrp.CfGrpTitle);
            }
            return cfGrpDict;
        }

        public Dictionary<string, string> GetClinicalFindingsDict(string type)
        {
            Dictionary<string, string> cfDict = new Dictionary<string, string>();
            cfDict.Add("", "--Select--");
            foreach (ClinicalFindings cf in new OPDDAL().GetClinicalFindings())
            {
                cfDict.Add(cf.FindingsID, cf.FindingsTitle);
            }
            return cfDict;
        }

        public short SaveClinicalFindings(ClinicalFindings cf)
        {
            return new OPDDAL().SaveClinicalFindings(cf);
        }
        public List<ClinicalFindings> GetCfTree()
        {
            return new OPDDAL().GetCfTree();
        }

        public short UpdateClinicalFindings(ClinicalFindings cf)
        {
            return new OPDDAL().UpdateClinicalFindings(cf);
        }
        public List<ClinicalFindings> GetClinicalFindings()
        {
            return new OPDDAL().GetClinicalFindings();
        }
        public List<ClinicalFindings> GetClinicalFinding(string cfTitle)
        {
            return new OPDDAL().GetClinicalFinding(cfTitle);
        }
        public List<ClinicalFindings> GetClinicalFindingByGroup(string cfGrpID)
        {
            return new OPDDAL().GetClinicalFindingByGroup(cfGrpID);
        }
        public List<ClinicalFindings> GetClinicalFindingByGroupNParent(string cfGrpID, string cfParentID)
        {
            return new OPDDAL().GetClinicalFindingByGroupNParent(cfGrpID, cfParentID);
        }

        public short SaveClinicalFindingsValue(ClinicalFindingsValues cfv)
        {
            return new OPDDAL().SaveClinicalFindingsValue(cfv);
        }

        public List<ClinicalFindingsValues> GetClinicalFindingsValues()
        {
            return new OPDDAL().GetClinicalFindingsValues();
        }

        public List<ClinicalFindingsValues> GetClinicalFindingsValue(string findingsvaltitle)
        {
            return new OPDDAL().GetClinicalFindingsValue(findingsvaltitle);
        }
        public short UpdateClinicalFindingsValue(ClinicalFindingsValues cfv)
        {
            return new OPDDAL().UpdateClinicalFindingsValue(cfv);
        }
        public short SaveCFAssignedValue(ClinicalFindingsValueAssign cfvalA)
        {
            return new OPDDAL().SaveCFAssignedValue(cfvalA);
        }

        public Dictionary<string, string> getCFAssignedValueDict(string cfID)
        {
            Dictionary<string, string> cfAssignDict = new Dictionary<string, string>();
            cfAssignDict.Add("", "--Select--");
            foreach (ClinicalFindingsValueAssign cf in new OPDDAL().getCFAssignedValue(cfID))
            {
                cfAssignDict.Add(cf.FindingsValID, cf.FindingsValTitle);
            }
            return cfAssignDict;
        }

        public List<ClinicalFindingsValueAssign> getCFAssignedValue(string cfID)
        {
            return new OPDDAL().getCFAssignedValue(cfID);
        }


#endregion (started)ClinicalFindingsNew(09/07/15)
        public short SaveClinicalDiagnosis(ClinicalDiagnosis cl)
        {
            return new OPDDAL().SaveClinicalDiagnosis(cl);
        }
        public short UpdateClinicalDiagnosis(ClinicalDiagnosis cl)
        {
            return new OPDDAL().UpdateClinicalDiagnosis(cl);
        }
        public List<ClinicalDiagnosis> GetClinicalDiagnosis()
        {
            return new OPDDAL().GetClinicalDiagnosis();
        }
        public List<ClinicalDiagnosis> GetClinicalDiagnos(string diagtitle)
        {
            return new OPDDAL().GetClinicalDiagnos(diagtitle);
        }
        public short SaveComplaint(Complaints com)
        {
            return new OPDDAL().SaveComplaint(com);
        }
        public short UpdateComplaint(Complaints com)
        {
            return new OPDDAL().UpdateComplaint(com);
        }
        public List<Complaints> GetComplaints()
        {
            return new OPDDAL().GetComplaints();
        }

        public List<Complaints> GetComplaints(string comptitle)
        {
            return new OPDDAL().GetComplaints(comptitle);
        }
        public List<PatHistoryTree> GetsTree(string HCN)
        {
            return new OpdTicketReportDAL().GetsTree(HCN);
        }
        public OPDDoctorCall InsUpdDocCall(OPDDoctorCall oOPDDoctorCall)
        {
            return new OPDDAL().InsUpdDocCall(oOPDDoctorCall); 
        }
        public List<OPDDoctor> InsertDoctorRoom(OPDDoctor oDoctorRoomSetup)
        {
            return new OPDDAL().InsertDoctorRoom(oDoctorRoomSetup);
        }

        public Dictionary<string, string> GetNurses()
        {
            return new EmployeeSpecializationSetupBLL().GetNurse("D");
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        public short AdviceSetupInsert(OPDAdvice oAdvice)
        {
            return new OPDSetupDAL().AdviceSetupInsert(oAdvice);
        }
        public short AdviceSetupUpdate(OPDAdvice oAdvice)
        {
            return new OPDSetupDAL().AdviceSetupUpdate(oAdvice);
        }

        public List<OPDAdvice> AdviceSetupGET()
        {
            return new OPDSetupDAL().AdviceSetupGET();
        }

        public List<OPDAdvice> GetAdviceDetails(string adviceID, string deptid)
        {
            return new OPDSetupDAL().GetAdviceDetails(adviceID, deptid);
        }

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //public List<OpdAppointment> Appointment(string hcn)
        //{
        //    return new OPDDAL().Appointment(hcn);
        //}

        public Dictionary<string, string> getConsumptionForm(string type)
        {
            return new DrugSetupBLL().getConsumptionForm(type);
        }

        public List<OPDDoctorCallQ> GetDoctorsList(string nsStnID)
        {
            return new OPDDAL().GetDoctorsList(nsStnID);
        }

        public short UpdateCallQ(OPDDoctorCallQ Q)
        {
            return new OPDDAL().UpdateCallQ(Q);
        }
        public OPDDoctorCallQ GetPatHealthInfo(string Ticket)
        {
            return new OPDDAL().GetPatHealthInfo(Ticket);
        }
        public List<Ticket> GetTicketList(string userID, string date)
        {
            return new OPDDAL().GetTicketList( userID, date);
        }
        public Ticket GetTicketStatusForRefundOrCancel(string ticket)
        {
            return new OPDDAL().GetTicketStatusForRefundOrCancel(ticket);
        }
        public short CancelTicket(string ticketNo, string user_id)
        {
            return new OPDDAL().CancelTicket(ticketNo, user_id);
        }
        public string RefundTicket(Ticket tkt)
        {
            return new OPDDAL().RefundTicket( tkt);
        }
        //public Ticket GetTicketFees(string userID, string date)
        public AccountsPayment GetTicketFees(string userID, string date)
        {
            return new OPDDAL().GetTicketFees(userID, date);
        }
        public short InsertUserCloseRegister(AccountsPayment tktFee) //(Ticket tktFee)
        {
            return new OPDDAL().InsertUserCloseRegister(tktFee);
        }

        public Prescription GetPrescriptionForEdit(string tkt_no)
        {
            return new OPDDAL().GetPrescriptionForEdit(tkt_no);
        }
        public List<OPDPrescriptionReportNewRO> GetOPDPatTree(string HCN)
        {
            return new OPDDAL().GetOPDPatTree(HCN);
        }
    }
}
