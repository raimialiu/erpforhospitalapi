using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Designation
    {
        public Designation()
        {
            Personnel = new HashSet<Personnel>();
        }

        public int Desigid { get; set; }
        public string Designation1 { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
