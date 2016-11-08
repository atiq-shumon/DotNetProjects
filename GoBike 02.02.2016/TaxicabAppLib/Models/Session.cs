using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCabAppLib.Models
{
    public class Session
    {
        public string UserName { set; get; }
        public string SessionID { set; get; }
        public Int32 LogInID { set; get; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public char HasCreditCardInfo { get; set; }

    }
}
