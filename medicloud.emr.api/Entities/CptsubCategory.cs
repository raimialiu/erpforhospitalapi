using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class CptsubCategory
    {
        public CptsubCategory()
        {
            Cptprocedure = new HashSet<Cptprocedure>();
        }

        public int Cptsubcategoryid { get; set; }
        public string Cptsubcategoryname { get; set; }
        public string Cptcategorydesc { get; set; }
        public int? Cptcategoryid { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Cptcategory Cptcategory { get; set; }
        public virtual ICollection<Cptprocedure> Cptprocedure { get; set; }
    }
}
