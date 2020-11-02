using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Cptcategory
    {
        public Cptcategory()
        {
            Cptprocedure = new HashSet<Cptprocedure>();
            CptsubCategory = new HashSet<CptsubCategory>();
        }

        public int Cptcategoryid { get; set; }
        public string Cptcategoryname { get; set; }
        public string Cptcategorydesc { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Cptprocedure> Cptprocedure { get; set; }
        public virtual ICollection<CptsubCategory> CptsubCategory { get; set; }
    }
}
