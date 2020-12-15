using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Bed
    {
        public Bed()
        {
            Admission = new HashSet<Admission>();
        }

        public int Bedid { get; set; }
        public string Bednumber { get; set; }
        public int? Wardid { get; set; }
        public string Description { get; set; }
        public int? ProviderId { get; set; }
        public string Bedname { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual Ward Ward { get; set; }
        public virtual ICollection<Admission> Admission { get; set; }
    }
}
