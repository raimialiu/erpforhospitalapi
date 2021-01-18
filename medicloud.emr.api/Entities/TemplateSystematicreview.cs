using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSystematicreview
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Respiratory1 { get; set; }
        public string Smoker { get; set; }
        public string Respiratory { get; set; }
        public string Cns { get; set; }
        public string Circulatory { get; set; }
        public string Metabolic { get; set; }
        public string Gastrointestinal { get; set; }
        public string Bleedingtendency { get; set; }
        public string Previousga { get; set; }
        public string Dental { get; set; }
        public string Hiatusherrica { get; set; }
        public string Alcoholweeklyunite { get; set; }
        public string Femaleslmp { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
