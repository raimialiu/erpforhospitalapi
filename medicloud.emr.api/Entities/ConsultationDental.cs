using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationDental
    {
        public int Txnkey { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public int? ProviderId { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Extraoralexamfa { get; set; }
        public string Extraoralexamtmj { get; set; }
        public string Extraoralexamswe { get; set; }
        public string Extraoralexamlav { get; set; }
        public string Intraoralexamtris { get; set; }
        public string Intraoralexamoralhyj { get; set; }
        public string Intraoralexamgingivae { get; set; }
        public string Tp { get; set; }
        public string Ct { get; set; }
        public string Ft { get; set; }
        public string Dt { get; set; }
        public string Ttp { get; set; }
        public string Displacement { get; set; }
        public string Treatmentplan { get; set; }
        public string Treatmentdone { get; set; }

        public virtual Consultation Consultation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
