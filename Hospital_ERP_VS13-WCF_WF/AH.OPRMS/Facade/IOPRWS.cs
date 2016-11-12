using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using AH.OPRMS.MODEL;
using AH.IPDShared.MODEL;
using System.Text;
using AH.IPDShared.BLL;
using AH.Shared.MODEL;

namespace AH.OPRMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOPRWS" in both code and config file together.
    [ServiceContract]
    public interface IOPRWS
    {
        [OperationContract]
        short SaveGradeSetup(Grade grd);
        [OperationContract]
        List<Grade> GetGrade();
        [OperationContract]
        short UpdateGradeSetup(Grade objTran);
        [OperationContract]
        short DeleteGrade(Grade objTran);
        [OperationContract]
        short SavetheaterSetup(Theater objTran);
        [OperationContract]
        short UpdatetheaterSetup(Theater objTran);
        [OperationContract]
        short Deletetheater(Theater objTran);
        [OperationContract]
        List<Theater> GetTheater();
        [OperationContract]
        short SaveAnesSetup(AnesthesiaGroup objTran);
        [OperationContract]
        short UpdateAnesSetup(AnesthesiaGroup objTran);
        [OperationContract]
        short DeleteAnesGroup(AnesthesiaGroup objTran);
        [OperationContract]
        List<AnesthesiaGroup> GetTAnesthesia();
        [OperationContract]
        Dictionary<string, string> GetAnesthesiaGroups(string type);
        [OperationContract]
        short SaveAnesSetupMaster(AnesthesiaMaster objTran);
        [OperationContract]
        short UpdateAnesSetupMaster(AnesthesiaMaster objTran);
        [OperationContract]
        List<AnesthesiaMaster> GetAnesthesiaMaster();
        [OperationContract]
        short DeleteAnesMaster(AnesthesiaMaster objTran);
        [OperationContract]
        Dictionary<string, string> GetOperationType(string type);
        [OperationContract]
        Dictionary<string, string> LoadGrade(string type);
        [OperationContract]
        Dictionary<string, string> LoadAnesthesiaID(string type);
        [OperationContract]
        short SaveOperationSetup(OperationMaster objTran);
        [OperationContract]
        short UpdateOperationSetup(OperationMaster objTran);
        [OperationContract]
        List<OperationMaster> LoadOperationMaster();
        [OperationContract]
        Dictionary<string, string> GetDepID(string type);
        [OperationContract]
        Dictionary<string, string> GetTheaterBed(string type);
        [OperationContract]
        Dictionary<string, string> GetRegID(string type);
        [OperationContract]
        Dictionary<string, string> GetRoomIdFromTheater(string type, string where);
        [OperationContract]
        Dictionary<string, string> GetDoctorsCategory(string strcontrol, string strWhere);
        [OperationContract]
        short SavedDoctotsCategory(DoctorsCategory objTran);
        [OperationContract]
        short SavedDoctotsCategoryMaster(DoctorsCategory objTran);
        [OperationContract]
        List<DoctorsCategory> DisplayDoctorsCategory(string strcontrol, string strWhere);
        [OperationContract]
        Dictionary<string, string> GetDoctorsAssign(string strcontrol, string strWhere);
        [OperationContract]
        short SavedPackagedItem(PackageItem objTran);
        [OperationContract]
        short UpdatePackagedItem(PackageItem objTran);
        [OperationContract]
        List<PackageItem> GetPackageItem(string strcontrol, string strWhere);
        [OperationContract]
        string  SavedPackageMaster(PackageItem objTran);
        [OperationContract]
        short SavedPackageChild(PackageItem objTran);
        [OperationContract]
        List<PackageItem> GetPackage(string strcontrol, string strWhere);
        [OperationContract]
        List<PackageItem> DisplayPackage(string strcontrol, string strWhere);
        [OperationContract]
        short UpdatePackageMaster(PackageItem objTran);
        [OperationContract]
        short UpdatePackageChild(PackageItem objTran);
        [OperationContract]
        List<DoctorsCategory> DispalyTeamAssign(string strcontrol, string strWhere);
        [OperationContract]
        Dictionary<string, string> GetRegScheduling();
        [OperationContract]
        Dictionary<string, string> GetInchargeID();
        [OperationContract]
        Dictionary<string, string> GetPacageInformation();
        [OperationContract]
        string  SavedOperationSchedulingMaster(CalenderOT objTran);
        [OperationContract]
        short SavedOperationSchedulingChild(string strScheduleid, string stRegDate,
                                                int intRow, int intCol, string strTheaterid,
                                                string strTimesSlot, string entryby, int intversion, string strcompanyid, string strlocationid, string strmachineid);
        [OperationContract]
        //short SavedOTteam(string strScheduleid, string strDoctorsID, string entryby, int intversion, string strcompanyid, string strlocationid, string strmachineid);
        short SavedOTteam(string strScheduleid, string strDoctorsID, string entryby, int intversion, string strcompanyid,
                               string strlocationid, string strmachineid, string strdoctorsFtime, string strdoctorsTtime);

        [OperationContract]
        Dictionary<string, string> LoadOTtheater();
        [OperationContract]
        List<CalenderOT> DisplayOTScheduling(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayOTSschedulingDoctors(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayOTPackage(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> GetInchargeIDBar(string strcontrol, string strWhere);
        [OperationContract]
        List<OperationMaster> GetInchargeIDBarchart();
        [OperationContract]
        List<CalenderOT> GetRowposofBarchat(string strcontrol, string strWhere, string strWhere1);
        [OperationContract]
        List<CalenderOT> Displayotscheduling(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> GetOTschedulingDetails(string strcontrol, string strWhere);
        [OperationContract]
        string UpdateOperationSchedulingMaster(CalenderOT objTran);
        [OperationContract]
        List<CalenderOT> DisplayDashBoard(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayHistory(string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayPatregistration(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayDoctorsInformation(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayPackageInformation(string strcontrol, string strWhere);
        [OperationContract]
        List<CalenderOT> DisplayInchargeInformation(string strcontrol, string strWhere);
        [OperationContract]
        //string UpdateOTstatus(string strSchedulueID, int intStatus, CalenderOT objTran);
        string UpdateOTstatus(string strSchedulueID, int intStatus, string hcnno, string Regno, string Depid,
                                             string Unit, double dblPackageAmount, CalenderOT objTran);
        [OperationContract]
        Dictionary<string, string> Getbedconfig(string Pcontrol);
        [OperationContract]
        short Savedchecklist(ChecklistItem objTran);
        [OperationContract]
        short Updatedchecklist(ChecklistItem objTran);
        [OperationContract]
        short Deletechecklist(ChecklistItem objTran);
        [OperationContract]
        List<ChecklistItem> GetChekcList();
        [OperationContract]
        List<ChecklistItem> GetCheklistOprtype(string strControlName, string strWhere);
        [OperationContract]
        Dictionary<string, string> GetCheklistRegNo(string Pcontrol);
        [OperationContract]
        List<ChecklistItem> GetRegNotoChecklist(string strControlName, string strWhere);
        [OperationContract]
        string SavedChecklistConfigMaster(ChecklistItem objTran);
        [OperationContract]
        short SavedChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran);
        [OperationContract]
        List<ChecklistItem> LoadCheckList(string strControlName);
        [OperationContract]
        List<ChecklistItem> DisplayChecklistfromChecklistNo(string strControlName, string strWhere);
        [OperationContract]
        short UpdateChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran);
        [OperationContract]
        short UpdateChecklistConfigMaster(ChecklistItem objTran);
        [OperationContract]
        short SavedOperationInfo(OperationMaster objTran);
        [OperationContract]
        short UpdatOperationInfo(OperationMaster objTran);
        [OperationContract]
        short DeleteOperationInfo(string strrOprID, OperationMaster objTran);
        [OperationContract]
        List<OperationMaster> GetoperationInformation();
        [OperationContract]
        Dictionary<string, string> GetOTnameFromOTtype(string strWhere);
        [OperationContract]
        short SaveOperationType(OperationType ot);
        [OperationContract]
        short UpdateOperation(OperationType upot);
        [OperationContract]
        int VerifyOperation(string typeid);
        [OperationContract]
        List<OperationType> GetOperationConfig();
        [OperationContract]
        InPatient GetAdmittedPatient(string RegistrationNo);
        [OperationContract]
        List<CalenderOT> GetRegDetailsFromOperarion(string strControl, string Where);
        [OperationContract]
        List<CalenderOT> GetDoctorsAvaiable(string strControl, string Fdate, string Tdate);
        [OperationContract]
        List<OperationDetailsRO> GetOprDetailsReport(int Where, string Fdate, string Tdate);

        [OperationContract]
        short SavePackageOprMaster(PackageItem PI);
        [OperationContract]
        short UpdatePackageOprMaster(PackageItem PI);
        [OperationContract]
        List<PackageItem> GetPackageMaster();
        [OperationContract]
        List<DepartmentUnit> GetUnits();
        [OperationContract]
        List<PackageItem> GetOprSubItem();
        [OperationContract]
        List<PackageItem> GetPackageItemConfig();

        [OperationContract]
        bool GetOperationStatus(string strRegNo);

    }
}
