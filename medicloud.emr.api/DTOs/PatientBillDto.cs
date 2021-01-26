using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PatientBillDto
    {
        public string patientname { get; set; }
        public int encounterid { get; set; }
        public int billid { get; set; }
        public string patientAccountCategory { get; set; }
        public DateTime encounterdate { get; set; }
        public decimal totaloutstanding { get; set; }
        public decimal totalbilledamount { get; set; }
        public List<BillingInvoiceDto> invoices { get; set; }
    }
}
