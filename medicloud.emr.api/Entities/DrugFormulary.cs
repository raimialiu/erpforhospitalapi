using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    [Table("Drug_Formulary")]
    public partial class DrugFormulary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Formularyid { get; set; }
        public string Formularyname { get; set; }
        public int? ProviderId { get; set; }
        public DateTime? Dateadded { get; set; }
        public bool? Isactive { get; set; }
    }
}
