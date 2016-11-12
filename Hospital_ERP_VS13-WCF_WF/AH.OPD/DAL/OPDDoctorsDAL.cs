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
using AH.PRMS.MODEL;
using AH.APPOPD.MODEL;
namespace AH.OPD.DAL
{
    public class OPDDoctorsDAL
    {  
        private string connstring = Utility.GetConnectionString(Utility.Module.OPDMIS);
        string packageName = string.Empty;

        public List<OPDDoctor> GetOPDDoctors(string DeptID, string UnitID)
        {
            string packageName = "AGH_OPD.PKG_OPD.Get_OPD_Doc_List";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_dept_id",OracleDbType.Varchar2,30,DeptID,ParameterDirection.Input),
             new OracleParameter ("p_unit_id",OracleDbType.Varchar2,30,UnitID,ParameterDirection.Input)
            };

            return GetOPDDoctorsList(packageName, parameterList);
        }

        private List<OPDDoctor> GetOPDDoctorsList(string packageName, OracleParameter[] parameterList)
        {

            List<OPDDoctor> rDRSs = new List<OPDDoctor>();
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

        private List<OPDDoctor> CreateObjects(IDataReader oReader)
        {
            List<OPDDoctor> rDRSs = new List<OPDDoctor>();

            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDDoctor oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }

        private OPDDoctor CreateObject(NullHandler oReader)
        {
            OPDDoctor oDRS = new OPDDoctor();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private OPDDoctor MapObject(NullHandler oReader)
        {
            OPDDoctor oOPDDoctor = new OPDDoctor();
            oOPDDoctor.RoomGroup = oReader.GetString("ROOM_GRP");

            Room rm = new Room();
            rm.RoomID = oReader.GetString("ROOM_ID").ToString();
            oOPDDoctor.Room = rm;

            Department dept = new Department();
            dept.DepartmentID = oReader.GetString("DEPARTMENT");
            oOPDDoctor.Department = dept;
            oOPDDoctor.Unit = oReader.GetString("UNIT");

            Doctor doc = new Doctor();
            doc.ID = oReader.GetString("DOC_ID");
            doc.Name = oReader.GetString("DOCTORNAME");
            oOPDDoctor.Doctor = doc;

            return oOPDDoctor;
        }
    }
}
