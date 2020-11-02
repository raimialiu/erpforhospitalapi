using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class GeneralExamination
    {
        public int Examid { get; set; }
        public string Examdescription { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
