using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class AppointmentDTO
    {
    }

    public class GenSchCreate
    {
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        [Range(1, 120)]
        public int Interval { get; set; }
        [Required]
        public string Adjuster { get; set; }
        [Range(3,5)]
        public int LocationId { get; set; }
    }
}
