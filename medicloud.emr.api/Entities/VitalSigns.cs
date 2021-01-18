using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.Entities
{
    public partial class VitalSigns
    {
        [Key]
        public int Vitalid { get; set; }
        public string Patientid { get; set; }
        public int? Staffid { get; set; }
        public string Temperature { get; set; }
        public string Pulse { get; set; }
        public string Weight { get; set; }
        public string Bloodpressure { get; set; }
        public string Height { get; set; }
        public string Respiration { get; set; }
        public string Comments { get; set; }
        public bool? Isfileattached { get; set; }
        public string Docname { get; set; }
        public string Docpath { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Staff { get; set; }
    }
}
