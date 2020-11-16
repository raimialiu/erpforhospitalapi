using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateLaboratory1
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Nutritioncounselling { get; set; }
        public string Nutritioneducaion { get; set; }
        public string Columns { get; set; }
        public string Coordinationofnutritioncare { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
