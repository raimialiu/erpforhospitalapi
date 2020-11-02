using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class UserRole
    {
        public int Userroleid { get; set; }
        public int? Userid { get; set; }
        public int? Roleid { get; set; }
        public string Permission { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Role Role { get; set; }
        public virtual AppUser User { get; set; }
    }
}
