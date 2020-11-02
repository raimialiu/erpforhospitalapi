using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugUtilization
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int DiagnosisId { get; set; }
        public string Dose { get; set; }
        public int? Quantity { get; set; }
        public string Frequency { get; set; }
        public string Duration { get; set; }
        public string Deseunit { get; set; }
        public decimal? Cost { get; set; }
        public string Paymenttype { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Isdispensed { get; set; }
        public bool? Isclaimsgenerated { get; set; }

        public virtual DiagnosisUtilization Diagnosis { get; set; }
    }
}
