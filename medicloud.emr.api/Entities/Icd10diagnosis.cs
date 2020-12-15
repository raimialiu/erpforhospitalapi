using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Icd10diagnosis
    {
        public int Serial { get; set; }
        public string Diagnosiscode { get; set; }
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public string Comments { get; set; }
        public int? Icdcategoryid { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Icdcategory Icdcategory { get; set; }
    }
}
