using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    public partial class EmrproblemsLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public bool? IsActive { get; set; }
        public int? EncodedBy { get; set; }
        public DateTime? EncodedDate { get; set; }
        public int? LastChangedBy { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public int? Sequenceno { get; set; }
        public string description { get; set; }
    }
}
