using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using AH.OPRMS.MODEL;
using AH.IPDShared.MODEL;
using AH.OPRMS.BLL;
using System.Text;
using AH.IPDShared.BLL;
using AH.ORGMS.BLL;
using AH.Shared.MODEL;

namespace AH.OPRMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OPRWS" in both code and config file together.
    public class OPRWS : IOPRWS
    {
       #region"Grade"
        public short SaveGradeSetup(Grade grd)
        {
            return new OPRSetupBLL().SaveGradeSetup(grd);
        }
        public List<Grade> GetGrade()
        {
            return new OPRSetupBLL().GetGrade();
        }
        public short UpdateGradeSetup(Grade objTran)
        {
            return new OPRSetupBLL().UpdateGradeSetup(objTran);
        }
        public short DeleteGrade(Grade objTran)
        {
            return new OPRSetupBLL().DeleteGrade(objTran);
        }
        #endregion
       #region "Theater"
        public short SavetheaterSetup(Theater objTran)
        {
            return new OPRSetupBLL().SavetheaterSetup(objTran);
        }
        public short UpdatetheaterSetup(Theater objTran)
        {
            return new OPRSetupBLL().UpdatetheaterSetup(objTran);
        }
        public short Deletetheater(Theater objTran)
        {
            return new OPRSetupBLL().Deletetheater(objTran);
        }
        public List<Theater> GetTheater()
        {
            return new OPRSetupBLL().GetTheater();
        }
        #endregion
       #region "Anes Group"
        public short SaveAnesSetup(AnesthesiaGroup objTran)
        {
            return new OPRSetupBLL().SaveAnesSetup(objTran);
        }
        public short UpdateAnesSetup(AnesthesiaGroup objTran)
        {
            return new OPRSetupBLL().UpdateAnesSetup(objTran);
        }
        public short DeleteAnesGroup(AnesthesiaGroup objTran)
        {
            return new OPRSetupBLL().DeleteAnesGroup(objTran);
        }
        public List<AnesthesiaGroup> GetTAnesthesia()
        {
            return new OPRSetupBLL().GetTAnesthesia();
        }
        #endregion
        #region "Dictionary 1"
        public Dictionary<string, string> GetAnesthesiaGroups(string type)
        {
            return new OPRSetupBLL().GetAnesthesiaGroups(type);
        }
        #endregion
        #region "Save Anesthesia"
        public short SaveAnesSetupMaster(AnesthesiaMaster objTran)
        {
            return new OPRSetupBLL().SaveAnesSetupMaster(objTran);
        }
        public short UpdateAnesSetupMaster(AnesthesiaMaster objTran)
        {
            return new OPRSetupBLL().UpdateAnesSetupMaster(objTran);
        }
        public List<AnesthesiaMaster> GetAnesthesiaMaster()
        {
            return new OPRSetupBLL().GetAnesthesiaMaster();
        }
        public short DeleteAnesMaster(AnesthesiaMaster objTran)
        {
            return new OPRSetupBLL().DeleteAnesMaster(objTran);
        }
        #endregion
        #region "Dictionary 1"
        public Dictionary<string, string> GetOperationType(string type)
        {
            return new OPRSetupBLL().OperationType(type);
        }
        public Dictionary<string, string> LoadGrade(string type)
        {
            return new OPRSetupBLL().LoadGrade(type);
        }
        public Dictionary<string, string> LoadAnesthesiaID(string type)
        {
            return new OPRSetupBLL().LoadAnesthesiaID(type);
        }
        #endregion
        #region "Operation Setup"
        public short SaveOperationSetup(OperationMaster objTran)
        {
            return new OPRSetupBLL().SaveOperationSetup(objTran);
        }
        public short UpdateOperationSetup(OperationMaster objTran)
        {
            return new OPRSetupBLL().UpdateOperationSetup(objTran);
        }
        #endregion
        #region "Load"
        public List<OperationMaster> LoadOperationMaster()
        {
            return new OPRSetupBLL().LoadOperationMaster();
        }
        #endregion
        #region "Dictionary 2"
        public Dictionary<string, string> GetDepID(string type)
        {
            return new OPRSetupBLL().GetDepID(type);
        }
        public Dictionary<string, string> GetTheaterBed(string type)
        {
            return new OPRSetupBLL().GetTheaterBed(type);
        }
        public Dictionary<string, string> GetRegID(string type)
        {
            return new OPRSetupBLL().GetRegID(type);
        }
        public Dictionary<string, string> GetRoomIdFromTheater(string type, string where)
        {
            return new OPRSetupBLL().GetRoomIdFromTheater(type, where);
        }
        public Dictionary<string, string> GetDoctorsCategory(string type, string where)
        {
            return new OPRSetupBLL().GetDoctorsCategory(type, where);
        }
        #endregion
        #region "Save Category"
        public short SavedDoctotsCategory(DoctorsCategory objTran)
        {
            return new OPRSetupBLL().SavedDoctotsCategory(objTran);
        }
        public short SavedDoctotsCategoryMaster(DoctorsCategory objTran)
        {
            return new OPRSetupBLL().SavedDoctotsCategoryMaster(objTran);
        }
        #endregion
        #region "Display Category"
        public List<DoctorsCategory> DisplayDoctorsCategory(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayDoctorsCategory(strcontrol, strWhere);
        }
        #endregion
        #region "Doctors Assign"
        public Dictionary<string, string> GetDoctorsAssign(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().GetDoctorsAssign(strcontrol, strWhere);
        }
        #endregion
        #region "Saved Packageitem"
        public short SavedPackagedItem(PackageItem objTran)
        {
            return new OPRSetupBLL().SavedPackagedItem(objTran);
        }
        public short UpdatePackagedItem(PackageItem objTran)
        {
            return new OPRSetupBLL().UpdatePackagedItem(objTran);
        }
        #endregion
        #region "Get PackageItem"
        public List<PackageItem> GetPackageItem(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().GetPackageItem(strcontrol, strWhere);
        }
        #endregion
        #region "Saved Package"
        public string  SavedPackageMaster(PackageItem objTran)
        {
            return new OPRSetupBLL().SavedPackageMaster(objTran);
        }
        public short SavedPackageChild(PackageItem objTran)
        {
            return new OPRSetupBLL().SavedPackageChild(objTran);
        }
        #endregion
        #region "Get Package"
        public List<PackageItem> GetPackage(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().GetPackage(strcontrol, strWhere);
        }
        #endregion
        #region "Display Pckage"
        public List<PackageItem> DisplayPackage(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayPackage(strcontrol, strWhere);
        }
        #endregion
        #region "Update Package"
        public short UpdatePackageMaster(PackageItem objTran)
        {
            return new OPRSetupBLL().UpdatePackageMaster(objTran);
        }
        public short UpdatePackageChild(PackageItem objTran)
        {
            return new OPRSetupBLL().UpdatePackageChild(objTran);
        }
        #endregion
        #region "Display Category"
        public List<DoctorsCategory> DispalyTeamAssign(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DispalyTeamAssign(strcontrol, strWhere);
        }
        #endregion
        #region "Dictionary"
        public Dictionary<string, string> GetRegScheduling()
        {
            return new OPRSetupBLL().GetRegScheduling();
        }
        public Dictionary<string, string> GetInchargeID()
        {
            return new OPRSetupBLL().GetInchargeID();
        }
        public Dictionary<string, string> GetPacageInformation()
        {
            return new OPRSetupBLL().GetPacageInformation();
        }
        #endregion
        #region "Saved Scheduling"
        public string  SavedOperationSchedulingMaster(CalenderOT objTran)
        {
            return new OPRSetupBLL().SavedOperationSchedulingMaster(objTran);
        }
        public short SavedOperationSchedulingChild(string strScheduleid, string stRegDate,
                                                 int intRow, int intCol, string strTheaterid,
                                                 string strTimesSlot, string entryby, int intversion, string strcompanyid, string strlocationid, string strmachineid)
        {
            return new OPRSetupBLL().SavedOperationSchedulingChild(strScheduleid, stRegDate, intRow, intCol, strTheaterid, strTimesSlot, entryby, intversion, strcompanyid, strlocationid, strmachineid);
        }
        #endregion
        #region "Saved OT Team"
        public short SavedOTteam(string strScheduleid, string strDoctorsID, string entryby, int intversion, string strcompanyid,
                               string strlocationid, string strmachineid, string strdoctorsFtime, string strdoctorsTtime)
        {
            return new OPRSetupBLL().SavedOTteam(strScheduleid, strDoctorsID, entryby, intversion, strcompanyid, strlocationid, strmachineid,
                                        strdoctorsFtime, strdoctorsTtime);
        }
        #endregion
        #region "Dictionary 1"
        public Dictionary<string, string> LoadOTtheater()
        {
            return new OPRSetupBLL().LoadOTtheater();
        }
        #endregion
        #region "Display"
        public List<CalenderOT> DisplayOTScheduling(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayOTScheduling(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayOTSschedulingDoctors(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayOTSschedulingDoctors(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayOTPackage(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL() .DisplayOTPackage(strcontrol, strWhere);
        }
        #endregion
        #region "Get Incharge Bar"
        public List<CalenderOT> GetInchargeIDBar(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().GetInchargeIDBar(strcontrol, strWhere);
        }
        public List<OperationMaster> GetInchargeIDBarchart()
        {
            return new OPRSetupBLL().GetInchargeIDBarchart();
        }
        public List<CalenderOT> GetRowposofBarchat(string strcontrol, string strWhere, string strWhere1)
        {
            return new OPRSetupBLL().GetRowposofBarchat(strcontrol, strWhere, strWhere1);
        }
        #endregion
        #region "Display Ot"
        public List<CalenderOT> Displayotscheduling(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayOTScheduling(strcontrol, strWhere);
        }
        #endregion
        #region "Get Ot Scheduling"
        public List<CalenderOT> GetOTschedulingDetails(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().GetOTschedulingDetails(strcontrol, strWhere);
        }
        #endregion
        #region "Update Operation"
        public string UpdateOperationSchedulingMaster(CalenderOT objTran)
        {
            return new OPRSetupBLL().UpdateOperationSchedulingMaster(objTran);
        }
        #endregion
        #region "Display 2"
        public List<CalenderOT> DisplayDashBoard(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayDashBoard(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayHistory(string strWhere)
        {
            return new OPRSetupBLL().DisplayHistory(strWhere);
        }
        public List<CalenderOT> DisplayPatregistration(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayPatregistration(strcontrol, strWhere);
        }
        public  List<CalenderOT> DisplayDoctorsInformation(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayDoctorsInformation(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayPackageInformation(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayPackageInformation(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayInchargeInformation(string strcontrol, string strWhere)
        {
            return new OPRSetupBLL().DisplayInchargeInformation(strcontrol, strWhere);
        }
        #endregion
        #region "Update OT"
        public string UpdateOTstatus(string strSchedulueID, int intStatus, string hcnno, string Regno, string Depid,
                                             string Unit, double dblPackageAmount, CalenderOT objTran)
        {
            return new OPRSetupBLL().UpdateOTstatus(strSchedulueID, intStatus, hcnno, Regno, Depid, Unit, dblPackageAmount, objTran);
        }
        #endregion
        #region "Dictionary 3"
        public Dictionary<string, string> Getbedconfig(string Pcontrol)
        {
            return new OPRSetupBLL().Getbedconfig(Pcontrol);
        }
        #endregion
        #region  "Checklist"
        public short Savedchecklist(ChecklistItem objTran)
        {
            return new OPRSetupBLL().Savedchecklist(objTran);
        }
        public short Updatedchecklist(ChecklistItem objTran)
        {
            return new OPRSetupBLL().Updatedchecklist(objTran);
        }
        public short Deletechecklist(ChecklistItem objTran)
        {
            return new OPRSetupBLL().Deletechecklist(objTran);
        }
        #endregion
        #region "Getchecklist"
        public List<ChecklistItem> GetChekcList()
        {
            return new OPRSetupBLL().GetChekcList();
        }
        public List<ChecklistItem> GetCheklistOprtype(string strControlName, string strWhere)
        {
            return new OPRSetupBLL().GetCheklistOprtype(strControlName, strWhere);
        }
        public Dictionary<string, string> GetCheklistRegNo(string Pcontrol)
        {
            return new OPRSetupBLL().GetCheklistRegNo(Pcontrol);
        }
        public List<ChecklistItem> GetRegNotoChecklist(string strControlName, string strWhere)
        {
            return new OPRSetupBLL().GetRegNotoChecklist(strControlName, strWhere);
        }
        #endregion
        #region "Saved Checklist Config."
        public string SavedChecklistConfigMaster(ChecklistItem objTran)
        {
            return new OPRSetupBLL().SavedChecklistConfigMaster(objTran);
        }
        public short SavedChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran)
        {
            return new OPRSetupBLL().SavedChecklistConfigChild(strRefNo, stritemcode, intYes, intNo, strComments, objTran);
        }
        #endregion
        #region "Load Checklist"
        public List<ChecklistItem> LoadCheckList(string strControlName)
       {
           return new OPRSetupBLL().LoadCheckList(strControlName);
       }
        #endregion
        #region "Display Checklist"
        public List<ChecklistItem> DisplayChecklistfromChecklistNo(string strControlName, string strWhere)
       {
           return new OPRSetupBLL().DisplayChecklistfromChecklistNo(strControlName, strWhere);
       }
        #endregion
        #region "Update Checklist Master"
        public short UpdateChecklistConfigMaster(ChecklistItem objTran)
       {
           return new OPRSetupBLL().UpdateChecklistConfigMaster(objTran);
       }
        public short UpdateChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran)
       {
           return new OPRSetupBLL().UpdateChecklistConfigChild(strRefNo, stritemcode, intYes, intNo, strComments, objTran);
       }
        #endregion
        #region "Saved Operation "
        public short SavedOperationInfo(OperationMaster objTran)
       {
           return new OPRSetupBLL().SavedOperationInfo(objTran);
       }
        public short UpdatOperationInfo(OperationMaster objTran)
       {
           return new OPRSetupBLL().UpdatOperationInfo(objTran);
       }
        public short DeleteOperationInfo(string strrOprID, OperationMaster objTran)
       {
           return new OPRSetupBLL().DeleteOperationInfo(strrOprID, objTran);
       }
        #endregion
        #region "Operation Info."
        public List<OperationMaster> GetoperationInformation()
       {
           return new OPRSetupBLL().GetoperationInformation();
       }
        #endregion
        #region "Dictionary 2"
        public Dictionary<string, string> GetOTnameFromOTtype(string strWhere)
       {
           return new OPRSetupBLL().GetOTnameFromOTtype(strWhere);
       }
        #endregion
        #region "Saved operation Type"
        public short SaveOperationType(OperationType ot)
       {
           return new OPRSetupBLL().SaveOperationType(ot);
       }
        public short UpdateOperation(OperationType upot)
       {
           return new OPRSetupBLL().UpdateOperation(upot);
       }
        #endregion
        #region "Varify Operation"
        public int VerifyOperation(string typeid)
       {
           return new OPRSetupBLL().VerifyOperation(typeid);
       }
        #endregion
        #region "Get Operation Config"
        public List<OperationType> GetOperationConfig()
       {
           return new OPRSetupBLL().GetOperationConfig();
       }
        #endregion
        #region "Get Registration Details"
        public InPatient GetAdmittedPatient(string RegistrationNo)
       {
           //return new IPDSharedBLL().GetPatreg(RegistrationNo);
           return new IPDSharedBLL().GetAdmittedPatient(RegistrationNo);
       }
        public List<CalenderOT> GetRegDetailsFromOperarion(string strControl, string Where)
       {
           return new OPRSetupBLL().GetRegDetailsFromOperarion(strControl, Where);
       }
        public List<CalenderOT> GetDoctorsAvaiable(string strControl, string Fdate, string Tdate)
       {
           return new OPRSetupBLL().GetDoctorsAvaiable(strControl, Fdate, Tdate);

       }
        public List<OperationDetailsRO> GetOprDetailsReport(int Where, string Fdate, string Tdate)
       {
           return new OPRSetupBLL().GetOprDetailsReport(Where, Fdate, Tdate);
       }
        #endregion


        public short SavePackageOprMaster(PackageItem PI)
        {
            return new OPRSetupBLL().SavePackageOprMaster(PI);
        }
        public short UpdatePackageOprMaster(PackageItem PI)
        {
            return new OPRSetupBLL().UpdatePackageOprMaster(PI);
        }

        public List<PackageItem> GetPackageMaster()
        {
            return new OPRSetupBLL().GetPackageMaster();
        }


        public List<DepartmentUnit> GetUnits()
        {
            return new AdministrationSetupBLL().GetUnits();
        }
        public List<PackageItem> GetOprSubItem()
        {
            return new OPRSetupBLL().GetOprSubItem();
        }

        public List<PackageItem> GetPackageItemConfig()
        {
            return new OPRSetupBLL().GetPackageItemConfig();
        }

        public bool GetOperationStatus(string strRegNo)
        {
            return new OPRSetupBLL().GetOperationStatus(strRegNo);
        }


    }
}
