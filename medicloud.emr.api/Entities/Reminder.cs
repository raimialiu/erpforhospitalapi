using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Reminder
    {
        public Reminder()
        {
            AppointmentSchedule = new HashSet<AppointmentSchedule>();
        }

        public int Reminderid { get; set; }
        public string Reminder1 { get; set; }
        public DateTime Dateadded { get; set; }

        public virtual ICollection<AppointmentSchedule> AppointmentSchedule { get; set; }
    }
}
