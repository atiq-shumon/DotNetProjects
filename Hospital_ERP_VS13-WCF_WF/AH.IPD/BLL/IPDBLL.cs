using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AH.PatReg.MODEL;
using AH.IPD.DAL;
using AH.DUtility;
using AH.Shared.MODEL;
using AH.IPDShared.MODEL;
using AH.INVMS.MODEL;
//using AH.OPRMS.DAL;

namespace AH.IPD.BLL
{
    public class IPDBLL
    {
        public string saveAdmission(InPatient adm)
        {
            return new IPDDAL().saveAdmission(adm);
        }
       
        public List<OPDPayment> GetAdvPay(string regno)
        {
            return new IPDDAL().GetAdvPay(regno);
        }
        public string SaveAdvanpay(InPatient adv)
        {
            return new IPDDAL().SaveAdvanpay(adv);
        }
        public string SaveBedTransfer(InPatient trans)
        {
            return new IPDDAL().SaveBedTransfer(trans);
        }
        public double GetTotalAmount(string RegistrationNo)
        {
            return new IPDDAL().GetTotalAmount(RegistrationNo);
        }
        public string SaveDeptTransfer(InPatient tradept)
        {
            return new IPDDAL().SaveDeptTransfer(tradept);
        }
        public List<InPatient> GetBedHist(string regno)
        {
            return new IPDDAL().GetBedHist(regno);
        }
        public List<InPatient> GetDeptHistory(string regno)
        {
            return new IPDDAL().GetDeptHistory(regno);
        }
       
        public List<RevenueHead> GetDepartmentRevenue(string regno)
        {
            return new IPDDAL().GetDepartmentRevenue(regno);
        }
        public List<InPatient> GetDepartmentHead(string deptID, string unitID)
        {
            return new IPDDAL().GetDepartmentHead(deptID, unitID);
        }
       
        public InPatient GetPatientDetailsForDis(string regID)
        {
            return new IPDDAL().GetPatientDetailsForDis(regID);
        }

        public InPatient GetPatientAdvancePayment(string regID)
        {
            return new IPDDAL().GetPatientAdvancePayment(regID);
        }
        public string SavePatientForDischarge(InPatient adm)
        {
            return new IPDDAL().SavePatientForDischarge(adm);
        }
        //public string VerifyPrescriptionNo(string prescriptionId)
        //{
        //    return new IPDDAL().VerifyPrescriptionNo(prescriptionId);
        //}

        public string VerifyHcnNo(string hcn)
        {
            return new IPDDAL().VerifyHcnNo(hcn);
            //if (hcn == "")
            //{
            //    return Utility.GetMsg(Utility.Msg.ValidPrescriptionNo);
            //};
            //var res = new IPDDAL().VerifyHcnNo(hcn);
            //if (res != "1")
            //{
            //    return res;
            //}
            //return "";
        }

        public string VerifyPatientDepartment(string regno, string deptID, string unitID)
        {
            return new IPDDAL().VerifyPatientDepartment(regno, deptID, unitID);
        }

        public short SavePatientAdmissionCancel(InPatient adm)
        {
            return new IPDDAL().SavePatientAdmissionCancel(adm);
        }

        public string CheckPatStayingTime(string regID)
        {
            var res = new IPDDAL().CheckPatStayingTime(regID);
            if (res != "1")
            {
                return res;
            }
            return "";
        }
     
       
        public InPatient GetPatientEmergencyContactDetails(string hcn)
        {
            return new IPDDAL().GetPatientEmergencyContactDetails(hcn);
        }
        public InPatient GetPatientAdressInformation(string hcn)
        {
            return new IPDDAL().GetPatientAdressInformation(hcn);
        }
    
        public double GetTotalAmountForDischarge(string RegistrationNo)
        {
            return new IPDDAL().GetTotalAmountForDischarge(RegistrationNo);
        }
        public InPatient GetPatientInfoByBedID(string bedID)
        {
            return new IPDDAL().GetPatientInfoByBedID(bedID);
        }
        public short InsertUserCloseRegister(AccountsPayment oAccount)
        {
            return new IPDDAL().InsertUserCloseRegister(oAccount);
        }
        public AccountsPayment GetCollectionToTransferAcc(string userID)
        {
            return new IPDDAL().GetCollectionToTransferAcc(userID);
        }
        public List<ItemOrder> GetBillableItemDetails(string regID)
        {
            return new IPDDAL().GetBillableItemDetails(regID);
        }
    }
}
