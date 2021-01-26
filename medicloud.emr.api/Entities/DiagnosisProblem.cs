using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class DiagnosisProblems
    {
        public int Id { get; set; }
        public int? ProviderID { get; set; }
        public int? encodedby { get; set; }
        public int? lastchangeby { get; set; }
        public int? sequenceno { get; set; }
        public string description { get; set; }
        public DateTime? encodeddate { get; set; }
        public DateTime? lastchangeddate { get; set; }
    }
}
