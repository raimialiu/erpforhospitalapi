using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateGastrointestinalsystem
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Anyabnormalmasses { get; set; }
        public string Anypreviousscar { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
