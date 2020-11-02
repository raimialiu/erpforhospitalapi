using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationRadiology
    {
        public int Labkey { get; set; }
        public int? Consultationid { get; set; }
        public string Patientid { get; set; }
        public string Labserviceid { get; set; }
        public string Arrivaltime { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public string Departuretime { get; set; }
        public int? Deptid { get; set; }
        public string Patienttype { get; set; }
        public string Labnotes { get; set; }
        public bool? Isdocattached { get; set; }
        public string Docname { get; set; }
        public string Docpath { get; set; }
        public DateTime? Labdate { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
    }
}
