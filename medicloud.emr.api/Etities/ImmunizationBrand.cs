using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{

    [Table("Immunization_Brand")]
    public partial class ImmunizationBrand
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Brandid { get; set; }
        public int? Immunizationid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public string brandname { get; set; }
    }
}
