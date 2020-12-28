using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateNutritioncareplan
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Clienthistory { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Bmi { get; set; }
        public string Muac { get; set; }
        public string Waistcircumference { get; set; }
        public string Agebodyfat { get; set; }
        public string Agevisceralfat { get; set; }
        public string Skeletalmusclefat { get; set; }
        public string Bp { get; set; }
        public string Textarea1 { get; set; }
        public string Textarea2 { get; set; }
        public string Teethandgum { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
