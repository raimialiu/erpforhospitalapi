using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Division
    {
        public Division()
        {
            Enrollee = new HashSet<Enrollee>();
        }

        public int Id { get; set; }
        public int? Groupid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Shortname { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Enrollee> Enrollee { get; set; }
    }
}
