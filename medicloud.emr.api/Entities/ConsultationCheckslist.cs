using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationCheckslist
    {
        public int Id { get; set; }
        public string Cclname { get; set; }
        public int? Ccltypeid { get; set; }

        public virtual ConsultationChecks Ccltype { get; set; }
    }
}
