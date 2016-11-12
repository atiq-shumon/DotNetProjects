using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OPRMS.MODEL;
using AH.OPRMS.DAL;
namespace AH.OPRMS.BLL
{
    public class OPRSetupBLL
    {
        #region"Grade"
        public short SaveGradeSetup(Grade grd)
        {
            return new OPRSetupDAL().SaveGradeSetup(grd);
        }
        public List<Grade> GetGrade()
        {
            return new OPRCollectionSummary().GetGrade();
        }
        public short UpdateGradeSetup(Grade objTran)
        {
            return new OPRSetupDAL().UpdateGradeSetup(objTran);
        }
        public short DeleteGrade(Grade objTran)
        {
            return new OPRSetupDAL().DeleteGrade(objTran);
        }
        #endregion
        #region "Theater"
        public short SavetheaterSetup(Theater objTran)
        {
            return new OPRSetupDAL().SavetheaterSetup(objTran);
        }
        public short UpdatetheaterSetup(Theater objTran)
        {
            return new OPRSetupDAL().UpdatetheaterSetup(objTran);
        }
        public short Deletetheater(Theater objTran)
        {
            return new OPRSetupDAL().Deletetheater(objTran);
        }
        public List<Theater> GetTheater()
        {
            return new OPRCollectionSummary().GetTheater();
        }
        #endregion
        #region "Anes Group"
        public short SaveAnesSetup(AnesthesiaGroup objTran)
        {
            return new OPRSetupDAL().SaveAnesSetup(objTran);
        }
        public short UpdateAnesSetup(AnesthesiaGroup objTran)
        {
            return new OPRSetupDAL().UpdateAnesSetup(objTran);
        }
        public short DeleteAnesGroup(AnesthesiaGroup objTran)
        {
            return new OPRSetupDAL().DeleteAnesGroup(objTran);
        }
        public List<AnesthesiaGroup> GetTAnesthesia()
        {
            return new OPRCollectionSummary().GetTAnesthesia();
        }


        public Dictionary<string, string> GetAnesthesiaGroups(string type)
        {
            Dictionary<string, string> Anesthesia = new Dictionary<string, string>();
            foreach (AnesthesiaMaster anes in new OPRCollectionSummary().GetAnesthesiaGroup())
            {
                Anesthesia.Add(anes.GroupID, anes.Anesthesiatitle);
            }
            return Anesthesia;
        }
        public short SaveAnesSetupMaster(AnesthesiaMaster objTran)
        {
            return new OPRSetupDAL().SaveAnesSetupMaster(objTran);
        }
        public short UpdateAnesSetupMaster(AnesthesiaMaster objTran)
        {
            return new OPRSetupDAL().UpdateAnesSetupMaster(objTran);
        }
        public List<AnesthesiaMaster> GetAnesthesiaMaster()
        {
            return new OPRCollectionSummary().GetAnesthesiaMaster();
        }
        public short DeleteAnesMaster(AnesthesiaMaster objTran)
        {
            return new OPRSetupDAL().DeleteAnesMaster(objTran);
        }
        #endregion
        public Dictionary<string, string> OperationType(string type)
        {
            Dictionary<string, string> oprType = new Dictionary<string, string>();
            foreach (OperationType opr in new OPRCollectionSummary().GetOperationType())
            {
                oprType.Add(opr.ID, opr.Title);
            }
            return oprType;
        }
        #region "grade"
        public Dictionary<string, string> LoadGrade(string type)
        {
            Dictionary<string, string> grade = new Dictionary<string, string>();
            foreach (Grade gra in new OPRCollectionSummary().LoadGrade())
            {
                grade.Add(gra.GradeId, gra.GradeTitle);
            }
            return grade;
        }
        #endregion
        public Dictionary<string, string> LoadAnesthesiaID(string type)
        {
            Dictionary<string, string> Anesthesia = new Dictionary<string, string>();
            foreach (AnesthesiaMaster anes in new OPRCollectionSummary().LoadAnesthesiaID())
            {
                Anesthesia.Add(anes.Anesesthesia, anes.Anesthesiatitle);
            }
            return Anesthesia;
        }
        #region Operation setup
        public short SaveOperationSetup(OperationMaster objTran)
        {
            return new OPRSetupDAL().SaveOperationSetup(objTran);
        }
        public short UpdateOperationSetup(OperationMaster objTran)
        {
            return new OPRSetupDAL().UpdateOperationSetup(objTran);
        }
        public List<OperationMaster> LoadOperationMaster()
        {
            return new OPRCollectionSummary().LoadOperationMaster();
        }
        #endregion
        #region "Dictionary 3"
        public Dictionary<string, string> GetDepID(string type)
        {
            Dictionary<string, string> objTheater = new Dictionary<string, string>();
            foreach (Theater theater in new OPRCollectionSummary().GetDepID(type))
            {
                objTheater.Add(theater.DepId, theater.DepName);
            }
            return objTheater;
        }
        public Dictionary<string, string> GetTheaterBed(string type)
        {
            Dictionary<string, string> objBed = new Dictionary<string, string>();
            foreach (BedConfiguration bedconfig in new OPRCollectionSummary().GetTheaterBed(type))
            {
                objBed.Add(bedconfig.theaterID, bedconfig.theaterTitle);
            }
            return objBed;
        }
        public Dictionary<string, string> GetRegID(string type)
        {
            Dictionary<string, string> objBed = new Dictionary<string, string>();
            foreach (BedConfiguration bedconfig in new OPRCollectionSummary().GetRegID(type))
            {
                objBed.Add(bedconfig.RegID, bedconfig.RegID);
            }
            return objBed;
        }
        public Dictionary<string, string> GetRoomIdFromTheater(string type, string where)
        {
            Dictionary<string, string> objBed = new Dictionary<string, string>();
            foreach (BedConfiguration bedconfig in new OPRCollectionSummary().GetRoomIdFromTheater(type, where))
            {
                objBed.Add(bedconfig.RegID, bedconfig.RegID);
            }
            return objBed;
        }
        public Dictionary<string, string> GetDoctorsCategory(string strcontrol, string strWhere)
        {
            Dictionary<string, string> objCatategory = new Dictionary<string, string>();
            foreach (DoctorsCategory objCat in new OPRCollectionSummary().GetDoctorsCategory(strcontrol, strWhere))
            {
                objCatategory.Add(objCat.doctorscode, objCat.doctorsName);
            }
            return objCatategory;
        }
        #endregion
        #region "Category"
        public short SavedDoctotsCategory(DoctorsCategory objTran)
        {
            return new OPRSetupDAL().SavedDoctotsCategory(objTran);
        }
        public short SavedDoctotsCategoryMaster(DoctorsCategory objTran)
        {
            return new OPRSetupDAL().SavedDoctotsCategoryMaster(objTran);
        }
        public List<DoctorsCategory> DisplayDoctorsCategory(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayDoctorsCategory(strcontrol, strWhere);
        }
        #endregion
        #region "Dictionary 4"
        public Dictionary<string, string> GetDoctorsAssign(string strcontrol, string strWhere)
        {
            Dictionary<string, string> objCat = new Dictionary<string, string>();
            foreach (DoctorsCategory cat in new OPRCollectionSummary().GetDoctorsAssign(strcontrol, strWhere))
            {
                objCat.Add(cat.doctorscode, cat.doctorsName);
            }
            return objCat;
        }
        #endregion
        #region "Package Cofig"
        public short SavedPackagedItem(PackageItem objTran)
        {
            return new OPRSetupDAL().SavedPackagedItem(objTran);
        }
        public short UpdatePackagedItem(PackageItem objTran)
        {
            return new OPRSetupDAL().UpdatePackagedItem(objTran);
        }
        #endregion
        #region "Get Package Item"
        public List<PackageItem> GetPackageItem(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().GetPackageItem(strcontrol, strWhere);
        }
        #endregion
        #region "Package Config"
        public string SavedPackageMaster(PackageItem objTran)
        {
            return new OPRSetupDAL().SavedPackageMaster(objTran);
        }
        public short SavedPackageChild(PackageItem objTran)
        {
            return new OPRSetupDAL().SavedPackageChild(objTran);
        }
        public List<PackageItem> GetPackage(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().GetPackage(strcontrol, strWhere);
        }

        public short UpdatePackageMaster(PackageItem objTran)
        {
            return new OPRSetupDAL().UpdatePackageMaster(objTran);
        }
        public short UpdatePackageChild(PackageItem objTran)
        {
            return new OPRSetupDAL().UpdatePackageChild(objTran);
        }

        #endregion
        #region "Display1"
        public List<PackageItem> DisplayPackage(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayPackage(strcontrol, strWhere);
        }
        public List<DoctorsCategory> DispalyTeamAssign(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DispalyTeamAssign(strcontrol, strWhere);
        }
        #endregion
        #region "Dictionary1"
        public Dictionary<string, string> GetRegScheduling()
        {
            Dictionary<string, string> objSchedule = new Dictionary<string, string>();
            foreach (OperationMaster Sche in new OPRCollectionSummary().GetSheduleRegID())
            {
                objSchedule.Add(Sche.RegId, Sche.RegName);
            }
            return objSchedule;
        }
        public Dictionary<string, string> GetInchargeID()
        {
            Dictionary<string, string> objSchedule = new Dictionary<string, string>();
            foreach (OperationMaster Sche in new OPRCollectionSummary().GetInchargeID())
            {
                objSchedule.Add(Sche.RegId, Sche.RegName);
            }
            return objSchedule;
        }
        public Dictionary<string, string> GetPacageInformation()
        {
            Dictionary<string, string> objSchedule = new Dictionary<string, string>();
            foreach (OperationMaster Sche in new OPRCollectionSummary().GetPacageInformation())
            {
                objSchedule.Add(Sche.PackageNo, Sche.PackageName);
            }
            return objSchedule;
        }
        #endregion
        #region "Saved Operation"
        public string SavedOperationSchedulingMaster(CalenderOT objTran)
        {
            return new OPRSetupDAL().SavedOperationSchedulingMaster(objTran);
        }
        public short SavedOperationSchedulingChild(string strScheduleid, string stRegDate,
                                                  int intRow, int intCol, string strTheaterid,
                                                  string strTimesSlot, string entryby, int intversion, string strcompanyid, string strlocationid, string strmachineid)
        {
            return new OPRSetupDAL().SavedOperationSchedulingChild(strScheduleid, stRegDate, intRow, intCol, strTheaterid, strTimesSlot, entryby, intversion, strcompanyid, strlocationid, strmachineid);
        }
        public short SavedOTteam(string strScheduleid, string strDoctorsID, string entryby, int intversion, string strcompanyid,
                                string strlocationid, string strmachineid, string strdoctorsFtime, string strdoctorsTtime)
        {
            return new OPRSetupDAL().SavedOTteam(strScheduleid, strDoctorsID, entryby, intversion, strcompanyid,
                                strlocationid, strmachineid, strdoctorsFtime, strdoctorsTtime);
        }
        #endregion
        #region "Dictionary2"
        public Dictionary<string, string> LoadOTtheater()
        {
            Dictionary<string, string> objSchedule = new Dictionary<string, string>();
            foreach (Theater Sche in new OPRCollectionSummary().LoadOTtheater())
            {
                objSchedule.Add(Sche.Theaterid, Sche.Theatertitle);
            }
            return objSchedule;
        }
        #endregion
        #region "Display2"
        public List<CalenderOT> DisplayOTScheduling(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayOTScheduling(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayOTSschedulingDoctors(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayOTSschedulingDoctors(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayOTPackage(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayOTPackage(strcontrol, strWhere);
        }
        #endregion
        #region "Get Incharge"
        public List<CalenderOT> GetInchargeIDBar(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().GetInchargeIDBar(strcontrol, strWhere);
        }
        public List<OperationMaster> GetInchargeIDBarchart()
        {
            return new OPRCollectionSummary().GetInchargeIDBarchart();
        }
        #endregion 
        #region "Get Row bar Chart"
        public List<CalenderOT> GetRowposofBarchat(string strcontrol, string strWhere, string strWhere1)
        {
            return new OPRCollectionSummary().GetRowposofBarchat(strcontrol, strWhere, strWhere1);
        }
        #endregion
        #region "Display 3"
        public List<CalenderOT> Displayotscheduling(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayOTScheduling(strcontrol, strWhere);
        }
        #endregion
        #region "Get OT Schedulue"
        public List<CalenderOT> GetOTschedulingDetails(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().GetOTschedulingDetails(strcontrol, strWhere);
        }
        #endregion
        #region "Update Operation"
        public string UpdateOperationSchedulingMaster(CalenderOT objTran)
        {
            return new OPRSetupDAL().UpdateOperationSchedulingMaster(objTran);
        }
        #endregion
        #region "Display 4"
        public List<CalenderOT> DisplayDashBoard(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayDashBoard(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayHistory(string strWhere)
        {
            return new OPRCollectionSummary().DisplayHistory(strWhere);
        }
        public List<CalenderOT> DisplayPatregistration(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayPatregistration(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayDoctorsInformation(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayDoctorsInformation(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayPackageInformation(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayPackageInformation(strcontrol, strWhere);
        }
        public List<CalenderOT> DisplayInchargeInformation(string strcontrol, string strWhere)
        {
            return new OPRCollectionSummary().DisplayInchargeInformation(strcontrol, strWhere);
        }
        #endregion
        #region "Update OT"
        public string UpdateOTstatus(string strSchedulueID, int intStatus, string hcnno, string Regno, string Depid,
                                            string Unit, double dblPackageAmount, CalenderOT objTran)
        {
            return new OPRSetupDAL().UpdateOTstatus(strSchedulueID, intStatus, hcnno, Regno, Depid, Unit, dblPackageAmount, objTran);
        }
        #endregion
        #region "Dictionary 4"
        public Dictionary<string, string> Getbedconfig(string Pcontrol)
        {
            Dictionary<string, string> objbed = new Dictionary<string, string>();
            foreach (BedConfiguration bed in new OPRCollectionSummary().Getbedconfig(Pcontrol))
            {
                objbed.Add(bed.BedID, bed.BedTitle);
            }
            return objbed;
        }
        #endregion
        #region "Checklist Info."
        public short Savedchecklist(ChecklistItem objTran)
        {
            return new OPRSetupDAL().Savedchecklist(objTran);
        }
        public short Updatedchecklist(ChecklistItem objTran)
        {
            return new OPRSetupDAL().Updatedchecklist(objTran);
        }
        public short Deletechecklist(ChecklistItem objTran)
        {
            return new OPRSetupDAL().Deletechecklist(objTran);
        }
        public List<ChecklistItem> GetChekcList()
        {
            return new OPRCollectionSummary().GetChekcList();
        }
        public List<ChecklistItem> GetCheklistOprtype(string strControlName, string strWhere)
        {
            return new OPRCollectionSummary().GetCheklistOprtype(strControlName, strWhere);
        }

        public Dictionary<string, string> GetCheklistRegNo(string Pcontrol)
        {
            Dictionary<string, string> objchk = new Dictionary<string, string>();
            foreach (ChecklistItem chklist in new OPRCollectionSummary().GetCheklistRegNo(Pcontrol))
            {
                objchk.Add(chklist.RegNo, chklist.PatientName);
            }
            return objchk;
        }
        public List<ChecklistItem> GetRegNotoChecklist(string strControlName, string strWhere)
        {
            return new OPRCollectionSummary().GetRegNotoChecklist(strControlName, strWhere);
        }
        #endregion 
        #region "Check list Config. "
        public string SavedChecklistConfigMaster(ChecklistItem objTran)
        {
            return new OPRSetupDAL().SavedChecklistConfigMaster(objTran);
        }
        public short SavedChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran)
        {
            return new OPRSetupDAL().SavedChecklistConfigChild(strRefNo, stritemcode, intYes, intNo, strComments, objTran);
        }
        public List<ChecklistItem> LoadCheckList(string strControlName)
        {
            return new OPRCollectionSummary().LoadCheckList(strControlName);
        }
        public List<ChecklistItem> DisplayChecklistfromChecklistNo(string strControlName, string strWhere)
        {
            return new OPRCollectionSummary().DisplayChecklistfromChecklistNo(strControlName, strWhere);
        }
        public short UpdateChecklistConfigMaster(ChecklistItem objTran)
        {
            return new OPRSetupDAL().UpdateChecklistConfigMaster(objTran);
        }
        public short UpdateChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran)
        {
            return new OPRSetupDAL().UpdateChecklistConfigChild(strRefNo, stritemcode, intYes, intNo, strComments, objTran);
        }
        #endregion
        #region "Operation Info."
        public short SavedOperationInfo(OperationMaster objTran)
        {
            return new OPRSetupDAL().SavedOperationInfo(objTran);
        }
        public short UpdatOperationInfo(OperationMaster objTran)
        {
            return new OPRSetupDAL().UpdatOperationInfo(objTran);
        }
        public short DeleteOperationInfo(string strrOprID, OperationMaster objTran)
        {
            return new OPRSetupDAL().DeleteOperationInfo(strrOprID, objTran);
        }
        public List<OperationMaster> GetoperationInformation()
        {
            return new OPRCollectionSummary().GetoperationInformation();
        }
        public Dictionary<string, string> GetOTnameFromOTtype(string strWhere)
        {
            Dictionary<string, string> objCal = new Dictionary<string, string>();
            foreach (CalenderOT cal in new OPRCollectionSummary().GetOTnameFromOTtype(strWhere))
            {
                objCal.Add(cal.OprID, cal.OprName);
            }
            return objCal;
        }
        public short SaveOperationType(OperationType ot)
        {
            return new OPRSetupDAL().SaveOperationType(ot);
        }
        public short UpdateOperation(OperationType upot)
        {
            return new OPRSetupDAL().UpdateOperation(upot);
        }
        #endregion
        #region "verifyOperation"
        public int VerifyOperation(string typeid)
        {
            return new OPRSetupDAL().VerifyOperation(typeid);
        }
        #endregion
        #region "Get Operation Details"
        public List<OperationType> GetOperationConfig()
        {
            return new OPRCollectionSummary().GetOperationConfig();
        }
        public List<CalenderOT> GetRegDetailsFromOperarion(string strControl, string Where)
        {
            return new OPRCollectionSummary().GetRegDetailsFromOperarion(strControl, Where);
        }
        public List<CalenderOT> GetDoctorsAvaiable(string strControl, string Fdate, string Tdate)
        {
            return new OPRCollectionSummary().GetDoctorsAvaiable(strControl, Fdate, Tdate);
        }
        public List<OperationDetailsRO> GetOprDetailsReport(int Where, string Fdate, string Tdate)
        {
            return new OPRCollectionSummary().GetOprDetailsReport(Where, Fdate, Tdate);
        }
        #endregion

        public short SavePackageOprMaster(PackageItem PI)
        {
            return new OPRSetupDAL().SavePackageOprMaster(PI);
        }
        public short UpdatePackageOprMaster(PackageItem PI)
        {
            return new OPRSetupDAL().UpdatePackageOprMaster(PI);
        }

        public List<PackageItem> GetPackageMaster()
        {
            return new OPRSetupDAL().GetPackageMaster();
        }

        public List<PackageItem> GetOprSubItem()
        {
            return new OPRSetupDAL().GetOprSubItem();
        }
        public List<PackageItem> GetPackageItemConfig()
        {
            return new OPRSetupDAL().GetPackageItemConfig();
        }

        public bool GetOperationStatus(string strRegNo)
        {
            return new OPRSetupDAL().GetOperationStatus(strRegNo);
        }


    }
}
