using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateMedicalhistory
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Cardiaccard { get; set; }
        public string Cardiaccard1 { get; set; }
        public string Cardiaccard2 { get; set; }
        public string Cardiaccard3 { get; set; }
        public string Cardiaccard4 { get; set; }
        public string Cardiaccard5 { get; set; }
        public string Cardiaccard6 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
