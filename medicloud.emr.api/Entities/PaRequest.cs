using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class PaRequest
    {
        public int PARequestId { get; set; }
        public int AccountId { get; set; }
        public virtual AccountManager AccountManager { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public string PaStatus { get; set; }
        public string PaNumber { get; set; }
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
        public int DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public decimal UnitCharge { get; set; }
        public decimal Quantity { get; set; }
        public string IssuerComment { get; set; }
        public DateTime? RequestDate { get; set; }
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
