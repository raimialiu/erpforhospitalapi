using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class GeneralSchedule
    {
        public int Genschid { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public int Timeinterval { get; set; }
        public string Adjuster { get; set; }
        public bool Iscurrent { get; set; }
        public DateTime Dateadded { get; set; }
        public int? Locationid { get; set; }

        public virtual Location Location { get; set; }
    }
}
