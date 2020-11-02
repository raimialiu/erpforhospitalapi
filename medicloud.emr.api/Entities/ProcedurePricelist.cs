using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ProcedurePricelist
    {
        public int Id { get; set; }
        public int Hmoid { get; set; }
        public string Procedurename { get; set; }
        public string Price { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
