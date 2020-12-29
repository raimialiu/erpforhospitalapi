﻿using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePreproceduralmedications
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Route { get; set; }
        public string Time { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
