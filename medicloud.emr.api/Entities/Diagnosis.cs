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

        public int diagnosisid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string diseasecode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? subgroupid { get; set; }
        public int? ProviderID { get; set; }
        public int? groupid { get; set; }
        public int? locationid { get; set; }
        public int? diseaseid { get; set; }
        public int? encodedby { get; set; }
        public bool isactive { get; set; }
        public string ICDCode { get; set; }
        public DateTime? encodeddate { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<DiagnosisUtilization> DiagnosisUtilization { get; set; }
    }
}
