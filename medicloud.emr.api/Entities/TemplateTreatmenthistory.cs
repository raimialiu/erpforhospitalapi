using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateTreatmenthistory
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Cardiacmedications { get; set; }
        public string Respiratorymedications { get; set; }
        public string Gimedications { get; set; }
        public string Cns { get; set; }
        public string Anticoagulants { get; set; }
        public string Antiplatelets { get; set; }
        public string Antipsychiatric { get; set; }
        public string Antidiabetic { get; set; }
        public string Antithyroid { get; set; }
        public string Others { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
