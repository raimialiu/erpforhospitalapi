using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateLscs
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Lscs { get; set; }
        public string Indicationoflscs { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
