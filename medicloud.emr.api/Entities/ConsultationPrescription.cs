using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationPrescription
    {
        public int Txnkey { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public string Drugcode { get; set; }
        public string Drugtype { get; set; }
        public string Drugstrength { get; set; }
        public bool? Isdocattached { get; set; }
        public string Docname { get; set; }
        public string Docpath { get; set; }
        public int? ProviderId { get; set; }
        public string Quantity { get; set; }
        public string Units { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public int? Duration { get; set; }
        public string Prescriptionnotes { get; set; }
        public bool? Isdispensed { get; set; }
        public bool? Isundispensed { get; set; }
        public DateTime? Dispensedate { get; set; }
        public string Dispensenotes { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Injectionflow { get; set; }

        public virtual Consultation Consultation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
