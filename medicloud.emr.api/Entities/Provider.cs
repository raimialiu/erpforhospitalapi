using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Provider
    {
        public Provider()
        {
            ProviderNetwork = new HashSet<ProviderNetwork>();
            UtilizationReferredFromNavigation = new HashSet<Utilization>();
            UtilizationReferredToNavigation = new HashSet<Utilization>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tin { get; set; }
        public string Network { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Contactphone { get; set; }
        public string Contactname { get; set; }
        public string Contactemail { get; set; }
        public string Hmoproviderid { get; set; }
        public bool? Isreferral { get; set; }
        public string Accountnumber { get; set; }

        public virtual ICollection<ProviderNetwork> ProviderNetwork { get; set; }
        public virtual ICollection<Utilization> UtilizationReferredFromNavigation { get; set; }
        public virtual ICollection<Utilization> UtilizationReferredToNavigation { get; set; }
    }
}
