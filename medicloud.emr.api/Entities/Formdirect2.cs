using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Formdirect2
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Textfield { get; set; }
        public string Textfield2 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
