using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AppointmentStatus
    {
        public int Statusid { get; set; }
        public string Statusname { get; set; }
        public string Statuscolor { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
