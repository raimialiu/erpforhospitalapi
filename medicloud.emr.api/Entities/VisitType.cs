using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.Entities
{
    public partial class VisitType
    {
        [Key]
        public int Typeid { get; set; }
        public string Typename { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
