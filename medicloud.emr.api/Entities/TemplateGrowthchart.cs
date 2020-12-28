using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateGrowthchart
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Date { get; set; }
        public string Dayoflifeandpostmensturalage { get; set; }
        public string Number1 { get; set; }
        public string Length { get; set; }
        public string Textfield2 { get; set; }
        public string Bu1 { get; set; }
        public string Albumin { get; set; }
        public string Alkalinephosphatase { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
