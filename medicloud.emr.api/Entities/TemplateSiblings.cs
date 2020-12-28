using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSiblings
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Bysamemother { get; set; }
        public string Familyhistoryofillness { get; set; }
        public string Disease { get; set; }
        public string Maritalstatus { get; set; }
        public string Howlongmarried { get; set; }
        public string Age { get; set; }
        public string Maritalstatus1 { get; set; }
        public string Previousoccupation { get; set; }
        public string Health { get; set; }
        public string Domesticsituation { get; set; }
        public string Children { get; set; }
        public string Age1 { get; set; }
        public string Gender { get; set; }
        public string Pastillnessandinjuries { get; set; }
        public string Presentconditionandcomplaints { get; set; }
        public string Currenttreatment { get; set; }
        public string Lastsawadoctoron { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
