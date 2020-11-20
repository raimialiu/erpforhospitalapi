using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ReferringPhysician
    {
        public ReferringPhysician()
        {
            AppointmentSchedule = new HashSet<AppointmentSchedule>();
        }

        public int Refid { get; set; }
        public string Physicianname { get; set; }
        public DateTime Dateadded { get; set; }

        public virtual ICollection<AppointmentSchedule> AppointmentSchedule { get; set; }
    }
}
