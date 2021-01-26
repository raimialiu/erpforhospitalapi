using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public partial class Vital
    {
        public int Id { get; set; }
        public string patientid { get; set; }
        public int encounterId { get; set; }
        public DateTime vitalentrydate { get; set; }
        public int vitalid { get; set; }
        public int enteredunitid1 { get; set; }
        public int convertedunitid { get; set; }
        public int billable { get; set; }
        public string remarks { get; set; }
        public int isactive { get; set; }
        public int encodedby { get; set; }
        public DateTime encodeddate { get; set; }
        public int templatefieldid { get; set; }
    }
}
