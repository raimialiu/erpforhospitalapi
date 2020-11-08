using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateBloodgasanalysisform
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Sampletype { get; set; }
        public string Na { get; set; }
        public string K { get; set; }
        public string Cl { get; set; }
        public string Tco2 { get; set; }
        public string Bun { get; set; }
        public string Glu { get; set; }
        public string Hct { get; set; }
        public string Hb { get; set; }
        public string Ph { get; set; }
        public string Pco2 { get; set; }
        public string Po2 { get; set; }
        public string Po2fio2 { get; set; }
        public string So2 { get; set; }
        public string Hco3 { get; set; }
        public string Beecf { get; set; }
        public string Angap { get; set; }
        public string Lac { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
