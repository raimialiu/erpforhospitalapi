using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.Entities
{
    public partial class VerificationLog
    {
        [Key]
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int? Userid { get; set; }
        public string Mode { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Isseen { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual User User { get; set; }
    }
}
