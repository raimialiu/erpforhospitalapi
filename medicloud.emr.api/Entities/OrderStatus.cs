using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            PatientOrder = new HashSet<PatientOrder>();
        }

        public int Orderstatusid { get; set; }
        public string Orderstatus1 { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<PatientOrder> PatientOrder { get; set; }
    }
}
