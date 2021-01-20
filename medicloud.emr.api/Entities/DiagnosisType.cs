using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class DiagnosisType
    {
        public int typeid { get; set; }
        public int? ProviderId { get; set; }
        public int? encodedby { get; set; }
        public DateTime? encodeddate { get; set; }
        public string description { get; set; }
        public bool isactive { get; set; }
    }
}
