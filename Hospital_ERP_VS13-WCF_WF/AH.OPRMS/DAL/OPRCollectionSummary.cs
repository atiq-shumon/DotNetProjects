using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OPRMS.MODEL;
using AH.DUtility;
using AH.OracleManager;


namespace AH.OPRMS.DAL
{
    public class OPRCollectionSummary
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;
       #region "Dal"

        public List<Grade> GetGrade()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"Grade",ParameterDirection.Input),
            };
            return GetGradeSet(packageName, parameterList);
        }
        private List<Grade> GetGradeSet(string packageName, OracleParameter[] parameterList)
        {
            List<Grade> bran = new List<Grade>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Grade grade = new Grade();
                grade.GradeId = (string)rdr["grade_id"];
                grade.GradeTitle = (string)rdr["grade_title"];
                grade.Active = (string)rdr["active"];
                grade.Remarks = rdr["remarks"].ToString() ;
                bran.Add(grade);
            }
            rdr.Close();
            return bran;
        }
        public List<Theater> GetTheater()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"Theater",ParameterDirection.Input),
            };
            return GetTheater(packageName, parameterList);
        }
        private List<Theater> GetTheater(string packageName, OracleParameter[] parameterList)
        {
            List<Theater> bran = new List<Theater>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                long lngNoofFacilities;
                Theater theater = new Theater();
                theater.Buildid = (string)rdr["BUILD_ID"];
                theater.FloorNo = (string)rdr["FLOOR_NO"];
                theater.BlockNo = (string)rdr["BLOCK_NO"];
                theater.Theaterid = (string)rdr["THEATER_ID"];
                if (rdr["THEATRE_TITLE"].ToString() != "")
                {
                     theater.Theatertitle = (string)rdr["THEATRE_TITLE"];
                }
                lngNoofFacilities =  Convert.ToInt64( rdr["NO_OF_FACILITIES"]);
                theater.NoofFacilities = lngNoofFacilities;
                if (rdr["PHONE_NO"].ToString() != "")
                {
                    theater.PhoneNo = (string)rdr["PHONE_NO"];
                }
                if (rdr["IN_CHARGE_ID"].ToString() != "")
                {
                    theater.Inchargeid = (string)rdr["IN_CHARGE_ID"];
                }
                if (rdr["REMARKS"].ToString() != "")
                {
                    theater.Remarks = (string)rdr["REMARKS"];
                }
                theater.Active  = (string)rdr["active"];
                theater.DepSpe = rdr["IS_DEPT_SPEC"].ToString();
                theater.DepId = rdr["DEPT_ID"].ToString();
                theater.RoomId = rdr["ROOM_ID"].ToString();

                bran.Add(theater);
            }
            rdr.Close();
            return bran;
        }
        #region "Anesthesia Load"
        public List<AnesthesiaGroup> GetTAnesthesia()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"AnesGroup",ParameterDirection.Input),
            };
            return GetAnesthesia(packageName, parameterList);
        }
        private List<AnesthesiaGroup> GetAnesthesia(string packageName, OracleParameter[] parameterList)
        {
            List<AnesthesiaGroup> bran = new List<AnesthesiaGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AnesthesiaGroup anesthesia = new AnesthesiaGroup();
                anesthesia.AnesGroupID = (string)rdr["GROUP_ID"];
                anesthesia.AnesGroupTitle = (string)rdr["GROUP_TITLE"];
                anesthesia.AnesRemarks = (string)rdr["REMARKS"];
                anesthesia.Active = (string)rdr["ACTIVE"];
                bran.Add(anesthesia);
            }
            rdr.Close();
            return bran;
        }
        public List<AnesthesiaMaster> GetAnesthesiaGroup()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"GetAnesGroup",ParameterDirection.Input),
            };
            return GetAnesthesiaGroup(packageName, parameterList);
        }
        private List<AnesthesiaMaster> GetAnesthesiaGroup(string packageName, OracleParameter[] parameterList)
        {
            List<AnesthesiaMaster> bran = new List<AnesthesiaMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AnesthesiaMaster anesthesia = new AnesthesiaMaster();
                anesthesia.GroupID = (string)rdr["group_id"];
                if (rdr["group_title"].ToString() != "")
                {
                    anesthesia.Anesthesiatitle = (string)rdr["group_title"];
                }
                bran.Add(anesthesia);
            }
            rdr.Close();
            return bran;
        }
        public List<AnesthesiaMaster> GetAnesthesiaMaster()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"GetAnesMaster",ParameterDirection.Input),
            };
            return GetAnesthesiaMaster(packageName, parameterList);
        }
        private List<AnesthesiaMaster> GetAnesthesiaMaster(string packageName, OracleParameter[] parameterList)
        {
            List<AnesthesiaMaster> bran = new List<AnesthesiaMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AnesthesiaMaster anesthesia = new AnesthesiaMaster();
                anesthesia.Anesesthesia  = (string)rdr["ANESTHESIA_ID"];
                anesthesia.GroupID = (string)rdr["GRP_ID"];
                anesthesia.Anesthesiatitle = (string)rdr["ANESTHESIA_TITLE"];
                if (rdr["REMARKS"].ToString() != "")
                {
                    anesthesia.Remarks = (string)rdr["REMARKS"];
                }
                anesthesia.Active = (string)rdr["ACTIVE"];
                bran.Add(anesthesia);
            }
            rdr.Close();
            return bran;
        }
        #endregion
        //New
        #region "Operation type"
        public List<OperationType> GetOperationType()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"GetOperationType",ParameterDirection.Input),
            };
            return GetOperationType(packageName, parameterList);
        }
        private List<OperationType> GetOperationType(string packageName, OracleParameter[] parameterList)
        {
            List<OperationType> bran = new List<OperationType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OperationType oprType = new OperationType();
                oprType.ID = (string)rdr["type_id"];
                if (rdr["type_title"].ToString() != "")
                {
                    oprType.Title = (string)rdr["type_title"];
                }
                bran.Add(oprType);
            }
            rdr.Close();
            return bran;
        }
        #endregion
        #region"Grade"
        public List<Grade> LoadGrade()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"GetGradeId",ParameterDirection.Input),
            };
            return LoadGrade(packageName, parameterList);
        }
        private List<Grade> LoadGrade(string packageName, OracleParameter[] parameterList)
        {
            List<Grade> bran = new List<Grade>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Grade gra = new Grade();
                gra.GradeId = (string)rdr["grade_id"];
                if (rdr["grade_title"].ToString() != "")
                {
                    gra.GradeTitle = (string)rdr["grade_title"];
                }
                bran.Add(gra);
            }
            rdr.Close();
            return bran;
        }
        #endregion
        #region "Anesthesia"
        public List<AnesthesiaMaster> LoadAnesthesiaID()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"GetAnesthesiaID",ParameterDirection.Input),
            };
            return LoadAnesthesiaID(packageName, parameterList);
        }
        private List<AnesthesiaMaster> LoadAnesthesiaID(string packageName, OracleParameter[] parameterList)
        {
            List<AnesthesiaMaster> anesthesia = new List<AnesthesiaMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AnesthesiaMaster anes = new AnesthesiaMaster();
                anes.Anesesthesia = (string)rdr["anesthesia_id"];
                if (rdr["anesthesia_title"].ToString() != "")
                {
                    anes.Anesthesiatitle = (string)rdr["anesthesia_title"];
                }
                anesthesia.Add(anes);
            }
            rdr.Close();
            return anesthesia;
        }
        public List<OperationMaster> LoadOperationMaster()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"LoadOperationMaster",ParameterDirection.Input),
            };
            return LoadOperationMaster(packageName, parameterList);
        }
        private List<OperationMaster> LoadOperationMaster(string packageName, OracleParameter[] parameterList)
        {
            List<OperationMaster> operation = new List<OperationMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OperationMaster opr = new OperationMaster();

                opr.OperationID = (string)rdr["OPR_ID"];
                opr.operationTitle = (string)rdr["OPR_TITLE"];
                opr.operationTitleBang = (string)rdr["OPR_TITLE"];
                opr.OperationTypeCode = (string)rdr["OPR_TYPE_CODE"];
                opr.GradeID = (string)rdr["GRADE_ID"];
                opr.Anesthesiatitle = rdr["ANAES_ID"].ToString();
                opr.OperationFees = Convert.ToDouble(rdr["OPR_FEE"]);
                opr.DrFees = Convert.ToDouble(rdr["DR_FEE"]);
                opr.AnesFees = Convert.ToDouble(rdr["ANS_FEE"]);
                opr.AssistantFees = Convert.ToDouble(rdr["ASST_FEE"]);
                opr.ExpectedTimeHour = Convert.ToDouble(rdr["EXPECETED_TIME_IN_HR"]);
                opr.Remarks = (string)rdr["REMARKS"];
                opr.Active = (string)rdr["ACTIVE"];
                operation.Add(opr);
            }
            rdr.Close();
            return operation;
        }
        #endregion "
        #region "DepID"
        public List<Theater> GetDepID(string strControl)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControl.ToString(),ParameterDirection.Input),
            };
            return GetDepID(packageName, parameterList);
        }
        private List<Theater> GetDepID(string packageName, OracleParameter[] parameterList)
        {
            List<Theater> bran = new List<Theater>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Theater oprType = new Theater();
                oprType.DepId = rdr["DEPT_ID"].ToString();
                if (rdr["DEPT_TITLE"].ToString() != "")
                {
                    oprType.DepName = rdr["DEPT_TITLE"].ToString();
                }
                bran.Add(oprType);
            }
            rdr.Close();
            return bran;
        }
        #endregion
        #region"Get theaterBed"
        public List<BedConfiguration> GetTheaterBed(string strcontrol)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
                OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
            };
            return GetTheaterBed(packageName, parameterList);
        }
        private List<BedConfiguration> GetTheaterBed(string packageName, OracleParameter[] parameterList)
        {
            List<BedConfiguration> bedcon = new List<BedConfiguration>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedConfiguration objBed = new BedConfiguration();
                objBed.theaterID = rdr["theater_id"].ToString();
                if (rdr["theatre_title"].ToString() != "")
                {
                    objBed.theaterTitle = rdr["theatre_title"].ToString();
                }
                bedcon.Add(objBed);
            }
            rdr.Close();
            return bedcon;
        }
        #endregion
        #region "Reg ID"
        public List<BedConfiguration> GetRegID(string strcontrol)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
            };
            return GetRegID(packageName, parameterList);
        }
        private List<BedConfiguration> GetRegID(string packageName, OracleParameter[] parameterList)
        {
            List<BedConfiguration> bedcon = new List<BedConfiguration>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedConfiguration objBed = new BedConfiguration();
                objBed.RegID = rdr["reg_id"].ToString();
                bedcon.Add(objBed);
            }
            rdr.Close();
            return bedcon;
        }
        #endregion
        // new 01_12_14 for Room
        #region "Bed"
        public List<BedConfiguration> GetRoomIdFromTheater(string strcontrol,string  strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return GetRoomIdFromTheater(packageName, parameterList);
        }
        private List<BedConfiguration> GetRoomIdFromTheater(string packageName, OracleParameter[] parameterList)
        {
            List<BedConfiguration> bedcon = new List<BedConfiguration>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedConfiguration objBed = new BedConfiguration();
                objBed.RegID = rdr["room_id"].ToString();
                bedcon.Add(objBed);
            }
            rdr.Close();
            return bedcon;
        }
        #endregion
        #region "Category"
        public List<DoctorsCategory> GetDoctorsCategory(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return GetDoctorsCategory(packageName, parameterList);
        }
        private List<DoctorsCategory> GetDoctorsCategory(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorsCategory> objCategory = new List<DoctorsCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DoctorsCategory objCat = new DoctorsCategory();
                objCat.doctorscode = rdr["emp_id"].ToString();
                objCat.doctorsName = rdr["empname"].ToString();
                objCategory.Add(objCat);
            }
            rdr.Close();
            return objCategory;
        }
        public List<DoctorsCategory> DisplayDoctorsCategory(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return DisplayDoctorsCategory(packageName, parameterList);
        }
        private List<DoctorsCategory> DisplayDoctorsCategory(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorsCategory> objCategory = new List<DoctorsCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DoctorsCategory objCat = new DoctorsCategory();
                objCat.assignId = rdr["id_master"].ToString();
                objCat.doctorscode = rdr["doctors_code"].ToString();
                objCat.doctorsName = rdr["empname"].ToString();
                objCat.assignmenttype = Convert.ToInt16(rdr["assignment_type"]);
                objCategory.Add(objCat);
            }
            rdr.Close();
            return objCategory;
        }
        public List<DoctorsCategory> GetDoctorsAssign(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return GetDoctorsAssign(packageName, parameterList);
        }
        private List<DoctorsCategory> GetDoctorsAssign(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorsCategory> objCategory = new List<DoctorsCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DoctorsCategory objCat = new DoctorsCategory();
                objCat.doctorscode = rdr["doctors_code"].ToString();
                objCat.doctorsName = rdr["empname"].ToString();
                objCategory.Add(objCat);
            }
            rdr.Close();
            return objCategory;
        }
        #endregion
        #region "GetPackageItem"
        public List<PackageItem> GetPackageItem(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return GetPackageItem(packageName, parameterList);
        }
        private List<PackageItem> GetPackageItem(string packageName, OracleParameter[] parameterList)
        {
            List<PackageItem> objPackiItem = new List<PackageItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageItem objPack = new PackageItem();
                objPack.ItemNo = rdr["item_no"].ToString();
                objPack.ItemName = rdr["item_Name"].ToString();
                objPack.ItemRate = Convert.ToDouble(rdr["item_rate"]);
                if (rdr["opd_main_id"].ToString() != "")
                {
                    objPack.submenuID = rdr["opd_main_id"].ToString();
                }
                else
                {
                    objPack.submenuID = "";
                }

                objPackiItem.Add(objPack);
            }
            rdr.Close();
            return objPackiItem;
        }

        #endregion
        #region "GetPackage"
        public List<PackageItem> GetPackage(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return GetPackage(packageName, parameterList);
        }
        private List<PackageItem> GetPackage(string packageName, OracleParameter[] parameterList)
        {
            List<PackageItem> objPackiItem = new List<PackageItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageItem objPack = new PackageItem();
                if (rdr["package_no"].ToString() != "")
                {
                    objPack.PackageItemNo = rdr["package_no"].ToString();
                }
                else
                {
                    objPack.PackageItemNo = "";
                }
                if (rdr["Package_Name"].ToString() != "")
                {
                    objPack.ItemName = rdr["Package_Name"].ToString();
                }
                else
                {
                    objPack.ItemName = "";
                }
                if (rdr["Package_Amount"].ToString() != "")
                {
                    objPack.NetAmount = Convert.ToDouble(rdr["Package_Amount"]);
                }
                else
                {
                    objPack.NetAmount = 0;
                }
                if (rdr["type_id"].ToString() != "")
                {
                    objPack.Oprtype = rdr["type_id"].ToString();
                }
                else
                {
                    objPack.Oprtype = "";
                }
                if (rdr["bed_type"].ToString() != "")
                {
                    objPack.Bedtype = rdr["bed_type"].ToString();
                }
                else
                {
                    objPack.Bedtype = "";
                }
                objPack.Bedstatus = Convert.ToInt16(rdr["bed_status"].ToString());
                if (rdr["p_start_date"].ToString() != "")
                {
                    objPack.fromdate = rdr["p_start_date"].ToString();
                }
                else
                {
                    objPack.fromdate = "";
                }
                if (rdr["p_end_date"].ToString() != "")
                {
                    objPack.todate = rdr["p_end_date"].ToString();
                }
                else
                {
                    objPack.todate = "";
                }

                if (rdr["unit_id"].ToString() != "")
                {
                    objPack.unitID = rdr["unit_id"].ToString();
                }
                else
                {
                    objPack.unitID = "";
                }


                objPackiItem.Add(objPack);
            }
            rdr.Close();
            return objPackiItem;
        }

        #endregion
        public List<PackageItem> DisplayPackage(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return DisplayPackage(packageName, parameterList);
        }
        private List<PackageItem> DisplayPackage(string packageName, OracleParameter[] parameterList)
        {
            List<PackageItem> objPackiItem = new List<PackageItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageItem objPack = new PackageItem();
                objPack.PackageItemNo = rdr["package_no"].ToString();
                objPack.ItemName = rdr["Package_Name"].ToString();
                objPack.NetAmount = Convert.ToDouble(rdr["Package_Amount"]);
                objPack.ItemNo = rdr["item_no"].ToString();
                objPackiItem.Add(objPack);
            }
            rdr.Close();
            return objPackiItem;
        }

        public List<DoctorsCategory> DispalyTeamAssign(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return DispalyTeamAssign(packageName, parameterList);
        }

        private List<DoctorsCategory> DispalyTeamAssign(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorsCategory> objDoctoresCat = new List<DoctorsCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DoctorsCategory objCat = new DoctorsCategory();
                objCat.doctorscode = rdr["emp_id"].ToString();
                objCat.doctorsName = rdr["empname"].ToString();
                objDoctoresCat.Add(objCat);
            }
            rdr.Close();
            return objDoctoresCat;
        }
        public List<OperationMaster> GetSheduleRegID()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"RegID",ParameterDirection.Input),
            };
            return GetSheduleRegID(packageName, parameterList);
        }
        private List<OperationMaster> GetSheduleRegID(string packageName, OracleParameter[] parameterList)
        {
            List<OperationMaster> oprMaster = new List<OperationMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OperationMaster opr = new OperationMaster();
                if (rdr["reg_id"].ToString() != "")
                {
                    opr.RegId = rdr["reg_id"].ToString();
                }
                else
                {
                    opr.RegId = "";
                }
                if (rdr["pat_name"].ToString() != "")
                {
                    opr.RegName = rdr["reg_id"].ToString() + " " + rdr["pat_name"].ToString();
                   // opr.RegId = rdr["hcn"].ToString();
                }
                oprMaster.Add(opr);
            }
            rdr.Close();
            return oprMaster;
        }
        public List<OperationMaster> GetInchargeID()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"InchargeID",ParameterDirection.Input),
            };
            return GetInchargeID(packageName, parameterList);
        }
        private List<OperationMaster> GetInchargeID(string packageName, OracleParameter[] parameterList)
        {
            List<OperationMaster> oprMaster = new List<OperationMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OperationMaster opr = new OperationMaster();
                if (rdr["emp_id"].ToString() != "")
                {
                    opr.RegId = rdr["emp_id"].ToString();
                }
                if (rdr["empname"].ToString() != "")
                {
                    opr.RegName = rdr["empname"].ToString();
                }
                oprMaster.Add(opr);
            }
            rdr.Close();
            return oprMaster;
        }
        public List<OperationMaster> GetPacageInformation()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"PackageMaster",ParameterDirection.Input),
            };
            return GetPacageInformation(packageName, parameterList);
        }
        private List<OperationMaster> GetPacageInformation(string packageName, OracleParameter[] parameterList)
        {
            List<OperationMaster> oprMaster = new List<OperationMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OperationMaster opr = new OperationMaster();
                if (rdr["package_no"].ToString() != "")
                {
                    opr.PackageNo = rdr["package_no"].ToString();
                }
                if (rdr["package_name"].ToString() != "")
                {
                    opr.PackageName = rdr["package_name"].ToString();
                }
                oprMaster.Add(opr);
            }
            rdr.Close();
            return oprMaster;
        }
        public List<Theater> LoadOTtheater()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"TheaterDep",ParameterDirection.Input),
            };
            return LoadOTtheater(packageName, parameterList);
        }
        private List<Theater> LoadOTtheater(string packageName, OracleParameter[] parameterList)
        {
            List<Theater> ottheater = new List<Theater>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Theater theater = new Theater();
                if (rdr["theater_id"].ToString() != "")
                {
                    theater.Theaterid = rdr["theater_id"].ToString();
                }
                else
                {
                    theater.Theaterid = "";
                }

                if (rdr["theatre_title"].ToString() != "")
                {
                    theater.Theatertitle = (string)rdr["theatre_title"];
                }
                else
                {
                    theater.Theatertitle = "";
                }
                    
                ottheater.Add(theater);
            }
            rdr.Close();
            return ottheater;
        }
        public List<CalenderOT> DisplayOTScheduling(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return DisplayOTScheduling(packageName, parameterList);
        }
        private List<CalenderOT> DisplayOTScheduling(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> OTCalender = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT  objCal = new CalenderOT();
                objCal.intCol = Convert.ToInt16(rdr["COL_POS"]);
                objCal.intRow = Convert.ToInt16(rdr["ROW_POS"]);
                objCal.RegNo = rdr["Patient_id"].ToString();
                objCal.Fromtime = rdr["Stratime"].ToString();
                objCal.Totime = rdr["endtime"].ToString();
                objCal.RegDate = rdr["scheduling_date"].ToString();
                objCal.ScheduleID = rdr["SCHEDULING_ID"].ToString();
                OTCalender.Add(objCal);
            }
            rdr.Close();
            return OTCalender;
        }
        public List<CalenderOT> DisplayOTSschedulingDoctors(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol.ToString(),ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return DisplayOTSschedulingDoctors(packageName, parameterList);
        }
        private List<CalenderOT> DisplayOTSschedulingDoctors(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> OTCalender = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT objCal = new CalenderOT();
                objCal.RegNo = rdr["Patient_id"].ToString();
                objCal.ScheduleID = rdr["SCHEDULING_ID"].ToString();
                objCal.PackageId = rdr["package_no"].ToString();
                objCal.PackageName = rdr["package_name"].ToString();

                if (rdr["DOCTORS_CODE"].ToString() != "")
                {
                    objCal.DoctorsCode = rdr["DOCTORS_CODE"].ToString();
                }
                else
                {
                    objCal.DoctorsCode = "";
                }
                if (rdr["empname"].ToString() != "")
                {
                    objCal.doctorsName = rdr["empname"].ToString();
                }
                else
                {
                    objCal.doctorsName = "";
                }

                OTCalender.Add(objCal);
            }
            rdr.Close();
            return OTCalender;
        }
        public List<CalenderOT> DisplayOTPackage(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return DisplayOTPackage(packageName, parameterList);
        }
        private List<CalenderOT> DisplayOTPackage(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> OTCalender = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT objCal = new CalenderOT();
                objCal.PackageId = rdr["package_no"].ToString();
                objCal.PackageName = rdr["package_name"].ToString();
                OTCalender.Add(objCal);
            }
            rdr.Close();
            return OTCalender;
        }
        public List<CalenderOT> GetInchargeIDBar(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere.ToString(),ParameterDirection.Input),
            };
            return GetInchargeIDBar(packageName, parameterList);
        }
        private List<CalenderOT> GetInchargeIDBar(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> OTCalender = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT objCal = new CalenderOT();
                objCal.InchargeId = rdr["emp_id"].ToString();
                objCal.InchargeName = rdr["empname"].ToString();
                OTCalender.Add(objCal);
            }
            rdr.Close();
            return OTCalender;
        }
        public List<OperationMaster> GetInchargeIDBarchart()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"InchargeID",ParameterDirection.Input),
            };
            return GetInchargeIDBarchart(packageName, parameterList);
        }
        private List<OperationMaster> GetInchargeIDBarchart(string packageName, OracleParameter[] parameterList)
        {
            List<OperationMaster> oprMaster = new List<OperationMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OperationMaster opr = new OperationMaster();
                if (rdr["emp_id"].ToString() != "")
                {
                    opr.RegId = rdr["emp_id"].ToString();
                }
                else
                {
                    opr.RegId = "";
                }

                if (rdr["empname"].ToString() != "")
                {
                    opr.RegName = rdr["empname"].ToString();
                }
                else
                {
                    opr.RegName = "";
                }
                oprMaster.Add(opr);
            }
            rdr.Close();
            return oprMaster;
        }
        public List<CalenderOT> GetRowposofBarchat(string strcontrol, string strWhere, string strWhere1)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetrowPosofincharge";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("Pinchargeid",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
                new OracleParameter("pdate",OracleDbType.Varchar2 ,strWhere1,ParameterDirection.Input),

            };
            return GetRowposofBarchat(packageName, parameterList);
        }
        private List<CalenderOT> GetRowposofBarchat(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                if (rdr["row_pos"].ToString() != "")
                {
                    cal.intRow = Convert.ToInt32(rdr["row_pos"].ToString());
                }
                else
                {
                    cal.intRow = 0;
                }
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }

        public List<CalenderOT> GetOTschedulingDetails(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return GetOTschedulingDetails(packageName, parameterList);
        }
        private List<CalenderOT> GetOTschedulingDetails(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if  (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                //cal.intRow = Convert.ToInt32(rdr["row_pos"].ToString());
                cal.RegNo = rdr["Patient_id"].ToString();
                cal.Fromtime = rdr["Stratime"].ToString();
                cal.Totime = rdr["endtime"].ToString();
                cal.RegDate =rdr["scheduling_date"].ToString();
                cal.ScheduleID = rdr["SCHEDULING_ID"].ToString();
                cal.PackageName = rdr["PACKAGE_ID"].ToString();
                cal.InchargeId = rdr["INCHARGE_ID"].ToString();
                cal.status = Convert.ToInt16(rdr["ot_status"].ToString());
                cal.Oprtype = rdr["opr_type"].ToString();
                cal.OprID = rdr["opr_id"].ToString();

               // cal.DoctorsCode = rdr["DOCTORS_CODE"].ToString();
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }

        public List<CalenderOT> DisplayDashBoard(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayDashBoard(packageName, parameterList);
        }
        private List<CalenderOT> DisplayDashBoard(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                cal.ScheduleID = rdr["SCHEDULING_ID"].ToString();
                cal.RegNo = rdr["Patient_id"].ToString();
                cal.Fromtime = rdr["STRATIME"].ToString();
                cal.Totime = rdr["ENDTIME"].ToString();
                //cal.RegDate = Convert.ToDateTime(dr["scheduling_date"]);
                cal.status = Convert.ToInt16(rdr["OT_STATUS"].ToString());
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }


        public List<CalenderOT> DisplayHistory(string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.Getschedulinghistory";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayHistory(packageName, parameterList);
        }
        private List<CalenderOT> DisplayHistory(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                if (rdr["SCHEDULING_ID"].ToString() != "")
                {
                    cal.ScheduleID = rdr["SCHEDULING_ID"].ToString();
                }
                if (rdr["scheduling_date"].ToString() != "")
                {
                    cal.RegDate = rdr["scheduling_date"].ToString();
                }
                if (rdr["patient_id"].ToString() != "")
                {
                    cal.PatientId = rdr["patient_id"].ToString();
                }
                if (rdr["pat_name"].ToString() != "")
                {
                    cal.PatientName = rdr["pat_name"].ToString();
                }
                if (rdr["stratime"].ToString() != "")
                {
                    cal.Fromtime = rdr["stratime"].ToString();
                }
                if (rdr["endtime"].ToString() != "")
                {
                    cal.Totime = rdr["endtime"].ToString();
                }
                if (rdr["OT_STATUS"].ToString() != "")
                {
                    cal.status = Convert.ToInt16(rdr["OT_STATUS"].ToString());
                }
                if (rdr["emp_id"].ToString() != "")
                {
                    cal.DoctorsCode = rdr["emp_id"].ToString();
                }
                if (rdr["doctorsname"].ToString() != "")
                {
                    cal.doctorsName = rdr["doctorsname"].ToString();
                }
                if (rdr["package_name"].ToString() != "")
                {
                    cal.PackageName = rdr["package_name"].ToString();
                }
                if (rdr["package_name"].ToString() != "")
                {
                    cal.packageitem = rdr["item_name"].ToString();
                }
                if (rdr["theatre_title"].ToString() != "")
                {
                    cal.Thetername = rdr["theatre_title"].ToString();
                }
                if (rdr["inchargename"].ToString() != "")
                {
                    cal.InchargeName = rdr["inchargename"].ToString();
                }

                
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }

        public List<CalenderOT> DisplayPatregistration(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayPatregistration(packageName, parameterList);
        }
        private List<CalenderOT> DisplayPatregistration(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                cal.ScheduleID = rdr["SCHEDULING_ID"].ToString();
                cal.RegNo = rdr["Patient_id"].ToString();
                cal.PatientName = rdr["pat_name"].ToString();
                cal.RegDate = rdr["scheduling_date"].ToString();
                cal.Fromtime = rdr["STRATIME"].ToString();
                cal.Totime = rdr["ENDTIME"].ToString();
                cal.PackageName = rdr["package_name"].ToString();
                //cal.RegDate = Convert.ToDateTime(dr["scheduling_date"]);
                cal.status = Convert.ToInt16(rdr["OT_STATUS"].ToString());
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }
        public List<CalenderOT> DisplayDoctorsInformation(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayDoctorsInformation(packageName, parameterList);
        }
        private List<CalenderOT> DisplayDoctorsInformation(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                cal.DoctorsCode = rdr["emp_id"].ToString();
                cal.doctorsName = rdr["doctorsName"].ToString();
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }
        public List<CalenderOT> DisplayPackageInformation(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayPackageInformation(packageName, parameterList);
        }
        private List<CalenderOT> DisplayPackageInformation(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                cal.PackageId = rdr["package_id"].ToString();
                cal.packageitem = rdr["item_name"].ToString();
                cal.packageitemRate = rdr["item_rate"].ToString();
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }

        public List<CalenderOT> DisplayInchargeInformation(string strcontrol, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strcontrol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayInchargeInformation(packageName, parameterList);
        }
        private List<CalenderOT> DisplayInchargeInformation(string packageName, OracleParameter[] parameterList)
        {
            List<CalenderOT> calOT = new List<CalenderOT>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CalenderOT cal = new CalenderOT();
                cal.InchargeId = rdr["emp_id"].ToString();
                cal.InchargeName = rdr["inchargename"].ToString();
                cal.Thetername = rdr["theatre_title"].ToString();
                calOT.Add(cal);
            }
            rdr.Close();
            return calOT;
        }

        public List<BedConfiguration> Getbedconfig(string Pcontrol)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"Bedtype",ParameterDirection.Input),
            };
            return Getbedconfig(packageName, parameterList);
        }
        private List<BedConfiguration> Getbedconfig(string packageName, OracleParameter[] parameterList)
        {
            List<BedConfiguration> bran = new List<BedConfiguration>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedConfiguration objBed = new BedConfiguration();
                objBed.BedID = rdr["type_id"].ToString();
                if (rdr["type_title"].ToString() != "")
                {
                    objBed.BedTitle = (string)rdr["type_title"];
                }
                bran.Add(objBed);
            }
            rdr.Close();
            return bran;
        }

        public List<ChecklistItem> GetChekcList()
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"GetChecklist",ParameterDirection.Input),
            };
            return GetChekcList(packageName, parameterList);
        }
        private List<ChecklistItem> GetChekcList(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["checklist_item_code"].ToString() != "")
                {
                    objChecklist.itemCode = rdr["checklist_item_code"].ToString();
                }
                else
                {
                    objChecklist.itemCode = "";
                }
                if (rdr["checklist_item_name"].ToString() != "")
                {
                    objChecklist.itemName = rdr["checklist_item_name"].ToString();
                }
                else
                {
                    objChecklist.itemName = "";
                }
                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }

        public List<ChecklistItem> GetCheklistOprtype(string strControlName,string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControlName,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return GetCheklistOprtype(packageName, parameterList);
        }
        private List<ChecklistItem> GetCheklistOprtype(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["checklist_item_code"].ToString() != "")
                {
                    objChecklist.itemCode = rdr["checklist_item_code"].ToString();
                }
                else
                {
                    objChecklist.itemCode = "";
                }
                if (rdr["checklist_item_name"].ToString() != "")
                {
                    objChecklist.itemName = rdr["checklist_item_name"].ToString();
                }
                else
                {
                    objChecklist.itemName = "";
                }
                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }

        public List<ChecklistItem> GetCheklistRegNo(string strControlName)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControlName,ParameterDirection.Input),
                //new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return GetCheklistRegNo(packageName, parameterList);
        }
        private List<ChecklistItem> GetCheklistRegNo(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["hcn"].ToString() != "")
                {
                    objChecklist.RegNo = rdr["hcn"].ToString();
                }
                else
                {
                    objChecklist.RegNo = "";
                }
                if (rdr["pat_name"].ToString() != "")
                {
                    objChecklist.PatientName = rdr["pat_name"].ToString();
                }
                else
                {
                    objChecklist.PatientName = "";
                }
                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }

        public List<ChecklistItem> GetRegNotoChecklist(string strControlName,string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControlName,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return GetRegNotoChecklist(packageName, parameterList);
        }
        private List<ChecklistItem> GetRegNotoChecklist(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["pat_name"].ToString() != "")
                {
                    objChecklist.PatientName = rdr["pat_name"].ToString();
                }
                else
                {
                    objChecklist.PatientName = "";
                }
                if (rdr["scheduling_date"].ToString() != "")
                {
                    objChecklist.RegDate = rdr["scheduling_date"].ToString();
                }
                else
                {
                    objChecklist.PatientName = "";
                }
                if (rdr["stratime"].ToString() != "")
                {
                    objChecklist.startime = rdr["stratime"].ToString();
                }
                else
                {
                    objChecklist.startime = "";
                }
                if (rdr["endtime"].ToString() != "")
                {
                    objChecklist.endtime = rdr["endtime"].ToString();
                }
                else
                {
                    objChecklist.endtime = "";
                }

                if (rdr["OPR_TYPE"].ToString() != "")
                {
                    objChecklist.oprType  = rdr["OPR_TYPE"].ToString();
                }
                else
                {
                    objChecklist.oprType = "";
                }

                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }
        public List<ChecklistItem> LoadCheckList(string strControlName)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItem";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControlName,ParameterDirection.Input),
                //new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return LoadCheckList(packageName, parameterList);
        }
        private List<ChecklistItem> LoadCheckList(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["item_code"].ToString() != "")
                {
                    objChecklist.itemCode = rdr["item_code"].ToString();
                }
                else
                {
                    objChecklist.itemCode = "";
                }
                if (rdr["reg_no"].ToString() != "")
                {
                    objChecklist.RegNo = rdr["reg_no"].ToString();
                }
                else
                {
                    objChecklist.RegNo = "";
                }
                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }
        public List<ChecklistItem> GetChecklistFromItemCode(string strControlName, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControlName,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return GetChecklistFromItemCode(packageName, parameterList);
        }
        private List<ChecklistItem> GetChecklistFromItemCode(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["item_code"].ToString() != "")
                {
                    objChecklist.itemCode  = rdr["item_code"].ToString();
                }
                else
                {
                    objChecklist.itemCode = "";
                }
                if (rdr["check_list_date"].ToString() != "")
                {
                    objChecklist.ChecklistDate  = rdr["check_list_date"].ToString();
                }
                else
                {
                    objChecklist.ChecklistDate = "";
                }
                if (rdr["reg_no"].ToString() != "")
                {
                    objChecklist.RegNo = rdr["reg_no"].ToString();
                }
                else
                {
                    objChecklist.RegNo = "";
                }
                if (rdr["checklist_item_code"].ToString() != "")
                {
                    objChecklist.Checklistitemcode = rdr["checklist_item_code"].ToString();
                }
                else
                {
                    objChecklist.Checklistitemcode = "";
                }
                objChecklist.intNo = Convert.ToInt16(rdr["STATUS_NO"].ToString());
                objChecklist.intYes = Convert.ToInt16(rdr["STATUS_YES"].ToString());
                if (rdr["COMMENTS"].ToString() != "")
                {
                    objChecklist.Comments = rdr["COMMENTS"].ToString();
                }
                else
                {
                    objChecklist.Comments = rdr["COMMENTS"].ToString();
                }
                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }

        public List<ChecklistItem> DisplayChecklistfromChecklistNo(string strControlName, string strWhere)
        {
            string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControlName,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
            return DisplayChecklistfromChecklistNo(packageName, parameterList);
        }
       private List<ChecklistItem> DisplayChecklistfromChecklistNo(string packageName, OracleParameter[] parameterList)
        {
            List<ChecklistItem> bran = new List<ChecklistItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ChecklistItem objChecklist = new ChecklistItem();
                if (rdr["item_code"].ToString() != "")
                {
                    objChecklist.itemCode = rdr["item_code"].ToString();
                }
                else
                {
                    objChecklist.itemCode = "";
                }
                if (rdr["check_list_date"].ToString() != "")
                {
                    objChecklist.ChecklistDate = rdr["check_list_date"].ToString();
                }
                else
                {
                    objChecklist.ChecklistDate = "";
                }

                if (rdr["opr_type"].ToString() != "")
                {
                    objChecklist.oprType = rdr["opr_type"].ToString();
                }
                else
                {
                    objChecklist.oprType = "";
                }

                if (rdr["reg_no"].ToString() != "")
                {
                    objChecklist.RegNo = rdr["reg_no"].ToString();
                }
                else
                {
                    objChecklist.RegNo = "";
                }

                if (rdr["checklist_item_code"].ToString() != "")
                {
                    objChecklist.Checklistitemcode = rdr["checklist_item_code"].ToString();
                }
                else
                {
                    objChecklist.Checklistitemcode = "";
                }

                if (rdr["checklist_item_name"].ToString() != "")
                {
                    objChecklist.itemName = rdr["checklist_item_name"].ToString();
                }
                else
                {
                    objChecklist.itemName = "";
                }

                objChecklist.intNo =  Convert.ToInt16(rdr["status_no"].ToString());
                objChecklist.intYes  = Convert.ToInt16(rdr["status_yes"].ToString());
                if (rdr["comments"].ToString() != "")
                {
                    objChecklist.Comments = rdr["comments"].ToString();
                }
                else
                {
                    objChecklist.Comments = "";
                }

                bran.Add(objChecklist);
            }
            rdr.Close();
            return bran;
        }
       public List<OperationMaster> GetoperationInformation()
       {
           string packageName = "AGH_IPD.PKG_OPR.GetItem";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,"LoadOprInfo",ParameterDirection.Input),
            };
           return GetoperationInformation(packageName, parameterList);
       }
       private List<OperationMaster> GetoperationInformation(string packageName, OracleParameter[] parameterList)
       {
           List<OperationMaster> operation = new List<OperationMaster>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               OperationMaster objoprInfo = new OperationMaster();
               if (rdr["opr_id"].ToString() != "")
               {
                   objoprInfo.OperationID = rdr["opr_id"].ToString();
               }
               else
               {
                   objoprInfo.OperationID = "";
               }

               if (rdr["opr_name"].ToString() != "")
               {
                   objoprInfo.operationTitle = rdr["opr_name"].ToString();
               }
               else
               {
                   objoprInfo.operationTitle = "";
               }
               if (rdr["TYPE_ID"].ToString() != "")
               {
                   objoprInfo.OperationTypeCode = rdr["TYPE_ID"].ToString();
               }
               else
               {
                   objoprInfo.OperationTypeCode = "";
               }
               operation.Add(objoprInfo);
           }
           rdr.Close();
           return operation;
       }

       public List<CalenderOT> GetOTnameFromOTtype(string strWhere)
       {
           string packageName = "AGH_IPD.PKG_OPR.GetOprNameFromType";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,strWhere,ParameterDirection.Input),
            };
           return GetOTnameFromOTtype(packageName, parameterList);
       }

       private List<CalenderOT> GetOTnameFromOTtype(string packageName, OracleParameter[] parameterList)
       {
           List<CalenderOT> operation = new List<CalenderOT>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               CalenderOT objoprInfo = new CalenderOT();
               if (rdr["opr_id"].ToString() != "")
               {
                   objoprInfo.OprID = rdr["opr_id"].ToString();
               }
               else
               {
                   objoprInfo.OprID = "";
               }
               if (rdr["opr_name"].ToString() != "")
               {
                   objoprInfo.OprName = rdr["opr_name"].ToString();
               }
               else
               {
                   objoprInfo.OprName = "";
               }
               operation.Add(objoprInfo);
           }
           rdr.Close();
           return operation;
       }

       public List<OperationType> GetOperationConfig()
       {
           string packageName = "PKG_IPD_SETUP.GET_OPR_TYPE";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
           return GetOperationConfig(packageName, parameterList);
       }
       private List<OperationType> GetOperationConfig(string packageName, OracleParameter[] parameterList)
       {
           List<OperationType> ot = new List<OperationType>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               OperationType otobj = new OperationType();
               otobj.ID = (string)rdr[0];
               otobj.Title = (string)rdr[1];
               otobj.TitleBeng = (string)rdr[2];
               otobj.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
               ot.Add(otobj);
           }
           rdr.Close();
           return ot;
       }

        #endregion
       #region "Collection"
       public List<CalenderOT> GetRegDetailsFromOperarion(string strControl,string Where)
       {
           string packageName = "AGH_IPD.PKG_OPR.GetItemWhere";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControl,ParameterDirection.Input),
                new OracleParameter("Pwhere",OracleDbType.Varchar2 ,Where,ParameterDirection.Input),
            };
           return GetRegDetailsFromOperarion(packageName, parameterList);
       }
       private List<CalenderOT> GetRegDetailsFromOperarion(string packageName, OracleParameter[] parameterList)
       {
           List<CalenderOT> objopr = new List<CalenderOT>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               CalenderOT operation = new CalenderOT();
               operation.PatientId = rdr["patient_id"].ToString();
               operation.RegDate = rdr["RegDate"].ToString();
               operation.Oprtype = rdr["opr_type"].ToString();
               operation.OprID = rdr["opr_id"].ToString();
               operation.OprName = rdr["opr_name"].ToString();
               operation.PackageAmount = Convert.ToDouble(rdr["package_amount"]);
               objopr.Add(operation);
           }
           rdr.Close();
           return objopr;
       }
       public List<CalenderOT> GetDoctorsAvaiable(string strControl, string Fdate, string Tdate)
       {
           string packageName = "AGH_IPD.PKG_OPR.GetDoctorsAvailable";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pcontrol",OracleDbType.Varchar2 ,strControl,ParameterDirection.Input),
                new OracleParameter("Pfdate",OracleDbType.Varchar2 ,Fdate,ParameterDirection.Input),
                new OracleParameter("ptdate",OracleDbType.Varchar2 ,Tdate,ParameterDirection.Input),
            };
           return GetDoctorsAvaiable(packageName, parameterList);
       }
       private List<CalenderOT> GetDoctorsAvaiable(string packageName, OracleParameter[] parameterList)
       {
           List<CalenderOT> objopr = new List<CalenderOT>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               CalenderOT operation = new CalenderOT();
               operation.DoctorsCode = rdr["doctors_code"].ToString();
               operation.AvailableFromTime = rdr["doc_avil_ftime"].ToString();
               operation.AvailablrToTime = rdr["doc_avil_ttime"].ToString();
               objopr.Add(operation);
           }
           rdr.Close();
           return objopr;
       }
       #endregion
       #region "Reports"
       public List<OperationDetailsRO> GetOprDetailsReport(int Where,string Fdate ,string Tdate)
       {
           string packageName = "AGH_IPD.PKG_OPR_REPORTS.getoperationdetailsreport";
           OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pwhere",OracleDbType.Varchar2 ,Where,ParameterDirection.Input),
                new OracleParameter("pfdate",OracleDbType.Varchar2 ,Fdate,ParameterDirection.Input),
                new OracleParameter("ptdate",OracleDbType.Varchar2 ,Tdate,ParameterDirection.Input),
            };
           return GetOprDetailsReport(packageName, parameterList);
       }
       private List<OperationDetailsRO> GetOprDetailsReport(string packageName, OracleParameter[] parameterList)
       {
           List<OperationDetailsRO> objopr = new List<OperationDetailsRO>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
           {
               OperationDetailsRO operation = new OperationDetailsRO();
               operation.RegDate = Convert.ToDateTime(rdr["scheduling_date"].ToString());
               if (rdr["patient_id"].ToString() != "")
               {
                   operation.RegID = rdr["patient_id"].ToString();
               }
               else
               {
                   operation.RegID = "";
               }
               if (rdr["pat_name"].ToString() != "")
               {
                   operation.PatinentName = rdr["pat_name"].ToString();
               }
               else
               {
                   operation.PatinentName = "";
               }
               if (rdr["sex"].ToString() != "")
               {
                   operation.Sex = rdr["sex"].ToString();
               }
               else
               {
                   operation.Sex = "";
               }
               if (rdr["stratime"].ToString() != "")
               {
                   operation.StartTime = rdr["stratime"].ToString();
               }
               else
               {
                   operation.StartTime = "";
               }
               if (rdr["endtime"].ToString() != "")
               {
                   operation.Endtime = rdr["endtime"].ToString();
               }
               else
               {
                   operation.Endtime = "";
               }
               operation.OtStatus = Convert.ToInt16(rdr["ot_status"]);

               objopr.Add(operation);
           }
           rdr.Close();
           return objopr;
       }

       #endregion
    }
}
