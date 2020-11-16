using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateBiodata
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Patientname { get; set; }
        public string Hospitalnumber { get; set; }
        public string Dateofbirth { get; set; }
        public string Datetime { get; set; }
        public string Columns { get; set; }
        public string Columns1 { get; set; }
        public string Submit { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
