using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugDispense
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UtilizationId { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Utilization Utilization { get; set; }
    }
}
