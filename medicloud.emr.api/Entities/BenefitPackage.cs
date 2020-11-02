using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class BenefitPackage
    {
        public BenefitPackage()
        {
            QueueManager = new HashSet<QueueManager>();
        }

        public int Benpackageid { get; set; }
        public string Packagename { get; set; }
        public string Packagedesc { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<QueueManager> QueueManager { get; set; }
    }
}
