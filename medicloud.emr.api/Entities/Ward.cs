using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Ward
    {
        public Ward()
        {
            Bed = new HashSet<Bed>();
        }

        public int Wardid { get; set; }
        public string Wardname { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Bed> Bed { get; set; }
    }
}
