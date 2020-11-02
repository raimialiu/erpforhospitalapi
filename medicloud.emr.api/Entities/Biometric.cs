using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Biometric
    {
        public int Biometricid { get; set; }
        public string Patientid { get; set; }
        public string Fingerindex { get; set; }
        public string Fingertemplate { get; set; }
        public string Quality { get; set; }
        public string Wsqformat { get; set; }
        public string Fingername { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
