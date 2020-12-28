using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateHandedover
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Patientrecord { get; set; }
        public string Medication { get; set; }
        public string Valuable { get; set; }
        public string Diettransferred { get; set; }
        public string Xray { get; set; }
        public string Consent { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
