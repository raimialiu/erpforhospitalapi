using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ProviderNetwork
    {
        public int Providerid { get; set; }
        public int Networkid { get; set; }

        public virtual Provider Provider { get; set; }
    }
}
