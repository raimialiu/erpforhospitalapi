using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class CentralStore
    {
        public int Centralstoreid { get; set; }
        public int? Drugid { get; set; }
        public string Drugcode { get; set; }
        public int? Packetno { get; set; }
        public int? Units { get; set; }
        public int? Extqty { get; set; }
        public double? Costprice { get; set; }
        public int? Reorderlevel { get; set; }
        public DateTime? Manufacturedate { get; set; }
        public int? Quantity { get; set; }
        public string Unitofstorage { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
    }
}
