using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class NursingRecord
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int? ProviderId { get; set; }
        public int? Consultationid { get; set; }
        public int? Categoryid { get; set; }
        public string Record { get; set; }
        public string Details { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
