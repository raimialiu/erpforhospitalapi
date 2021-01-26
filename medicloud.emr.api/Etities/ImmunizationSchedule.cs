using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    [Table("Immunization_Schedule")]
    public partial class ImmunizationSchedule
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Scheduleid { get; set; }
        public int? Providerid { get; set; }
        public int? Immunizationid { get; set; }
        public int? Agefrom1 { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public string Agefromtype1 { get; set; }
        public int? Ageto1 { get; set; }
        public string Agetotype1 { get; set; }
        public int? Daysfrom { get; set; }
        public int? Daysto { get; set; }
    }
}
