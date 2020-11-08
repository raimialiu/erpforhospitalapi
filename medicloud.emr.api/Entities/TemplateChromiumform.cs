using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateChromiumform
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
