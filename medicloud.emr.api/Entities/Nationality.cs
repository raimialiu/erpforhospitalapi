using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Nationality
    {
        public int Nationalityid { get; set; }
        public string Nationalityname { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
