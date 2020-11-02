using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class BillDetail
    {
        public int Billdetailid { get; set; }
        public int? Billid { get; set; }
        public string Serviceid { get; set; }
        public string Servicedesc { get; set; }
        public double? Amount { get; set; }
        public string Servicetype { get; set; }
        public int? Deptid { get; set; }
        public string Comments { get; set; }
        public string Billtype { get; set; }
        public DateTime? Dateofservice { get; set; }
        public int? ProviderId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
