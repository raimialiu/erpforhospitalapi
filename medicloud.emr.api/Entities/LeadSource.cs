using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class LeadSource
    {
        public LeadSource()
        {
            Patient = new HashSet<Patient>();
        }

        public int Leadid { get; set; }
        public string Leadname { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
