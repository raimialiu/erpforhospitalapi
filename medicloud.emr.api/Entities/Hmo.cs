using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Hmo
    {
        public Hmo()
        {
            Authorisation = new HashSet<Authorisation>();
            HmoMonthlyList = new HashSet<HmoMonthlyList>();
            Insurance = new HashSet<Insurance>();
        }

        public int Hmoid { get; set; }
        public string Hmoname { get; set; }
        public string Hmoaddress { get; set; }
        public int? Stateid { get; set; }
        public string Hmocountry { get; set; }
        public string Hmocontact { get; set; }
        public string Hmophone1 { get; set; }
        public string Hmophone2 { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Email { get; set; }
        public int? Typeid { get; set; }
        public string Hmonumber { get; set; }

        public virtual State State { get; set; }
        public virtual HmoType Type { get; set; }
        public virtual ICollection<Authorisation> Authorisation { get; set; }
        public virtual ICollection<HmoMonthlyList> HmoMonthlyList { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
    }
}
