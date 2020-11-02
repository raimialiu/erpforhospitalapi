using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugPricelist
    {
        public int Id { get; set; }
        public int Hmoid { get; set; }
        public string Drugname { get; set; }
        public string Price { get; set; }
        public DateTime Datetadded { get; set; }
    }
}
