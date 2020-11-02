using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DataSynchronization
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Userid { get; set; }

        public virtual User User { get; set; }
    }
}
