using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class EnrolleeType
    {
        public EnrolleeType()
        {
            Enrollee = new HashSet<Enrollee>();
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<Enrollee> Enrollee { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
