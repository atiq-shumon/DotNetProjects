using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.DMS.MODEL
{
    public class Admission
    {
        public DepartmentGroup DepartmentGroup { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public Doctor Doctor { set; get; }
        public string FloorNo { set; get; }
        public string RoomID { set; get; }
        public string BedTypeID { set; get; }
        public string BedCategoryTypeID { set; get; }
        public string BedNo { set; get; }
    }
}
