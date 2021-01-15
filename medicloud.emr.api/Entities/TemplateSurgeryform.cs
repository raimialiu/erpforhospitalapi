using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSurgeryform
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
