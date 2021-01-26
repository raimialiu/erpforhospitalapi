using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    [Table("EMRImmunizationMaster")]
    public partial class EmrimmunizationMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Immunizationid { get; set; }
        public string Immunizationname { get; set; }
        public int? Providerid { get; set; }
        public string Cptcode { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
    }
}
