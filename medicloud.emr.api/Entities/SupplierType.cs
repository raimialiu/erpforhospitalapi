using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class SupplierType
    {
        public SupplierType()
        {
            Supplier = new HashSet<Supplier>();
        }

        public int Suppliertypeid { get; set; }
        public string Supplierdesc { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
