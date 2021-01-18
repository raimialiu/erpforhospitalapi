using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class DiagnosisLocation
    {
        public int diagnosislocationid { get; set; }
        public int? groupid { get; set; }
        public int? subgroupid { get; set; }
        public int? diagnosis { get; set; }
        public int? ICDCode { get; set; }
        public int? location { get; set; }
        public int? type { get; set; }
        public int? condition { get; set; }
        public string remarks { get; set; }
        public DateTime? onsetdate { get; set; }
        public DateTime? Dateadded { get; set; }
        public bool isprimary { get; set; }
        public bool ischronic { get; set; }
        public bool isprovisional { get; set; }
        public bool isresolved { get; set; }
    }
}
