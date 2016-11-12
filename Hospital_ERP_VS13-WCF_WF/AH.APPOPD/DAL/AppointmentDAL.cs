using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.APPOPD.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.APPOPD.DAL
{
    public class AppointmentDAL
    {
         private string connstring = Utility.GetConnectionString(Utility.Module.APMS);
        string packageName = string.Empty;

        //public string SaveDoctorWeekDays(DoctorWeekDays apms)
        //{
        //    packageName = "pkg_apms_setup.save_doctor_weekdays";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
        //        new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
        //        new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input),
        //        new OracleParameter("p_week_day_no",OracleDbType.Varchar2,2,apms.WeekDayNO,ParameterDirection.Input),
        //        new OracleParameter("p_active",OracleDbType.Char,1,apms.EntryParameter.Active,ParameterDirection.Input),
        //        new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
        //        new OracleParameter("p_entry_date",OracleDbType.Date,apms.EntryParameter.EntryDate,ParameterDirection.Input),
        //        new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input),
        //        new OracleParameter("p_update_date",OracleDbType.Date,apms.EntryParameter.EntryDate,ParameterDirection.Input),
        //        new OracleParameter("p_version",OracleDbType.Int64,apms.EntryParameter.Version,ParameterDirection.Input),
        //        new OracleParameter("p_dt",OracleDbType.Date,apms.EntryParameter.SysDate,ParameterDirection.Input),
        //        new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

        //    };

        //    short i= DALHelper.Insert(connstring,packageName,parameterList);
        //    OracleParameter[] prm= {parameterList[0],parameterList[2],parameterList[3] };

        //    if ((OracleDecimal)prm[1].Value == 1)
        //        return prm[1].Value + "~" + prm[2].Value;

        //    else
        //        return "0";

        //}


        public List<OpdAppointment> Appointment(string hcn)
        {
            List<OpdAppointment> oAppointmentLIST = new List<OpdAppointment>();
            string packageName = "AGH_APMS.pkg_apms_setup.GetPatientAppointmentDetails";  //AGH_APMS.pkg_apms_setup. GetPatientAppointmentDetails

            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("hcn",OracleDbType.Varchar2,15,hcn,ParameterDirection.Input),         
            };

            OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                OpdAppointment app = new OpdAppointment();

                Department oDept = new Department();
                oDept.DepartmentID =(string)rdr["DEPT_ID"];

                DepartmentUnit dept = new DepartmentUnit();
                dept.UnitId = (string)rdr["Unit_ID"];
                app.DepartmentUnit = dept;
                app.Department = oDept;

                Doctor oDoctor = new Doctor();
                oDoctor.ID = (string)rdr["DOCTOR_ID"];
                //oDoctor.Name = (rdr["DOCTORNAME"] == DBNull.Value ? string.Empty : (string)rdr["DOCTORNAME"]);
                app.Doctor = oDoctor;
                app.AppointID = (string)rdr["APPOINT_ID"];
                app.TokenNo = (string)rdr["TokenWithDoctor"];
                app.ApproxSTime = (string)rdr["APPROX_S_TIME"];
                app.ApproxETime = (string)rdr["APPROX_E_TIME"];

                oAppointmentLIST.Add(app);
            }
            rdr.Close();
            return oAppointmentLIST;
        }


        public List<OpdAppointment> GetPatientInfo(string deptId, string unitId, string doctorId, string tokenNo, string appointDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetPatientInfo";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_app_token_no",OracleDbType.Varchar2,30,tokenNo,ParameterDirection.Input),
                new OracleParameter("p_appoint_date",OracleDbType.Varchar2,30,appointDate,ParameterDirection.Input),
            };

            return GetPatientInfo(packageName, parameterList);

        }

        public List<OpdAppointment> GetPatientListForHcn()
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetPatientListForHcn";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               
            };

            return GetPatientInfo(packageName, parameterList);

        }

        private List<OpdAppointment> GetPatientInfo(string packageName, OracleParameter[] parameterList)
        {
            List<OpdAppointment> oListGrid = new List<OpdAppointment>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                OpdAppointment oOpdPat = new OpdAppointment();

                Patient oPat = new Patient();

                oPat.Name = (string)rdr["pat_name"];
                Age age = new Age();
                age.Year = Convert.ToInt16(rdr["AGE_Y"]);
                age.Month = Convert.ToInt16(rdr["AGE_M"]);
                age.Day = Convert.ToInt16(rdr["AGE_D"]);
                oPat.AgeBreakDown = age;
                oPat.Permanent_H_R_B = rdr["ADDR"].ToString();               
                oPat.HomePhone = !rdr.IsDBNull(10)?(string)rdr["PHONE"]:"";              
                oPat.CellPhone = !rdr.IsDBNull(9)?(string)rdr["MOBILE"]:"";
                oPat.Country = (string)rdr["country"];
                oPat.Sex = (string)rdr["Gender"];
                oPat.Email = !rdr.IsDBNull(11)?(string)rdr["EMAIL"]:"";
                oPat.HCN = (string)rdr["HCN"];
                oOpdPat.Patient = oPat;

                //Department dept = new Department();
                //dept.DepartmentTitle = (string)rdr["dept_name"];
                //oOpdPat.Department = dept;

                //DepartmentUnit deptUnit = new DepartmentUnit();
                //deptUnit.UnitTitle = (string)rdr["unit_name"];
                //oOpdPat.DepartmentUnit = deptUnit;

                //Doctor doc = new Doctor();
                //doc.Name = (string)rdr["doc_name"];
                //oOpdPat.Doctor = doc;
                oOpdPat.AppointID = (string)rdr["APPOINT_ID"];
                oOpdPat.AppointDate = rdr["appointDate"].ToString();
                oOpdPat.ApproxSTime = (string)rdr["APPROX_S_TIME"];
                oOpdPat.BookingType = (string)rdr["booking_type"];
                oOpdPat.VisitorType = (string)rdr["visitor_type"];
                oOpdPat.VisitType = (string)rdr["visit_type"];
                oOpdPat.TokenNo = (string)rdr["APP_TOKEN_NO"];
                oListGrid.Add(oOpdPat);

            }
            rdr.Close();
            return oListGrid;

        }
    
    }
}
