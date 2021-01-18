using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateGeneralcondition
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Colour { get; set; }
        public string Cry { get; set; }
        public string Activity { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
