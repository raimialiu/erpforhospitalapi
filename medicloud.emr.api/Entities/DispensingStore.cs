using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DispensingStore
    {
        public int Dispensingstoreid { get; set; }
        public int? Drugid { get; set; }
        public int? ReorderLevel { get; set; }
        public DateTime? Stockdate { get; set; }
        public DateTime? Manufacturedate { get; set; }
        public int? ProviderId { get; set; }
        public DateTime? Expirydate { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Description { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
