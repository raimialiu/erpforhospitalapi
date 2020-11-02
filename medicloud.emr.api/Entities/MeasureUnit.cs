using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class MeasureUnit
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public int? Freqvalue { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
