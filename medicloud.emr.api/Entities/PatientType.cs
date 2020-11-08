using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class PatientType
    {
        public int PatienttypeId { get; set; }
        public string Name { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
