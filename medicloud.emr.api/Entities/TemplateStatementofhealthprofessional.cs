using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateStatementofhealthprofessional
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Theintendedbenefits { get; set; }
        public string Seriousorfrequentlyoccuringrisks { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
