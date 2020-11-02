using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ProviderChange
    {
        public int Id { get; set; }
        public string Oldprovider { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Sequence { get; set; }
        public string Reason { get; set; }
        public DateTime? Providereffectivedate { get; set; }
        public DateTime? Providerterminationdate { get; set; }
        public int? EnrolleeId { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncedAt { get; set; }
        public int? Userid { get; set; }

        public virtual Enrollee Enrollee { get; set; }
        public virtual User User { get; set; }
    }
}
