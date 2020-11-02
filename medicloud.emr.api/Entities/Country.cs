using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Country
    {
        public Country()
        {
            AccountManager = new HashSet<AccountManager>();
            State = new HashSet<State>();
        }

        public int Countryid { get; set; }
        public string Countryname { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}
