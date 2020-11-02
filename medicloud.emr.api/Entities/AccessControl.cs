using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AccessControl
    {
        public AccessControl()
        {
            AccesscontrolUser = new HashSet<AccesscontrolUser>();
        }

        public int Id { get; set; }
        public string Modules { get; set; }
        public string Roles { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<AccesscontrolUser> AccesscontrolUser { get; set; }
    }
}
