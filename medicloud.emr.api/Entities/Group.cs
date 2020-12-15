using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Group
    {
        public Group()
        {
            Division = new HashSet<Division>();
            Enrollee = new HashSet<Enrollee>();
        }

        public int Id { get; set; }
        public string Scheme { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public DateTime? Contractstart { get; set; }
        public DateTime? Contractend { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Shortname { get; set; }

        public virtual ICollection<Division> Division { get; set; }
        public virtual ICollection<Enrollee> Enrollee { get; set; }
    }
}
