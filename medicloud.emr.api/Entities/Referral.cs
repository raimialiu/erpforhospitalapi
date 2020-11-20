using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Referral
    {
        public Referral()
        {
            AppointmentSchedule = new HashSet<AppointmentSchedule>();
            Patient = new HashSet<Patient>();
        }

        public int Refid { get; set; }
        public string Reftype { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<AppointmentSchedule> AppointmentSchedule { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
