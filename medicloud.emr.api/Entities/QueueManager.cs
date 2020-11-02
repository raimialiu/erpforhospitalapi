using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class QueueManager
    {
        public int ListId { get; set; }
        public string Patientid { get; set; }
        public int? FromPersonnelid { get; set; }
        public int? Deptid { get; set; }
        public bool? IsSeen { get; set; }
        public bool? IsRemoved { get; set; }
        public int? RemovedBy { get; set; }
        public int? ProviderId { get; set; }
        public int? Benpackageid { get; set; }
        public int? ToPersonnelid { get; set; }
        public DateTime? Dateadded { get; set; }
        public bool? Isflagged { get; set; }

        public virtual BenefitPackage Benpackage { get; set; }
        public virtual Department Dept { get; set; }
        public virtual Personnel FromPersonnel { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel RemovedByNavigation { get; set; }
        public virtual Personnel ToPersonnel { get; set; }
    }
}
