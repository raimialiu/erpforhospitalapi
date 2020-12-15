using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DependantInfo
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Value { get; set; }
        public string Relationship { get; set; }
        public int? Enrolleeid { get; set; }

        public virtual Enrollee Enrollee { get; set; }
    }
}
