using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AccountCategory
    {
        public int Accountcatid { get; set; }
        public string Accountcattype { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
