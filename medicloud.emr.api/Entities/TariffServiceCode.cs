using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class TariffServiceCode
    {
        public int tariffserviceid { get; set; }
        public int? serviceid { get; set; }
        public int? drugid { get; set; }
        public int? tariffid { get; set; }
        public decimal? tariffamount { get; set; }
        public decimal? premiumtariffamount { get; set; }
        public int? alternatecode { get; set; }
        public string comments { get; set; }
        public int? locationid { get; set; }
        public DateTime? dateadded { get; set; }
    }
}
