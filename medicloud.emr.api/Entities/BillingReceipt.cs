using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class BillingReceipt
    {
        public int receiptid { get; set; }
        public string patientid { get; set; }
        public int? encounterId { get; set; }
        public int? billid { get; set; }
        public decimal openingbalance { get; set; }
        public decimal creditamount { get; set; }
        public decimal closingbalance { get; set; }
        public int? credittypeid { get; set; }
        public int? plantypeid { get; set; }
        public int? tariffid { get; set; }
        public int? adjusterid { get; set; }
        public DateTime? receiptdate { get; set; }
        public string comments { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
        public DateTime? dateadded { get; set; }
    }
}
