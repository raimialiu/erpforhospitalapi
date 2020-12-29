using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateFamilyhistory
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Cardiacillness { get; set; }
        public string Hypertension { get; set; }
        public string Diabetesmellitus { get; set; }
        public string Bronchiaasthma { get; set; }
        public string Pulmonarytuberculosis { get; set; }
        public string Porphyna { get; set; }
        public string Dyscrasias { get; set; }
        public string Malignanthyperthermia { get; set; }
        public string Musculardystrophies { get; set; }
        public string Others { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
