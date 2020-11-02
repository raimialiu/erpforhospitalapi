using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Icdcategory
    {
        public Icdcategory()
        {
            Icd10diagnosis = new HashSet<Icd10diagnosis>();
        }

        public int Icdcategoryid { get; set; }
        public string Icdcategoryname { get; set; }
        public string Icdcategorydesc { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Icd10diagnosis> Icd10diagnosis { get; set; }
    }
}
