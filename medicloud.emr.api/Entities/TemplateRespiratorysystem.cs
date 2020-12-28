using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateRespiratorysystem
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Rr { get; set; }
        public string Breathsoundspresentbilaterally { get; set; }
        public string Anyabnormalbreathsounds { get; set; }
        public string Anychangeinthequalityofthebreathsounds { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
