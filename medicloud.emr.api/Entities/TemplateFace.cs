using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateFace
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Eyes { get; set; }
        public string Ears { get; set; }
        public string Nose { get; set; }
        public string Mouth { get; set; }
        public string Palate { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
