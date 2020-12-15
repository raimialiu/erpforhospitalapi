using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Specialization
    {
        public Specialization()
        {
            AppointmentSchedule = new HashSet<AppointmentSchedule>();
            ProviderSchedule = new HashSet<ProviderSchedule>();
            SpecializationSchedule = new HashSet<SpecializationSchedule>();
        }

        public int Specid { get; set; }
        public string Specname { get; set; }
        public DateTime Dateadded { get; set; }
        public int? Locationid { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<AppointmentSchedule> AppointmentSchedule { get; set; }
        public virtual ICollection<ProviderSchedule> ProviderSchedule { get; set; }
        public virtual ICollection<SpecializationSchedule> SpecializationSchedule { get; set; }
    }
}
