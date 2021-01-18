using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugRoute
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public string Description { get; set; }
        public int? SequenceNo { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Isactive { get; set; }
        public int? EncodedBy { get; set; }
        public DateTime? Encodeddate { get; set; }
    }
}
