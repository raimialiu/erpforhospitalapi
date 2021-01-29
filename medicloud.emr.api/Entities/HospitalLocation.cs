using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class HospitalLocation
    {
        public HospitalLocation()
        {
            CheckIn = new HashSet<CheckIn>();
            DiagSampleOplabMain = new HashSet<DiagSampleOplabMain>();
            //DiagnosisProblems = new HashSet<DiagnosisProblems>();
            //EmrFrequencyDetail = new HashSet<EmrFrequencyDetail>();
            //EmrVitalSignTypes = new HashSet<EmrVitalSignTypes>();
            //EmrVitalUnitMaster = new HashSet<EmrVitalUnitMaster>();
            //EmrpatientImmunizationDetail = new HashSet<EmrpatientImmunizationDetail>();
            //EmrproblemDuration = new HashSet<EmrproblemDuration>();
            //EntrySiteMaster = new HashSet<EntrySiteMaster>();
            //Invoice = new HashSet<Invoice>();
            Patient = new HashSet<Patient>();
            ////PhrItemMaster = new HashSet<PhrItemMaster>();
            ////PrescriptionMain = new HashSet<PrescriptionMain>();
            ////ServiceorderMain = new HashSet<ServiceorderMain>();
        }

        public int Hospitallocationid { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public virtual ICollection<CheckIn> CheckIn { get; set; }
        //public virtual ICollection<ChiefComplain> ChiefComplain { get; set; }
        //public virtual ICollection<DiagEntrySite> DiagEntrySite { get; set; }
        public virtual ICollection<DiagSampleOplabMain> DiagSampleOplabMain { get; set; }
        //public virtual ICollection<DiagnosisProblems> DiagnosisProblems { get; set; }
        //public virtual ICollection<EmrFrequencyDetail> EmrFrequencyDetail { get; set; }
        //public virtual ICollection<EmrVitalSignTypes> EmrVitalSignTypes { get; set; }
        //public virtual ICollection<EmrVitalUnitMaster> EmrVitalUnitMaster { get; set; }
        //public virtual ICollection<EmrpatientImmunizationDetail> EmrpatientImmunizationDetail { get; set; }
        //public virtual ICollection<EmrproblemDuration> EmrproblemDuration { get; set; }
        //public virtual ICollection<EntrySiteMaster> EntrySiteMaster { get; set; }
        //public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
        //public virtual ICollection<PhrItemMaster> PhrItemMaster { get; set; }
        //public virtual ICollection<PrescriptionMain> PrescriptionMain { get; set; }
        //public virtual ICollection<ServiceorderMain> ServiceorderMain { get; set; }
    }
}
