using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            Patient = new HashSet<Patient>();
        }

        public int Genderid { get; set; }
        public string Gendername { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
