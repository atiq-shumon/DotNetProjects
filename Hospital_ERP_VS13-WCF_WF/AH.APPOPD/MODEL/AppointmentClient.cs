using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.APPOPD.MODEL
{
    public class AppointmentClient
    {
        public Patient Patient { set; get; }
        public string BookedBy { get; set; }
        public string ClientId { get; set; }
        public string AllowAutoNotification { set; get; }
        public EntryParameter EntryParameter { get; set; }
    }
}
