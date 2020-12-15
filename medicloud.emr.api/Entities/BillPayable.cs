using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class BillPayable
    {
        public int Billpayableid { get; set; }
        public int? Billid { get; set; }
        public double? Billamount { get; set; }
        public string Patientid { get; set; }
        public double? Discount { get; set; }
        public double? Amountpaid { get; set; }
        public string Amountinwords { get; set; }
        public double? Balance { get; set; }
        public string Trfno { get; set; }
        public int? Staffid { get; set; }
        public DateTime? Txndate { get; set; }
        public int? ProviderId { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Staff { get; set; }
    }
}
