using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.HR.DAL;
using AH.Shared.MODEL;

namespace AH.HR.BLL
{
    public class AppointmentSetupBLL
    {
        public short SaveAppointmentSetup(Appointment oAppointment)
        {
            return new AppointmentSetupDAL().SaveAppointmentSetup(oAppointment);
        }
        public short UpdateAppointmentSetup(Appointment oAppointment)
        {
            return new AppointmentSetupDAL().UpdateAppointmentSetup(oAppointment);
        }
        public List<Appointment> GetAppointmentSetup(string ReffNumber)
        {
            return new AppointmentSetupDAL().GetAppointmentSetup(ReffNumber);
        }
        public List<AppointmentRO> GetAppointmentLetter(string ReffNumber)
        {
            return new AppointmentSetupDAL().GetAppointmentLetter(ReffNumber);
        }
    }
}
