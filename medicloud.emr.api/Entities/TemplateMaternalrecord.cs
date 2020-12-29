using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateMaternalrecord
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Mothersname { get; set; }
        public string Dateofbirth { get; set; }
        public string Hospitalnumber { get; set; }
        public string Dateofadmission { get; set; }
        public string Booked { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
