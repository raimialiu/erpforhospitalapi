using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateRisksituation
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Asaclassification { get; set; }
        public string Euroscoreii { get; set; }
        public string Rachsi { get; set; }
        public string Modifiedchildpugh { get; set; }
        public string Meld { get; set; }
        public string Anaesthesiaissues { get; set; }
        public string Anaesthesiaplan { get; set; }
        public string Pacdoneby { get; set; }
        public string Consultant { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
