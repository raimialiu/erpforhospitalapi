using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class OrderListing
    {
        public OrderListing()
        {
            PatientOrder = new HashSet<PatientOrder>();
        }

        public int Orderlistid { get; set; }
        public int? Ordertypeid { get; set; }
        public int? ProviderID { get; set; }
        public string Ordertype { get; set; }
        public string Orderthreshold { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Ordercategoryid { get; set; }

        public virtual OrderCategory Ordercategory { get; set; }
        public virtual OrderType OrdertypeNavigation { get; set; }
        public virtual ICollection<PatientOrder> PatientOrder { get; set; }
    }
}
