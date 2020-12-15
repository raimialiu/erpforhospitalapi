using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AppointmentStatus
    {
        public AppointmentStatus()
        {
            AppointmentSchedule = new HashSet<AppointmentSchedule>();
        }

        public int Statusid { get; set; }
        public string Statusname { get; set; }
        public string Statuscolor { get; set; }
        public DateTime Dateadded { get; set; }

        public virtual ICollection<AppointmentSchedule> AppointmentSchedule { get; set; }
    }
}
