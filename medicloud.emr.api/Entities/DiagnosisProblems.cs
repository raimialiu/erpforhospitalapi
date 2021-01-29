using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DiagnosisProblems
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string Description { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangeddate { get; set; }
        public int? Sequenceno { get; set; }
    }
}
