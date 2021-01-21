using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    [Table("Drug_foodrelation")]
    public partial class DrugFoodrelation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
