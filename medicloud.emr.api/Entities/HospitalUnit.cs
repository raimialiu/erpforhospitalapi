using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class HospitalUnit
    {
        public HospitalUnit()
        {
            PatientQueue = new HashSet<PatientQueue>();
        }

        public int HospitalUnitId { get; set; }
        public string HospitalUnitName { get; set; }
        public virtual ICollection<PatientQueue> PatientQueue { get; set; }
    }
}
