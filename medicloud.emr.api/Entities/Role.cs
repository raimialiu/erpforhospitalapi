using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Role
    {
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int Roleid { get; set; }
        public string Rolename { get; set; }
        public string Roledescription { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
