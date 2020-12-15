using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationChecks
    {
        public ConsultationChecks()
        {
            ConsultationCheckslist = new HashSet<ConsultationCheckslist>();
        }

        public int Id { get; set; }
        public string Ccname { get; set; }
        public string FilterCategory { get; set; }
        public string Datecreated { get; set; }

        public virtual ICollection<ConsultationCheckslist> ConsultationCheckslist { get; set; }
    }
}
