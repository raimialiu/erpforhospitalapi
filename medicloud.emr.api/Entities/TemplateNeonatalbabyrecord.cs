using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateNeonatalbabyrecord
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Motherstest { get; set; }
        public string Columns5 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
