using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ConsultationLaboratory
    {
        public int Labkey { get; set; }
        public int? Consultationid { get; set; }
        public string Patientid { get; set; }
        public int? Patientorderid { get; set; }
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
        public bool? Isexternal { get; set; }
        public int? ProviderId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual PatientOrder Patientorder { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
