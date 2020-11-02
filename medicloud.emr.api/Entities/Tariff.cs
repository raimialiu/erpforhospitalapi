using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Tariff
    {
        public Tariff()
        {
            Bill = new HashSet<Bill>();
            ServiceTariff = new HashSet<ServiceTariff>();
        }

        public int Tariffid { get; set; }
        public string Tariffname { get; set; }
        public string Tariffdesc { get; set; }
        public DateTime? Expirydate { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual ICollection<ServiceTariff> ServiceTariff { get; set; }
    }
}
