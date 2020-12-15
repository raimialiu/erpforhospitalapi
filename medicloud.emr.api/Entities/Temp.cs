using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Temp
    {
        public string DiagnosisCode { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string NfExcl { get; set; }
    }
}
