using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Title
    {
        public Title()
        {
            AppUser = new HashSet<AppUser>();
            Personnel = new HashSet<Personnel>();
        }

        public int Titleid { get; set; }
        public string Titlename { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
