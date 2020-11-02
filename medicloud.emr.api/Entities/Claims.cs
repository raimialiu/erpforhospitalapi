using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Claims
    {
        public int Id { get; set; }
        public int? Enrolleeid { get; set; }
        public int? Userid { get; set; }
        public int? DiagnosisId { get; set; }
        public string Hmonumber { get; set; }
        public string Code { get; set; }
        public DateTime? Treatmentstartdate { get; set; }
        public DateTime? Treatmentenddate { get; set; }
        public decimal? Amountbilled { get; set; }
        public string Diagnosiscode { get; set; }
        public string Claimtype { get; set; }
        public bool? IsClaimExported { get; set; }
        public string Syncid { get; set; }
        public string Flag { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Panumber { get; set; }
        public string Patienttype { get; set; }
        public string Comment { get; set; }
        public int? ProviderId { get; set; }

        public virtual DiagnosisUtilization Diagnosis { get; set; }
        public virtual Enrollee Enrollee { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual User User { get; set; }
    }
}
