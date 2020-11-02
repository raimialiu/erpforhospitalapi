using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Appointment
    {
        public int Appointmentid { get; set; }
        public string Patientid { get; set; }
        public int? Deptid { get; set; }
        public int? Staffid { get; set; }
        public DateTime? Appointmentdate { get; set; }
        public string Appointmenttime { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public DateTime? Appointmentenddate { get; set; }
        public string Subject { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Locationid { get; set; }
        public int? Accountid { get; set; }
        public string Reasonforvisit { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Personnel Staff { get; set; }
    }
}
