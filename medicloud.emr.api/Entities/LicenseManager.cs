using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class LicenseManager
    {
        public Guid LicenseKey { get; set; }
        public DateTime? LicenseStart { get; set; }
        public DateTime? LicenseEnd { get; set; }
        public int? RecordLimit { get; set; }
        public bool? IsFirstTimeLogin { get; set; }
        public DateTime? LogDate { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
    }
}
