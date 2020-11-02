using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class HealthCareFacilitator
    {
        public HealthCareFacilitator()
        {
            Patient = new HashSet<Patient>();
        }

        public int Facilitatorid { get; set; }
        public string Facilitatorname { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
