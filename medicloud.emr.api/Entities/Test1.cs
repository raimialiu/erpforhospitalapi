using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Test1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
