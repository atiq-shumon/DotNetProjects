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
using AH.INVMS.MODEL;

namespace AH.IPD.DAL
{
    public class IPDDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;

        public string saveAdmission(InPatient adm)
        {
            packageName = "PKG_IPD.INSERT_PAT_ADMISSION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                new OracleParameter("PatientNo",OracleDbType.Varchar2,30,adm.HCN,ParameterDirection.Input),
                new OracleParameter("ReffType",OracleDbType.Varchar2,3,adm.ReferenceType,ParameterDirection.Input),
                new OracleParameter("ReffNo",OracleDbType.Varchar2,30,adm.ReferenceNo,ParameterDirection.Input),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,adm.RegistrationNo,ParameterDirection.Output),
                new OracleParameter("TransNo",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                new OracleParameter("StaffID",OracleDbType.Varchar2,30,adm.StaffID,ParameterDirection.Input),
                new OracleParameter("AdmissionType",OracleDbType.Varchar2,5,adm.AdmissionType,ParameterDirection.Input),
                new OracleParameter("AdmissionReason",OracleDbType.Varchar2,5,adm.AdmissionReason.ID,ParameterDirection.Input),
                new OracleParameter("PackageID",OracleDbType.Varchar2,5,adm.PackageID,ParameterDirection.Input),
                new OracleParameter("Age-Year",OracleDbType.Int32,adm.Age.Year,ParameterDirection.Input),
                new OracleParameter("Age-Month",OracleDbType.Int32,adm.Age.Month,ParameterDirection.Input),
                new OracleParameter("Age-Day",OracleDbType.Int32,adm.Age.Day,ParameterDirection.Input),
                new OracleParameter("Age-Hour",OracleDbType.Int32,adm.Age.Hour,ParameterDirection.Input),              
                new OracleParameter("ExpectedDischargeDate",OracleDbType.Date,adm.ExpDischargeDate,ParameterDirection.Input),
                new OracleParameter("p_is_opr_advised",OracleDbType.Varchar2,1,adm.IsOperationAdvised,ParameterDirection.Input),
                new OracleParameter("p_opr_id",OracleDbType.Varchar2,30,adm.OperationID,ParameterDirection.Input),
                new OracleParameter("p_expected_opr_date",OracleDbType.Date,adm.ExpectedOperationDate,ParameterDirection.Input),             
                new OracleParameter("Department",OracleDbType.Varchar2,5,adm.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,adm.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Floor_no",OracleDbType.Decimal,adm.Bed.Floor,ParameterDirection.Input),
                new OracleParameter("Bed Type",OracleDbType.Varchar2,5,adm.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("Bed_Category_Type_ID",OracleDbType.Varchar2,2,adm.Bed.BedType.BedFacility.ID,ParameterDirection.Input),
                new OracleParameter("Bed No",OracleDbType.Varchar2,5,adm.Bed.BedNo,ParameterDirection.Input),
                new OracleParameter("Room ID",OracleDbType.Varchar2,4,adm.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("Bed Charges",OracleDbType.Varchar2,40,adm.Bed.BedChargesString,ParameterDirection.Input),
                new OracleParameter("HeadGroup ID",OracleDbType.Varchar2,4,adm.RevenueHead.RevenueHeadGroup.ID,ParameterDirection.Input),
                new OracleParameter("Head ID",OracleDbType.Varchar2,4,adm.RevenueHead.ID,ParameterDirection.Input),
                new OracleParameter("Payment",OracleDbType.Decimal,adm.Payment.Amount,ParameterDirection.Input),
                new OracleParameter("NurseStation",OracleDbType.Varchar2,3,adm.NurseStation.NurseStationID,ParameterDirection.Input),
                new OracleParameter("DutyNurse",OracleDbType.Varchar2,5,adm.DutyNurse.ID,ParameterDirection.Input),
               // new OracleParameter("DepositType",OracleDbType.Char,adm.Payment.PaymentType,ParameterDirection.Input), 
                new OracleParameter("DepartmentHead",OracleDbType.Varchar2,20,adm.Department.DepartmentUnitHead,ParameterDirection.Input),
                new OracleParameter("Doctor",OracleDbType.Varchar2,30,adm.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("Purpose",OracleDbType.Varchar2,4,adm.Purpose.PurposeID,ParameterDirection.Input),
                new OracleParameter("PaymentType",OracleDbType.Int32,2,adm.Payment.PaymentType,ParameterDirection.Input),
                new OracleParameter("PaymentString",OracleDbType.Varchar2,20000,adm.Payment.PaymentString,ParameterDirection.Input),

                new OracleParameter("Remarks",OracleDbType.Varchar2,200,adm.Remarks,ParameterDirection.Input),
                new OracleParameter("EmergencyAmount",OracleDbType.Decimal,adm.EmergencyAmount,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,adm.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,adm.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,adm.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,adm.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[4], parameterList[5] };

            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value + "~" + prm[2].Value;//prm[4].Value;
            else return "0";
        }
        
       
        public double GetTotalAmount(string RegistrationNo)
        {
            string packageName = "PKG_IPD.GET_TOTAL_AMOUNT";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("RegNo",OracleDbType.Varchar2,30,RegistrationNo,ParameterDirection.Input)
            };
            return GetTotal(packageName, parameterList);

        }
        private double GetTotal(string packageName, OracleParameter[] parameterList)
        {

            OracleDataReader rdr;
            double i = 0;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {

                i = double.Parse(rdr[0].ToString());
            }
            rdr.Close();
            return i;

        }
        public List<OPDPayment> GetAdvPay(string regno)
        {
            string packageName = "PKG_IPD.GET_DEPOSIT_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,regno,ParameterDirection.Input)
            };
            return GetAdvan(packageName, parameterList);
        }
        private List<OPDPayment> GetAdvan(string packageName, OracleParameter[] parameterList)
        {
            List<OPDPayment> adpay = new List<OPDPayment>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OPDPayment payment = new OPDPayment();
                payment.EntryDate = (DateTime)rdr[11];
                payment.DepositType = (string)rdr[3];
                payment.Amount=Convert.ToInt32(rdr["amount"]);
                payment.TransactionNo = (string)rdr["trans_no"];

                adpay.Add(payment);
            }
            rdr.Close();
            return adpay;
        }
        public List<InPatient> GetBedHist(string regno)
        
         {
            string packageName = "AGH_IPD.PKG_IPD.GET_BED_REG";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,regno,ParameterDirection.Input)
            };
            return GetBedHists(packageName, paramterList);
        }
        private List<InPatient> GetBedHists(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> bedh = new List<InPatient>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InPatient bd = new InPatient();
                bd.AdmissionDate = (DateTime)rdr["Admission"];
                bd.DischargeDate = (DateTime)rdr["release_date"];
               // bd.StayingDays = (Decimal)rdr["Day_Diff"];

                Department dept = new Department();
                dept.DepartmentID = (string)rdr["dept_id"];
                dept.DepartmentTitle = (string)rdr["Department"];
                bd.Department = dept;


                DepartmentUnit ounit = new DepartmentUnit();
                ounit.UnitId = (string)rdr["unit_id"];
                ounit.UnitTitle = (string)rdr["unit_title"];
                bd.DepartmentUnit = ounit;

                Bed bds = new Bed();
                bds.BedChargesString = (string)rdr["amount"].ToString(); ;
                bds.SerialNo=Convert.ToInt16(rdr["serial_no"].ToString()) ;
                
                BedType bdtype = new BedType();
                bdtype.ID = (string)rdr["bed_type_id"];
                bdtype.Title = (string)rdr["bed_type"];

                BedFacility bedFac = new BedFacility();
                bedFac.Title = (string)rdr["facility_title"];
                bdtype.BedFacility = bedFac;
                bds.BedType = bdtype;

                bds.BedNo = (string)rdr["bed_title"];
                bds.NoOfDays = (int)rdr["no_of_day"];
                bd.Bed = bds;

                //Ward wrd = new Ward();
                //wrd.WardID = (string)rdr[3];
                //wrd.WardTitle = (string)rdr[4];
                //bd.Ward = wrd;

                bedh.Add(bd);
            }
            rdr.Close();
            return bedh;

        }
        public List<InPatient> GetDeptHistory(string regno)
        {
            string packageName = "PKG_IPD.GET_DEPT_HISTORY";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,regno,ParameterDirection.Input)
            };
            return GetDeptHist(packageName, parameterList);
        }
        private List<InPatient> GetDeptHist(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> dpths = new List<InPatient>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InPatient depth = new InPatient();
                depth.AdmissionDate = (DateTime)rdr[2];
                depth.DischargeDate = (DateTime)rdr[3];

                Department dpt = new Department();
                dpt.DepartmentTitle = (string)rdr[1];
                depth.Department = dpt;
                DepartmentUnit unit = new DepartmentUnit();
                unit.UnitTitle = (string)rdr["unit"];
                depth.DepartmentUnit = unit;
                dpths.Add(depth);

            }
            rdr.Close();
            return dpths;

        }
        public List<RevenueHead> GetDepartmentRevenue(string regno)
        {
            string packageName = "PKG_IPD.GET_DEPT_REVREG";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,30,regno,ParameterDirection.Input)
            };
            return GetDeptRevHist(packageName, parameterList);
        }
        private List<RevenueHead> GetDeptRevHist(string packageName, OracleParameter[] parameterList)
        {
            List<RevenueHead> rvhis = new List<RevenueHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RevenueHead rv = new RevenueHead();
                rv.ID = (string)rdr["Head_Id"];
                rv.Title = (string)rdr["Head"];
                rv.Amount = decimal.Parse(rdr["amount"].ToString());

                RevenueHeadGroup rvgr = new RevenueHeadGroup();
                rvgr.ID = (string)rdr["Head_Group_Id"];
                //rvgr.Title = (string)rdr["HeadGroup"];
                rv.RevenueHeadGroup = rvgr;

                rvhis.Add(rv);
            }
            rdr.Close();
            return rvhis;
        }
        public string SaveAdvanpay(InPatient adv)
        {
            packageName = "PKG_IPD.INSERT_DEPOSIT_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TransactionNo",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,adv.HCN,ParameterDirection.Input),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,adv.RegistrationNo,ParameterDirection.Input),
                new OracleParameter("StaffID",OracleDbType.Varchar2,30,adv.StaffID,ParameterDirection.Input),
                new OracleParameter("HeadGroup ID",OracleDbType.Varchar2,4,adv.RevenueHead.RevenueHeadGroup.ID,ParameterDirection.Input),
                new OracleParameter("Head ID",OracleDbType.Varchar2,5,adv.RevenueHead.ID,ParameterDirection.Input),
                new OracleParameter("Amount",OracleDbType.Decimal,adv.Payment.Amount,ParameterDirection.Input),
                new OracleParameter("Department_id",OracleDbType.Varchar2,5,adv.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit_id",OracleDbType.Varchar2,5,adv.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("Purpose_id",OracleDbType.Varchar2,20,adv.Payment.PurposeID,ParameterDirection.Input),
                new OracleParameter("PayType",OracleDbType.Varchar2,1,adv.Payment.PaymentType,ParameterDirection.Input),
                new OracleParameter("PaymentString",OracleDbType.Varchar2,20000,adv.Payment.PaymentString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,adv.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,adv.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,adv.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,adv.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[1] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value + "~" + prm[0].Value;
            else return "0";   
        }
        public string SaveBedTransfer(InPatient trans)
        {
            packageName = "PKG_IPD.INSERT_BED_TRANSFER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TransactionNo",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,trans.HCN,ParameterDirection.Input),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,trans.RegistrationNo,ParameterDirection.Input),

                new OracleParameter("Department",OracleDbType.Varchar2,5,trans.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,trans.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("FloorNo",OracleDbType.Decimal,trans.Room.Floor,ParameterDirection.Input),
                new OracleParameter("Room ID",OracleDbType.Varchar2,5,trans.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("StaffID",OracleDbType.Varchar2,30,trans.StaffID,ParameterDirection.Input),

                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,trans.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("Bed_Category_Type_ID",OracleDbType.Varchar2,2,trans.Bed.BedType.BedFacility.ID,ParameterDirection.Input), 
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,trans.Bed.BedNo,ParameterDirection.Input),            
                new OracleParameter("Bed Charges",OracleDbType.Varchar2,40,trans.Bed.BedChargesString,ParameterDirection.Input),

                new OracleParameter("HeadGroup ID",OracleDbType.Varchar2,3,trans.RevenueHead.RevenueHeadGroup.ID,ParameterDirection.Input),
                new OracleParameter("Head ID",OracleDbType.Varchar2,5,trans.RevenueHead.ID,ParameterDirection.Input),
                
                new OracleParameter("Amount",OracleDbType.Decimal,trans.Payment.Amount,ParameterDirection.Input),
                new OracleParameter("NurseStation",OracleDbType.Varchar2,3,trans.NurseStation.NurseStationID,ParameterDirection.Input),
                new OracleParameter("DutyNurse",OracleDbType.Varchar2,20,trans.DutyNurse.ID,ParameterDirection.Input),
                new OracleParameter("PurposeID",OracleDbType.Varchar2,20,trans.Payment.PurposeID,ParameterDirection.Input),
                new OracleParameter("PayType",OracleDbType.Varchar2,1,trans.Payment.PaymentType,ParameterDirection.Input),
                 new OracleParameter("PaymentString",OracleDbType.Varchar2,20000,trans.Payment.PaymentString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,trans.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,trans.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,trans.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,trans.EntryParameter.MachineID,ParameterDirection.Input)
            };
       
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[1] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value + "~" + prm[0].Value;
            else return "0";   

        }

        public string VerifyPatientDepartment(string regno , string deptID,string unitID)
        {
            packageName = "PKG_IPD.Verify_Pat_Dept";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
                new OracleParameter("Registration",OracleDbType.Varchar2,30,regno,ParameterDirection.Input),
                new OracleParameter("DeptID",OracleDbType.Varchar2,4,deptID,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,3,unitID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //string regno = (int)(OracleDecimal)cmd.Parameters[2].Value; ;
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;
        }

        public string SaveDeptTransfer(InPatient tradept)
        {
            packageName = "PKG_IPD.INSERT_DEPT_TRANSFER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TransactionNo",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,tradept.HCN,ParameterDirection.Input),
                new OracleParameter("RegistrationNo",OracleDbType.Varchar2,30,tradept.RegistrationNo,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,5,tradept.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,5,tradept.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("FloorNo",OracleDbType.Decimal,tradept.Room.Floor,ParameterDirection.Input),
                new OracleParameter("Room ID",OracleDbType.Varchar2,4,tradept.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("DepartmentHead",OracleDbType.Varchar2,20,tradept.Department.DepartmentUnitHead,ParameterDirection.Input),
                new OracleParameter("Doctor",OracleDbType.Varchar2,30,tradept.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("StaffID",OracleDbType.Varchar2,30,tradept.StaffID,ParameterDirection.Input),
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,tradept.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("Bed_Category_Type_ID",OracleDbType.Varchar2,2,tradept.Bed.BedType.BedFacility.ID,ParameterDirection.Input), 
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,tradept.Bed.BedNo,ParameterDirection.Input),            
                new OracleParameter("Bed Charges",OracleDbType.Varchar2,40,tradept.Bed.BedChargesString,ParameterDirection.Input),
                new OracleParameter("HeadGroup ID",OracleDbType.Varchar2,4,tradept.RevenueHead.RevenueHeadGroup.ID,ParameterDirection.Input),
                new OracleParameter("Head ID",OracleDbType.Varchar2,4,tradept.RevenueHead.ID,ParameterDirection.Input),               
                new OracleParameter("Amount",OracleDbType.Decimal,tradept.Payment.Amount,ParameterDirection.Input),
                new OracleParameter("NurseStation",OracleDbType.Varchar2,3,tradept.NurseStation.NurseStationID,ParameterDirection.Input),
                new OracleParameter("DutyNurse",OracleDbType.Varchar2,20,tradept.DutyNurse.ID,ParameterDirection.Input),
                new OracleParameter("Purpose",OracleDbType.Varchar2,20,tradept.Payment.PurposeID,ParameterDirection.Input),
                new OracleParameter("PayType",OracleDbType.Varchar2,1,tradept.Payment.PaymentType,ParameterDirection.Input),
                new OracleParameter("PaymentString",OracleDbType.Varchar2,20000,tradept.Payment.PaymentString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tradept.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tradept.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tradept.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tradept.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[1] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value + "~" + prm[0].Value;
            else return "0";   

        }
        //========================11-11-14=============================//
        public List<InPatient> GetDepartmentHead(string deptID, string unitID)
        {
            string packageName = "PKG_IPD.GET_DEPT_HD";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DeptID",OracleDbType.Varchar2,4,deptID,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,3,unitID,ParameterDirection.Input)
            };
            return GetDepartmentHead(packageName, parameterList);
        }
        private List<InPatient> GetDepartmentHead(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> oPats = new List<InPatient>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InPatient oPat = new InPatient();

                Department oDept = new Department(); 
                oDept.DepartmentUnitHeadID = (string)rdr["EMP_ID"];
                oDept.DepartmentUnitHead = (string)rdr["NAME"];
                oPat.Department = oDept;
                oPats.Add(oPat);
            }
            rdr.Close();
            return oPats;
        }


      
        //15-11-2014////

        public InPatient GetPatientDetailsForDis(string regID)
        {
            string packageName = "PKG_IPD.GET_PAT_DETAILS_FOR_DIS";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PrescriptionID",OracleDbType.Varchar2,30,regID,ParameterDirection.Input)
               
            };
            return GetPatientDetailsForDis(packageName, parameterList);
        }
       
        private InPatient GetPatientDetailsForDis(string packageName, OracleParameter[] parameterList)
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

                OPDPayment opd = new OPDPayment();
                opd.Amount = Convert.ToInt32(rdr["amount"]);

                oPat.Payment = opd;

                //Department oDept = new Department();
                //oDept.DepartmentTitle = (string)rdr["Dept_Title"];
                //oPat.Department = oDept;

                //DepartmentUnit dUnit = new DepartmentUnit();
                //dUnit.UnitTitle = (string)rdr["Unit_Title"];
                //oPat.DepartmentUnit = dUnit;

                //Doctor doc = new Doctor();
                //doc.ID = (string)rdr["Doc_ID"];
                //doc.Name = !rdr.IsDBNull(6) ? (string)rdr["Reff_Doc_name"] : "";
                //oPat.Doctor = doc;
                //oPats.Add(oPat);
            }
            rdr.Close();
            return oPat;
        }

        //=======================================18-11-2014===================================//
        

        public InPatient GetPatientAdvancePayment(string regID)
        {
            string packageName = "PKG_IPD.GET_PATIENT_ADVANCE_PAYMENT";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Reg_ID",OracleDbType.Varchar2,30,regID,ParameterDirection.Input)
               
            };
            return GetPatientAdvancePayment(packageName, parameterList);
        }
        private InPatient GetPatientAdvancePayment(string packageName, OracleParameter[] parameterList)
        {

            InPatient oPat = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OPDPayment opd=new OPDPayment ();
                opd.Amount=Convert.ToInt32(rdr["amount"]);
                oPat.Payment = opd;
            }
            rdr.Close();
            return oPat;
        }

        public string SavePatientForDischarge(InPatient adm)
        {
            packageName = "PKG_IPD.INSERT_PAT_DIS_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                   new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                   new OracleParameter("P_Reg_id",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
                   new OracleParameter("HCN_No",OracleDbType.Varchar2,30,adm.Payment.HCN,ParameterDirection.Input),
                   new OracleParameter("Reg_Id",OracleDbType.Varchar2,30,adm.RegistrationNo,ParameterDirection.Input),
                   new OracleParameter("Department",OracleDbType.Varchar2,5,adm.Department.DepartmentID,ParameterDirection.Input),
                   new OracleParameter("Unit",OracleDbType.Varchar2,5,adm.DepartmentUnit.UnitId,ParameterDirection.Input),
                   new OracleParameter("Bed_Serial_No",OracleDbType.Decimal,3,adm.Bed.SerialNo,ParameterDirection.Input),
                   new OracleParameter("Revenue_Head",OracleDbType.Varchar2,4000,adm.RevenueHead.RevenueHeadString,ParameterDirection.Input),
                   new OracleParameter("VAT",OracleDbType.Decimal,adm.Payment.VAT,ParameterDirection.Input),
                   new OracleParameter("P_Discopunt",OracleDbType.Decimal,adm.Payment.Discount,ParameterDirection.Input),
                   new OracleParameter("P_Advance",OracleDbType.Decimal,adm.Payment.Advance,ParameterDirection.Input),
                   new OracleParameter("Total",OracleDbType.Decimal,adm.Payment.Amount,ParameterDirection.Input),
                   new OracleParameter("Net_Amount",OracleDbType.Decimal,adm.Payment.NetAmount,ParameterDirection.Input),
                   new OracleParameter("Payment_Type",OracleDbType.Varchar2,30,adm.Payment.PaymentType,ParameterDirection.Input),
                   new OracleParameter("PaymentString",OracleDbType.Varchar2,20000,adm.Payment.PaymentString,ParameterDirection.Input),
                   new OracleParameter("Discharge_Type_Id",OracleDbType.Varchar2,30,adm.DischargeType,ParameterDirection.Input),
                  // new OracleParameter("Bed_Serial",OracleDbType.Varchar2,10,adm.Bed.BedNo,ParameterDirection.Input),
                   new OracleParameter("Purpose_Id",OracleDbType.Varchar2,4,adm.Payment.PurposeID,ParameterDirection.Input),
                   new OracleParameter("StaffID",OracleDbType.Varchar2,30,adm.StaffID,ParameterDirection.Input),
                   new OracleParameter("EntryBy",OracleDbType.Varchar2,20,adm.EntryParameter.EntryBy,ParameterDirection.Input),
                   new OracleParameter("CompanyID",OracleDbType.Varchar2,2,adm.EntryParameter.CompanyID,ParameterDirection.Input),
                   new OracleParameter("LocationID",OracleDbType.Varchar2,2,adm.EntryParameter.LocationID,ParameterDirection.Input),
                   new OracleParameter("MachineID",OracleDbType.Varchar2,20,adm.EntryParameter.MachineID,ParameterDirection.Input)
             
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0], parameterList[1] };
            if ((OracleDecimal)prm[0].Value == 1)
                return prm[1].Value.ToString();
            else return "0";

            //short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter[] prm = { parameterList[0], parameterList[4], parameterList[5] };

            //if ((OracleDecimal)prm[0].Value == 1)
            //    return prm[1].Value + "~" + prm[2].Value;//prm[4].Value;
            //else return "0";
        }

        public string VerifyHcnNo(string HcnNo)
        {
            packageName = "PKG_IPD.P_VERIFY_HCN_NO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Varchar2,400,null,ParameterDirection.Output),
                new OracleParameter("HcnNo",OracleDbType.Varchar2,30,HcnNo,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);          
            OracleParameter prm = parameterList[0];
            string output = (string)(OracleString)prm.Value;
            return output;            
        }


        //=========================17-12-2014===============================//
        public short SavePatientAdmissionCancel(InPatient admCan)
        {
            packageName = "PKG_IPD.INSERT_ADM_CANC_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                   new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                   new OracleParameter("HCN_No",OracleDbType.Varchar2,30,admCan.Payment.HCN,ParameterDirection.Input),
                   new OracleParameter("Reg_Id",OracleDbType.Varchar2,30,admCan.RegistrationNo,ParameterDirection.Input),
                   new OracleParameter("Department",OracleDbType.Varchar2,5,admCan.Department.DepartmentID,ParameterDirection.Input),
                   new OracleParameter("Unit",OracleDbType.Varchar2,5,admCan.DepartmentUnit.UnitId,ParameterDirection.Input),                
                   new OracleParameter("HeadGroup ID",OracleDbType.Varchar2,4,admCan.RevenueHead.RevenueHeadGroup.ID,ParameterDirection.Input),
                   new OracleParameter("Head ID",OracleDbType.Varchar2,4,admCan.RevenueHead.ID,ParameterDirection.Input),
                   new OracleParameter("StaffID",OracleDbType.Varchar2,30,admCan.StaffID,ParameterDirection.Input),
                   new OracleParameter("Purpose",OracleDbType.Varchar2,20,admCan.Payment.PurposeID,ParameterDirection.Input),
                   new OracleParameter("PayType",OracleDbType.Varchar2,1,admCan.Payment.PaymentType,ParameterDirection.Input),
                   new OracleParameter("PaymentString",OracleDbType.Varchar2,20000,admCan.Payment.PaymentString,ParameterDirection.Input),
                   new OracleParameter("P_Amount",OracleDbType.Decimal,admCan.Payment.NetAmount,ParameterDirection.Input),
                   new OracleParameter("Reason_Id",OracleDbType.Varchar2,5,admCan.CancellationReason,ParameterDirection.Input),
                   new OracleParameter("Remarks",OracleDbType.Varchar2,300,admCan.Remarks,ParameterDirection.Input),
                   new OracleParameter("EntryBy",OracleDbType.Varchar2,30,admCan.EntryParameter.EntryBy,ParameterDirection.Input),
                   new OracleParameter("CompanyID",OracleDbType.Varchar2,2,admCan.EntryParameter.CompanyID,ParameterDirection.Input),
                   new OracleParameter("LocationID",OracleDbType.Varchar2,2,admCan.EntryParameter.LocationID,ParameterDirection.Input),
                   new OracleParameter("MachineID",OracleDbType.Varchar2,20,admCan.EntryParameter.MachineID,ParameterDirection.Input)
             
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public string CheckPatStayingTime(string regno)
        {
            packageName = "PKG_IPD.Check_Pat_Staying_Time";
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

   
       
        public InPatient GetPatientEmergencyContactDetails(string hcn)
        {
            string packageName = "PKG_IPD.GET_PAT_EMERG_CONTACT_DETAILS";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,hcn,ParameterDirection.Input)
            };
            return GetPatientEmergencyContactDetails(packageName, parameterList);

        }
        private InPatient GetPatientEmergencyContactDetails(string packageName, OracleParameter[] parameterList)
        {
            InPatient inp = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                inp.EmergencyContactPerson =  !rdr.IsDBNull(0) ?(string)rdr["E_CONT_PERSON"] : "";
                inp.EmergencyAddress =  !rdr.IsDBNull(1) ?(string)rdr["E_ADdRESS"] : "";
                inp.EmergencyCellPhone =  !rdr.IsDBNull(2) ?(string)rdr["E_CELL_PHONE"] : "";
                inp.EmergencyHomePhone =  !rdr.IsDBNull(3) ?(string)rdr["E_HOME_PHONE"]: "";
                inp.EmergencyPersonRelation = !rdr.IsDBNull(4) ? (string)rdr["Relation_With_Pat"] : "";
            }
            rdr.Close();
            return inp;
        }

        public InPatient GetPatientAdressInformation(string hcn)
        {
            string packageName = "PKG_IPD.GET_PAT_ADDRESS_DETAILS";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,hcn,ParameterDirection.Input)
            };
            return GetPatientAdressInformation(packageName, parameterList);

        }
        private InPatient GetPatientAdressInformation(string packageName, OracleParameter[] parameterList)
        {
            InPatient inp = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                inp.Present_H_R_B = (string)rdr["HO_VI_AR_RD"];
                inp.Present_Post= !rdr.IsDBNull(1) ? (string)rdr["POST_CODE"] : "";
                inp.PresentThana =  (string)rdr["THANA_CODE"];
                inp.PresentDistrict = (string)rdr["DISTRICT_CODE"] ;
                inp.Permanent_H_R_B =(string)rdr["PER_HO_VI_AR_RD"] ;
                inp.Permanent_Post = !rdr.IsDBNull(5) ? (string)rdr["PER_POST_CODE"] : "";
                inp.PermanentThana = (string)rdr["PER_THANA_CODE"] ;
                inp.PermanentDistrict =  (string)rdr["PER_DISTRICT_CODE"] ;
                inp.Country = (string)rdr["COUNTRY"];
            }
            rdr.Close();
            return inp;
        }

        public double GetTotalAmountForDischarge(string RegistrationNo)
        {
            string packageName = "PKG_IPD.GET_TOTAL_AMOUNT_FOR_DISCHARGE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("RegNo",OracleDbType.Varchar2,30,RegistrationNo,ParameterDirection.Input)
            };
            return GetTotalAmountForDischarge(packageName, parameterList);

        }
        private double GetTotalAmountForDischarge(string packageName, OracleParameter[] parameterList)
        {

            OracleDataReader rdr;
            double i = 0;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {

                i = double.Parse(rdr[0].ToString());
            }
            rdr.Close();
            return i;

        }


        //public List<InPatient> GetAdmittedPatientList()
        //{
        //    string packageName = "PKG_IPD.GET_ADMITTED_PATIENT_LIST";

        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //    };
        //    return GetAdmittedPatientList(packageName, parameterList);

        //}
    
   /*     private List<InPatient> GetAdmittedPatientList(string packageName, OracleParameter[] parameterList)
        {
            List<InPatient> inpList = new List<InPatient>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InPatient inp = new InPatient();
                inp.Name = (string)rdr["pat_name"];
                inp.HCN = (string)rdr["hcn"];         
                inp.RegistrationNo = (string)rdr["reg_id"];
                inpList.Add(inp);
            }
            rdr.Close();
            return inpList;
        }*/
        //private List<InPatient> GetAdmittedPatientList(string packageName, OracleParameter[] parameterList)
        //{
        //    List<InPatient> inpList = new List<InPatient>();
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

        //        Bed bd = new Bed();
        //        bd.BedNo = (string)rdr["bed_no"];
        //        bd.BedTitle = (string)rdr["bed_title"];
        //        inp.Bed = bd;


        //        Room rm = new Room();
        //        rm.RoomID = Convert.ToInt16(rdr["room_id"]).ToString();
        //        rm.RoomTitle = (string)rdr["room_title"];
        //        rm.Floor = (string)rdr["floor_no"].ToString();
        //        inp.Room = rm;

        //        OPDPayment pay = new OPDPayment();
        //        //pay.TransactionNo = (string)rdr["trans_no"];
        //        pay.Amount = Convert.ToDecimal(rdr["amount"]);
        //        inp.Payment = pay;

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
        //        inp.AdmissionDate = (DateTime)rdr["DT"];
        //      //  inp.HourDifference = Convert.ToInt32(rdr["Hour_diff"]);
        //        inpList.Add(inp);

        //    }
        //    rdr.Close();
        //    return inpList;
        //}
        public InPatient GetPatientInfoByBedID(string bedID)
        {
            string packageName = "PKG_IPD.GET_PATIENT_INFO_BY_BEDID";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("bedID",OracleDbType.Varchar2,30,bedID,ParameterDirection.Input)
            };
            return GetPatientInfoByBedID(packageName, parameterList);

        }
        private InPatient GetPatientInfoByBedID(string packageName, OracleParameter[] parameterList)
        {
            InPatient inp = new InPatient();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
               // InPatient inp = new InPatient();
                inp.Name = (string)rdr["pat_name"];
                inp.RegistrationNo = (string)rdr["reg_id"];
                Room rm = new Room();
                rm.RoomTitle = (string)rdr["room_title"];
                inp.Room = rm;
                Bed bd = new Bed();
                bd.BedTitle = (string)rdr["bed_title"];
                inp.Bed = bd;
               
            }
            rdr.Close();
            return inp;
        }
        public AccountsPayment GetCollectionToTransferAcc(string userID)
        {
            string packageName = "PKG_IPD.Get_Collection_To_Transfer_Acc";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("userID",OracleDbType.Varchar2,30,userID,ParameterDirection.Input)              
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            AccountsPayment oAccountPay = new AccountsPayment();
            while (rdr.Read())
            {
                oAccountPay.CashAmount = Convert.ToUInt64(rdr["CASH_AMT"] == DBNull.Value ? 0 : rdr["CASH_AMT"]);
                oAccountPay.CreditCardAmount = Convert.ToUInt64(rdr["CREDIT_CARD_AMT"] == DBNull.Value ? 0 : rdr["CREDIT_CARD_AMT"]);
                oAccountPay.DebitCardAmount = Convert.ToUInt64(rdr["DEBIT_CARD_AMT"] == DBNull.Value ? 0 : rdr["DEBIT_CARD_AMT"]);
            }
            rdr.Close();
            return oAccountPay;
        }
        public short InsertUserCloseRegister(AccountsPayment oAccount)
        {
            string packageName = "PKG_IPD.INSERT_USER_CLOSE_REGISTER";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("p_test_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output), 
                new OracleParameter("userID",OracleDbType.Varchar2,30,oAccount.EntryParameter.EntryBy,ParameterDirection.Input),

                new OracleParameter("CASH_AMT",OracleDbType.Decimal,oAccount.CashAmount,ParameterDirection.Input),
                new OracleParameter("CREDIT_CARD_AMT",OracleDbType.Decimal,oAccount.CreditCardAmount,ParameterDirection.Input),
               new OracleParameter("DEBIT_CARD_AMT",OracleDbType.Decimal,oAccount.DebitCardAmount,ParameterDirection.Input),

                new OracleParameter("Total_COllection",OracleDbType.Decimal,oAccount.TotalCollection,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,oAccount.Remarks,ParameterDirection.Input),

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oAccount.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oAccount.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oAccount.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oAccount.EntryParameter.MachineID,ParameterDirection.Input),
                //new OracleParameter("date",OracleDbType.Varchar2,30,oAccount.AmountSendToAccountDate,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public List<ItemOrder> GetBillableItemDetails(string regID)
        {
            List<ItemOrder> ItmOrder = new List<ItemOrder>();
            string packageName = "AGH_IPD.PKG_NURSE_REQUISITION.Get_Billable_Items_Details";
            OracleParameter[] parameterList = new OracleParameter[] 
           { 
                new OracleParameter("ref", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("regID",OracleDbType.Varchar2,30,regID,ParameterDirection.Input)
           };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ItemOrder OItm = new ItemOrder();

                ItemMaster item = new ItemMaster();
                item.ID = (string)rdr["PROD_ID"];
                item.Name = (string)rdr["PROD_Name"];

                Units ounit = new Units();
                ounit.ID = (string)rdr["PROD_UNIT_ID"];
                ounit.Name = (string)rdr["PROD_UNIT_Name"];
                item.Units = ounit;

                GroupDetails ogroup = new GroupDetails();
                ogroup.ID = (string)rdr["PROD_GRP_ID"];
                ogroup.Name = (string)rdr["PROD_GRP_Name"];
                item.GroupDetails = ogroup;

                item.ReorderQty = Convert.ToInt32(rdr["QTY"]);
                item.Urate = float.Parse(rdr["URATE"].ToString());

                item.PODate = (string)rdr["EDate"].ToString();
                OItm.ItemMaster = item;

                ItmOrder.Add(OItm);
            }
            rdr.Close();
            return ItmOrder;
        }

    }
}
