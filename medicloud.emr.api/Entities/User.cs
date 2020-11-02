using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class User
    {
        public User()
        {
            AccesscontrolUser = new HashSet<AccesscontrolUser>();
            CaseNote = new HashSet<CaseNote>();
            Claims = new HashSet<Claims>();
            DataSynchronization = new HashSet<DataSynchronization>();
            DrugDispense = new HashSet<DrugDispense>();
            Enrollee = new HashSet<Enrollee>();
            ProviderChange = new HashSet<ProviderChange>();
            Renewal = new HashSet<Renewal>();
            Utilization = new HashSet<Utilization>();
            VerificationLog = new HashSet<VerificationLog>();
        }

        public int IdU { get; set; }
        public string FirstnameU { get; set; }
        public string LastnameU { get; set; }
        public string OthernameU { get; set; }
        public string GenderU { get; set; }
        public DateTime? DobU { get; set; }
        public string TitleU { get; set; }
        public string Addressline1U { get; set; }
        public string Addressline2U { get; set; }
        public string PhoneU { get; set; }
        public string EmailU { get; set; }
        public string UsernameU { get; set; }
        public string PasswordU { get; set; }
        public int? Providerid { get; set; }
        public int? Departmetid { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<AccesscontrolUser> AccesscontrolUser { get; set; }
        public virtual ICollection<CaseNote> CaseNote { get; set; }
        public virtual ICollection<Claims> Claims { get; set; }
        public virtual ICollection<DataSynchronization> DataSynchronization { get; set; }
        public virtual ICollection<DrugDispense> DrugDispense { get; set; }
        public virtual ICollection<Enrollee> Enrollee { get; set; }
        public virtual ICollection<ProviderChange> ProviderChange { get; set; }
        public virtual ICollection<Renewal> Renewal { get; set; }
        public virtual ICollection<Utilization> Utilization { get; set; }
        public virtual ICollection<VerificationLog> VerificationLog { get; set; }
    }
}
