using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DentalProcedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
