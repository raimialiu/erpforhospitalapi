using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ReceivingStore
    {
        public int Receivingstoreid { get; set; }
        public string Storename { get; set; }
        public string Storedescription { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
    }
}
