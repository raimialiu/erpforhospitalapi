using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateProvisionaldiagnosis
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Investigation { get; set; }
        public string Labs { get; set; }
        public string Radiology { get; set; }
        public string Cardiology { get; set; }
        public string Others { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
