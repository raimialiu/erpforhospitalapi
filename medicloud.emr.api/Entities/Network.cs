using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Network
    {
        public Network()
        {
            Enrollee = new HashSet<Enrollee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Enrollee> Enrollee { get; set; }
    }
}
