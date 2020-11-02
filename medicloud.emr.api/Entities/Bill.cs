using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Bill
    {
        public Bill()
        {
            BillPayable = new HashSet<BillPayable>();
        }

        public int Billid { get; set; }
        public string Patientid { get; set; }
        public int? Staffid { get; set; }
        public int? Consultationid { get; set; }
        public double? Consultationfee { get; set; }
        public bool? Paymentconfirmed { get; set; }
        public int? Accounttypeid { get; set; }
        public int? Tariffid { get; set; }
        public string Batchno { get; set; }
        public DateTime? Billdate { get; set; }
        public string Comments { get; set; }
        public DateTime? Billclosedate { get; set; }
        public int? ProviderId { get; set; }
        public bool? IsHmopayment { get; set; }

        public virtual AccountType Accounttype { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Staff { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual ICollection<BillPayable> BillPayable { get; set; }
    }
}
