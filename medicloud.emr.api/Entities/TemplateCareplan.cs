using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateCareplan
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Domain { get; set; }
        public string Diagnosis { get; set; }
        public string Objective { get; set; }
        public string Intervention { get; set; }
        public string Evaluation { get; set; }
        public string Remarks { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
