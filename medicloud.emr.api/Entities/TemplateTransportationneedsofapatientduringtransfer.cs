using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateTransportationneedsofapatientduringtransfer
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Manpowerneeds { get; set; }
        public string Equipmentneeds { get; set; }
        public string Medicationneeds { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
