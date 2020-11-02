using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AppUser
    {
        public AppUser()
        {
            UserLocation = new HashSet<UserLocation>();
            UserRole = new HashSet<UserRole>();
        }

        public int Userid { get; set; }
        public int? Titleid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Secretquestion { get; set; }
        public string Secretanswer { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual Title Title { get; set; }
        public virtual ICollection<UserLocation> UserLocation { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
