using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACMS.MODEL
{
    public class User
    {
        public string  EmpID { get; set; }
        public Department Department { set; get; }
        public Designation Designation { get; set; }
        public DepartmentUnit DepartmentUnit { get; set; }
        public string  UserPassw  { get; set; }
        public string  PinCode  { get; set; }
        public string  Email { get; set; }
        public string  LockedStatus { get; set; }
        public string  AutoLogOut { get; set; }
        public string  ActiveDate  { get; set; }
        public string  ValidUpto   { get; set; }   
        public string  Remarks   { get; set; }
        public string LoginAs { get; set; }
        public string PhotoPath { get; set; }
        public SecurityQuestion SecurityQuestion { set; get; }
        public UserGroup UserGroup { set; get; }
        public string NickName { get; set; }
        public Module Module { get; set; }
        public EntryParameter EntryParameter { get; set; }
    }
}

