using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Diagnosis
    {
        public Diagnosis()
        {
            DiagnosisUtilization = new HashSet<DiagnosisUtilization>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string patientid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Comments { get; set; }
        public int? Genderconstraint { get; set; }
        public int? ProviderID { get; set; }
        public int? hospitallocationid { get; set; }
        public int? encounterId { get; set; }
        public int? locationid { get; set; }
        public int? doctorid { get; set; }
        public int? encodedby { get; set; }
        public int? ICDId { get; set; }
        public bool primarydiagnosis { get; set; }
        public bool ischronic { get; set; }
        public bool isresolved { get; set; }
        public bool isactive { get; set; }
        public bool MRDCode { get; set; }
        public bool IsOTDiagnosis { get; set; }
        public string remarks { get; set; }
        public DateTime encodeddate { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<DiagnosisUtilization> DiagnosisUtilization { get; set; }
    }
}
