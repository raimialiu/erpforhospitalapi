using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePrimaryexaminationdetails
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Generalcondition { get; set; }
        public string Cns { get; set; }
        public string Chest { get; set; }
        public string Cvs { get; set; }
        public string Abdomen { get; set; }
        public string Pelvis { get; set; }
        public string Mss { get; set; }
        public string Breasts { get; set; }
        public string Otherrelevantabnormalities { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
