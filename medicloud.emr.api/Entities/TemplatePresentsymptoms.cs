using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplatePresentsymptoms
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Cough { get; set; }
        public string Suptum { get; set; }
        public string Dyspnoea { get; set; }
        public string Chestpain { get; set; }
        public string Claudication { get; set; }
        public string Dyspepsia { get; set; }
        public string Appetite { get; set; }
        public string Boweels { get; set; }
        public string Anal { get; set; }
        public string Weight { get; set; }
        public string Mict { get; set; }
        public string Fatigue { get; set; }
        public string Headache { get; set; }
        public string Backache { get; set; }
        public string Muscskeletalpain { get; set; }
        public string Eyesight { get; set; }
        public string Deafness { get; set; }
        public string Teeth { get; set; }
        public string Veins { get; set; }
        public string Gynacc { get; set; }
        public string Sleep { get; set; }
        public string Spousessleep { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
