using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateDischargenotes
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Weightatdischarge { get; set; }
        public string Feedingmethod { get; set; }
        public string Investigationenclosed { get; set; }
        public string Consultationandreferrals { get; set; }
        public string Courseinthehospital { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
