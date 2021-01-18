using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateTimeoutbeforestartofsurgicalintervention
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Timeofpatientcall { get; set; }
        public string Haveallteammembersintroducedthemselvesbynameandrole { get; set; }
        public string Surgeonanaesthetistandregisteredpractitionerverballyconfirmwhatispatientname { get; set; }
        public string Surgeonanaesthetistandregisteredpractitionerverballyconfirmwhatproceduresiteandpositionareplanned { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
