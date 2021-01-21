using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ChiefComplain
    {
        public int Id { get; set; }
        public int? Hospitallocationid { get; set; }
        public string Patientid { get; set; }
        public int? EncounterId { get; set; }
        public int? ProblemId { get; set; }
        public string Problemdescription { get; set; }
        public int? Locationid { get; set; }
        public int? ProviderId { get; set; }
        public int? Doctorid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public string Remarks { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
    }
}
