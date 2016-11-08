using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TaxiCabAppLib.Models
{
    public class Customer
    {

        public string ID { set; get; }
        public LogIn LogIn { set; get; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NID { get; set; }
        public string CellPhone { get; set; }
        public Address Address { get; set; }
        
    }
}