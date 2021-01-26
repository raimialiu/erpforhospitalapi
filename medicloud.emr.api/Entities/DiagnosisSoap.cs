using System;
using System.Collections.Generic;

namespace medicloud.emr.api
{
    public partial class DiagnosisSoap
    {
        public int Soapid { get; set; }
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string Plans { get; set; }
        public int? Providerid { get; set; }
        public int? Locationid { get; set; }
        public int? Encounterid { get; set; }
        public string Patientid { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
