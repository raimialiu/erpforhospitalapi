using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class HmoType
    {
        public HmoType()
        {
            Hmo = new HashSet<Hmo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Dateadded { get; set; }
        public bool? IsActive { get; set; }
        public int? Providerid { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<Hmo> Hmo { get; set; }
    }
}
