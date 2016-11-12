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
    public class EmergencyCollectionDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.DMSMIS);
        string packageName = string.Empty;

        #region GetEmerBillForPayment
        public List<EmergencyCollectionMR> GetEmerBillForPayment(string HCNNo)
        {
            string packageName = "AGH_DMS.PKG_EMERGENCY_SETUP.GET_EMR_BILL_FOR_PAY";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_hcn",OracleDbType.Varchar2,30,HCNNo,ParameterDirection.Input)
              };

            return GetEmerBillForPaymentDetails(packageName, parameterList);
        }
        private List<EmergencyCollectionMR> GetEmerBillForPaymentDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmergencyCollectionMR> oDMRs = new List<EmergencyCollectionMR>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                EmergencyCollectionMR oEmeregency = new EmergencyCollectionMR();
                EmrCollHead oEmrCollHead = new EmrCollHead();

                oEmeregency.EmergencyMR = (string)rdr["E_MR_NO"].ToString();

                InPatient Pat = new InPatient();
                Pat.HCN = (string)rdr["HCN"].ToString();
                Pat.Name = (string)rdr["PatientName"].ToString();
                Pat.DOB = Convert.ToDateTime(rdr["DOB"].ToString());
                Pat.Sex = (string)rdr["Sex"].ToString();
                Pat.CellPhone = (string)rdr["MobileNo"].ToString();
                Pat.EmergencyAddress = (string)rdr["Address"].ToString();

                oEmeregency.Patient = Pat;

                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["DEPT_GRP_ID"].ToString();
                oEmrCollHead.DepartmentGroup = oDeptGrp;

                Department oDept = new Department();
                oDept.DepartmentID = rdr["DEPT_ID"].ToString();
                oEmrCollHead.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"].ToString();
                oEmrCollHead.DepartmentUnit = oDeptUnit;

                oEmrCollHead.HeadID = rdr["HEAD_ID"].ToString();
                oEmrCollHead.HeadTitle = rdr["HEAD_TITLE"].ToString();
                oEmrCollHead.Fee = Convert.ToDouble(rdr["Fee"].ToString());
                oEmrCollHead.Qty = Convert.ToDouble(rdr["QTY"].ToString());
                oEmrCollHead.NetPaid = Convert.ToDouble(rdr["NetPaid"].ToString());

                oEmeregency.EmrCollHead = oEmrCollHead;           
               
                oDMRs.Add(oEmeregency);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetEmerDetailsForIPD
        public List<EmergencyCollectionMR> GetEmerDetailsForIPD(string HCNNo)
        {
            string packageName = "AGH_DMS.PKG_EMERGENCY_SETUP.GET_EMR_DETAILS_FOR_IPD";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_hcn",OracleDbType.Varchar2,30,HCNNo,ParameterDirection.Input)
              };

            return GetEmerDetailsForIPDDetails(packageName, parameterList);
        }
        private List<EmergencyCollectionMR> GetEmerDetailsForIPDDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmergencyCollectionMR> oDMRs = new List<EmergencyCollectionMR>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                EmergencyCollectionMR oEmeregency = new EmergencyCollectionMR();
                EmrCollHead oEmrCollHead = new EmrCollHead();

                oEmeregency.EmergencyMR = (string)rdr["E_MR_NO"].ToString();

                InPatient Pat = new InPatient();
                Pat.HCN = (string)rdr["HCN"].ToString();
                Pat.Name = (string)rdr["PatientName"].ToString();
                Pat.DOB = Convert.ToDateTime(rdr["DOB"].ToString());
                Pat.Sex = (string)rdr["Sex"].ToString();
                Pat.CellPhone = (string)rdr["MobileNo"].ToString();
                Pat.EmergencyAddress = (string)rdr["Address"].ToString();

                Department oDepts = new Department();
                oDepts.DepartmentID = rdr["ADM_DEPT_ID"].ToString();
                Pat.Department = oDepts;

                DepartmentUnit oDeptUnits = new DepartmentUnit();
                oDeptUnits.UnitId = rdr["ADM_UNIT_ID"].ToString();
                Pat.DepartmentUnit = oDeptUnits;

                Doctor oDoc = new Doctor();
                oDoc.ID = rdr["ADM_DOC_ID"].ToString();
                oDoc.Name = rdr["ADM_DOC_TITLE"].ToString();
                Pat.Doctor = oDoc;

                Pat.StaffID = rdr["STAFF_ID"].ToString();

                oEmeregency.Patient = Pat;

                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["DEPT_GRP_ID"].ToString();
                oEmrCollHead.DepartmentGroup = oDeptGrp;

                Department oDept = new Department();
                oDept.DepartmentID = rdr["DEPT_ID"].ToString();
                oEmrCollHead.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["UNIT_ID"].ToString();
                oEmrCollHead.DepartmentUnit = oDeptUnit;

                oEmrCollHead.HeadID = rdr["HEAD_ID"].ToString();
                oEmrCollHead.HeadTitle = rdr["HEAD_TITLE"].ToString();
                oEmrCollHead.Fee = Convert.ToDouble(rdr["Fee"].ToString());
                oEmrCollHead.Qty = Convert.ToDouble(rdr["QTY"].ToString());
                oEmrCollHead.NetPaid = Convert.ToDouble(rdr["NetPaid"].ToString());

                oEmeregency.EmrCollHead = oEmrCollHead;

                oDMRs.Add(oEmeregency);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region GetEmerMRNo
        public List<EmergencyCollectionMR> GetEmerMRNo(string HCNNo)
        {
            string packageName = "AGH_DMS.PKG_EMERGENCY_SETUP.GET_EMR_MR_NO";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_hcn",OracleDbType.Varchar2,30,HCNNo,ParameterDirection.Input)
              };

            return GetEmerMRNoDetails(packageName, parameterList);
        }
        private List<EmergencyCollectionMR> GetEmerMRNoDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmergencyCollectionMR> oDMRs = new List<EmergencyCollectionMR>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                EmergencyCollectionMR oEmeregency = new EmergencyCollectionMR();
                oEmeregency.EmergencyMR = (string)rdr["E_MR_NO"].ToString();
                oEmeregency.IsAdmAdv = (string)rdr["IS_ADM_ADV"].ToString();
                InPatient oPat = new InPatient();

                Department oDept = new Department();
                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["ADM_DEPT_GRP_ID"].ToString();
                oDept.DepartmentGroup = oDeptGrp;

                oDept.DepartmentID = rdr["ADM_DEPT_ID"].ToString();
                oPat.Department = oDept;

                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["ADM_UNIT_ID"].ToString();
                oPat.DepartmentUnit = oDeptUnit;

                Doctor oDoc = new Doctor();
                oDoc.ID = rdr["ADM_DOC_ID"].ToString();
                oPat.Doctor = oDoc;

                oEmeregency.Patient = oPat;

              
                
                oDMRs.Add(oEmeregency);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

        #region SaveEmergencyCollectionEntry
        public string SaveEmergencyCollection(EmergencyCollectionMR mr)
        {
            string packageName = "PKG_EMERGENCY_SETUP.INSERT_EMERGENCY_COLL_ENTRY";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_e_mr_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_admission_id",OracleDbType.Varchar2,30,mr.AdmissionID,ParameterDirection.Input),             
              new OracleParameter("p_hcn",OracleDbType.Varchar2,30,mr.Patient.HCN,ParameterDirection.Input),
              new OracleParameter("p_emer_pkg_id",OracleDbType.Varchar2,30,mr.PackageID,ParameterDirection.Input),
              new OracleParameter("p_AGE_Y",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Year,ParameterDirection.Input),
              new OracleParameter("p_AGE_M",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Month,ParameterDirection.Input),
              new OracleParameter("p_AGE_D",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Day,ParameterDirection.Input),
              new OracleParameter("p_AGE_H",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Hour,ParameterDirection.Input),
              new OracleParameter("p_reff_org_id",OracleDbType.Varchar2,100,mr.RefdOrg.OrgID,ParameterDirection.Input),
              new OracleParameter("p_dept_grp",OracleDbType.Varchar2,10,mr.EmrCollHead.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
              new OracleParameter("p_dept_id",OracleDbType.Varchar2,50,mr.EmrCollHead.Department.DepartmentID,ParameterDirection.Input),
              new OracleParameter("p_unit_id",OracleDbType.Varchar2,50,mr.EmrCollHead.DepartmentUnit.UnitId,ParameterDirection.Input),
              new OracleParameter("p_doc_id",OracleDbType.Varchar2,30,mr.Doctor.ID,ParameterDirection.Input),
              new OracleParameter("p_reg_id",OracleDbType.Varchar2,30,mr.Patient.RegistrationNo,ParameterDirection.Input),
              new OracleParameter("p_bed_id",OracleDbType.Varchar2,5,mr.Patient.Bed.BedID,ParameterDirection.Input),
              new OracleParameter("p_nrs_stn",OracleDbType.Varchar2,100,mr.NursingTestOrder.NursingStationID,ParameterDirection.Input),
              new OracleParameter("p_staff_id",OracleDbType.Varchar2,30,mr.Patient.StaffID,ParameterDirection.Input),                         
              new OracleParameter("p_net_amt",OracleDbType.Decimal,100,mr.NetPaid,ParameterDirection.Input),
              new OracleParameter("p_remarks",OracleDbType.Varchar2,300,mr.Remarks,ParameterDirection.Input),
              new OracleParameter("p_collection_string",OracleDbType.Varchar2,20000,mr.TestString1,ParameterDirection.Input),  
              new OracleParameter("p_is_adm_adv",OracleDbType.Varchar2,6,mr.IsAdmAdv,ParameterDirection.Input),
              new OracleParameter("p_adm_dept_grp_id",OracleDbType.Varchar2,6,mr.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
              new OracleParameter("p_adm_dept_id",OracleDbType.Varchar2,6,mr.Patient.Department.DepartmentID,ParameterDirection.Input),
              new OracleParameter("p_adm_unit_id",OracleDbType.Varchar2,6,mr.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
              new OracleParameter("p_adm_doc_id",OracleDbType.Varchar2,6,mr.Patient.Doctor.ID,ParameterDirection.Input),
              new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)              
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string DMR_No = (string)(OracleString)prm.Value;
            return DMR_No;
        }
        #endregion

        #region SaveEmergencyCollectionPayment
        public string SaveEmergencyCollectionPayment(EmergencyCollectionMR mr)
        {
            string packageName = "PKG_EMERGENCY_SETUP.INSERT_EMERGENCY_COLL_PAY";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_trans_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_admission_id",OracleDbType.Varchar2,30,mr.AdmissionID,ParameterDirection.Input),  
              new OracleParameter("p_e_mr_no",OracleDbType.Varchar2,30,mr.EmergencyMR,ParameterDirection.Input),             
              new OracleParameter("p_tkt_no",OracleDbType.Varchar2,30,mr.Ticket.TicketNo,ParameterDirection.Input),
              new OracleParameter("p_tkt_type",OracleDbType.Varchar2,2,mr.Ticket.TicketType,ParameterDirection.Input),
              new OracleParameter("p_hcn",OracleDbType.Varchar2,30,mr.Patient.HCN,ParameterDirection.Input),
              new OracleParameter("p_AGE_Y",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Year,ParameterDirection.Input),
              new OracleParameter("p_AGE_M",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Month,ParameterDirection.Input),
              new OracleParameter("p_AGE_D",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Day,ParameterDirection.Input),
              new OracleParameter("p_AGE_H",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Hour,ParameterDirection.Input),
              new OracleParameter("p_vat",OracleDbType.Decimal,10,mr.DiagnosticPayment.VAT,ParameterDirection.Input),   
              new OracleParameter("p_discount_type",OracleDbType.Varchar2,30,mr.test.DiscountType,ParameterDirection.Input),
              new OracleParameter("p_discount_reff",OracleDbType.Varchar2,30,mr.test.DiscountReff,ParameterDirection.Input),
              new OracleParameter("p_discount_authority",OracleDbType.Varchar2,30,mr.test.DiscountAuthority,ParameterDirection.Input),
              new OracleParameter("p_discount",OracleDbType.Decimal,100,mr.DiagnosticPayment.Discount,ParameterDirection.Input),                                                   
              new OracleParameter("p_net_amt",OracleDbType.Decimal,100,mr.DiagnosticPayment.NetAmount,ParameterDirection.Input),
              new OracleParameter("p_amount",OracleDbType.Decimal,100,mr.DiagnosticPayment.Amount,ParameterDirection.Input),
              new OracleParameter("p_payment_string",OracleDbType.Varchar2,10000,mr.DiagnosticPayment.PaymentString,ParameterDirection.Input),   
              new OracleParameter("p_purpose_id",OracleDbType.Varchar2,6,mr.DiagnosticPayment.PurposeID,ParameterDirection.Input),
              new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)
              
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string DMR_No = (string)(OracleString)prm.Value;
            return DMR_No;
        }
        #endregion

        #region SaveEmergencyMaster
        public string SaveEmergencyMaster(EmergencyMaster mr)
        {
            string packageName = "PKG_EMERGENCY_SETUP.INSERT_EMERGENCY_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_trans_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_e_pres_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),                                        
              new OracleParameter("p_tkt_type",OracleDbType.Varchar2,2,mr.TicketType,ParameterDirection.Input),
              new OracleParameter("p_hcn",OracleDbType.Varchar2,30,mr.Patient.HCN,ParameterDirection.Input),
              new OracleParameter("p_emer_pkg_id",OracleDbType.Varchar2,30,mr.PackageID,ParameterDirection.Input),
              new OracleParameter("p_AGE_Y",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Year,ParameterDirection.Input),
              new OracleParameter("p_AGE_M",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Month,ParameterDirection.Input),
              new OracleParameter("p_AGE_D",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Day,ParameterDirection.Input),
              new OracleParameter("p_AGE_H",OracleDbType.Varchar2,400,mr.Patient.AgeBreakDown.Hour,ParameterDirection.Input),
              new OracleParameter("p_reff_org_id",OracleDbType.Varchar2,100,mr.RefdOrg.OrgID,ParameterDirection.Input),
              new OracleParameter("p_dept_grp",OracleDbType.Varchar2,10,mr.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
              new OracleParameter("p_dept_id",OracleDbType.Varchar2,50,mr.Department.DepartmentID,ParameterDirection.Input),
              new OracleParameter("p_unit_id",OracleDbType.Varchar2,50,mr.DepartmentUnit.UnitId,ParameterDirection.Input),
              new OracleParameter("p_doc_id",OracleDbType.Varchar2,30,mr.Doctor.ID,ParameterDirection.Input),             
              new OracleParameter("p_nrs_stn",OracleDbType.Varchar2,100,mr.NursingTestOrder.NursingStationID,ParameterDirection.Input),
              new OracleParameter("p_staff_id",OracleDbType.Varchar2,30,mr.Patient.StaffID,ParameterDirection.Input),  
              new OracleParameter("p_tkt_valid",OracleDbType.Varchar2,30,mr.TicketValidity,ParameterDirection.Input),
              new OracleParameter("p_copy_printed",OracleDbType.Varchar2,30,mr.CopyPrinted,ParameterDirection.Input),
              new OracleParameter("p_copy_printed_by",OracleDbType.Varchar2,30,mr.CopyPrintedBY,ParameterDirection.Input),
              new OracleParameter("p_prev_tkn_no",OracleDbType.Varchar2,30,mr.PrevTicketNo,ParameterDirection.Input),
              new OracleParameter("p_tkt_fee",OracleDbType.Varchar2,30,mr.TicketFee,ParameterDirection.Input),
              new OracleParameter("p_consultant_fee",OracleDbType.Varchar2,30,mr.ConsultantFee,ParameterDirection.Input),
              new OracleParameter("p_refd_fee",OracleDbType.Varchar2,30,mr.RefdFee,ParameterDirection.Input),
              new OracleParameter("p_dept_fee",OracleDbType.Varchar2,30,mr.DeptFee,ParameterDirection.Input),
              new OracleParameter("p_discount_type",OracleDbType.Varchar2,30,mr.test.DiscountType,ParameterDirection.Input),
              new OracleParameter("p_discount_reff",OracleDbType.Varchar2,30,mr.test.DiscountReff,ParameterDirection.Input),
              new OracleParameter("p_discount_authority",OracleDbType.Varchar2,30,mr.test.DiscountAuthority,ParameterDirection.Input),
              new OracleParameter("p_discount",OracleDbType.Decimal,100,mr.DiagnosticPayment.Discount,ParameterDirection.Input),
              new OracleParameter("p_vat",OracleDbType.Decimal,10,mr.DiagnosticPayment.VAT,ParameterDirection.Input),             
              new OracleParameter("p_net_amt",OracleDbType.Decimal,100,mr.DiagnosticPayment.NetAmount,ParameterDirection.Input),
              new OracleParameter("p_amount",OracleDbType.Decimal,100,mr.DiagnosticPayment.Amount,ParameterDirection.Input),
              new OracleParameter("p_next_visit_date",OracleDbType.Varchar2,20,mr.NextVisitDate,ParameterDirection.Input),    
              new OracleParameter("p_purpose_id",OracleDbType.Varchar2,6,mr.DiagnosticPayment.PurposeID,ParameterDirection.Input),
              new OracleParameter("p_is_adm_adv",OracleDbType.Varchar2,6,mr.IsAdmAdv,ParameterDirection.Input),
              new OracleParameter("p_adm_dept_grp_id",OracleDbType.Varchar2,6,mr.Patient.Department.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
              new OracleParameter("p_adm_dept_id",OracleDbType.Varchar2,6,mr.Patient.Department.DepartmentID,ParameterDirection.Input),
              new OracleParameter("p_adm_unit_id",OracleDbType.Varchar2,6,mr.Patient.DepartmentUnit.UnitId,ParameterDirection.Input),
              new OracleParameter("p_adm_doc_id",OracleDbType.Varchar2,6,mr.Patient.Doctor.ID,ParameterDirection.Input),
              new OracleParameter("p_floor_no",OracleDbType.Varchar2,6,mr.Patient.Bed.Floor,ParameterDirection.Input),
              new OracleParameter("p_room_id",OracleDbType.Varchar2,6,mr.Patient.Bed.Room.RoomID,ParameterDirection.Input),
              new OracleParameter("p_bed_type_id",OracleDbType.Varchar2,6,mr.Patient.Bed.BedType.ID,ParameterDirection.Input),
              new OracleParameter("p_category_type_id",OracleDbType.Varchar2,6,mr.Patient.Bed.BedType.BedFacility.ID,ParameterDirection.Input),
              new OracleParameter("p_bed_no",OracleDbType.Varchar2,6,mr.Patient.Bed.BedNo,ParameterDirection.Input),
              new OracleParameter("p_payment_string",OracleDbType.Varchar2,10000,mr.DiagnosticPayment.PaymentString,ParameterDirection.Input),             
              new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)
              
             };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter prm1 = parameterList[1];
            string DMR_No = (string)(OracleString)prm1.Value;
            return DMR_No;
        }
        #endregion

        #region GetPatientByEmerPrescription
        public List<EmergencyMaster> GetPatientByEmerPrescription(string Prescription)
        {
            string packageName = "AGH_DMS.PKG_EMERGENCY_SETUP.GET_PAT_EMR_PRES";
            OracleParameter[] parameterList = new OracleParameter[]
              {
                new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
                new OracleParameter ("p_prescription_no",OracleDbType.Varchar2,30,Prescription,ParameterDirection.Input)
              };

            return GetEmergencyPrescriptionDetails(packageName, parameterList);
        }
        private List<EmergencyMaster> GetEmergencyPrescriptionDetails(string packageName, OracleParameter[] parameterList)
        {
            List<EmergencyMaster> oDMRs = new List<EmergencyMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                EmergencyMaster oEmeregency = new EmergencyMaster();
                oEmeregency.EmergencyPrescriptionID = (string)rdr["E_PRES_NO"].ToString();
                InPatient Pat = new InPatient();
                Pat.HCN = (string)rdr["HCN"].ToString();
                Pat.Name = (string)rdr["PatientName"].ToString();
                Pat.DOB = Convert.ToDateTime(rdr["DOB"].ToString());
                Pat.Sex = (string)rdr["Sex"].ToString();
                Pat.EmergencyAddress = (string)rdr["Address"].ToString();

                Department oDept = new Department();
                oDept.DepartmentID = rdr["ADM_DEPT_ID"].ToString();
                DepartmentGroup oDeptGrp = new DepartmentGroup();
                oDeptGrp.DepartmentGroupID = rdr["ADM_DEPT_GRP_ID"].ToString();
                Pat.Department = oDept;
                DepartmentUnit oDeptUnit = new DepartmentUnit();
                oDeptUnit.UnitId = rdr["ADM_UNIT_ID"].ToString();
                Pat.DepartmentUnit = oDeptUnit;
                Doctor oDoc = new Doctor();
                oDoc.ID = rdr["ADM_DOC_ID"].ToString();
                oDoc.Name = rdr["AdmDoctorName"].ToString();
                Pat.Doctor = oDoc;

                oEmeregency.Patient = Pat;
                oDMRs.Add(oEmeregency);
            }
            rdr.Close();
            return oDMRs;
        }
        #endregion

    }
}
