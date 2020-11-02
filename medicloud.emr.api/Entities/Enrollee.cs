using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Enrollee
    {
        public Enrollee()
        {
            Claims = new HashSet<Claims>();
            DependantInfo = new HashSet<DependantInfo>();
            ProviderChange = new HashSet<ProviderChange>();
            Renewal = new HashSet<Renewal>();
            Utilization = new HashSet<Utilization>();
        }

        public int IdE { get; set; }
        public string FirstnameE { get; set; }
        public string LastnameE { get; set; }
        public string OthernameE { get; set; }
        public string TitleE { get; set; }
        public string GenderE { get; set; }
        public string Addressline1E { get; set; }
        public string Addressline2E { get; set; }
        public DateTime? DobE { get; set; }
        public string Maritalstatus { get; set; }
        public string PhoneE { get; set; }
        public DateTime? Coveragestartdate { get; set; }
        public DateTime? Coverageenddate { get; set; }
        public DateTime? Effectivedate { get; set; }
        public DateTime? Terminationdate { get; set; }
        public DateTime? Planeffectivedate { get; set; }
        public DateTime? Planterminationdate { get; set; }
        public DateTime? Providereffectivedate { get; set; }
        public DateTime? Providerterminationdate { get; set; }
        public string Occupation { get; set; }
        public string Hmocode1 { get; set; }
        public string Hmocode2 { get; set; }
        public string Hmocode3 { get; set; }
        public string PrincipalCode { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Market { get; set; }
        public string ProviderReason { get; set; }
        public string Nextofkin { get; set; }
        public string Nextofkinaddress { get; set; }
        public string Nextofkinphone { get; set; }
        public DateTime? Dateenrolleed { get; set; }
        public DateTime? Formreceiveddate { get; set; }
        public DateTime? Formprocesseddate { get; set; }
        public string Receiptnum { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Syncid { get; set; }
        public string Flag { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncAt { get; set; }
        public int? Plainid { get; set; }
        public int? Providerid { get; set; }
        public int? Networkid { get; set; }
        public int? Userid { get; set; }
        public int? Groupid { get; set; }
        public int? Enrolleetypeid { get; set; }
        public int? Divisionid { get; set; }
        public string Officeaddress { get; set; }
        public string Officecity { get; set; }
        public string OfficeLga { get; set; }
        public string Officestate { get; set; }
        public string Cardnumber { get; set; }

        public virtual Division Division { get; set; }
        public virtual EnrolleeType Enrolleetype { get; set; }
        public virtual Group Group { get; set; }
        public virtual Network Network { get; set; }
        public virtual Plan Plain { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Claims> Claims { get; set; }
        public virtual ICollection<DependantInfo> DependantInfo { get; set; }
        public virtual ICollection<ProviderChange> ProviderChange { get; set; }
        public virtual ICollection<Renewal> Renewal { get; set; }
        public virtual ICollection<Utilization> Utilization { get; set; }
    }
}
