using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class VisitType
    {
        public VisitType()
        {
            AppointmentSchedule = new HashSet<AppointmentSchedule>();
        }

        public int Typeid { get; set; }
        public string Typename { get; set; }
        public DateTime Dateadded { get; set; }

        public virtual ICollection<AppointmentSchedule> AppointmentSchedule { get; set; }
    }
}
