using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Service
    {
        public Service()
        {
            ServiceTariff = new HashSet<ServiceTariff>();
        }

        public int Serviceid { get; set; }
        public string Servicedesc { get; set; }
        public int? Deptid { get; set; }
        public int? Servicetypeid { get; set; }
        public string Servicecode { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual ServiceType Servicetype { get; set; }
        public virtual ICollection<ServiceTariff> ServiceTariff { get; set; }
    }
}
