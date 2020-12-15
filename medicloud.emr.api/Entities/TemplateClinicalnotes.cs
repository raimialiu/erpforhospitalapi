﻿using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateClinicalnotes
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Painscore { get; set; }
        public string Clinicalnotes { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
