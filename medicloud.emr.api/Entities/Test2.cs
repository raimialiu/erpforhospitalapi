using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Test2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
