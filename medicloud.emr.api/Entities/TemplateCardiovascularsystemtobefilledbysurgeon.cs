using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateCardiovascularsystemtobefilledbysurgeon
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string H1 { get; set; }
        public string S1ands2 { get; set; }
        public string S1ands3 { get; set; }
        public string S1ands4 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
