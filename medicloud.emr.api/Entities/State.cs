using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class State
    {
        public State()
        {
            AccountManager = new HashSet<AccountManager>();
            Hmo = new HashSet<Hmo>();
            Insurance = new HashSet<Insurance>();
            Patient = new HashSet<Patient>();
        }

        public int Stateid { get; set; }
        public string Statename { get; set; }
        public int? Countryid { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<Hmo> Hmo { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
