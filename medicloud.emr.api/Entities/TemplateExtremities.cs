using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateExtremities
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Arms { get; set; }
        public string Hands { get; set; }
        public string Legs { get; set; }
        public string Feet { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
