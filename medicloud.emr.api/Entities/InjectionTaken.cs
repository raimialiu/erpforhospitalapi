using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class InjectionTaken
    {
        public int Injid { get; set; }
        public string Patientid { get; set; }
        public int Consultationid { get; set; }
        public string Injname { get; set; }
        public int QtyTaken { get; set; }
        public int QtyLeft { get; set; }
        public DateTime Datetaken { get; set; }
        public string Administeredby { get; set; }
    }
}
