using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Location
    {
        public Location()
        {
            Asset = new HashSet<Asset>();
            UserLocation = new HashSet<UserLocation>();
        }

        public int Locationid { get; set; }
        public string Locationname { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Comments { get; set; }
        public string Locationadmin { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Locationdescription { get; set; }

        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<UserLocation> UserLocation { get; set; }
    }
}
