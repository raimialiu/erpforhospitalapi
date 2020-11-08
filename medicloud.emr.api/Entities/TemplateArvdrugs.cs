using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateArvdrugs
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Regimen { get; set; }
        public string Adherence { get; set; }
        public string Whypoorfairadherence1 { get; set; }
        public string Otherspleasespecify { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
