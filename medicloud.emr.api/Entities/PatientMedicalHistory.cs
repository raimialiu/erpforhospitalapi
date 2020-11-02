using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class PatientMedicalHistory
    {
        public int Pid { get; set; }
        public string Patientid { get; set; }
        public int? Problemid { get; set; }
        public string Problemdesc { get; set; }
        public DateTime? Datestart { get; set; }
        public DateTime? Dateend { get; set; }
        public string Status { get; set; }
        public string Occurence { get; set; }
        public string Diagnosiscode { get; set; }
        public string Reaction { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual MedicalProblemItem Problem { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
