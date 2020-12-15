using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class CaseNote
    {
        public int Id { get; set; }
        public string Complaints { get; set; }
        public string HistoryOfPresentingComplaints { get; set; }
        public string PastMedicalAndDrugHistory { get; set; }
        public string FamilyAndSocialHistory { get; set; }
        public string General { get; set; }
        public string Cardiovascular { get; set; }
        public string Respiratory { get; set; }
        public string GastroIntestinal { get; set; }
        public string CentralNervousSystem { get; set; }
        public string MusculoSkeletal { get; set; }
        public string Reproductive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UtilizationId { get; set; }
        public int? UserId { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual User User { get; set; }
        public virtual Utilization Utilization { get; set; }
    }
}
