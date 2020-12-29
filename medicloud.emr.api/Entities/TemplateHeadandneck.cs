using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateHeadandneck
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Headandneck { get; set; }
        public string Asymmetry { get; set; }
        public string Caputandcephalhaematorna { get; set; }
        public string Fontanelles { get; set; }
        public string Sutures { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
