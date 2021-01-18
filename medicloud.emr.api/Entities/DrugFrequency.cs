using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugFrequency
    {
        public int FrequencyId { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public decimal? Frequency { get; set; }
        public int? Sequence { get; set; }
        public bool? IsActive { get; set; }
        public bool? CommonFrequency { get; set; }
        public bool? IsTimingRequired { get; set; }
    }
}
