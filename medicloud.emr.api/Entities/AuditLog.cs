using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AuditLog
    {
        public int Auditlogid { get; set; }
        public string Systemid { get; set; }
        public string Actionperformed { get; set; }
        public string Formaccessed { get; set; }
        public string Modulename { get; set; }
        public int? Userid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual Personnel User { get; set; }
    }
}
