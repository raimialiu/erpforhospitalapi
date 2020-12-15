using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AccesscontrolUser
    {
        public int AccessControlId { get; set; }
        public int UserId { get; set; }

        public virtual AccessControl AccessControl { get; set; }
        public virtual User User { get; set; }
    }
}
