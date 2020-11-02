using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Transportation
    {
        public int Id { get; set; }
        public decimal? Cost { get; set; }
        public string Preauth { get; set; }
        public bool? Isclaimsgenerated { get; set; }
        public int? DiagnosisId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual DiagnosisUtilization Diagnosis { get; set; }
    }
}
