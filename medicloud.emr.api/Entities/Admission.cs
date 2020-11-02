using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Admission
    {
        public Admission()
        {
            AdmissionDiagnosis = new HashSet<AdmissionDiagnosis>();
        }

        public int AdmissionId { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public int? Staffid { get; set; }
        public string Complaints { get; set; }
        public string ClinicalSummary { get; set; }
        public int? Deptid { get; set; }
        public DateTime? Dateadmitted { get; set; }
        public int? Bedid { get; set; }
        public string Admissiontime { get; set; }
        public DateTime? Dischargedate { get; set; }
        public string Dischargetime { get; set; }
        public DateTime? Estimateddischarge { get; set; }
        public int? DischargedBy { get; set; }
        public int? ProviderId { get; set; }

        public virtual Bed Bed { get; set; }
        public virtual Department Dept { get; set; }
        public virtual Personnel DischargedByNavigation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Staff { get; set; }
        public virtual ICollection<AdmissionDiagnosis> AdmissionDiagnosis { get; set; }
    }
}
