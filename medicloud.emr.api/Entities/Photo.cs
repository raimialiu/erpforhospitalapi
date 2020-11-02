using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Patientid { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncAt { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
