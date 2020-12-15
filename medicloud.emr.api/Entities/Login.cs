using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid? AccountId { get; set; }
        public bool? IsNewUser { get; set; }
        public DateTime? LogDate { get; set; }
        public int? ProviderId { get; set; }
        public bool? IsLoggedIn { get; set; }

        public virtual AccountManager Provider { get; set; }
    }
}
