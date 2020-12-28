using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePainreassessmentadult8yrsabove
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Painscore { get; set; }
        public string Actions { get; set; }
        public string Interventions { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
