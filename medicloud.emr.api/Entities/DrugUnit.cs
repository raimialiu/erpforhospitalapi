using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugUnit
    {
        public int UnitId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isvolumeunit { get; set; }
    }
}
