using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class DiagnosisLocation
    {
        public int diagnosislocationid { get; set; }
        public string diagnosislocationname { get; set; }
        public DateTime? dateadded { get; set; }
    }
}
