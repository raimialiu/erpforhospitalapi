using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePsychological
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Anxious { get; set; }
        public string Radio1 { get; set; }
        public string Angry { get; set; }
        public string Suicidal { get; set; }
        public string Homicidal { get; set; }
        public string Other { get; set; }
        public string Columns { get; set; }
        public string Columns1 { get; set; }
        public string Normal { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
