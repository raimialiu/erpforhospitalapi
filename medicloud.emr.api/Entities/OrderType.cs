using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class OrderType
    {
        public OrderType()
        {
            OrderCategory = new HashSet<OrderCategory>();
            OrderListing = new HashSet<OrderListing>();
            PatientOrder = new HashSet<PatientOrder>();
        }

        public int Ordertypeid { get; set; }
        public string Ordername { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<OrderCategory> OrderCategory { get; set; }
        public virtual ICollection<OrderListing> OrderListing { get; set; }
        public virtual ICollection<PatientOrder> PatientOrder { get; set; }
    }
}
