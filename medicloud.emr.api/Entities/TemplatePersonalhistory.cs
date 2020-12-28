using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePersonalhistory
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Smoking { get; set; }
        public string Alcoholconsumption { get; set; }
        public string Othershabits { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
