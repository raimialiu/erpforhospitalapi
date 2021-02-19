using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class BillingInvoiceHistoryDto
    {
        public string ServiceCategoryName { get; set; }
        public decimal TotalBillCharge { get; set; }
        public double TotalDiscountPercent { get; set; }
        public double TotalDiscountAmount { get; set; }
        public decimal PatientPayable { get; set; }
        public decimal PayerPayable { get; set; }
        public List<BillingInvoiceDto> Invoices { get; set; }
    }

    public class EncounterBillingInvoicesDto
    {
        public int EncounterId { get; set; }
        public DateTime EncounterDate { get; set; }
        public string PatientPayerInfo { get; set; }
        public string BillProvider { get; set; }
        public string Location { get; set; }
        public List<BillingInvoiceHistoryDto> BillingInvoiceHistory { get; set; }
    }
}
