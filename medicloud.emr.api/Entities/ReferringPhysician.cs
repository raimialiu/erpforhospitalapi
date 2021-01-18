using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.Entities
{
    public partial class ReferringPhysician
    {
        [Key]
        public int Refid { get; set; }
        public string Physicianname { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
