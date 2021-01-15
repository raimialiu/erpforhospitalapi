using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateDischargedplan
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Paediatrician { get; set; }
        public string Sourceofinformation { get; set; }
        public string Ishomemedicalequipmentanticipated { get; set; }
        public string Anyotherneedsanticipated { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
