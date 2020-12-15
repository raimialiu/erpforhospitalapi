using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class IdGeneration
    {
        public int Id { get; set; }
        public string Lastcode { get; set; }
        public string Startvalue { get; set; }
        public string Endvalue { get; set; }
        public string Sequence { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
    }
}
