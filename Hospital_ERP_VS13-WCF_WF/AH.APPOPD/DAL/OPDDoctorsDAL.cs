using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using AH.OracleManager;
using AH.APPOPD.MODEL;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
using AH.DUtility;

namespace AH.APPOPD.DAL
{
    public class OPDDoctorsDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);
        public List<OPDDoctor> GetOPDDoctors()
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_DoctorRoom";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)               
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            List<OPDDoctor> oDoctorsLIST = new List<OPDDoctor>();
            while (rdr.Read())
            {
                OPDDoctor odoctors = new OPDDoctor();

                odoctors.RoomGroup = (string)rdr["ROOM_GRP"];

                Room oRoom = new Room();
                oRoom.RoomID = (string)rdr["ROOM_ID"];
                oRoom.RoomNo = Convert.ToInt16(rdr["ROOMNO"]);  //!rdr.IsDBNull(3) ? Convert.ToInt16(rdr["ROOMNO"]) : ""; //  
                odoctors.Room = oRoom;

                Department oDept = new Department();
                oDept.DepartmentID = (rdr["Dept_id"] == DBNull.Value ? string.Empty : (string)rdr["Department"]);
                oDept.DepartmentTitle = (string)rdr["Department"];
                odoctors.Department = oDept;

                DepartmentUnit deptUnit = new DepartmentUnit();
                deptUnit.UnitId = (string)rdr["Unit_id"];
                deptUnit.UnitTitle = (string)rdr["Unit"];
                odoctors.DepartmentUnit = deptUnit;

             

                Doctor oDoctor = new Doctor();
                oDoctor.ID = (string)rdr["Doc_ID"];
                oDoctor.Name = (rdr["DOCTORNAME"] == DBNull.Value ? string.Empty : (string)rdr["DOCTORNAME"]);
                odoctors.Doctor = oDoctor;

                odoctors.VisStartTime = (string)rdr["VisStartTime"];        //Convert.ToString(oReader.GetString("VisStartTime"));
                odoctors.VisEndTime = (string)rdr["VisEndTime"];            //Convert.ToString(oReader.GetString("VisEndTime"));

                odoctors.VisFirst = Convert.ToString((Decimal)rdr["VisFirst"]);// rdr.GetDecimal("DrVisFirst");//(string)rdr["VisFirst"];
                odoctors.DrVisFirst = Convert.ToString((Decimal)rdr["DrVisFirst"]);
                odoctors.VisSecond = Convert.ToString((Decimal)rdr["VisSecond"]);
                odoctors.DrVisSecond = Convert.ToString((Decimal)rdr["DrVisSecond"]);
                odoctors.VisThird = Convert.ToString((Decimal)rdr["VisThird"]);
                odoctors.DrVisThird = Convert.ToString((Decimal)rdr["DrVisThird"]);
                odoctors.VisFourth = Convert.ToString((Decimal)rdr["VisFourth"]);
                odoctors.DrVisFourth = Convert.ToString((Decimal)rdr["DrVisFourth"]);

                odoctors.RptVisit = Convert.ToString((Decimal)rdr["RptVisit"]);
                odoctors.DrRptVisit = Convert.ToString((Decimal)rdr["DrRptVisit"]);

                odoctors.VisitCycle = Convert.ToString((Decimal)rdr["VisitCycle"]);
                odoctors.MaxPatBar = Convert.ToString((Decimal)rdr["MaxPatBar"]);
                odoctors.AvgPatMin = Convert.ToString((Decimal)rdr["AvgPatMin"]);


                odoctors.DegreeLine1 = (rdr["degree1"] == DBNull.Value ? string.Empty : (string)rdr["degree1"]);
                odoctors.DegreeLine2 = (rdr["degree2"] == DBNull.Value ? string.Empty : (string)rdr["degree2"]);
                odoctors.DegreeLine3 = (rdr["degree3"] == DBNull.Value ? string.Empty : (string)rdr["degree3"]);
                odoctors.DegreeLine4 = (rdr["degree4"] == DBNull.Value ? string.Empty : (string)rdr["degree4"]);

                EntryParameter oEP = new EntryParameter();

                oEP.EntryDate.ToString("dd-MM-yyyy");
                odoctors.EntryParameter = oEP;

                oEP.EntryBy = (string)rdr["EntryBy"];

                oDoctorsLIST.Add(odoctors);
            }
            rdr.Close();
            return oDoctorsLIST;

        
        }
    }
}
