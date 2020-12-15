using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Clinic
    {
        public int Clinicid { get; set; }
        public string Clinicname { get; set; }
        public string Contactperson { get; set; }
        public string Contactphone { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
