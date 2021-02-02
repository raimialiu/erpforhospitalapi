using medicloud.emr.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class BillingInvoiceDto
    {
        public int billid { get; set; }
        public string patientid { get; set; }
        public string patientname { get; set; }
        public int? encounterId { get; set; }
        public string servicecode { get; set; }
        public string Servicename { get; set; }
        public int? payortypeid { get; set; }
        public int? sponsorid { get; set; }
        public int? plantypeid { get; set; }
        public int? tariffid { get; set; }
        public int? billtypeid { get; set; }
        public decimal? billamount { get; set; }
        public decimal? Outstanding { get; set; }
        public double discount { get; set; }
        public decimal copay { get; set; }
        public decimal? amounttopay { get; set; }
        public bool isadjusted { get; set; }
        public int? adjusterid { get; set; }
        public DateTime? billdate { get; set; }
        public string panumber { get; set; }
        public bool isbilledclosed { get; set; }
        public string alternatecode { get; set; }
        public string comments { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
        public DateTime? dateadded { get; set; }
        public decimal? unitcharge { get; set; }
        public int? unit { get; set; }
        public PayerDto payer { get; set; }
        public Sponsor sponsor { get; set; }
    }

    public class BillingInvoicePaymentByPaDto
    {
        public List<int> billid { get; set; }
        public string patientid { get; set; }
        public int? encounterId { get; set; }
        public decimal? amountpaid { get; set; }
        public string panumber { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
    }
}
