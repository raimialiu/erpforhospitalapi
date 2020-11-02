using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DiagnosisUtilization
    {
        public DiagnosisUtilization()
        {
            Claims = new HashSet<Claims>();
            ConsultationUtilization = new HashSet<ConsultationUtilization>();
            DrugUtilization = new HashSet<DrugUtilization>();
            ProcedureUtilization = new HashSet<ProcedureUtilization>();
            Transportation = new HashSet<Transportation>();
        }

        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public int UtilizationId { get; set; }
        public string VisiType { get; set; }
        public int? Diagsequence { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Diagnosis Diagnosis { get; set; }
        public virtual Utilization Utilization { get; set; }
        public virtual ICollection<Claims> Claims { get; set; }
        public virtual ICollection<ConsultationUtilization> ConsultationUtilization { get; set; }
        public virtual ICollection<DrugUtilization> DrugUtilization { get; set; }
        public virtual ICollection<ProcedureUtilization> ProcedureUtilization { get; set; }
        public virtual ICollection<Transportation> Transportation { get; set; }
    }
}
