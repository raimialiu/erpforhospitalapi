using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class BillingInvoice
    {
        public int billid { get; set; }
        public string patientid { get; set; }
        public int? encounterId { get; set; }
        public int? diagnosisid { get; set; }
        public string servicecode { get; set; }
        public int? payortypeid { get; set; }
        public int? sponsorid { get; set; }
        public int? plantypeid { get; set; }
        public int? tariffid { get; set; }
        public int? billtypeid { get; set; }
        public decimal? billamount { get; set; }
        public double discount { get; set; }
        public decimal copay { get; set; }
        public decimal? amounttopay { get; set; }
        public decimal? unitcharge { get; set; }
        public bool isadjusted { get; set; }
        public bool settouseprivatetariff { get; set; }
        public int? adjusterid { get; set; }
        public DateTime? billdate { get; set; }
        public string panumber { get; set; }
        public bool isbilledclosed { get; set; }
        public bool ishmoclaim { get; set; }
        public string alternatecode { get; set; }
        public string comments { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
        public int? unit { get; set; }
        public int? drugid { get; set; }
        public int? encodedby { get; set; }
        public DateTime? dateadded { get; set; }
    }
}
