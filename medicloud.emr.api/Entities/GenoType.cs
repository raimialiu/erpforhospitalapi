using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class GenoType
    {
        public GenoType()
        {
            Patient = new HashSet<Patient>();
        }

        public int Genotypeid { get; set; }
        public string Genotypename { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
