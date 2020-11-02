using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class MedicalProblemItem
    {
        public MedicalProblemItem()
        {
            PatientMedicalHistory = new HashSet<PatientMedicalHistory>();
        }

        public int Itemid { get; set; }
        public int? Medid { get; set; }
        public string Itemname { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual MedicalProblemCategory Med { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistory { get; set; }
    }
}
