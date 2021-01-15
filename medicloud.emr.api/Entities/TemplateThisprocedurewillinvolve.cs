using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateThisprocedurewillinvolve
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Generalandregionalanaesthesia { get; set; }
        public string Generalandregionalanaesthesia1 { get; set; }
        public string Generalandregionalanaesthesia2 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
