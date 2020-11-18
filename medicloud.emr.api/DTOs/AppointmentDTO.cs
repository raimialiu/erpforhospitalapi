using System;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.DTOs
{

    public class Schedule
    {
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public int Duration { get; set; }
        public string Adjuster { get; set; }
        public bool Iscurrent { get; set; }
        public DateTime Dateadded { get; set; }
        public string Locationname { get; set; }
    }

    public class GenSchedule : Schedule
    {
        public int Genschid { get; set; }
    }
    public class GenSchCreate
    {
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        [Range(1, 120)]
        public int Duration { get; set; }
        [Required]
        public string Adjuster { get; set; }
        [Range(3,5)]
        public int LocationId { get; set; }
    }

    public class SpecSchCreate : GenSchCreate
    {
        [Required]
        public string Days { get; set; }
        public int SpecId { get; set; }
    }

    public class SpecSchedule : Schedule
    {
        public int Specschid { get; set; }
        public string Days { get; set; }
        public string Specname { get; set; }
    }

    public class ProvSchCreate : SpecSchCreate
    {
        public int ProvId { get; set; }
    }

    public class ProvSchedule : Schedule
    {
        public int Provschid { get; set; }
        public string Days { get; set; }
        public string Specname { get; set; }
        public string Providername { get; set; }
        public int Provid { get; set; }
    }

    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
