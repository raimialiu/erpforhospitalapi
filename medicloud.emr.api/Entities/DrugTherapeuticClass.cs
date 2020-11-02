using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugTherapeuticClass
    {
        public int Classid { get; set; }
        public string Therapeuticdesc { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
