using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateMaster
    {
        public int Masterid { get; set; }
        public string Jsonform { get; set; }
        public string Formname { get; set; }
        public string Formdescription { get; set; }
        public string Formcomments { get; set; }
        public int? Tempcatid { get; set; }
        public int? Adjusterid { get; set; }
        public int? Accountid { get; set; }
        public bool? Iscurrent { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Locationid { get; set; }
    }
}
