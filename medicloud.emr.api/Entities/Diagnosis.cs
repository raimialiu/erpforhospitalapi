using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Diagnosis
    {
        public Diagnosis()
        {
            DiagnosisUtilization = new HashSet<DiagnosisUtilization>();
            PaRequest = new HashSet<PaRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Comments { get; set; }
        public int? Genderconstraint { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<DiagnosisUtilization> DiagnosisUtilization { get; set; }
        public virtual ICollection<PaRequest> PaRequest { get; set; }
    }
}
