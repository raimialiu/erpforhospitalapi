using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class NextOfKinRelationship
    {
        public int Nokid { get; set; }
        public string Noktype { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
