using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateChestasymmetry
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Respiratoryratemin { get; set; }
        public string Airentry { get; set; }
        public string Adventitioussounds { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
