using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Cptprocedure
    {
        public int Serial { get; set; }
        public string Cptcode { get; set; }
        public string Cptdescription { get; set; }
        public int? Cptcategoryid { get; set; }
        public int? Cptsubcategoryid { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Cptcategory Cptcategory { get; set; }
        public virtual CptsubCategory Cptsubcategory { get; set; }
    }
}
