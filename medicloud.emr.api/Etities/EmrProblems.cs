using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    public partial class EmrProblems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string Description { get; set; }
        public string Sctid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
        public int? Doctorid { get; set; }
        public int? Officeproblemid { get; set; }
    }
}
