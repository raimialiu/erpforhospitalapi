using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class IdentificationMode
    {
        public IdentificationMode()
        {
            AppUser = new HashSet<AppUser>();
            Personnel = new HashSet<Personnel>();
        }

        public int IdentificationModeid { get; set; }
        public string IdentificationModename { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
