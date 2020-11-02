using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateCategory
    {
        public int Tempcatid { get; set; }
        public string Categoryname { get; set; }
        public int? Specializationid { get; set; }
        public int? Accountid { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
