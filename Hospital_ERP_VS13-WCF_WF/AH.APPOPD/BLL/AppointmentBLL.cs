using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.APPOPD.MODEL;
using AH.APPOPD.DAL;

namespace AH.APPOPD.BLL
{
    public class AppointmentBLL
    {
        public List<OpdAppointment> Appointment(string hcn)
        {
            return new AppointmentDAL().Appointment(hcn);
        }
        public List<OpdAppointment> GetPatientInfo(string deptId, string unitId, string doctorId, string tokenNo, string appointDate)
        {
            return new AppointmentDAL().GetPatientInfo(deptId, unitId, doctorId, tokenNo, appointDate);
        }
        public List<OpdAppointment> GetPatientListForHcn()
        {
            return new AppointmentDAL().GetPatientListForHcn();
        }
    }
}
