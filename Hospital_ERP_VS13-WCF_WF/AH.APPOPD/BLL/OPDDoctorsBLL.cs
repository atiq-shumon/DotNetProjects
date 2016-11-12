using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.APPOPD.MODEL;
using AH.APPOPD.DAL;

namespace AH.APPOPD.BLL
{
    public class OPDDoctorsBLL
    {
        public List<OPDDoctor> GetOPDDoctors()
        {
            return new OPDDoctorsDAL().GetOPDDoctors();
        }
    }
}
