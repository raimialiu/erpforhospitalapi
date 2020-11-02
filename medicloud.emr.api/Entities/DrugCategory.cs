using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugCategory
    {
        public DrugCategory()
        {
            Drug = new HashSet<Drug>();
        }

        public int Drugcategoryid { get; set; }
        public string Drugcategory1 { get; set; }
        public string Categorydesc { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Drug> Drug { get; set; }
    }
}
