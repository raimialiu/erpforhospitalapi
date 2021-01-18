using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class BloodGroup
    {
        public BloodGroup()
        {
            Patient = new HashSet<Patient>();
        }

        public int Bloodgroupid { get; set; }
        public string Bloodgroupname { get; set; }
        public DateTime Dateadded { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
