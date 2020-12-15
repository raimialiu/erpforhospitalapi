using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationUtilization
    {
        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public int? ConsultationId { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Isclaimsgenerated { get; set; }
        public int? ProviderId { get; set; }

        public virtual DiagnosisUtilization Diagnosis { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
