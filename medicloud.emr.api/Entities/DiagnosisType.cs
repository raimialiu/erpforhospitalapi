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
        public bool description { get; set; }
        public string isactive { get; set; }
    }
}
