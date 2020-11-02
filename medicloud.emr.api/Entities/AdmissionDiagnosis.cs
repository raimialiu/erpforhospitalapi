using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AdmissionDiagnosis
    {
        public int Id { get; set; }
        public int? Admissionid { get; set; }
        public string Diagnosiscode { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Admission Admission { get; set; }
    }
}
