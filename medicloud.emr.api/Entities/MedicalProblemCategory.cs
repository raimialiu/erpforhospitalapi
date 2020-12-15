using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class MedicalProblemCategory
    {
        public MedicalProblemCategory()
        {
            MedicalProblemItem = new HashSet<MedicalProblemItem>();
        }

        public int Medid { get; set; }
        public string Problemtype { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<MedicalProblemItem> MedicalProblemItem { get; set; }
    }
}
