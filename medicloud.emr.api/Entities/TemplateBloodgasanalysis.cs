using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateBloodgasanalysis
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Template { get; set; }
        public string Sesionlists { get; set; }
        public string Addnewsession { get; set; }
        public string Resultsets { get; set; }
        public string Deleteresultset { get; set; }
        public string Patienttemplate { get; set; }
        public string Columns { get; set; }
        public string Columns1 { get; set; }
        public string Addnewrecord { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
