using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class UserLocation
    {
        public int Userlocationid { get; set; }
        public int? Userid { get; set; }
        public int? Locationid { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Location Location { get; set; }
        public virtual AppUser User { get; set; }
    }
}
