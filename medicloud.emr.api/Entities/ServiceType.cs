using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            Service = new HashSet<Service>();
        }

        public int Servicetypeid { get; set; }
        public string Servicetypedesc { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Service> Service { get; set; }
    }
}
