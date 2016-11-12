﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class ServiceProviderSCM
    {
        public string ID = "";
        public string ServiceProviderName = "";
        public string Address = "";
        public string Web = "";
        public string Phone = "";
        public string Fax = "";
        public string Email = "";
        public string ContactPerson = "";
        public string Acccode = "";
        public string Remarks = "";
        public string Priority = "";
        public string Active = "";
        public string itemId = "";
        public string itemName = "";
        public string expectedReturnDate = "";
        public string servicedate = "";
        public string returndate = "";



        public EntryParameter EntryParameter { set; get; }

    }
}
