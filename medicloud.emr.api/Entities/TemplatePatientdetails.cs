using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePatientdetails
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Pregnancybreastfeedingstatus { get; set; }
        public string Edd { get; set; }
        public string Familyplanningwritecode { get; set; }
        public string Functionalstatus { get; set; }
        public string Whoclinicalstage { get; set; }
        public string Tbstatus { get; set; }
        public string Otheroisproblem { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
