using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ProcedureUtilization
    {
        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public int? ProcedureId { get; set; }
        public decimal? Cost { get; set; }
        public string Paymenttype { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Isclaimsgenerated { get; set; }

        public virtual DiagnosisUtilization Diagnosis { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}
