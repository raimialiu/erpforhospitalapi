using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSystemexamination
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Respiratorysystem { get; set; }
        public string Peripheralpulses { get; set; }
        public string Heartsounds { get; set; }
        public string Murmur { get; set; }
        public string Organeomegaly { get; set; }
        public string Ascites { get; set; }
        public string Dilatedveinsonabdomen { get; set; }
        public string Highermentalfunctions { get; set; }
        public string Cns { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
