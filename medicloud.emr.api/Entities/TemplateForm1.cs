using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateForm1
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Test { get; set; }
        public string Submit { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
