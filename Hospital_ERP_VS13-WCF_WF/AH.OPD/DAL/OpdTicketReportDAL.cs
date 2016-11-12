using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using System.Data;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using Oracle.DataAccess.Types;

namespace AH.DLayer.OPD
{
    public class OpdTicketReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.OPDMIS);
        string packageName = string.Empty;
        #region Search
        public List<OPDTicketRO> GetOPDTicketDetails(string ParamDateFrom, string ParamDateTo)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_MR_Collection_Details";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_datefrom",OracleDbType.Varchar2,30,ParamDateFrom,ParameterDirection.Input),
             new OracleParameter ("p_dateto",OracleDbType.Varchar2,30,ParamDateTo,ParameterDirection.Input),
            };

            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }
        public List<OPDTicketRO> GetOPDTicketMR(string TicketNo)    //OPD money receipt, 
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_MoneyReceipt";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_ticketno",OracleDbType.Varchar2,30,TicketNo,ParameterDirection.Input) 
            };

            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }
      
        public List<OPDTicketRO> GetOPDRefundTicketMR(string TicketNo)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_RefundReceipt";

            OracleParameter[] parameterList = new OracleParameter[] 
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_ticketno",OracleDbType.Varchar2,30,TicketNo,ParameterDirection.Input) 
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            List<OPDTicketRO> oRefTicket = new List<OPDTicketRO>();

            while (rdr.Read())
            {
                OPDTicketRO oTktRef = new OPDTicketRO();
                oTktRef.TicketNo =(string)rdr["TicketNo"];
                oTktRef.PreviousTicketNo = (string)rdr["PreviousTicketNo"];
                oTktRef.HCN = (string)rdr["HCN"];
                oTktRef.PatSerial = (string)rdr["PatSerial"];
                oTktRef.Staff_ID = (string)rdr["Staff_ID"];
              
                oTktRef.Case_ID = (string)rdr["Case_ID"];
                oTktRef.TransactionNo = (string)rdr["TransactionNo"];
                oTktRef.Tkt_Type_ID = (string)rdr["Tkt_Type_ID"];
                oTktRef.Tkt_Cat = (string)rdr["Tkt_Cat"];
                oTktRef.Tkt_Status = (string)rdr["Tkt_Status"];
                oTktRef.Dept_ID = (string)rdr["Dept_ID"];
                oTktRef.DepertmentName = (string)rdr["DepertmentName"];
                oTktRef.Unit_ID = (string)rdr["Unit_ID"];
                oTktRef.UnitName = (string)rdr["UnitName"];
                oTktRef.DoctorName = (string)rdr["DoctorName"];
                oTktRef.Age = (string)rdr["Age"];
                oTktRef.TKT_Valid = (string)rdr["TKT_Valid"];
                oTktRef.Copy_Printed = (string)rdr["Copy_Printed"];

                oTktRef.TicketFee = Convert.ToDouble((decimal)rdr["TicketFee"]);
                oTktRef.Consult_fee = Convert.ToDouble((decimal)rdr["Consult_fee"]);
                oTktRef.Refd_fee = Convert.ToDouble((decimal)rdr["Refd_fee"]);
                oTktRef.Dept_fee = Convert.ToDouble((decimal)rdr["Dept_fee"]);
                oTktRef.Discount = Convert.ToDouble((decimal)rdr["Discount"]);
                oTktRef.VAT = Convert.ToDouble((decimal)rdr["VAT"]);

                oTktRef.RoomNo = (string)rdr["Room_No"];
                oTktRef.AppointmentID = (string)rdr["AppointmentID"];

                oTktRef.EntryDate = Convert.ToDateTime(rdr["EntryDate"]).ToString("dd MMM yyyy");

              //  oEP.EntryDate = Convert.ToDateTime(oReader.GetDateTime("Entry_Date").ToString("dd MMM yyyy"));

                oTktRef.PatientName = (string)rdr["PatientName"];
                oTktRef.Sex = (string)rdr["Sex"];
                oTktRef.Address = (string)rdr["Address"];
                oTktRef.MobileNo = (string)rdr["MobileNo"];  
                //oTktRef.HomePhone = (string)rdr["HomePhone"];
                oTktRef.DOB = Convert.ToDateTime(rdr["DOB"]).ToString("dd MMM yyyy");// (string)rdr["DOB"];
                oTktRef.DoctorID = (string)rdr["DoctorID"];
                oTktRef.EntryBy = (string)rdr["EntryBy"];

                oRefTicket.Add(oTktRef);
            }
            rdr.Close();
            return oRefTicket;
        }

        public List<OPDTicketRO> GetOPDDepartment(string deapartmentname, string ParamDateFrom, string ParamDateTo)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_Department";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_dept_title",OracleDbType.Varchar2,30,deapartmentname,ParameterDirection.Input),
             new OracleParameter ("p_datefrom",OracleDbType.Varchar2,30,ParamDateFrom,ParameterDirection.Input),
             new OracleParameter ("p_dateto",OracleDbType.Varchar2,30,ParamDateTo,ParameterDirection.Input),
            };

            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }
        public List<OPDTicketRO> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_Voucher_Report";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("user_id",OracleDbType.Varchar2,30,user_id,ParameterDirection.Input),
             new OracleParameter ("p_datefrom",OracleDbType.Varchar2,30,ParamDateFrom,ParameterDirection.Input),
             new OracleParameter ("p_dateto",OracleDbType.Varchar2,30,ParamDateTo,ParameterDirection.Input),
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            List<OPDTicketRO> oVoucher = new List<OPDTicketRO>();

            while (rdr.Read())
            {
                OPDTicketRO oVou = new OPDTicketRO();
                oVou.EntryBy = (string)rdr["USER_ID"];
                oVou.VoucherNo = (string)rdr["VOU_NUM"];
                oVou.CashAmount = Convert.ToDouble((decimal)rdr["CASH"]);
                oVou.CreditCardAmount = Convert.ToDouble((decimal)rdr["CREDIT_AMT"]);
                oVou.DebitCardAmount = Convert.ToDouble((decimal)rdr["DEBIT_AMT"]);
                oVou.TotalAmount = Convert.ToDouble((decimal)rdr["NET_AMOUNT"]);
                oVou.EntryDate = Convert.ToDateTime(rdr["ENTRY_DATE"]).ToString("dd MMM yyyy");
                oVoucher.Add(oVou);
            }
            rdr.Close();
            return oVoucher;
        }


        public List<OPDTicketRO> GetOPDCollSummary(string DateFrom, string DateTo)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_Coll_Sum";

            OracleParameter[] parameterList = new OracleParameter[]
            {
               new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),   
               new OracleParameter ("p_datefrom",OracleDbType.Varchar2,30,DateFrom,ParameterDirection.Input),
               new OracleParameter ("p_dateto",OracleDbType.Varchar2,30,DateTo,ParameterDirection.Input)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            List<OPDTicketRO> oCollSum = new List<OPDTicketRO>();
            while (rdr.Read())
            {
                OPDTicketRO oColl = new OPDTicketRO();

                oColl.Dept_ID = (string)rdr["DEPT_ID"];
                oColl.DepertmentName = (string)rdr["depertmentname"];
                oColl.Unit_ID = (string)rdr["UNIT_ID"];
                oColl.UnitName = (string)rdr["UnitName"];
                oColl.TicketFee = Convert.ToDouble((decimal)rdr["FeeTotal"]);

                oCollSum.Add(oColl);
            }
            rdr.Close();
            return oCollSum;
        }


        public List<OPDTicketRO> GetOPDMRDoctor(string doctorid, string deapartmentname, string ParamDateFrom, string ParamDateTo)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_MR_Doctor";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_doctor_id",OracleDbType.Varchar2,30,doctorid,ParameterDirection.Input),
             new OracleParameter ("p_dept_id",OracleDbType.Varchar2,30,deapartmentname,ParameterDirection.Input),
             new OracleParameter ("p_datefrom",OracleDbType.Varchar2,30,ParamDateFrom,ParameterDirection.Input),
             new OracleParameter ("p_dateto",OracleDbType.Varchar2,30,ParamDateTo,ParameterDirection.Input),
            };

            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }


        public List<OPDTicketRO> GetsOPD()
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Gets_OPD";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)

            };

            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }

        //public List<OPDTicketRO> GetsOPD(string TicketNo)
        //{
        //    string packageName = "AGH_OPD.Pkg_OPD_Reports.Gets_OPD";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //     new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //     new OracleParameter ("p_ticketno",OracleDbType.Varchar2,30,TicketNo,ParameterDirection.Input) 

        //    };

        //    return GetOPDTicketDetailsDetails(packageName, parameterList);
        //}
        public List<Department> GetsDepartmentName()
        {

            string packageName = "AGH_OPD.Pkg_OPD_Reports.Gets_Department";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };

            return GetDepartments(packageName, parameterList);
        }
        public List<Doctor> GetDoctorNames()
        {

            string packageName = "AGH_OPD.Pkg_OPD_Reports.Gets_Doctor";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };

            return GetDoctors(packageName, parameterList);
        }
        private List<Doctor> GetDoctors(string packageName, OracleParameter[] parameterList)
        {
            List<Doctor> rDRSs = new List<Doctor>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsDoctor(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return rDRSs;
        }
        private List<Department> GetDepartments(string packageName, OracleParameter[] parameterList)
        {
            List<Department> rDRSs = new List<Department>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsDepartment(reader);
                }

            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return rDRSs;
        }

        //private List<OPDTicketRO> GetOPDTicketDetailsDetails(string packageName, OracleParameter[] parameterList)
        //{
        //    List<OPDTicketRO> rDRSs = new List<OPDTicketRO>();
        //    IDataReader reader = null;
        //    try
        //    {
        //        reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //        if (reader.FieldCount > 0)
        //        {
        //            rDRSs = CreateObjects(reader);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }      
        //        return rDRSs;
        //}
        #endregion

        #region DataReaderMappingwithNUll
        #region MapObjec
        

        private Doctor MapObjectDoctor(NullHandler oReader)
        {
            Doctor oDRS = new Doctor();
            Designation oDsg = new Designation();
            Department oDpt = new Department();

            //oDsg.DesignationTitle = oReader.GetString("Designation");
            //oDRS.Designation = oDsg;

            oDRS.Degree1 = oReader.GetString("Degree1");
            oDRS.Degree2 = oReader.GetString("Degree2");
            oDRS.Degree3 = oReader.GetString("Degree3");
            oDRS.Degree4 = oReader.GetString("Degree4");

            oDRS.Name = oReader.GetString("DoctorName");
            oDRS.ID = oReader.GetString("DoctorID");

            oDpt.DepartmentTitle = oReader.GetString("DepartmentName");
            oDRS.Department = oDpt;
            return oDRS;
        }

        private Department MapObjectDept(NullHandler oReader)
        {
            Department oDRS = new Department();
            oDRS.DepartmentTitle = oReader.GetString("DepartmentName");
            oDRS.DepartmentID = oReader.GetString("Dept_ID");

            DepartmentGroup oDGroup = new DepartmentGroup();
            oDGroup.DepartmentGroupTitle = oReader.GetString("Group_Title");
            oDRS.DepartmentGroup = oDGroup;
            oDRS.DepartmentUnit = oReader.GetString("UnitName");

            return oDRS;
        }
        #endregion
        #region createobject
       

        private Doctor CreateObjectDoctor(NullHandler oReader)
        {
            Doctor oDRS = new Doctor();
            oDRS = MapObjectDoctor(oReader);
            return oDRS;
        }

        private Department CreateObjectDept(NullHandler oReader)
        {
            Department oDRS = new Department();
            oDRS = MapObjectDept(oReader);
            return oDRS;
        }
        #endregion
        #region CreateObjects
        

        private List<Department> CreateObjectsDepartment(IDataReader oReader)
        {
            List<Department> rDRSs = new List<Department>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                Department oItem = CreateObjectDept(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private List<Doctor> CreateObjectsDoctor(IDataReader oReader)
        {
            List<Doctor> rDRSs = new List<Doctor>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                Doctor oItem = CreateObjectDoctor(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion

        #endregion

 #region Tree        

        public List<PatHistoryTree> GetsTree(string HCN)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Gets_Pat_Tree";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
             ,new OracleParameter ("p_mrno",OracleDbType.Varchar2,30,HCN,ParameterDirection.Input)
            };

            return GetsTreeDetails(packageName, parameterList);        
        }
        private List<PatHistoryTree> GetsTreeDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PatHistoryTree> rDRSs = new List<PatHistoryTree>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsTree(reader);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }

        private List<PatHistoryTree> CreateObjectsTree(IDataReader oReader)
        {
            List<PatHistoryTree> rDRSs = new List<PatHistoryTree>();
            NullHandler oHandler = new NullHandler(oReader);

            while (oReader.Read())
            {
                PatHistoryTree oItem = CreateObjectTree(oHandler);
                rDRSs.Add(oItem);
                // break;
            }
            
            return rDRSs;
        }

        private PatHistoryTree CreateObjectTree(NullHandler oReader)
        {
            PatHistoryTree oDRS = new PatHistoryTree();
            oDRS = MapObjectTree(oReader);
            return oDRS;
        }

        private PatHistoryTree MapObjectTree(NullHandler oReader)
        {
            PatHistoryTree oDRS = new PatHistoryTree();
            oDRS.HCN = oReader.GetString("HCN");
            oDRS.VisitDate = oReader.GetDateTime("VisitDate").ToString("dd MMM yyyy");
            oDRS.TreeGroup = oReader.GetString("TreeGroup");
            oDRS.Name = oReader.GetString("Name");
            oDRS.ResultDetails = oReader.GetString("ResultDetails");
            oDRS.VisitAndDept = oReader.GetString("VisitandDept");
            //oDRS.ResultDetails = oReader.GetString("ResultDetails");
            return oDRS;
        }

 #endregion

       
        public List<OPDDoctorCallQ> GetsOPDDoctorName()
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_Nurse_Calling";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_roomno",OracleDbType.Varchar2,30,"",ParameterDirection.Input),
             new OracleParameter ("p_doctorid",OracleDbType.Varchar2,30,"",ParameterDirection.Input)
                
            };

            return GetOPDDrCallQDetails(packageName, parameterList);
        }

        //Fauzul 15 July 2014
        private List<OPDDoctorCallQ> GetOPDDrCallQDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDDoctorCallQ> rDRSs = new List<OPDDoctorCallQ>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsDrQ(reader);
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return rDRSs;
        }
        private List<OPDDoctorCallQ> CreateObjectsDrQ(IDataReader oReader)
        {
            List<OPDDoctorCallQ> rDRSs = new List<OPDDoctorCallQ>();

            NullHandler oHandler = new NullHandler(oReader);
          
            while (oReader.Read())
            {
                OPDDoctorCallQ oItem = CreateObjectDrQ(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDDoctorCallQ CreateObjectDrQ(NullHandler oReader)
        {
            OPDDoctorCallQ oDRS = new OPDDoctorCallQ();
            oDRS = MapObjectDrQ(oReader);
            return oDRS;
        }

        private OPDDoctorCallQ MapObjectDrQ(NullHandler oReader)
        {
            OPDDoctorCallQ oDrCallQ = new OPDDoctorCallQ();

            oDrCallQ.Dept_ID = oReader.GetString("Dept_ID");
            oDrCallQ.DepertmentName = oReader.GetString("DepertmentName");

            oDrCallQ.UnitId = oReader.GetString("Unit_ID");
            oDrCallQ.UnitName = oReader.GetString("UnitName");

            oDrCallQ.Doc_ID = oReader.GetString("Doc_ID");
            oDrCallQ.DoctorName = oReader.GetString("DoctorName");

            oDrCallQ.NurseID = oReader.GetString("Nurse_ID");
            oDrCallQ.NStationID = oReader.GetString("Nurse_Station_ID");

            oDrCallQ.RoomNo = oReader.GetString("Room_No");
            oDrCallQ.TicketNo = oReader.GetString("Pres_No");

            oDrCallQ.DoctorStatus = oReader.GetString("DoctorStatus");
            oDrCallQ.PatientCount = oReader.GetString("PatientCount");

            return oDrCallQ;
        }

        //Fauzul 28 Jun 2014......................................................ticketRO....................................................................
        public List<OPDTicketRO> GetsOPDDocRoomNo(string RoomNo, string DocID)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_Nurse_Calling";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_roomno",OracleDbType.Varchar2,30,RoomNo,ParameterDirection.Input), 
             new OracleParameter ("p_doctorid",OracleDbType.Varchar2,30,DocID,ParameterDirection.Input)
            };
            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }

        private List<OPDTicketRO> GetOPDTicketDetailsDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDTicketRO> rDRSs = new List<OPDTicketRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjects(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        private List<OPDTicketRO> CreateObjects(IDataReader oReader)
        {
            List<OPDTicketRO> rDRSs = new List<OPDTicketRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDTicketRO oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDTicketRO CreateObject(NullHandler oReader)
        {
            OPDTicketRO oDRS = new OPDTicketRO();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private OPDTicketRO MapObject(NullHandler oReader)
        {
            OPDTicketRO oDRS = new OPDTicketRO();
            oDRS.TicketNo = oReader.GetString("TicketNo");
            oDRS.HCN = oReader.GetString("HCN");
            oDRS.PatSerial = oReader.GetString("PatSerial");
            oDRS.Staff_ID = oReader.GetString("Staff_ID");
            oDRS.Case_ID = oReader.GetString("Case_ID");
            oDRS.TransactionNo = oReader.GetString("TransactionNo");
            oDRS.Tkt_Type_ID = oReader.GetString("Tkt_Type_ID");
            oDRS.Tkt_Cat = oReader.GetString("Tkt_Cat");
            oDRS.Tkt_Status = oReader.GetString("Tkt_Status");
            oDRS.Dept_ID = oReader.GetString("Dept_ID");
            oDRS.DepertmentName = oReader.GetString("DepertmentName");
            oDRS.EntryDate = oReader.GetDateTime("EntryDate").ToString("dd MMM yyyy");
            oDRS.Unit_ID = oReader.GetString("Unit_ID");
            oDRS.UnitName = oReader.GetString("UnitName");

           // oDRS.DoctorID = oReader.GetString("Doctor_ID");
            oDRS.DoctorName = oReader.GetString("DoctorName");

            oDRS.Age = oReader.GetString("Age");
            oDRS.TKT_Valid = oReader.GetString("TKT_Valid");
            oDRS.Copy_Printed = oReader.GetString("Copy_Printed");
            oDRS.TicketFee = Convert.ToDouble(oReader.GetString("TicketFee"));
            oDRS.Consult_fee = Convert.ToDouble(oReader.GetString("Consult_fee"));
            oDRS.Refd_fee = Convert.ToDouble(oReader.GetString("Refd_fee"));
            oDRS.Dept_fee = Convert.ToDouble(oReader.GetString("Dept_fee"));
            oDRS.Discount = Convert.ToDouble(oReader.GetString("Discount"));
            oDRS.VAT = Convert.ToDouble(oReader.GetString("VAT"));
            oDRS.PatientName = oReader.GetString("PatientName");
            oDRS.MobileNo = oReader.GetString("MobileNo");
            oDRS.Sex = oReader.GetString("Sex");
            oDRS.Address = oReader.GetString("Address");
            oDRS.MobileNo = oReader.GetString("MobileNo");
            oDRS.HomePhone = oReader.GetString("HomePhone");
            oDRS.DOB = oReader.GetDateTime("DOB").ToString("dd MMM yyyy");
            oDRS.DoctorID = oReader.GetString("DoctorID");
            oDRS.EntryDate = oReader.GetDateTime("EntryDate").ToString("dd MMM yyyy");
            oDRS.EntryBy = oReader.GetString("EntryBy");
            oDRS.RoomNo = oReader.GetString("RoomID");
            oDRS.Room = oReader.GetString("RoomNo");
            oDRS.AppointmentID = oReader.GetString("AppointmentID");
            oDRS.DoctorStatus = oReader.GetString("DoctorStatus");

            return oDRS;
        }
        //................................................................................................
        //Fauzul 28 Jun 2014
        public List<OPDTicketRO> ChangePatientStatus(string TickeNo, string RoomNo, string Doc_ID)
        {
            string packageName = "AGH_OPD.PKG_OPD_REPORTS.Change_Pat_Status";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_ticketNo",OracleDbType.Varchar2,30,TickeNo,ParameterDirection.Input),
             new OracleParameter ("p_roomno",OracleDbType.Varchar2,30,RoomNo,ParameterDirection.Input),
             new OracleParameter ("p_doc_id",OracleDbType.Varchar2,30,Doc_ID,ParameterDirection.Input),
            };

            return GetOPDTicketDetailsDetails(packageName, parameterList);
        }

        public object deapartmentname { get; set; }


        public List<OPDTicketRO> GetOPDVisitedPatList(string dept_id, string unit_id, string doc_id)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_VisPatList";

            OracleParameter[] parameterList = new OracleParameter[]
            {
               new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),   
               new OracleParameter ("p_dept_id",OracleDbType.Varchar2,30,dept_id,ParameterDirection.Input),
               new OracleParameter ("p_unit_id",OracleDbType.Varchar2,30,unit_id,ParameterDirection.Input),
               new OracleParameter ("p_doc_id",OracleDbType.Varchar2,30,doc_id,ParameterDirection.Input)
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            List<OPDTicketRO> oVisitPatList = new List<OPDTicketRO>();
            while (rdr.Read())
            {
                OPDTicketRO oVisitPat = new OPDTicketRO();

                oVisitPat.TicketNo = (string)rdr["TKT_NO"];
                oVisitPat.HCN = (string)rdr["HCN"];
                oVisitPat.Age = (string)rdr["Age"];
                oVisitPat.PatSerial = (string)rdr["SERIAL"];
                oVisitPat.TicketFee = Convert.ToDouble((decimal)rdr["TKT_FEE"]);
                oVisitPat.Consult_fee = Convert.ToDouble((decimal)rdr["CONSULT_FEE"]);
                oVisitPat.EntryDate =Convert.ToString( Convert.ToDateTime(rdr["entry_date"]).ToString("dd MMM yyyy"));
                oVisitPatList.Add(oVisitPat);
            }
            rdr.Close();
            return oVisitPatList;
        }

        public short ChangeTktStatusFrmDoc(string ticketNo,string DocID)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Chng_Pat_Status_frmDoc";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output),        
             new OracleParameter ("tkt_no",OracleDbType.Varchar2,30,ticketNo,ParameterDirection.Input),
             new OracleParameter ("doc_id",OracleDbType.Varchar2,30,DocID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
    }
}
