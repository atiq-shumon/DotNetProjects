using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.IPD.DAL;
using AH.DUtility;
using AH.Shared.MODEL;
using AH.IPD.MODEL;
using AH.HR.BLL;
using AH.ORGMS.BLL;

namespace AH.IPD.BLL
{
    public class IPDSetupBLL
    {
        public short SaveDeliveryType(DeliveryType tipd)
        {
            return new IPDSetupDAL().SaveDeliveryType(tipd);
        }
        public short UpdateDelType(DeliveryType uipd)
        {
            return new IPDSetupDAL().UpdateDelType(uipd);
        }
        //public short SaveOperationType(OperationType ot)
        //{
        //    return new IPDSetupDAL().SaveOperationType(ot);
        //}
        //public short UpdateOperation(OperationType upot)
        //{
        //    return new IPDSetupDAL().UpdateOperation(upot);
        //}
       
        public List<DeliveryType> GetDeliveryType()
        {
            return new IPDSetupDAL().GetDeliveryType();
        }
        public int VerifyDelivery(string delid)
        {
            return new IPDSetupDAL().VerifyDelivery(delid);
        }
        //public List<OperationType> GetOperationType()
        //{
        //    return new IPDSetupDAL().GetOperationType();
        //}
        //public int VerifyOperation(string typeid)
        //{
        //    return new IPDSetupDAL().VerifyOperation(typeid);
        //}
       
        public short SaveAdmissionReason(AdmissionReason admr)
        {
            return new IPDSetupDAL().SaveAdmissionReason(admr);
        }
        public short UpdateAdmissionReason(AdmissionReason admr)
        {
            return new IPDSetupDAL().UpdateAdmissionReason(admr);
        }
        public List<AdmissionReason> GetAdmReason()
        {
            return new IPDSetupDAL().GetAdmReason();
        }
        public Dictionary<string, string> GetAdmReason(string type)
        {
            Dictionary<string, string> adrsn = new Dictionary<string, string>();
            foreach (AdmissionReason adm in new IPDSetupDAL().GetAdmReason())
            {
                adrsn.Add(adm.ID, adm.Title);
            }
            return adrsn;
        }

        public short SaveAdmReasonAss(AdmReasonAssign admass)
        {
            return new IPDSetupDAL().SaveAdmReasonAss(admass);
        }
        public List<AdmReasonAssign> GetAdmReasonAss()
        {
            return new IPDSetupDAL().GetAdmReasonAss();
        }
        public List<AdmReasonAssign> GetAdmReasonAss(string departmentID)
        {
            return new IPDSetupDAL().GetAdmReasonAss(departmentID);
        }
        public Dictionary<string, string> GetAdmReason(string type, string departmentID)
        {
            Dictionary<string, string> adrsn = new Dictionary<string, string>();
            foreach (AdmReasonAssign adm in new IPDSetupDAL().GetAdmReasonAss(departmentID))
            {
                adrsn.Add(adm.AdmissionReason.ID, adm.AdmissionReason.Title);
            }
            return adrsn;
        }
        public int GetMinStayingDays(string admReason)
        {
            return new IPDSetupDAL().GetMinStayingDays(admReason);
        }
        //public Dictionary<string, string> GetDeptUnitAssigned(string type, string deptid)
        //{
        //    return new AdministrationSetupBLL().GetDeptUnitAssigned(type, deptid);
        //}
        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(deptgrp, deptid);
        }

        public short SaveAdmissionReffType(AdmissionReference delType)
        {
            return new IPDSetupDAL().SaveAdmissionReffType(delType);
        }
        public List<AdmissionReference> GetAdmReffType()
        {
            return new IPDSetupDAL().GetAdmReffType();
        }
        public short UpdateAdmissionReffType(AdmissionReference delType)
        {
            return new IPDSetupDAL().UpdateAdmissionReffType(delType);
        }
        public Dictionary<string, string> GetAdmReffTypeDic(string type)
        {
            Dictionary<string, string> deltDic = new Dictionary<string, string>();
            foreach (AdmissionReference delType in new IPDSetupDAL().GetAdmReffType())
            {
                deltDic.Add(delType.ID, delType.Title);
            }
            return deltDic;
        }
        //================17-12-2014=========================//

        public short SaveCancelReason(CancelReasonSetup canRes)
        {
            return new IPDSetupDAL().SaveCancelReason(canRes);
        }
        public Dictionary<string, string> GetAdmCancelReasonDic(string type)
        {
            Dictionary<string, string> oCanResDic = new Dictionary<string, string>();
            foreach (CancelReasonSetup oCanRes in new IPDSetupDAL().GetCancelReason())
            {
                oCanResDic.Add(oCanRes.ID, oCanRes.Title);
            }
            return oCanResDic;
        }
        public short UpdateCancelReason(CancelReasonSetup oCanRes)
        {
            return new IPDSetupDAL().UpdateCancelReason(oCanRes);
        }

        public List<CancelReasonSetup> GetCancelReason()
        {
            return new IPDSetupDAL().GetCancelReason();
        }
        public short SavePackageMaster(PackageSetup pkg)
        {
            return new IPDSetupDAL().SavePackageMaster(pkg);
        }
        public List<PackageSetup> GetPackageMaster()
        {
            return new IPDSetupDAL().GetPackageMaster();
        }
        public short UpdatePackageMaster(PackageSetup pkg)
        {
            return new IPDSetupDAL().UpdatePackageMaster(pkg);
        }

        public Dictionary<string, string> GetPackageMasteDic(string type)
        {
            Dictionary<string, string> oPkgDic = new Dictionary<string, string>();
            foreach (PackageSetup oPkg in new IPDSetupDAL().GetPackageMaster())
            {
                oPkgDic.Add(oPkg.PackageID, oPkg.PackageTitle);
            }
            return oPkgDic;
        }
       
    }
}
