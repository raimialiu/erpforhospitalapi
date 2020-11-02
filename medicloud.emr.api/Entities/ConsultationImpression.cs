using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationImpression
    {
        public int Txnkey { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public string Impressioncode { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }
    }
}
