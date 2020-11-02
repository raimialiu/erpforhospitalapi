using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugOrders
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int? CreatedAt { get; set; }
        public int? AdminHandler { get; set; }
        public bool? IsAdminApproved { get; set; }
        public DateTime? AdminTime { get; set; }
        public int? PharmacyHandler { get; set; }
        public bool? IsPharmayHandled { get; set; }
        public DateTime? PharmacyTime { get; set; }
        public int? Quantity { get; set; }
        public int? OrderSupplierId { get; set; }
        public bool? IsAdminHandled { get; set; }
        public string AdminComment { get; set; }
        public bool? IsPharmacyConcluded { get; set; }
        public string RequisitionNumber { get; set; }

        public virtual Personnel AdminHandlerNavigation { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual Supplier OrderSupplier { get; set; }
        public virtual Personnel PharmacyHandlerNavigation { get; set; }
    }
}
