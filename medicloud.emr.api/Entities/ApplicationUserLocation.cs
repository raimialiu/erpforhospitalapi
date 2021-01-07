using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class ApplicationUserLocation
    {
        public int appuserlocationid { get; set; }
        public int appuserid { get; set; }
        public int specid { get; set; }
        public int locationid { get; set; }
    }
}
