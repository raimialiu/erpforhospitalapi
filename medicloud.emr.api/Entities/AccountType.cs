using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AccountType
    {
        public AccountType()
        {
            Bill = new HashSet<Bill>();
        }

        public int Accttypeid { get; set; }
        public string Accttypedesc { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Bill> Bill { get; set; }
    }
}
