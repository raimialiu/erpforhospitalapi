using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSurgeonsnotes
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Timein { get; set; }
        public string Preopdiagnosis { get; set; }
        public string Postopdiagnosis { get; set; }
        public string Procedurestarttime { get; set; }
        public string Procedureendtime { get; set; }
        public string Proceduredone { get; set; }
        public string Nameofprocedure { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
