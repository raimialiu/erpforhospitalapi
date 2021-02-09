using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class TarriffPlan
    {
        public int plantariffid { get; set; }
        public int? planid { get; set; }
        public int? tariffid { get; set; }
        public int? drugtariffid { get; set; }
        public string tariffplandescription { get; set; }
        public string alternatecode { get; set; }
        public string comments { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
        public DateTime? dateadded { get; set; }
    }
}
