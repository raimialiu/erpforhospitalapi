using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Fingerprint
    {
        public int Id { get; set; }
        public string Index { get; set; }
        public byte[] Image { get; set; }
        public int? Quality { get; set; }
        public byte[] Wsqformat { get; set; }
        public string Fingername { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Patientid { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
