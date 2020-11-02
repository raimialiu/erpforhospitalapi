using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Sponsor
    {
        public Sponsor()
        {
            Patient = new HashSet<Patient>();
        }

        public int Sponsid { get; set; }
        public string Sponsortype { get; set; }
        public string Dateadded { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
