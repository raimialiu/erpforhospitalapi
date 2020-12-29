﻿using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePreproceduralvitals
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Bloodpressure { get; set; }
        public string Pulserate { get; set; }
        public string Respiratoryrate { get; set; }
        public string Time { get; set; }
        public string Oxygensaturationonroomair { get; set; }
        public string Levelofconsciousness { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
