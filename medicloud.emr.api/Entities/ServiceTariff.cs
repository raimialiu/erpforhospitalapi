using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ServiceTariff
    {
        public int Servtariffid { get; set; }
        public int? Serviceid { get; set; }
        public int? Tariffid { get; set; }
        public double? Tariffamount { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual Service Service { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
