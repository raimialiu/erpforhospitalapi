using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugFoodrelation
    {
        public int Foodid { get; set; }
        public string FoodName { get; set; }
        public int? ProviderId { get; set; }
        public int? LocationId { get; set; }
        public bool? IsActive { get; set; }
        public int? EncodedBy { get; set; }
        public DateTime? EncodedDate { get; set; }
        public int? LastChangedBy { get; set; }
        public DateTime? LastChangedDate { get; set; }

        public virtual Location Location { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
