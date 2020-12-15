﻿using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationOtherDiagnosis
    {
        public int Txnkey { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public string Otherdiagnosis { get; set; }
        public string Status { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual Consultation Consultation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
