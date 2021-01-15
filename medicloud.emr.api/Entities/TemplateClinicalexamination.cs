using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateClinicalexamination
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Pulserate { get; set; }
        public string Bloodpressure { get; set; }
        public string Respiratorypressure { get; set; }
        public string Spo2 { get; set; }
        public string Jvp { get; set; }
        public string Peripheralpulses { get; set; }
        public string Jaundice { get; set; }
        public string Lymphnode { get; set; }
        public string Pedaledema { get; set; }
        public string Modifiedmallampaticlassification { get; set; }
        public string Loosetooth { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
