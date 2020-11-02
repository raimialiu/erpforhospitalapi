using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Authorisation
    {
        public int Authorisationid { get; set; }
        public string Authorisationcode { get; set; }
        public string Approvallist { get; set; }
        public string Procedurecodes { get; set; }
        public int? Hmoid { get; set; }
        public string Patientid { get; set; }
        public string Nameofapprover { get; set; }
        public string Treatmentoption { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Hmo Hmo { get; set; }
    }
}
