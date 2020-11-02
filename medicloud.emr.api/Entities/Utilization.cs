using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Utilization
    {
        public Utilization()
        {
            CaseNote = new HashSet<CaseNote>();
            DiagnosisUtilization = new HashSet<DiagnosisUtilization>();
            DrugDispense = new HashSet<DrugDispense>();
        }

        public int Id { get; set; }
        public int? Enrolleeid { get; set; }
        public string Respiration { get; set; }
        public string Pulse { get; set; }
        public string Temprature { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Bloodpressure { get; set; }
        public DateTime? Encounterdate { get; set; }
        public string Visitoutcome { get; set; }
        public DateTime? DateDied { get; set; }
        public bool? IsReferred { get; set; }
        public int? ReferredFrom { get; set; }
        public int? ReferredTo { get; set; }
        public int? DiagnosisId { get; set; }
        public string TestingDoctor { get; set; }
        public DateTime? VisitInfoEncounterDate { get; set; }
        public string Note { get; set; }
        public bool? IsNewBorn { get; set; }
        public bool? Isinpatient { get; set; }
        public DateTime? Dischargeddate { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncAt { get; set; }
        public int? Userid { get; set; }
        public bool? Isvisitscheduled { get; set; }
        public string VisiType { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Enrollee Enrollee { get; set; }
        public virtual Provider ReferredFromNavigation { get; set; }
        public virtual Provider ReferredToNavigation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CaseNote> CaseNote { get; set; }
        public virtual ICollection<DiagnosisUtilization> DiagnosisUtilization { get; set; }
        public virtual ICollection<DrugDispense> DrugDispense { get; set; }
    }
}
