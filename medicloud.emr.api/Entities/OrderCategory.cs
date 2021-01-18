using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class OrderCategory
    {
        public OrderCategory()
        {
            OrderListing = new HashSet<OrderListing>();
            PatientOrder = new HashSet<PatientOrder>();
        }

        public int Ordercategoryid { get; set; }
        public int? ProviderID { get; set; }
        public int? Ordertypeid { get; set; }
        public string Ordercategory1 { get; set; }
        public string Categorycomment { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual OrderType Ordertype { get; set; }
        public virtual ICollection<OrderListing> OrderListing { get; set; }
        public virtual ICollection<PatientOrder> PatientOrder { get; set; }
    }
}
