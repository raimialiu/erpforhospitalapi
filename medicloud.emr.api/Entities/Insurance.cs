using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Insurance
    {
        public int Insuranceid { get; set; }
        public string Patientid { get; set; }
        public string Insurancetype { get; set; }
        public int? Hmoid { get; set; }
        public string Planname { get; set; }
        public DateTime? Effectivedate { get; set; }
        public string Hmonumber { get; set; }
        public string Employername { get; set; }
        public string Employeraddress { get; set; }
        public int? Stateid { get; set; }
        public string Employercountry { get; set; }
        public string Relationship { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Hmo Hmo { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual State State { get; set; }
    }
}
